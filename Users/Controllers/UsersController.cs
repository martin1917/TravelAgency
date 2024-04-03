using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Users.Data;
using Users.Dto;
using Users.Models;

namespace Users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly Context ctx;
        private readonly IConfiguration cfg;

        public UsersController(Context ctx, IConfiguration cfg)
        {
            this.ctx = ctx;
            this.cfg = cfg;

            ctx.Database.EnsureCreated();
        }

        [HttpGet]
        [Authorize(Roles = "touragent")]
        public IActionResult GetAllClient()
        {
            return Ok(ctx.Clients);
        }

        [HttpGet("{clientId}")]
        [Authorize(Roles = "touragent")]
        public IActionResult GetClientById(long clientId)
        {
            return Ok(ctx.Clients.FirstOrDefault(c => c.Id == clientId));
        }

        [HttpGet("me")]
        [Authorize(Roles = "client")]
        public async Task<IActionResult> GetSelfInfo()
        {
            var authHeader = Request.Headers.Authorization[0];
            var encodedJwt = authHeader["Bearer ".Length..];
            var jwt = new JwtSecurityTokenHandler().ReadJwtToken(encodedJwt);
            var id = long.Parse(jwt.Claims.First(c => c.Type.Equals("id")).Value);
            var client = await ctx.Clients.FirstAsync(c => c.Id == id);
            return Ok(client);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var login = loginDto.Login;
            var password = loginDto.Password;

            var account = await ctx.Accounts.FirstOrDefaultAsync(a => a.Login.Equals(login) && a.Password.Equals(password));
            if (account is null)
            {
                return NotFound("Invalid login or password");
            }

            var id = account.Role switch
            {
                "client" => ctx.Clients.First(c => c.AccountId == account.Id).Id,
                "touragent" => ctx.TourAgents.First(c => c.AccountId == account.Id).Id
            };

            var claims = new List<Claim>
            {
                new Claim("name", login),
                new Claim("role", account.Role),
                new Claim("id", $"{id}"),
            };

            var now = DateTime.UtcNow;

            var claimsIdentity = new ClaimsIdentity(claims, "Token");
            var jwt = new JwtSecurityToken(
                issuer: cfg["JWT_ISSUER"],
                audience: "anyone",
                notBefore: now,
                claims: claims,
                expires: now.Add(TimeSpan.FromHours(double.Parse(cfg["JWT_LIFETIME_IN_HOURS"]))),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(cfg["JWT_SECRET"])), SecurityAlgorithms.HmacSha256)
                );

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            var response = new
            {
                username = login,
                role = account.Role,
                access_token = encodedJwt,
            };

            return Ok(response);
        }

        [HttpPost("registration")]
        public async Task<IActionResult> Registrate(RegistrationDto registrationDto)
        {
            var existAccount = await ctx.Accounts.FirstOrDefaultAsync(a => a.Login.Equals(registrationDto.Login));
            if (existAccount is not null)
            {
                return BadRequest("User already exist");
            }

            var newAccount = new Account
            {
                Login = registrationDto.Login,
                Password = registrationDto.Password,
                Role = "client"
            };

            var newClient = new Client
            {
                Name = registrationDto.Name,
                SecondName = registrationDto.SecondName,
                Patronymic = registrationDto.Patronymic,
                Birthday = registrationDto.Birthday,
                Email = registrationDto.Email,
                PhoneNumber = registrationDto.PhoneNumber,
                Account = newAccount,
            };

            await ctx.Accounts.AddAsync(newAccount);
            await ctx.Clients.AddAsync(newClient);
            await ctx.SaveChangesAsync();
            return Ok();
        }
    }
}

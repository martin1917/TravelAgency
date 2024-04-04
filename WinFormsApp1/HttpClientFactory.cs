namespace WinFormsApp1
{
    public static class HttpClientFactory
    {
        public static HttpClient Create()
        {
            return new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7120/api/"),
                Timeout = new TimeSpan(0, 0, 30)
            };
        }
    }
}

namespace Tours.Dto
{
    public record ChangeStatusDto
    {
        public long RequestId { get; set; }

        public string NewState { get; set; }
    }
}

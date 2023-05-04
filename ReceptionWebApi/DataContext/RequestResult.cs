namespace ReceptionWebApi.DataContext
{
    public class RequestResult
    {
        public string? Message { get; set; }

        public int Status { get; set; }

        public object? Data { get; set; }
    }
}

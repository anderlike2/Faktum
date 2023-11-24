namespace DomainLayer.Models
{
    public class Result
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public bool? Error { get; set; }
        public string? MessageOrfeo { get; set; }
        public string? RecordId { get; set; }
        public string? PdfPath { get; set; }

        public Result()
        {
            this.Success = false;
        }
    }
}

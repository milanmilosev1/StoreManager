namespace SM.Api.Requests.ProductRequests
{
    public class UpdateProductRequest
    {
        public string SerialNumber { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
    }
}

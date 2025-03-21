namespace SM.Api.Requests.ProductRequests
{
    public class AddProductRequest
    {
        public string SerialNumber { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
    }
}

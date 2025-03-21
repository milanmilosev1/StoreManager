using System.ComponentModel.DataAnnotations;

namespace SM.Infrastructure.Models
{
    public class Bill
    {
        [Key]
        public Guid Id { get; set; }
        public int Price { get; set; }
    }
}

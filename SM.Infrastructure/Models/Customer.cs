using System.ComponentModel.DataAnnotations;

namespace SM.Infrastructure.Models
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }
    }
}

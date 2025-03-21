using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM.Infrastructure.Models
{
    public class BillProduct
    {
        [Key]
        public Guid BillProductId { get; set; }
        [ForeignKey("Bill")]
        public Guid BillId { get; set; }
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
    }
}

using SM.Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;

namespace SM.Infrastructure.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public Role Role { get; set; }
    }
}

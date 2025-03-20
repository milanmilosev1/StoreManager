using SM.Infrastructure.Enums;

namespace SM.Infrastructure.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public Role Role { get; set; }
    }
}

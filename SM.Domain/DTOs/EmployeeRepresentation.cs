using SM.Domain.Enums;

namespace SM.Domain.DTOs
{
    public class EmployeeRepresentation
    {
        public string FullName { get; set; } = string.Empty;
        public Role Role { get; set; }
    }
}

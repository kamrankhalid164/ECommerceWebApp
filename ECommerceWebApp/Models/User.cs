using System;
using System.Collections.Generic;

namespace E_CommerceWebApp.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string Password { get; set; } = null!;
        public string? Address { get; set; }
        public string? ZipCode { get; set; }
        public bool? IsSuperAdmin { get; set; }
        public bool? IsAdmin { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? FkcompanyId { get; set; }
    }
}

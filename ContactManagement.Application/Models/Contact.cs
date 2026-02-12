using System;

namespace ContactManagement.Application.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public ContactCategory Category { get; set; }

        public DateTime CreatedAt { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public string Company { get; set; }

        public string Website { get; set; }

        public string Notes { get; set; }

        public string Address { get; set; }

        public string AvatarPath { get; set; }
    }
}

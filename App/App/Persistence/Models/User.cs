using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.Persistence.Models
{
    public class User
    {
        [Key]
        public String EmailAddress { get; set; } = null!;

        public String DisplayName { get; set; } = "User";
        

        // TODO Persist secrets somehow
        public User(string emailAddress, string displayName)
        {
            EmailAddress = emailAddress;
            DisplayName = displayName;
        }

        public User() { }
    }
}
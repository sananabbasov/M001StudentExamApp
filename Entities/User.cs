using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User : Base
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string? ParrentEmail { get; set; }
        public string? ParrentFullName { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}

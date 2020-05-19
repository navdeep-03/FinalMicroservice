using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Models
{
    public class User
    {
        public int age { get; set; }
        public string Name { get; set; }
        [Required]
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
    }
}

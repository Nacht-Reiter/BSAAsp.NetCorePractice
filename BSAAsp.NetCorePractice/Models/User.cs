using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace BSAAsp.NetCorePractice
{
    public class User
    {
        [Required, Display(Name = "User`s ID"), Range(1, int.MaxValue, ErrorMessage ="User`s Id must be > 0")]
        public int Id { get; set; }
        [Display(Name = "Created at")]
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }

        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Todo> Todoes { get; set; }

    }   
}
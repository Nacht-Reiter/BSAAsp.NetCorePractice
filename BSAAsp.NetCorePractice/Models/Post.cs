using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace BSAAsp.NetCorePractice
{
    public class Post
    {
        [Required, Display(Name = "Post`s ID"), Range(1, int.MaxValue, ErrorMessage = "PostS Id must be > 0")]
        public int Id { get; set; }
        [Display(Name = "Created at")]
        public DateTime CreatedAt { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        [Display(Name = "Author")]
        public int UserId { get; set; }
        public int Likes { get; set; }

        public IEnumerable<Comment> Comments { get; set; }

    }
}
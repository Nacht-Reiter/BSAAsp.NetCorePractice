using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace BSAAsp.NetCorePractice
{
    public class Comment
    {
        public int Id { get; set; }
        [Display(Name = "Created at")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Text")]
        public string Body { get; set; }
        [Display(Name = "Author")]
        public int UserId { get; set; }
        [Display(Name = "Post")]
        public int PostId { get; set; }
        public int Likes { get; set; }

    }
}
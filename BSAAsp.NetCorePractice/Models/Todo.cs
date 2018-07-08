using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace BSAAsp.NetCorePractice
{
    public class Todo
    {
        public int Id { get; set; }
        [Display(Name = "Created at")]
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        [Display(Name = "User")]
        public int UserId { get; set; }

    }
}
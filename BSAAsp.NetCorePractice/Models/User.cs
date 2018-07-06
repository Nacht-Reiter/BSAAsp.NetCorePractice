﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BSAAsp.NetCorePractice
{
    public class User
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }

        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Todo> Todoes { get; set; }

    }   
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BernieApp.Portable.Models
{
    public class ActionAlert
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        public string BodyHTML { get; set; }
        public string Date { get; set; }
        public string TargetUrl { get; set; }
        public string TwitterUrl { get; set; }
        public int TweetId { get; set; }
    }
}

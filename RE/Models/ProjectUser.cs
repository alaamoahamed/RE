﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RE.Models
{
    public class ProjectUser
    {
        public long ID { set; get; }
        public User Usrs { get; set; }
        public Project Projects { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SangDT_DotNetCore5._0.Models.Entities
{
    public partial class User
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}

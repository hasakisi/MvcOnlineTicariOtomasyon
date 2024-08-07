﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UserName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UserPassword { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string UserAuthority { get; set; }
    }
}
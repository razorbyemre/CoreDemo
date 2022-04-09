﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class About
    {
        [Key]
        public int AboutID { get; set; }
        public int AboutDetails1 { get; set; }
        public int AboutDetails2 { get; set; }
        public int Aboutimage1 { get; set; }
        public int Aboutimage2 { get; set; }
        public int AboutiMapLocation { get; set; }
        public bool AboutStatus { get; set; }
    }
}

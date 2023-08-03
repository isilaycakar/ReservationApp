﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp.EntityLayer.Concrete
{
    public class NewsLatter
    {
        [Key]
        public int NewsLatterID { get; set; }
        public string Mail { get; set; }
    }
}

﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp.EntityLayer.Concrete
{
    public class AppUser: IdentityUser<int>
    {
        public string? ImageUrl { get; set; }
        public string NameSurname { get; set; }
        public List<Reservation> Reservation { get; set; }
    }
}

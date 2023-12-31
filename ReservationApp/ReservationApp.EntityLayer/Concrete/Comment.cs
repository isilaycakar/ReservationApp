﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp.EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentUser { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentContent { get; set; }
        public bool Status { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
    }
}

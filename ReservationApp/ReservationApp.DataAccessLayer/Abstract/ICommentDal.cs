﻿using ReservationApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp.DataAccessLayer.Abstract
{
    public interface ICommentDal: IGenericDal<Comment>
    {
        public List<Comment> GetListCommetWithDestination();
    }
}

﻿using ReservationApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp.DataAccessLayer.Abstract
{
    public interface IGuideDal: IGenericDal<Guide>
    {
        void ChangeToTrueByGuide(int id);
        void ChangeToFalseByGuide(int id);
        
    }
}

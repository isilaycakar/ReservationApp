﻿using ReservationApp.DataAccessLayer.Abstract;
using ReservationApp.DataAccessLayer.Repository;
using ReservationApp.EntityLayer.Concrete;

namespace ReservationApp.DataAccessLayer.Entity_Framework
{
    public class EFNewsLatterDal : GenericRepository<NewsLatter>, INewsLatterDal
    {
    }
}
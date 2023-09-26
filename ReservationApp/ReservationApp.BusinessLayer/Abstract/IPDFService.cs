using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp.BusinessLayer.Abstract
{
    public interface IPDFService
    {
        byte[] ExcelList<T>(List<T> t) where T : class;
    }
}

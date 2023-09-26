using ReservationApp.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp.BusinessLayer.Concrete
{
    public class PDFManager : IPDFService
    {
        public byte[] ExcelList<T>(List<T> t) where T : class
        {
            throw new NotImplementedException();
        }
    }
}

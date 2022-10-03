using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class DataBaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Veritabanına log yazar.");
        }
    }
}

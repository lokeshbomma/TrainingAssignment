using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{

    public interface ILog
    {
        void info(string str);
    }
    public class MyConsoleLogger:ILog
    {
        public void info(string str)
        {
            Debug.WriteLine(str);
        }
    }
}

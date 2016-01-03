using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateVsStrategy;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            TemplateClass myClass = new SubTemp1();
            myClass.TemplateMethod();

            myClass = new SubTemp2();
            myClass.TemplateMethod();
        }
    }
}

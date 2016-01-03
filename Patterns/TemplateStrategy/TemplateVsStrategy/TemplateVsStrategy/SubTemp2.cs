using System;

namespace TemplateVsStrategy
{
    public class SubTemp2 : TemplateClass
    {
        protected override void DoA()
        {
            Console.WriteLine(GetType().Name + " Herps once");
        }

        protected override void DoB()
        {
            Console.WriteLine(GetType().Name + " Herps twice");
        }
    }
}
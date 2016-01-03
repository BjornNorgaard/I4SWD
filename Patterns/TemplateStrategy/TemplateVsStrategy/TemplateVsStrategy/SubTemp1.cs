using System;

namespace TemplateVsStrategy
{
    public class SubTemp1 : TemplateClass
    {
        protected override void DoA()
        {
            Console.WriteLine(GetType().Name + " Derps once");
        }

        protected override void DoB()
        {
            Console.WriteLine(GetType().Name + " Derps twice");
        }
    }
}
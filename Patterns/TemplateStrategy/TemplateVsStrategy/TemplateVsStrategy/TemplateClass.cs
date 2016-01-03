
namespace TemplateVsStrategy
{
    public abstract class TemplateClass
    {
        public void TemplateMethod()
        {
            DoA();
            DoB();
        }

        protected abstract void DoA();
        protected abstract void DoB();
    }
}

using ShaMathConsole.Interfaces;

namespace ShaMathConsole.Classes
{
    public abstract class AbstractBase : IMathBase
    {
        public abstract int Add(int x, int y);
        public virtual int Substract(int x, int y)
        {
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }


    }
}

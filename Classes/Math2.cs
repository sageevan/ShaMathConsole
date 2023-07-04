using ShaMathConsole.Interfaces;

namespace ShaMathConsole.Classes
{
    internal class Math2 : IMathBase
    {
     
        public int Add(int x, int y)
        {
            return x + y;

        }
        public int Substract(int x, int y)
        {
            return x - y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;

        }

    }
}

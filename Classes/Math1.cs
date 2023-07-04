using ShaMathConsole.Classes;
using ShaMathConsole.Interfaces;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ShaMathConsole.Classes
{
    public class Math1 : AbstractBase
    {
        public override int Add(int x, int y)
        {
            return x + y;
        }

        public sealed override int Substract(int x, int y)
        {
            return x-y;
        }

        public new int Multiply(int x, int y)
        {
            return x * y;
        }

    }

  }

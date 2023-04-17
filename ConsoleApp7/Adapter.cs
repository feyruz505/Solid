using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public interface ITarget
    {
        void Request();
    }

    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adapter method is called.");
        }
    }

    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }

}

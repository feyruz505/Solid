using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public interface IComponent
    {
        void Operation();
    }

    public class Leaf : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Leaf operation is called.");
        }
    }

    public class Composite : IComponent
    {
        private readonly List<IComponent> _children = new List<IComponent>();

        public void Add(IComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IComponent component)
        {
            _children.Remove(component);
        }

        public void Operation()
        {
            Console.WriteLine("Composite operation is called.");
            foreach (var child in _children)
            {
                child.Operation();
            }
        }
    }

}

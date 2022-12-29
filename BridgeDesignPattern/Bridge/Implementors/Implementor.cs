using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Bridge.Implementors
{
    public abstract class Implementor
    {
        public abstract void Implementation();
    }

    public class ConcreteImplementor : Implementor
    {
        public override void Implementation()
        {
            Console.WriteLine("Run ====>  ConcreteImplementor.Implementation");
        }
    }
}

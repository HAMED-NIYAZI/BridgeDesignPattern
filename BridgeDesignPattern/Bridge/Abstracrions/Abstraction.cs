using BridgeDesignPattern.Bridge.Implementors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Bridge.Abstracrions
{
    public abstract class Abstraction
    {
        private readonly Implementor implementors;
        public Abstraction()
        {
            this.implementors = new ConcreteImplementor();
        }

        public virtual void Function()
        {
            implementors.Implementation();
        }
    }

    public class RefinedAAbstraction : Abstraction
    { 
    
    }
}

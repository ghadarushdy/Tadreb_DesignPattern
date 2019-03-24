using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tadreb_DesignPattern
{
    //Define an interface for creating an object, but let subclasses decide which class to instantiate. 
    //Factory Method lets a class defer instantiation to subclasses.

    abstract class FactoryMethod
    {
        public abstract Product FactoryMethodFunc();
    }
    
    abstract class Product
    {
    }
    

    class ConcreteProductA : Product
    {

    }

    class ConcreteProductB : Product
    {
    }


    class ConcreteCreatorA : FactoryMethod
    {
        public override Product FactoryMethodFunc()
        {
            return new ConcreteProductA();
        }
    }

    class ConcreteCreatorB : FactoryMethod
    {
        public override Product FactoryMethodFunc()
        {
            return new ConcreteProductB();
        }
    }


}

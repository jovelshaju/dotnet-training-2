using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesignPatternOne
{
    class Program
    {
        AbstractProductA proA;
        AbstractProductB proB;
        static void Main(string[] args)
        {
        }

        public Program(AbstractFactory factory)
        {
            proA = factory.CreateProductA();
            proB = factory.CreateProductB();
        }
    }

    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    };

    public class ConcreteFactoryA : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB();
        }
    }
    public abstract class AbstractProductA { };

    public class ProductA : AbstractProductA { };

    public abstract class AbstractProductB { };

    public class ProductB : AbstractProductB { };



}

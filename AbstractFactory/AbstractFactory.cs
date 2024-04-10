

namespace AbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract ProductA CreateProductA();
        public abstract ProductB CreateProductB();
    }
    class ConcreteFactory1 : AbstractFactory
    {
        public override ProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public override ProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
    class ConcreteFactory2 : AbstractFactory
    {
        public override ProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public override ProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }

    abstract class ProductA
    { }

    abstract class ProductB
    { }

    class ConcreteProductA1 : ProductA
    { }

    class ConcreteProductB1 : ProductB
    { }

    class ConcreteProductA2 : ProductA
    { }

    class ConcreteProductB2 : ProductB
    { }
}

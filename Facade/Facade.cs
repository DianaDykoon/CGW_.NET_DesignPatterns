

namespace Facade
{
    public class Subsystem1
    {
        public void operation1()
        {
            
        }

        public void operationN()
        {
            
        }
    }

    public class Subsystem2
    {
        public void operation1()
        {
            
        }

        public void operationM()
        {
            
        }
    }

    public class Facade
    {
        protected Subsystem1 _subsystem1;

        protected Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            _subsystem1 = subsystem1;
            _subsystem2 = subsystem2;
        }

        public void Operation1()
        {
            _subsystem1.operation1();
            _subsystem2.operation1();
        }
    }
}

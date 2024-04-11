

namespace DoubleCheckedLocking
{
    public sealed class Singleton
    {
        private Singleton()
        {
            
        }

        private static volatile Singleton _instance;

        private static readonly Object _lock = new Object();

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }
}

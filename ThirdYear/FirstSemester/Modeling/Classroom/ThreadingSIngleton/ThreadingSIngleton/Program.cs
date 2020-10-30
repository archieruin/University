using System.IO;
using System.Threading;

namespace ThreadingSIngleton
{
    class Program
    {
        class Logger
        {
            static Logger _instance = null;
            static object _locker = new object();

            private Logger() {}

            public static Logger GetInstance
            {
                get {
                    lock (_locker)
                    {
                        if (_instance == null) _instance = new Logger();
                    }
                    return _instance;
                }
            }

            public void PutMessage(string text)
            {
                lock(_locker)
                {
                    using (StreamWriter writer = new StreamWriter(new FileStream("log.txt", FileMode.Append)))
                    {
                        writer.Write(text)
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            const int maxThreadsCount = 5;
            for (int i = 0; i < maxThreadsCount; i++)
            {

            }
        }
    }
}

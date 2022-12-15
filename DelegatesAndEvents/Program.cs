namespace DelegatesAndEvents
{
    public delegate void CustomDelegate(string msg);
    public delegate T MathDelegate<T>(T paramOne, T paramTwo);

    internal class Program
    {
        static void Main()
        {
            MathDelegate mathDelegate = Multiply.MultiplyM;

            CustomDelegate logDelegate = Logger.Log;
            CustomDelegate notificationDelegate = Notification.Log;
            CustomDelegate del = logDelegate + notificationDelegate;
            del("Hello World!!!");

            del -= notificationDelegate;
            del("Hello King!!!");
        }
    }
    class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine($"I am Logger: {message}");
        }
    }

    class Notification
    {
        public static void Log(string message)
        { 
            Console.WriteLine($"I am Notification: {message}");
        }
    }

    //Generic Delegate
    //This is more like creating a delegate that can take in what you want it to take in and give out what you want it to give out
    class Multiply
    {
        public static int MultiplyM(int paramOne, int paramTwo)
        {
            return paramOne*paramTwo;
        }
    }

    class Subtract
    {
        public static int SubtractM(int paramOne, int paramTwo)
        {
            return paramTwo - paramOne;
        }
    }
}
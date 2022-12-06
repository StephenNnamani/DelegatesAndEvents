namespace DelegatesAndEvents
{
    public delegate void CustomDelegate(string msg);
    internal class Program
    {
        static void Main()
        {
            CustomDelegate logDelegate = Logger.Log;
            CustomDelegate notificationDelegate = Notification.Log;
            CustomDelegate del = logDelegate + notificationDelegate;
            del("Hello World!!!");

            del = del - notificationDelegate;
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
}
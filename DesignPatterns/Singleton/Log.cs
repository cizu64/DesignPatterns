using System;

namespace DesignPatterns.Singleton
{

    public class Log
    {
        Log() //constructor should be private because users should not be calling instance of the constructor in a singleton
        {
            Console.WriteLine("Logged");
            
        }

     
        static Log instance = new Log();
        public static Log Instance => instance;
        
    }
}
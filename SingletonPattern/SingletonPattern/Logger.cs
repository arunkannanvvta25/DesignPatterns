using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Logger
    {
        //variable to store the instance of Logger
        private static  Logger? _instance;

        // protected constructor - so that it can not be instantiated by other classes
        protected  Logger() { 
            
        }
        public static Logger Instance { 
            get
            {
                // if the instance is already created, return that instance, else create an instance and then return it.
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }
        public void Log(string s)
        {
            Console.WriteLine(s);  
        }
    }
}

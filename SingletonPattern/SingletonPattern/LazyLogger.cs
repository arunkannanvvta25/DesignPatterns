using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class LazyLogger
    {
        // Object creation happens only when it is first used. 
        private static readonly Lazy<LazyLogger> lazyLogger = new Lazy<LazyLogger>(()=> new LazyLogger());

        protected LazyLogger()
        {

        }
        public static LazyLogger Instance
        {
            get { return lazyLogger.Value; }
        }
        public void Log(string s)
        {
            Console.WriteLine(s);
        }
    }
}

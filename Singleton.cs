using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Tadreb_DesignPattern
{
   sealed class Singleton
    {
        private static Singleton _instance;
        
        Singleton()
        {

        }

        public static Singleton Instance()
        {
            const int yy=0;
            
            // Uses lazy initialization.
            // Note: this is not thread safe.
            _instance = _instance ?? new Singleton();
            
            return _instance;
        }
    }
}

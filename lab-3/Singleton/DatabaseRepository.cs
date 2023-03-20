using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class DatabaseRepository
    {
        private static DatabaseRepository? _instance;

        private DatabaseRepository()
        {
            Console.WriteLine("New Instance created");
        }

        public static DatabaseRepository GetInstance()
        {
            if (_instance is null)
            {
                _instance = new();
            }

            return _instance;
        }
    }
}

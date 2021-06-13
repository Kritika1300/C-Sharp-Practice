using System;
using System.Collections.Generic;

namespace Classes
{
    class HttpCookie {


        private readonly Dictionary<string, string> _dictionary;
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key] {

            get { return _dictionary[key]; }

            set { _dictionary[key] = value; }
        
        
        }



        public static void Main()
        {
            HttpCookie cookie = new HttpCookie();
            cookie["name"] = "Kritika";
            Console.WriteLine(cookie["name"]);
        }



    }
}

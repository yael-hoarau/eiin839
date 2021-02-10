using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Header
    {
        HttpListenerRequest request;
        public Header(HttpListenerRequest r) {
            request = r;
        }

        public override string ToString()
        {
            string toReturn = "Liste des headers : ";
            for (int i = 0; i < request.Headers.Count; ++i)
                toReturn += "<br>" + request.Headers.Keys[i] + " : " + request.Headers[i];
            return toReturn;
        }
    }
}

using Microsoft.Rest.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EECore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Advisor advisor = new Advisor();

            WebRequests wr = new WebRequests();

            wr.Request("{\"username\":\"salted\",\"ai_key\":\"49ee125ad5e9a3b81dfb771ac0d3d2fb\",\"server\":\"ai\"}");

            while (true) ;
        }
    }
}

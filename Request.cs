using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clones
{
    public class Request
    {
        public string Command { get;}
        public int Receiver { get;}
        public string Program { get;}

        public Request(string query)
        {
            var request = query.Split(' ');
            Command = request[0];
            Receiver = Convert.ToInt32(request[1]);
            Program = request.Count() > 2 ? request[2] : null;
        }
    }
}

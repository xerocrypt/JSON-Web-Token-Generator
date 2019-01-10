using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT_Generator
{
    public class TokenHeader
    {
        public string alg { get; set; }
        public string typ { get; set; }
    }

    public class TokenPayload
    {
        public string sub { get; set; }
        public string name { get; set; }
        public string admin { get; set; }
    }
}

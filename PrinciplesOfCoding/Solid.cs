using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinciplesOfCoding
{
    internal class Ocp
    {
        public IOcp injection;
        public Ocp(IOcp injection) {
            this.injection = injection;
        }
    }
}
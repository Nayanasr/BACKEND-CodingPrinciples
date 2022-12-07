using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinciplesOfCoding
{
    internal class Post
    {
        public Post injection;
        public Post(IPost injection) {
            this.injection = (Post)injection;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    public class Cast
    {   
        public string ImdbId { get; set; }
        public string Name { get; set; }

        public List<Role> Roles { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}

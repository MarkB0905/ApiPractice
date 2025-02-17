using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JET2.Connection
{
    public class DbParam
    {
        public string Name { get; set; }
        public dynamic Value { get; set; }


        public DbParam() { }
        public DbParam(string name, dynamic value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}

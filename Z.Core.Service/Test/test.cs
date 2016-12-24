using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z.Core.Service.Test
{
    public class test
    {
        public void t()
        {
            priv();
        }

        private void priv() { }

        public virtual string name(string name)
        {
            return name;
        }

        public string name(string name, string sex)
        {
            return name + ":" + sex;
        }

        public string chongxie(string name)
        {
            return "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVRepositories
{
    public class Thema
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
    }
}

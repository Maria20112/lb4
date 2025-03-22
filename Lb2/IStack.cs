using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    internal interface IStack
    {
        public void Add(Person person);
        public Person? Find(int id);
        public void Remove(int id);
        public DataTable GenerateData();
    }
}

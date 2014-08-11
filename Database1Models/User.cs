using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database1Models.Mapping
{
    public class User
    {
        public virtual int UserId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual IList<Computer> Computers { get; set; }
        public User()
        {
            Computers = new List<Computer>();
        }

        public virtual void AddComputer(Computer item)
        {
            item.Owner = this;
            Computers.Add(item);
        }
    }
}


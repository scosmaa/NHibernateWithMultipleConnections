using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database1Models.Mapping
{
    public class ComputerMap : ClassMap<Computer>
    {
        public ComputerMap()
        {
            Id(x => x.Id);
            Map(x => x.Brand);
            Map(x => x.Model);

            References(i => i.Owner)
                .Column("UserId")
                .Not.Nullable();
        }
    }
}

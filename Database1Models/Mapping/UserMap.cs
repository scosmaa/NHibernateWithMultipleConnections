using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database1Models.Mapping
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.UserId).GeneratedBy.Identity();
            Map(x => x.Name);
            Map(x => x.Surname);
            HasMany(x => x.Computers).KeyColumn("Id").Cascade.AllDeleteOrphan().Inverse();
        }
    }
}

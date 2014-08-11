using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database2Models.Mapping
{
    class PhoneMap : ClassMap<Phone>
    {
        public PhoneMap()
        {
            Id(x => x.Id);
            Map(x => x.Brand);
            Map(x => x.Model);
        }
    }
}

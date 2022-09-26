using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFATM.Models
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    public class ATMDataContext : DbContext
    {
        public ATMDataContext() : base("name=connstr")
        {
        }

        public DbSet<Carddetail> Carddetail { get; set; }

        public DbSet<TransDetail> TransDetail { get; set; }
    }
}

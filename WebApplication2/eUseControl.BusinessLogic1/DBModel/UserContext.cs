using eUseControl.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic1.DBModel
{
    class UserContext : DbContext
    {
        public UserContext() : base("WebApplication2")
        {
        }
        public virtual DbSet<UDbtable> Users { get; set; }
    }
}
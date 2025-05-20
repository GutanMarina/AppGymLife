using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSport.Domain.Entities.User;
using eSport.Domain.Entities;

namespace eSport.BusinessLogic.DBModel
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() :
            base("name = eGymLife")
        {
        }
        public DbSet<UDbTable> UDbTable { get; set; }

    }


}



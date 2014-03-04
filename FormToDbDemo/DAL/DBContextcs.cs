using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FormToDbDemo.Models;

namespace FormToDbDemo.DAL      // Data Access Layer
{
    public class EquipDBContext : DbContext
    {
        public DbSet<Equipment> Equipments { get; set; }
    }
}
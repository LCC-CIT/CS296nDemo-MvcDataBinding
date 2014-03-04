using FormToDbDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormToDbDemo.DAL
{
    public class EquipmentRepo    // Data Access Layer
    {
        public IQueryable<Equipment> Equipments
        {
            get
            {
                var db = new EquipDBContext();
                return db.Equipments;
            }
        }


        // Remove all equipment items and add new ones
        public void Init()
        {
            var db = new EquipDBContext();

            // Delete all rows from the Equipments table
            foreach (Equipment item in db.Equipments)
                db.Equipments.Remove(item);

            // Add some new ones
            Equipment equipItem1 = new Equipment() { Name = "iPad", CheckedOut = false };
            db.Equipments.Add(equipItem1);
            Equipment equipItem2 = new Equipment() { Name = "Microphone", CheckedOut = false };
            db.Equipments.Add(equipItem2);
            Equipment equipItem3 = new Equipment() { Name = "Tripod", CheckedOut = false };
            db.Equipments.Add(equipItem3);

            db.SaveChanges();
        }

        public bool SaveItem(Equipment item)
        {
            var db = new EquipDBContext();
            // Check to see if an item with this name is in the database
            if(null == db.Equipments.FirstOrDefault(e => e.Name == item.Name))
            {
                db.Equipments.Add(item);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
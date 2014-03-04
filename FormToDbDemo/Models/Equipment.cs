using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormToDbDemo.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public bool CheckedOut { get; set; }
    }
}
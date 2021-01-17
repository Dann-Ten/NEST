using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NEST.Models
{
        public enum IsolationCat { Mechanical, Electrical}
        public enum DefaultIso { Closed, Open }
        public class IsolationPointList { 
            [Key]
            [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
            public int UDC { get; set; }
            public int IsolationUID { get; set;}
            public string ParentSystem { get; set; }
            public string IsolationPoint { get; set; }
            public string SwitchboardOrCubicle { get; set; }
            public string Description { get; set; }
            public string PhysicalLocation { get; set; }
            public IsolationCat IsolationCat { get; set; }
            public DefaultIso DefaultIso { get; set; }
            public int FacilityCode { get; set; }
            public string IsolationType { get; set; }
            public string EnergyPotential { get; set; }
            public bool Padlockable { get; set; }
            public string PreferredPadlock { get; set; }
            public string PreferredLockout { get; set; }
            public string AlternateLockout { get; set; }
            public bool IsIsolationPoint { get; set; }
            public bool ValidationPoss { get; set; }
            public string ValidationMethod { get; set; }
            public bool HighRiskPlant { get; set; }
            public string Photos { get; set; }
            public string Comments { get; set; }
            public string CheckedBy { get; set; }

        }   
}

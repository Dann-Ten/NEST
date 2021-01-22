using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NEST.Models;
namespace NEST.Data
{
    public class DatabaseInjector
    {
        public static void Initialize(DatabaseContext context) {
            context.Database.EnsureCreated();
            
            if (context.IsolationPointTools.Any()) {
                return;
            }
            var Tools = new IsolationPointTools[] {
                new IsolationPointTools{Description="test", PartNum=1,Manufacturer="test", Type="test", Comment="test"}
            };
            foreach(IsolationPointTools Tool in Tools)
            {
                context.IsolationPointTools.Add(Tool);
            }
            context.SaveChanges();
            if (context.IsolationPointList.Any())
            {
                return;
            }
            var List = new IsolationPointList[] {
                new IsolationPointList{ParentSystem="test",IsolationPoint="test",SwitchboardOrCubicle="test",Description="test",PhysicalLocation="test",
                IsolationCat=IsolationCat.Mechanical, DefaultIso=DefaultIso.Closed,FacilityCode=1, IsolationType="test", EnergyPotential="test", Padlockable=true, PreferredPadlock="test", PreferredLockout="test",
                AlternateLockout="test", IsIsolationPoint=true, ValidationPoss=true, ValidationMethod="test", HighRiskPlant=true, Photos="test", Comments="test", CheckedBy="test" },
                 new IsolationPointList{ParentSystem="tester",IsolationPoint="test",SwitchboardOrCubicle="test",Description="test",PhysicalLocation="test",
                IsolationCat=IsolationCat.Mechanical, DefaultIso=DefaultIso.Closed,FacilityCode=1, IsolationType="test", EnergyPotential="test", Padlockable=true, PreferredPadlock="test", PreferredLockout="test",
                AlternateLockout="test", IsIsolationPoint=true, ValidationPoss=true, ValidationMethod="test", HighRiskPlant=true, Photos="test", Comments="test", CheckedBy="test" }
            };
            foreach (IsolationPointList Lists in List)
            {
                context.IsolationPointList.Add(Lists);
            }
            context.SaveChanges();
        }
    }
}

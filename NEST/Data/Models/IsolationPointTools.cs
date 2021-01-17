using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NEST.Models
{
    public class IsolationPointTools
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int StockCodeID { get; set; }
        public string Description { get; set; }
        public int PartNum { get; set; }
        public string Manufacturer { get; set; }
        public string Website { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
    }
}

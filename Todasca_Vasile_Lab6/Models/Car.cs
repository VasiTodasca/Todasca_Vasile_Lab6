using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Todasca_Vasile_Lab6.Models
{
    public class Car
    {
        public int ID { get; set; }
        [Display(Name= "Car Brand")]
        public string Brand { get; set; }
        public string Model { get; set; }
        [Column(TypeName ="decimal(6,2)")]
        public decimal Price { get; set; }
        [Display(Name = "Year of fabrication")]
        public int FabricationDate { get; set; }
    }
}

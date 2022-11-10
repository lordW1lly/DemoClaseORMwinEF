using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClaseORMwinEF.Models
{
    [Table("Empleado")]
    public class Empleado
    {
        public int SID    { get; set; }
        public string Nombre { get; set; }
    }
}

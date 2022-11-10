using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoClaseORMwinEF.Models
{
   [Table("Categoria")]   
    public class Categoria
    {
        //EF convensión: Id, ID o CategoriaId  automaticamente es PK
        public int Id { get; set; }

        [Required]//campo obligatorio - DB: NOT NULL
        [Column(TypeName = "varchar")]//tipo de datos de sql server
        [StringLength(50)]//longitud máxima de la cadena 
        public string Nombre { get; set; }

        #region Propiedades de Navegacion
        public List<Producto> productos { get; set; }
        #endregion

    }
}

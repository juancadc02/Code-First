using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Modelo
{
   
    public class Accesos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_acceso {  get; set; }
        public string codigo_acceso { get; set; }
        public string descripcion_acceso { get; set; }

        public Accesos()
        {
        }

        public Accesos(string codigo_acceso, string descripcion_acceso)
        {
            this.codigo_acceso = codigo_acceso;
            this.descripcion_acceso = descripcion_acceso;
        }
    }
}

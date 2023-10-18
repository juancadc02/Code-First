using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Modelo
{
    public  class LibrosDal
    {
        [Key]
        
        public int id_libro { get; set; }
        public string nombre_libro { get; set; }
    }
}

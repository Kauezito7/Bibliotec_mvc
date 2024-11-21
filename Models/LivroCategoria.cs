using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class LivroCategoria
    {
        public int LivroCategoriaId { get; set;}
        [ForeignKey("Livro")]
        public int LivroId { get; set;}
        [ForeignKey("Categoria")]
        public int CategoriaID { get; set;}
        public Categoria Categoria { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class LivroReserva
    {
        [Key]
        public int LivroReservaid { get; set; }
        public DateOnly DtReserva { get; set; }
        public DateOnly DtDevolucao { get; set; }
        public int Status { get; set; }

        public int UsuaruioID { get; set; }
         [ForeignKey("Usuario")]
         public Usuario Usuario { get; set; }
        public int LivroID  { get; set; }
         [ForeignKey("Livro")]
        public Livro Livro { get; set; }
    }
}
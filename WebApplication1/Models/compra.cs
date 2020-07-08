using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class compra
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }

        [ForeignKey("cliente")]
        public int clienteid { get; set; }
        public virtual cliente cliente { get; set; }
    }
}
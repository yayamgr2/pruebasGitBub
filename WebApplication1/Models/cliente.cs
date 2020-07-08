using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class cliente
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public virtual List<compra> compras { get; set; }
    }
}
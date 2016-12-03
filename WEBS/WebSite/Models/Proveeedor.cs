using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite.Models
{
    public class Proveeedor
    {

        public int id { get; set; }
        public int marca_id { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }
        public string proveedor { get; set; }
        public int stock { get; set; }
      
    }
  
  }
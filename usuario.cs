//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoeMarket
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        public usuario()
        {
            this.direccions = new HashSet<direccion>();
            this.metodo_de_pago = new HashSet<metodo_de_pago>();
            this.ordens = new HashSet<orden>();
            this.productoes = new HashSet<producto>();
        }
    
        public int id { get; set; }
        public string celularUsuario { get; set; }
        public string correo { get; set; }
        public bool estado { get; set; }
        public string nombre { get; set; }
        public string username { get; set; }
        public int rol_id { get; set; }
    
        public virtual ICollection<direccion> direccions { get; set; }
        public virtual ICollection<metodo_de_pago> metodo_de_pago { get; set; }
        public virtual ICollection<orden> ordens { get; set; }
        public virtual rol rol { get; set; }
        public virtual ICollection<producto> productoes { get; set; }
    }
}

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
    
    public partial class metodo_de_pago
    {
        public metodo_de_pago()
        {
            this.ordens = new HashSet<orden>();
        }
    
        public int id { get; set; }
        public string tipoPago { get; set; }
        public int usuario_id { get; set; }
    
        public virtual usuario usuario { get; set; }
        public virtual ICollection<orden> ordens { get; set; }
    }
}
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
    
    public partial class grupo
    {
        public grupo()
        {
            this.categorias = new HashSet<categoria>();
        }
    
        public int id { get; set; }
        public string nombre_grupo { get; set; }
    
        public virtual ICollection<categoria> categorias { get; set; }
    }
}

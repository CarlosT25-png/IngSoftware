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
    
    public partial class direccion
    {
        public int id { get; set; }
        public string ciudad { get; set; }
        public string codigo_postal { get; set; }
        public string detalle { get; set; }
        public string pais { get; set; }
        public int usuario_id { get; set; }
    
        public virtual usuario usuario { get; set; }
    }
}

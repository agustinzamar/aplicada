//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aplicada.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdenesEstado
    {
        public int Id { get; set; }
        public Nullable<int> orden_id { get; set; }
        public Nullable<int> estado_id { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string usuario_id { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual Ordene Ordene { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}

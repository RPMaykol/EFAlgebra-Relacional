//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADONetEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerDemographics
    {
        public CustomerDemographics()
        {
            this.Customers = new HashSet<Customers>();
        }
    
        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
    
        public virtual ICollection<Customers> Customers { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Knjižnica
{
    using System;
    using System.Collections.Generic;
    
    public partial class tipKorisnika
    {
        public tipKorisnika()
        {
            this.korisnik = new HashSet<korisnik>();
        }
    
        public int idTip { get; set; }
        public string naziv { get; set; }
    
        public virtual ICollection<korisnik> korisnik { get; set; }
    }
}

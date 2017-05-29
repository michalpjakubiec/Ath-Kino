//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATH_kino
{
    using System;
    using System.Collections.Generic;
    
    public partial class Film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            this.GatunekSzczegoly = new HashSet<GatunekSzczegoly>();
            this.Rola = new HashSet<Rola>();
            this.Seans = new HashSet<Seans>();
        }
    
        public int ID_Film { get; set; }
        public int ID_Rezyser { get; set; }
        public int ID_Scenarzysta { get; set; }
        public string Nazwa { get; set; }
        public string NazwaOryginalu { get; set; }
        public Nullable<System.DateTime> DataPremieryPolska { get; set; }
        public System.DateTime DataPremierySwiat { get; set; }
        public int CzasTrwaniaMinuty { get; set; }
        public string Produkcja { get; set; }
        public int OgraniczenieWiekowe { get; set; }
        public string Opis { get; set; }
        public string TypObrazu { get; set; }
    
        public virtual Rezyser Rezyser { get; set; }
        public virtual Scenarzysta Scenarzysta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GatunekSzczegoly> GatunekSzczegoly { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rola> Rola { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seans> Seans { get; set; }
        public virtual Okladka Okladka { get; set; }
    }
}

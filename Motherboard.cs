//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Motherboard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Motherboard()
        {
            this.Basket = new HashSet<Basket>();
            this.TovarToOrder = new HashSet<TovarToOrder>();
        }
    
        public int Id_Motherboard { get; set; }
        public string Model { get; set; }
        public string Form_factor { get; set; }
        public string Soket { get; set; }
        public int Memory_slots { get; set; }
        public string Type_memory { get; set; }
        public string Max_memory { get; set; }
        public string Max_frequency { get; set; }
        public string Pic { get; set; }
        public Nullable<int> Coast { get; set; }
        public Nullable<int> Count { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Basket> Basket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TovarToOrder> TovarToOrder { get; set; }
    }
}

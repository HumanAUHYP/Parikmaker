//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Parikmaker.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Haircut
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Haircut()
        {
            this.Cashbox = new HashSet<Cashbox>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Gender { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cashbox> Cashbox { get; set; }
        public virtual Gender Gender1 { get; set; }
    }
}

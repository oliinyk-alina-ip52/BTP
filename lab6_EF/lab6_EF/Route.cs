//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab6_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Route
    {
        public Route()
        {
            this.Bus = new HashSet<Bus>();
            this.Link = new HashSet<Link>();
        }
    
        public int Id { get; set; }
        public string count { get; set; }
    
        public virtual ICollection<Bus> Bus { get; set; }
        public virtual ICollection<Link> Link { get; set; }
    }
}

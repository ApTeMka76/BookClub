//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookClub.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderProduct
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int PriceProduct { get; set; }
    
        public virtual ListOfProducts ListOfProducts { get; set; }
        public virtual Orders Orders { get; set; }
    }
}

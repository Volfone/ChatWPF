//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatWPF.ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserSub
    {
        public int UserSub_ID { get; set; }
        public int User_ID { get; set; }
        public int Sub_ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Sub Sub { get; set; }
        public virtual User User { get; set; }
    }
}
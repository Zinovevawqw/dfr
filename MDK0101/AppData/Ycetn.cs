//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MDK0101.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ycetn
    {
        public int NomerZapisi { get; set; }
        public int NomerRemontRabor { get; set; }
        public System.DateTime DataNacala { get; set; }
        public int DlitelnostRabot { get; set; }
        public int Kol_voVipoln { get; set; }
    
        public virtual Sprav Sprav { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcPerInfo.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Duyuru
    {
        public int ID { get; set; }
        public string DuyuruBaslik { get; set; }
        public string DuyuruIcerik { get; set; }
        public string KAD { get; set; }
        public Nullable<bool> Durum { get; set; }
    }
}

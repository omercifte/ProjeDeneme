//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjeDeneme.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    public partial class Hakkinda
    {
        public int HakkindaID { get; set; }
        public string HakkindaBaslik { get; set; }
        [UIHint("tinymce_full")][AllowHtml]
        
        public string HakkindaIcerik { get; set; }
    }
}

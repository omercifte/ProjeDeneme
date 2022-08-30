using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProjeDeneme.Models {

    public class TinyMCEModel {

        [AllowHtml]
        [UIHint("tinymce_full_compressed")]
        public string Content { get; set; }

    }
}
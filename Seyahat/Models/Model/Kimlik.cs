using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seyahat.Models.Model
{
    [Table("Kimlik")]
    public class Kimlik
    {
        [Key]
        public int KimlikId { get; set; }
        [Required,StringLength(100, ErrorMessage = "100 Karekter Olmalıdır")]
        public string Title { get; set; }

        [DisplayName("Anahtar Kelime")]
        [Required, StringLength(200, ErrorMessage = "200 Karekter Olmalıdır")]

        public string Keywords { get; set; }
        [DisplayName("Site Açıklama")]
        [Required, StringLength(200, ErrorMessage = "200 Karekter Olmalıdır")]

        public string Description { get; set; }
        [DisplayName("Site Başlık")]
        
        public String LogoURL { get; set; }
        [DisplayName("Site Ünvan")]

        public string Unvan { get; set;}

    }
}
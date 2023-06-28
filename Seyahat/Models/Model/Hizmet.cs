using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seyahat.Models.Model
{
    [Table("Hizmet")]
    public class Hizmet
    {
        [Key]
        public int HizmetId { get; set; }
        [Required,StringLength(150,ErrorMessage ="150 Karakter Olabilir")]
        [DisplayName("Hizmat Başlık")]
          
        public string Başlık { get; set; }
        [DisplayName("Hizmet Açıklama")]

        public string Açıklama { get; set; }
        [DisplayName("Hizmet Resim")]

        public string ResimURL { get; set; }



    }
}
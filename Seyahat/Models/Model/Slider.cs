using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seyahat.Models
{
    [Table("Slider")]//Veri Tabanına Eklemek İçin
    public class Slider
    {
        [Key] //Birincil Anahtar Oldunu beritim Hocam :)
        public int SliderId { get; set; }
        [DisplayName("Slider Başlık"),StringLength(30,ErrorMessage ="30 Karakter Olmalıdır")] //30 Karakter Dişinda Yazarsam Hata veriri hocam
        public string Baslik { get; set;}
        [DisplayName("Slider Başlık"), StringLength(150, ErrorMessage = "150 Karakter Olmalıdır")] 

        public string Acıklama { get; set;}
        [DisplayName("Slider Başlık"), StringLength(250, ErrorMessage = "150 Karakter Olmalıdır")]


        public string ResimURL {get; set;}
    }
}
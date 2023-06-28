using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seyahat.Models.Model
{
    [Table("İletişim")]
    public class İletişim
    {
        [Key]
        public int  İletişimId { get ; set; }

        [StringLength(250,ErrorMessage ="250 Karekter Olmalı")]

        public string Adres { get; set; }
        [StringLength(250, ErrorMessage = "250 Karekter Olmalı")]


        public string Telefon { get; set; }
        

        public string Fax { get; set; }
       

        public string Whatsapp { get; set; }
        

        public string Facebbok { get; set; }
        public string Twitter { get; set; }
        public string İnstagram { get; set; }
    }
}
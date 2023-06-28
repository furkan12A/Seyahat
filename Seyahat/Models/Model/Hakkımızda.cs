using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seyahat.Models.Model
{
    [Table("Hakkımızda")]
    public class Hakkımızda
    {
        [Key]
        public int HakkımızdaId { get; set; }
        [Required]
        [DisplayName(" Hakkımızda Açıklama")]
        public string Acıklama { get; set; }
    }
}
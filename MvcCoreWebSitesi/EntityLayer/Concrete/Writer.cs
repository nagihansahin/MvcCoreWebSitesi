using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        public string WriterName { get; set; }//yazar ismi alanı
        public string WriterAbout { get; set; }//yazar hakkında alanı
        public string WriterImage { get; set; }//yazar fotoğraf alanı
        public string WriterMail { get; set; }//yazar mail alanı
        public string WriterPassword { get; set; }//yazar şifre alanı
        public bool WriterStatus { get; set; }
    }
}

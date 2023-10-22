using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string ContactUserName { get; set; }// iletişim kuran kişinin kullanıcı adı alanı
        public string ContactMail { get; set; }// iletişim kuran kişinin mail alanı
        public string ContactSubject { get; set; }// iletişim konusu alanı
        public string ContactMessage { get; set; }// iletişim içerik alanı
        public DateTime ContactDate { get; set; }// iletişimin oluşturulma tarihi alanı
        public bool ContactStatus { get; set; }

    }
}

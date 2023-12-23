using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }//Blog Başlık alanı
        public string BlogContent { get; set; }//Blog içerik alanı
        public string BlogThumbnailImage { get; set; }//Blog için küçük resim alanı
        public string BlogImage { get; set; }//Blog için büyük resim alanı
        public DateTime BlogCreateDate { get; set; }//Blogun oluşturulma tarihi
        public bool BlogStatus { get; set; }//Blog aktif pasiflik durumu alanı
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
        public int WriterID { get; set; }
        public Writer Writer { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentUserName { get; set; } //Yorum yapanın kullanıcı adı alanı 
        public string CommentTitle { get; set; } //Yorum başlık alanı 
        public string CommentContent { get; set; } //Yorum içerik alanı 
        public DateTime CommentDate { get; set; } //Yorum oluşturulma tarihi alanı 
        public bool CommentStatus { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Teregulov.Models
{
    public class Comment
    {
        [ScaffoldColumn(false)]
        public int CommentId { get; set; }
        [DisplayName("Пост")]
        public int PostId { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Емайл")]
        public string Email { get; set; }
        [DisplayName("Сайт")]
        public string Site { get; set; }
        [DisplayName("Текст комментария")]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
        [DisplayName("Дата создания")]
        public DateTime CreateDate { get; set; }
        [DisplayName("Промодерирован")]
        public bool Moderated { get; set; }
        [DisplayName("Опубликован")]
        public bool Published { get; set; }
        [DisplayName("Комментарий автора блога")]
		public bool IsBlogAuthor { get; set; }
		[DisplayName("Родительский комментарий")]
		public int ParentCommentId { get; set; }
		[DisplayName("Глубина вложенности")]
		public int Depth { get; set; }
    }
}
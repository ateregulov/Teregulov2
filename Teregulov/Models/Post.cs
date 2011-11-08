using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Teregulov.Models
{
    public class Post
    {
        //[ScaffoldColumn(false)]
        public int PostId { get; set; }
        [DisplayName("Заголовок")]
        public string Title { get; set; }
        [DisplayName("Описание для поисковой системы")]
        public string HtmlDesription { get; set; }
        [DisplayName("Ключевые слова для поисковых систем")]
        public string HtmlKeywords { get; set; }
        [DisplayName("ЧПУ")]
        public string FriendlyUrl { get; set; }
        [DisplayName("Основной текст")]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
        [DisplayName("Дата создания")]
        public DateTime CreateDate { get; set; }
        [DisplayName("Является черновиком")]
        public bool IsDraft { get; set; }
        [DisplayName("Поток")]
        public int FlowId { get; set; }
        
        public List<string> Tags { get; set; }
        public List<string> Comments { get; set; }

        public int FlowId3 { get; set; }
    }
}
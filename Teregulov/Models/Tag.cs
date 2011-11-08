using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Teregulov.Models
{
    public class Tag
    {
        [ScaffoldColumn(false)]
        public int TagtId { get; set; }
        [DisplayName("Заголовок")]
        public string Title { get; set; }
        [DisplayName("ЧПУ")]
        public string FriendlyUrl { get; set; }
    }
}
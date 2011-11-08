using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Teregulov.Models
{
    public class Flow
    {
        [ScaffoldColumn(false)]
        public int FlowId { get; set; }
        [DisplayName("Название потока")]
        public string Title { get; set; }
        
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SearchEngine.Models
{
    public class RecordsModel
    {
        public int RecordsId { get; set; }

        [Required(ErrorMessage = "This field is required.")]
       
        public string Record { get; set; }

        public int? Id { get; set; }

    }
}
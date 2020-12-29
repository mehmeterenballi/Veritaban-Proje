using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VeritabaniProjesi.Models
{
    public class Announcement
    {
        [Key, NotNull, MaxLength(40), Required]
        public string Title { get; set; }
        public string Content { get; set; }
        public string SourceListJson { get; set; }

        [NotMapped]
        public string[] SourceList
        {
            get
            {
                return SourceListJson.Split(';');
            }
        }

        [DataType(DataType.DateTime)] public DateTime Date { get; set; }
    }
}

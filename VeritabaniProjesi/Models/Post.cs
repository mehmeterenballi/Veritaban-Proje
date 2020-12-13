using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace VeritabaniProjesi.Models
{
    public class Post
    {
        [Key, NotNull] public int Id { get; set; }

        [MaxLength(20), MinLength(2), NotNull]public string Title;
        [MaxLength(20), MinLength(2), NotNull]public string Sender { get; set; }
        [NotNull]public string Content { get; set; }
        public int Rating { get; set; }

        [DataType(DataType.DateTime)] public DateTime Date { get; set;}
    }
}

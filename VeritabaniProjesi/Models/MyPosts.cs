using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeritabaniProjesi.Models
{
    public class MyPosts
    {
        [Key] public int Id { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }

        [DataType(DataType.Currency)]
        public int Rating { get; set; }
    }
}

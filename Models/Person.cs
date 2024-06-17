using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace NLC_Baithi2324.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public int IDperson { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
    }
}
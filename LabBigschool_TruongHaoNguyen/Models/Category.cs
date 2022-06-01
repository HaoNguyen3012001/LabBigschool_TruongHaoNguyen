using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabBigschool_TruongHaoNguyen.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [stringLength(255)]
        public string Name { get; set; }
    }
}
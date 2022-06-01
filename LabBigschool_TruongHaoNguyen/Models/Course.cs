using Microsoft.Build.Framework;
using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabBigschool_TruongHaoNguyen.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerId { get; set; }
        [Required]
        [stringLength(255)]
        public string Place { get; set; }
        public DateTime Datetime { get; set; }
        public Func<DateTime> DateTime { get; internal set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryID { get; set; }

        public static implicit operator Course(Course v)
        {
            throw new NotImplementedException();
        }
    }
}
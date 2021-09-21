using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباریست")]
        [MinLength(3, ErrorMessage = "حداقل باید 3 کاراکتر باشد")]
        [MaxLength(100)]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "ایمیل صحیح نمی باشد")]
        [Required(ErrorMessage = "این فیلد اجباریست")]
        public string Email { get; set; }

        public int Service { get; set; }

        [Required(ErrorMessage = "این فیلد اجباریست")]
        public string Message { get; set; }

        public SelectList Services { get; set; }
    }
}

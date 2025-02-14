﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCar.UI.Models
{
    public class PasswordModel
    {
        [Required]
        [DisplayName("Eski şifre")]
        public string OldPassword { get; set; }
        [Required]
        [DisplayName("Yeni şifre")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Şifreniz en az 5 karakter olmalıdır.")]
        public string NewPassword { get; set; }
        [Required]
        [DisplayName(" Şifre Tekrar")]
        [Compare("NewPassword", ErrorMessage = "Şifreler aynı değil")]
        public string ConNewPassword { get; set; }
    }
}

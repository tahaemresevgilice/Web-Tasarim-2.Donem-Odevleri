using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web14.Models
{
    public class Register
    {
        public int Id { get; set; }

        [Display(Name = "İsim")]
        [Required(ErrorMessage = "{0} giriniz")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "{0} {2}-{1} karakter olmalı")]
        public string ?Name { get; set; }
        [Display(Name = "Soyisim")]
        [Required(ErrorMessage = "{0} giriniz")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "{0} {2}-{1} karakter olmalı")]
        public string ?Surname { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0} giriniz")]
        [EmailAddress(ErrorMessage ="{0} giriniz")]
        public string ?Email { get; set; }
        public double Phone { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string ?Tip { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string ?Cinsiyet { get; set; }
        public int ÜyetipiId { get; set; }
        [Display(Name = "Üye Tipi")]
        [Required(ErrorMessage = "{0} giriniz")]
        public string ?Uyetipi { get; set; }
    }
}
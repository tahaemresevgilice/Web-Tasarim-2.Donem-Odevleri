using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace web14.Models
{
    public class UyeTipi
    {
    public int Id { get; set; }
    [Display(Name = "Üye Tipi")]
    [Required(ErrorMessage = "{0} giriniz")]
    public string ?Uyetipi { get; set; }
    public List<Register>? Registers { get; set; }
    }
}
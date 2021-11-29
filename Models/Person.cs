using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models
{
    [Table ("Persons")]
    public class Person
    {
        [Key]
        [Display(Name = "Mã khách hàng")]
        public string PersonID { get; set; }
        [Display(Name = "Tên Khách hàng")]
        public string PersonName {get; set;}

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CarpentyStore2.Domain.Entities
{
    public class Door
    {   
        [HiddenInput(DisplayValue = false)]
        public int DoorId { get; set; }
        [Required(ErrorMessage ="Пожалуйста, введите тип двери")]
        public string TypeDoor { get; set; }
        [Required(ErrorMessage ="Пожалуйста, введите вид дерево")]
        public string Tree { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage ="Пожалуйста, введите корректную сумму. ")]
        public decimal Price { get; set; }

        public byte[] ImageData { get; set; }
        [HiddenInput(DisplayValue = false)] 
        public string ImageMimeType { get; set; }
    }
}

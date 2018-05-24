using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CarpentyStore2.Domain.Entities
{
    public class Armchair        
    {
        // Модель данных для таблицы Armchairs
        [HiddenInput(DisplayValue = false)]
        public int ArmchairId { get; set; }

        public string TypeOfArmchair { get; set; }
        
        public string Tree { get; set; }
        
        public decimal Price { get; set; }
        
        public byte[] ImageData { get; set; }
        [HiddenInput(DisplayValue = false)]   
        public string ImageMimeType { get; set; } 
    }
}

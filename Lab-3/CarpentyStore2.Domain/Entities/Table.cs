using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CarpentyStore2.Domain.Entities
{
    // Модель данных для таблицы Tables
    public class Table
    {
        [HiddenInput(DisplayValue=false)]
        public int TableId { get; set; }

        public string TypeOfTable { get; set; }

        public string Tree { get; set; }

        public decimal Price { get; set; }

        public byte[] ImageData { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string ImageMimeType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayFashio_M
{
   public class category
    {
       
        public int ID { get; set; }
        public string categoryname { get; set; }
       
        public List<Item> items { get; set; } = new List<Item>();
    }
}

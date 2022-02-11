using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayFashio_M
{
   public class added
    {
        public int ID { set; get; }
        [Required]
        [StringLength(100)]

        public string Name { set; get; }
        [Required]
        [StringLength(25)]

        public string Color { set; get; }
        [Required]
        [StringLength(25)]

        public string Size { set; get; }

        public float Rating { set; get; }
        [Required]
        [StringLength(25)]

        public string Material { set; get; }
        [Required]
        [StringLength(500)]

        public string Description { set; get; }
        [Required]

        public float Price { set; get; }
        /*public List<Image> images { set; get; } = new List<Image>();*/

        [Required]
        public string PathItem { set; get; }
    }
}

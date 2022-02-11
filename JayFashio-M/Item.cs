using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayFashio_M
{
    public class Item
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
    [ForeignKey(nameof(Categorys))]
        public int categoryID { get; set; }
        //navg
        public virtual category Categorys { get; set; }
        public float Price { set; get; }
        public int  coun { set; get; }

        [Required]
        public string PathItem { set; get; }
      public List<Image> images { set; get; } = new List<Image>();

      
    }
}

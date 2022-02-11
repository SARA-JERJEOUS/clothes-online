using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayFashio_M
{
    public class Image
    {
        public int ID { set; get; }
        [Required]
        [StringLength(25)]
        public string Name { set; get; }

        [ForeignKey(nameof(y))]
        public int ItemId { get; set; }

        public virtual Item y { get; set; }

        [Required]
      
        public string PathImage { get; set; }
    }
}

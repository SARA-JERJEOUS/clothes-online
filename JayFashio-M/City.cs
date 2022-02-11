using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayFashio_M
{
    public class City
    {


        [Key]
        public int Id { get; set; }
        [Required]
        public string CityName { set; get; }
        public List<User> Users { get; set; } = new List<User>();


    }
}

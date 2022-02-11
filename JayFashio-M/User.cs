using JayFashio_M;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayFashio_M
{
    public class User
    {
        public int ID { set; get; }
        [Required]
        [StringLength(20)]
        public string FirstName { set; get; }
        [Required]
        [StringLength(20)]
        public string LastName { set; get; }
        [Required]
        [StringLength(16)]
        public string Username { set; get; }
        [Required]
        /**/
        [StringLength(25)]
        public string Password { set; get; }
        [Required]
        [StringLength(255)]
       
        public string Email { set; get; }
        [Required]
        public int DateOFbirth { set; get; }
        public string Role { get; set; } // Customer 

        [ForeignKey(nameof(Location))]
        public int CityId { get; set; }
        //navg
        public virtual City Location { get; set; }

        public string Address1 { set; get; }
        public string Address2 { set; get; }

    }
}

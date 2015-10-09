using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDBAppDEMO
{

    [Table("MemberShipType")]
    public class MemberShipType
    {
        public MemberShipType()
        { }
        [Key]
        public GuestRating GuestRating { get; set; }
        public int Discount { get; set; }
        /// <summary>
        /// how many booking are required to obtain this privilege
        /// </summary>
        public int SumBookings { get; set; }
    }

}

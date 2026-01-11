using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesMarketWF.Entities
{
    public class PickupPointEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Adress { get; set; }

        public List<OrderEntity> Orders { get; set; }

    }
}

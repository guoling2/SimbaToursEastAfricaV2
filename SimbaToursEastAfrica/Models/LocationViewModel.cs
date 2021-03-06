﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbaToursEastAfrica.Models
{
    public class LocationViewModel
    {
        [Key]
        public int LocationId { get; set; }
        public string Country { get; set; }
        [ForeignKey("AddressId")]
        public AddressViewModel Address { get; set; }
        public int AddressId { get; set; }
        public string LocationName { get; set; }
    }

}

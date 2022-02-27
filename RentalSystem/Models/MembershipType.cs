﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalSystem.Models
{
    public class MembershipType
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        // byte is used to select type of membership payment
        [DataType(DataType.Currency)]
        [Required]
        public byte SignUpFee { get; set; }
        [DisplayName("Charge Rate One Month")]
        [Required]
        public byte ChargeRateOneMonth { get; set; }
        [DisplayName("Charge Rate Six Month")]
        [Required]
        public byte ChargeRateSixMonth { get; set; }

    }
}
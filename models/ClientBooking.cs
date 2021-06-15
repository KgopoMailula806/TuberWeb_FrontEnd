﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuadCore_Website.models
{
    public class ClientBooking
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Date_Time { get; set; }
        public int isActive { get; set; }
        public int BookingDetails_BookingRequestTable_Reference { get; set; }
        public int Periods { get; set; }
        public string EndTime { get; set; }
        [Required]
        public int Tutor_Table_Reference { get; set; }
        [Required]
        public int Client_Table_Reference { get; set; }
    }
}
﻿using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int ID { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }
        public SalesRecord()
        {

        }
        public SalesRecord(int iD, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            ID = iD;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}

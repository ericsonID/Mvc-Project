﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public double BaseSalary { get; set; }
        public DateTime BirthDate { get; set; }
        public Department Department { get; set; }

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
        public Seller()
        {

        }
        public Seller(int iD, string name, string email, double baseSalary, DateTime birthDate, Department department)
        {
            ID = iD;
            Name = name;
            Email = email;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            Department = department;
        }
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}

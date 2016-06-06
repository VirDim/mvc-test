using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Purchase
    {
        // ID purchase        
        public int PurchaseId { get; set; }
        //Name 
        public string Person { get; set; }
        //Adres
        public string Address { get; set; }
        // Book Id
        public int BookId { get; set; }
        //Date
        public DateTime Date { get; set; }
    }
}
using System;

namespace PrintingClasses
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int CustomerNo { get; set; }
        public string ForeName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public int PhoneNo { get; set; }
    }
}
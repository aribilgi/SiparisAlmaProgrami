using System;
using System.Collections.Generic;

namespace Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual List<Address> Addresses { get; set; }
        public Customer()
        {
            Addresses = new List<Address>();
        }
    }
}

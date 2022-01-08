using System;

namespace Entities
{
    public class Address : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string OpenAddress { get; set; }
        public DateTime CreateDate { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}

using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public class CustomerRequest
    {
        public string ownId { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public string birthDate { get; set; }
        public Taxdocument taxDocument { get; set; }
        public Phone phone { get; set; }
        public Shippingaddress shippingAddress { get; set; }
        public string method { get; set; }
        public Fundinginstrument fundingInstrument { get; set; }
        public Creditcard creditCard { get; set; }
        public Amount amount { get; set; }
        public List<Item> items { get; set; }
        public Customer customer { get; set; }
    }
}
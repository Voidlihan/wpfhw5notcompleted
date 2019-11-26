using System;

namespace WPF_HW5
{
    public class User : Entity
    {
        public int IIN { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Phonenumber { get; set; }
        public Guid ServiceId { get; set; }
    }
}
using System;

namespace WPF_HW5
{
    public class User : Entity
    {
        public string IIN { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Phonenumber { get; set; }
        public Service ServiceId { get; set; }
    }
}
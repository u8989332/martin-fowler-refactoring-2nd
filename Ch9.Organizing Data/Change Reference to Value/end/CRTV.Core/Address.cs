using System;

namespace CRTV.Core
{
    public class Address
    {
        public Address() : this(string.Empty, string.Empty)
        {

        }

        public Address(string city, string street)
        {
            City = city;
            Street = street;
        }
        
        public string City { get; }
        public string Street { get; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Address);
        }

        public bool Equals(Address other)
        {
            return other != null &&
                   City == other.City &&
                   Street == other.Street;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(City, Street);
        }

    }
}
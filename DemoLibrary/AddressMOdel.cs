using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AddressMOdel
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; } //00852 storing as a string

        public string AddressDisplayValue => $"{StreetAddress}, {City}, {State}  {ZipCode}";

    }
}

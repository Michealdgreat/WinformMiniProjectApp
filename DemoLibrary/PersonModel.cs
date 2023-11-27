using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class PersonModel
    {
        public string firstname { get; set; }
        public string lastName { get; set; }
        public bool IsActive { get; set; }
        public List<AddressMOdel> addresses { get; set; }
    }
}

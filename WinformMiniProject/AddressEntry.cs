using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformMiniProject
{
    public partial class AddressEntry : Form
    {

        IsaveAddress _parent;
        public AddressEntry(IsaveAddress parent)
        {
            InitializeComponent();

            _parent = parent;
        }


        private void Saverecord_Click(object sender, EventArgs e)
        {
            AddressMOdel address = new AddressMOdel
            {
                StreetAddress = StreeAddressText.Text,
                City = CityText.Text,
                State = StateText.Text,
                ZipCode = ZipText.Text,

            };
            _parent.SaveAddress(address);

            this.Close();
        }
    }
}

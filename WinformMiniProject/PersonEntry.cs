using DemoLibrary;
using System.ComponentModel;

namespace WinformMiniProject
{
    public partial class PersonEntry : Form, IsaveAddress
    {
        BindingList<AddressMOdel> addresses = new BindingList<AddressMOdel>();

        public PersonEntry()
        {
            InitializeComponent();

            //addresses.Add(new AddressMOdel
            //{
            //    StreetAddress = "Koydenpunjankatu",
            //    City = "Kokkola",
            //    ZipCode = "67100",
            //    State = "CENTRAL",
            //});

            addressesList.DataSource = addresses;
            addressesList.DisplayMember = nameof(AddressMOdel.AddressDisplayValue);

        }

        private void addNewAddress_Click(object sender, EventArgs e)
        {
            // Open the address Entry Form

            // AddressMOdel newaddressmod = new AddressMOdel();
            AddressEntry entry = new AddressEntry(this);


            entry.Show();

        }

        public void AddnewAddresscomplete(AddressMOdel addressmod)
        {

        }

        public void SaveAddress(AddressMOdel address)
        {
            addresses.Add(address);
        }

        private void saverecord_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel
            {
                firstname = firstNameText.Text,
                lastName = lastNameText.Text,
                IsActive = isActive.Checked,
                addresses = addresses.ToList(),
            };
        }
    }
}

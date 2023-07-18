using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentForm : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        private decimal storeProfit = 0;


        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorBinding = new BindingSource();

        //constructor no return type
        public ConsignmentForm()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemslistBox.DataSource = itemsBinding;


            itemslistBox.DisplayMember = "Display";
            itemslistBox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListBox.DataSource = cartBinding;

            shoppingCartListBox.DisplayMember = "Display";
            shoppingCartListBox.ValueMember = "Display";

            vendorBinding.DataSource = store.Vendors;
            vendorsListBox.DataSource = vendorBinding;

            vendorsListBox.DisplayMember = "DisplayVendor";
            vendorsListBox.ValueMember = "DisplayVendor";
        }

        private void SetupData()
        {
            //create vendor object
            //Vendor addvendor = new Vendor();

            //addvendor.FirstName = "Akash";
            //addvendor.LastName = "Reddy";
            //addvendor.Commission = 1.5;

            //creating new instance of Vendor
            store.Vendors.Add(new Vendor { FirstName = "Akash", LastName = "Reddy" });
            store.Vendors.Add(new Vendor { FirstName = "Rohan", LastName = "Reddy" });

            store.Items.Add(new Item
            {
                Title = "Formula 1",
                Descripton = "Lewis Hamilton Bio",
                Price = 11.5M,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "Tennis",
                Descripton = "Novak Djokovic Bio",
                Price = 14.5M,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Title = "NBA",
                Descripton = "Kobe Bryant Bio",
                Price = 24.0M,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "Soccer",
                Descripton = "Cristiano Ronaldo Bio",
                Price = 27.5M,
                Owner = store.Vendors[1]
            });

            store.Name = "Grey Matter Books";
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)itemslistBox.SelectedItem;
            shoppingCartData.Add(selectedItem);

            cartBinding.ResetBindings(false);
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit+= (1- (decimal)item.Owner.Commission) * item.Price;
            }
            shoppingCartData.Clear();
            storeProfitValue.Text = string.Format("$0", storeProfit);
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorBinding.ResetBindings(false);


        }


    }
}

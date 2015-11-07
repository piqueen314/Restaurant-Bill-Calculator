using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBillCalc
{
    public partial class BillCalc : Form
    {
        List<string> _items = new List<string>();
        private double subTotal = 0.0;
        private double tax = 0.0;
        private double total = 0.0;

        public BillCalc()
        {
            InitializeComponent();

        }

        private void appetizercComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var price = getPrice(appetizercComboBox.SelectedIndex, "appetizer");
            _items.Add(appetizercComboBox.Text + "\t" + price.ToString("C2"));
            receiptListBox.DataSource = null;
            receiptListBox.DataSource = _items;
            subTotal += price;
            subtotalTextBox.Text = subTotal.ToString("N2");
            tax = .075*subTotal;
            taxTextBox.Text = tax.ToString("N2");
            total = subTotal + tax;
            totalTextBox.Text = total.ToString("N2");

        }

        private void beverageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var price = getPrice(beverageComboBox.SelectedIndex, "beverage");
            _items.Add(beverageComboBox.Text + "\t" + price.ToString("C2"));
            receiptListBox.DataSource = null;
            receiptListBox.DataSource = _items;
            subTotal += price;
            subtotalTextBox.Text = subTotal.ToString("N2");
            tax = .075 * subTotal;
            taxTextBox.Text = tax.ToString("N2");
            total = subTotal + tax;
            totalTextBox.Text = total.ToString("N2");
        }

        private void dessertComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var price = getPrice(dessertComboBox.SelectedIndex, "dessert");
            _items.Add(dessertComboBox.Text + "\t" + price.ToString("C2"));
            receiptListBox.DataSource = null;
            receiptListBox.DataSource = _items;
            subTotal += price;
            subtotalTextBox.Text = subTotal.ToString("N2");
            tax = .075 * subTotal;
            taxTextBox.Text = tax.ToString("N2");
            total = subTotal + tax;
            totalTextBox.Text = total.ToString("N2");
        }

        private void mainCourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var price = getPrice(mainCourseComboBox.SelectedIndex, "mainCourse");
            _items.Add(mainCourseComboBox.Text + "\t" + price.ToString("C2"));
            receiptListBox.DataSource = null;
            receiptListBox.DataSource = _items;
            subTotal += price;
            subtotalTextBox.Text = subTotal.ToString("N2");
            tax = .075 * subTotal;
            taxTextBox.Text = tax.ToString("N2");
            total = subTotal + tax;
            totalTextBox.Text = total.ToString("N2");
        }

        public double getPrice(int indexNum, string itemType)
        {
            double price =0.0;
            if (itemType == "beverage")
            {
                switch (indexNum)
                {
                    case 0:
                        price = 1.95;
                        break;
                    case 1:
                        price = 1.50;
                        break;
                    case 2:
                        price = 1.25;
                        break;
                    case 3:
                        price = 2.95;
                        break;
                    case 4:
                        price = 2.50;
                        break;
                    case 5:
                        price = 1.50;
                        break;
                    case 6:
                        price = 3.44;
                        break;
                    case 7:
                        price = 5.22;
                        break;
                }
            }
            else if (itemType == "appetizer")
            {
                switch (indexNum)
                {
                    case 0:
                        price = 5.95;
                        break;
                    case 1:
                        price = 6.95;
                        break;
                    case 2:
                        price = 8.95;
                        break;
                    case 3:
                        price = 8.95;
                        break;
                    case 4:
                        price = 10.95;
                        break;
                    case 5:
                        price = 12.95;
                        break;
                    case 6:
                        price = 6.95;
                        break;
                    case 7:
                        price = 4.45;
                        break;
                    case 8:
                        price = 5.45;
                        break;
                }
            }
            else if (itemType == "dessert")
            {
                switch (indexNum)
                {
                    case 0:
                        price = 5.95;
                        break;
                    case 1:
                        price = 3.95;
                        break;
                    case 2:
                        price = 5.95;
                        break;
                    case 3:
                        price = 4.95;
                        break;
                    case 4:
                        price = 5.95;
                        break;
                }
            }
            else
            {
                switch (indexNum)
                {
                    case 0:
                        price = 13.95;
                        break;
                    case 1:
                        price = 13.95;
                        break;
                    case 2:
                        price =11.95;
                        break;
                    case 3:
                        price = 19.95;
                        break;
                    case 4:
                        price = 20.95;
                        break;
                    case 5:
                        price = 18.95;
                        break;
                    case 6:
                        price = 13.95;
                        break;
                    case 7:
                        price = 14.45;
                        break;
                    case 8:
                        price = 15.45;
                        break;
                }
            }

            return price;
            ;

        }

        private void clearBillButton_Click(object sender, EventArgs e)
        {
            subTotal = 0.0;
            tax = 0.0;
            total = 0.0;
            _items.Clear();
            receiptListBox.DataSource = null;
            receiptListBox.DataSource = _items;
            subtotalTextBox.Text = subTotal.ToString("N2");
            taxTextBox.Text = tax.ToString("N2");
            totalTextBox.Text = total.ToString("N2");

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = receiptListBox.SelectedIndex;
            string parseItem = _items.ElementAt(selectedIndex);
            string[] words = parseItem.Split(Convert.ToChar("$"));
            subTotal -= Convert.ToDouble(words[1]);
            subtotalTextBox.Text = subTotal.ToString("N2");
            tax = .075 * subTotal;
            taxTextBox.Text = tax.ToString("N2");
            total = subTotal + tax;
            totalTextBox.Text = total.ToString("N2");
            _items.RemoveAt(selectedIndex);
            receiptListBox.DataSource = null;
            receiptListBox.DataSource = _items;

        }

       

    }
}

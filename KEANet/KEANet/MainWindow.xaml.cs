using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KEANet
{
    public partial class MainWindow : Window
    {
        Purchase purchase;

        public MainWindow()
        {
            InitializeComponent();

            ListBoxItem lbi1 = new ListBoxItem();
            ListBoxItem lbi2 = new ListBoxItem();
            ListBoxItem lbi3 = new ListBoxItem();
            ListBoxItem lbi4 = new ListBoxItem();
            ListBoxItem lbi5 = new ListBoxItem();
            lbi1.Content = "Motorola G99";
            lbi2.Content = "iPhone 99";
            lbi3.Content = "Samsung Galaxy 99";
            lbi4.Content = "Sony Xperia 99";
            lbi5.Content = "Huawei 99";
            listbox_left.Items.Add(lbi1);
            listbox_left.Items.Add(lbi2);
            listbox_left.Items.Add(lbi3);
            listbox_left.Items.Add(lbi4);
            listbox_left.Items.Add(lbi5);

            purchase = new Purchase();
        }

        private void GreaterThanButton_Click(object sender, RoutedEventArgs e)
        {
            if (listbox_left.SelectedItem != null)
            {
                ListBoxItem temp = (ListBoxItem)listbox_left.SelectedItem;

                ListBoxItem lbi1 = new ListBoxItem();
                lbi1.Content = temp.Content;
                listbox_right.Items.Add(lbi1);

                purchase.SelectCellPhone(temp.Content.ToString());

                updateTotalPriceUI();
            }
        }

        private void LesserThanButton_Click(object sender, RoutedEventArgs e)
        {
            if (listbox_right.SelectedItem != null)
            {
                ListBoxItem temp = (ListBoxItem)listbox_right.SelectedItem;
                listbox_right.Items.Remove(listbox_right.SelectedItem);

                purchase.UnselectCellPhone(temp.Content.ToString());

                updateTotalPriceUI();
            }
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(purchase.Buy());

            listbox_right.Items.Clear();
            checkbox.IsChecked = false;
            purchase.Reset();
            txtNum.Text = purchase.PhoneLines.ToString();

            updateTotalPriceUI();
        }

        private void checkbox_Checked(object sender, RoutedEventArgs e)
        {
            purchase.IncludeExcludeInternetConnection(true);

            updateTotalPriceUI();
        }

        private void checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            purchase.IncludeExcludeInternetConnection(false);

            updateTotalPriceUI();
        }

        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            purchase.IncrementPhoneLineNumber();
            txtNum.Text = purchase.PhoneLines.ToString();

            updateTotalPriceUI();
        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            purchase.DecrementPhoneLineNumber();
            txtNum.Text = purchase.PhoneLines.ToString();

            updateTotalPriceUI();
        }

        private void updateTotalPriceUI()
        {
            priceLabel.Text = purchase.Price.ToString();
        }
    }
}

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

namespace _2025._04._09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int fullprice = 0;
        int oneprice = 200;
        public MainWindow()
        {
            InitializeComponent();
            start();
        }

        void start()
        {
            dbinput.GotFocus += clear;
            dbinput.LostFocus += add;

            pastainput.GotFocus += clear;
            pastainput.LostFocus += add;

            filigninput.GotFocus += clear;
            filigninput.LostFocus += add;

            addbutton.Click += (s, e) =>
            {

                fullprice += oneprice * int.Parse(dbinput.Text);
                all.Children.Add(new Label {Content = $"{filigninput.Text} palacsinta\n {pastainput.Text} teszta\n {dbinput.Text} darab"});
               
                allprice.Content = "Összesen :"+fullprice+"forint";

            };
            order.Click += (ss, ee) =>
            {
                all.Children.Clear();
                allprice.Content = "Összesen :";
            };

            cancelbutton.Click += (sss, eee) =>
            {
                dbinput.Text = "Palacxsinta darabszám";
                pastainput.Text = "Tészta típusa";
                filigninput.Text = "Töltelék típusa";
            };

        }
        
        void clear(object s,EventArgs e )
        {
            TextBox valami = s as TextBox;
            if (valami.Text == valami.Tag.ToString())
            {
                valami.Clear();
            }
        }
        void add(object s, EventArgs e)
        {
            TextBox valami = s as TextBox;
            if (valami.Text == "")
            {
                valami.Text = valami.Tag.ToString();
            }
        }

        private void all_StylusUp(object sender, StylusEventArgs e)
        {

        }
    }
}

using System;
using System.Collections;
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

namespace ArrayListAdd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>    
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Sort();
            foreach (int data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }       
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtAdd.Text == "")
            {
                MessageBox.Show("Please Input Data Hrere");
            }
            else
            {
                arrayList.Add(int.Parse(txtAdd.Text));
                MessageBox.Show("คุณได้เพิ่ม"+ txtAdd.Text);
                txtAdd.Text = "";
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            arrayList.Clear();
            MessageBox.Show("คุณได้ทำการลบข้อมูลทั้งหมดเเล้ว");
        }
    }
}

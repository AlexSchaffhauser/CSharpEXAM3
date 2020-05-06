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

namespace EXAM3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> studentList = new List<Student>();
        int stdCount = 0;

        //Question 3 Number List
        List<int> numList = new List<int>() { 55, 200, 740, 76, 230, 482, 95 };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            stdCount++;
            studentList.Add(new Student(stdCount, FirstName.Text, LastName.Text, IsRegistered.IsChecked.Value));
            MessageBox.Show("Added Students " + stdCount + " time(s)");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Call Question 2 Window
            StudentGrid stdGridWindow = new StudentGrid();
            stdGridWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Run method to display numbers above 80
            Question3.greaterThan80(numList);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Displays students entered in Question 1 in conosle
            foreach (var std in studentList)
            {
                Console.WriteLine("Id = {0}, Name = {1} {2}, Registered = {3}", std.Id, std.FirstName, std.LastName, std.IsRegistered);
            }
        }
    }
}

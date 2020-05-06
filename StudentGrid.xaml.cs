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
using System.Windows.Shapes;

namespace EXAM3
{
    /// <summary>
    /// Interaction logic for StudentGrid.xaml
    /// </summary>
    public partial class StudentGrid : Window
    {
        public StudentGrid()
        {
            InitializeComponent();

            List<Student> stdList = new List<Student>();
            stdList.Add(new Student() { Id = 1, FirstName = "Alex1", LastName = "SB1", IsRegistered = true });
            stdList.Add(new Student() { Id = 2, FirstName = "Alex2", LastName = "SB2", IsRegistered = false });
            stdList.Add(new Student() { Id = 3, FirstName = "Alex3", LastName = "SB3", IsRegistered = false });
            stdList.Add(new Student() { Id = 4, FirstName = "Alex4", LastName = "SB4", IsRegistered = false });
            stdList.Add(new Student() { Id = 5, FirstName = "Alex5", LastName = "SB5", IsRegistered = true });

            stdGrid.ItemsSource = stdList;
        }
    }
}

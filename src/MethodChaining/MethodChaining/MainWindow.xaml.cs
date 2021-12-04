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

namespace MethodChaining
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SampleMethod();
        }

        private void SampleMethod()
        {

            int[] numbers = { 2, 3, 5, 6 };

            var getValue = numbers.Select(x => x * 2)
                                  .Where(x => x != 4)
                                  .OrderBy(x => x);


        }
    }
}

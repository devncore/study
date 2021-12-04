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
            int[] nums = { 2, 3, 5, 6 };
            int[] result = new int[4];
            int i = 0;

            foreach (var row in nums)
            {
                int var1 = row * 2;
                if (var1 != 4)
                {
                    result[i] = var1;
                    i++;
                }
            }

            var getNum = result.OrderByDescending(x => x);


            int[] numbers = { 2, 3, 5, 6 };

            var getValue = numbers.Select(x => x * 2)
                                  .Where(x => x != 4)
                                  .OrderByDescending(x => x);

        }
    }
}

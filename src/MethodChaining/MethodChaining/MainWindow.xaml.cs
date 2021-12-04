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
            List<int> cnts = new List<int>();

            cnts.Add(2);
            cnts.Add(3);
            cnts.Add(5);
            cnts.Add(6);

            List<int> getCnt = new List<int>();

            foreach (var row in cnts)
            {
                var a = row * 2;

                if (a == 4)
                {
                    continue;
                }

                getCnt.Add(a);
            }

            var getList = getCnt.OrderByDescending(x => x).ToArray();


            int[] nums = { 2, 3, 5, 6 };
            int[] values = new int[4];
            int i = 0;

            foreach (var row in nums)
            {
                int val = row * 2;

                if (val == 0)
                {
                    continue;
                }

                if (val != 4)
                {
                    values[i] = val;
                    i++;
                }
            }

            var getNum = values.OrderByDescending(x => x);

            int[] numbers = { 2, 3, 5, 6 };

            var getValue = numbers.Select(x => x * 2)
                                  .Where(x => x != 4)
                                  .OrderByDescending(x => x);
        }
    }
}

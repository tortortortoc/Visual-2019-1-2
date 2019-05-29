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
using System.Windows.Threading;

namespace N023_DigitalClock
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer t = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            t.Interval = new TimeSpan(0, 0, 0, 0, 10);
            t.Tick += T_Tick;
            t.Start();

            DispatcherTimer t1 = new DispatcherTimer();
            t1.Interval = new TimeSpan(0,0,10); //10초
            t1.Tick += T1_Tick;
            t1.Start();
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            dClock.Text = DateTime.Now.ToString() + DateTime.Now.Millisecond;
            string s = string.Format("{0}:{1,3:000}", DateTime.Now.ToString(), DateTime.Now.Millisecond);
            dClock.Text = s;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            t.Start();
        }
    }
}


/*알아야 할것
 1.wpf에서는 dispatcherTimer를 사용
 2.interval 속성이 timespan입니다.
 3.TimeSpan(일,시,뷴,초,밀리초) or TimeSpan(시,분,초)
 4.dateTime.Now.Tostring():초까지 알려줍니다.
 5.DateTime.Now.Millisecond속성을 사용합니다.
 6.String.Format()으로 문자열 만드는 방법
     */

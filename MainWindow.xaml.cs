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

namespace oef_10._8_wekker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer _clockTimer = new DispatcherTimer();
        DispatcherTimer _alarmTimer = new DispatcherTimer();
       
        private AlarmClock alarmTime;
        public MainWindow()
        {
            InitializeComponent();

            _clockTimer.Start();
            _alarmTimer.Start();
            Console.WriteLine(alarmTime);

        }

        private void setAlarmButton_Click(object sender, RoutedEventArgs e)
        {
            //int hours = Convert.ToInt32(setHoursTextBox.Text);
            // int min = Convert.ToInt32(setSecTextBox.Text);
            try
            {
                //alarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(setHoursTextBox.Text), Convert.ToInt32(setMinTextBox.Text), Convert.ToInt32(setSecTextBox.Text));
                alarmTime = new AlarmClock(Convert.ToInt32(hourAlarm.Text), Convert.ToInt32(minuteAlarm.Text), Convert.ToInt32(secondsAlarm.Text));
            }
            catch (Exception)
            { }
            
        }
    }
}

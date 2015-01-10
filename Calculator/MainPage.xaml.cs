using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Calc calc = new Calc();
        public double num1 ;
        public double num2 ;
        public int flag =0 ;
        public string temp1 = "";
        public string temp2 = "";
        public string sign = "";
        

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void numberButton_Click(object sender, RoutedEventArgs e)
        {
                var number = sender as Button;

                if (flag == 0)
                {
                    temp1 += number.Content.ToString();
                    resultBox.Text = temp1;
                }
                else if (flag != 0)
                {
                    temp2 += number.Content.ToString();
                    resultBox.Text = temp1 + sign + temp2;
                }

                    
            
        }
         
        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            flag++;
            sign = "-";
            resultBox.Text = temp1 + sign ;
        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {
            flag++;
            sign = "/";
            resultBox.Text = temp1 + sign;
        }

        private void multipliccationButton_Click(object sender, RoutedEventArgs e)
        {
            flag++;
            sign = "*";
            resultBox.Text = temp1 + sign;
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            flag++;
            sign = "+";
            resultBox.Text = temp1 + sign;
        }


        private void equalButton_click(object sender, RoutedEventArgs e)
        {
            perform();
        }
      

        public void perform()
        {
            num1 = double.Parse(temp1);
            num2 = double.Parse(temp2);

            calc.calculation(sign, num1, num2);
            resultBox.Text = calc.result.ToString();

            flag = 0;
            temp1 = "";
            temp2 = "";
        }



        
    }
}

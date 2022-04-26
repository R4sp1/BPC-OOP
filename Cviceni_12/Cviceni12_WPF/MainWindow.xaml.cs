using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace Cviceni12_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string oper = operation.Text;
            if(oper == "+")
            {
                oper = "plus";
            }else if(oper == "-")
            {
                oper = "minus";
            }else if(oper == "*")
            {
                oper = "krat";
            }else if(oper == "/")
            {
                oper = "deleno";
            }
            string num1;
            string num2;
            string res;
            try
            {
                num1 = number1.Text;
                num2 = number2.Text;
                res = Kalkuluj(num1, num2, oper);
            }
            catch (Exception)
            {
                res = "Error";
            }
            result.Text = res.ToString();

        }

        public class CalcData
        {
            public string Operace { get; set; }
            public decimal Operand1 { get; set; }
            public decimal Operand2 { get; set; }
        }

        private string Kalkuluj(string a, string b, string op)
        {
            CalcData calcData = new CalcData
            {
                Operace = op,
                Operand1 = Convert.ToDecimal(a),
                Operand2 = Convert.ToDecimal(b)
            };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44372//");
            HttpResponseMessage response =
            client.PostAsJsonAsync("api/values", calcData).Result;
            if (response.IsSuccessStatusCode)
            {
                decimal odpoved = response.Content.ReadAsAsync<decimal>().Result;
                return odpoved.ToString();
            }
            return "Error";
        }
    }
}

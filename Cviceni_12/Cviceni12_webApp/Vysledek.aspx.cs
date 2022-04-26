using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cviceni12_webApp
{
    public partial class Vysledek : System.Web.UI.Page
    {
        public class CalcData
        {
            public string Operace { get; set; }
            public decimal Operand1 { get; set; }
            public decimal Operand2 { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string num1 = Request.QueryString["num1"];
            string num2 = Request.QueryString["num2"];
            string oper = Request.QueryString["op"];
            if (num1 != null && num2 != null && oper != null)
            {
                if (oper == "plus")
                {
                    Response.Write(String.Format("{0} {1} {2} = {3}", num1, "+", num2, Kalkuluj(num1, num2, oper)));
                }
                else if (oper == "minus")
                {
                    Response.Write(String.Format("{0} {1} {2} = {3}", num1, "-", num2, Kalkuluj(num1, num2, oper)));
                }
                else if (oper == "krat")
                {
                    Response.Write(String.Format("{0} {1} {2} = {3}", num1, "*", num2, Kalkuluj(num1, num2, oper)));
                }
                else if (oper == "deleno")
                {
                    Response.Write(String.Format("{0} {1} {2} = {3}", num1, "/", num2, Kalkuluj(num1, num2, oper)));
                }
            }
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
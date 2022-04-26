using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cviceni12_webApp
{
    public partial class Default : System.Web.UI.Page
    {
        public class CalcData
        {
            public string Operace { get; set; }
            public decimal Operand1 { get; set; }
            public decimal Operand2 { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void compute_Click(object sender, EventArgs e)
        {
            Response.Redirect(String.Format("Vysledek.aspx?num1={0}&num2={1}&op={2}",
                Operand1.Text, Operand2.Text, DropDownList1.SelectedValue));
        }
    }
}
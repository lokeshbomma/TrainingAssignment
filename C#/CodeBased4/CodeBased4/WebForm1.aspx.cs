using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeBased4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "select", "Benz", "Jaguar", "Porsche", "Audi", "Bugatti" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Benz.ImageUrl = "~/Images/" + str + ".jfif";
        }




        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {



        }



        protected void Button1_Click1(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "Benz")
            {
                TextBox1.Text = "Rs 1000000";
            }
            else if (DropDownList1.Text == "Jaguar")
            {
                TextBox1.Text = "Rs 1440000";
            }
            else if (DropDownList1.Text == "Porsche")
            {
                TextBox1.Text = "Rs 12130000";
            }
            else if (DropDownList1.Text == "Audi")
            {
                TextBox1.Text = "Rs 1320000";
            }
            else if (DropDownList1.Text == "Bugatti")
            {
                TextBox1.Text = "Rs 1700000";
            }



            else
            {
                TextBox1.Text = "Rs 3700000";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculator_using__btn_textbox
{
    public partial class calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            if (sender == Button1)
            {
                TextBox3.Text = Convert.ToString(Convert.ToDouble(TextBox1.Text) + Convert.ToDouble(TextBox2.Text));
                Label1.Text = Convert.ToString(Convert.ToDouble(TextBox1.Text) + Convert.ToDouble(TextBox2.Text));
            }
            if (sender == Button2)
            {
                TextBox3.Text = Convert.ToString(Convert.ToDouble(TextBox1.Text) - Convert.ToDouble(TextBox2.Text));
                Label1.Text = Convert.ToString(Convert.ToDouble(TextBox1.Text) - Convert.ToDouble(TextBox2.Text));
            }
            if (sender == Button3)
            {
                TextBox3.Text = Convert.ToString(Convert.ToDouble(TextBox1.Text) * Convert.ToDouble(TextBox2.Text));
                Label1.Text = Convert.ToString(Convert.ToDouble(TextBox1.Text) * Convert.ToDouble(TextBox2.Text));
            }
            if (sender == Button4)
            {
                TextBox3.Text = Convert.ToString(Convert.ToDouble(TextBox1.Text) / Convert.ToDouble(TextBox2.Text));
                Label1.Text = Convert.ToString(Convert.ToDouble(TextBox1.Text) / Convert.ToDouble(TextBox2.Text));
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}
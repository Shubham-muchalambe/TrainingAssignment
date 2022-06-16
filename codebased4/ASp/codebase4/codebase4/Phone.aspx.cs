using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace codebase4
{
    public partial class Phone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {





                string[] str = new string[] { "IPhone","MI","samsung","Vivo" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Images/" + str + ".jpg";
            if (DropDownList1.Items.FindByText("IPhone").Selected == true)
            {
                Label1.Text = "Price: 1,00,000/-";
            }
            else if (DropDownList1.Items.FindByText("MI").Selected == true)
            {
                Label1.Text = "Price: 15,0000/-";
            }
            else if (DropDownList1.Items.FindByText("samsung").Selected == true)
            {
                Label1.Text = "Price: 25,00,000/-";
            }
           
            else
            {
                Label1.Text = "Price: 40,000/-";
            }
        }
    }
}
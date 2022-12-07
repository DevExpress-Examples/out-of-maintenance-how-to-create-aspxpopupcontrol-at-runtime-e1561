using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {        
        ASPxPopupControl popup = new ASPxPopupControl();
        popup.ID = "popup";
        popup.ClientInstanceName = "popup";

        popup.HeaderText = "Runtime Popup";
        popup.Controls.Add(GetControl());

        form1.Controls.Add(popup);
    }

    Control GetControl()
    {
        TextBox txt = new TextBox();
        txt.ID = "txt";
        txt.Width = 200;
        txt.Text = "Dynamic control";

        return txt;
    }
}

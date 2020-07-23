using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UI_UI : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ObjUBO.Name = txtname.Text;
        ObjUBO.address = txAddress.Text;
        ObjUBO.EmailID = txtEmailid.Text;
        ObjUBO.Mobilenumber = txtmobile.Text;

        UserBL objUBL = new UserBL();

        int result = objUBL.SaveUserregisrationBL(ObjUBO);

        if (result > 0)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Data saved successfully By Using 3 tier by :-sai')", true);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Net;
using System.IO;
using ASPSnippets.SmsAPI;

public partial class CS : System.Web.UI.Page
{
    protected void btnSend_Click(object sender, EventArgs e)
    {
        SMS.APIType = SMSGateway.Site2SMS;
        SMS.MashapeKey = "E46zFB7xtPmshUPwokhPmnXuatrfp1XKRpZjsn3SCSkA8cT3MT";
        SMS.Username = txtNumber.Text.Trim();
        SMS.Password = txtPassword.Text.Trim();
        if (txtRecipientNumber.Text.Trim().IndexOf(",") == -1)
        {
            //Single SMS
            SMS.SendSms(txtRecipientNumber.Text.Trim(), txtMessage.Text.Trim());
        }
        else
        {
            //Multiple SMS
            List<string> numbers = txtRecipientNumber.Text.Trim().Split(',').ToList();
            SMS.SendSms(numbers, txtMessage.Text.Trim());
        }
    }
}
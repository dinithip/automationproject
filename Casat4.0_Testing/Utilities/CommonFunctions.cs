using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using Casat4._0_Testing.ObjectRepo.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Casat4._0_Testing.Utilities
{
    class CommonFunctions
    {

        public static void Login(Manager m,string uname,string pw,string Url)
        {
            m.ActiveBrowser.NavigateTo(Url);

            m.ActiveBrowser.Window.Maximize();

            ObjLogin objlogin = new ObjLogin(m);

            // Define Vriables for the classes
            HtmlInputText username = objlogin.txtusername.As<HtmlInputText>();
            HtmlInputPassword password = objlogin.txtpassword.As<HtmlInputPassword>();
            Element login = objlogin.btnlogin;

            // Assign values
            username.Text = uname;
            password.Text = pw;
            m.ActiveBrowser.Actions.Click(login);

            Thread.Sleep(1000);
            m.ActiveBrowser.WaitUntilReady();
            m.ActiveBrowser.RefreshDomTree();

            
        }
    }
}

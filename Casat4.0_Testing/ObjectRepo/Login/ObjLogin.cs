using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Login
{
    class ObjLogin
    {
        private Manager _manager;

        public ObjLogin(Manager m)
        {
            _manager = m;
        }

        public Element txtusername{ get { return _manager.ActiveBrowser.Find.ById("validation-email"); } }

        public Element txtpassword { get { return _manager.ActiveBrowser.Find.ById("validation-password"); } }

        public Element btnlogin { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='form-validation']/div[4]/button"); } }

        // Invalid Login
        public Element invalidloginMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div/div/div/div[2]/div"); } }


        // USER LOCK after 3 attempts

        public Element un { get { return _manager.ActiveBrowser.Find.ById("validation-email"); } }

        public Element pw { get { return _manager.ActiveBrowser.Find.ById("validation-password"); } }

        public Element userlockedMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div/div/div/div[2]/div"); } }

        public Element usernamesearch { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[2]/th[3]/input"); } }

        public Element usertable { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]"); } }

        // Login screen view

        public Element loginpgheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div/div/div/div[2]/h3"); } }

        public Element usernamelabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='form-validation']/div[1]/label"); } }

        public Element passwordlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='form-validation']/div[2]/label"); } }

        public Element remembermelabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='form-validation']/div[3]/div/label"); } }

        public Element forgotlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='form-validation']/div[3]/a"); } }

        public Element signinname { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='form-validation']/div[4]/button"); } }
    }
}

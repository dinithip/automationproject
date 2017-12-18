using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Login
{
    class ObjFirstTimeLogin
    {
        private Manager _manager;

        public ObjFirstTimeLogin(Manager m)
        {
            _manager = m;
        }

        public Element usn { get { return _manager.ActiveBrowser.Find.ById("validation-email"); } }

        public Element pwd { get { return _manager.ActiveBrowser.Find.ById("validation-password"); } }

        public Element signbtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='form-validation']/div[6]/button"); } }

        public Element newpw1 { get { return _manager.ActiveBrowser.Find.ById("password1"); } }

        public Element newpw2 { get { return _manager.ActiveBrowser.Find.ById("password2"); } }

        public Element changebutton { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='form-validation']/div[3]/button"); } }

        public Element pageheadingtxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='form-validation']/h5"); } }

        public Element verifylogtitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h"); } }

        public Element verifypwmismatchMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='form-validation']/div[1]"); } }
    }
}

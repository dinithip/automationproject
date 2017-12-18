using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Adduser
{
    class ObjAdduser
    {
        private Manager _manager;

        public ObjAdduser(Manager m)
        {
            _manager = m;
        }
        // Define Constructor
        public Element searchusername { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[2]/th[3]/input"); } }

        public Element casattable { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]"); } }

        //public Element searchusername { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[2]/th[3]/input"); } }

        public Element createbtn { get { return _manager.ActiveBrowser.Find.ById("create"); } }

        public Element usernametxt { get { return _manager.ActiveBrowser.Find.ById("l0"); } }

        public Element txtfrstname { get { return _manager.ActiveBrowser.Find.ById("l1"); } }

        public Element txtlastname { get { return _manager.ActiveBrowser.Find.ById("l2"); } }

        public Element txtemailaddress { get { return _manager.ActiveBrowser.Find.ById("l3"); } }

        public Element txtphone { get { return _manager.ActiveBrowser.Find.ById("l4"); } }

        public Element txtaccessrole { get { return _manager.ActiveBrowser.Find.ById("l5"); } }

        public Element txtdept { get { return _manager.ActiveBrowser.Find.ById("l6"); } }

        public Element btnsave { get { return _manager.ActiveBrowser.Find.ById("save"); } }

        public Element backbtn { get { return _manager.ActiveBrowser.Find.ById("back"); } }

        public Element usernamelength { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[2]/span[2]"); } }

        public Element moveto { get { return _manager.ActiveBrowser.Find.ById("moveTo"); } }

        public Element movefrom { get { return _manager.ActiveBrowser.Find.ById("moveFrom"); } }

        public Element saveMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='msgBar']/div/p[2]"); } }

        public Element existingMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        // Mandatory Messages

        public Element unmandatorymsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[2]/span[1]"); } }

        public Element fnmandatorymsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[2]/div[2]/span"); } }

        public Element lnmandatorymsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[3]/div[2]/span"); } }

        public Element emailmandatorymsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[4]/div[2]/span[1]"); } }

        public Element phonemandatorymsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[5]/div[2]/span[2]"); } }

        // reset user page heading
        public Element pageheadingtxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='form-validation']/h5"); } }
    }
}

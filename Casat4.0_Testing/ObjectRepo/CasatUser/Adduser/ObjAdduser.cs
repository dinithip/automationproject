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

        //public Element searchusername { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[2]/th[3]/input"); } }

        public Element createbtn { get { return _manager.ActiveBrowser.Find.ById("create"); } }

        public Element usernametxt { get { return _manager.ActiveBrowser.Find.ById("l0"); } }

        public Element txtfrstname { get { return _manager.ActiveBrowser.Find.ById("l1"); } }

        public Element txtlastname { get { return _manager.ActiveBrowser.Find.ById("l2"); } }

        public Element txtemailaddress { get { return _manager.ActiveBrowser.Find.ById("l3"); } }

        public Element txtphone { get { return _manager.ActiveBrowser.Find.ById("l4"); } }

        public Element txtaccessrole { get { return _manager.ActiveBrowser.Find.ById("l5"); } }

        public Element txtdept { get { return _manager.ActiveBrowser.Find.ById("l6"); } }

        public Element btnsave { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[8]/div/div[2]/div[1]/input"); } }

        public Element backbtn { get { return _manager.ActiveBrowser.Find.ById("back"); } }

        public Element usernamelength { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[2]/span[2]"); } }

    }
}

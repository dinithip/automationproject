using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Articles.AddArticle
{
    class ObjEditArticle
    {
        private Manager _manager;

        public ObjEditArticle(Manager m)
        {
            _manager = m;
        }

        // EDIT ARTICLE PAGE

        public Element editpagetitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h2"); } }

        // Label names
        public Element editnumberlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[1]/label"); } }

        public Element editnamelabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[2]/div[1]/label"); } }

        public Element editamountlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[3]/div[1]/label"); } }

        public Element edittypelabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[4]/div[1]/label"); } }

        public Element editfromcolabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[5]/div[1]/label"); } }

        public Element edittocolabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[6]/div[1]/label"); } }

        // Text fields

        public Element editnumbertxt { get { return _manager.ActiveBrowser.Find.ById("l0"); } }

        public Element editnametxt { get { return _manager.ActiveBrowser.Find.ById("l1"); } }

      //public Element editamounttxt { get { return _manager.ActiveBrowser.Find.ById("l4"); } }

        public Element edittypetxt { get { return _manager.ActiveBrowser.Find.ById("type"); } }

        public Element editfromcotxt { get { return _manager.ActiveBrowser.Find.ById("fromCo"); } }

        public Element edittocotxt { get { return _manager.ActiveBrowser.Find.ById("toCo"); } }

        // Buttons

        public Element editbtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/p[2]/button"); } }

        public Element updatebtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[5]/div/div[2]/div[1]/input"); } }

        public Element updatebackbtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[7]/div/div[2]/div[2]/button"); } }

        // Check boxes

        public Element editrowcheck1 { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element editrowcheck2 { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        // Random check

        public Element check1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/tbody/tr[1]/td[1]/input"); } }
    }
}

using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Articles.AddArticle
{
    class ObjDeleteArticle
    {
        private Manager _manager;

        public ObjDeleteArticle(Manager m)
        {
            _manager = m;
        }

        // DELETE ARTICLE

        public Element deletepopuptitle { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[1]/h3"); } }

       

        // SINGLE DELETE ARTICLE

        public Element deletebtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/p[4]/button"); } }

        // Row check
        public Element rowcheckdelete1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/tbody/tr/td[1]/input"); } }

        public Element confirmation1 { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[2]/p[2]"); } }

        public Element yesbtn { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[2]"); } }

        public Element nobtn { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[1]"); } }

        
        // delete success message
        public Element deletesuccess { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        // BATCH DELETE ARTICLE

        // Row check
        public Element deleterowcheck1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/tbody/tr[3]/td[1]/input"); } }

        public Element deleterowcheck2 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/tbody/tr[4]/td[1]/input"); } }

        public Element batchdeleteconfirmation { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element yesbtnbatchdelete { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[2]"); } }

        public Element nobtnbatchdelete { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[1]"); } }

        public Element batchdeletesuccess { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        // ------------------------

        // Article Connected to aivities
        public Element connectrowcheck1 { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element connectrowcheck2 { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element connectpopuptitle { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[1]/h3"); } }

        public Element connectconfirmationmsg { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[2]/p[2]"); } }

        public Element connectyesbtn { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[2]"); } }

        public Element connectnobtn { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[1]"); } }

        public Element connectdltsuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }
    }
}

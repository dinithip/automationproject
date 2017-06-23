using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.DIuser.BatchEditDI
{
    class ObjBatchEditDI
    {
        private Manager _manager;

        public ObjBatchEditDI(Manager m)
        {
            _manager = m;
        }

        

        public Element searchoperatorid { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[2]/th[3]/input"); } }

        public Element ditable { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]"); } }

        public Element editbtn { get { return _manager.ActiveBrowser.Find.ById("editDi"); } }

        // edit status & station
        public Element rowcheck1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/tbody/tr[1]/td[1]/input"); } }
        
        public Element rowcheck2 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/tbody/tr[2]/td[1]/input"); } }

        // Row select for Batch Active

        public Element rowcheck3 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/tbody/tr[9]/td[1]/input"); } }

        public Element rowcheck4 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/tbody/tr[10]/td[1]/input"); } }

        // Row select for Batch Deactive

        public Element rowcheck5 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/tbody/tr[9]/td[1]/input"); } }

        public Element rowcheck6 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/tbody/tr[10]/td[1]/input"); } }


        // user management page title
        public Element pgtitletxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/h3"); } }

        // Data fields
        public Element statustxt { get { return _manager.ActiveBrowser.Find.ById("diActive"); } }

        public Element stationtxt { get { return _manager.ActiveBrowser.Find.ById("l6"); } }

        public Element yesbtnbatch { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[2]"); } }

        public Element nobtnbatch { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[1]"); } }

        public Element updatebtn { get { return _manager.ActiveBrowser.Find.ById("update"); } }

        public Element backbtn { get { return _manager.ActiveBrowser.Find.ById("back"); } }

        // Label names

        public Element batcheditpgtitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/h3"); } }

        public Element statuslabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[1]/label"); } }

        public Element stationlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[2]/div[1]/label"); } }


        // onfirmation popup

        public Element confirmationtitle { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[1]/h3"); } }

        public Element confirmationMsg { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[2]/p[2]"); } }


        public Element usermanagementtitletxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/div/h2"); } }
        
        // Success messages

        public Element batchDeactivesuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        public Element batchActivesuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        // success message - status and station update
        public Element batchupdatesuccess { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }


        // No changes and stay on same page

        public Element nochangesMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }
    }
}

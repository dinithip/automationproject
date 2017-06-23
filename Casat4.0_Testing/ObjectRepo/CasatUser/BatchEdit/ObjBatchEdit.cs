//using ArtOfTest.WebAii.Core;
//using ArtOfTest.WebAii.ObjectModel;
//using System;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.CasatUser.BatchEdit
{
    class ObjBatchEdit
    {
        private Manager _manager;

        public ObjBatchEdit(Manager m)
        {
            _manager = m;
        }

        public Element status { get { return _manager.ActiveBrowser.Find.ById("status"); } }

        public Element txtaccessrole { get { return _manager.ActiveBrowser.Find.ById("l5"); } }

        public Element txtdepartment { get { return _manager.ActiveBrowser.Find.ById("l6"); } }

        public Element btnupdate { get { return _manager.ActiveBrowser.Find.ById("update"); } }

        public Element backbtn { get { return _manager.ActiveBrowser.Find.ById("back"); } }

        public Element searchun { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[2]/th[3]/input"); } }

        public Element row1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/tbody/tr[1]/td[1]/input"); } }
        
        public Element row2 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/tbody/tr[2]/td[1]/input"); } }

        public Element editbtn { get { return _manager.ActiveBrowser.Find.ById("edit"); } }

        public Element yesbutton { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[2]"); } }

        public Element nobutton { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[1]"); } }

        public Element title { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h2"); } }

        public Element currentpagetitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/h3"); } }

        public Element usertble { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]"); } }

        public Element successMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        // Label names

        public Element statuslabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[1]/label"); } }

        public Element acessrolelabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[2]/div[1]/label"); } }

        public Element departmentlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[3]/div[1]/label"); } }

    }
}

using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.StandardActivity
{
    class ObjDeleteStandardActivity
    {
        private Manager _manager;

        public ObjDeleteStandardActivity(Manager m)
        {
            _manager = m;
        }

        public Element standardactivitytable { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table"); } }

        public Element searchnamefield { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[2]/th[3]/input[1]"); } }

        public Element rowcheck1 { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element rowcheck2 { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element deletebtn { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element popuptitle { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element deleteconfirmationmsg { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element connectedmsg { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element yesbtn { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element nobtn { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element deletesuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }
    }
}

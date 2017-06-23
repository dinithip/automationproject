using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Orders
{
    class ObjOrderTable
    {
        private Manager _manager;

        public ObjOrderTable(Manager m)
        {
            _manager = m;
        }


        public Element ordertabletitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h2"); } }

        public Element ordertable { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table"); } }

        public Element searchordernum { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table/thead/tr[2]/th[3]/input[1]"); } }

        // Tab names
        public Element ordertab { get { return _manager.ActiveBrowser.Find.ById("orders"); } }

        // Buttons
        public Element createorderbtn { get { return _manager.ActiveBrowser.Find.ById("create"); } }

        public Element publishorderbtn { get { return _manager.ActiveBrowser.Find.ById("publish"); } }

        public Element savefilterbtn { get { return _manager.ActiveBrowser.Find.ById("save"); } }

        public Element editbtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table/tbody/tr[1]/td[7]/p/button[1]"); } }

        public Element deletebtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table/tbody/tr[1]/td[7]/p/button[2]"); } }

        // Table Heading names
        public Element idheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table/thead/tr[1]/th[2]"); } }
       
        public Element ordernumheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table/thead/tr[1]/th[3]"); } }

        public Element ordervariantheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table/thead/tr[1]/th[4]"); } }

        public Element statusheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table/thead/tr[1]/th[5]"); } }

        public Element issuerheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table/thead/tr[1]/th[7]"); } }

        public Element startdateheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table/thead/tr[1]/th[6]"); } }

    }
}

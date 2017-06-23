using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Orders
{
    class ObjCreateOrder
    {
        private Manager _manager;

        public ObjCreateOrder(Manager m)
        {
            _manager = m;
        }

        public Element createorderpgtitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h2"); } }

        public Element searchordernum { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table/thead/tr[2]/th[3]/input[1]"); } }

        // Label names
        public Element ordernnumlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[1]/label"); } }

        public Element datelabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[2]/div[1]/label"); } }

        public Element ordervariantlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[3]/div[1]/label"); } }

        // Data Fields

        public Element ordernumtxt { get { return _manager.ActiveBrowser.Find.ById("orderNumber"); } }

        public Element datetxt { get { return _manager.ActiveBrowser.Find.ById("plannedStartDate"); } }

        public Element ordervarianttxt { get { return _manager.ActiveBrowser.Find.ById("variantString"); } }

        // Buttons

        public Element savebtn { get { return _manager.ActiveBrowser.Find.ById("save"); } }

        public Element backbtn { get { return _manager.ActiveBrowser.Find.ById("back"); } }

        // Save success message
        public Element savesuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }
            // Order has been created successfully

        // Existing order number
        public Element existingmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }
        // Order number (order01) already exists

        // Variant message
        public Element variantinvalidmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }
        // Variant(s) (G5) does not exist



    }
}

using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Products
{
    class ObjDeleteProduct
    {
        private Manager _manager;

        public ObjDeleteProduct(Manager m)
        {
            _manager = m;
        }

        public Element producttable { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table"); } }

        public Element searchproduct { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table/thead/tr[2]/th[3]/input[1]"); } }

        public Element producttabletitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/div[1]/div/h2"); } }

        // Buttons

        public Element deleteproductbtn { get { return _manager.ActiveBrowser.Find.ById("deleteProduct"); } }

        public Element yesbtn { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[2]"); } }

        public Element nobtn { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[1]"); } }

        // popup contents

        public Element popuptitle { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[1]/h3"); } }

        public Element deleteconfirmationmsg { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[2]/p[2]"); } }

        // messages
        public Element deletesuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        public Element cickondeletebtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }
        //Selected product/s have been deleted successfully.

        //Please select at least one product

        // checkboxes

        public Element rowselect1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table/tbody/tr[1]/td[1]/input"); } }

        public Element rowselect2 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table/tbody/tr[2]/td[1]/input"); } }




    }
}

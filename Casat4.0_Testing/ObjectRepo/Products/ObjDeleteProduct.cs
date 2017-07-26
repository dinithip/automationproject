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

        public Element producttable { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element searchproduct { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element producttabletitle { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        // Buttons

        public Element deletebtn { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element yesbtn { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element nobtn { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        // popup contents

        public Element deleteconfirmationmsg { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        // success message
        public Element deletesuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        // checkboxes

        public Element rowselect1 { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element rowselect2 { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }




    }
}

using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Products
{
    class ObjDeleteVariant
    {
        private Manager _manager;

        public ObjDeleteVariant(Manager m)
        {
            _manager = m;
        }

        public Element searchvariant { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element deletevariantbtn { get { return _manager.ActiveBrowser.Find.ById("delete"); } }

        public Element yesbtn { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element nobtn { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element yesbtn2 { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element nobtn2 { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        // Check boxes

        public Element rowcheck1 { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element rowcheck2 { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        // confirmation popups

        public Element deleteconfirmation { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element artifactconfirmation { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        // success message

        public Element deletesuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }




    }
}

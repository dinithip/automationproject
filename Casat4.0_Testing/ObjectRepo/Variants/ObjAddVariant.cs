using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Products
{
    class ObjAddVariant
    {
        private Manager _manager;

        public ObjAddVariant(Manager m)
        {
            _manager = m;
        }

        public Element createpagetitle { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        // Input fields

        public Element variantnametxt { get { return _manager.ActiveBrowser.Find.ById(""); } }

        public Element familytxt { get { return _manager.ActiveBrowser.Find.ById(""); } }

        public Element aliastxt { get { return _manager.ActiveBrowser.Find.ById(""); } }

        public Element grouptxt { get { return _manager.ActiveBrowser.Find.ById(""); } }

        public Element groupnametxt { get { return _manager.ActiveBrowser.Find.ById(""); } }

        public Element freetexttxt { get { return _manager.ActiveBrowser.Find.ById(""); } }

        // Label names

        public Element variantnamelabel { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element familylabel { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element aliaslabel { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element grouplabel { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element groupnamelabel { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element freetextlabel { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        // Buttons

        public Element addvariantbtn { get { return _manager.ActiveBrowser.Find.ById("create"); } }

        public Element savebtn { get { return _manager.ActiveBrowser.Find.ById(""); } }

        public Element backbtn { get { return _manager.ActiveBrowser.Find.ById(""); } }

        // Messages

        public Element savesuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element existingmsg { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        // Mandatory messages

        public Element variantnmmandatory { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element groupmandatory { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        

    }
}

using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Variants
{
    class ObjEditVariant
    {
        private Manager _manager;

        public ObjEditVariant(Manager m)
        {
            _manager = m;
        }

        public Element searchtoedit { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        // BATCH Edit Variant
        public Element rowcheck1 { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element rowcheck2 { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element batchedittitle { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        // input fields
        public Element batchgroup { get { return _manager.ActiveBrowser.Find.ById(""); } }

        public Element freetexttxt { get { return _manager.ActiveBrowser.Find.ById(""); } }

        // Buttons

        public Element editbtn { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element updatebtn { get { return _manager.ActiveBrowser.Find.ById(""); } }

        public Element backbtn { get { return _manager.ActiveBrowser.Find.ById(""); } }

        // messages

        public Element batcheditsuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element groupvalidatemsg { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

    }
}

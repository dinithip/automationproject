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
        public Element rowcheck1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/tbody/tr[1]/td[1]/input"); } }

        public Element rowcheck2 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/tbody/tr[2]/td[1]/input"); } }

        public Element batchedittitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h2"); } }

        // input fields
        public Element batchgroup { get { return _manager.ActiveBrowser.Find.ById("groupId"); } }

        public Element freetexttxt { get { return _manager.ActiveBrowser.Find.ById("freeTextId"); } }

        // Buttons

        public Element editbtn { get { return _manager.ActiveBrowser.Find.ByXPath("edit"); } }

        public Element updatebtn { get { return _manager.ActiveBrowser.Find.ById("update"); } }

        public Element backbtn { get { return _manager.ActiveBrowser.Find.ById("back"); } }

        // messages

        public Element batcheditsuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        public Element groupvalidatemsg { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        // ---------------------------------------------------------------------------------------- //

        // Single Edit variant

        // click on varint link to edit


    }
}

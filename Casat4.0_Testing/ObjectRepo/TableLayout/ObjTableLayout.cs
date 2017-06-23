using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.TableLayout
{
    class ObjTableLayout
    {
        private Manager _manager;

        public ObjTableLayout(Manager m)
        {
            _manager = m;
        }

        public Element editlayoutBtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[1]/th[1]/button"); } }

        public Element editlayouttable { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[2]/table"); } }

        public Element drag { get { return _manager.ActiveBrowser.Find.ById("id"); } }

        public Element drop { get { return _manager.ActiveBrowser.Find.ById("username"); } }

        // Rows

        public Element id { get { return _manager.ActiveBrowser.Find.ById("id"); } }


    }
}

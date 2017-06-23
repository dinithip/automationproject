using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.DIuser.AdduserDI
{
    class ObjDItableContents
    {
        private Manager _manager;

        public ObjDItableContents(Manager m)
        {
            _manager = m;
        }

        public Element ditabletitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/div/h2"); } }

        public Element addbtn { get { return _manager.ActiveBrowser.Find.ById("addDi"); } }

        public Element editbtn { get { return _manager.ActiveBrowser.Find.ById("editDi"); } }

        public Element filterbtn { get { return _manager.ActiveBrowser.Find.ById("saveDi"); } }

        public Element exportbtn { get { return _manager.ActiveBrowser.Find.ById("excel1"); } }

        public Element downloadbtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/p[12]/button"); } }

        // Table headings

        public Element tableheading1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[1]/th[2]"); } }

        public Element tableheading2 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[1]/th[3]"); } }

        public Element tableheading3 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[1]/th[4]"); } }

        public Element tableheading4 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[1]/th[5]"); } }

        public Element tableheading5 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[1]/th[6]"); } }

        public Element tableheading6 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[1]/th[7]"); } }

        public Element tableheading7 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[1]/th[8]"); } }
    }
}

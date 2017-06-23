using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.CasatUser.Adduser
{
    class ObjCasatPageContents
    {
        private Manager _manager;

        public ObjCasatPageContents(Manager m)
        {
            _manager = m;
        }

        public Element titletxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h2"); } }

        public Element addBtnName { get { return _manager.ActiveBrowser.Find.ById("create"); } }

        public Element editBtnName { get { return _manager.ActiveBrowser.Find.ById("edit"); } }

        public Element savefilterBtnName { get { return _manager.ActiveBrowser.Find.ById("save"); } }

        public Element deleteBtnName { get { return _manager.ActiveBrowser.Find.ById("delete"); } }

        public Element exportBtnName { get { return _manager.ActiveBrowser.Find.ById("excel"); } }

        public Element downloadBtnName { get { return _manager.ActiveBrowser.Find.ById("download"); } }

        public Element uploadBtnName { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/p[5]/label/span"); } }

        // Table headings
        public Element idcolumntxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[1]/th[2]"); } }

        public Element uncolumntxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[1]/th[3]"); } }

        public Element fncolumntxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[1]/th[4]"); } }

        public Element lncolumntxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[1]/th[5]"); } }

        public Element emailcolumntxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[1]/th[6]"); } }

        public Element phonecolumntxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[1]/th[7]"); } }

        public Element statuscolumntxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[1]/th[8]"); } }
    }
}

using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.DIuser
{
    class ObjDIuserPageContents
    {
        private Manager _manager;

        public ObjDIuserPageContents(Manager m)
        {
            _manager = m;
        }

        public Element diTitletxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/div/h2"); } }

        public Element addDIBtnName { get { return _manager.ActiveBrowser.Find.ById("addDi"); } }

        public Element EditBtnName { get { return _manager.ActiveBrowser.Find.ById("editDi"); } }

        public Element saveFilterBtnName { get { return _manager.ActiveBrowser.Find.ById("saveDi"); } }

        public Element exportBtnName { get { return _manager.ActiveBrowser.Find.ById("excel1"); } }

        public Element downloadBtnName { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/p[12]/button"); } }

        // DI table headings
        public Element idcolumn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[1]/th[2]"); } }

        public Element operatoridcolumn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[1]/th[3]"); } }

        public Element firstncolumn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[1]/th[4]"); } }

        public Element lastncolumn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[1]/th[5]"); } }

        public Element emailcolumn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[1]/th[6]"); } }

        public Element phonecolumn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[1]/th[7]"); } }

        public Element statuscolumn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[1]/th[8]"); } }
    }
}

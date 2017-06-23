using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.UnlockUser
{
    class ObjUnlockUser
    {
        private Manager _manager;

        public ObjUnlockUser(Manager m)
        {
            _manager = m;
        }

        public Element usertable { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]"); } }

        public Element searchstatus { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[2]/th[8]/select"); } }

        public Element editbtn { get { return _manager.ActiveBrowser.Find.ById("edit"); } }

        // Unlock to Active - Sngle edit

        public Element rowcheck1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/tbody/tr/td[1]/input"); } }

        // Active popup confirmation message

        public Element popupconfirmationmsg { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[2]/p[2]"); } }

        // Unlock to active - Batch Edit

        public Element row1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/tbody/tr[1]/td[1]/input"); } }

        public Element row2 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/tbody/tr[3]/td[1]/input"); } }

        public Element pageheadingtxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='form-validation']/h5"); } }

        public Element inactivesuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        // login using inactive details

        public Element inactiveloginmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div/div/div/div[2]/div"); } }
    }
}

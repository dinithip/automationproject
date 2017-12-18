using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Menus
{
    class ObjMenus
    {
        private Manager _manager;

        public ObjMenus(Manager m)
        {
            _manager = m;
        }

        public Element systemlink { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/section/div/div[1]/div/nav/div[2]/ul/li[2]"); } }
        
        public Element userslink { get { return _manager.ActiveBrowser.Find.ById("user"); } }

        public Element accessrolelink { get { return _manager.ActiveBrowser.Find.ById("accessRole"); } }

        public Element settinglink { get { return _manager.ActiveBrowser.Find.ById("swttings"); } }

        public Element systemloglink { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[2]/ul/li[2]/a"); } }
        
        public Element Datalink { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[2]/ul/li[3]/a"); } }

        public Element productlink { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[2]/ul/li[3]/ul/li[1]/a"); } }

        public Element Articlelink { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[2]/ul/li[3]/ul/li[2]/a"); } }

        public Element AUGlink { get { return _manager.ActiveBrowser.Find.ById("articleUsage"); } }

        public Element processlink { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[2]/ul/li[4]/a"); } }

        public Element standardactivitylink { get { return _manager.ActiveBrowser.Find.ById("activity"); } }

        public Element DI { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/section/div/div[1]/div/nav/div[2]/ul/li[6]"); } }

        public Element orderlink { get { return _manager.ActiveBrowser.Find.ById("order"); } }

        // Logout

        public Element user { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/section/div/div[1]/div/nav/div[2]/ul/li[7]"); } }

        public Element logoutlink { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[2]/ul/li[7]/ul/li[2]/a"); } }
    }
}

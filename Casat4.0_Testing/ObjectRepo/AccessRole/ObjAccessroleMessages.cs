using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.AccessRole
{
    class ObjAccessroleMessages
    {
        private Manager _manager;

        public ObjAccessroleMessages(Manager m)
        {
            _manager = m;
        }

        public Element successfullyCreateMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[1]"); } }

        public Element successfullysaveMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[1]"); } }

        public Element existingMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }
    }
}

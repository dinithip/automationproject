using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Articles.AddArticle
{
    class ObjAddArticle
    {
        private Manager _manager;

        public ObjAddArticle(Manager m)
        {
            _manager = m;
        }

        public Element titletxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h2"); } }

        public Element articlenumbertxt { get { return _manager.ActiveBrowser.Find.ById("l0"); } }

        public Element articlenametxt { get { return _manager.ActiveBrowser.Find.ById("l1"); } }

        public Element amounttxt { get { return _manager.ActiveBrowser.Find.ById("l4"); } }

        public Element articletypetxt { get { return _manager.ActiveBrowser.Find.ById("type"); } }

        public Element btnsave { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[5]/div/div[2]/div[1]/input"); } }

        public Element btnback { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[5]/div/div[2]/div[2]/button"); } }
    }
}

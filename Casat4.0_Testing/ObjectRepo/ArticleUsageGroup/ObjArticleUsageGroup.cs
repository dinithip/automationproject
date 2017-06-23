using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.ArticleUsageGroup
{
    class ObjArticleUsageGroup
    {

        private Manager _manager;

        public ObjArticleUsageGroup(Manager m)
        {
            _manager = m;
        }

        public Element ammountamounttxt { get { return _manager.ActiveBrowser.Find.ById("amount"); } }

        public Element unit { get { return _manager.ActiveBrowser.Find.ById("unit"); } }

        public Element freetxt { get { return _manager.ActiveBrowser.Find.ById("freeText");} }

        public Element codetxt { get { return _manager.ActiveBrowser.Find.ById("code"); } }

        public Element groupselect { get { return _manager.ActiveBrowser.Find.ById("group"); } }

        public Element posselect { get { return _manager.ActiveBrowser.Find.ById("pos"); } }

        public Element opselect { get { return _manager.ActiveBrowser.Find.ById("op"); } }

        public Element articlegroupidselect { get { return _manager.ActiveBrowser.Find.ById("groupId"); } }

        public Element productselect { get { return _manager.ActiveBrowser.Find.ById("productType"); } }

        public Element moduletxt { get { return _manager.ActiveBrowser.Find.ById("moduleFamily"); } }

        public Element fromcoselect { get { return _manager.ActiveBrowser.Find.ById("fromCo"); } }

        public Element tocoselect { get { return _manager.ActiveBrowser.Find.ById("toCo"); } }

        public Element impldateselect { get { return _manager.ActiveBrowser.Find.ById("implDate"); } }

        public Element expiredatselect { get { return _manager.ActiveBrowser.Find.ById("expirationDate"); } }

        public  Element varianttxt { get { return _manager.ActiveBrowser.Find.ById("variantString"); } }

        public Element btnsave { get { return _manager.ActiveBrowser.Find.ById("saveBtn"); } }

        public Element btnback { get { return _manager.ActiveBrowser.Find.ById("cancelBtn"); } }
    }
}

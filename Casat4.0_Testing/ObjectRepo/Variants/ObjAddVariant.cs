using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Products
{
    class ObjAddVariant
    {
        private Manager _manager;

        public ObjAddVariant(Manager m)
        {
            _manager = m;
        }

        public Element createpagetitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h2"); } }

        // Input fields

        public Element variantnametxt { get { return _manager.ActiveBrowser.Find.ById("name"); } }

        public Element familytxt { get { return _manager.ActiveBrowser.Find.ById("familyId"); } }

        public Element aliastxt { get { return _manager.ActiveBrowser.Find.ById("aliasId"); } }

        public Element grouptxt { get { return _manager.ActiveBrowser.Find.ById("groupId"); } }

        public Element groupnametxt { get { return _manager.ActiveBrowser.Find.ById("groupNameId"); } }

        public Element freetexttxt { get { return _manager.ActiveBrowser.Find.ById("freeTextId"); } }

        // Label names

        public Element variantnamelabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[1]/label"); } }

        public Element familylabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[2]/div[1]/label"); } }

        public Element aliaslabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[3]/div[1]/label"); } }

        public Element grouplabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[4]/div[1]/label"); } }

        public Element groupnamelabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[5]/div[1]/label"); } }

        public Element freetextlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[6]/div[1]/label"); } }

        // Buttons

        public Element addvariantbtn { get { return _manager.ActiveBrowser.Find.ById("create"); } }

        public Element savebtn { get { return _manager.ActiveBrowser.Find.ById("save"); } }

        public Element backbtn { get { return _manager.ActiveBrowser.Find.ById("back"); } }

        // Messages

        public Element savesuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        public Element existingmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        // Mandatory messages

        public Element variantnmmandatory { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[2]/span"); } }

        public Element groupmandatory { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[4]/div[2]/span"); } }

        

    }
}

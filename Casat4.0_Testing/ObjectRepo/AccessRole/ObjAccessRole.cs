using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.AccessRole
{
    class ObjAccessRole
    {

        private Manager _manager;

        public ObjAccessRole(Manager m)
        {
            _manager = m;
        }

        // Heading names

        public Element pagetitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h2"); } }

        // Create Access role
        public Element createtitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[1]/div/h4"); } }

        public Element nametxt { get { return _manager.ActiveBrowser.Find.ById("l1"); } }

        public Element createbtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[2]/div[3]/button"); } }

        // Edit Access role
        public Element edittitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/div[1]/div/h4"); } }

        public Element accessdropdown { get { return _manager.ActiveBrowser.Find.ById("accessRoles"); } }

        public Element savebtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/div[2]/div[3]/button[1]"); } }

        public Element deletebtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/div[2]/div[3]/button[2]"); } }

        public Element createcopybtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/div[2]/div[3]/button[3]"); } }

        // table heading
        public Element tableheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/div[3]/table/thead/tr[1]/th[2]"); } }


    }
}

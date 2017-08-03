using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.ActiveDeactiveuser
{
    class ObjActiveDeactive
    {
        private Manager _manager;

        public ObjActiveDeactive(Manager m)
        {
            _manager = m;
        }

        public Element searchusername { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[2]/th[3]/input"); } }

        public Element row1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/tbody/tr[1]/td[1]/input"); } }

        public Element row2 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/tbody/tr[2]/td[1]/input"); } }

        public Element updatebtn { get { return _manager.ActiveBrowser.Find.ById("update"); } }

        // Active popup

        public Element activepoupheading { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[1]/h3"); } }

        public Element activeconfirmationtxt { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[1]/h3"); } }

        public Element nobtn { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[1]"); } }

        public Element yebtn { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[2]"); } }

        public Element activesuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        //Deactive popup
        public Element deactivepopupheading { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[1]/h3"); } }

        public Element deactiveconfirmationtxt { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[2]/p[2]"); } }

        public Element deactivesuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        


    }
}

using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.CasatUser.Edit
{
    class ObjEditUser
    {
        private Manager _manager;

        public ObjEditUser(Manager m)
        {
            _manager = m;
        }

        public Element casattable { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]"); } }

        public Element editbutton { get { return _manager.ActiveBrowser.Find.ById("edit"); } }

        public Element titletxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/h3"); } }

        // Text fields
        public Element usernmtxt { get { return _manager.ActiveBrowser.Find.ById("l0"); } }

        public Element firstnametxt { get { return _manager.ActiveBrowser.Find.ById("l1"); } }

        public Element lastnametxt { get { return _manager.ActiveBrowser.Find.ById("l2"); } }

        public Element emailtxt { get { return _manager.ActiveBrowser.Find.ById("l3"); } }

        public Element phonetxt { get { return _manager.ActiveBrowser.Find.ById("l4"); } }

        public Element status { get { return _manager.ActiveBrowser.Find.ById("status"); } }

        public Element txtaccessrole { get { return _manager.ActiveBrowser.Find.ById("l5"); } }

        public Element txtdepartment { get { return _manager.ActiveBrowser.Find.ById("l6"); } }

        // Buttons
        public Element btnupdate { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[9]/div/div[2]/div[1]/input"); } }

        public Element backbtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[9]/div/div[2]/div[2]/button"); } }

        public Element yesbtn { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[2]"); } }
        
        public Element nobtn { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[1]"); } }

        public Element accessMoveto { get { return _manager.ActiveBrowser.Find.ById("moveATo"); } }

        public Element accessMovefrom { get { return _manager.ActiveBrowser.Find.ById("moveAFrom"); } }

        public Element dptMoveto { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[8]/div[3]/button[1]/span"); } }

        public Element dptMovefrom { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[8]/div[3]/button[2]"); } }

        // Messages

        public Element usernamelengthmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[2]/span[2]"); } }

        public Element updateMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }
        
        public Element clickonEditbtnMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        public Element UpdateActiveconfirmationPopup { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[2]/p[2]"); } }

        public Element UpdateActiveSuccessMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]/text()"); } }

        public Element UpdateDeactiveconfirmationPopup { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[2]/p[2]"); } }

        public Element UpdateDeactiveSuccessMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]/text()"); } }

        public Element searchUsername { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[2]/th[3]/input"); } }

        public Element usertable { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]"); } }

        // Checkbox
        public Element rowcheck { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/tbody/tr[1]/td[1]/input"); } }

        public Element rowcheck2 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/tbody/tr[13]/td[1]/input"); } }

        // Existing message
        public Element existingUsername { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        // Label names

        public Element label1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[1]/label"); } }

        public Element label2 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[2]/div[1]/label"); } }

        public Element label3 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[3]/div[1]/label"); } }

        public Element label4 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[4]/div[1]/label"); } }

        public Element label5 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[5]/div[1]/label"); } }

        public Element label6 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[6]/div[1]/label"); } }

        public Element label7 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[7]/div[1]/label"); } }

        public Element label8 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[8]/div[1]/label"); } }
        
        public Element label9 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[7]/div[2]/span"); } }

        public Element label10 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[7]/div[4]/span[1]"); } }

        public Element label11 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[8]/div[2]/span"); } }

        public Element label12 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[8]/div[4]/span"); } }

        // Mandatory messages
        public Element mandatorymsg1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[2]/span[1]"); } }

        public Element mandatorymsg2 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[2]/div[2]/span"); } }

        public Element mandatorymsg3 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[3]/div[2]/span"); } }

        public Element mandatorymsg4 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[4]/div[2]/span[2]"); } }

        public Element mandatorymsg5 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[5]/div[2]/span[2]"); } }

        public Element mandatorymsg6 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[7]/div[4]/span[2]"); } }
    }
}

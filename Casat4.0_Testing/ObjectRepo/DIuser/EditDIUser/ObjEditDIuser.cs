using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.DIuser.EditDIUser
{
    class ObjEditDIuser
    {
        private Manager _manager;

        public ObjEditDIuser(Manager m)
        {
            _manager = m;
        }
        // Usermanagement page
        public Element userpgtitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/div/h2"); } }

        //DI table
        public Element titletxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/h3"); } }

        public Element ditable { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]"); } }
        
        
        // Edit button
        public Element editdibtn { get { return _manager.ActiveBrowser.Find.ById("editDi"); } }

        // Label names

        public Element editlabel1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[1]/label"); } }

        public Element editlabel2 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[2]/div[1]/label"); } }

        public Element editlabel3 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[3]/div[1]"); } }

        public Element editlabel4 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[4]/div[1]/label"); } }

        public Element editlabel5 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[5]/div[1]/label"); } }

        public Element editlabel6 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[6]/div[1]/label"); } }

        public Element editlabel7 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[7]/div[1]/label"); } }

        public Element editlabel8 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[7]/div[2]/span"); } }

        public Element editlabel9 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[7]/div[4]/span"); } }


        // Data fileds
        public Element operatoridtxt { get { return _manager.ActiveBrowser.Find.ById("l0"); } }

        public Element firstnametxt { get { return _manager.ActiveBrowser.Find.ById("l1"); } }

        public Element lastnametxt { get { return _manager.ActiveBrowser.Find.ById("l2"); } }

        public Element emailtxt { get { return _manager.ActiveBrowser.Find.ById("l3"); } }

        public Element phonetxt { get { return _manager.ActiveBrowser.Find.ById("l4"); } }

        public Element statustxt { get { return _manager.ActiveBrowser.Find.ById("status"); } }

        public Element departmenttxt { get { return _manager.ActiveBrowser.Find.ById("l6"); } }

        // Buttons

        public Element searchoperatorid { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[2]/th[3]/input"); } }

        public Element searchfirstname { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[2]/th[4]/input"); } }

        public Element movetobtn { get { return _manager.ActiveBrowser.Find.ById("moveTo"); } }

        public Element movefrombtn { get { return _manager.ActiveBrowser.Find.ById("moveFrom"); } }

        public Element updatebtn { get { return _manager.ActiveBrowser.Find.ById("update"); } }

        public Element backbtn { get { return _manager.ActiveBrowser.Find.ById("back"); } }

        public Element yesbtn { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[2]"); } }

        public Element nobtn { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[3]/button[1]"); } }


        // Checkbox
        public Element row1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/tbody/tr/td[1]/input"); } }

        // Success message
        public Element editsuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }


        // Mandatory messages

        public Element opridMandatoryMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[2]/span[1]"); } }

        public Element fnMandatoryMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[2]/div[2]/span"); } }

        public Element lnMandatoryMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[3]/div[2]/span"); } }

        public Element emailMandatoryMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[4]/div[2]/span[2]"); } }

        public Element phoneMandatoryMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[5]/div[2]/span[2]"); } }

        // Operator id length

        public Element opridlengthMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[2]/span[2]"); } }

        // existing message

        public Element existingdimsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        // click on edit di button without selecting users

        public Element clickonmsgdiedit { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }


    }
}

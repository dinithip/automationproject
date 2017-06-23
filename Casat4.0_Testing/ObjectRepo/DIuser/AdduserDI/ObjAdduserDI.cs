using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.AdduserDI
{
    class ObjAdduserDI
    {
        private Manager _manager;

        public ObjAdduserDI(Manager m)
        {
            _manager = m;
        }

        public Element titletxt { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h3"); } }

        public Element ditabletitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/div/h2"); } }

        
        public Element searchdiuser { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[2]/th[3]/input"); } }

        public Element ditable { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]"); } }

        public Element addbtn { get { return _manager.ActiveBrowser.Find.ById("addDi"); } }

        // Text fields
        public Element operatoridtxt { get { return _manager.ActiveBrowser.Find.ById("operatorId"); } }

        public Element txtfirstname { get { return _manager.ActiveBrowser.Find.ById("firstName"); } }

        public Element txtlastname { get { return _manager.ActiveBrowser.Find.ById("lastName"); } }

        public Element txtemail { get { return _manager.ActiveBrowser.Find.ById("email"); } }

        public Element txtphone { get { return _manager.ActiveBrowser.Find.ById("phone"); } }   

        public Element txtdept { get { return _manager.ActiveBrowser.Find.ById("l6"); } }

        // Buttons
        public Element movetobtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='moveTo']/span"); } }

        public Element movefrombtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='moveFrom']/span"); } }

        public Element savebtn { get { return _manager.ActiveBrowser.Find.ById("create"); } }

        public Element backbtn { get { return _manager.ActiveBrowser.Find.ById("back"); } }

        // Label names

        public Element operatoridLabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[1]/label"); } }

        public Element firstnameLabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[2]/div[1]/label"); } }

        public Element lastnameLabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[3]/div[1]/label"); } }

        public Element emailLabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[4]/div[1]/label"); } }

        public Element phoneLabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[5]/div[1]/label"); } }

        public Element dptLabel1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[6]/div[1]/label"); } }

        public Element dptLabel2 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[6]/div[3]/label"); } }

        // Messages
        public Element successmsgdi { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        public Element existingmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        // Length message
        public Element optLengthmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[2]/span[2]"); } }


    }
}

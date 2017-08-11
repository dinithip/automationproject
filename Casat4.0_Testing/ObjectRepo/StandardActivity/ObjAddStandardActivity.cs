using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Process
{
    class ObjAddStandardActivity
    {
        private Manager _manager;

        public ObjAddStandardActivity(Manager m)
        {
            _manager = m;
        }

        public Element addpagetitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h2"); } }

        public Element addactivitybtn { get { return _manager.ActiveBrowser.Find.ById("create"); } }

        public Element detailstab { get { return _manager.ActiveBrowser.Find.ById("details"); } }

        //search field
        public Element searchnamefield { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[2]/th[3]/input[1]"); } }

        public Element standardactivitytable { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table"); } }

        // Label names
        public Element namelabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[1]/form/div[1]/div[1]/div[2]/div[1]/label"); } }

        public Element freetextlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[1]/form/div[1]/div[1]/div[3]/div[1]/label"); } }

        public Element grouplabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[1]/form/div[1]/div[1]/div[4]/div[1]/label"); } }

        public Element poslabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[1]/form/div[1]/div[1]/div[5]/div[1]/label"); } }

        public Element postlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[1]/form/div[1]/div[1]/div[6]/div[1]/label"); } }

        public Element oplabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[1]/form/div[1]/div[1]/div[7]/div[1]/label"); } }

        public Element activitytypelabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[1]/form/div[1]/div[1]/div[9]/div[1]/label"); } }

        public Element weslabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='wes1']"); } }

        public Element variantlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[1]/form/div[1]/div[2]/div[1]/div/div/div[1]/div[1]/label"); } }

        public Element memolabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[1]/form/div[1]/div[2]/div[1]/div/div/div[1]/div[2]/label"); } }

        public Element additionalmemolabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[1]/form/div[1]/div[2]/div[1]/div/div/div[1]/div[3]/label"); } }


        // Data Fields

        public Element standactivitynametxt { get { return _manager.ActiveBrowser.Find.ById("name"); } }

        public Element freetexttxt { get { return _manager.ActiveBrowser.Find.ById("freeText"); } }
            
        public Element grouptxt { get { return _manager.ActiveBrowser.Find.ById("group"); } }

        public Element postxt { get { return _manager.ActiveBrowser.Find.ById("pos"); } }

        public Element posttxt { get { return _manager.ActiveBrowser.Find.ById("post"); } }

        public Element optxt { get { return _manager.ActiveBrowser.Find.ById("op"); } }

        public Element activitytypetxt { get { return _manager.ActiveBrowser.Find.ById("actType"); } }

        public Element wesslider { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[1]/form/div[1]/div[1]/div[14]/div[2]/div/div/label/div"); } }

        public Element varianttxt { get { return _manager.ActiveBrowser.Find.ById("variantStrings"); } }

        public Element memotxt { get { return _manager.ActiveBrowser.Find.ById("memo"); } }

        public Element additionalmemotxt { get { return _manager.ActiveBrowser.Find.ById("additionalmemo"); } }

        // Buttons
        public Element savebtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[3]/div/div/button[1]"); } }

        public Element publishbtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[3]/div/div/button[2]"); } }

        public Element cancelbtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[3]/div/div/button[3]"); } }

        // Save success message
        public Element savesuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[1]"); } }

        // Existing message
        public Element existingmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[1]"); } }

        // Invalid Varint string message
        
        public Element invalidvariantmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        // Mandatory messages

        public Element namemandatory { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[1]/form/div[1]/div[1]/div[2]/div[2]/span"); } }
        
        public Element variantmandatory { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div[1]/form/div[1]/div[2]/div[1]/div/div/div[2]/div[1]/span"); } }

        public Element mandatoryMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }


        // add Default variant

        public Element globalvariantpopuptitle { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element globalvariantpopupmsg { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element yesbtn { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element nobtn { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }


    }
}

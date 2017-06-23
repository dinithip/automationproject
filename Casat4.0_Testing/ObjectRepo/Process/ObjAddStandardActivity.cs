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

        public Element addpagetitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h3"); } }

        public Element addactivitybtn { get { return _manager.ActiveBrowser.Find.ById("create"); } }

        //search field
        public Element searchnamefield { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[2]/th[3]/input[1]"); } }

        public Element standardactivitytable { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table"); } }

        // Label names
        public Element namelabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[1]/label"); } }

        public Element freetextlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[2]/div[1]/label"); } }

        public Element memolabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[3]/div[1]/label"); } }

        public Element additionalmemolabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[4]/div[1]/label"); } }

        public Element grouplabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[5]/div[1]/label"); } }

        public Element poslabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[6]/div[1]/label"); } }

        public Element postlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[7]/div[1]/label"); } }

        public Element oplabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[8]/div[1]/label"); } }

        public Element weslabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[9]/div[1]/label"); } }

        public Element variantlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[10]/div[1]/label"); } }

        // Data Fields

        public Element standactivitynametxt { get { return _manager.ActiveBrowser.Find.ById("name"); } }

        public Element freetexttxt { get { return _manager.ActiveBrowser.Find.ById("freeText"); } }
     
        public Element memotxt { get { return _manager.ActiveBrowser.Find.ById("memo"); } }

        public Element additionalmemotxt { get { return _manager.ActiveBrowser.Find.ById("additionalMemo"); } }

        public Element grouptxt { get { return _manager.ActiveBrowser.Find.ById("group"); } }

        public Element postxt { get { return _manager.ActiveBrowser.Find.ById("pos"); } }

        public Element posttxt { get { return _manager.ActiveBrowser.Find.ById("post"); } }

        public Element optxt { get { return _manager.ActiveBrowser.Find.ById("op"); } }

        public Element wesslider { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[9]/div[2]/label/div"); } }

        public Element varianttxt { get { return _manager.ActiveBrowser.Find.ById("variantString"); } }

        // Buttons
        public Element savebtn { get { return _manager.ActiveBrowser.Find.ById("saveBtn"); } }

        public Element backbtn { get { return _manager.ActiveBrowser.Find.ById("cancelBtn"); } }

        // Save success message
        public Element savesuccessmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[1]"); } }

        // Existing message
        public Element existingmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[1]"); } }


    }
}

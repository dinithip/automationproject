using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.StandardActivity
{
    class ObjStandardActivity
    {
        private Manager _manager;

        public ObjStandardActivity(Manager m)
        {
            _manager = m;
        }

        public Element standardactivitytbl { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table"); } }

        public Element standardactivitytblheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h2"); } }

        // Table headings
        public Element idlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[2]"); } }

        public Element namelabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[3]"); } }

        public Element variantlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[4]"); } }

        public Element additionalmemolabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[5]"); } }

        public Element grouplabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[6]"); } }

        public Element freetxtlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[7]"); } }

        public Element memolabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[8]"); } }

        public Element picturelabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[9]"); } }

        public Element timelabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[10]"); } }

        public Element weslabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[11]"); } }

        public Element oplabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[12]"); } }

        public Element poslabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[13]"); } }

        public Element postlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[14]"); } }

        public Element createdlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[15]"); } }

        public Element updatedlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[16]"); } }

        // buttons

        public Element addactivitybtn { get { return _manager.ActiveBrowser.Find.ById("create"); } }

        public Element editactivitybtn { get { return _manager.ActiveBrowser.Find.ById("edit"); } }

        public Element savefilterbtn { get { return _manager.ActiveBrowser.Find.ById("save"); } }

        public Element deleteactivitybtn { get { return _manager.ActiveBrowser.Find.ById("delete"); } }

        public Element converttostationbtn { get { return _manager.ActiveBrowser.Find.ById("convert"); } }

        public Element exportbtn { get { return _manager.ActiveBrowser.Find.ById("excel"); } }









    }
}

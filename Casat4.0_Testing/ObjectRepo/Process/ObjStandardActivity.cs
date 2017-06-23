using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Process
{
    class ObjStandardActivity
    {
        private Manager _manager;

        public ObjStandardActivity(Manager m)
        {
            _manager = m;
        }

        public Element standardacttabletitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h2"); } }

            // Buttons

        public Element addactivitybtn { get { return _manager.ActiveBrowser.Find.ById("create"); } }

        public Element editactivitybtn { get { return _manager.ActiveBrowser.Find.ById("edit"); } }

        public Element saveactivityfilterbtn { get { return _manager.ActiveBrowser.Find.ById("save"); } }

        public Element deleteactivitybtn { get { return _manager.ActiveBrowser.Find.ById("delete"); } }

        public Element exportactivitybtn { get { return _manager.ActiveBrowser.Find.ById("excel"); } }

            // Table Heading names
        public Element idheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[2]"); } }

        public Element nameheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[3]"); } }

        public Element variantidheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[4]"); } }

        public Element additionalmemoheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[5]"); } }

        public Element freetxtheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[6]"); } }

        public Element memoheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[7]"); } }

        public Element pictureheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[8]"); } }

        public Element timeheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[9]"); } }

        public Element wesheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[10]"); } }

        public Element groupheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[11]"); } }

        public Element opheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[12]"); } }

        public Element posheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[13]"); } }

        public Element postheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[14]"); } }

        public Element createdheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[15]"); } }

        public Element updatedheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/table/thead/tr[1]/th[16]"); } }
    }
}

using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Products
{
    class ObjVariant
    {
        private Manager _manager;

        public ObjVariant(Manager m)
        {
            _manager = m;
        }
        // Variant Table
        public Element varianttable { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table"); } }

        public Element varianttabletitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h2"); } }

        public Element searchvariant { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[2]/th[3]/input[1]"); } }

       

        // table headings

        public Element variantidheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[2]"); } }

        public Element variantnameheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[3]"); } }

        public Element variantfamilyheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[4]"); } }

        public Element variantaliasheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[5]"); } }

        public Element variantgroupheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[6]"); } }

        public Element variantgroupnameheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[7]"); } }

        public Element variantfreetxtheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[8]"); } }

        public Element variantvalidfromheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[9]"); } }

        public Element variantvalidtoheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[10]"); } }

        public Element variantfromcoheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[11]"); } }

        public Element varianttocoheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[12]"); } }

        public Element variantcreatedheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[13]"); } }

        public Element variantupdatedheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[14]"); } }


        

        // Buttons

        public Element addvariantbtn { get { return _manager.ActiveBrowser.Find.ById("create"); } }

        public Element editvariantbtn { get { return _manager.ActiveBrowser.Find.ById("edit"); } }

        public Element savefilterbtn { get { return _manager.ActiveBrowser.Find.ById("save"); } }

        public Element deletevariantbtn { get { return _manager.ActiveBrowser.Find.ById("delete"); } }

        public Element exportvariantbtn { get { return _manager.ActiveBrowser.Find.ById("excel"); } }

        



    }
}

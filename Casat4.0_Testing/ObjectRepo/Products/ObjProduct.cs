using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Products
{
    class ObjProduct
    {
        private Manager _manager;

        public ObjProduct(Manager m)
        {
            _manager = m;
        }

        // ------ Product table ------

        // Product table
        public Element producttable { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table"); } }

        public Element producttabletitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/div[1]/div/h2"); } }


        // BUttons
        public Element addproductbtn { get { return _manager.ActiveBrowser.Find.ById("createProduct"); } }

        public Element editproductbtn { get { return _manager.ActiveBrowser.Find.ById("editProduct"); } }

        public Element savefilterbtn { get { return _manager.ActiveBrowser.Find.ById("saveProduct"); } }

        public Element deleteproductbtn { get { return _manager.ActiveBrowser.Find.ById("deleteProduct"); } }

        public Element exportproductbtn { get { return _manager.ActiveBrowser.Find.ById("excelProduct"); } }

            // Search fields
        public Element idsearch { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table/thead/tr[2]/th[2]/input[1]"); } }

        public Element namesearch { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table/thead/tr[2]/th[3]/input[1]"); } }

        public Element freetextsearch { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table/thead/tr[2]/th[4]/input[1]"); } }

        public Element variantsearch { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table/thead/tr[2]/th[5]/input[1]"); } }

        // table heading names

        public Element prodidheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table/thead/tr[1]/th[2]"); } }

        public Element prodnameheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table/thead/tr[1]/th[3]"); } }

        public Element prodvariantheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table/thead/tr[1]/th[4]"); } }

        public Element prodfreetxtheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table/thead/tr[1]/th[5]"); } }

        public Element prodcreatedheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table/thead/tr[1]/th[6]"); } }

        public Element produpdatedheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table/thead/tr[1]/th[7]"); } }


        // ----- ADD PRODUCT ------

        public Element addpgtitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h2"); } }
            
            // Label names
        public Element namelabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[1]/label"); } }

        public Element variantlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[2]/div[1]/label"); } }

        public Element freetextlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[3]/div[1]/label"); } }

            // Text Fields
        public Element nametxt { get { return _manager.ActiveBrowser.Find.ById("productName"); } }

        public Element varianttxt { get { return _manager.ActiveBrowser.Find.ById("variantStrings"); } }

        public Element freetexttxt { get { return _manager.ActiveBrowser.Find.ById("freeText"); } }

            // Buttons
        public Element savebtn { get { return _manager.ActiveBrowser.Find.ById("create"); } }

        public Element backbtn { get { return _manager.ActiveBrowser.Find.ById("back"); } }

            // Success message
        public Element savesuccessMsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

            // Variant validation message
        public Element varianterrormsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        // Variant Validation message
        public Element variantvalidationrmsg { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        // Existing message

        public Element existingmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }


        // ---------- BATCH EDIT Products ---------

        public Element batcheditpgtitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/h3"); } }

            // Row check
        public Element row1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table/tbody/tr[1]/td[1]/input"); } }

        public Element row2 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table/tbody/tr[2]/td[1]/input"); } }

            // Label names
        public Element variantstringlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[1]/label"); } }

        public Element freetxtlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[2]/div[1]/label"); } }

            // Text fields
        public Element batchvarianttxt { get { return _manager.ActiveBrowser.Find.ById("variantStrings"); } }

        public Element batchfreetexttxt { get { return _manager.ActiveBrowser.Find.ById("freeText"); } }

            // Buttons
        public Element batchupdatebtn { get { return _manager.ActiveBrowser.Find.ById("update"); } }

        public Element batchbackbtn { get { return _manager.ActiveBrowser.Find.ById("back"); } }

            // batch update success
        
        public Element batchupdatesuccess { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

            // Variant validation message
        public Element variantinvalidmsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }
    }
}

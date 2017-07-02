using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casat4._0_Testing.ObjectRepo.Articles
{
    class ObjArticle
    {
        private Manager _manager;

        public ObjArticle(Manager m)
        {
            _manager = m;
        }

        // ARTICLE PAGE

        public Element articlepagetitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h3"); } }

        public Element searcharticlenum { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[2]/th[3]/input"); } }

        public Element articletable { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table"); } }


        // Table Heading names

        public Element idheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[2]"); } }

        public Element numberheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[3]"); } }

        public Element nameheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[4]"); } }

        public Element typeheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[5]"); } }

        public Element amountheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[6]"); } }

        public Element fromcoheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[7]"); } }

        public Element tocoheading { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[1]/th[8]"); } }

        public Element createdateheading { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element updatedateheading { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

            // Buttons

        public Element addArticlebtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/p[1]/a"); } }

        public Element editArticlebtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/p[2]/button"); } }

        public Element filterArticlebtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/p[3]/button"); } }

        public Element deleteArticlebtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/p[4]/button"); } }

        public Element exportArticlebtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/button"); } }

            // Article name link

        public Element articlenamelink { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/tbody/tr[1]/td[4]/a"); } }
        
        // ---------------------------------------------------------------------------------------------------------------------- //

        // ADD ARTICLE PAGE

        public Element addarticlepgtitle { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[1]/div/h2"); } }

            // Label names
        public Element numberlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[1]/div[1]/label"); } }

        public Element namelabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[2]/div[1]/label"); } }

        public Element amountlabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[3]/div[1]/label"); } }

        public Element typelabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[4]/div[1]/label"); } }

        public Element fromcolabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[5]/div[1]/label"); } }

        public Element tocolabel { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[6]/div[1]/label"); } }

        // Text fields

        public Element numbertxt { get { return _manager.ActiveBrowser.Find.ById("l0"); } }

        public Element nametxt { get { return _manager.ActiveBrowser.Find.ById("l1"); } }

        public Element amounttxt { get { return _manager.ActiveBrowser.Find.ById("l4"); } }

        public Element typetxt { get { return _manager.ActiveBrowser.Find.ById("type"); } }

        public Element fromcotxt { get { return _manager.ActiveBrowser.Find.ById("fromCo"); } }

        public Element tocotxt { get { return _manager.ActiveBrowser.Find.ById("toCo"); } }

        // Buttons
        //public Element savebtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[5]/div/div[2]/div[1]/input"); } }

        public Element savebtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[7]/div/div[2]/div[1]/input"); } }
       // public Element btnsave { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[5]/div/div[2]/div[1]/input"); } }
        public Element addbackbtn { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[5]/div/div[2]/div[2]/button"); } }

        // add existing

        public Element existarticlemsg { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]"); } }

        // ------------------------------------------------------------------------------------------------ //

        
        // ------------------------------------------------------------------------------------------- //
        // BATCH EDIT PAGE



        public Element editpopup { get { return _manager.ActiveBrowser.Find.ByXPath("/html/body/div[3]/div/div/div[1]/h3"); } }

        public Element arttypebatch { get { return _manager.ActiveBrowser.Find.ById("type"); } }

        public Element updatebatch { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element row1cancelbatch { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }

        public Element row1 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/tbody/tr[1]/td[1]/input"); } }

        public Element row2 { get { return _manager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/tbody/tr[2]/td[1]/input"); } }

        public Element successMagbatchedit { get { return _manager.ActiveBrowser.Find.ByXPath(""); } }




        // ----------------------------------------------------------------------------------------------------- //
        


    }
}

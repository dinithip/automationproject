using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using Casat4._0_Testing.ObjectRepo.Articles;
using Casat4._0_Testing.ObjectRepo.Articles.AddArticle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Casat4._0_Testing.Utilities
{
    class CommonFunctionAddArticle
    {
        public static void Addaticle(Manager m,string url, string articleno, string articlenm, string amt, string articlety, bool isexisting)
        {
            //  ObjAddArticle objaddarticle = new ObjAddArticle(m);

            ObjArticle objarticle = new ObjArticle(m);


            HtmlInputText artnum = objarticle.numbertxt.As<HtmlInputText>();
            HtmlInputText artname = objarticle.nametxt.As<HtmlInputText>();
            HtmlInputText amnt = objarticle.amounttxt.As<HtmlInputText>();
            
            

            artnum.Text = articleno;
            artname.Text = articlenm;
            amnt.Text = amt;

         
            m.ActiveBrowser.RefreshDomTree();


            //HtmlSelect arttype = objarticle.typetxt.As<HtmlSelect>();
            //arttype.MouseClick();
            //Thread.Sleep(1000);
            //arttype.SelectByText(_articletype, true);

            Element savebutton = objarticle.savebtn;
            m.ActiveBrowser.Actions.Click(savebutton);

            Thread.Sleep(1000);
            m.ActiveBrowser.RefreshDomTree();

            if (isexisting == true)
            {
                //verify is existing messege
                Element verifyExist = m.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]");
                Assert.IsTrue(verifyExist.InnerText.Contains("Article number must be unique. Please try again"));
            }
            else
            {
                VerifyArticle(m, articleno);
            }

        }

        private static void VerifyArticle(Manager m, string articleno)
        {
            Thread.Sleep(2000);
            m.ActiveBrowser.RefreshDomTree();

            HtmlInputText articlenum;

            articlenum = m.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[2]/th[3]/input").As<HtmlInputText>();

            articlenum.Text = articleno;

            m.Desktop.Mouse.Click(MouseClickType.LeftClick, articlenum.GetRectangle());
            m.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Thread.Sleep(2000);
            m.ActiveBrowser.RefreshDomTree();

            HtmlTable Articletable = m.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table").As<HtmlTable>();

            Assert.AreEqual(Articletable.BodyRows[0].Cells[2].InnerText, articleno);
        }
        /*
        public static string GenarateRandom(string strPrefix)
        {
            string strRandomText = "";

            Random random = new Random();
            int intNumber = random.Next(10000);
            string strNumber = intNumber.ToString();
            strRandomText = strPrefix + strNumber;

            return strRandomText;
        }
        */
    }
}

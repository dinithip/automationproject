using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using Casat4._0_Testing.ObjectRepo.AdduserDI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Casat4._0_Testing.Utilities
{
    class CommonFunctionCreateDIuser
    {
        /*
        public static void AdduserDI(Manager m,string url,string oprid,string firstnm,string lastnm,string em,string phn,string dept, bool isexisting)
        {
            ObjAdduserDI objadddiuser = new ObjAdduserDI(m);

            HtmlInputText operatorid = objadddiuser.operatoridtxt.As<HtmlInputText>();
            HtmlInputText firstname = objadddiuser.txtfirstname.As<HtmlInputText>();
            HtmlInputText lastname = objadddiuser.txtlastname.As<HtmlInputText>();
            HtmlInputEmail email = objadddiuser.txtemail.As<HtmlInputEmail>();
            HtmlInputText phone = objadddiuser.txtphone.As<HtmlInputText>();
            HtmlSelect department = objadddiuser.txtdept.As<HtmlSelect>();

            HtmlSelect dep = objadddiuser.txtdept.As<HtmlSelect>();

            Element savebtn = objadddiuser.savebtn;

            operatorid.Text = oprid;
            firstname.Text = firstnm;
            lastname.Text = lastnm;
            email.Text = em;
            phone.Text = phn;

            m.ActiveBrowser.RefreshDomTree();

            //used accessR.SelectByText(accrl); twice because the save button is getting enabed after a mouse action 

            dep.MouseClick();
            Thread.Sleep(1000);
            dep.SelectByText(dept);
            dep.MouseHover();
            dep.SelectByText(dept);

            Element movetobutton = objadddiuser.movetobtn;           
            m.ActiveBrowser.Actions.Click(movetobutton);

            m.ActiveBrowser.Actions.Click(savebtn);

            Thread.Sleep(1000);
            m.ActiveBrowser.RefreshDomTree();

            if (isexisting == true)
            {
                //verify is existing message
                Element verifyExist = m.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[3]/div/p[2]");
                Assert.IsTrue(verifyExist.InnerText.Contains("Operator ID already exist"));
            }
            else
            {
                VerifyUserDI(m, oprid);
            }

          //  if(savebtn.CssClassAttributeValue == "")
          //{

            //}

      
    }
    */
        /*
        private static void VerifyUserDI(Manager m, string oprid)
        {
            Thread.Sleep(2000);
            m.ActiveBrowser.RefreshDomTree();

            ObjAdduserDI objadddiuser = new ObjAdduserDI(m);

            HtmlInputText oprID;

            oprID = m.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[2]/th[3]/input").As<HtmlInputText>();

            oprID.Text = oprid;


            m.Desktop.Mouse.Click(MouseClickType.LeftClick, oprID.GetRectangle());
            m.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Thread.Sleep(2000);
            m.ActiveBrowser.RefreshDomTree();

            HtmlTable opridTable = objadddiuser.ditable.As<HtmlTable>();

            Assert.AreEqual(opridTable.BodyRows[0].Cells[2].InnerText, oprid);
        }
        */

        public static string GenarateRandom(string strPrefix)
        {
            string strRandomText = "";

            Random random = new Random();
            int intNumber = random.Next(10000);
            string strNumber = intNumber.ToString();
            strRandomText = strPrefix + strNumber;

            return strRandomText;
        }
    }
}

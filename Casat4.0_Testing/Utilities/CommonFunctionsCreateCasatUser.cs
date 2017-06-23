using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using Casat4._0_Testing.ObjectRepo.Adduser;
using Casat4._0_Testing.ObjectRepo.CasatUser.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Casat4._0_Testing.Utilities
{
    class CommonFunctionsCreateCasatUser
    {
        
        public static void AddCasatUser(Manager m,string url,string un,string firstnm,string lastnm,string em,string phn,string accrl,string dept, bool isexisting)
        {
                       
            ObjAdduser objadduser = new ObjAdduser(m);

            HtmlInputText usernametxt = objadduser.usernametxt.As<HtmlInputText>();
            HtmlInputText firstname = objadduser.txtfrstname.As<HtmlInputText>();
            HtmlInputText lastname = objadduser.txtlastname.As<HtmlInputText>();
            HtmlInputEmail emailaddress = objadduser.txtemailaddress.As<HtmlInputEmail>();
            HtmlInputText phone = objadduser.txtphone.As<HtmlInputText>();
            HtmlSelect accessrole = objadduser.txtaccessrole.As<HtmlSelect>();
            HtmlSelect department = objadduser.txtdept.As<HtmlSelect>();

            HtmlSelect accessR = m.ActiveBrowser.Find.ById("l5").As<HtmlSelect>();
            HtmlSelect deptm = m.ActiveBrowser.Find.ById("l6").As<HtmlSelect>();

            Element savebtn = objadduser.btnsave;

            usernametxt.Text = un;
            firstname.Text = firstnm;
            lastname.Text = lastnm;
            emailaddress.Text = em;
            phone.Text = phn;         
           
            m.ActiveBrowser.RefreshDomTree();

            //used accessR.SelectByText(accrl); twice because the save button is getting enabed after a mouse action 
            accessR.MouseClick();
            Thread.Sleep(1000);
            accessR.SelectByText(accrl);
            accessR.MouseHover();
            accessR.SelectByText(accrl);


            deptm.MouseClick();
            Thread.Sleep(1000);
            deptm.SelectByText(dept);
            deptm.MouseHover();
            deptm.SelectByText(dept);


            Element assignbtn;
            assignbtn = m.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[7]/div[2]/button[1]/span");
            m.ActiveBrowser.Actions.Click(assignbtn);
            

            m.ActiveBrowser.Actions.Click(savebtn);

            //ObjCasatUserMsgs save = new ObjCasatUserMsgs(m);

            //Element verifySave = save.saveMsg;
            //Assert.IsTrue(verifySave.InnerText.Contains("CASAT user has been created successfully..!"));

            Thread.Sleep(1000);
            m.ActiveBrowser.RefreshDomTree();

            ObjCasatUserMsgs usermsg = new ObjCasatUserMsgs(m);

            if (isexisting == true)
            {
                //verify is existing messege
                Element verifyExist = usermsg.existingMsg;
                Assert.IsTrue(verifyExist.InnerText.Contains("Username already exist.Please try again"));
            }
            else
            {
                VerifyUser(m, un);
            }

        }

        private static void VerifyUser(Manager m, string un)
        {

            ObjAdduser objadduser = new ObjAdduser(m);

            Thread.Sleep(2000);
            m.ActiveBrowser.RefreshDomTree();

            HtmlInputText usernm = objadduser.searchusername.As<HtmlInputText>();

            //usernm = m.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]/thead/tr[2]/th[3]/input").As<HtmlInputText>();

            usernm.Text = un;

            m.Desktop.Mouse.Click(MouseClickType.LeftClick, usernm.GetRectangle());
            m.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Thread.Sleep(2000);
            m.ActiveBrowser.RefreshDomTree();

            HtmlTable Usertable = m.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]").As<HtmlTable>();

            Assert.AreEqual(Usertable.BodyRows[0].Cells[2].InnerText, un);
        }

        public static string GenarateRandom(string strPrefix)
        {
            string strRandomText = "";

            Random random = new Random();
            int intNumber = random.Next(100);
            string strNumber = intNumber.ToString();
            strRandomText = strPrefix + strNumber;

            return strRandomText;
        }
    }
}

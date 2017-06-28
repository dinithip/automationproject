using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.TestAttributes;
using ArtOfTest.WebAii.TestTemplates;
using ArtOfTest.WebAii.Win32.Dialogs;

using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casat4._0_Testing.Utilities;
using System.Threading;
using Casat4._0_Testing.ObjectRepo.DIuser.EditDIUser;
using Casat4._0_Testing.ObjectRepo.Menus;

namespace Casat4._0_Testing.Testcases.UserManagement.CreateDIuser.EditUserDI
{
    /// <summary>
    /// Summary description for EditUserDI
    /// </summary>
    [TestClass]
    public class EditUserDI : BaseTest
    {

        #region [Setup / TearDown]

        private TestContext testContextInstance = null;
        /// <summary>
        ///Gets or sets the VS test context which provides
        ///information about and functionality for the
        ///current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }


        Settings mySettings;
        Manager myManager;

        string _url;
        string _username;
        string _password;

        string _searchoperatorid;
        string _editoperatorid;
        string _firstname;
        string _lastname;
        string _phone;
        string _email;
        string _department;
        string _status;

        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
        }


        // Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            #region WebAii Initialization

            // Initializes WebAii manager to be used by the test case.
            // If a WebAii configuration section exists, settings will be
            // loaded from it. Otherwise, will create a default settings
            // object with system defaults.
            //
            // Note: We are passing in a delegate to the VisualStudio
            // testContext.WriteLine() method in addition to the Visual Studio
            // TestLogs directory as our log location. This way any logging
            // done from WebAii (i.e. Manager.Log.WriteLine()) is
            // automatically logged to the VisualStudio test log and
            // the WebAii log file is placed in the same location as VS logs.
            //
            // If you do not care about unifying the log, then you can simply
            // initialize the test by calling Initialize() with no parameters;
            // that will cause the log location to be picked up from the config
            // file if it exists or will use the default system settings (C:\WebAiiLog\)
            // You can also use Initialize(LogLocation) to set a specific log
            // location for this test.

            // Pass in 'true' to recycle the browser between test methods
            Initialize(false, this.TestContext.TestLogsDir, new TestContextWriteLine(this.TestContext.WriteLine));

            // If you need to override any other settings coming from the
            // config section you can comment the 'Initialize' line above and instead
            // use the following:

            /*

            // This will get a new Settings object. If a configuration
            // section exists, then settings from that section will be
            // loaded

            Settings settings = GetSettings();

            // Override the settings you want. For example:
            settings.Web.DefaultBrowser = BrowserType.FireFox;

            // Now call Initialize again with your updated settings object
            Initialize(settings, new TestContextWriteLine(this.TestContext.WriteLine));

            */

            // Set the current test method. This is needed for WebAii to discover
            // its custom TestAttributes set on methods and classes.
            // This method should always exist in [TestInitialize()] method.
            SetTestMethod(this, (string)TestContext.Properties["TestName"]);

            #endregion

            mySettings = new Settings();
            mySettings.Web.DefaultBrowser = BrowserType.InternetExplorer;
            myManager = new Manager(mySettings);
            myManager.Start();
            myManager.LaunchNewBrowser();

        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\editUserDI.csv", "editUserDI#csv", DataAccessMethod.Sequential), DeploymentItem("Data\\editUserDI.csv")]
        public void TestMethod_EdituserDI()
        {

            readData();

            CommonFunctions.Login(myManager, _username, _password, _url);

            myManager.ActiveBrowser.Window.Maximize();

            // -- End of Login ---

            ObjMenus menus = new ObjMenus(myManager);

            HtmlListItem system = menus.systemlink.As<HtmlListItem>();
            system.MouseHover();

            myManager.ActiveBrowser.RefreshDomTree();
            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlAnchor users = menus.userslink.As<HtmlAnchor>();
            users.MouseClick();

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            // Search DI user to Edit

            ObjEditDIuser objeditdiuser = new ObjEditDIuser(myManager);

            HtmlTable DItable = objeditdiuser.ditable.As<HtmlTable>();

            HtmlInputText operid = objeditdiuser.searchoperatorid.As<HtmlInputText>();          
            operid.Text = _searchoperatorid;

            myManager.Desktop.Mouse.Click(MouseClickType.LeftClick, operid.GetRectangle());
            myManager.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            // Select one DI user                    

            HtmlInputCheckBox firstrowcheck = objeditdiuser.row1.As<HtmlInputCheckBox>();
            firstrowcheck.Check(true);

            Element editbutton = objeditdiuser.editdibtn;
            myManager.ActiveBrowser.Actions.Click(editbutton);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            updateDiEdit();

            VerifyUser();

            /*
            if (DItable.BodyRows.Count > 0)
            {
                firstrowcheck = myManager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/tbody/tr/td[1]/input").As<HtmlInputCheckBox>();
                firstrowcheck.Check(true);

                // click on Edit user button
                HtmlButton editbutton2;
                editbutton2 = myManager.ActiveBrowser.Find.ByXPath("//*[@id='editDi']").As<HtmlButton>();
                editbutton2.Click();

                updateuser();
            }
            else
            {
                throw new Exception("no matching data to edit");
            }
            */

        }

        public void updateDiEdit()
        {
            ObjEditDIuser objeditdiuser = new ObjEditDIuser(myManager);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlInputText firstnm = objeditdiuser.firstnametxt.As<HtmlInputText>();
            HtmlInputText lastnm = objeditdiuser.lastnametxt.As<HtmlInputText>();
            HtmlInputText phn = objeditdiuser.phonetxt.As<HtmlInputText>();
            HtmlInputEmail em = objeditdiuser.emailtxt.As<HtmlInputEmail>();
            Element updatebutton = objeditdiuser.updatebtn;

            firstnm.Text = _firstname;
            lastnm.Text = _lastname;
            em.Text = _email;
            phn.Text = _phone;
            
            Thread.Sleep(1000);

            HtmlSelect selectStatus = objeditdiuser.statustxt.As<HtmlSelect>();

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            selectStatus.MouseClick();
            Thread.Sleep(1000);
            selectStatus.SelectByText(_status, true);

            Thread.Sleep(5000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element yesbutton = objeditdiuser.yesbtn;
            myManager.ActiveBrowser.Actions.Click(yesbutton);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlSelect dpt = objeditdiuser.departmenttxt.As<HtmlSelect>();

            dpt.MouseClick();
            Thread.Sleep(1000);
            dpt.SelectByText(_department);
            dpt.MouseHover();
            dpt.SelectByText(_department);

            Element moveto = objeditdiuser.movetobtn;
            myManager.ActiveBrowser.Actions.Click(moveto);

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            myManager.ActiveBrowser.Actions.Click(updatebutton);
          
        }

        public void VerifyUser()
        {
            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            ObjEditDIuser objeditdiuser = new ObjEditDIuser(myManager);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element verifysuccessmsg = objeditdiuser.editsuccessmsg;
            Assert.IsTrue(verifysuccessmsg.InnerText.Contains("Changes to the user has been saved."));

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlInputText opertid = objeditdiuser.searchoperatorid.As<HtmlInputText>();

            opertid.Text = _searchoperatorid;

            myManager.Desktop.Mouse.Click(MouseClickType.LeftClick, opertid.GetRectangle());
            myManager.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlTable DItable = objeditdiuser.ditable.As<HtmlTable>();

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Assert.AreEqual(DItable.BodyRows[0].Cells[3].InnerText, _firstname);
            Assert.AreEqual(DItable.BodyRows[0].Cells[4].InnerText, _lastname);
            Assert.AreEqual(DItable.BodyRows[0].Cells[5].InnerText, _phone);
            Assert.AreEqual(DItable.BodyRows[0].Cells[6].InnerText, _email);
            Assert.AreEqual(DItable.BodyRows[0].Cells[7].InnerText, _status);
        }

        

        public void updateuser()
        {

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlInputText oprtid;
            HtmlInputText firstn;
            HtmlInputText lastn;
            Element updatebtn;

            oprtid = myManager.ActiveBrowser.Find.ById("l0").As<HtmlInputText>();
            firstn = myManager.ActiveBrowser.Find.ById("l1").As<HtmlInputText>();
            lastn = myManager.ActiveBrowser.Find.ById("l2").As<HtmlInputText>();

            updatebtn = myManager.ActiveBrowser.Find.ByXPath("//*[@id='update']");
            
            oprtid.Text = _editoperatorid;
            firstn.Text = _firstname;
            lastn.Text = _lastname;
            myManager.ActiveBrowser.Actions.Click(updatebtn);
           
        }

        public void readData()
        {
            _url = TestContext.DataRow["url"].ToString();
            _username = TestContext.DataRow["username"].ToString();
            _password = TestContext.DataRow["password"].ToString();
            _searchoperatorid = TestContext.DataRow["searchoperatorid"].ToString();
            _editoperatorid = TestContext.DataRow["editoperatorid"].ToString();
            _firstname = TestContext.DataRow["firstname"].ToString();
            _lastname = TestContext.DataRow["lastname"].ToString();
            _phone = TestContext.DataRow["phone"].ToString();
            _email = TestContext.DataRow["email"].ToString();
            _department = TestContext.DataRow["department"].ToString();
            _status = TestContext.DataRow["status"].ToString();
        }

        // Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {

            //Screen_shot
            if (TestContext.CurrentTestOutcome == UnitTestOutcome.Failed)
            {
                System.Drawing.Image img = myManager.ActiveBrowser.Capture();
                string filename = string.Format("{0}_{1}.jpg", DateTime.Now.ToString("yyyyMMdd_HHmmsss"), TestContext.TestName);
                img.Save(@"E:\Images\Errors\" + filename, System.Drawing.Imaging.ImageFormat.Jpeg);

            }
            Thread.Sleep(2000);
            myManager.Dispose();

            #region WebAii CleanUp

            //    // Shuts down WebAii manager and closes all browsers currently running
            //    // after each test. This call is ignored if recycleBrowser is set
            this.CleanUp();

            #endregion
        }

        //Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            //    This will shut down all browsers if

            //    recycleBrowser is turned on.Else
            //    will do nothing.
            ShutDown();
    }

    #endregion

}
}

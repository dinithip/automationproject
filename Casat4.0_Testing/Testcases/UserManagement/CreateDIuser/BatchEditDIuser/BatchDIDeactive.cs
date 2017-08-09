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
using Casat4._0_Testing.ObjectRepo.Menus;
using System.Threading;
using Casat4._0_Testing.ObjectRepo.DIuser.BatchEditDI;

namespace Casat4._0_Testing.Testcases.UserManagement.CreateDIuser.BatchEditDIuser
{
    /// <summary>
    /// Summary description for BatchDIDeactive
    /// </summary>
    [TestClass]
    public class BatchDIDeactive : BaseTest
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

        string _deactivestatus;
        string _searchoperatorid3;

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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\DIBatchEdit.csv", "DIBatchEdit#csv", DataAccessMethod.Sequential), DeploymentItem("Data\\DIBatchEdit.csv")]
        public void TestMethod_BatchDIDeactive()
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

            Element bottomcontent = myManager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[1]/th[2]");
            myManager.ActiveBrowser.Actions.ScrollToVisible(bottomcontent);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            // Search DI users to Batch Edit

            ObjBatchEditDI objbatcheditdi = new ObjBatchEditDI(myManager);

            HtmlInputText searchid = objbatcheditdi.searchoperatorid.As<HtmlInputText>();
            searchid.Text = _searchoperatorid3;

            myManager.Desktop.Mouse.Click(MouseClickType.LeftClick, searchid.GetRectangle());
            myManager.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            // Select multiple users

            HtmlTable DItable = objbatcheditdi.ditable.As<HtmlTable>();

            HtmlInputCheckBox firstrowcheck = objbatcheditdi.rowcheck4.As<HtmlInputCheckBox>();
            firstrowcheck.Check(true);

            HtmlInputCheckBox secondrowcheck = objbatcheditdi.rowcheck5.As<HtmlInputCheckBox>();
            secondrowcheck.Check(true);

            Thread.Sleep(3000);

            // click on Edit button
            HtmlButton editbutton4 = objbatcheditdi.editbtn.As<HtmlButton>();
            editbutton4.Click();

            updateBatchedit();

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            verifybatchDeactive();

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();
        }

        // Scenario : Batch Edit - INACTIVE
        public void updateBatchedit()
        {
            ObjBatchEditDI objbatcheditdi = new ObjBatchEditDI(myManager);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlSelect selectstatus = objbatcheditdi.statustxt.As<HtmlSelect>();

            selectstatus.MouseClick();
            Thread.Sleep(1000);
            selectstatus.SelectByText(_deactivestatus, true);

            Thread.Sleep(3000);

            Element verifypopuptitle = objbatcheditdi.confirmationtitle;
            Assert.IsTrue(verifypopuptitle.InnerText.Contains("Change Status"));

            Thread.Sleep(2000);

            Element verifyconfirmation = objbatcheditdi.confirmationMsg;
            Assert.IsTrue(verifyconfirmation.InnerText.Contains("Are you sure you want to deactivate the selected user/s"));

            Thread.Sleep(2000);

            // YES
            Element yesbtn = objbatcheditdi.yesbtnbatch;
            myManager.ActiveBrowser.Actions.Click(yesbtn);

            /*
            // NO
            Element nobtn = objbatcheditdi.nobtnbatch;
            myManager.ActiveBrowser.Actions.Click(nobtn);

            Element noMsg = objbatcheditdi.nochangesMsg;
            Assert.IsTrue(noMsg.InnerText.Contains("You haven't done any changes"));
            */

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element verifycurrentpg = objbatcheditdi.pgtitletxt;
            Assert.IsTrue(verifycurrentpg.InnerText.Contains("Batch Update DI Users"));

            Thread.Sleep(2000);

            // Click on UPDATE button
            Element updatebtn = objbatcheditdi.updatebtn;
            myManager.ActiveBrowser.Actions.Click(updatebtn);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element verifysuccess = objbatcheditdi.batchDeactivesuccessmsg;
            Assert.IsTrue(verifysuccess.InnerText.Contains("The user accounts has been deactivated successfully"));

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element bottomcontent = myManager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[2]/thead/tr[1]/th[2]");
            myManager.ActiveBrowser.Actions.ScrollToVisible(bottomcontent);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();
        }


        public void verifybatchDeactive()
        {
            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            

            ObjBatchEditDI objbatcheditdi = new ObjBatchEditDI(myManager);

            

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element verifyPage = objbatcheditdi.usermanagementtitletxt;
            Assert.IsTrue(verifyPage.InnerText.Contains("DI Users"));

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlInputText searchopid = objbatcheditdi.searchoperatorid.As<HtmlInputText>();

            searchopid.Text = _searchoperatorid3;

            myManager.Desktop.Mouse.Click(MouseClickType.LeftClick, searchopid.GetRectangle());
            myManager.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlTable ditable = objbatcheditdi.ditable.As<HtmlTable>();

            Assert.AreEqual(ditable.BodyRows[0].Cells[7].InnerText, _deactivestatus);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Assert.AreEqual(ditable.BodyRows[1].Cells[7].InnerText, _deactivestatus);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();
        }

        public void readData()
        {
            _url = TestContext.DataRow["url"].ToString();
            _username = TestContext.DataRow["username"].ToString();
            _password = TestContext.DataRow["password"].ToString();
            _searchoperatorid3 = TestContext.DataRow["searchoperatorid2"].ToString();
            _deactivestatus = TestContext.DataRow["deactivestatus"].ToString();
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

            // Shuts down WebAii manager and closes all browsers currently running
            // after each test. This call is ignored if recycleBrowser is set
            this.CleanUp();

            #endregion
        }

        //Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            // This will shut down all browsers if
            // recycleBrowser is turned on. Else
            // will do nothing.
            ShutDown();
        }

        #endregion

    }
}

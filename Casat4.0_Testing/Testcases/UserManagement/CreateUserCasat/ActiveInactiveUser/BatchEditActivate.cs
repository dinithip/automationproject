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
using Casat4._0_Testing.ObjectRepo.ActiveDeactiveuser;
using Casat4._0_Testing.ObjectRepo.CasatUser.Edit;

namespace Casat4._0_Testing.Testcases.UserManagement.CreateUserCasat.ActiveInactiveUser
{
    /// <summary>
    /// Summary description for BatchEditActivate
    /// </summary>
    [TestClass]
    public class BatchEditActivate : BaseTest
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

        string _Url;
        string _username;
        string _password;

        string _editusername;
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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\activeuser.csv", "activeuser#csv", DataAccessMethod.Sequential), DeploymentItem("Data\\activeuser.csv")]
        public void TestMethod_BatchActiveCasatUser()
        {
            readData();

            CommonFunctions.Login(myManager, _username, _password, _Url);

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

            // Search users to Active           

            ObjActiveDeactive objactive = new ObjActiveDeactive(myManager);

            ObjEditUser objedit = new ObjEditUser(myManager);

            HtmlInputText usern = objedit.searchUsername.As<HtmlInputText>();
            usern.Text = _editusername;

            myManager.Desktop.Mouse.Click(MouseClickType.LeftClick, usern.GetRectangle());
            myManager.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            // Select users to activate

            HtmlTable usertable = objedit.usertable.As<HtmlTable>();

            HtmlInputCheckBox firstrowcheck = objactive.row1.As<HtmlInputCheckBox>();
            firstrowcheck.Check(true);

            HtmlInputCheckBox secondrowcheck = objactive.row2.As<HtmlInputCheckBox>();
            secondrowcheck.Check(true);

            // click on Edit user button
            HtmlButton editbtn = objedit.editbutton.As<HtmlButton>();
            editbtn.Click();

            batchactivateUser();

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            verifyActivation();

            Thread.Sleep(3000);
            myManager.ActiveBrowser.RefreshDomTree();
        }

        public void batchactivateUser()
        {
            ObjActiveDeactive objactive = new ObjActiveDeactive(myManager);
            ObjEditUser objedit = new ObjEditUser(myManager);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlSelect selectStatus = objedit.status.As<HtmlSelect>();

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            selectStatus.MouseClick();
            Thread.Sleep(1000);
            selectStatus.SelectByText(_status, true);

            Thread.Sleep(5000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element yesbtn = objactive.yebtn;
            myManager.ActiveBrowser.Actions.Click(yesbtn);

            /*
            Element nobtn = objactive.nobtn;
            myManager.ActiveBrowser.Actions.Click(nobtn);
            */

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element updatebtn = objactive.updatebtn;
            myManager.ActiveBrowser.Actions.Click(updatebtn);

            Thread.Sleep(3000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element successmsg = objactive.activesuccessmsg;
            Assert.IsTrue(successmsg.InnerText.Contains("The user accounts has been activated successfully"));

            Thread.Sleep(3000);
            myManager.ActiveBrowser.RefreshDomTree();
        }

        public void verifyActivation()
        {
            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            ObjActiveDeactive objactive = new ObjActiveDeactive(myManager);
            ObjEditUser objedit = new ObjEditUser(myManager);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlInputText usernm = objedit.searchUsername.As<HtmlInputText>();

            usernm.Text = _editusername;

            myManager.Desktop.Mouse.Click(MouseClickType.LeftClick, usernm.GetRectangle());
            myManager.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlTable casattable = objedit.usertable.As<HtmlTable>();

            Assert.AreEqual(casattable.BodyRows[0].Cells[7].InnerText, _status);

            Thread.Sleep(3000);
            myManager.ActiveBrowser.RefreshDomTree();
        }

        public void readData()
        {
            _Url = TestContext.DataRow["url"].ToString();
            _username = TestContext.DataRow["username"].ToString();
            _password = TestContext.DataRow["password"].ToString();
            _editusername = TestContext.DataRow["editusername"].ToString();
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

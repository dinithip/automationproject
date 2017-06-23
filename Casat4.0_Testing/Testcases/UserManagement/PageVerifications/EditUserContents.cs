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
using Casat4._0_Testing.ObjectRepo.Menus;
using Casat4._0_Testing.Utilities;
using System.Threading;
using Casat4._0_Testing.ObjectRepo.CasatUser.Edit;

namespace Casat4._0_Testing.Testcases.UserManagement.CreateUserCasat.EditCasatUser
{
    /// <summary>
    /// Summary description for EditUserContents
    /// </summary>
    [TestClass]
    public class EditUserContents : BaseTest
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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\dataSheet.csv", "dataSheet#csv", DataAccessMethod.Sequential), DeploymentItem("Data\\dataSheet.csv")]
        public void TestMethod_EditUserContents()
        {
            readData();

            CommonFunctions.Login(myManager, _username, _password, _url);

            myManager.ActiveBrowser.Window.Maximize();

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

            ObjEditUser objedit = new ObjEditUser(myManager);

            HtmlTable usertable = myManager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/table[1]").As<HtmlTable>();

            HtmlInputCheckBox firstrowcheck = objedit.rowcheck.As<HtmlInputCheckBox>();
            firstrowcheck.Check(true);

            // click on Edit user button
            HtmlButton editbtn = objedit.editbutton.As<HtmlButton>();
            editbtn.Click();

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element title = objedit.titletxt;
            Assert.IsTrue(title.InnerText.Contains("Update CASAT User"));

            Element verifylabel1 = objedit.label1;
            Assert.IsTrue(verifylabel1.InnerText.Contains("Username*"));

            Element verifylabel2 = objedit.label2;
            Assert.IsTrue(verifylabel2.InnerText.Contains("First Name*"));

            Element verifylabel3 = objedit.label3;
            Assert.IsTrue(verifylabel3.InnerText.Contains("Last Name*"));

            Element verifylabel4 = objedit.label4;
            Assert.IsTrue(verifylabel4.InnerText.Contains("Email Address*"));

            Element verifylabel5 = objedit.label5;
            Assert.IsTrue(verifylabel5.InnerText.Contains("Phone*"));

            Element verifylabel6 = objedit.label6;
            Assert.IsTrue(verifylabel6.InnerText.Contains("Status"));

            Element verifylabel7 = objedit.label7;
            Assert.IsTrue(verifylabel7.InnerText.Contains("Access Roles*"));

            Element verifylabel8 = objedit.label8;
            Assert.IsTrue(verifylabel8.InnerText.Contains("Departments"));

            Element verifylabel9 = objedit.label9;
            Assert.IsTrue(verifylabel9.InnerText.Contains("All Access Roles"));

            Element verifylabel10 = objedit.label10;
            Assert.IsTrue(verifylabel10.InnerText.Contains("User's Access Roles"));

            Element verifylabel11 = objedit.label11;
            Assert.IsTrue(verifylabel11.InnerText.Contains("All Departments"));

            Element verifylabel12 = objedit.label12;
            Assert.IsTrue(verifylabel12.InnerText.Contains("User's Departments"));

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();
        }

        public void readData()
        {
            _url = TestContext.DataRow["url"].ToString();
            _username = TestContext.DataRow["username"].ToString();
            _password = TestContext.DataRow["password"].ToString();
            
        }

        // Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {

            //
            // Place any additional cleanup here
            //

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

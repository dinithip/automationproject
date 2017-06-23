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
using Casat4._0_Testing.ObjectRepo.Process;
using Casat4._0_Testing.Utilities;
using Casat4._0_Testing.ObjectRepo.Menus;
using System.Threading;

namespace Casat4._0_Testing.Testcases.StandardActivity
{
    /// <summary>
    /// Summary description for AddStandardActivity
    /// </summary>
    [TestClass]
    public class addStandardActivity : BaseTest
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

        string _standactivityname;
        string _freetext;
        string _memo;
        string _additionalmemo;
        string _group;
        string _pos;
        string _post;
        string _op;
        string _variant;

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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\addstandardactivity.csv", "addstandardactivity#csv", DataAccessMethod.Sequential), DeploymentItem("Data\\addstandardactivity.csv")]
        public void TestMethod_addStandardactivity()
        {
            readData();

            CommonFunctions.Login(myManager, _username, _password, _Url);

            myManager.ActiveBrowser.Window.Maximize();

            // -- End of Login ---
            ObjMenus menus = new ObjMenus(myManager);

            HtmlAnchor process = menus.processlink.As<HtmlAnchor>();
            process.MouseHover();

            myManager.ActiveBrowser.RefreshDomTree();

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlAnchor standardactivity = menus.standardactivitylink.As<HtmlAnchor>();
            standardactivity.MouseClick();

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            ObjAddStandardActivity objaddstandardactivity = new ObjAddStandardActivity(myManager);

            Element addbutton = objaddstandardactivity.addactivitybtn;
            myManager.ActiveBrowser.Actions.Click(addbutton);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element verifypage = objaddstandardactivity.addpagetitle;
            Assert.IsTrue(verifypage.InnerText.Contains("Create New Standard Activity"));

            addactivity();
            verifycreate();
        }

        public void addactivity()
        {
            ObjAddStandardActivity objaddstandardactivity = new ObjAddStandardActivity(myManager);

            HtmlInputText name = objaddstandardactivity.standactivitynametxt.As<HtmlInputText>();
            HtmlInputText freetext = objaddstandardactivity.freetexttxt.As<HtmlInputText>();
            HtmlInputText memo = objaddstandardactivity.memotxt.As<HtmlInputText>();
            HtmlInputText additionalmemo = objaddstandardactivity.additionalmemotxt.As<HtmlInputText>();
            HtmlSelect group = objaddstandardactivity.grouptxt.As<HtmlSelect>();
            HtmlSelect pos = objaddstandardactivity.postxt.As<HtmlSelect>();
            HtmlSelect post = objaddstandardactivity.posttxt.As<HtmlSelect>();
            HtmlSelect op = objaddstandardactivity.optxt.As<HtmlSelect>();
            HtmlInputText variant = objaddstandardactivity.varianttxt.As<HtmlInputText>();

            name.Text = _standactivityname;
            freetext.Text = _freetext;
            memo.Text = _memo;
            additionalmemo.Text = _additionalmemo;

            Thread.Sleep(2000);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            group.MouseClick();
            Thread.Sleep(1000);
            group.SelectByText(_group, true);

            //Thread.Sleep(1000);
            //myManager.ActiveBrowser.RefreshDomTree();

            pos.MouseClick();
            Thread.Sleep(1000);
            pos.SelectByText(_pos, true);

            //Thread.Sleep(1000);
            //myManager.ActiveBrowser.RefreshDomTree();

            post.MouseClick();
            Thread.Sleep(1000);
            post.SelectByText(_post, true);

            //Thread.Sleep(1000);
            //myManager.ActiveBrowser.RefreshDomTree();
            
            op.MouseClick();
            Thread.Sleep(1000);
            op.SelectByText(_op, true);

            //Thread.Sleep(1000);
            //myManager.ActiveBrowser.RefreshDomTree();

            variant.Text = _variant;

            Thread.Sleep(3000);

            Element savebutton = objaddstandardactivity.savebtn;
            myManager.ActiveBrowser.Actions.Click(savebutton);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element verifysave = objaddstandardactivity.savesuccessmsg;
            Assert.IsTrue(verifysave.InnerText.Contains("Standard Activity created successfully"));

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

        }


         public void verifycreate()
        {
            ObjAddStandardActivity objaddstandardactivity = new ObjAddStandardActivity(myManager);

            HtmlTable standacttbl = objaddstandardactivity.standardactivitytable.As<HtmlTable>();

            HtmlInputText searchname = objaddstandardactivity.searchnamefield.As<HtmlInputText>();
            searchname.Text = _standactivityname;

            myManager.Desktop.Mouse.Click(MouseClickType.LeftClick, searchname.GetRectangle());
            myManager.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            

            Assert.AreEqual(standacttbl.BodyRows[0].Cells[2].InnerText, _standactivityname);


        }

        public void readData()
        {
            _Url = TestContext.DataRow["url"].ToString();
            _username = TestContext.DataRow["username"].ToString();
            _password = TestContext.DataRow["password"].ToString();

            _standactivityname = TestContext.DataRow["standactivityname"].ToString();
            _freetext = TestContext.DataRow["freetext"].ToString();
            _memo = TestContext.DataRow["memo"].ToString();
            _additionalmemo = TestContext.DataRow["additionalmemo"].ToString();
            _group = TestContext.DataRow["group"].ToString();
            _pos = TestContext.DataRow["pos"].ToString();
            _post = TestContext.DataRow["post"].ToString();
            _op = TestContext.DataRow["op"].ToString();
            _variant = TestContext.DataRow["variant"].ToString();
            
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

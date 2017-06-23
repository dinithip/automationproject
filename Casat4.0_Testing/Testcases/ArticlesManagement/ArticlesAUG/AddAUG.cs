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

namespace Casat4._0_Testing.Testcases.ArticlesManagement.ArticleUsageGroup
{
    /// <summary>
    /// Summary description for AddAUG
    /// </summary>
    [TestClass]
    public class AddAUG : BaseTest
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

        string _articlenumber;
        string _amount;
        string _unit;
        string _freetext;
        string _code;
        string _group;
        string _pos;
        string _post;
        string _op;
        string _articlegroup;
        string _producttype;
        string _module;
        string _fromco;
        string _toco;
        string _impldate;
        string _expdate;
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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\createAUG.csv", "createAUG#csv", DataAccessMethod.Sequential), DeploymentItem("Data\\createAUG.csv")]
        public void TestMethod_CreateAUG()
        {
            readData();

            CommonFunctions.Login(myManager, _username, _password, _Url);

            myManager.ActiveBrowser.Window.Maximize();

            // -- End of Login ---

            HtmlAnchor data = myManager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[2]/ul/li[3]/a").As<HtmlAnchor>();
            data.MouseHover();

            myManager.ActiveBrowser.RefreshDomTree();

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlAnchor articles = myManager.ActiveBrowser.Find.ByXPath("//*[@id='header']/div/nav/div[2]/ul/li[3]/ul/li[2]/a").As<HtmlAnchor>();
            articles.MouseClick();

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            // Serch Article
            HtmlInputText articleno;

            articleno = myManager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[2]/th[3]/input").As<HtmlInputText>();
            articleno.Text = _articlenumber;

            myManager.Desktop.Mouse.Click(MouseClickType.LeftClick, articleno.GetRectangle());
            myManager.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            // click article name
            HtmlAnchor artname;
            artname = myManager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/tbody/tr/td[4]/a").As<HtmlAnchor>();
            artname.MouseClick();

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

        }

        public void readData()
        {
            _Url = TestContext.DataRow["url"].ToString();
            _username = TestContext.DataRow["username"].ToString();
            _password = TestContext.DataRow["password"].ToString();
            _articlenumber = TestContext.DataRow["articlenumber"].ToString();
            _amount = TestContext.DataRow["amount"].ToString();
            _unit = TestContext.DataRow["unit"].ToString();
            _freetext = TestContext.DataRow["freetext"].ToString();
            _code = TestContext.DataRow["code"].ToString();
            _group = TestContext.DataRow["group"].ToString();
            _pos = TestContext.DataRow["pos"].ToString();
            _post = TestContext.DataRow["post"].ToString();
            _op = TestContext.DataRow["op"].ToString();
            _articlegroup = TestContext.DataRow["articlegroupid"].ToString();
            _producttype = TestContext.DataRow["producttype"].ToString();
            _module = TestContext.DataRow["modulefamily"].ToString();
            _fromco = TestContext.DataRow["fromco"].ToString();
            _toco = TestContext.DataRow["toco"].ToString();
            _impldate = TestContext.DataRow["impldate"].ToString();
            _expdate = TestContext.DataRow["expirationdate"].ToString();            
            _variant = TestContext.DataRow["variantstring"].ToString();

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

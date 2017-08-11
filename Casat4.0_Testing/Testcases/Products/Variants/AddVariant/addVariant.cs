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
using Casat4._0_Testing.ObjectRepo.Products;

namespace Casat4._0_Testing.Testcases.Products.Variants.AddVariant
{
    /// <summary>
    /// Summary description for addVariant
    /// </summary>
    [TestClass]
    public class addVariant : BaseTest
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

        string _variantname;
        string _family;
        string _alias;
        string _group;
        string _groupname;
        string _freetext;

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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\variantdata.csv", "variantdata#csv", DataAccessMethod.Sequential), DeploymentItem("Data\\variantdata.csv")]
        public void TestMethod_AddVariant()
        {
            readData();

            CommonFunctions.Login(myManager, _username, _password, _Url);

            myManager.ActiveBrowser.Window.Maximize();

            // -- End of Login ---
            ObjMenus menus = new ObjMenus(myManager);

            HtmlAnchor data = menus.Datalink.As<HtmlAnchor>();
            data.MouseHover();

            myManager.ActiveBrowser.RefreshDomTree();

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlAnchor products = menus.productlink.As<HtmlAnchor>();
            products.MouseClick();

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            ObjAddVariant objaddvariant = new ObjAddVariant(myManager);

            Element addbutton = objaddvariant.addvariantbtn;
            myManager.ActiveBrowser.Actions.Click(addbutton);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element verifypage = objaddvariant.createpagetitle;
            Assert.IsTrue(verifypage.InnerText.Contains("Create New Variant"));

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            add();

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            verifycreate();

            Thread.Sleep(3000);
            myManager.ActiveBrowser.RefreshDomTree();
        }

        public void add()
        {
            ObjAddVariant objaddvariant = new ObjAddVariant(myManager);

            HtmlInputText variantname = objaddvariant.variantnametxt.As<HtmlInputText>();
            HtmlInputText family = objaddvariant.familytxt.As<HtmlInputText>();
            HtmlInputText alias = objaddvariant.aliastxt.As<HtmlInputText>();
            HtmlInputNumber group = objaddvariant.grouptxt.As<HtmlInputNumber>();
            HtmlInputText groupname = objaddvariant.groupnametxt.As<HtmlInputText>();
            HtmlInputText freetext = objaddvariant.freetexttxt.As<HtmlInputText>();

            variantname.Text = _variantname;
            family.Text = _family;
            alias.Text = _alias;
            group.Text = _group;
            groupname.Text = _groupname;
            freetext.Text = _freetext;

            Element savebutton = objaddvariant.savebtn;
            myManager.ActiveBrowser.Actions.Click(savebutton);

            Thread.Sleep(3000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element verifysuccess = objaddvariant.savesuccessmsg;
            Assert.IsTrue(verifysuccess.InnerText.Contains("Variant has been created successfully"));

            Thread.Sleep(3000);
            myManager.ActiveBrowser.RefreshDomTree();
        }

        public void verifycreate()
        {
            ObjAddVariant objaddvariant = new ObjAddVariant(myManager);
            ObjVariant objvariant = new ObjVariant(myManager);

            HtmlTable varianttbl = objvariant.varianttable.As<HtmlTable>();

            HtmlInputText searchname = objvariant.searchvariant.As<HtmlInputText>();
            searchname.Text = _variantname;

            myManager.Desktop.Mouse.Click(MouseClickType.LeftClick, searchname.GetRectangle());
            myManager.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Assert.AreEqual(varianttbl.BodyRows[0].Cells[1].InnerText, _variantname);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();
        }


        public void readData()
        {
            _Url = TestContext.DataRow["url"].ToString();
            _username = TestContext.DataRow["username"].ToString();
            _password = TestContext.DataRow["password"].ToString();
            
            _variantname = CommonGenerateRandom.GenarateRandom(_variantname);
            _family = TestContext.DataRow["family"].ToString();
            _alias = TestContext.DataRow["alias"].ToString();
            _group = TestContext.DataRow["group"].ToString();
            _groupname = TestContext.DataRow["groupname"].ToString();
            _freetext = TestContext.DataRow["freetext"].ToString();
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

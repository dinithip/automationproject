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
using System.Threading;
using Casat4._0_Testing.Utilities;
using Casat4._0_Testing.ObjectRepo.Menus;
using Casat4._0_Testing.ObjectRepo.Articles;

namespace Casat4._0_Testing.Testcases.ArticlesManagement.ViewArticle
{
    /// <summary>
    /// Summary description for ViewArticlePage
    /// </summary>
    [TestClass]
    public class ViewArticlePage : BaseTest
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
        public void TestMethod_ViewArticlePage()
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

            HtmlAnchor articles = menus.Articlelink.As<HtmlAnchor>();
            articles.MouseClick();

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            ObjArticle objarticle = new ObjArticle(myManager);

            Element verifypagetitle = objarticle.articlepagetitle;
            Assert.AreEqual(verifypagetitle.InnerText, "Article");

            Thread.Sleep(1000);

            // --- Verify Contents of View Article Page ---
            // - Verify Button Names -
            Element VerifyaddArticlebtn = objarticle.addArticlebtn;
            Assert.AreEqual(VerifyaddArticlebtn.InnerText, "Add Article");

            Element VerifyEditArticlebtn = objarticle.editArticlebtn;
            Assert.IsTrue(VerifyEditArticlebtn.InnerText.Contains("Edit Article/s"));

            Element VerifySaveFilterbtn = objarticle.filterArticlebtn;
            Assert.IsTrue(VerifySaveFilterbtn.InnerText.Contains("Save Filters"));

            Element VerifyDeletebtn = objarticle.deleteArticlebtn;
            Assert.IsTrue(VerifyDeletebtn.InnerText.Contains("Delete Articles"));

            Element VerifyExportbtn = objarticle.exportArticlebtn;
            Assert.IsTrue(VerifyExportbtn.InnerText.Contains("Export"));

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            // Verify table heading names

            Element idheadingname = objarticle.idheading;
            Assert.IsTrue(idheadingname.InnerText.Contains(""));

            Element numheadingname = objarticle.numberheading;
            Assert.IsTrue(numheadingname.InnerText.Contains(""));

            Element nameheadingname = objarticle.nameheading;
            Assert.IsTrue(nameheadingname.InnerText.Contains(""));

            Element typeheadingname = objarticle.typeheading;
            Assert.IsTrue(typeheadingname.InnerText.Contains(""));

            Element amountheadingname = objarticle.amountheading;
            Assert.IsTrue(amountheadingname.InnerText.Contains(""));

            Element fromcoheadingname = objarticle.fromcoheading;
            Assert.IsTrue(fromcoheadingname.InnerText.Contains(""));

            Element tocoheadingname = objarticle.tocoheading;
            Assert.IsTrue(tocoheadingname.InnerText.Contains(""));

            Element createdateheadingname = objarticle.typeheading;
            Assert.IsTrue(typeheadingname.InnerText.Contains(""));

            Element updatedateheadingname = objarticle.updatedateheading;
            Assert.IsTrue(updatedateheadingname.InnerText.Contains(""));

            Thread.Sleep(1000);

        }

        public void readData()
        {
            _Url = TestContext.DataRow["url"].ToString();
            _username = TestContext.DataRow["username"].ToString();
            _password = TestContext.DataRow["password"].ToString();
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

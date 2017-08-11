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

namespace Casat4._0_Testing.Testcases.Products.Prouct
{
    /// <summary>
    /// Summary description for AddProduct
    /// </summary>
    [TestClass]
    public class AddProduct : BaseTest
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

        string _productname;
        string _variant;
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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\addProduct.csv", "addProduct#csv", DataAccessMethod.Sequential), DeploymentItem("Data\\addProduct.csv")]
        public void TestMethod_AddProduct()
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

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element bottomcontent = myManager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table/thead/tr[1]/th[1]/button/span");
            myManager.ActiveBrowser.Actions.ScrollToVisible(bottomcontent);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            ObjProduct objproduct = new ObjProduct(myManager);

            Element addproductbutton = objproduct.addproductbtn;
            myManager.ActiveBrowser.Actions.Click(addproductbutton);

            addproduct();

            //Thread.Sleep(2000);
            //myManager.ActiveBrowser.RefreshDomTree();

            //verifyproduct();

            Thread.Sleep(3000);
            myManager.ActiveBrowser.RefreshDomTree();
        }

        public void addproduct()
        {
            ObjProduct objproduct = new ObjProduct(myManager);

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element pgtitle = objproduct.addpgtitle;
            Assert.IsTrue(pgtitle.InnerText.Contains("Create New Product"));

            Thread.Sleep(1000);

            HtmlInputText name = objproduct.nametxt.As<HtmlInputText>();
            HtmlInputText variant = objproduct.varianttxt.As<HtmlInputText>();
            HtmlInputText freetxt = objproduct.freetexttxt.As<HtmlInputText>();

            name.Text = _productname;
            variant.Text = _variant;
            freetxt.Text = _freetext;

            Element savebutton = objproduct.savebtn;
            myManager.ActiveBrowser.Actions.Click(savebutton);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element verifysave = objproduct.savesuccessMsg;
            Assert.IsTrue(verifysave.InnerText.Contains("Product has been created successfully"));

            //Element verifysave = objproduct.savesuccessMsg;
            //Assert.IsTrue(verifysave.InnerText.Contains("zzz"), "Product has been created successfullyaaaaaaaaaaaaaaaaaaaa aaaa");

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element bottomcontent = myManager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[4]/table/thead/tr[1]/th[1]/button/span");
            myManager.ActiveBrowser.Actions.ScrollToVisible(bottomcontent);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

        }

        public void verifyproduct()
        {
            ObjProduct objproduct = new ObjProduct(myManager);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlInputText searchnm = objproduct.namesearch.As<HtmlInputText>();
            searchnm.Text = _productname;

            myManager.Desktop.Mouse.Click(MouseClickType.LeftClick, searchnm.GetRectangle());
            myManager.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element pagetitle = objproduct.producttabletitle;
            Assert.IsTrue(pagetitle.InnerText.Contains("Products"));

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlTable prodtbl = objproduct.producttable.As<HtmlTable>();

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            //Assert.AreEqual(prodtbl.BodyRows[0].Cells[2].InnerText, _productname);

            //Thread.Sleep(2000);
            //myManager.ActiveBrowser.RefreshDomTree();

            //Assert.AreEqual(prodtbl.BodyRows[0].Cells[2].InnerText, _freetext);
            //Assert.AreEqual(prodtbl.BodyRows[0].Cells[3].InnerText, _variant);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();
        }

        public void readData()
        {
            _Url = TestContext.DataRow["url"].ToString();
            _username = TestContext.DataRow["username"].ToString();
            _password = TestContext.DataRow["password"].ToString();
            _productname = CommonGenerateRandom.GenarateRandom(_productname);
            _variant = TestContext.DataRow["variant"].ToString();
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

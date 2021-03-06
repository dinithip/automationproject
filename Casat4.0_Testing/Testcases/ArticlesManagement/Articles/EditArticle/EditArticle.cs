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
using Casat4._0_Testing.ObjectRepo.Menus;
using Casat4._0_Testing.ObjectRepo.Articles;
using Casat4._0_Testing.ObjectRepo.Articles.AddArticle;

namespace Casat4._0_Testing.Testcases.ArticlesManagement.EditArticle
{
    /// <summary>
    /// Summary description for EditArticle
    /// </summary>
    [TestClass]
    public class EditArticle : BaseTest
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
        string _articlename;
        string _amount;
        string _articletype;
        string _editarticle;
        //string _fromco;
        //string _toco;


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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\EditArticle.csv", "EditArticle#csv", DataAccessMethod.Sequential), DeploymentItem("Data\\EditArticle.csv")]
        public void TestMethod_EditArticle()
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

            ObjEditArticle objeditarticle = new ObjEditArticle(myManager);

            // Search Article to Edit

            HtmlInputText articleno = objarticle.searcharticlenum.As<HtmlInputText>();
            
            articleno.Text = _editarticle;

            myManager.Desktop.Mouse.Click(MouseClickType.LeftClick, articleno.GetRectangle());
            myManager.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            // Select one Article to Edit
            HtmlInputCheckBox firstrowcheck;
            
            HtmlTable articletbl = objarticle.articletable.As<HtmlTable>();

            if (articletbl.BodyRows.Count > 0)
            {
                firstrowcheck = objeditarticle.editrowcheck1.As<HtmlInputCheckBox>();
                firstrowcheck.Check(true);

                // click on Edit Article button
                Element editbutton = objeditarticle.editbtn;   
                myManager.ActiveBrowser.Actions.Click(editbutton);

            }
            else
            {
                throw new Exception("no matching data to edit");
            }

            updateArticle();

            verifyArticle();
        }

       

        public void updateArticle()
        {
            ObjEditArticle objeditarticle = new ObjEditArticle(myManager);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlInputText artnum = objeditarticle.editnumbertxt.As<HtmlInputText>();
            HtmlInputText artname =objeditarticle.editnametxt.As<HtmlInputText>();
            //HtmlInputText amt;
            HtmlSelect arttype = objeditarticle.edittypetxt.As<HtmlSelect>();
           // HtmlSelect fromco = objeditarticle.editfromcotxt.As<HtmlSelect>();
            HtmlSelect toco = objeditarticle.edittocotxt.As<HtmlSelect>();
            Element updatebtn = objeditarticle.updatebtn;
                       
            //amt = myManager.ActiveBrowser.Find.ById("l4").As<HtmlInputText>();          
            artnum.Text = _articlenumber;
            artname.Text = _articlename;
            //amt.Text = _amount;

            arttype.MouseClick();
            Thread.Sleep(1000);
            arttype.SelectByText(_articletype, true);

            /*
            fromco.MouseClick();
            Thread.Sleep(1000);
            fromco.SelectByText(_fromco, true);
            */

            /*
            toco.MouseClick();
            Thread.Sleep(1000);
            toco.SelectByText(_toco, true);
            */

            myManager.ActiveBrowser.Actions.Click(updatebtn);
            //Element verifymandatorymsg = myManager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[2]/div/div/div/form/div[2]/div[2]/span");
            //Assert.AreEqual(verifymandatorymsg.InnerText, "tttt");


        }

        private void verifyArticle()
        {
            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlInputText articlesearch;
            articlesearch = myManager.ActiveBrowser.Find.ByXPath("//*[@id='body']/div/div/div[3]/table/thead/tr[2]/th[3]/input").As<HtmlInputText>();

            articlesearch.Text = _articlenumber;

            myManager.Desktop.Mouse.Click(MouseClickType.LeftClick, articlesearch.GetRectangle());
            myManager.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();



        }

        public void readData()
        {
            _Url = TestContext.DataRow["url"].ToString();
            _username = TestContext.DataRow["username"].ToString();
            _password = TestContext.DataRow["password"].ToString();
            _articlenumber = TestContext.DataRow["articlenumber"].ToString();
            _articlename = TestContext.DataRow["articlename"].ToString();
            _amount = TestContext.DataRow["amount"].ToString();
            _articletype = TestContext.DataRow["articletype"].ToString();
            _editarticle = TestContext.DataRow["editarticle"].ToString();
            //_fromco = TestContext.DataRow["fromco"].ToString();
            //_toco = TestContext.DataRow["toco"].ToString();
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

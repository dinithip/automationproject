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
using Casat4._0_Testing.ObjectRepo.Process;
using Casat4._0_Testing.ObjectRepo.StandardActivity;

namespace Casat4._0_Testing.Testcases.StandardActivity
{
    /// <summary>
    /// Summary description for standardActivitytable
    /// </summary>
    [TestClass]
    public class standardActivitytable : BaseTest
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
        public void TestMethod_verifystandardActivityTable()
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

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            ObjStandardActivity objstandardactivity = new ObjStandardActivity(myManager);

            Element tabletitle = objstandardactivity.standardactivitytblheading;
            Assert.IsTrue(tabletitle.InnerText.Contains("Standard Activity"));

            // Verify Buttons
            Element add = objstandardactivity.addactivitybtn;
            Assert.IsTrue(add.InnerText.Contains("Add Activity"));

            Element edit = objstandardactivity.editactivitybtn;
            Assert.IsTrue(edit.InnerText.Contains("Edit Activity/s"));

            Element save = objstandardactivity.savefilterbtn;
            Assert.IsTrue(save.InnerText.Contains("Save Filters"));

            Element delete = objstandardactivity.deleteactivitybtn;
            Assert.IsTrue(delete.InnerText.Contains("Delete Activity/s"));

            Element convert = objstandardactivity.converttostationbtn;
            Assert.IsTrue(convert.InnerText.Contains("Convert To Station"));

            Element export = objstandardactivity.exportbtn;
            Assert.IsTrue(export.InnerText.Contains("Export"));

            // Verify Table heading names
            Element id = objstandardactivity.idlabel;
            Assert.IsTrue(id.InnerText.Contains("ID"));

            Element name = objstandardactivity.namelabel;
            Assert.IsTrue(name.InnerText.Contains("Name"));

            Element variant = objstandardactivity.variantlabel;
            Assert.IsTrue(variant.InnerText.Contains("Variant String"));

            Element additionalmemo = objstandardactivity.additionalmemolabel;
            Assert.IsTrue(additionalmemo.InnerText.Contains("Additional Memo"));

            Element group = objstandardactivity.grouplabel;
            Assert.IsTrue(group.InnerText.Contains("Group"));

            Element freetext = objstandardactivity.freetxtlabel;
            Assert.IsTrue(freetext.InnerText.Contains("Free Text"));

            Element memo = objstandardactivity.memolabel;
            Assert.IsTrue(memo.InnerText.Contains("Memo"));

            Element picture = objstandardactivity.picturelabel;
            Assert.IsTrue(picture.InnerText.Contains("Picture"));

            Element time = objstandardactivity.timelabel;
            Assert.IsTrue(time.InnerText.Contains("Time"));

            Element wes = objstandardactivity.weslabel;
            Assert.IsTrue(wes.InnerText.Contains("WES"));
            
            Element op = objstandardactivity.oplabel;
            Assert.IsTrue(op.InnerText.Contains("Op"));

            Element pos = objstandardactivity.poslabel;
            Assert.IsTrue(pos.InnerText.Contains("Pos"));

            Element post = objstandardactivity.postlabel;
            Assert.IsTrue(post.InnerText.Contains("Post"));

            Element created = objstandardactivity.createdlabel;
            Assert.IsTrue(created.InnerText.Contains("Created"));

            Element updated = objstandardactivity.updatedlabel;
            Assert.IsTrue(updated.InnerText.Contains("Updated"));

            Thread.Sleep(3000);
            myManager.ActiveBrowser.RefreshDomTree();
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

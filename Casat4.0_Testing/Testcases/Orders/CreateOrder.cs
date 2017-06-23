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
using Casat4._0_Testing.ObjectRepo.Orders;

namespace Casat4._0_Testing.Testcases.Orders
{
    /// <summary>
    /// Summary description for CreateOrder
    /// </summary>
    [TestClass]
    public class CreateOrder : BaseTest
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

        string _ordernumber;
        string _startdate;
        string _ordervariant;
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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\createOrder.csv", "createOrder#csv", DataAccessMethod.Sequential), DeploymentItem("Data\\createOrder.csv")]
        public void TestMethod_createOrder()
        {
            readData();

            CommonFunctions.Login(myManager, _username, _password, _Url);

            myManager.ActiveBrowser.Window.Maximize();

            // -- End of Login ---
            ObjMenus menus = new ObjMenus(myManager);

            HtmlListItem di = menus.DI.As<HtmlListItem>();
            di.MouseHover();

            myManager.ActiveBrowser.RefreshDomTree();

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlAnchor order = menus.orderlink.As<HtmlAnchor>();
            order.MouseClick();

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            ObjOrderTable objordertable = new ObjOrderTable(myManager);
            ObjCreateOrder objcreateorder = new ObjCreateOrder(myManager);

            Element pagetitle = objordertable.ordertabletitle;
            Assert.IsTrue(pagetitle.InnerText.Contains("Orders"));

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element orderstabname = objordertable.ordertab;
            Assert.IsTrue(orderstabname.InnerText.Contains("Orders"));

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element createbutton = objordertable.createorderbtn;
            myManager.ActiveBrowser.Actions.Click(createbutton);

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element pgtitle = objcreateorder.createorderpgtitle;
            Assert.IsTrue(pgtitle.InnerText.Contains("Create New Order"));

            Thread.Sleep(1000);

            create();
            verifycreate();

        }

        public void create()
        {
            ObjOrderTable objordertable = new ObjOrderTable(myManager);
            ObjCreateOrder objcreateorder = new ObjCreateOrder(myManager);

            HtmlInputText number = objcreateorder.ordernumtxt.As<HtmlInputText>();
            //HtmlInputText date = objcreateorder.datetxt.As<HtmlInputText>();
            HtmlInputText variant = objcreateorder.ordervarianttxt.As<HtmlInputText>();

            number.Text = _ordernumber;
            //date.Text = _startdate;
            variant.Text = _ordervariant;

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element save = objcreateorder.savebtn;
            myManager.ActiveBrowser.Actions.Click(save);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element savemsg = objcreateorder.savesuccessmsg;
            Assert.IsTrue(savemsg.InnerText.Contains("Order has been created successfully"));

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element verifypage = objordertable.ordertab;
            Assert.IsTrue(verifypage.InnerText.Contains("Orders"));

        }

        public void verifycreate()
        {
            ObjOrderTable objordertable = new ObjOrderTable(myManager);

            HtmlInputText searchnumber = objordertable.searchordernum.As<HtmlInputText>();
            searchnumber.Text = _ordernumber;

            myManager.Desktop.Mouse.Click(MouseClickType.LeftClick, searchnumber.GetRectangle());
            myManager.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlTable ordertbl = objordertable.ordertable.As<HtmlTable>();

            //Assert.AreEqual(ordertbl.BodyRows[0].Cells[2].InnerText, _ordernumber);
            //Assert.AreEqual(ordertbl.BodyRows[0].Cells[4].InnerText, _status);
        }


        public void readData()
        {
            _Url = TestContext.DataRow["url"].ToString();
            _username = TestContext.DataRow["username"].ToString();
            _password = TestContext.DataRow["password"].ToString();
            _ordernumber = TestContext.DataRow["ordernumber"].ToString();
            _startdate = TestContext.DataRow["startdate"].ToString();
            _ordervariant = TestContext.DataRow["ordervariant"].ToString();
            _status = TestContext.DataRow["status"].ToString();

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

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
using Casat4._0_Testing.ObjectRepo.CasatUser;
using Casat4._0_Testing.ObjectRepo.Adduser;

namespace Casat4._0_Testing.Testcases.UserManagement.CreateUserCasat.DeleteCasatUser
{
    /// <summary>
    /// Summary description for softDeleteUser
    /// </summary>
    [TestClass]
    public class softDeleteUser : BaseTest
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

        string _softdelete;

        
        string _firstname;
        string _lastname;
        string _email;
        string _phone;
        string _accessrole;
        

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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data\\deleteuser.csv", "deleteuser#csv", DataAccessMethod.Sequential), DeploymentItem("Data\\deleteuser.csv")]
        public void TestMethod_softdeleteCasatUser()
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

            // Search Casat user to Delete

            ObjDeleteUser objdelete = new ObjDeleteUser(myManager);

            HtmlInputText usern = objdelete.searchusername.As<HtmlInputText>();
            usern.MouseClick();

            usern.Text = _softdelete;

            myManager.Desktop.Mouse.Click(MouseClickType.LeftClick, usern.GetRectangle());
            myManager.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            // Select one user to Delete

            HtmlTable Usertable = objdelete.usertbl.As<HtmlTable>();
            
            HtmlInputCheckBox rowcheck = objdelete.rowcheck1.As<HtmlInputCheckBox>();
            rowcheck.Check(true);

                // click on Delete user button
            HtmlButton deletebutton = objdelete.deletebtn.As<HtmlButton>();
            deletebutton.Click();

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            // Verify Confirmation popup
            Element verifyconfirmation = objdelete.confirmationtxt;
            Assert.IsTrue(verifyconfirmation.InnerText.Contains("Are you sure you want to delete the selected user/s?"));

            Thread.Sleep(4000);
            myManager.ActiveBrowser.RefreshDomTree();

            // Click Yes
            Element yesbtn = objdelete.yesbtn;
            myManager.ActiveBrowser.Actions.Click(yesbtn);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            verifysoftdelete();
        }

        public void verifysoftdelete()
        {
            ObjAdduser objadduser = new ObjAdduser(myManager);

            Element addbtn = objadduser.createbtn;
            myManager.ActiveBrowser.Actions.Click(addbtn);

            Thread.Sleep(1000);
            myManager.ActiveBrowser.RefreshDomTree();

            HtmlInputText usernametxt = objadduser.usernametxt.As<HtmlInputText>();
            HtmlInputText firstname = objadduser.txtfrstname.As<HtmlInputText>();
            HtmlInputText lastname = objadduser.txtlastname.As<HtmlInputText>();
            HtmlInputEmail emailaddress = objadduser.txtemailaddress.As<HtmlInputEmail>();
            HtmlInputText phone = objadduser.txtphone.As<HtmlInputText>();
            HtmlSelect accessR = objadduser.txtaccessrole.As<HtmlSelect>();           

            Element savebtn = objadduser.btnsave;

            usernametxt.Text = _softdelete;
            firstname.Text = _firstname;
            lastname.Text = _lastname;
            emailaddress.Text = _email;
            phone.Text = _phone;

            myManager.ActiveBrowser.RefreshDomTree();

            //used accessR.SelectByText(accrl); twice because the save button is getting enabed after a mouse action 
            accessR.MouseClick();
            Thread.Sleep(1000);
            accessR.SelectByText(_accessrole);
            accessR.MouseHover();
            accessR.SelectByText(_accessrole, true);

            myManager.ActiveBrowser.Actions.Click(savebtn);

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

            Element verifyexisting = objadduser.existingMsg;
            Assert.IsTrue(verifyexisting.InnerText.Contains("Username already exist.Please try again"));

            Thread.Sleep(2000);
            myManager.ActiveBrowser.RefreshDomTree();

        }



        public void readData()
        {
            _Url = TestContext.DataRow["url"].ToString();
            _username = TestContext.DataRow["username"].ToString();
            _password = TestContext.DataRow["password"].ToString();
            _softdelete = TestContext.DataRow["softdelete"].ToString();
            _firstname = TestContext.DataRow["firstname"].ToString();
            _lastname = TestContext.DataRow["lastname"].ToString();
            _email = TestContext.DataRow["email"].ToString();
            _phone = TestContext.DataRow["phone"].ToString();
            _accessrole = TestContext.DataRow["accessrole"].ToString();
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

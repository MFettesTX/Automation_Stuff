using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using [REDACTED].Base;
using [REDACTED].Helpers;
using [REDACTED].Pages.GenericPages;
using [REDACTED].Pages.LibraryPages;
using static [REDACTED].Base.Browser;

namespace [REDACTED].TestCases.Library
{
    [TestClass]
    public class _TC_8605_2 : Base
    {
        string url = "[REDACTED]/Modules/USRMGMT/Login.aspx";
        //string url = "https://[REDACTED]";

        /// <summary>
        /// Test method to create a new District.
        /// </summary>
        [TestMethod]
        public void TC_8605_2()
        {
            try
            {

                string fileName = Environment.CurrentDirectory.ToString() + "\\ExcelData\\LibraryNew\\Login.xlsx";
                ExcelHelpers.PopulateInCollection(fileName, "sheet1");
                OpenBrowser(BrowserType.Chrome);
                //LogHelpers.Write("Opening the Chrome Browser");

                DriverContext.Browser.GoToUrl(url);
                CurrentPage = GetInstance<LoginPage>();
                CurrentPage = CurrentPage.As<LoginPage>().Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));
                CurrentPage.As<LeftMenuBar>().ClickLibrary();
                CurrentPage = CurrentPage.As<LeftMenuBar>().ClickExpandTree();
                CurrentPage = CurrentPage.As<LibraryLeftPane>().ClickDistrict();
                DriverContext.Driver.SwitchTo().Frame("contentFrame");
                System.Threading.Thread.Sleep(1500);
                CurrentPage.As<DistrictListPage>().ClickFirstCheckBox();
                CurrentPage = CurrentPage.As<DistrictListPage>().ClickDistrictEdit();
                CurrentPage.As<District>().ClickIsMetro();
                CurrentPage = CurrentPage.As<District>().ClickEditSave();

            }

            catch (Exception e)
            {
                LogHelpers.Write("Test Failed" + e.Message);
            }

        }
    }
}





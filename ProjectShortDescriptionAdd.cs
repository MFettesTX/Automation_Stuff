using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using [REDACTED].Base;
using [REDACTED].Helpers;
using static [REDACTED].Helpers.Randomize;
using [REDACTED].Pages.GenericPages;
using [REDACTED].Pages.LibraryPages;
using static [REDACTED].Base.Browser;


namespace [REDACTED].TestCases.Library
{

    [TestClass]

    public class [REDACTED] : Base
    {
        string url = "https://[REDACTED]";
    //string url = "https://[REDACTED]";

    /// <summary>
    /// Test method to create a new Project Short Description
    /// </summary>
    /// 



    [TestMethod]
        public void[REDACTED]_1()
        {

            try
            {

                string fileName = Environment.CurrentDirectory.ToString() + "\\ExcelData\\LibraryNew\\Login.xlsx";
                ExcelHelpers.PopulateInCollection(fileName, "Sheet1");
                OpenBrowser(BrowserType.Chrome);
                //LogHelpers.Write("Opening the Chrome Browser");
                DriverContext.Browser.GoToUrl(url);
                CurrentPage = GetInstance<LoginPage>();
                //CurrentPage = CurrentPage.As<LoginPage>().Login("Administrator", "aurigo");
                CurrentPage = CurrentPage.As<LoginPage>().Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));
                CurrentPage.As<LeftMenuBar>().ClickLibrary();
                CurrentPage = CurrentPage.As<LeftMenuBar>().ClickExpandTree();
                CurrentPage = CurrentPage.As<LibraryLeftPane>().ClickProjectShortDescription();
                DriverContext.Driver.SwitchTo().Frame("contentFrame");
                System.Threading.Thread.Sleep(1500);
                CurrentPage = CurrentPage.As<ProjectShortDescriptionListPage>().ClickProjectShortDescriptionNew();

                //Manually create project short description with random acronym and random string added to end of division name
                // CurrentPage.As<ProjectShortDescription>().ClickIsEnabled(); //Flips the Is Enabled flag to TRUE
                CurrentPage = CurrentPage.As<ProjectShortDescription>().ClickProjectShortDescriptionSave("SD " + Randomize.RandomString(4), "TEST " + RandomString(8));
                //fileName = Environment.CurrentDirectory.ToString() + "\\ExcelData\\LibraryNew\\[     ].xlsx";
                //ExcelHelpers.PopulateInCollection(fileName, "Project Short Description" );
                //CurrentPage = CurrentPage.As<ProjectShortDescription>().ClickProjectShortDescriptionSave(ExcelHelpers.ReadData(1, "Division Code :"), ExcelHelpers.ReadData(1, "Reference ID :"), ExcelHelpers.ReadData(1, "Short Description :"));
            }

            catch (Exception e)
            {
                LogHelpers.Write("Test Failed" + e.Message);
            }

        }
    }
}


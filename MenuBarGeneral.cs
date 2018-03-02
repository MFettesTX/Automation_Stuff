using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using [REDACTED].Base;

namespace [REDACTED].Pages.GenericPages
{
    public class MenuBarGeneral : BasePage
    {

        /// <summary>
        /// Objects for Top Menu Bar - General
        /// </summary>
        [FindsBy(How = How.Id, Using = "lnkNew")]
        private IWebElement btnNew { get; set; }

        [FindsBy(How = How.Id, Using = "lnkEdit")]
        private IWebElement btnEdit { get; set; }

        [FindsBy(How = How.Id, Using = "lnkView")]
        private IWebElement btnView { get; set; }

        [FindsBy(How = How.Id, Using = "lnkDelete")]
        private IWebElement btnDelete { get; set; }

        [FindsBy(How = How.Id, Using = "lnkSave")]
        private IWebElement btnSave { get; set; }

        [FindsBy(How = How.Id, Using = "lnkCancel")]
        private IWebElement btnCancel { get; set; }

        [FindsBy(How = How.Id, Using = "lnkBack")]
        private IWebElement btnBack { get; set; }


        /// <summary>
        /// Method to Click on New button
        /// </summary>
        public void ClickNew()
        {
            btnNew.Click();
        }

        /// <summary>
        /// Method to Click on Edit button
        /// </summary>
        public void ClickEdit()
        {
            btnEdit.Click();
        }

        /// <summary>
        /// Method to Click on View button
        /// </summary>
        public void ClickView()
        {
            btnView.Click();
        }

        /// <summary>
        /// Method to Click on Delete button
        /// </summary>
        
        public void ClickDelete()
        {
            btnDelete.Click();
        }

        /// <summary>
        /// Method to Click on Save button on creating or editing the existing record
        /// </summary>
        public void ClickSave()
        {
            btnSave.Click();
        }

        /// <summary>
        /// Method to Click on Cancel button 'ON' creating or editing the existing record
        /// </summary>
        public void ClickDCancel()
        {
            btnCancel.Click();
        }

        /// <summary>
        /// Method to Click on Back button on creating or editing the existing record
        /// </summary>

        public void ClickBack()
        {
            btnBack.Click();
        }
    }
}

# Automation_Stuff
Just some items I worked on


I changed all of the project-specific stuff to [REDACTED] because they're not really relevant. 
I only added the items to this repository that I specifically had a part in.

In the case of MenuBarGeneral.cs, I added the following to the file: 

        [FindsBy(How = How.Id, Using = "lnkDelete")]
        private IWebElement btnDelete { get; set; }
       
and

        /// <summary>
        /// Method to Click on Delete button
        /// </summary>
        
        public void ClickDelete()
        {
            btnDelete.Click();
        }

Everything else was either done using a previously-created script and tweaking for my specific test or created from scratch. 

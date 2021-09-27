using System;
using Xunit;

namespace Assignment3.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void Query_GetWizardNames_returns_only_names_of_wizards_invented_by_Rowling()
        {
            string[] wizardNames = {"Lord Voldemort" , "Albus Dumbledore"};

            Assert.Equal(wizardNames, Queries.GetWizardNames();

        }
    }
}

using System;
using System.Collections.Generic;
using Xunit;

namespace Assignment3.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void GetWizardNamesByExtension_returns_only_names_of_wizards_invented_by_Rowling()
        {
            string[] wizardNames = {"Lord Voldemort" , "Albus Dumbledore"};
            Assert.Equal(wizardNames, Queries.GetWizardNamesByExtension());
        }
        
        [Fact]
        public void GetWizardNamesByLINQ_returns_only_names_of_wizards_invented_by_Rowling()
        {
            (string,int?)[] wizardNames = {("Lord Voldemort",2001) , ("Albus Dumbledore",2001)};
            Assert.Equal(wizardNames, Queries.GetWizardsFromHarryPotterByExtension());
        }
        
        [Fact]
        public void GetWizardsFromHarryPotterByExtension_ReturnsNameAndYear()
        {
            (string,int?)[] wizardNames = {("Lord Voldemort",2001) , ("Albus Dumbledore",2001)};
            Assert.Equal(wizardNames, Queries.GetWizardsFromHarryPotterByLINQ());
        }
    }
}

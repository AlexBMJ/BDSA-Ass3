using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    public class Queries
    {

        public static IEnumerable<string> GetWizardNamesByExtension() => 
            Wizard.Wizards.Value.Where(w => w.Creator.Contains("Rowling")).Select(c => c.Name);

        public static IEnumerable<string> GetWizardNamesByLINQ() => 
            from wizard in Wizard.Wizards.Value
            where wizard.Creator.Contains("Rowling")
            select wizard.Name;

        public static IEnumerable<(string,int?)> GetWizardsFromHarryPotterByExtension() => 
            Wizard.Wizards.Value.Where(w => w.Medium.Contains("Harry Potter")).Select(c => (c.Name, c.Year));

        public static IEnumerable<(string, int?)> GetWizardsFromHarryPotterByLINQ() => 
            from wizard in Wizard.Wizards.Value
            where wizard.Medium.Contains("Harry Potter")
            select (wizard.Name, wizard.Year);
    }
}

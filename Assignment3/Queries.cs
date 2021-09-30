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
        
        public static int? GetYearOfFirstSithByExtension() => 
            Wizard.Wizards.Value.OrderBy(w => w.Year).FirstOrDefault(w => w.Name.Contains("Darth"))?.Year;

        public static int? GetYearOfFirstSithByLINQ() => 
            (from wizard in Wizard.Wizards.Value
            orderby wizard.Year
            where wizard.Name.Contains("Darth")
            select wizard.Year).FirstOrDefault();

        public static IEnumerable<(string,int?)> GetWizardsFromHarryPotterByExtension() => 
            Wizard.Wizards.Value.Where(w => w.Medium.Contains("Harry Potter")).Select(c => (c.Name, c.Year)).Distinct();

        public static IEnumerable<(string, int?)> GetWizardsFromHarryPotterByLINQ() => 
            (from wizard in Wizard.Wizards.Value
            where wizard.Medium.Contains("Harry Potter")
            select (wizard.Name, wizard.Year)).Distinct();
        
        public static IEnumerable<string> GetWizardNamesGroupedByCreatorReversedByExtension() => 
            Wizard.Wizards.Value.GroupBy(wizard => wizard.Creator).OrderByDescending(wizards => wizards.Key).Select(g => g.OrderByDescending(w => w.Name)).Flatten().Select(wiz => wiz.Name);

        public static IEnumerable<string> GetWizardNamesGroupedByCreatorReversedByLINQ() => 
            from wizard in Wizard.Wizards.Value
            group wizard by wizard.Creator
            into g
            orderby g.Key descending
            from wiz in ( 
                from w in g
                orderby w.Name descending select w)
            select wiz.Name;
    }
}

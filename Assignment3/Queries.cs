using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    public class Queries
    {

        public static IEnumerable<string> GetWizardNamesByExtension()
        {
            IEnumerable<string> WizardNames = Wizard.Wizards.Value.Where(w => w.Creator.Contains("Rowling")).Select(c => c.Name);
             return WizardNames;
        }

        public static IEnumerable<string> GetWizardNamesByLINQ()
        {
            IEnumerable<string> WizardNames = (from wizard in Wizard.Wizards.Value
                                                where wizard.Creator.Contains("Rowling")
                                                select wizard.Name);
             return WizardNames;
        }

        public static IEnumerable<(string,int?)> GetWizardsFromHarryPotterByExtension()
        {
            var harryPotter = Wizard.Wizards.Value.Where(w => w.Medium.Contains("Harry Potter"))
                                            .Select(c => (c.Name, c.Year));
            return harryPotter;
        }

        public static IEnumerable<(string, int?)> GetWizardsFromHarryPotterByLINQ()
        {
            var harryPotter = from wizard in Wizard.Wizards.Value
                                where wizard.Medium.Contains("Harry Potter")
                                select (wizard.Name, wizard.Year) ;
            return harryPotter;
        }
       

    }
}

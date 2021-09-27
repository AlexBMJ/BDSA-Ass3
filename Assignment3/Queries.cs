using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    public class Queries
    {

        public static IEnumerable<string> GetWizardNamesByExtension()
        {
            IEnumerable<string> WizardNames = Wizard.Wizards.Where(w => w.Creator.Contains("Rowling")).Select(c => c.Name);
             return WizardNames;
        }

        public static IEnumerable<string> GetWizardNamesByLINQ()
        {
            IEnumerable<string> WizardNames = (from wizard in Wizard.Wizards
                                                where wizard.Creator.Contains("Rowling")
                                                select wizard.Name);
             return WizardNames;
        }

        public static IEnumerable<string> GetWizardsFromHarryPotterByExtension()
        {
            var harryPotter = Wizard.Wizards.Where(w => w.Medium.Contains("Harry Potter"))
                                            .Select(c => new {Name = c.Name,
                                                              Year = c.Year});
        }

        public static IEnumerable<string> GetWizardsFromHarryPotterByLINQ()
        {
            var harryPotter = from wizard in Wizard.Wizards
                                where wizard.Medium.Contains("Harry Potter")
                                select new {Name = wizard.Name,
                                            Year = wizard.Year};
        }
       

    }
}

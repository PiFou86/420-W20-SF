using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNullable
{
    public class Livre
    {
        public DateTime? DateEmprunt { get; set; }
        public DateTime? DateRetour
        {
            get
            {
                DateTime? dateRetour = null;
                if (this.DateEmprunt.HasValue)
                {
                    dateRetour = this.DateEmprunt.Value.AddDays(10);
                }

                return dateRetour;
            }
        }

        public DateTime? DateRetour2
        {
            get
            {
                return this.DateEmprunt?.AddDays(10);
            }
        }
    }
}

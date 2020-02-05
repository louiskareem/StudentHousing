using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentHousingBv
{
    public class FacilityClass
    {
        private string facility;

        public void SetName( string facility )
        {
            this.facility = facility;
        }

        public String GetName()
        {
            //var item in Enum.GetNames(typeof(WorkingDays))
            return this.facility;
        }

        public override String ToString()
        {
            return this.facility;
        }
    }
}

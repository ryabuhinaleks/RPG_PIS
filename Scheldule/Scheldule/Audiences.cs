using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheldule
{
    class Audiences
    {
        private static FreeAudinces FreeAud = new FreeAudinces();
        private static BusyAudinces BusyAud = new BusyAudinces();

        public Lesson GetAudLess(List<Lesson> Les)
        {
            var UndLes = FreeAud.FindAud(Les);
            BusyAud.AddAud(UndLes);
            FreeAud.DeleteAud(UndLes);
            return UndLes;
        }
    }
}

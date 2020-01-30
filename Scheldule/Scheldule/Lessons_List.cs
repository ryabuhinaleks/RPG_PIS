using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheldule
{
    public  class Lessons_List
    {
        private static FreeLessons Fl = new FreeLessons();
        private static BusyLessons Bl = new BusyLessons();

        public List<Lesson> FreeLesDisc { get; set; }
        public int SchedID { get; set; }

        public List<Lesson> GetLesson(int ds)
        {
            Fl.SchID = SchedID;
            FreeLesDisc = Fl.FindLessons(ds);
            return FreeLesDisc;
        }
        public void AddUndLesson(Lesson UndLesson)
        {
            Bl.SchID = SchedID;
            Bl.AddLesson(UndLesson);
            Fl.DeleteLessons(UndLesson);
        }
    }
}

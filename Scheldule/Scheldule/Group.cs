namespace Scheldule
{
    class Group
    {
        private static Schedules_List sch_list = new Schedules_List();
        private static Schedule sch = new Schedule();
        public int Name { get; set; }

        public int GetScheduleGroup(int semestr)
        {

            sch_list.id_group = Name;

            var Schedule = sch_list.FindSchGroup(semestr);
            if (Schedule == null)
            {
                Schedule = sch.Created(semestr);
                sch_list.Add((int)Schedule);
            }

            return (int)Schedule;
        }
    }
}

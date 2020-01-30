namespace Scheldule
{
    class Direction
    {
        private static Curriculums_List curr_list = new Curriculums_List();
        private static Curriculum curr = new Curriculum();
        private static Groups_List gr_list = new Groups_List();
        private static Group gr = new Group();

        public int Name { get; set; } //передали с журнала имя-id
        public int GetCurriculumDirrection(int semestr)
        {

            curr_list.Name = Name; //передаем направление листу УП

            var Curriculum = curr_list.FindCurDir(semestr);
            if (Curriculum == null)
            {
                Curriculum = curr.Created(semestr);
                curr_list.Add((int)Curriculum);
            }

            return (int)Curriculum;
        }

        public int GetSchedule(string nameGroup, int semestr)
        {
            gr.Name = gr_list.FindGroup(nameGroup);
            int Schedule = gr.GetScheduleGroup(semestr);
            return Schedule;
        }
    }
}

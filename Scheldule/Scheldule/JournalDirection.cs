namespace Scheldule
{
    class JournalDirection
    {
        private static Directions_List direct_List = new Directions_List();
        private static Direction direct = new Direction();
        public int GetCurriculum(string Direction, int semestr)
        {

            direct.Name = direct_List.FindDirection(Direction);   //id направления      
            int Curriculum = direct.GetCurriculumDirrection(semestr);
            return Curriculum;
        }
    }
}

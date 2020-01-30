namespace Scheldule
{
    class University
    {
        private static Departments_List dep_list = new Departments_List();

        public int GetDepartment(string nameD)
        {
            int id_dep = dep_list.FindDep(nameD);
            return id_dep;
        }
    }
}

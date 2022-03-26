using System.Collections.Generic;

namespace CVTR.Core
{
    public class Repository
    {
        private static readonly Dictionary<int, Department> RepositoryData = new Dictionary<int, Department>();

        public static Department RegisterDepartment(int id)
        {
            if (!RepositoryData.ContainsKey(id))
            {
                RepositoryData.Add(id, new Department(id));
            }

            return FindDepartment(id);
        }

        private static Department FindDepartment(int id)
        {
            return RepositoryData[id];
        }
    }
}

using MediatorDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern.Concrete
{
    public enum TodoList
    {
        todo1,
        todo2,
        todo3
    }

    public class ProjectManager: IProjectManager
    {

        Dictionary<IProjectTeam, TodoList> TeamMission;
        List<IProjectTeam> projectTeams;

        private static List<T> GetEnumList<T>()
        {
            T[] array = (T[])Enum.GetValues(typeof(T));
            List<T> list = new List<T>(array);
            return list;
        }

        public ProjectManager()
        {
            TeamMission = new Dictionary<IProjectTeam, TodoList>();
            projectTeams = new List<IProjectTeam>();
        }

        public void AddTeam(IProjectTeam projectTeam)
        {
            projectTeams.Add(projectTeam);
        }

        public void ProjectProccessRequest(IProjectTeam projectTeam)
        {

            if (!projectTeams.Contains(projectTeam))
            {
                Console.WriteLine("Bu takım bu proje yöneticisine bağlı değil!");
                return;

            }

            foreach (var item in GetEnumList<TodoList>())
            {
                if (!TeamMission.ContainsValue(item))
                {
                    TeamMission.Add(projectTeam, item);
                    Console.WriteLine("Göreviniz : " + item);
                    return;
                }
            }
            Console.WriteLine("Görev listesi doludur!");
        }

      
    }
}

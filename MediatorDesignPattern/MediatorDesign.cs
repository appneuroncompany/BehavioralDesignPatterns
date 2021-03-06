using MediatorDesignPattern.Concrete;
using System;

namespace MediatorDesignPattern
{
    /// <summary>
    /// Mediator örüntü birçok bileşenin birbirinden servis kullandığı ve bu servis kullanımlarından dolayı bağımlılıkların çok arttığı durumlarda bu bağımlılıkları merkeze taşıyarak bağımlılık kaosunu çözen bir yaklaşımdır.
    /// </summary>
    public class MediatorDesign
    {
        

        public static void TestMediatorDesign()
        {
            ProjectManager projectManager = new ProjectManager();

            Team teamA = new Team();
            Team teamB = new Team();
            Team teamC = new Team();
            Team teamD = new Team();

            projectManager.AddTeam(teamA);
            projectManager.AddTeam(teamB);
            projectManager.AddTeam(teamC);

            teamA.RequestMission(projectManager);
            teamB.RequestMission(projectManager);
            teamC.RequestMission(projectManager);
            teamD.RequestMission(projectManager);

        }


    }
}

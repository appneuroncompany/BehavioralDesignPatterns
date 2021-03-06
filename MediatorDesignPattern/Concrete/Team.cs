using MediatorDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern.Concrete
{
    public class Team : IProjectTeam
    {
        public int TeamMemberCount { get; set; }
        public string TeamName { get; set; }

        public void RequestMission(IProjectManager projectManager)
        {
            projectManager.ProjectProccessRequest(this);
        }
    }
}

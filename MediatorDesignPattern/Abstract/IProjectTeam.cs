using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern.Abstract
{
    public interface IProjectTeam
    {
        public int TeamMemberCount { get; set; }
        public string TeamName { get; set; }

        void RequestMission(IProjectManager projectManager);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern.Abstract
{
    public interface IProjectManager
    {
        void AddTeam(IProjectTeam projectTeam);
        void ProjectProccessRequest(IProjectTeam projectTeam);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL.Team_related
{
    public class TeamManager
    {
        ITeamDAO teamDAO;

        public TeamManager(ITeamDAO teamDAO)
        {
            this.teamDAO = teamDAO;
        }

        private static List<Team>? Teams = new List<Team>();

        private void PopulateIfEmpty()
        {
            if (Teams.Any())
            {
                return;
            }
            else
            {
                RefreshTeamsFromDatabase();
            }
        }

        private int GetLastInsertedId()
        {
            return teamDAO.GetLastInsertedId();
        }

        public int AllTimeConstructorWins(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateTeam(Team Team)
        {
            teamDAO.CreateTeam(Team);
            Team.ID = GetLastInsertedId();
            Teams.Add(Team);
        }

        public void DeleteTeam(int id)
        {
            teamDAO.DeleteTeam(id);

            PopulateIfEmpty();
            Team teamToRemove = Teams?.FirstOrDefault(team => team.ID == id);
            if (teamToRemove != null)
            {
                Teams.Remove(teamToRemove);
            }
        }

        private void RefreshTeamsFromDatabase()
        {
            Teams?.Clear();

            foreach (Team team in teamDAO.GetAllTeams())
            {
                Teams.Add(team);
            }
        }

        public List<Team>? GetAllTeamsRefresh()
        {
            PopulateIfEmpty();
            return Teams.ToList();
        }

        public int GetCurrentConstructorPoints(int id)
        {
            throw new NotImplementedException();
        }

        public int GetCurrentConstructorWins(int id)
        {
            throw new NotImplementedException();
        }

        public Team GetTeamByID(int id)
        {
            PopulateIfEmpty();
            Team team = Teams?.FirstOrDefault(team => team.ID == id);
            return team;
        }

        public void UpdateTeam(Team Team)
        {
            teamDAO.UpdateTeam(Team);
            PopulateIfEmpty();
            Team existingTeam = Teams?.First(team => team.ID == Team.ID);
            if (existingTeam != null)
            {
                existingTeam.Name = Team.Name;
                existingTeam.CreationDate = Team.CreationDate;
            }
        }
    }
}

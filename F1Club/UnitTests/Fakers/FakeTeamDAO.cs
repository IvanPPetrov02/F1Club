using LL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Fakers
{
    public class FakeTeamDAO : ITeamDAO
    {
        private int lastInsertedId;
        private List<Team> teams = new List<Team>();

        public void CreateTeam(Team team)
        {
            lastInsertedId++;
            team.ID = lastInsertedId;
            teams.Add(team);
        }

        public void DeleteTeam(int id)
        {
            teams.RemoveAll(t => t.ID == id);
        }

        public List<Team> GetAllTeams()
        {
            return teams;
        }

        public int GetLastInsertedId()
        {
            return lastInsertedId;
        }

        public void UpdateTeam(Team team)
        {
            var existingTeam = teams.FirstOrDefault(t => t.ID == team.ID);
            if (existingTeam != null)
            {
                teams.Remove(existingTeam);
                teams.Add(team);
            }
        }
    }

}

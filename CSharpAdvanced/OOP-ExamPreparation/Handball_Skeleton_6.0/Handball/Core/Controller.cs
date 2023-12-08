using Handball.Core.Contracts;
using Handball.Models;
using Handball.Models.Contracts;
using Handball.Repositories;
using Handball.Repositories.Contracts;
using Handball.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Handball.Core
{
    public class Controller : IController
    {
        private IRepository<IPlayer> players;
        private IRepository<ITeam> teams;
        private string[] validPlayerTypes = { "CenterBack", "ForwardWing", "Goalkeeper" };
        public Controller()
        {
            players = new PlayerRepository();
            teams = new TeamRepository();
        }
        public string LeagueStandings()
        {
            List<ITeam> sortedTeams = teams.Models.OrderByDescending(t => t.PointsEarned).OrderByDescending(t => t.OverallRating).ThenBy(t => t.Name).ToList();

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("***League Standings***");

            foreach (var team in sortedTeams)
            {
                stringBuilder.AppendLine(team.ToString());
            }

            return stringBuilder.ToString().Trim();
        }

        public string NewContract(string playerName, string teamName)
        {
            if (!players.ExistsModel(playerName))
            {
                return string.Format(OutputMessages.PlayerNotExisting, playerName, typeof(PlayerRepository).Name);
            }

            if (!teams.ExistsModel(teamName))
            {
                return string.Format(OutputMessages.TeamNotExisting, teamName, typeof(TeamRepository).Name);
            }

            IPlayer player = players.GetModel(playerName);
            ITeam team = teams.GetModel(teamName);

            if (player.Team != null)
            {
                return string.Format(OutputMessages.PlayerAlreadySignedContract, playerName, player.Team);
            }

            player.JoinTeam(teamName);
            team.SignContract(player);

            return string.Format(OutputMessages.SignContract, playerName, teamName);
        }

        public string NewGame(string firstTeamName, string secondTeamName)
        {
            ITeam firstTeam = teams.GetModel(firstTeamName);
            ITeam secondTeam = teams.GetModel(secondTeamName);

            if (firstTeam.OverallRating > secondTeam.OverallRating)
            {
                firstTeam.Win();
                secondTeam.Lose();

                return string.Format(OutputMessages.GameHasWinner, firstTeamName, secondTeamName);
            }
            else if (secondTeam.OverallRating > firstTeam.OverallRating)
            {
                secondTeam.Win();
                firstTeam.Lose();

                return string.Format(OutputMessages.GameHasWinner, secondTeamName, firstTeamName);
            }
            else
            {
                firstTeam.Draw();
                secondTeam.Draw();

                return string.Format(OutputMessages.GameIsDraw, firstTeamName, secondTeamName);
            }

        }

        public string NewPlayer(string typeName, string name)
        {

            if (!validPlayerTypes.Contains(typeName))
            {
                return string.Format(OutputMessages.InvalidTypeOfPosition, typeName);
            }

            if (players.ExistsModel(name))
            {
                IPlayer player = players.GetModel(name);
                return string.Format(OutputMessages.PlayerIsAlreadyAdded, name, players.GetType().Name, player.GetType().Name);
            }

            IPlayer newPlayer = null;

            if (typeName == validPlayerTypes[0])
            {
                newPlayer = new CenterBack(name);
            }
            else if (typeName == validPlayerTypes[1])
            {
                newPlayer = new ForwardWing(name);
            }
            else if (typeName == validPlayerTypes[2])
            {
                newPlayer = new Goalkeeper(name);
            }

            players.AddModel(newPlayer);

            return string.Format(OutputMessages.PlayerAddedSuccessfully, name);
        }

        public string NewTeam(string name)
        {
            Team team = new Team(name);

            if (!teams.ExistsModel(name))
            {
                teams.AddModel(team);
                return String.Format(OutputMessages.TeamSuccessfullyAdded, name, "TeamRepository");
            }

            return String.Format(OutputMessages.TeamAlreadyExists, name, "TeamRepository");
        }

        public string PlayerStatistics(string teamName)
        {
            ITeam team = teams.GetModel(teamName);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"***{teamName}***");

            foreach (var player in team.Players.OrderByDescending(p => p.Rating).ThenBy(p => p.Name))
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}

using DREAM_TEAM_NBA.Models;

namespace NBA.Services
{
    public class PlayerServices
    {
        public List<Team> GetTeam()
        {
            var players1 = new List<Player>
            {
                new Player { Name = "Russel Westbrook", Position = "PG", Img = "russelW.png" },
                new Player { Name = "Carmelo Anthony", Position = "SG", Img = "carmeloA.png" },
                new Player { Name = "Lebron James", Position = "PF", Img = "lebronJ.png" },
                new Player { Name = "Anthony Davis", Position = "SF", Img = "anthonyD.png" },
                new Player { Name = "Dwhite Howard", Position = "C", Img = "dwightH.png" }
            };
            var players2 = new List<Player>
            {
                new Player { Name = "Stephen Curry", Position = "PG", Img = "Steph.png" },
                new Player { Name = "Klay Thompson", Position = "SG", Img = "klay.png" },
                new Player { Name = "Andre Wiggns", Position = "PF", Img = "andrew.png" },
                new Player { Name = "Daymon Green", Position = "SF", Img = "daymon.png" },
                new Player { Name = "James Wiseman", Position = "C", Img = "jamesW.png", }
            };
            var players3 = new List<Player>
            {
                new Player { Name = "Lonzo Ball", Position = "PG", Img = "lonzoB.png" },
                new Player { Name = "Zach Lavine", Position = "SG", Img = "zachL.png" },
                new Player { Name = "DeMar DeRozan", Position = "PF", Img = "demarD.png" },
                new Player { Name = "Alex Caruso", Position = "SF", Img = "alexC.png" },
                new Player { Name = "Nikola Vucevic", Position = "C", Img = "nikolaV.png", }
            };
            var players4 = new List<Player>
            {
                new Player { Name = "kyrie Irving", Position = "PG", Img = "kyrieI.png" },
                new Player { Name = "Caris LeVert", Position = "SG", Img = "carisL.png" },
                new Player { Name = "Joe Haris", Position = "PF", Img = "joeH.png" },
                new Player { Name = "Kevin Durant", Position = "SF", Img = "kevinD.png" },
                new Player { Name = "Deandre Jordan", Position = "C", Img = "deandreJ.png", }
            };
            var team = new List<Team>
            {
                new Team { Name = "Gold State Warrios", Img = "golden-state-warriors.png", Players = players2, TeamId = 0 },
                new Team { Name = "Los Angeles Lakers", Img = "losAngeles.png", Players = players1, TeamId = 1 },
                new Team { Name = "Chicago Bulls", Img = "chicago-bulls.png", Players = players3, TeamId = 2 },
                new Team { Name = "Broklin Nets", Img = "broklin-nets.png", Players = players4, TeamId = 2 }
            };
            return team;
        }

        public Team GetOneTeam()
        {
            
                var teams = GetTeam(); ;//Estou recebendo uma lista com dados dos times, direto da controller, que pegou os dados da services.
                Random InstanciaRandom = new Random();
                var randomNumber = 0;
                var atualTeam = new Team();//Instancio a variavel atualTeam que vai ser preenchida de acordo com o id aleatorio que vier no 'RandomTeam()'

                Team RandomTeam(List<Team> allTeams)//essa função recebe uma lista como parametro, que vai ser usada no for, e de acordo com o id do for, retornamos um novo time com todos os dados
                {
                    randomNumber = InstanciaRandom.Next(0, teams.Count - 1);
                    foreach(var team in allTeams)
                    {
                        if (randomNumber == team.TeamId)
                        {
                            atualTeam = team;
                        }
                    }
                    return atualTeam;
                }
                atualTeam = RandomTeam(teams);//estou atribuindo o valor do atualTeam com algum time aletório da lista
            return atualTeam;
        }
    }
}
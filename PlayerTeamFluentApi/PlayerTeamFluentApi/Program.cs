using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerTeamFluentApi
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SportContext())
            {
                Console.Write("Введите Id игрока: ");
                string id = Console.ReadLine();

               
                int intId;
                bool success = int.TryParse(id, out intId);
                bool anyPlayerId = context.Players.Any(player => player.Id == intId);
                if (anyPlayerId)
                {
                    var players = from p in context.Players
                                  join t in context.Teams on
                                  p.TeamId equals t.Id
                                  where p.Id == intId
                                  select new
                                  {
                                      Name = p.Name,
                                      Number = p.Number,
                                      TeamName = t.Name

                                  };

                    foreach (var player in players)
                    {
                        Console.WriteLine("Имя игрока: " + player.Name);
                        Console.WriteLine("Номер игрока: " + player.Number);
                        Console.WriteLine("Наименование команды: " + player.TeamName);
                    }
                }
                else
                {
                    Console.WriteLine("Нет такого игрока!");
                }

                Console.Write("Введите имя игрока: ");
                string name = Console.ReadLine();
                bool anyPlayer = context.Players.Any(player=> player.Name==name);
                if (anyPlayer) {
                    var players = from p in context.Players
                                  join t in context.Teams on
                                  p.TeamId equals t.Id
                                  where p.Name==name
                                  select new
                                  { 
                                      Name=p.Name,
                                      Number = p.Number,
                                      TeamName=t.Name

                                  };

                    foreach (var player in players) {
                        Console.WriteLine("Номер игрока: "+player.Number);
                        Console.WriteLine("Наименование команды: "+player.TeamName);
                    }
                }
                else {
                    Console.WriteLine("Нет такого игрока!");
                }
                Console.Read();

            }
        }
    }
}

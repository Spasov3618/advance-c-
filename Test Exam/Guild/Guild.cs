using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Guilds = new List<Player>();
        }

        public List<Player> Guilds { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => Guilds.Count;

        public void AddPlayer(Player player)
        {
            if (Count < Capacity)
            {
                Guilds.Add(player);
            }
        }
        public bool  RemovePlayer(string name)
        {
            Player find = Guilds.FirstOrDefault(n => n.Name == name);
            if (find != null)
            {
                Guilds.Remove(find);
                return true;

            }
            return false;
        }
      public void  PromotePlayer(string name)
        {
            Player find = Guilds.FirstOrDefault(n => n.Name == name);
            if (find!= null)
            {
                if (find.Rank != "Member")
                {
                    find.Rank = "Member";
                }
            }
        }
        public void DemotePlayer(string name)
        {
            Player find = Guilds.FirstOrDefault(n => n.Name == name);
            if (find != null)
            {
                if (find.Rank != "Trial")
                {
                    find.Rank = "Trial";
                }
            }
        }
       public Player[] KickPlayersByClass(string @class)
        {
            var kikPlayer = Guilds.FindAll(n => n.Class == @class);
            Guilds.RemoveAll(n => n.Class == @class);
            return kikPlayer.ToArray();
            
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var item in Guilds)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}

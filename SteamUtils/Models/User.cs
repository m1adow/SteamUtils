using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamUtils.Models
{
    internal class User
    {
        public uint AppId { get; private set; }

        private Dictionary<string, uint> _games = new()
        {
            ["Dota 2"] = 570,
            ["CS:GO"] = 730,
            ["Apex Legends"] = 1172470
        };

        public void SetAppId(string name)
        {
            _games.TryGetValue(name, out uint appId);
            AppId = appId;
        }
    }
}

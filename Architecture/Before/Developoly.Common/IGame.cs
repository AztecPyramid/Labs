using System;
using System.Collections.Generic;
using System.Text;
using Developoly.Common;
using System.Collections;
using System.Data;

namespace Developoly.Common
{
	public interface IGame
	{
        void Advance(string playerName, int positions);
        GameMessage GetConsequence();
        void Consequence(GameMessage request);
        Player CurrentPlayer { get; }
        bool AddPlayer(string name);
        IList Players { get; }
        string[] PlayerNames { get; }
        Player GetPlayer(string playerName);
        DataTable Board { get; }
        DataRow Chance { get; }
        DataRow CommunityChest { get; }
	}
}

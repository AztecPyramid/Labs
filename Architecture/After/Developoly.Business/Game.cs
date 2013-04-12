using System.Data;
using System.Collections;
using Developoly.Common;

namespace Developoly.Business
{
	public class Game: IGame
	{
		private Bank _bank; 
		private DataSet _game;
		private Hashtable _players;
		private Rules _rules;

		private Player _currentPlayer;
		private GameMessage _consequence;

		private ChancesEnum _chancePosition = ChancesEnum.count;
		private CommunityChestEnum _communityChestPosition = CommunityChestEnum.count;

		public Game(IGameDataProvider data)
		{
			this._game = data.Data;
			_bank = new Bank(_game.Tables["Properties"]);
			_rules = new Rules();
			_players = new Hashtable();
		}

		public void Advance(string playerName, int positions)
		{
			_currentPlayer = GetPlayer(playerName);
			_consequence = _rules.ProcessRule(positions, _currentPlayer);
		}

		public GameMessage GetConsequence()
		{
			return _consequence;
		}

		public void Consequence(GameMessage request)
		{
			_consequence = _rules.ProcessConsequence(request, _currentPlayer, _bank);
		}

		public Player CurrentPlayer
		{
			get { return _currentPlayer; }
		}

		public bool AddPlayer(string name)
		{
			bool isPlayer=false;
			if( (null != name) && (string.Empty != name) )
			{
				Player newPlayer = new Player(name);
				try 
				{
					_players.Add(newPlayer.ID, newPlayer);
					isPlayer=true;
				}
				catch 
				{
					isPlayer=false;
				}
			}
			return isPlayer;
		}

		public IList Players
		{
			get 
			{ 
				ArrayList playersList = new ArrayList();
				foreach (Player aPlayer in _players.Values)
				{
					playersList.Add(aPlayer.Name);
				}
				playersList.Sort();
				return playersList;
			}
		}

		public string[] PlayerNames
		{
			get
			{
				int c = _players.Count;
				string[] s = new string[c];

				int i=0;
				foreach( DictionaryEntry item in _players)
				{
					s[i++]= ((Player)item.Value).Name;
				}
				return s;
			}
		}
        
		public Player GetPlayer(string playerName)
		{
			foreach( DictionaryEntry item in _players)
			{
				if (((Player)item.Value).Name == playerName)
				{
					return (Player)_players[item.Key];
				}
			}
			return null;
		}

		public DataTable Board
		{
			get { return _bank.Properties; }
		}

		public DataRow Chance
		{
			get
			{
				if (_chancePosition + 1 < ChancesEnum.count - 1)
				{
					_chancePosition = _chancePosition + 1;
				}
				else
				{
					_chancePosition = 0;
				}
				return _game.Tables["chances"].Rows[(int)_chancePosition];
			}
		}

		public DataRow CommunityChest
		{
			get
			{
				if (_communityChestPosition + 1 < CommunityChestEnum.count - 1)
				{
					_communityChestPosition += 1;
				}
				else
				{
					_communityChestPosition = 0;
				}
				return _game.Tables["communitychest"].Rows[(int)_communityChestPosition];
			}
		}
	}//class
}//namespace


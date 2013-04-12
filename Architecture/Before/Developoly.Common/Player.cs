using System.Collections;

namespace Developoly.Common
{
	public class Player
	{
		public string Name;
		public string ID;
		public decimal Money = 15140;
		public ArrayList Properties = new ArrayList();
		public bool InJail = false;
		public int Position = 0;
		public int LastThrow  = 0;
		public int NumberOfDoubles = 0;

		public Player() {}

		public Player(string playerName)
		{
			Name = playerName;
			ID = Name;
		}

		public void Credit(decimal amount)
		{
			Money += amount;
		}

		public bool Debit(decimal amount)
		{
			if (Money - amount < 0)
			{
				return false;
			}
			else
			{
				Money -= amount;
				return true;
			}
		}
	}
}
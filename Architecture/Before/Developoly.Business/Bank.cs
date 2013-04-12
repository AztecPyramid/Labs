using System.Data;
using Developoly.Common;

namespace Developoly.Business
{
	public class Bank
	{
		private DataTable _properties;
		private string owner = "playerId";

		public Bank(DataTable t )
		{
			_properties = t;
			_properties.Columns.Add(new DataColumn(owner, typeof(string)));
		}

		public DataTable Properties
		{
			get { return _properties; }
		}

		public GameEnum Credit(decimal amount, Player currentPlayer )
		{

			currentPlayer.Credit(amount);
			return GameEnum.success;
		}

		public GameEnum Debit(decimal amount, Player currentPlayer)
		{
			if (currentPlayer.Debit(amount) == true)
			{
				return GameEnum.success;
			}
			else
			{
				return GameEnum.insufficientFunds;
			}
		}

		public GameEnum PurchaseProperty(int propertyId, Player currentPlayer)
		{

            // adding a comment to see if it goes to github

			if (System.Convert.IsDBNull( _properties.Rows[propertyId][owner]) == false)
			{
				if ((string)_properties.Rows[propertyId][owner] == currentPlayer.ID)
				{
					return GameEnum.alreadyOwner;
				}
				else
				{
					if (((string)_properties.Rows[propertyId][owner]).Length > 0)
						return GameEnum.payRent;
				}
			}

			// Property for sale
			int purchasePrice = (int)_properties.Rows[propertyId]["price"];

			// Deduct money from player
			GameEnum result = Debit(purchasePrice, currentPlayer);
			if (result == GameEnum.success)
			{

				// Player has just paid for property add to their list and update board
				currentPlayer.Properties.Add(propertyId);
				_properties.Rows[propertyId][owner] = currentPlayer.ID;
				return result;
			}

			// Insufficient funds
			return result;

		}
	}	
}

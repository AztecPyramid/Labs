using System.Data;
using Developoly.Common;

namespace Developoly.Business
{
	public class Rules
	{
		private const int DOUBLE_THROW = 12;
		private const int MAX_NUMBER_OF_DOUBLES = 3;
		public const int MAX_PLACES = 39;

		public GameMessage ProcessRule(int places, Player currentPlayer)
		{   // advance
			GameMessage response = new GameMessage();

			response = CheckForDoubles(places, currentPlayer, response);
			response = MovePosition(places, currentPlayer, response);
			response = NewPositionRules(currentPlayer, response);
			response.playerId = currentPlayer.ID;

			return response;
		}

		public GameMessage ProcessConsequence(GameMessage request, Player currentPlayer, Bank bank)
		{
			GameMessage response = new GameMessage();
			response.opCode = GameEnum.success;

			switch (request.opCode)
			{
				case GameEnum.chance:
					response = ProcessChance((ChancesEnum)request.chanceId, currentPlayer);
					response = ProcessConsequence(response, currentPlayer, bank);
					break;
				case GameEnum.communityChest:
					// To Do
					//ProcessCommunityChestRule
					break;
				case GameEnum.purchaseProperty:
					response.opCode = bank.PurchaseProperty(request.propertyId, currentPlayer);
					break;
				case GameEnum.purchaseHouse:
					break;
				case GameEnum.purchaseHotel:
					break;
				case GameEnum.passGo:
					break;
				case GameEnum.pay:
					response.opCode = bank.Debit(request.amount, currentPlayer);
					break;
				case GameEnum.collect:
					response.opCode = bank.Credit(request.amount, currentPlayer);
					break;
				case GameEnum.mortgageProperty:
					break;
				case GameEnum.goToJail:
					break;
				case GameEnum.sellHotel:
					break;
				case GameEnum.sellHouse:
					break;
				case GameEnum.payRent:
					break;
				default:
					//option to buy property, or pay rent
					break;
			}        
			return response;
		}

		private GameMessage ProcessChance(ChancesEnum chance, Player currentPlayer)
		{
			GameMessage response = new GameMessage();

			switch ( chance )
			{
				case ChancesEnum.AdvancetoGo:
					currentPlayer.Position = 0;
					response.opCode = GameEnum.collect;
					response.amount = 200;
					break;
				case ChancesEnum.AdvancetoTrafalgarSquare:
					currentPlayer.Position = 24;
					break;
				case ChancesEnum.AdvancetonearestUtility:
					// Not nearest
					currentPlayer.Position = 12;
					break;
				case ChancesEnum.AdvancetonearestRailroad:
					// Not nearest
					currentPlayer.Position = 29;
					break;
				case ChancesEnum.AdvancetoWhitehall:
					currentPlayer.Position = 13;
					break;
				case ChancesEnum.Bankpaysyoudividend:
					response.opCode = GameEnum.collect;
					response.amount = 50;
					break;
				case ChancesEnum.GetoutofJailfree:
					break;
				case ChancesEnum.Goback3spaces:
					currentPlayer.Position -= 3;
					break;
				case ChancesEnum.GodirectlytoJail:
					break;
				case ChancesEnum.Makegeneralrepairs:
					break;
				case ChancesEnum.Paypoortax:
					response.opCode = GameEnum.pay;
					response.amount = 15;
					break;
				case ChancesEnum.AdvancetoKingsCrossStation:
					break;
				case ChancesEnum.AdvancetoMayfair:
					break;
				case ChancesEnum.Electedchairman:
					break;
				case ChancesEnum.Buildingandloanmatures:
					break;
				default:
					break;
			}

			response.position = currentPlayer.Position;
			response.playerId = currentPlayer.ID;

			return response;
		}

		public void ProcessCommunityChest(DataSet game, ChancesEnum chance, Player current)
		{
			// To Do
		}

		// GameMessage is a struct - that is why it is also a return value
		private GameMessage CheckForDoubles(int places, Player currentPlayer, GameMessage response)
		{
			// if double throw rethrow
			if (places == DOUBLE_THROW)
			{
				currentPlayer.NumberOfDoubles += 1;
				if (currentPlayer.NumberOfDoubles == MAX_NUMBER_OF_DOUBLES)
				{
					response.opCode = GameEnum.goToJail;
					currentPlayer.LastThrow = 0;
					currentPlayer.NumberOfDoubles = 0;
				}
				else
				{
					if (currentPlayer.LastThrow == DOUBLE_THROW)
					{
						currentPlayer.LastThrow = DOUBLE_THROW;
						response.isRethrow = true;
					}
					else
					{
						currentPlayer.LastThrow = DOUBLE_THROW;
					}
				}
			}
			else
			{
				currentPlayer.LastThrow = 0;
				currentPlayer.NumberOfDoubles = 0;
			}
			return response;
		}

		private GameMessage MovePosition(int places, Player currentPlayer, GameMessage response)
		{
			// Player can be advanced - do they pass go?
			if (currentPlayer.Position + places > MAX_PLACES)
			{
				response.opCode = GameEnum.passGo;
				response.amount = 200;
				response.position = (currentPlayer.Position + places) - MAX_PLACES;
				currentPlayer.Position = response.position;
			}
			else
			{
				response.position = currentPlayer.Position + places;
				currentPlayer.Position += places;
			}
			return response;
		}

		private GameMessage NewPositionRules(Player currentPlayer, GameMessage response)
		{
			// Where have they landed?

			// Debug for specific board positions
			//currentPlayer.Position = 7 '// Chance
			//currentPlayer.Position = 33 '// communityChest

			switch ((GameFeaturesEnum)currentPlayer.Position)
			{
				case GameFeaturesEnum.Chance_1:
				case GameFeaturesEnum.Chance_2:
				case GameFeaturesEnum.Chance_3:
					response.opCode = GameEnum.chance;
					break;
				case GameFeaturesEnum.CommunityChest_1:
				case GameFeaturesEnum.CommunityChest_2:
					response.opCode = GameEnum.communityChest;
					break;
				case GameFeaturesEnum.GoToJail:
					response.opCode = GameEnum.goToJail;
					break;
				case GameFeaturesEnum.IncomeTax:
					response.opCode = GameEnum.pay;
					response.amount = 200;
					break;
				case GameFeaturesEnum.SuperTax:
					response.opCode = GameEnum.pay;
					response.amount = 100;
					break;
				case GameFeaturesEnum.FreeParking:
					response.opCode = GameEnum.freeParking;
					break;
				case GameFeaturesEnum.InJailVisiting:
					response.opCode = GameEnum.visitingJail;
					break;
				default:

					//option to buy property, or pay rent. Set property identifier
					response.opCode = GameEnum.purchaseProperty;
					response.propertyId = currentPlayer.Position;
					break;
			}
			return response;
		}

	}//class
}//namespace

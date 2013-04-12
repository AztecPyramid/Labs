namespace Developoly.Common
{
	public struct GameMessage
	{
		public GameEnum opCode;
		public string playerId;
		public int position;
		public bool isRethrow;
		public decimal amount;
		public int propertyId;
		public int chanceId;
		public int communityChestId;
	}

	public enum GameEnum
	{
		pay = 1,
		collect,
		passGo,
		goToJail,
		freeParking,
		reThrow,
		chance,
		communityChest,
		purchaseProperty,
		bidProperty,
		purchaseHouse,
		purchaseHotel,
		sellHouse,
		sellHotel,
		mortgageProperty,
		sellGetOutOfJail,
		insufficientFunds,
		alreadyOwner,
		payRent,
		visitingJail,
		success,
		fail
	}

}//namespace
using System.Data;

namespace Developoly.Business
{
	public interface IGameDataProvider
	{
		bool HaveData{get;}
		DataSet Data{get;}
	}
}

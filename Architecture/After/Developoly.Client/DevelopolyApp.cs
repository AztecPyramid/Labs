using System.Windows.Forms;
using Developoly.Common;
using Developoly.Business;


namespace Developoly.Client
{
	public class DevelopolyApp
	{
		public static void Main()
		{
			IGameDataProvider data = new GameDataResource();
			if(data.HaveData)
			{
				IGame gameObj = new Game(data);
				Application.Run(new MainForm(gameObj));
			}
			else
			{
				MessageBox.Show("Data is not available. Correct and run the app again");
			}
		}
	}
}

using System;
using System.Data;
using System.IO;
using System.Reflection;

namespace Developoly.Business
{
	/// <summary>
	/// Game data provider
	/// </summary>
	/// <remarks>
	/// In C#, the file name for the resource is case sensitive and 
	/// location dependent.
	/// 
	/// If the file is in the root directory for the project
	/// then just use the name of the file.  If the file is
	/// in a sub folder then include it as a namespace. For
	/// example, if file foo.xml is in the root of the
	/// project, then use "foo.xml" but if foo.xml is in the
	/// folder "Bar.Baz" then the name beomes "Bar.Baz.foo.xml"
	/// </remarks>
	public class GameDataResource  : IGameDataProvider
	{
		string fileName = @"GameData.xml";  // name of embedded resource
//		string fileName = @"Developoly.Business.GameData.xml";  // name of embedded resource

		DataSet gameData = null;
		bool loadAttempted = false;

		public GameDataResource()
		{
			LoadDataFromResource();
		}

		public bool HaveData
		{
			get
			{
				return (gameData != null);
			}
		}
		public DataSet Data
		{
			get
			{
				return gameData;
			}
		}

		private void LoadDataFromResource()
		{
			if( !this.loadAttempted) //try once
			{
				try
				{
					Assembly asm = this.GetType().Assembly;
					Stream file = asm.GetManifestResourceStream(fileName);

					if(file != null)
					{
						DataSet gameData = new DataSet();
						gameData.ReadXml(file);

						this.gameData = gameData;
					}
				}
				catch (Exception)
				{
					this.gameData = null;
				}
			}
			this.loadAttempted = true;
		}

	}//class
}// namespace

using RithmicApi.Models;
using RithmicApi.Systems;

namespace RithmicApi.Services
{
	public static class RithmicServerProvider
	{
		public static DataRithmicServer GetServer(string system, string gateway)
		{
			switch (system)
			{
			case "Rithmic_01":
				return SystemRithmic01.GetServer(gateway);
			case "Rithmic_Paper_Trading":
				return SystemPaperTrading.GetServer(gateway);
			case "Rithmic_04_Colo":
				return System04Colo.GetServer(gateway);
			case "Rithmic_Test":
				return SystemTest.GetServer(gateway);
			case "TopsetpTrader":
				return SystemTopstepTrader.GetServer(gateway);
			case "MES_Capital":
				return SystemMesCapital.GetServer(gateway);
			case "SpeedUp":
				return SystemSpeedUp.GetServer(gateway);
			case "UProfitTrader":
				return SystemUProfitTrader.GetServer(gateway);
			case "TradeFundrr":
				return SystemTradeFundrr.GetServer(gateway);
			case "Apex":
				return SystemApex.GetServer(gateway);
			case "Leeloo_Trading":
				return SystemLeelooTrading.GetServer(gateway);
			case "TheTradingPit":
				return SystemTheTradingPit.GetServer(gateway);
			default:
				return null;
			}
		}
	}
}

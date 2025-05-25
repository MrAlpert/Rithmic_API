using RithmicApi.Models;

namespace RithmicApi.Systems
{
	public class SystemUProfitTrader
	{
		public static DataRithmicServer GetServer(string gateway)
		{
			switch (gateway)
			{
			case "Chicago_Area":
				return GatewayChicagoArea();
			case "Seoul":
				return GatewaySeoul();
			case "Mumbai":
				return GatewayMumbai();
			case "Sao_Paolo":
				return GatewaySaoPaolo();
			default:
				return null;
			}
		}

		public static DataRithmicServer GatewayChicagoArea()
		{
			return new DataRithmicServer
			{
				Name = "",
				AdmCnnctPt = "",
				AppName = "",
				AppVersion = "",
				CertFile = "",
				LogFilePath = "",
				DmnSrvrAddr = "",
				DomainName = "",
				LicSrvrAddr = "",
				LocBrokAddr = "",
				LoggerAddr = "",
				MdConnectionPoint = "",
				TsConnectionPoint = "",
				PnlConnectionPoint = "",
				HistorycConnectionPoint = ""
			};
		}

		public static DataRithmicServer GatewaySeoul()
		{
			return new DataRithmicServer
			{
				Name = "",
				AdmCnnctPt = "",
				AppName = "",
				AppVersion = "",
				CertFile = "",
				LogFilePath = "",
				DmnSrvrAddr = "",
				DomainName = "",
				LicSrvrAddr = "",
				LocBrokAddr = "",
				LoggerAddr = "",
				MdConnectionPoint = "",
				TsConnectionPoint = "",
				PnlConnectionPoint = "",
				HistorycConnectionPoint = ""
			};
		}

		public static DataRithmicServer GatewayMumbai()
		{
			return new DataRithmicServer
			{
				Name = "",
				AdmCnnctPt = "",
				AppName = "",
				AppVersion = "",
				CertFile = "",
				LogFilePath = "",
				DmnSrvrAddr = "",
				DomainName = "",
				LicSrvrAddr = "",
				LocBrokAddr = "",
				LoggerAddr = "",
				MdConnectionPoint = "",
				TsConnectionPoint = "",
				PnlConnectionPoint = "",
				HistorycConnectionPoint = ""
			};
		}

		public static DataRithmicServer GatewaySaoPaolo()
		{
			return new DataRithmicServer
			{
				Name = "",
				AdmCnnctPt = "",
				AppName = "",
				AppVersion = "",
				CertFile = "",
				LogFilePath = "",
				DmnSrvrAddr = "",
				DomainName = "",
				LicSrvrAddr = "",
				LocBrokAddr = "",
				LoggerAddr = "",
				MdConnectionPoint = "",
				TsConnectionPoint = "",
				PnlConnectionPoint = "",
				HistorycConnectionPoint = ""
			};
		}
	}
}

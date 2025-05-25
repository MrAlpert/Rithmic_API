using RithmicApi.Models;

namespace RithmicApi.Systems
{
	public class System04Colo
	{
		public static DataRithmicServer GetServer(string gateway)
		{
			switch (gateway)
			{
			case "Aurora":
				return GatewayAurora();
			case "Aurora_Area":
				return GatewayAuroraArea();
			case "Colo_75":
				return GatewayColo75();
			default:
				return null;
			}
		}

		public static DataRithmicServer GatewayAurora()
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

		public static DataRithmicServer GatewayAuroraArea()
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

		public static DataRithmicServer GatewayColo75()
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

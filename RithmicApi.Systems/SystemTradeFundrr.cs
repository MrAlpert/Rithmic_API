using RithmicApi.Models;

namespace RithmicApi.Systems
{
	public class SystemTradeFundrr
	{
		public static DataRithmicServer GetServer(string gateway)
		{
			switch (gateway)
			{
			case "Chicago_Area":
				return GatewayChicagoArea();
			case "Mumbai":
				return GatewayMumbai();
			case "Seoul":
				return GatewaySeoul();
			case "Hong_Kong":
				return GatewayHongKong();
			case "Sao_Paolo":
				return GatewaySaoPaolo();
			case "Singapore":
				return GatewaySingapore();
			case "Tokyo":
				return GatewayTokyo();
			case "Sydney":
				return GatewaySydney();
			case "Frankfurt":
				return GatewayFrankfurt();
			case "Europe":
				return GatewayEurope();
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

		public static DataRithmicServer GatewayFrankfurt()
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

		public static DataRithmicServer GatewayHongKong()
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

		public static DataRithmicServer GatewaySingapore()
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

		public static DataRithmicServer GatewayTokyo()
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

		public static DataRithmicServer GatewaySydney()
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

		public static DataRithmicServer GatewayEurope()
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

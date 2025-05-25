using RithmicApi.Models;

namespace RithmicApi.Systems
{
	public static class SystemPaperTrading
	{
		public static DataRithmicServer GetServer(string gateway)
		{
			switch (gateway)
			{
			case "Chicago_Area":
				return GatewayChicagoArea();
			case "Europe":
				return GatewayEurope();
			case "Frankfurt":
				return GatewayFrankfurt();
			case "Mumbai":
				return GatewayMumbai();
			case "Satelite_Link":
				return GatewaySateliteLink();
			case "Colo_75":
				return GatewayColo75();
			case "Singapore":
				return GatewaySingapore();
			case "Tokyo":
				return GatewayTokyo();
			case "Hong_Kong":
				return GatewayHongKong();
			case "Sydney":
				return GatewaySydney();
			case "Sao_Paolo":
				return GatewaySaoPaolo();
			case "Seoul":
				return GatewaySeoul();
			default:
				return null;
			}
		}

		public static DataRithmicServer GatewayChicagoArea()
		{
			return new DataRithmicServer
			{
				Name = "Rithmic Demo",
				AdmCnnctPt = "dd_admin_sslc",
				AppName = "TradeMonitor3",
				AppVersion = "1.0.0.0",
				CertFile = "RithmicCertificate.pk12",
				LogFilePath = "smd.log",
				DmnSrvrAddr = "ritpz01004.01.rithmic.com:65000~ritpz04063.04.rithmic.com:65000~ritpz01004.01.rithmic.net:65000~ritpz04063.04.rithmic.net:65000~ritpz01004.01.theomne.net:65000~ritpz04063.04.theomne.net:65000~ritpz01004.01.theomne.com:65000~ritpz04063.04.theomne.com:65000",
				DomainName = "rithmic_paper_prod_domain",
				LicSrvrAddr = "ritpz04063.04.rithmic.com:56000~ritpz01004.01.rithmic.com:56000~ritpz04063.04.rithmic.net:56000~ritpz01004.01.rithmic.net:56000~ritpz04063.04.theomne.net:56000~ritpz01004.01.theomne.net:56000~ritpz04063.04.theomne.com:56000~ritpz01004.01.theomne.com:56000",
				LocBrokAddr = "ritpa11120.11.rithmic.com:64100",
				LoggerAddr = "ritpz04063.04.rithmic.com:45454~ritpz01004.01.rithmic.com:45454~ritpz04063.04.rithmic.net:45454~ritpz01004.01.rithmic.net:45454~ritpz04063.04.theomne.net:45454~ritpz01004.01.theomne.net:45454~ritpz04063.04.theomne.com:45454~ritpz01004.01.theomne.com:45454",
				MdConnectionPoint = "login_agent_tp_aws_europec",
				TsConnectionPoint = "login_agent_op_aws_europec",
				PnlConnectionPoint = "login_agent_pnl_paperc",
				HistorycConnectionPoint = "login_agent_history_paperc"
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

		public static DataRithmicServer GatewayFrankfurt()
		{
			return new DataRithmicServer
			{
				Name = "Frankfurt",
				AdmCnnctPt = "dd_admin_sslc",
				AppName = "TradeMonitor3",
				AppVersion = "1.0.0.0",
				CertFile = "RithmicCertificate.pk12",
				LogFilePath = "smd.log",
				DmnSrvrAddr = "ritpz01004.01.rithmic.com:65000~ritpz04063.04.rithmic.com:65000~ritpz01004.01.rithmic.net:65000~ritpz04063.04.rithmic.net:65000~ritpz01004.01.theomne.net:65000~ritpz04063.04.theomne.net:65000~ritpz01004.01.theomne.com:65000~ritpz04063.04.theomne.com:65000",
				DomainName = "rithmic_paper_aws_eu_domain",
				LicSrvrAddr = "ritpz17001.rithmic.com:56000~ritpz04063.04.rithmic.com:56000~ritpz01004.01.rithmic.com:56000~ritpz04063.04.rithmic.net:56000~ritpz01004.01.rithmic.net:56000~ritpz04063.04.theomne.net:56000~ritpz01004.01.theomne.net:56000~ritpz04063.04.theomne.com:56000~ritpz01004.01.theomne.com:56000",
				LocBrokAddr = "ritpz17001.rithmic.com:63100",
				LoggerAddr = "ritpz04063.04.rithmic.com:45454~ritpz01004.01.rithmic.com:45454~ritpz04063.04.rithmic.net:45454~ritpz01004.01.rithmic.net:45454~ritpz04063.04.theomne.net:45454~ritpz01004.01.theomne.net:45454~ritpz04063.04.theomne.com:45454~ritpz01004.01.theomne.com:45454",
				MdConnectionPoint = "login_agent_tp_aws_frankfurtc",
				TsConnectionPoint = "login_agent_op_aws_frankfurtc",
				PnlConnectionPoint = "login_agent_pnl_aws_frankfurtc",
				HistorycConnectionPoint = "login_agent_history_paper_aws_frankfurtc"
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

		public static DataRithmicServer GatewaySateliteLink()
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

		public static DataRithmicServer GatewaySingapore()
		{
			return new DataRithmicServer
			{
				Name = "Rithmic Demo singaporec",
				AdmCnnctPt = "dd_admin_sslc",
				AppName = "TradeMonitor3",
				AppVersion = "1.0.0.0",
				CertFile = "RithmicCertificate.pk12",
				LogFilePath = "smd.log",
				DmnSrvrAddr = "ritpz01004.01.rithmic.com:65000~ritpz04063.04.rithmic.com:65000~ritpz01004.01.rithmic.net:65000~ritpz04063.04.rithmic.net:65000~ritpz01004.01.theomne.net:65000~ritpz04063.04.theomne.net:65000~ritpz01004.01.theomne.com:65000~ritpz04063.04.theomne.com:65000",
				DomainName = "rithmic_paper_aws_sg_domain",
				LicSrvrAddr = "ritpz06001.rithmic.com:56000~ritpz04063.04.rithmic.com:56000~ritpz01004.01.rithmic.com:56000~ritpz04063.04.rithmic.net:56000~ritpz01004.01.rithmic.net:56000~ritpz04063.04.theomne.net:56000~ritpz01004.01.theomne.net:56000~ritpz04063.04.theomne.com:56000~ritpz01004.01.theomne.com:56000",
				LocBrokAddr = "ritpz06001.rithmic.com:63100",
				LoggerAddr = "ritpz04063.04.rithmic.com:45454~ritpz01004.01.rithmic.com:45454~ritpz04063.04.rithmic.net:45454~ritpz01004.01.rithmic.net:45454~ritpz04063.04.theomne.net:45454~ritpz01004.01.theomne.net:45454~ritpz04063.04.theomne.com:45454~ritpz01004.01.theomne.com:45454",
				MdConnectionPoint = "login_agent_tp_paper_singaporec",
				TsConnectionPoint = "login_agent_op_paper_singaporec",
				PnlConnectionPoint = "login_agent_pnl_paper_singaporec",
				HistorycConnectionPoint = "login_agent_repository_aws_singaporec"
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

		public static DataRithmicServer GatewayHongKong()
		{
			return new DataRithmicServer
			{
				Name = "Rithmic Demo Hong Kong",
				AdmCnnctPt = "dd_admin_sslc",
				AppName = "TradeMonitor3",
				AppVersion = "1.0.0.0",
				CertFile = "RithmicCertificate.pk12",
				LogFilePath = "smd.log",
				DmnSrvrAddr = "ritpz01004.01.rithmic.com:65000~ritpz04063.04.rithmic.com:65000~ritpz01004.01.rithmic.net:65000~ritpz04063.04.rithmic.net:65000~ritpz01004.01.theomne.net:65000~ritpz04063.04.theomne.net:65000~ritpz01004.01.theomne.com:65000~ritpz04063.04.theomne.com:65000",
				DomainName = "rithmic_paper_aws_hk_domain",
				LicSrvrAddr = "ritpz19001.rithmic.com:56000~ritpz04063.04.rithmic.com:56000~ritpz01004.01.rithmic.com:56000~ritpz04063.04.rithmic.net:56000~ritpz01004.01.rithmic.net:56000~ritpz04063.04.theomne.net:56000~ritpz01004.01.theomne.net:56000~ritpz04063.04.theomne.com:56000~ritpz01004.01.theomne.com:56000",
				LocBrokAddr = "ritpz19001.rithmic.com:63100",
				LoggerAddr = "ritpz04063.04.rithmic.com:45454~ritpz01004.01.rithmic.com:45454~ritpz04063.04.rithmic.net:45454~ritpz01004.01.rithmic.net:45454~ritpz04063.04.theomne.net:45454~ritpz01004.01.theomne.net:45454~ritpz04063.04.theomne.com:45454~ritpz01004.01.theomne.com:45454",
				MdConnectionPoint = "login_agent_tp_paper_hongkongc",
				TsConnectionPoint = "login_agent_op_paper_hongkongc",
				PnlConnectionPoint = "login_agent_pnl_paper_hongkongc",
				HistorycConnectionPoint = "login_agent_repository_aws_hongkongc"
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
	}
}

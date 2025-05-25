using RithmicApi.Models;

namespace RithmicApi.Systems
{
	public class SystemTest
	{
		public static DataRithmicServer GetServer(string gateway)
		{
			if (gateway == "Orangeburg")
			{
				return GatewayOrangeburg();
			}
			return null;
		}

		public static DataRithmicServer GatewayOrangeburg()
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

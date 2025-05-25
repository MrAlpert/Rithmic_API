using System;
using System.Threading;
using com.omnesys.rapi;
using RithmicApi.Callbacks;
using RithmicApi.Enums;
using RithmicApi.Models;
using RithmicApi.Services;

namespace RithmicApi
{
	public class RithmicFeederApi
	{
		public REngine OEngine;

		public DataRithmicServer RServer;

		public MyCallbacks OCallback;

		public REngineParams rEngineParams;

		public string Login { get; set; }

		public string Password { get; set; }

		public string DataServerCenter { get; set; }

		public string DataServerGateway { get; set; }

		public bool IsConnected { get; set; }

		public RithmicServerType Server { get; set; }

		public event EventHandler<RithmicNewMarketData> OnQuoteUpdate;

		public event EventHandler<bool> OnConnectionUpdate;

		public virtual void OnQuoteUpdateCompleted(RithmicNewMarketData quote)
		{
			this.OnQuoteUpdate?.Invoke(this, quote);
		}

		public RithmicFeederApi(string login, string password, string dataServerCenter, string dataServerGateway)
		{
			Login = login;
			Password = password;
			DataServerCenter = dataServerCenter;
			DataServerGateway = dataServerGateway;
		}

		public void Start()
		{
			RServer = RithmicServerProvider.GetServer(DataServerCenter, DataServerGateway);
			OCallback = new MyCallbacks(this);
			rEngineParams = new REngineParams();
			rEngineParams.AdmCnnctPt = RServer.AdmCnnctPt;
			rEngineParams.AppName = RServer.AppName;
			rEngineParams.AppVersion = RServer.AppVersion;
			rEngineParams.AdmCallbacks = new MyAdmCallbacks();
			rEngineParams.CertFile = RServer.CertFile;
			rEngineParams.LogFilePath = RServer.LogFilePath;
			rEngineParams.DmnSrvrAddr = RServer.DmnSrvrAddr;
			rEngineParams.DomainName = RServer.DomainName;
			rEngineParams.LicSrvrAddr = RServer.LicSrvrAddr;
			rEngineParams.LocBrokAddr = RServer.LocBrokAddr;
			rEngineParams.LoggerAddr = RServer.LoggerAddr;
			OEngine = new REngine(rEngineParams);
			OEngine.login(OCallback, Login, Password, RServer.MdConnectionPoint, Login, Password, RServer.TsConnectionPoint, RServer.PnlConnectionPoint, RServer.HistorycConnectionPoint);
			for (int i = 0; i < 30; i++)
			{
				Thread.Sleep(1000);
			}
		}

		public void Subscribe(string exchange, string symbol)
		{
			OEngine.subscribe(exchange, symbol, SubscriptionFlags.Best, null);
		}

		public void Unsubscribe(string exchange, string symbol)
		{
			OEngine.unsubscribe(exchange, symbol);
		}

		public void Stop()
		{
			OEngine.logout();
			OEngine.shutdown();
			OEngine = null;
		}

		public void OnQuote(bool isAsk, double price, string symbolId)
		{
			if (isAsk)
			{
				OnQuoteUpdateCompleted(new RithmicNewMarketData
				{
					Symbol = symbolId,
					Ask = price
				});
			}
			else
			{
				OnQuoteUpdateCompleted(new RithmicNewMarketData
				{
					Symbol = symbolId,
					Bid = price
				});
			}
		}
	}
}

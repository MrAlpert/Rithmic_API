using System;
using System.Collections;
using System.Text;
using com.omnesys.rapi;

namespace RithmicApi.Callbacks
{
	public class MyCallbacks : RCallbacks
	{
		private RithmicFeederApi SessionRithmic;

		private bool PRI_bGotAccounts;

		private AccountInfo PRI_oAccount;

		public Hashtable bid = new Hashtable();

		public Hashtable ask = new Hashtable();

		private bool PRI_bLoggedIntoMd;

		private bool PRI_bGotPriceIncrInfo;

		public bool LoggedIntoMd => PRI_bLoggedIntoMd;

		public bool GotPriceIncrInfo => PRI_bGotPriceIncrInfo;

		public AccountInfo Account => PRI_oAccount;

		public bool GotAccounts => PRI_bGotAccounts;

		public MyCallbacks(RithmicFeederApi rithmic)
		{
			SessionRithmic = rithmic;
			PRI_bLoggedIntoMd = false;
			PRI_bGotPriceIncrInfo = false;
		}

		public override void Alert(AlertInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
			if (oInfo.AlertType == AlertType.ConnectionOpened && oInfo.ConnectionId == ConnectionId.MarketData)
			{
				PRI_bLoggedIntoMd = true;
			}
		}

		public override void AskQuote(AskInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void BestAskQuote(AskInfo oInfo)
		{
			SessionRithmic.OnQuote(true, oInfo.Price, oInfo.Symbol);
		}

		public override void BestBidQuote(BidInfo oInfo)
		{
			SessionRithmic.OnQuote(false, oInfo.Price, oInfo.Symbol);
		}

		public override void BidQuote(BidInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void BinaryContractList(BinaryContractListInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void ClosePrice(ClosePriceInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void ClosingIndicator(ClosingIndicatorInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void EndQuote(EndQuoteInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void InstrumentByUnderlying(InstrumentByUnderlyingInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void EquityOptionStrategyList(EquityOptionStrategyListInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void ExchangeList(ExchangeListInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void HighPrice(HighPriceInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void LimitOrderBook(OrderBookInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void LowPrice(LowPriceInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void MarketMode(MarketModeInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void OpenInterest(OpenInterestInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void OpenPrice(OpenPriceInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void OptionList(OptionListInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void OpeningIndicator(OpeningIndicatorInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void PriceIncrUpdate(PriceIncrInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
			if (oInfo.RpCode == 0)
			{
				PRI_bGotPriceIncrInfo = true;
			}
		}

		public override void RefData(RefDataInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void SettlementPrice(SettlementPriceInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void Strategy(StrategyInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void StrategyList(StrategyListInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void TradeCondition(TradeInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void TradePrint(TradeInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void TradeVolume(TradeVolumeInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void TimeBar(TimeBarInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void TimeBarReplay(TimeBarReplayInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void TradeReplay(TradeReplayInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			Console.WriteLine(stringBuilder);
		}

		public override void AccountList(AccountListInfo oInfo)
		{
			PRI_bGotAccounts = true;
			if (oInfo.Accounts.Count > 0)
			{
				PRI_oAccount = new AccountInfo(oInfo.Accounts[0].FcmId, oInfo.Accounts[0].IbId, oInfo.Accounts[0].AccountId);
			}
		}

		public override void PasswordChange(PasswordChangeInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void ProductRmsList(ProductRmsListInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void ExecutionReplay(ExecutionReplayInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void LineUpdate(LineInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void OpenOrderReplay(OrderReplayInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void OrderReplay(OrderReplayInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void SingleOrderReplay(SingleOrderReplayInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void TradeRoute(TradeRouteInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void TradeRouteList(TradeRouteListInfo oInfo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oInfo.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void PnlReplay(PnlReplayInfo oInfo)
		{
		}

		public override void PnlUpdate(PnlInfo oInfo)
		{
		}

		public override void SodUpdate(SodReport oReport)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oReport.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void BustReport(OrderBustReport oReport)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oReport.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void CancelReport(OrderCancelReport oReport)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oReport.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void FailureReport(OrderFailureReport oReport)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oReport.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void FillReport(OrderFillReport oReport)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oReport.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void ModifyReport(OrderModifyReport oReport)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oReport.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void NotCancelledReport(OrderNotCancelledReport oReport)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oReport.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void NotModifiedReport(OrderNotModifiedReport oReport)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oReport.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void OtherReport(OrderReport oReport)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oReport.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void RejectReport(OrderRejectReport oReport)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oReport.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void StatusReport(OrderStatusReport oReport)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oReport.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void TradeCorrectReport(OrderTradeCorrectReport oReport)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oReport.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void TriggerPulledReport(OrderTriggerPulledReport oReport)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oReport.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void TriggerReport(OrderTriggerReport oReport)
		{
			StringBuilder stringBuilder = new StringBuilder();
			oReport.Dump(stringBuilder);
			stringBuilder.AppendFormat("\n");
			Console.WriteLine(stringBuilder);
		}

		public override void BestBidAskQuote(BidInfo oBid, AskInfo oAsk)
		{
		}
	}
}

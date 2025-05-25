using System.Text;
using com.omnesys.rapi;

namespace RithmicApi.Callbacks
{
	internal class MyAdmCallbacks : AdmCallbacks
	{
		public override void Alert(AlertInfo oInfo)
		{
			StringBuilder sb = new StringBuilder();
			oInfo.Dump(sb);
		}
	}
}

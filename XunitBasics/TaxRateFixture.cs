using System;
using System.Collections.Generic;
using System.Text;

namespace XunitBasics
{
	public class TaxRateFixture : IDisposable
	{
		public Dictionary<string, decimal> _stateTaxes { get; private set; }

		public TaxRateFixture()
		{
			_stateTaxes = new Dictionary<string, decimal>
			{
				{"NY",0.08m },
				{"OH",0.06m },
				{"NJ",0.10m },
				{"TX",0.15m }


			};
		}

		public void Dispose()
		{
			_stateTaxes.Clear();
		}
	}
}

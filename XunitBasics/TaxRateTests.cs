using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XunitBasics
{
	public class TaxRateTests : IClassFixture<TaxRateFixture>
	{
		private readonly TaxRateFixture _fixture;

		public TaxRateTests(TaxRateFixture fixture)
		{
			_fixture = fixture;
		}

		[Fact]

		public void test_NewYorkTaxRate_isEight()
		{
			decimal result = _fixture._stateTaxes["NY"];
			Assert.Equal(0.08m, result);
		}

		[Fact]

		public void test_TexasTaxRate_isFifteen()
		{
			decimal result = _fixture._stateTaxes["TX"];
			Assert.Equal(0.15m, result);
		}
	}
}

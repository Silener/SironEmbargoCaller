namespace VCSBankInstantPaymentsSironEmbargoClient
{
    public class SironConfigurationDataProvider
    {
		public ISironLogger SironLogger { get; set; }

		public ISironWebServiceConfigurationProvider SironWebServiceConfigProvider { get; set; }

        public SironConfigurationDataProvider(ISironLogger sironLogger, ISironWebServiceConfigurationProvider webConfigProvider)
        {
			SironLogger = sironLogger;
			SironWebServiceConfigProvider = webConfigProvider;
        }
    }
}

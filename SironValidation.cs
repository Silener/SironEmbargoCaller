using System.Threading.Tasks;
using System.Xml;
using VCSBankInstantPaymentsSironEmbargoClient.SIRONEmbargoClient;

namespace VCSBankInstantPaymentsSironEmbargoClient
{
	public enum SironCheckResult
	{
        CheckPassed = 1,
        HitFounded = 2,
        CheckFailed = 3,
        AutomaticPass = 4
	}
	
	public class SironValidation
	{
        public string generatedReason;

		public SironValidation()
		{
            generatedReason = "";
        }

        private SironCheckResult MakeSironCheck(string requestXml, SironConfigurationDataProvider sironParameters)
        {
            SironCheckResult sironCheckResult = SironCheckResult.CheckFailed;

			TransactionScoring03RequestData sironTransactionScoringData = new TransactionScoring03RequestData
			{
				serviceURL = sironParameters.SironWebServiceConfigProvider.GetServiceURL(),
				username = sironParameters.SironWebServiceConfigProvider.GetUsername(),
				password = sironParameters.SironWebServiceConfigProvider.GetPlainPassword(),
				format = sironParameters.SironWebServiceConfigProvider.GetMessageFormat(),
				searchMode = sironParameters.SironWebServiceConfigProvider.GetSearchMode(),
				multiCheckInstance = sironParameters.SironWebServiceConfigProvider.GetMessageIstance(),
				paymentSystem = sironParameters.SironWebServiceConfigProvider.GetPaymentSystem(),
				transferDirection = sironParameters.SironWebServiceConfigProvider.GetTransactionDirection()
			};
			
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(requestXml);

            XmlNodeList documentTagList = xmlDocument.GetElementsByTagName("Document");
            string parsedXml = ""; 

            for (int i = 0; i < documentTagList.Count; i++)
            {
                parsedXml = documentTagList[i].OuterXml;
            }

            if(parsedXml.Length <= 0)
            {
                parsedXml = requestXml;
            }

            sironTransactionScoringData.xmlData = parsedXml;

            TransactionScoring03RequestSender transactionScoringRequestSender = new TransactionScoring03RequestSender(sironTransactionScoringData, sironParameters.SironLogger);

            bool isCheckFailed = false;
            if (!transactionScoringRequestSender.ScoreTransactionSend())
                isCheckFailed = true;

            if (transactionScoringRequestSender.isHitFound)
            {
                sironCheckResult = SironCheckResult.HitFounded;

                generatedReason = "Открит HIT в Siron.";
            }
            else if(!transactionScoringRequestSender.isHitFound && !isCheckFailed)
            {
                sironCheckResult = SironCheckResult.CheckPassed;
            }
            else
            {
                sironCheckResult = SironCheckResult.CheckFailed;
            }

            return sironCheckResult;
        }

		public SironCheckResult Validate(string requestXml, SironConfigurationDataProvider sironParameters)
		{
			return MakeSironCheck(requestXml, sironParameters);
		}
	}
}

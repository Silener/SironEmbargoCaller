namespace VCSBankInstantPaymentsSironEmbargoClient
{
    namespace SIRONEmbargoClient
    {
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
		[System.ServiceModel.ServiceContractAttribute(Namespace = "https://siron-app2.westeastbank.com/embargo/services/TransactionScoring03", ConfigurationName = "TransactionScoring03")]
		public interface TransactionScoring03
		{

			// CODEGEN: Generating message contract since the wrapper namespace (http://v3.server.transaction.webservice.embargo.tonbeller.com) of message scoreTransactionRequest does not match the default value (https://siron-app2.westeastbank.com/embargo/services/TransactionScoring03)
			[System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
			[System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(HitWord))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScoringDetailResult02))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessRuleResult))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(TransactionResult03))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalData))]
			scoreTransactionResponse scoreTransaction(scoreTransactionRequest request);

			// CODEGEN: Generating message contract since the wrapper namespace (http://v3.server.transaction.webservice.embargo.tonbeller.com) of message getRequestStatusRequest does not match the default value (https://siron-app2.westeastbank.com/embargo/services/TransactionScoring03)
			[System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
			[System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(HitWord))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScoringDetailResult02))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessRuleResult))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(TransactionResult03))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalData))]
			getRequestStatusResponse getRequestStatus(getRequestStatusRequest request);

			// CODEGEN: Generating message contract since the wrapper namespace (http://v3.server.transaction.webservice.embargo.tonbeller.com) of message getTransactionStatusRequest does not match the default value (https://siron-app2.westeastbank.com/embargo/services/TransactionScoring03)
			[System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
			[System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(HitWord))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScoringDetailResult02))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessRuleResult))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(TransactionResult03))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalData))]
			getTransactionStatusResponse getTransactionStatus(getTransactionStatusRequest request);

			// CODEGEN: Generating message contract since the wrapper namespace (http://v3.server.transaction.webservice.embargo.tonbeller.com) of message getAllFinalStatusRequest does not match the default value (https://siron-app2.westeastbank.com/embargo/services/TransactionScoring03)
			[System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
			[System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(HitWord))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScoringDetailResult02))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessRuleResult))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(TransactionResult03))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalData))]
			getAllFinalStatusResponse getAllFinalStatus(getAllFinalStatusRequest request);

			// CODEGEN: Generating message contract since the wrapper namespace (http://v3.server.transaction.webservice.embargo.tonbeller.com) of message closeTransactionsRequest does not match the default value (https://siron-app2.westeastbank.com/embargo/services/TransactionScoring03)
			[System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
			[System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(HitWord))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScoringDetailResult02))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(BusinessRuleResult))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(TransactionResult03))]
			[System.ServiceModel.ServiceKnownTypeAttribute(typeof(AdditionalData))]
			closeTransactionsResponse closeTransactions(closeTransactionsRequest request);
		}

		/// <remarks/>
		[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
		[System.SerializableAttribute()]
		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.SoapTypeAttribute(Namespace = "urn:commons.webservice.embargo.tonbeller.com")]
		public partial class LoginData
		{

			private string passField;

			private string userNameField;

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string pass
			{
				get
				{
					return this.passField;
				}
				set
				{
					this.passField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string userName
			{
				get
				{
					return this.userNameField;
				}
				set
				{
					this.userNameField = value;
				}
			}
		}

		/// <remarks/>
		[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
		[System.SerializableAttribute()]
		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.SoapTypeAttribute(Namespace = "urn:commons.webservice.embargo.tonbeller.com")]
		public partial class HitWord
		{

			private string fieldIdField;

			private string matchedWordField;

			private double scoreField;

			private string searchedWordField;

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string fieldId
			{
				get
				{
					return this.fieldIdField;
				}
				set
				{
					this.fieldIdField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string matchedWord
			{
				get
				{
					return this.matchedWordField;
				}
				set
				{
					this.matchedWordField = value;
				}
			}

			/// <remarks/>
			public double score
			{
				get
				{
					return this.scoreField;
				}
				set
				{
					this.scoreField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string searchedWord
			{
				get
				{
					return this.searchedWordField;
				}
				set
				{
					this.searchedWordField = value;
				}
			}
		}

		/// <remarks/>
		[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
		[System.SerializableAttribute()]
		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.SoapTypeAttribute(Namespace = "urn:commons.webservice.embargo.tonbeller.com")]
		public partial class ScoringDetailResult02
		{

			private HitWord[] hitsField;

			private int relScoreField;

			private double scoreField;

			private string slIdField;

			private string slInstitutsIdField;

			private string slListNameField;

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public HitWord[] hits
			{
				get
				{
					return this.hitsField;
				}
				set
				{
					this.hitsField = value;
				}
			}

			/// <remarks/>
			public int relScore
			{
				get
				{
					return this.relScoreField;
				}
				set
				{
					this.relScoreField = value;
				}
			}

			/// <remarks/>
			public double score
			{
				get
				{
					return this.scoreField;
				}
				set
				{
					this.scoreField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string slId
			{
				get
				{
					return this.slIdField;
				}
				set
				{
					this.slIdField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string slInstitutsId
			{
				get
				{
					return this.slInstitutsIdField;
				}
				set
				{
					this.slInstitutsIdField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string slListName
			{
				get
				{
					return this.slListNameField;
				}
				set
				{
					this.slListNameField = value;
				}
			}
		}

		/// <remarks/>
		[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
		[System.SerializableAttribute()]
		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.SoapTypeAttribute(Namespace = "urn:server.transaction.webservice.embargo.tonbeller.com")]
		public partial class BusinessRuleResult
		{

			private string brActionField;

			private string brDescriptionField;

			private int brIdField;

			private string brPrePostField;

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string brAction
			{
				get
				{
					return this.brActionField;
				}
				set
				{
					this.brActionField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string brDescription
			{
				get
				{
					return this.brDescriptionField;
				}
				set
				{
					this.brDescriptionField = value;
				}
			}

			/// <remarks/>
			public int brId
			{
				get
				{
					return this.brIdField;
				}
				set
				{
					this.brIdField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string brPrePost
			{
				get
				{
					return this.brPrePostField;
				}
				set
				{
					this.brPrePostField = value;
				}
			}
		}

		/// <remarks/>
		[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
		[System.SerializableAttribute()]
		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.SoapTypeAttribute(Namespace = "urn:server.transaction.webservice.embargo.tonbeller.com")]
		public partial class TransactionResult03
		{

			private AdditionalData[] additionalDataField;

			private BusinessRuleResult[] businessRuleResultsField;

			private ScoringDetailResult02[] detailResultsField;

			private string requestIdField;

			private string statusField;

			private string statusOriginField;

			private string transactionIdField;

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public AdditionalData[] additionalData
			{
				get
				{
					return this.additionalDataField;
				}
				set
				{
					this.additionalDataField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public BusinessRuleResult[] businessRuleResults
			{
				get
				{
					return this.businessRuleResultsField;
				}
				set
				{
					this.businessRuleResultsField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public ScoringDetailResult02[] detailResults
			{
				get
				{
					return this.detailResultsField;
				}
				set
				{
					this.detailResultsField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string requestId
			{
				get
				{
					return this.requestIdField;
				}
				set
				{
					this.requestIdField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string status
			{
				get
				{
					return this.statusField;
				}
				set
				{
					this.statusField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string statusOrigin
			{
				get
				{
					return this.statusOriginField;
				}
				set
				{
					this.statusOriginField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string transactionId
			{
				get
				{
					return this.transactionIdField;
				}
				set
				{
					this.transactionIdField = value;
				}
			}
		}

		/// <remarks/>
		[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
		[System.SerializableAttribute()]
		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.SoapTypeAttribute(Namespace = "urn:server.transaction.webservice.embargo.tonbeller.com")]
		public partial class AdditionalData
		{

			private string dataField;

			private string nameField;

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string data
			{
				get
				{
					return this.dataField;
				}
				set
				{
					this.dataField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string name
			{
				get
				{
					return this.nameField;
				}
				set
				{
					this.nameField = value;
				}
			}
		}

		/// <remarks/>
		[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
		[System.SerializableAttribute()]
		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.SoapTypeAttribute(Namespace = "urn:server.transaction.webservice.embargo.tonbeller.com")]
		public partial class RequestResult03
		{

			private string errorTextField;

			private string requestIdField;

			private int returnValueField;

			private TransactionResult03[] transactionResultsField;

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string errorText
			{
				get
				{
					return this.errorTextField;
				}
				set
				{
					this.errorTextField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string requestId
			{
				get
				{
					return this.requestIdField;
				}
				set
				{
					this.requestIdField = value;
				}
			}

			/// <remarks/>
			public int returnValue
			{
				get
				{
					return this.returnValueField;
				}
				set
				{
					this.returnValueField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public TransactionResult03[] transactionResults
			{
				get
				{
					return this.transactionResultsField;
				}
				set
				{
					this.transactionResultsField = value;
				}
			}
		}

		/// <remarks/>
		[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
		[System.SerializableAttribute()]
		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.SoapTypeAttribute(Namespace = "urn:server.transaction.webservice.embargo.tonbeller.com")]
		public partial class TransactionData
		{

			private string requestIdField;

			private string textDataField;

			private string[] transactionIdsField;

			private byte[] xmlDataField;

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string requestId
			{
				get
				{
					return this.requestIdField;
				}
				set
				{
					this.requestIdField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string textData
			{
				get
				{
					return this.textDataField;
				}
				set
				{
					this.textDataField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string[] transactionIds
			{
				get
				{
					return this.transactionIdsField;
				}
				set
				{
					this.transactionIdsField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(DataType = "base64Binary", IsNullable = true)]
			public byte[] xmlData
			{
				get
				{
					return this.xmlDataField;
				}
				set
				{
					this.xmlDataField = value;
				}
			}
		}

		/// <remarks/>
		[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
		[System.SerializableAttribute()]
		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.SoapTypeAttribute(Namespace = "urn:server.transaction.webservice.embargo.tonbeller.com")]
		public partial class TransactionScoringContext03
		{

			private AdditionalData[] additionalParameterField;

			private string inOutField;

			private string instanceField;

			private string paymentSystemField;

			private string searchModeField;

			private string trxFormatField;

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public AdditionalData[] additionalParameter
			{
				get
				{
					return this.additionalParameterField;
				}
				set
				{
					this.additionalParameterField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string inOut
			{
				get
				{
					return this.inOutField;
				}
				set
				{
					this.inOutField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string instance
			{
				get
				{
					return this.instanceField;
				}
				set
				{
					this.instanceField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string paymentSystem
			{
				get
				{
					return this.paymentSystemField;
				}
				set
				{
					this.paymentSystemField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string searchMode
			{
				get
				{
					return this.searchModeField;
				}
				set
				{
					this.searchModeField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
			public string trxFormat
			{
				get
				{
					return this.trxFormatField;
				}
				set
				{
					this.trxFormatField = value;
				}
			}
		}

		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		[System.ServiceModel.MessageContractAttribute(WrapperName = "scoreTransaction", WrapperNamespace = "http://v3.server.transaction.webservice.embargo.tonbeller.com", IsWrapped = true)]
		public partial class scoreTransactionRequest
		{

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 0)]
			public LoginData loginData;

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 1)]
			public TransactionScoringContext03 @params;

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 2)]
			public TransactionData data;

			public scoreTransactionRequest()
			{
			}

			public scoreTransactionRequest(LoginData loginData, TransactionScoringContext03 @params, TransactionData data)
			{
				this.loginData = loginData;
				this.@params = @params;
				this.data = data;
			}
		}

		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		[System.ServiceModel.MessageContractAttribute(WrapperName = "scoreTransactionResponse", WrapperNamespace = "https://siron-app2.westeastbank.com/embargo/services/TransactionScoring03", IsWrapped = true)]
		public partial class scoreTransactionResponse
		{

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 0)]
			public RequestResult03 scoreTransactionReturn;

			public scoreTransactionResponse()
			{
			}

			public scoreTransactionResponse(RequestResult03 scoreTransactionReturn)
			{
				this.scoreTransactionReturn = scoreTransactionReturn;
			}
		}

		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		[System.ServiceModel.MessageContractAttribute(WrapperName = "getRequestStatus", WrapperNamespace = "http://v3.server.transaction.webservice.embargo.tonbeller.com", IsWrapped = true)]
		public partial class getRequestStatusRequest
		{

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 0)]
			public LoginData loginData;

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 1)]
			public string requestId;

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 2)]
			public bool detailedResult;

			public getRequestStatusRequest()
			{
			}

			public getRequestStatusRequest(LoginData loginData, string requestId, bool detailedResult)
			{
				this.loginData = loginData;
				this.requestId = requestId;
				this.detailedResult = detailedResult;
			}
		}

		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		[System.ServiceModel.MessageContractAttribute(WrapperName = "getRequestStatusResponse", WrapperNamespace = "https://siron-app2.westeastbank.com/embargo/services/TransactionScoring03", IsWrapped = true)]
		public partial class getRequestStatusResponse
		{

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 0)]
			public RequestResult03 getRequestStatusReturn;

			public getRequestStatusResponse()
			{
			}

			public getRequestStatusResponse(RequestResult03 getRequestStatusReturn)
			{
				this.getRequestStatusReturn = getRequestStatusReturn;
			}
		}

		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		[System.ServiceModel.MessageContractAttribute(WrapperName = "getTransactionStatus", WrapperNamespace = "http://v3.server.transaction.webservice.embargo.tonbeller.com", IsWrapped = true)]
		public partial class getTransactionStatusRequest
		{

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 0)]
			public LoginData loginData;

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 1)]
			public string[] transactionIds;

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 2)]
			public bool detailedResult;

			public getTransactionStatusRequest()
			{
			}

			public getTransactionStatusRequest(LoginData loginData, string[] transactionIds, bool detailedResult)
			{
				this.loginData = loginData;
				this.transactionIds = transactionIds;
				this.detailedResult = detailedResult;
			}
		}

		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		[System.ServiceModel.MessageContractAttribute(WrapperName = "getTransactionStatusResponse", WrapperNamespace = "https://siron-app2.westeastbank.com/embargo/services/TransactionScoring03", IsWrapped = true)]
		public partial class getTransactionStatusResponse
		{

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 0)]
			public RequestResult03 getTransactionStatusReturn;

			public getTransactionStatusResponse()
			{
			}

			public getTransactionStatusResponse(RequestResult03 getTransactionStatusReturn)
			{
				this.getTransactionStatusReturn = getTransactionStatusReturn;
			}
		}

		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		[System.ServiceModel.MessageContractAttribute(WrapperName = "getAllFinalStatus", WrapperNamespace = "http://v3.server.transaction.webservice.embargo.tonbeller.com", IsWrapped = true)]
		public partial class getAllFinalStatusRequest
		{

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 0)]
			public LoginData loginData;

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 1)]
			public bool detailedResult;

			public getAllFinalStatusRequest()
			{
			}

			public getAllFinalStatusRequest(LoginData loginData, bool detailedResult)
			{
				this.loginData = loginData;
				this.detailedResult = detailedResult;
			}
		}

		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		[System.ServiceModel.MessageContractAttribute(WrapperName = "getAllFinalStatusResponse", WrapperNamespace = "https://siron-app2.westeastbank.com/embargo/services/TransactionScoring03", IsWrapped = true)]
		public partial class getAllFinalStatusResponse
		{

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 0)]
			public RequestResult03 getAllFinalStatusReturn;

			public getAllFinalStatusResponse()
			{
			}

			public getAllFinalStatusResponse(RequestResult03 getAllFinalStatusReturn)
			{
				this.getAllFinalStatusReturn = getAllFinalStatusReturn;
			}
		}

		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		[System.ServiceModel.MessageContractAttribute(WrapperName = "closeTransactions", WrapperNamespace = "http://v3.server.transaction.webservice.embargo.tonbeller.com", IsWrapped = true)]
		public partial class closeTransactionsRequest
		{

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 0)]
			public LoginData loginData;

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 1)]
			public string[] transactionIds;

			public closeTransactionsRequest()
			{
			}

			public closeTransactionsRequest(LoginData loginData, string[] transactionIds)
			{
				this.loginData = loginData;
				this.transactionIds = transactionIds;
			}
		}

		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		[System.ServiceModel.MessageContractAttribute(WrapperName = "closeTransactionsResponse", WrapperNamespace = "https://siron-app2.westeastbank.com/embargo/services/TransactionScoring03", IsWrapped = true)]
		public partial class closeTransactionsResponse
		{

			[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", Order = 0)]
			public RequestResult03 closeTransactionsReturn;

			public closeTransactionsResponse()
			{
			}

			public closeTransactionsResponse(RequestResult03 closeTransactionsReturn)
			{
				this.closeTransactionsReturn = closeTransactionsReturn;
			}
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
		public interface TransactionScoring03Channel : TransactionScoring03, System.ServiceModel.IClientChannel
		{
		}

		[System.Diagnostics.DebuggerStepThroughAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
		public partial class TransactionScoring03Client : System.ServiceModel.ClientBase<TransactionScoring03>, TransactionScoring03
		{

			public TransactionScoring03Client()
			{
			}

			public TransactionScoring03Client(string endpointConfigurationName) :
					base(endpointConfigurationName)
			{
			}

			public TransactionScoring03Client(string endpointConfigurationName, string remoteAddress) :
					base(endpointConfigurationName, remoteAddress)
			{
			}

			public TransactionScoring03Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
					base(endpointConfigurationName, remoteAddress)
			{
			}

			public TransactionScoring03Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
					base(binding, remoteAddress)
			{
			}

			[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
			scoreTransactionResponse TransactionScoring03.scoreTransaction(scoreTransactionRequest request)
			{
				return base.Channel.scoreTransaction(request);
			}

			public RequestResult03 scoreTransaction(LoginData loginData, TransactionScoringContext03 @params, TransactionData data)
			{
				scoreTransactionRequest inValue = new scoreTransactionRequest();
				inValue.loginData = loginData;
				inValue.@params = @params;
				inValue.data = data;
				scoreTransactionResponse retVal = ((TransactionScoring03)(this)).scoreTransaction(inValue);
				return retVal.scoreTransactionReturn;
			}

			[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
			getRequestStatusResponse TransactionScoring03.getRequestStatus(getRequestStatusRequest request)
			{
				return base.Channel.getRequestStatus(request);
			}

			public RequestResult03 getRequestStatus(LoginData loginData, string requestId, bool detailedResult)
			{
				getRequestStatusRequest inValue = new getRequestStatusRequest();
				inValue.loginData = loginData;
				inValue.requestId = requestId;
				inValue.detailedResult = detailedResult;
				getRequestStatusResponse retVal = ((TransactionScoring03)(this)).getRequestStatus(inValue);
				return retVal.getRequestStatusReturn;
			}

			[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
			getTransactionStatusResponse TransactionScoring03.getTransactionStatus(getTransactionStatusRequest request)
			{
				return base.Channel.getTransactionStatus(request);
			}

			public RequestResult03 getTransactionStatus(LoginData loginData, string[] transactionIds, bool detailedResult)
			{
				getTransactionStatusRequest inValue = new getTransactionStatusRequest();
				inValue.loginData = loginData;
				inValue.transactionIds = transactionIds;
				inValue.detailedResult = detailedResult;
				getTransactionStatusResponse retVal = ((TransactionScoring03)(this)).getTransactionStatus(inValue);
				return retVal.getTransactionStatusReturn;
			}

			[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
			getAllFinalStatusResponse TransactionScoring03.getAllFinalStatus(getAllFinalStatusRequest request)
			{
				return base.Channel.getAllFinalStatus(request);
			}

			public RequestResult03 getAllFinalStatus(LoginData loginData, bool detailedResult)
			{
				getAllFinalStatusRequest inValue = new getAllFinalStatusRequest();
				inValue.loginData = loginData;
				inValue.detailedResult = detailedResult;
				getAllFinalStatusResponse retVal = ((TransactionScoring03)(this)).getAllFinalStatus(inValue);
				return retVal.getAllFinalStatusReturn;
			}

			[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
			closeTransactionsResponse TransactionScoring03.closeTransactions(closeTransactionsRequest request)
			{
				return base.Channel.closeTransactions(request);
			}

			public RequestResult03 closeTransactions(LoginData loginData, string[] transactionIds)
			{
				closeTransactionsRequest inValue = new closeTransactionsRequest();
				inValue.loginData = loginData;
				inValue.transactionIds = transactionIds;
				closeTransactionsResponse retVal = ((TransactionScoring03)(this)).closeTransactions(inValue);
				return retVal.closeTransactionsReturn;
			}
		}

		public class TransactionScoring03RequestData
		{
			/// <summary>
			/// Адрес за изпращане
			/// </summary>
			public string serviceURL;
			/// <summary>
			/// Потребител
			/// </summary>
			public string username;
			/// <summary>
			/// Парола
			/// </summary>
			public string password;
			/// <summary>
			/// Формат на съобщението
			/// </summary>
			public string format;
			/// <summary>
			/// Режим на търсене
			/// </summary>
			public string searchMode;
			/// <summary>
			/// Създаване на инстанции
			/// </summary>
			public string multiCheckInstance;
			/// <summary>
			/// Платежна система
			/// </summary>
			public string paymentSystem;
			/// <summary>
			/// Посока на превода
			/// </summary>
			public string transferDirection;
			/// <summary>
			/// XML данни
			/// </summary>
			public string xmlData;
			

			public TransactionScoring03RequestData()
			{

			}
		}

		public class TransactionScoring03ResponseData
		{
			/// <summary>
			/// Булев флаг, дали е открит HIT в Siron
			/// </summary>
			public bool isHitFound;

			public TransactionScoring03ResponseData()
			{
				isHitFound = false;
			}
		}
	}
}

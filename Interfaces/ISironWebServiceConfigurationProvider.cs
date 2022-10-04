﻿namespace VCSBankInstantPaymentsSironEmbargoClient
{
	/// <summary>
	/// 
	/// </summary>

	public interface ISironWebServiceConfigurationProvider
	{
		// --------------------------------------------------------------------------
		// Constants
		// --------------------------------------------------------------------------

		// --------------------------------------------------------------------------
		// Members
		// --------------------------------------------------------------------------

		// --------------------------------------------------------------------------
		// Properties
		// --------------------------------------------------------------------------

		// --------------------------------------------------------------------------
		// Constructor
		// --------------------------------------------------------------------------

		// --------------------------------------------------------------------------
		// Methods
		// --------------------------------------------------------------------------
		string GetServiceURL();
		string GetUsername();
		string GetPlainPassword();
		string GetSearchMode();
		string GetMessageIstance();
		string GetPaymentSystem();
		string GetTransactionDirection();
		string GetMessageFormat();

		// --------------------------------------------------------------------------
		// Overrides
		// --------------------------------------------------------------------------

	}
}

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MortageDataSwitch.Models
{
    public class SubmitAutoApplicationRequest
    {
        public ApplicationType ApplicationType { get; set; }
        public ApplicationDetails ApplicationDetails { get; set; }
        public ApplicationApplicants ApplicationApplicants { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ApplicationType
    {
        [EnumMember(Value = "SINGLE")]
        Single,
        [EnumMember(Value = "JOINT")]
        Joint
    }

    public class ApplicationDetails
    {
        public AbsaDetails Absa { get; set; }
        public FnbDetails Fnb { get; set; }
        public NedbankDetails Nedbank { get; set; }
        public SbsaDetails Sbsa { get; set; }

        public CommonDetails Common { get; set; }
    }

    public class ApplicationApplicants
    {
        public MainApplicantDetail MainApplicantDetails { get; set; }
        public CoApplicantDetail CoApplicantDetails { get; set; }
    }


    public class AbsaDetails
    {
        [JsonProperty("IsPrimaryResident")]
        public string ApplicaionABSAIsPrimaryResident { get; set; } = "false";
        [JsonProperty("BondAttorney")]
        public string ApplicationABSABondAttorney { get; set; } = string.Empty;
        [JsonProperty("ComplexName")]
        public string ApplicationABSAComplexName { get; set; } = string.Empty;
        [JsonProperty("FamilySpringboard")]
        public string ApplicationABSAFamilySpringboard { get; set; } = "false";
        [JsonProperty("FurtherLoanAccountNumber")]
        public string ApplicationABSAFurtherLoanAccountNumber { get; set; } = string.Empty;
        [JsonProperty("FurtherLoanAmount")]
        public string ApplicationABSAFurtherLoanAmount { get; set; } = "0";
        [JsonProperty("IsNewDevelopment")]
        public string ApplicationABSAIsNewDevelopment { get; set; } = "false";
        [JsonProperty("LoyaltyHomeLoan")]
        public string ApplicationABSALoyaltyHomeLoan { get; set; } = "false";
        [JsonProperty("MyHome")]
        public string ApplicationABSAMyHome { get; set; } = "false";
        [JsonProperty("NewDevelopmentRefNum")]
        public string ApplicationABSANewDevelopmentRefNum { get; set; } = string.Empty;
        [JsonProperty("NotificationCellPhoneNumber")]
        public string ApplicationABSANotificationCellPhoneNumber { get; set; } = string.Empty;
        [JsonProperty("NotificationEmailAddress")]
        public string ApplicationABSANotificationEmailAddress { get; set; } = string.Empty;
        [JsonProperty("NotificationMethodTypeId")]
        public string ApplicationABSANotificationMethodTypeId { get; set; } = "0";
        [JsonProperty("Password")]
        public string ApplicationABSAPassword { get; set; } = string.Empty;
        [JsonProperty("PreviousApplicationNumber")]
        public string ApplicationABSAPReviousApplicationNumber { get; set; } = string.Empty;
        [JsonProperty("PropertyType")]
        public string ApplicationABSAPropertyType { get; set; } = string.Empty;
        [JsonProperty("PurposeOfApplication")]
        public string ApplicationABSAPurposeOfApplication { get; set; } = string.Empty;
        [JsonProperty("ReApplication")]
        public string ApplicationABSAReApplication { get; set; } = "false";
        [JsonProperty("SubClassification")]
        public string ApplicationABSASubClassification { get; set; } = string.Empty;
        [JsonProperty("TransferAttorney")]
        public string ApplicationABSATransferAttorney { get; set; } = string.Empty;
        [JsonProperty("TransferAttorneyCode")]
        public string ApplicationABSATransferAttorneyCode { get; set; } = string.Empty;
        [JsonProperty("TypeOfApplication")]
        public string ApplicationABSATypeOfApplication { get; set; } = string.Empty;
        [JsonProperty("VendorDescription")]
        public string ApplicationABSAVendorDescription { get; set; } = string.Empty;
        [JsonProperty("PreferredBranch")]
        public string ApplicationPreferredABSABranch { get; set; } = string.Empty;
        [JsonProperty("PreferredBranchCode")]
        public string ApplicationPreferredABSABranchCode { get; set; } = string.Empty;
        [JsonProperty("SettleMortgageLoan")]
        public string ApplicationSettleAbsaMortgageLoan { get; set; } = string.Empty;
        [JsonProperty("FlexiReserveOption")]
        public string ApplicationFlexiReserveOption { get; set; } = "0";
    }

    public class FnbDetails
    {
        [JsonProperty("BondAccountNumber")]
        public string ApplicationFNBBondAccountNumber { get; set; } = string.Empty;
        [JsonProperty("BondAttorney")]
        public string ApplicationFNBBondAttorney { get; set; } = string.Empty;
        [JsonProperty("BondFree")]
        public string ApplicationFNBBondFree { get; set; } = "false";
        [JsonProperty("BondHolderName")]
        public string ApplicationFNBBondHolderName { get; set; } = string.Empty;
        [JsonProperty("BondInstitutionBranchName")]
        public string ApplicationFNBBondInstitutionBranchName { get; set; } = string.Empty;
        [JsonProperty("BondInstitutionName")]
        public string ApplicationFNBBondInstitutionName { get; set; } = string.Empty;
        [JsonProperty("Directors")]
        public string ApplicationFNBDirectors { get; set; } = string.Empty;
        [JsonProperty("FutureChoiceRegistrationAmount")]
        public string ApplicationFNBFutureChoiceRegistrationAmount { get; set; } = "0";
        [JsonProperty("FuturePostalAddressCountry")]
        public string ApplicationFNBFuturePostalAddressCountry { get; set; } = string.Empty;
        [JsonProperty("HFVendorCode")]
        public string ApplicationFNBHFVendorCode { get; set; } = string.Empty;
        [JsonProperty("HFVendorDescription")]
        public string ApplicationFNBHFVendorDescription { get; set; } = string.Empty;
        [JsonProperty("ILPNumber")]
        public string ApplicationFNBILPNumber { get; set; } = string.Empty;
        [JsonProperty("IsDevelopment")]
        public string ApplicationFNBIsDevelopment { get; set; } = "false";
        [JsonProperty("LoanType")]
        public string ApplicationFNBLoanType { get; set; } = string.Empty;
        [JsonProperty("MoveHomeNotHomeloanId")]
        public string ApplicationFNBMoveHomeNotHomeloanId { get; set; } = "false";
        [JsonProperty("NumberofStakeholders")]
        public string ApplicationFNBNumberofStakeholders { get; set; } = "0";
        [JsonProperty("PropertyHoldingId")]
        public string ApplicationFNBPropertyHoldingId { get; set; } = string.Empty;
        [JsonProperty("SubPropertyType")]
        public string ApplicationFNBSubPropertyType { get; set; } = string.Empty;
        [JsonProperty("SwitchingBondRegisteredAmount")]
        public string ApplicationFNBSwitchingBondRegisteredAmount { get; set; } = "0";
        [JsonProperty("SwitchingTypeId")]
        public string ApplicationFNBSwitchingTypeId { get; set; } = string.Empty;
        [JsonProperty("TransferAttorney")]
        public string ApplicationFNBTransferAttorney { get; set; } = string.Empty;
        [JsonProperty("TypeOfApplication")]
        public string ApplicationFNBTypeOfApplication { get; set; } = string.Empty;
        [JsonProperty("TypeOfProperty")]
        public string ApplicationFNBTypeOfProperty { get; set; } = string.Empty;
        [JsonProperty("VendorDescription")]
        public string ApplicationFNBVendorDescription { get; set; } = string.Empty;
    }

    public class NedbankDetails
    {
        [JsonProperty("AgencyCode")]
        public string ApplicationNedAgencyCode { get; set; } = string.Empty;
        [JsonProperty("AgencyName")]
        public string ApplicationNedAgencyName { get; set; } = string.Empty;
        [JsonProperty("AssuranceCompany")]
        public string ApplicationNedAssuranceCompany { get; set; } = string.Empty;
        [JsonProperty("AssuranceCoverAmount")]
        public string ApplicationNedAssuranceCoverAmount { get; set; } = "0";
        [JsonProperty("CompanyName")]
        public string ApplicationNEDCompanyName { get; set; } = string.Empty;
        [JsonProperty("CompanyName2")]
        public string ApplicationNEDCompanyName2 { get; set; } = string.Empty;
        [JsonProperty("DebitAccountBranch")]
        public string ApplicationNedDebitAccountBranch { get; set; } = string.Empty;
        [JsonProperty("DebitAccountBranchCode")]
        public string ApplicationNedDebitAccountBranchCode { get; set; } = string.Empty;
        [JsonProperty("DebitAccountInstitution")]
        public string ApplicationNedDebitAccountInstitution { get; set; } = string.Empty;
        [JsonProperty("DeclarationOfWarranty")]
        public string ApplicationNedDeclarationOfWarranty { get; set; } = string.Empty;
        [JsonProperty("LoanReason")]
        public string ApplicationNedLoanReason { get; set; } = string.Empty;
        [JsonProperty("MOIDateOfIssue")]
        public string ApplicationNEDMOIDateOfIssue { get; set; } = string.Empty;
        [JsonProperty("MOIIndexed")]
        public string ApplicationNEDMOIIndexed { get; set; } = string.Empty;
        [JsonProperty("MOIIndicator")]
        public string ApplicationNEDMOIIndicator { get; set; } = string.Empty;
        [JsonProperty("MOIType")]
        public string ApplicationNEDMOIType { get; set; } = string.Empty;
        [JsonProperty("TypeOfProperty")]
        public string ApplicationNedTypeOfProperty { get; set; } = string.Empty;
        [JsonProperty("VendorDescription")]
        public string ApplicationNedVendorDescription { get; set; } = string.Empty;

        [JsonProperty("FinancialYearEnd")]
        public string ApplicationFinancialYearEnd { get; set; }
        [JsonProperty("EconomicSector")]
        public string ApplicationEconomicSector { get; set; }
        [JsonProperty("BusinessFaxNumber")]
        public string ApplicationBusinessFaxNumber { get; set; }
        [JsonProperty("BusinessTelephoneNumber")]
        public string ApplicationBusinessTelephoneNumber { get; set; } 
        [JsonProperty("BusinessFaxCode")]
        public string ApplicationBusinessFaxCode { get; set; } 
        [JsonProperty("BusinessTelephoneCode")]
        public string ApplicationBusinessTelephoneCode { get; set; }
        [JsonProperty("CommercialTitle")]
        public string ApplicationCommercialTitle { get; set; }

    }

    public class SbsaDetails
    {
        [JsonProperty("ExistingHomeLoan")]
        public string ApplicationExistingSTDHomeLoan { get; set; } = "false";
        [JsonProperty("ExistingHomeLoanAccountNo")]
        public string ApplicationExistingSTDHomeLoanAccountNo { get; set; } = string.Empty;
        [JsonProperty("AccountHolder")]
        public string ApplicationSTDAccountHolder { get; set; } = string.Empty;
        [JsonProperty("BondAttorney")]
        public string ApplicationSTDBondAttorney { get; set; } = string.Empty;
        [JsonProperty("DebitAccountBranch")]
        public string ApplicationSTDDebitAccountBranch { get; set; } = string.Empty;
        [JsonProperty("DebitAccountBranchCode")]
        public string ApplicationSTDDebitAccountBranchCode { get; set; } = string.Empty;
        [JsonProperty("DomicleAddress1")]
        public string ApplicationSTDDomicleAddress1 { get; set; } = string.Empty;
        [JsonProperty("DomicleAddress2")]
        public string ApplicationSTDDomicleAddress2 { get; set; } = string.Empty;
        [JsonProperty("DomicleDeliveryMethod")]
        public string ApplicationSTDDomicleDeliveryMethod { get; set; } = string.Empty;
        [JsonProperty("DomiclePaymentDay")]
        public string ApplicationSTDDomiclePaymentDay { get; set; } = string.Empty;
        [JsonProperty("DomicleSuburb")]
        public string ApplicationSTDDomicleSuburb { get; set; } = string.Empty;
        [JsonProperty("DomicleSuburbCode")]
        public string ApplicationSTDDomicleSuburbCode { get; set; } = string.Empty;
        [JsonProperty("EmailAddress")]
        public string ApplicationSTDEmailAddress { get; set; } = string.Empty;
        [JsonProperty("IntendedUseOfAccount")]
        public string ApplicationSTDIntendedUseOfAccount { get; set; } = string.Empty;
        [JsonProperty("PropertyCurrentlyBonded")]
        public string ApplicationSTDPropertyCurrentlyBonded { get; set; } = string.Empty;
        [JsonProperty("PropertySuburb")]
        public string ApplicationSTDPropertySuburb { get; set; } = string.Empty;
        [JsonProperty("PropertySuburbCode")]
        public string ApplicationSTDPropertySuburbCode { get; set; } = string.Empty;
        [JsonProperty("PropertyUse")]
        public string ApplicationSTDPropertyUse { get; set; } = string.Empty;
        [JsonProperty("TransferAttorney")]
        public string ApplicationSTDTransferAttorney { get; set; } = string.Empty;
        [JsonProperty("TypeOfApplication")]
        public string ApplicationSTDTypeOfApplication { get; set; } = string.Empty;
        [JsonProperty("TypeOfLoan")]
        public string ApplicationSTDTypeOfLoan { get; set; } = string.Empty;
        [JsonProperty("TypeOfProperty")]
        public string ApplicationSTDTypeOfProperty { get; set; } = string.Empty;
        [JsonProperty("VendorChannel")]
        public string ApplicationSTDVendorChannel { get; set; } = string.Empty;
        [JsonProperty("VendorCode")]
        public string ApplicationSTDVendorCode { get; set; } = string.Empty;
        [JsonProperty("VendorDescription")]
        public string ApplicationSTDVendorDescription { get; set; } = string.Empty;
        [JsonProperty("VendorUser")]
        public string ApplicationSTDVendorUser { get; set; } = string.Empty;
    }

    public class CommonDetails
    {
        [JsonProperty("AgencyInvolved")]
        public string ApplicationAgencyInvolved { get; set; } = "false";
        [JsonProperty("AgencyNotifyEmailAddress")]
        public string ApplicationAgencyNotifyEmailAddress { get; set; } = string.Empty;
        [JsonProperty("AgencyNotifyOption")]
        public string ApplicationAgencyNotifyOption { get; set; } = string.Empty;
        [JsonProperty("AgentName")]
        public string ApplicationAgentName { get; set; } = string.Empty;
        [JsonProperty("AgencyFax")]
        public string ApplicationAgencyFax { get; set; } = string.Empty;
        [JsonProperty("AIPBanks")]
        public string ApplicationAIPBanks { get; set; } = string.Empty;
        [JsonProperty("AltPropertyContact")]
        public string ApplicationAltPropertyContact { get; set; } = string.Empty;
        [JsonProperty("AmountOfGuarantee")]
        public string ApplicationAmountOfGuarantee { get; set; } = "0";
        [JsonProperty("ApplicationType")]
        public string ApplicationApplicationType { get; set; } = string.Empty;
        [JsonProperty("BondAmountToBeRegistered")]
        public string ApplicationBondAmountToBeRegistered { get; set; } = "0";
        [JsonProperty("BondInstitution")]
        public string ApplicationBondInstitution { get; set; } = string.Empty;
        [JsonProperty("BondRegistrationLegalCosts")]
        public string ApplicationBondRegistrationLegalCosts { get; set; } = "0";
        [JsonProperty("CampaignRefNumber")]
        public string ApplicationCampaignRefNumber { get; set; } = string.Empty;
        [JsonProperty("CashDeposit")]
        public string ApplicationCashDeposit { get; set; } = "0";
        [JsonProperty("CellNumberEstateAgency")]
        public string ApplicationCellNumberEstateAgency { get; set; } = string.Empty;
        [JsonProperty("ConsultantEmailAddress")]
        public string ApplicationConsultantEmailAddress { get; set; } = string.Empty;
        [JsonProperty("CurrentBondBalance")]
        public string ApplicationCurrentBondBalance { get; set; } = "0";
        [JsonProperty("DebtConsolidationOption")]
        public string ApplicationDebtConsolidationOption { get; set; } = string.Empty;
        [JsonProperty("DeclinedBanks")]
        public string ApplicationDeclinedBanks { get; set; } = string.Empty;
        [JsonProperty("EmployerHousingScheme")]
        public string ApplicationEmployerHousingScheme { get; set; } = "false";
        [JsonProperty("EstateAgency")]
        public string ApplicationEstateAgency { get; set; } = string.Empty;
        [JsonProperty("ExistingHomeLoan")]
        public string ApplicationExistingHomeLoan { get; set; } = "false";
        [JsonProperty("FirstPropertyPurchase")]
        public string ApplicationFirstPropertyPurchase { get; set; } = "false";
        [JsonProperty("FixedRateTerm")]
        public string ApplicationFixedRateTerm { get; set; } = string.Empty;
        [JsonProperty("FlexiReserveFurtherOption")]
        public string ApplicationFlexiReserveFurtherOption { get; set; } = string.Empty;
        [JsonProperty("GovernmentSubsidy")]
        public string ApplicationGovernmentSubsidy { get; set; } = "0";
        [JsonProperty("InsuranceQuoteRequired")]
        public string ApplicationInsuranceQuoteRequired { get; set; } = "false";
        [JsonProperty("IsCampaign")]
        public string ApplicationIsCampaign { get; set; } = "false";
        [JsonProperty("IsDebtConsolidation")]
        public string ApplicationIsDebtConsolidation { get; set; } = "false";
        [JsonProperty("Lapa")]
        public string ApplicationLapa { get; set; } = "false";
        [JsonProperty("LoanAmountRequired")]
        public string ApplicationLoanAmountRequired { get; set; } = "0";
        [JsonProperty("LoanType")]
        public string ApplicationLoanType { get; set; } = string.Empty;
        [JsonProperty("LoanTypeId")]
        public string ApplicationLoanTypeId { get; set; } = string.Empty;
        [JsonProperty("MultiPlanFacility")]
        public string ApplicationMultiPlanFacility { get; set; } = "false";
        [JsonProperty("MultiPlanLoanAmount1")]
        public string ApplicationMultiPlanLoanAmount1 { get; set; } = "0";
        [JsonProperty("MultiPlanLoanAmount2")]
        public string ApplicationMultiPlanLoanAmount2 { get; set; } = "0";
        [JsonProperty("MultiPlanLoanTerm1")]
        public string ApplicationMultiPlanLoanTerm1 { get; set; } = "0.0";
        [JsonProperty("MultiPlanLoanTerm2")]
        public string ApplicationMultiPlanLoanTerm2 { get; set; } = "0.0";
        [JsonProperty("MultiPlanPurpose1")]
        public string ApplicationMultiPlanPurpose1 { get; set; } = string.Empty;
        [JsonProperty("MultiPlanPurpose2")]
        public string ApplicationMultiPlanPurpose2 { get; set; } = string.Empty;
        [JsonProperty("NegotiateFixedRate")]
        public string ApplicationNegotiateFixedRate { get; set; } = "false";
        [JsonProperty("Network")]
        public string ApplicationNetwork { get; set; } = string.Empty;
        [JsonProperty("NoOfMultiPlanAccounts")]
        public string ApplicationNoOfMultiPlanAccounts { get; set; } = "0";
        [JsonProperty("OriginatorInvolved")]
        public string ApplicationOriginatorInvolved { get; set; } = "false";
        [JsonProperty("OriginatorNotifyCellphone")]
        public string ApplicationOriginatorNotifyCellphone { get; set; } = string.Empty;
        [JsonProperty("OriginatorNotifyOption")]
        public string ApplicationOriginatorNotifyOption { get; set; } = string.Empty;
        [JsonProperty("OriginatorNotifyPhoneCode")]
        public string ApplicationOriginatorNotifyPhoneCode { get; set; } = string.Empty;
        [JsonProperty("OriginatorNotifyPhoneNo")]
        public string ApplicationOriginatorNotifyPhoneNo { get; set; } = string.Empty;
        [JsonProperty("OtherGuaranteeAmount")]
        public string ApplicationOtherGuaranteeAmount { get; set; } = "0";
        [JsonProperty("PhoneDialCodeEstateAgency")]
        public string ApplicationPhoneDialCodeEstateAgency { get; set; } = string.Empty;
        [JsonProperty("PhoneNumberEstateAgency")]
        public string ApplicationPhoneNumberEstateAgency { get; set; } = string.Empty;
        [JsonProperty("PortionNo")]
        public string ApplicationPortionNo { get; set; } = string.Empty;
        [JsonProperty("PropertyAddressCity")]
        public string ApplicationPropertyAddressCity { get; set; } = string.Empty;
        [JsonProperty("PropertyAddressSuburb")]
        public string ApplicationPropertyAddressSuburb { get; set; } = string.Empty;
        [JsonProperty("PropertyContactCellphone")]
        public string ApplicationPropertyContactCellphone { get; set; } = string.Empty;
        [JsonProperty("PropertyContactName")]
        public string ApplicationPropertyContactName { get; set; } = string.Empty;
        [JsonProperty("PropertyContactTelCode")]
        public string ApplicationPropertyContactTelCode { get; set; } = string.Empty;
        [JsonProperty("PropertyContactTelNo")]
        public string ApplicationPropertyContactTelNo { get; set; } = string.Empty;
        [JsonProperty("PropertyMarketValue")]
        public string ApplicationPropertyMarketValue { get; set; } = "0";
        [JsonProperty("PropertyOccupiedBy")]
        public string ApplicationPropertyOccupiedBy { get; set; } = string.Empty;
        [JsonProperty("PropertyPurchaseDate")]
        public string ApplicationPropertyPurchaseDate { get; set; } = string.Empty;
        [JsonProperty("PropertyPurchasePrice")]
        public string ApplicationPropertyPurchasePrice { get; set; } = "0";
        [JsonProperty("PropertyRoofConstruction")]
        public string ApplicationPropertyRoofConstruction { get; set; } = string.Empty;
        [JsonProperty("PropertyStreetName")]
        public string ApplicationPropertyStreetName { get; set; } = string.Empty;
        [JsonProperty("PropertyStreetNo")]
        public string ApplicationPropertyStreetNo { get; set; } = string.Empty;
        [JsonProperty("PropertyTownship")]
        public string ApplicationPropertyTownship { get; set; } = string.Empty;
        [JsonProperty("PropertyWallConstruction")]
        public string ApplicationPropertyWallConstruction { get; set; } = string.Empty;
        [JsonProperty("RepaymentDay")]
        public string ApplicationRepaymentDay { get; set; } = string.Empty;
        [JsonProperty("SectionalTitleFlatNo")]
        public string ApplicationSectionalTitleFlatNo { get; set; } = string.Empty;
        [JsonProperty("SectionalTitleUnitNo")]
        public string ApplicationSectionalTitleUnitNo { get; set; } = string.Empty;
        [JsonProperty("SellerIDNo")]
        public string ApplicationSellerIDNo { get; set; } = string.Empty;
        [JsonProperty("SellerIdType")]
        public string ApplicationSellerIdType { get; set; } = string.Empty;
        [JsonProperty("SignLegalDocsProvince")]
        public string ApplicationSignLegalDocsProvince { get; set; } = string.Empty;
        [JsonProperty("SignLegalDocsRegion")]
        public string ApplicationSignLegalDocsRegion { get; set; } = string.Empty;
        [JsonProperty("SingleHousehold")]
        public string ApplicationSingleHousehold { get; set; } = string.Empty;
        [JsonProperty("SourceOfFunds")]
        public string ApplicationSourceOfFunds { get; set; } = string.Empty;
        [JsonProperty("SourceOfFunds1")]
        public string ApplicationSourceOfFunds1 { get; set; } = string.Empty;
        [JsonProperty("SourceOfFunds2")]
        public string ApplicationSourceOfFunds2 { get; set; } = string.Empty;
        [JsonProperty("SourceOfFunds3")]
        public string ApplicationSourceOfFunds3 { get; set; } = string.Empty;
        [JsonProperty("SourceOfFunds4")]
        public string ApplicationSourceOfFunds4 { get; set; } = string.Empty;
        [JsonProperty("StandErfNo")]
        public string ApplicationStandErfNo { get; set; } = string.Empty;
        [JsonProperty("SubmittingBanks")]
        public string ApplicationSubmittingBanks { get; set; } = string.Empty;
        [JsonProperty("SuretyshipOffered")]
        public string ApplicationSuretyshipOffered { get; set; } = "false";
        [JsonProperty("TermOfLoan")]
        public string ApplicationTermOfLoan { get; set; } = string.Empty;
        [JsonProperty("TransferAttorneyPhoneNo")]
        public string ApplicationTransferAttorneyPhoneNo { get; set; } = string.Empty;
        [JsonProperty("TypeOfInterest")]
        public string ApplicationTypeOfInterest { get; set; } = string.Empty;

        // extras from fnb
        [JsonProperty("YearOfPurchase")]
        public string ApplicationApplicantYearOfPurchase { get; set; } = string.Empty;
        [JsonProperty("BrandType")]
        public string ApplicationBrandType { get; set; } = string.Empty;
        [JsonProperty("CollateralSecurity")]
        public string ApplicationCollateralSecurity { get; set; } = "0";
        [JsonProperty("ComplexName")]
        public string ApplicationComplexName { get; set; } = string.Empty;
        [JsonProperty("ConsultantCellphone")]
        public string ApplicationConsultantCellphone { get; set; } = string.Empty;
        [JsonProperty("ConsultantFaxNo")]
        public string ApplicationConsultantFaxNo { get; set; } = string.Empty;
        [JsonProperty("ConsultantFirstName")]
        public string ApplicationConsultantFirstName { get; set; } = string.Empty;
        [JsonProperty("ConsultantSurname")]
        public string ApplicationConsultantSurname { get; set; } = string.Empty;
        [JsonProperty("DebitAccountBranch")]
        public string ApplicationDebitAccountBranch { get; set; } = string.Empty;
        [JsonProperty("DebitAccountBranchCode")]
        public string ApplicationDebitAccountBranchCode { get; set; } = string.Empty;
        [JsonProperty("DebitAccountInstitution")]
        public string ApplicationDebitAccountInstitution { get; set; } = string.Empty;
        [JsonProperty("DebitAccountName")]
        public string ApplicationDebitAccountName { get; set; } = string.Empty;
        [JsonProperty("DebitAccountNo")]
        public string ApplicationDebitAccountNo { get; set; } = string.Empty;
        [JsonProperty("DebitAccountType")]
        public string ApplicationDebitAccountType { get; set; } = string.Empty;
        [JsonProperty("DepositCash")]
        public string ApplicationDepositCash { get; set; } = "0";
        [JsonProperty("DepositOther")]
        public string ApplicationDepositOther { get; set; } = "0";
        [JsonProperty("DwellingPurpose")]
        public string ApplicationDwellingPurpose { get; set; } = string.Empty;

        [JsonProperty("FutureChoicePrincipleAmount")]
        public string ApplicationFutureChoicePrincipleAmount { get; set; } = "0";
        [JsonProperty("FuturePostalAddress1")]
        public string ApplicationFuturePostalAddress1 { get; set; } = string.Empty;
        [JsonProperty("FuturePostalAddressCity")]
        public string ApplicationFuturePostalAddressCity { get; set; } = string.Empty;
        [JsonProperty("FuturePostalAddressCode")]
        public string ApplicationFuturePostalAddressCode { get; set; } = string.Empty;
        [JsonProperty("FuturePostalAddressSuburb")]
        public string ApplicationFuturePostalAddressSuburb { get; set; } = string.Empty;
        [JsonProperty("GenericLoanType")]
        public string ApplicationGenericLoanType { get; set; } = string.Empty;
        [JsonProperty("IncludeBondTransferCosts")]
        public string ApplicationIncludeBondTransferCosts { get; set; } = "false";
        [JsonProperty("InstalmentMethod")]
        public string ApplicationInstalmentMethod { get; set; } = string.Empty;
        [JsonProperty("InterestPeriod")]
        public string ApplicationInterestPeriod { get; set; } = string.Empty;
        [JsonProperty("IsTrustCompanyCC")]
        public string ApplicationIsTrustCompanyCC { get; set; } = "false";
        [JsonProperty("MonthlyRepayments")]
        public string ApplicationMonthlyRepayments { get; set; } = string.Empty;
        [JsonProperty("NamePropertyRegistered")]
        public string ApplicationNamePropertyRegistered { get; set; } = string.Empty;
        [JsonProperty("OfferToPurchaseDate")]
        public string ApplicationOfferToPurchaseDate { get; set; } = string.Empty;
        [JsonProperty("OneAccountConvertCheque")]
        public string ApplicationOneAccountConvertCheque { get; set; } = "false";
        [JsonProperty("OneAccountConvertChequeAccountNumber")]
        public string ApplicationOneAccountConvertChequeAccountNumber { get; set; } = string.Empty;
        [JsonProperty("OneAccountConvertILP")]
        public string ApplicationOneAccountConvertILP { get; set; } = string.Empty;
        [JsonProperty("OriginatorEmail")]
        public string ApplicationOriginatorEmail { get; set; } = string.Empty;
        [JsonProperty("PrevMortgagePeriod")]
        public string ApplicationPrevMortgagePeriod { get; set; } = string.Empty;
        [JsonProperty("ProcessingBranch")]
        public string ApplicationProcessingBranch { get; set; } = string.Empty;
        [JsonProperty("PropertyPostalCode")]
        public string ApplicationPropertyPostalCode { get; set; } = string.Empty;
        [JsonProperty("PropertyProvince")]
        public string ApplicationPropertyProvince { get; set; } = string.Empty;
        [JsonProperty("PropertyRight")]
        public string ApplicationPropertyRight { get; set; } = string.Empty;
        [JsonProperty("SectionNo")]
        public string ApplicationSectionNo { get; set; } = string.Empty;
        [JsonProperty("SecurityBonds")]
        public string ApplicationSecurityBonds { get; set; } = "0";
        [JsonProperty("Suretyship")]
        public string ApplicationSuretyship { get; set; } = "0";
        [JsonProperty("TypeOfBond")]
        public string ApplicationTypeOfBond { get; set; } = string.Empty;
        [JsonProperty("TypeOfOffer")]
        public string ApplicationTypeOfOffer { get; set; } = string.Empty;
        [JsonProperty("TypeOfStreet")]
        public string ApplicationTypeOfStreet { get; set; } = string.Empty;

        // extras from nedbank
        [JsonProperty("AdvancePaymentOption")]
        public string ApplicationAdvancePaymentOption { get; set; } = "false";
        [JsonProperty("AgencyCellphone")]
        public string ApplicationAgencyCellphone { get; set; } = string.Empty;
        [JsonProperty("AgencyPhysicalAddress")]
        public string ApplicationAgencyPhysicalAddress { get; set; } = string.Empty;
        [JsonProperty("AgencyPhysicalCity")]
        public string ApplicationAgencyPhysicalCity { get; set; } = string.Empty;
        [JsonProperty("AgencyTel")]
        public string ApplicationAgencyTel { get; set; } = string.Empty;
        [JsonProperty("AgriculturalIndicator")]
        public string ApplicationAgriculturalIndicator { get; set; } = "false";
        [JsonProperty("ApplicationOrigin")]
        public string ApplicationApplicationOrigin { get; set; } = string.Empty;
        [JsonProperty("AreaOfLand")]
        public string ApplicationAreaOfLand { get; set; } = "0";
        [JsonProperty("AssuranceLPAType")]
        public string ApplicationAssuranceLPAType { get; set; } = string.Empty;
        [JsonProperty("AssuranceMonthlyPremium")]
        public string ApplicationAssuranceMonthlyPremium { get; set; } = "0";
        [JsonProperty("AssurancePaymentMethod")]
        public string ApplicationAssurancePaymentMethod { get; set; } = string.Empty;
        [JsonProperty("AttorneyRequestedBy")]
        public string ApplicationAttorneyRequestedBy { get; set; } = string.Empty;
        [JsonProperty("BondAmount")]
        public string ApplicationBondAmount { get; set; } = "0";
        [JsonProperty("BondAttorney")]
        public string ApplicationBondAttorney { get; set; } = string.Empty;
        [JsonProperty("BusinessCountry")]
        public string ApplicationBusinessCountry { get; set; } = string.Empty;
        [JsonProperty("BusinessEmail")]
        public string ApplicationBusinessEmail { get; set; } = string.Empty;
        [JsonProperty("BusinessSourceOfIncomeOther")]
        public string ApplicationBusinessSourceOfIncomeOther { get; set; } = string.Empty;
        [JsonProperty("CommercialOrBusiness")]
        public string ApplicationCommercialOrBusiness { get; set; } = string.Empty;
        [JsonProperty("ConsultantWorkTelNo")]
        public string ApplicationConsultantWorkTelNo { get; set; } = string.Empty;
        [JsonProperty("ContractPrice")]
        public string ApplicationContractPrice { get; set; } = "0";
        [JsonProperty("IndicateInsuranceOption")]
        public string ApplicationIndicateInsuranceOption { get; set; } = string.Empty;
        [JsonProperty("InitFeePaymentOption")]
        public string ApplicationInitFeePaymentOption { get; set; } = string.Empty;
        [JsonProperty("InsuranceCompany")]
        public string ApplicationInsuranceCompany { get; set; } = string.Empty;
        [JsonProperty("InsuranceCoverReason")]
        public string ApplicationInsuranceCoverReason { get; set; } = string.Empty;
        [JsonProperty("InsuranceMonthlyPremium")]
        public string ApplicationInsuranceMonthlyPremium { get; set; } = "0";
        [JsonProperty("InsurancePaymentMethod")]
        public string ApplicationInsurancePaymentMethod { get; set; } = string.Empty;
        [JsonProperty("InsurancePolicyNumber")]
        public string ApplicationInsurancePolicyNumber { get; set; } = string.Empty;
        [JsonProperty("LapaDistance")]
        public string ApplicationLapaDistance { get; set; } = "0";
        [JsonProperty("LapaSize")]
        public string ApplicationLapaSize { get; set; } = "0";
        [JsonProperty("MainBuildingSize")]
        public string ApplicationMainBuildingSize { get; set; } = "0";
        [JsonProperty("ManagingAgentDetails")]
        public string ApplicationManagingAgentDetails { get; set; } = string.Empty;
        [JsonProperty("OutBuildingNo")]
        public string ApplicationOutBuildingNo { get; set; } = "0";
        [JsonProperty("OwnAttorneyReason")]
        public string ApplicationOwnAttorneyReason { get; set; } = string.Empty;
        [JsonProperty("ParkingBayNo")]
        public string ApplicationParkingBayNo { get; set; } = "0";
        [JsonProperty("PaymentHoliday")]
        public string ApplicationPaymentHoliday { get; set; } = string.Empty;
        [JsonProperty("ProcessingRegion")]
        public string ApplicationProcessingRegion { get; set; } = string.Empty;
        [JsonProperty("PropertyBondAccountNo")]
        public string ApplicationPropertyBondAccountNo { get; set; } = string.Empty;
        [JsonProperty("PropertyBondBank")]
        public string ApplicationPropertyBondBank { get; set; } = string.Empty;
        [JsonProperty("PropertyBondBranch")]
        public string ApplicationPropertyBondBranch { get; set; } = string.Empty;
        [JsonProperty("PropertyBondBranchCode")]
        public string ApplicationPropertyBondBranchCode { get; set; } = string.Empty;
        [JsonProperty("PropertyCurrentlyBonded")]
        public string ApplicationPropertyCurrentlyBonded { get; set; } = "false";
        [JsonProperty("PropertyDescription")]
        public string ApplicationPropertyDescription { get; set; } = string.Empty;
        [JsonProperty("PropertyOccupantContact")]
        public string ApplicationPropertyOccupantContact { get; set; } = string.Empty;
        [JsonProperty("SectionalTitleRegister")]
        public string ApplicationSectionalTitleRegister { get; set; } = "false";
        [JsonProperty("SellerCellphone")]
        public string ApplicationSellerCellphone { get; set; } = string.Empty;
        [JsonProperty("SellerName")]
        public string ApplicationSellerName { get; set; } = string.Empty;
        [JsonProperty("SellerTelNo")]
        public string ApplicationSellerTelNo { get; set; } = string.Empty;
        [JsonProperty("StatementSentToIndicator")]
        public string ApplicationStatementSentToIndicator { get; set; } = string.Empty;
        [JsonProperty("TransferAttorney")]
        public string ApplicationTransferAttorney { get; set; } = string.Empty;
        [JsonProperty("TypeOfAssurance")]
        public string ApplicationTypeOfAssurance { get; set; } = string.Empty;
        [JsonProperty("TypeOfGroupScheme")]
        public string ApplicationTypeOfGroupScheme { get; set; } = string.Empty;

        // extras from sbsa
        [JsonProperty("CollateralAmount")]
        public string ApplicationCollateralAmount { get; set; } = "0";
        [JsonProperty("CollateralType")]
        public string ApplicationCollateralType { get; set; } = string.Empty;
        [JsonProperty("ComplexType")]
        public string ApplicationComplexType { get; set; } = string.Empty;
        [JsonProperty("ConsentClause1")]
        public string ApplicationConsentClause1 { get; set; } = "false";
        [JsonProperty("ConsentClause2")]
        public string ApplicationConsentClause2 { get; set; } = "false";
        [JsonProperty("ConsentClause3")]
        public string ApplicationConsentClause3 { get; set; } = "false";
        [JsonProperty("ConsentClause4")]
        public string ApplicationConsentClause4 { get; set; } = "false";
        [JsonProperty("CorrespondenceTitle")]
        public string ApplicationCorrespondenceTitle { get; set; } = string.Empty;
        [JsonProperty("DomicileBranch")]
        public string ApplicationDomicileBranch { get; set; } = string.Empty;
        [JsonProperty("DomicileBranchCode")]
        public string ApplicationDomicileBranchCode { get; set; } = string.Empty;
        [JsonProperty("GarageBayNo")]
        public string ApplicationGarageBayNo { get; set; } = "0";
        [JsonProperty("JumpStartOption")]
        public string ApplicationJumpStartOption { get; set; } = string.Empty;
        [JsonProperty("LoanProtectionPlan")]
        public string ApplicationLoanProtectionPlan { get; set; } = string.Empty;
        [JsonProperty("LoanReason")]
        public string ApplicationLoanReason { get; set; } = string.Empty;
        [JsonProperty("ManagingAgentPhoneCode")]
        public string ApplicationManagingAgentPhoneCode { get; set; } = string.Empty;
        [JsonProperty("ManagingAgentPhoneNo")]
        public string ApplicationManagingAgentPhoneNo { get; set; } = string.Empty;
        [JsonProperty("OriginatorName")]
        public string ApplicationOriginatorName { get; set; } = string.Empty;
        [JsonProperty("OtherLoanAmount")]
        public string ApplicationOtherLoanAmount { get; set; } = "0";
        [JsonProperty("OtherLoanInstallment")]
        public string ApplicationOtherLoanInstallment { get; set; } = "0";
        [JsonProperty("SuretyAmount")]
        public string ApplicationSuretyAmount { get; set; } = "0";
        [JsonProperty("SuretyName")]
        public string ApplicationSuretyName { get; set; } = string.Empty;
        [JsonProperty("SuretyType")]
        public string ApplicationSuretyType { get; set; } = string.Empty;
        [JsonProperty("TypeOfRate")]
        public string ApplicationTypeOfRate { get; set; } = string.Empty;
    }



    public class IncomeItem
    {
        [JsonProperty("IncomeAmount")]
        public string ApplicantIncomeAmount { get; set; } = "0";
        [JsonProperty("IncomeDesc")]
        public string ApplicantIncomeDesc { get; set; } = string.Empty;
        [JsonProperty("IncomeType")]
        public string ApplicantIncomeType { get; set; } = string.Empty;
    }

    public class ExpenditureItem
    {
        [JsonProperty("ExpenditureAmount")]
        public string ApplicantExpenditureAmount { get; set; } = "0";
        [JsonProperty("ExpenditureDesc")]
        public string ApplicantExpenditureDesc { get; set; } = string.Empty;
        [JsonProperty("ExpenditureType")]
        public string ApplicantExpenditureType { get; set; } = string.Empty;
    }

    public class BankAccount
    {
        [JsonProperty("AccountBalance")]
        public string ApplicantAccountBalance { get; set; } = "0";
        [JsonProperty("AccountBranch")]
        public string ApplicantAccountBranch { get; set; } = string.Empty;
        [JsonProperty("AccountBranchCode")]
        public string ApplicantAccountBranchCode { get; set; } = string.Empty;
        [JsonProperty("AccountInstitution")]
        public string ApplicantAccountInstitution { get; set; } = string.Empty;
        [JsonProperty("AccountName")]
        public string ApplicantAccountName { get; set; } = string.Empty;
        [JsonProperty("AccountNumber")]
        public string ApplicantAccountNumber { get; set; } = string.Empty;
        [JsonProperty("AccountType")]
        public string ApplicantAccountType { get; set; } = string.Empty;
        [JsonProperty("IsMainAccount")]
        public string ApplicantIsMainAccount { get; set; } = "false";
    }

    public class AssetItem
    {
        [JsonProperty("AssetAmount")]
        public string ApplicantAssetAmount { get; set; } = "0";
        [JsonProperty("AssetDesc")]
        public string ApplicantAssetDesc { get; set; } = string.Empty;
        [JsonProperty("AssetType")]
        public string ApplicantAssetType { get; set; } = string.Empty;
    }

    public class LiabilityItem
    {
        [JsonProperty("LiabilityAmount")]
        public string ApplicantLiabilityAmount { get; set; } = "0";
        [JsonProperty("LiabilityDesc")]
        public string ApplicantLiabilityDesc { get; set; } = string.Empty;
        [JsonProperty("LiabilityType")]
        public string ApplicantLiabilityType { get; set; } = string.Empty;
    }

    public class AbsaApplicant
    {
        [JsonProperty("CurrentBondAmount")]
        public string ApplicantABSACurrentBondAmount { get; set; } = "0";
        [JsonProperty("CurrentBondToBeCancelled")]
        public string ApplicantABSACurrentBondToBeCancelled { get; set; } = "0";
        [JsonProperty("CurrentRentAmount")]
        public string ApplicantABSACurrentRentAmount { get; set; } = "0";
        [JsonProperty("CurrentRentToBeCancelled")]
        public string ApplicantABSACurrentRentToBeCancelled { get; set; } = "0";
        [JsonProperty("EmploymentSector")]
        public string ApplicantABSAEmploymentSector { get; set; } = string.Empty;
        [JsonProperty("ExecutiveManager")]
        public string ApplicantABSAExecutiveManager { get; set; } = "false";
        [JsonProperty("IdentificationType")]
        public string ApplicantABSAIdentificationType { get; set; } = string.Empty;
        [JsonProperty("LifeInsurance")]
        public string ApplicantABSALifeInsurance { get; set; } = "false";
        [JsonProperty("Occupation")]
        public string ApplicantABSAOccupation { get; set; } = string.Empty;
        [JsonProperty("OtherIdentificationType")]
        public string ApplicantABSAOtherIdentificationType { get; set; } = string.Empty;
        [JsonProperty("PostMatricQualification")]
        public string ApplicantABSAPostMatricQualification { get; set; } = string.Empty;
        [JsonProperty("ResidentialStatus")]
        public string ApplicantABSAResidentialStatus { get; set; } = string.Empty;
        [JsonProperty("SAEmployed")]
        public string ApplicantABSASAEmployed { get; set; } = "false";
        [JsonProperty("StaffMember")]
        public string ApplicantABSAStaffMember { get; set; } = "false";
        [JsonProperty("Will")]
        public string ApplicantABSAWill { get; set; } = "false";
        [JsonProperty("SettleNonABSABondAccount")]
        public string ApplicantSettleNonABSABondAccount { get; set; } = "false";
        [JsonProperty("SpouseDetailsAvailable")]
        public string ApplicantSpouseDetailsAvailable { get; set; } = "false";
        [JsonProperty("SpouseParticipant")]
        public string ApplicantSpouseParticipant { get; set; } = "false";
        [JsonProperty("IsSurety")]
        public string ApplicantABSAIsSurety { get; set; } = "false";
        

    }

    public class FnbApplicant
    {
        [JsonProperty("CityOfBirth")]
        public string ApplicantFNBCityOfBirth { get; set; } = string.Empty;
        [JsonProperty("Client")]
        public string ApplicantFNBClient { get; set; } = "false";
        [JsonProperty("CountryOfCitizenship")]
        public string ApplicantFNBCountryOfCitizenship { get; set; } = string.Empty;
        [JsonProperty("CountryOfMarriage")]
        public string ApplicantFNBCountryOfMarriage { get; set; } = string.Empty;
        [JsonProperty("CountryResideWork")]
        public string ApplicantFNBCountryResideWork { get; set; } = string.Empty;
        [JsonProperty("EmploymentSector")]
        public string ApplicantFNBEmploymentSector { get; set; } = string.Empty;
        [JsonProperty("EmploymentType")]
        public string ApplicantFNBEmploymentType { get; set; } = string.Empty;
        [JsonProperty("ForeignTaxNumber")]
        public string ApplicantFNBForeignTaxNumber { get; set; } = string.Empty;
        [JsonProperty("ForeignTaxReturnId")]
        public string ApplicantFNBForeignTaxReturnId { get; set; } = "false";
        [JsonProperty("HighestQualification")]
        public string ApplicantFNBHighestQualification { get; set; } = string.Empty;
        [JsonProperty("InternationalWorkAddress")]
        public string ApplicantFNBInternationalWorkAddress { get; set; } = "false";
        [JsonProperty("IsFirstRandEmployee")]
        public string ApplicantFNBIsFirstRandEmployee { get; set; } = "false";
        [JsonProperty("IsInternationalAddress")]
        public string ApplicantFNBIsInternationalAddress { get; set; } = "false";
        [JsonProperty("MarketingConsentId")]
        public string ApplicantFNBMarketingConsentId { get; set; } = "false";
        [JsonProperty("PostalAddressCountry")]
        public string ApplicantFNBPostalAddressCountry { get; set; } = string.Empty;
        [JsonProperty("RandEmployeeNumber")]
        public string ApplicantFNBRandEmployeeNumber { get; set; } = string.Empty;
        [JsonProperty("ResidentialAddressCountry")]
        public string ApplicantFNBResidentialAddressCountry { get; set; } = string.Empty;
        [JsonProperty("SourceOfIncome1")]
        public string ApplicantFNBSourceOfIncome1 { get; set; } = string.Empty;
        [JsonProperty("SourceOfIncome2")]
        public string ApplicantFNBSourceOfIncome2 { get; set; } = string.Empty;
        [JsonProperty("SourceOfIncome3")]
        public string ApplicantFNBSourceOfIncome3 { get; set; } = string.Empty;
        [JsonProperty("SourceOfIncome4")]
        public string ApplicantFNBSourceOfIncome4 { get; set; } = string.Empty;
        [JsonProperty("SourceOfIncome5")]
        public string ApplicantFNBSourceOfIncome5 { get; set; } = string.Empty;
        [JsonProperty("TaxPayerInResidentCountry")]
        public string ApplicantFNBTaxPayerInResidentCountry { get; set; } = string.Empty;
        [JsonProperty("TypeOfPermit")]
        public string ApplicantFNBTypeOfPermit { get; set; } = string.Empty;
        [JsonProperty("IsSurety")]
        public string ApplicantFNBIsSurety { get; set; } = "false";
    }

    public class NedbankApplicant
    {
        [JsonProperty("Nationality")]
        public string ApplicantNationality { get; set; } = string.Empty;
        [JsonProperty("Branch")]
        public string ApplicantNedBranch { get; set; } = string.Empty;
        [JsonProperty("EmploymentType")]
        public string ApplicantNedEmploymentType { get; set; } = string.Empty;
        [JsonProperty("MultipleNationalities")]
        public string ApplicantNedMultipleNationalities { get; set; } = "false";
        [JsonProperty("Occupation")]
        public string ApplicantNedOccupation { get; set; } = string.Empty;
        [JsonProperty("SecondaryNationality")]
        public string ApplicantNedSecondaryNationality { get; set; } = string.Empty;
        [JsonProperty("IsSurety")]
        public string ApplicantNEDIsSurety { get; set; } = "false";
        [JsonProperty("AssetItems")]
        public List<AssetItem> ApplicantAssetItems { get; set; }
        [JsonProperty("LiabilityItems")]
        public List<LiabilityItem> ApplicantLiabilityItems { get; set; }
    }

    public class SbsaApplicant
    {
        [JsonProperty("IsAssociatedToOffical")]
        public string ApplicantSBSAIsAssociatedToOffical { get; set; } = "false";
        [JsonProperty("IsPublicOffical")]
        public string ApplicantSBSAIsPublicOffical { get; set; } = "false";
        [JsonProperty("NatureOfRelationship")]
        public string ApplicantSBSANatureOfRelationship { get; set; } = string.Empty;
        [JsonProperty("POFirstName")]
        public string ApplicantSBSAPOFirstName { get; set; } = string.Empty;
        [JsonProperty("POSurname")]
        public string ApplicantSBSAPOSurname { get; set; } = string.Empty;
        [JsonProperty("BondInstitution")]
        public string ApplicantSTDBondInstitution { get; set; } = string.Empty;
        [JsonProperty("CountryPassportIssuedId")]
        public string ApplicantSTDCountryPassportIssuedId { get; set; }
        [JsonProperty("DebitOrderResponsible")]
        public string ApplicantSTDDebitOrderResponsible { get; set; } = "false";
        [JsonProperty("EmployerSuburb")]
        public string ApplicantSTDEmployerSuburb { get; set; } = string.Empty;
        [JsonProperty("EmployerSuburbCode")]
        public string ApplicantSTDEmployerSuburbCode { get; set; } = string.Empty;
        [JsonProperty("EverCitixen")]
        public string ApplicantSTDEverCitixen { get; set; } = string.Empty;
        [JsonProperty("IDXIndicator")]
        public string ApplicantSTDIDXIndicator { get; set; } = string.Empty;
        [JsonProperty("IsSurety")]
        public string ApplicantSTDIsSurety { get; set; } = "false";
        [JsonProperty("MaintenanceIncome")]
        public string ApplicantSTDMaintenanceIncome { get; set; } = "0";
        [JsonProperty("PostalSuburb")]
        public string ApplicantSTDPostalSuburb { get; set; } = string.Empty;
        [JsonProperty("PostalSuburbCode")]
        public string ApplicantSTDPostalSuburbCode { get; set; } = string.Empty;
        [JsonProperty("RentalIncome")]
        public string ApplicantSTDRentalIncome { get; set; } = "0";
        [JsonProperty("ResidentialSuburb")]
        public string ApplicantSTDResidentialSuburb { get; set; } = string.Empty;
        [JsonProperty("ResidentialSuburbCode")]
        public string ApplicantSTDResidentialSuburbCode { get; set; } = string.Empty;
        [JsonProperty("SelfEmployedProfessionalLevel")]
        public string ApplicantSTDSelfEmployedProfessionalLevel { get; set; } = string.Empty;
        [JsonProperty("SellingExistingProperty")]
        public string ApplicantSTDSellingExistingProperty { get; set; } = "false";
        [JsonProperty("SmokerStatus")]
        public string ApplicantSTDSmokerStatus { get; set; } = "false";
        [JsonProperty("SourceOfIncomeAmount")]
        public string ApplicantSTDSourceOfIncomeAmount { get; set; } = "0";
        [JsonProperty("SourceOfIncomeAmount1")]
        public string ApplicantSTDSourceOfIncomeAmount1 { get; set; } = "0";
        [JsonProperty("SourceOfIncomeAmount2")]
        public string ApplicantSTDSourceOfIncomeAmount2 { get; set; } = "0";
        [JsonProperty("TypeOfPermit")]
        public string ApplicantSTDTypeOfPermit { get; set; } = string.Empty;
    }


    public class CommonApplicant
    {
        [JsonProperty("AddressCityWork")]
        public string ApplicantAddressCityWork { get; set; } = string.Empty;
        [JsonProperty("AddressCountryWork")]
        public string ApplicantAddressCountryWork { get; set; } = string.Empty;
        [JsonProperty("AddressLine1Work")]
        public string ApplicantAddressLine1Work { get; set; } = string.Empty;
        [JsonProperty("AddressSince")]
        public string ApplicantAddressSince { get; set; } = string.Empty;
        [JsonProperty("AddressSuburbWork")]
        public string ApplicantAddressSuburbWork { get; set; } = string.Empty;
        [JsonProperty("CanRetrieveStatement")]
        public string ApplicantCanRetrieveStatement { get; set; } = "false";
        [JsonProperty("CanSupplyStatement")]
        public string ApplicantCanSupplyStatement { get; set; } = "false";
        [JsonProperty("Cellphone")]
        public string ApplicantCellphone { get; set; } = string.Empty;
        [JsonProperty("CorrespondenceLanguage")]
        public string ApplicantCorrespondenceLanguage { get; set; } = string.Empty;
        [JsonProperty("CountryOfBirth")]
        public string ApplicantCountryOfBirth { get; set; } = string.Empty;
        [JsonProperty("CountryOfPermResidenceCode")]
        public string ApplicantCountryOfPermResidenceCode { get; set; } = string.Empty;
        [JsonProperty("CountryPassportIssued")]
        public string ApplicantCountryPassportIssued { get; set; }
        [JsonProperty("DateJoinedEmployer")]
        public string ApplicantDateJoinedEmployer { get; set; } = string.Empty;
        [JsonProperty("DateOfBirth")]
        public string ApplicantDateOfBirth { get; set; } = string.Empty;
        [JsonProperty("DateRehabilitated")]
        public string ApplicantDateRehabilitated { get; set; } = string.Empty;
        [JsonProperty("DebtConsolidationAmount")]
        public string ApplicantDebtConsolidationAmount { get; set; } = "0";
        [JsonProperty("DebtCounsellorName")]
        public string ApplicantDebtCounsellorName { get; set; } = string.Empty;
        [JsonProperty("DebtCounsellorNumber")]
        public string ApplicantDebtCounsellorNumber { get; set; } = string.Empty;
        [JsonProperty("DeclaredInsolvent")]
        public string ApplicantDeclaredInsolvent { get; set; } = "false";
        [JsonProperty("EmailAddress")]
        public string ApplicantEmailAddress { get; set; } = string.Empty;
        [JsonProperty("EmployeeNo")]
        public string ApplicantEmployeeNo { get; set; } = string.Empty;
        [JsonProperty("EmployerFaxCode")]
        public string ApplicantEmployerFaxCode { get; set; } = string.Empty;
        [JsonProperty("EmployerFaxNo")]
        public string ApplicantEmployerFaxNo { get; set; } = string.Empty;
        [JsonProperty("EmployerName")]
        public string ApplicantEmployerName { get; set; } = string.Empty;
        [JsonProperty("EmployerTelCode")]
        public string ApplicantEmployerTelCode { get; set; } = string.Empty;
        [JsonProperty("EmployerTelNo")]
        public string ApplicantEmployerTelNo { get; set; } = string.Empty;
        [JsonProperty("EthnicGroup")]
        public string ApplicantEthnicGroup { get; set; } = string.Empty;
        [JsonProperty("FirstName")]
        public string ApplicantFirstName { get; set; } = string.Empty;
        [JsonProperty("ForeignNational")]
        public string ApplicantForeignNational { get; set; } = "false";
        [JsonProperty("Gender")]
        public string ApplicantGender { get; set; } = string.Empty;
        [JsonProperty("HasChequeAccount")]
        public string ApplicantHasChequeAccount { get; set; } = "false";
        [JsonProperty("HasCreditCard")]
        public string ApplicantHasCreditCard { get; set; } = "false";
        [JsonProperty("HomeLanguage")]
        public string ApplicantHomeLanguage { get; set; } = string.Empty;
        [JsonProperty("HomePhone")]
        public string ApplicantHomePhone { get; set; } = string.Empty;
        [JsonProperty("HomePhoneCode")]
        public string ApplicantHomePhoneCode { get; set; } = string.Empty;
        [JsonProperty("IdentificationNo")]
        public string ApplicantIdentificationNo { get; set; } = string.Empty;
        [JsonProperty("IsInternationalHomeNo")]
        public string ApplicantIsInternationalHomeNo { get; set; } = string.Empty;
        [JsonProperty("IsInternationalWorkNo")]
        public string ApplicantIsInternationalWorkNo { get; set; } = string.Empty;
        [JsonProperty("IsUnderDebtReview")]
        public string ApplicantIsUnderDebtReview { get; set; } = "false";
        [JsonProperty("MaritalStatus")]
        public string ApplicantMaritalStatus { get; set; } = string.Empty;
        [JsonProperty("MarriedStatus")]
        public string ApplicantMarriedStatus { get; set; } = string.Empty;
        [JsonProperty("MayDoCreditBureauEnquiry")]
        public string ApplicantMayDoCreditBureauEnquiry { get; set; } = "false";
        [JsonProperty("Nationality")]
        public string ApplicantNationality { get; set; } = string.Empty;
        [JsonProperty("OccupationStatus")]
        public string ApplicantOccupationStatus { get; set; } = string.Empty;
        [JsonProperty("OtherDeductionsDescription")]
        public string ApplicantOtherDeductionsDescription { get; set; } = string.Empty;
        [JsonProperty("PassportNo")]
        public string ApplicantPassportNo { get; set; } = string.Empty;
        [JsonProperty("PermanentResident")]
        public string ApplicantPermanentResident { get; set; } = "false";
        [JsonProperty("PermanentResidentCountry")]
        public string ApplicantPermanentResidentCountry { get; set; } = string.Empty;
        [JsonProperty("PhysicalAddressCity")]
        public string ApplicantPhysicalAddressCity { get; set; } = string.Empty;
        [JsonProperty("PhysicalAddressCode")]
        public string ApplicantPhysicalAddressCode { get; set; } = string.Empty;
        [JsonProperty("PhysicalAddressLine1")]
        public string ApplicantPhysicalAddressLine1 { get; set; } = string.Empty;
        [JsonProperty("PhysicalAddressLine2")]
        public string ApplicantPhysicalAddressLine2 { get; set; } = string.Empty;
        [JsonProperty("PhysicalAddressSuburb")]
        public string ApplicantPhysicalAddressSuburb { get; set; } = string.Empty;
        [JsonProperty("PostalAddressCity")]
        public string ApplicantPostalAddressCity { get; set; } = string.Empty;
        [JsonProperty("PostalAddressCode")]
        public string ApplicantPostalAddressCode { get; set; } = string.Empty;
        [JsonProperty("PostalAddressLine1")]
        public string ApplicantPostalAddressLine1 { get; set; } = string.Empty;
        [JsonProperty("PostalAddressLine2")]
        public string ApplicantPostalAddressLine2 { get; set; } = string.Empty;
        [JsonProperty("PostalAddressSuburb")]
        public string ApplicantPostalAddressSuburb { get; set; } = string.Empty;
        [JsonProperty("PostalCodeWork")]
        public string ApplicantPostalCodeWork { get; set; } = string.Empty;
        [JsonProperty("PreferredContactDelivery")]
        public string ApplicantPreferredContactDelivery { get; set; } = string.Empty;
        [JsonProperty("RightOfRefusalConsent")]
        public string ApplicantRightOfRefusalConsent { get; set; } = "0";
        [JsonProperty("SocialGrant")]
        public string ApplicantSocialGrant { get; set; } = "false";
        [JsonProperty("SourceOfIncome")]
        public string ApplicantSourceOfIncome { get; set; } = string.Empty;
        [JsonProperty("Surname")]
        public string ApplicantSurname { get; set; } = string.Empty;
        [JsonProperty("TempResident")]
        public string ApplicantTempResident { get; set; } = "false";
        [JsonProperty("TempResidentPermitExpiry")]
        public string ApplicantTempResidentPermitExpiry { get; set; } = string.Empty;
        [JsonProperty("TempResidentPermitNo")]
        public string ApplicantTempResidentPermitNo { get; set; } = string.Empty;
        [JsonProperty("Title")]
        public string ApplicantTitle { get; set; } = string.Empty;

        [JsonProperty("IncomeItems")]
        public List<IncomeItem> ApplicantIncomeItems { get; set; }
        [JsonProperty("ExpenditureItems")]
        public List<ExpenditureItem> ApplicantExpenditureItems { get; set; }
        [JsonProperty("BankAccounts")]
        public List<BankAccount> ApplicantBankAccounts { get; set; }

        //extras from fnb
        [JsonProperty("CountryPermitIssued")]
        public string ApplicantCountryPermitIssued { get; set; } = string.Empty;
        [JsonProperty("DatePassportExpires")]
        public string ApplicantDatePassportExpires { get; set; } = string.Empty;
        [JsonProperty("DateWorkContractExpires")]
        public string ApplicantDateWorkContractExpires { get; set; } = string.Empty;
        [JsonProperty("DateWorkContractIssued")]
        public string ApplicantDateWorkContractIssued { get; set; } = string.Empty;
        [JsonProperty("EmployeeStatus")]
        public string ApplicantEmployeeStatus { get; set; } = string.Empty;
        [JsonProperty("EmployerOperatingYears")]
        public string ApplicantEmployerOperatingYears { get; set; } = "0";
        [JsonProperty("FaxCode")]
        public string ApplicantFaxCode { get; set; } = string.Empty;
        [JsonProperty("FaxNo")]
        public string ApplicantFaxNo { get; set; } = string.Empty;
        [JsonProperty("HouseholdSize")]
        public string ApplicantHouseholdSize { get; set; } = "0";
        [JsonProperty("IdentificationType")]
        public string ApplicantIdentificationType { get; set; } = string.Empty;
        [JsonProperty("InsolventDate")]
        public string ApplicantInsolventDate { get; set; } = string.Empty;
        [JsonProperty("Jurisdiction")]
        public string ApplicantJurisdiction { get; set; } = string.Empty;
        [JsonProperty("Jurisdiction1")]
        public string ApplicantJurisdiction1 { get; set; } = string.Empty;
        [JsonProperty("Jurisdiction2")]
        public string ApplicantJurisdiction2 { get; set; } = string.Empty;
        [JsonProperty("Jurisdiction3")]
        public string ApplicantJurisdiction3 { get; set; } = string.Empty;
        [JsonProperty("Jurisdiction4")]
        public string ApplicantJurisdiction4 { get; set; } = string.Empty;
        [JsonProperty("LifeAssuranceOption")]
        public string ApplicantLifeAssuranceOption { get; set; } = string.Empty;
        [JsonProperty("MayBankContactYou")]
        public string ApplicantMayBankContactYou { get; set; } = "false";
        [JsonProperty("NoOfDependents")]
        public string ApplicantNoOfDependents { get; set; } = "0";
        [JsonProperty("Occupation")]
        public string ApplicantOccupation { get; set; } = string.Empty;
        [JsonProperty("OccupationLevel")]
        public string ApplicantOccupationLevel { get; set; } = string.Empty;
        [JsonProperty("PermanentResidentNo")]
        public string ApplicantPermanentResidentNo { get; set; } = string.Empty;
        [JsonProperty("PermitIssueDate")]
        public string ApplicantPermitIssueDate { get; set; } = string.Empty;
        [JsonProperty("PreviousEmployerName")]
        public string ApplicantPreviousEmployerName { get; set; } = string.Empty;
        [JsonProperty("PreviousEmployerPeriod")]
        public string ApplicantPreviousEmployerPeriod { get; set; } = string.Empty;
        [JsonProperty("Rehabilitated")]
        public string ApplicantRehabilitated { get; set; } = "false";
        [JsonProperty("SACitizen")]
        public string ApplicantSACitizen { get; set; } = "false";
        [JsonProperty("TaxIdentificationNumber")]
        public string ApplicantTaxIdentificationNumber { get; set; } = string.Empty;
        [JsonProperty("TaxIdentificationNumber1")]
        public string ApplicantTaxIdentificationNumber1 { get; set; } = string.Empty;
        [JsonProperty("TaxIdentificationNumber2")]
        public string ApplicantTaxIdentificationNumber2 { get; set; } = string.Empty;
        [JsonProperty("TaxIdentificationNumber3")]
        public string ApplicantTaxIdentificationNumber3 { get; set; } = string.Empty;
        [JsonProperty("TaxIdentificationNumber4")]
        public string ApplicantTaxIdentificationNumber4 { get; set; } = string.Empty;
        [JsonProperty("TaxIdentificationReason")]
        public string ApplicantTaxIdentificationReason { get; set; } = string.Empty;
        [JsonProperty("TaxIdentificationReason1")]
        public string ApplicantTaxIdentificationReason1 { get; set; } = string.Empty;
        [JsonProperty("TaxIdentificationReason2")]
        public string ApplicantTaxIdentificationReason2 { get; set; } = string.Empty;
        [JsonProperty("TaxIdentificationReason3")]
        public string ApplicantTaxIdentificationReason3 { get; set; } = string.Empty;
        [JsonProperty("TaxIdentificationReason4")]
        public string ApplicantTaxIdentificationReason4 { get; set; } = string.Empty;
        [JsonProperty("TypeOfIncome")]
        public string ApplicantTypeOfIncome { get; set; } = string.Empty;
        [JsonProperty("WorkPhone")]
        public string ApplicantWorkPhone { get; set; } = string.Empty;
        [JsonProperty("WorkPhoneCode")]
        public string ApplicantWorkPhoneCode { get; set; } = string.Empty;

        // extra from nedbank
        [JsonProperty("DatePassportIssued")]
        public string ApplicantDatePassportIssued { get; set; } = string.Empty;
        [JsonProperty("DisputeWithCreditBureau")]
        public string ApplicantDisputeWithCreditBureau { get; set; } = "false";
        [JsonProperty("EmploymentIndustry")]
        public string ApplicantEmploymentIndustry { get; set; } = string.Empty;
        [JsonProperty("HadJudgement")]
        public string ApplicantHadJudgement { get; set; } = "false";
        [JsonProperty("IncomeTaxNo")]
        public string ApplicantIncomeTaxNo { get; set; } = string.Empty;
        [JsonProperty("IsUnderAdminOrder")]
        public string ApplicantIsUnderAdminOrder { get; set; } = "false";
        [JsonProperty("JobChange")]
        public string ApplicantJobChange { get; set; } = "false";
        [JsonProperty("MassContact")]
        public string ApplicantMassContact { get; set; } = "false";
        [JsonProperty("PostalSameIndicator")]
        public string ApplicantPostalSameIndicator { get; set; } = "false";
        [JsonProperty("RearrangementInPlace")]
        public string ApplicantRearrangementInPlace { get; set; } = "false";
        [JsonProperty("ResidentialStatus")]
        public string ApplicantResidentialStatus { get; set; } = string.Empty;
        [JsonProperty("SelfEmployed")]
        public string ApplicantSelfEmployed { get; set; } = "false";
        [JsonProperty("SourceOfIncomeNone")]
        public string ApplicantSourceOfIncomeNone { get; set; } = string.Empty;
        [JsonProperty("SourceOfIncomeOther")]
        public string ApplicantSourceOfIncomeOther { get; set; } = string.Empty;
        [JsonProperty("WasUnderAdminOrder")]
        public string ApplicantWasUnderAdminOrder { get; set; } = "false";

        // extra from sbsa
        [JsonProperty("BankPackage")]
        public string ApplicantBankPackage { get; set; } = string.Empty;
        [JsonProperty("CompanyRegistrationNo")]
        public string ApplicantCompanyRegistrationNo { get; set; } = string.Empty;
        [JsonProperty("CurrentEmploymentStatus")]
        public string ApplicantCurrentEmploymentStatus { get; set; } = string.Empty;
        [JsonProperty("CurrentMonthlyInstallment")]
        public string ApplicantCurrentMonthlyInstallment { get; set; } = "0";
        [JsonProperty("EmployerAddress")]
        public string ApplicantEmployerAddress { get; set; } = string.Empty;
        [JsonProperty("FrequencyOfSalaryPayments")]
        public string ApplicantFrequencyOfSalaryPayments { get; set; } = string.Empty;
        [JsonProperty("HighestQualification")]
        public string ApplicantHighestQualification { get; set; } = string.Empty;
        [JsonProperty("IncomeMix")]
        public string ApplicantIncomeMix { get; set; } = "0";
        [JsonProperty("Initials")]
        public string ApplicantInitials { get; set; } = string.Empty;
        [JsonProperty("MayBankShareInfo")]
        public string ApplicantMayBankShareInfo { get; set; } = "false";
        [JsonProperty("MayOthersContactYou")]
        public string ApplicantMayOthersContactYou { get; set; } = "false";
        [JsonProperty("MayUseForResearch")]
        public string ApplicantMayUseForResearch { get; set; } = "false";
        [JsonProperty("PermitNumber")]
        public string ApplicantPermitNumber { get; set; } = string.Empty;
        [JsonProperty("RentingProperty")]
        public string ApplicantRentingProperty { get; set; } = "false";
        [JsonProperty("ShareHolderPercentage")]
        public string ApplicantShareHolderPercentage { get; set; } = "0";
        [JsonProperty("SourceOfIncome1")]
        public string ApplicantSourceOfIncome1 { get; set; } = string.Empty;
        [JsonProperty("SourceOfIncome2")]
        public string ApplicantSourceOfIncome2 { get; set; } = string.Empty;
        [JsonProperty("SouthAfricanBank")]
        public string ApplicantSouthAfricanBank { get; set; } = "false";

        [JsonProperty("MaySubsidiariesContactYou")]
        public string ApplicantMaySubsidiariesContactYou { get; set; } = "false";

    }

    public class ApplicantDetails
    {
        public AbsaApplicant Absa { get; set; }
        public FnbApplicant Fnb { get; set; }
        public NedbankApplicant Nedbank { get; set; }
        public SbsaApplicant Sbsa { get; set; }
        public CommonApplicant Common { get; set; }


    }

    public class MainApplicantDetail
    {
        [JsonProperty("ApplicantDetails")]
        public ApplicantDetails ApplicantDetails { get; set; }
        [JsonProperty("SpouseDetails")]
        public ApplicantDetails SpouseDetails { get; set; }
    }
    public class CoApplicantDetail
    {
        [JsonProperty("ApplicantDetails")]
        public ApplicantDetails ApplicantDetails { get; set; }
        [JsonProperty("SpouseDetails")]
        public ApplicantDetails SpouseDetails { get; set; }
    }


}
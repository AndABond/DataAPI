using MortageDataSwitch.Models.SubmitService;
using MortageDataSwitch.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortageDataSwitch.Models
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("SubmitApplication.Request", Namespace = "", IsNullable = false)]
    public class SubmitIncomingApplicationRequest : SubmitApplicationRequest
    {
        [System.Xml.Serialization.XmlElementAttribute("Application.Details")]
        public AllApplicationRequest.SubmitApplicationRequestApplicationDetails ApplicationDetails { get; set; } = null;
        [System.Xml.Serialization.XmlElementAttribute("Application.Applicants")]
        public AllApplicationRequest.SubmitApplicationRequestApplicationApplicants ApplicationApplicants { get; set; } = null;
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("SubmitApplication.Request", Namespace = "", IsNullable = false)]
    public class SubmitAbsaApplicationRequest: SubmitApplicationRequest
    {
        [System.Xml.Serialization.XmlElementAttribute("Application.Details")]
        public AbsaApplicationRequest.SubmitApplicationRequestApplicationDetails ApplicationDetails { get; set; } = null;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Application.Applicants")]
        public AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicants ApplicationApplicants { get; set; } = null;

        public static explicit operator SubmitAbsaApplicationRequest(SubmitIncomingApplicationRequest v)
        {
            SubmitAbsaApplicationRequest request = new SubmitAbsaApplicationRequest();
            request.ServiceHeader = v.ServiceHeader;
            request.ApplicationApplicants = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicants();
            request.ApplicationApplicants.MainApplicantDetails = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetails();
            request.ApplicationDetails = new AbsaApplicationRequest.SubmitApplicationRequestApplicationDetails();
            request.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount[v.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts.Length];
            for(int i=0; i < v.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts.Length; ++i)
            {
                request.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i] = v.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i];
            }
            request.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem[v.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems.Length];
            for (int i = 0; i < v.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems.Length; ++i)
            {
                request.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i] = v.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i];
            }
            request.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem[v.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems.Length];
            for (int i = 0; i < v.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems.Length; ++i)
            {
                request.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i] = v.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i];
            }

            if (v.ApplicationApplicants.CoApplicantDetails != null)
            {
                request.ApplicationApplicants.CoApplicantDetails = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsCoApplicantDetails();

                request.ApplicationApplicants.CoApplicantDetails = v.ApplicationApplicants.CoApplicantDetails;
                if (v.ApplicationApplicants.CoApplicantDetails.ApplicantBankAccounts != null)
                {
                    request.ApplicationApplicants.CoApplicantDetails.ApplicantBankAccounts = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantBankAccount[v.ApplicationApplicants.CoApplicantDetails.ApplicantBankAccounts.Length];
                    for (int i = 0; i < v.ApplicationApplicants.CoApplicantDetails.ApplicantBankAccounts.Length; ++i)
                    {
                        request.ApplicationApplicants.CoApplicantDetails.ApplicantBankAccounts[i] = v.ApplicationApplicants.CoApplicantDetails.ApplicantBankAccounts[i];
                    }
                }
                if (v.ApplicationApplicants.CoApplicantDetails.ApplicantExpenditureItems != null)
                {
                    request.ApplicationApplicants.CoApplicantDetails.ApplicantExpenditureItems = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantExpenditureItem[v.ApplicationApplicants.CoApplicantDetails.ApplicantExpenditureItems.Length];
                    for (int i = 0; i < v.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems.Length; ++i)
                    {
                        request.ApplicationApplicants.CoApplicantDetails.ApplicantExpenditureItems[i] = v.ApplicationApplicants.CoApplicantDetails.ApplicantExpenditureItems[i];
                    }
                }

                if (v.ApplicationApplicants.CoApplicantDetails.ApplicantIncomeItems != null)
                {
                    request.ApplicationApplicants.CoApplicantDetails.ApplicantIncomeItems = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantIncomeItem[v.ApplicationApplicants.CoApplicantDetails.ApplicantIncomeItems.Length];
                    for (int i = 0; i < v.ApplicationApplicants.CoApplicantDetails.ApplicantIncomeItems.Length; ++i)
                    {
                        request.ApplicationApplicants.CoApplicantDetails.ApplicantIncomeItems[i] = v.ApplicationApplicants.CoApplicantDetails.ApplicantIncomeItems[i];
                    }

                }

                if (v.ApplicationApplicants.CoApplicantDetails.ApplicantSpouseDetails != null)
                {
                    request.ApplicationApplicants.CoApplicantDetails.ApplicantSpouseDetails = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetails();
                    request.ApplicationApplicants.CoApplicantDetails.ApplicantSpouseDetails = v.ApplicationApplicants.CoApplicantDetails.ApplicantSpouseDetails;

                }
            }
            request.ApplicationApplicants.MainApplicantDetails.ApplicantABSACurrentBondAmount = v.ApplicationApplicants.MainApplicantDetails.ApplicantABSACurrentBondAmount;
            request.ApplicationApplicants.MainApplicantDetails.ApplicantABSACurrentBondToBeCancelled = v.ApplicationApplicants.MainApplicantDetails.ApplicantABSACurrentBondToBeCancelled;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantABSACurrentRentAmount = v.ApplicationApplicants.MainApplicantDetails.ApplicantABSACurrentRentAmount;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantABSACurrentRentToBeCancelled = v.ApplicationApplicants.MainApplicantDetails.ApplicantABSACurrentRentToBeCancelled;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantABSAEmploymentSector = v.ApplicationApplicants.MainApplicantDetails.ApplicantABSAEmploymentSector;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantABSAExecutiveManager = v.ApplicationApplicants.MainApplicantDetails.ApplicantABSAExecutiveManager;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantABSAIdentificationType = v.ApplicationApplicants.MainApplicantDetails.ApplicantABSAIdentificationType;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantABSALifeInsurance = v.ApplicationApplicants.MainApplicantDetails.ApplicantABSALifeInsurance;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantABSAOccupation = v.ApplicationApplicants.MainApplicantDetails.ApplicantABSAOccupation;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantABSAOtherIdentificationType = v.ApplicationApplicants.MainApplicantDetails.ApplicantABSAOtherIdentificationType;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantABSAPostMatricQualification = v.ApplicationApplicants.MainApplicantDetails.ApplicantABSAPostMatricQualification;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantABSAResidentialStatus = v.ApplicationApplicants.MainApplicantDetails.ApplicantABSAResidentialStatus;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantABSASAEmployed = v.ApplicationApplicants.MainApplicantDetails.ApplicantABSASAEmployed;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantABSAStaffMember = v.ApplicationApplicants.MainApplicantDetails.ApplicantABSAStaffMember;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantABSAWill = v.ApplicationApplicants.MainApplicantDetails.ApplicantABSAWill;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantAddressCityWork = v.ApplicationApplicants.MainApplicantDetails.ApplicantAddressCityWork;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantAddressCountryWork = v.ApplicationApplicants.MainApplicantDetails.ApplicantAddressCountryWork;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantAddressLine1Work = v.ApplicationApplicants.MainApplicantDetails.ApplicantAddressLine1Work;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantAddressSince = v.ApplicationApplicants.MainApplicantDetails.ApplicantAddressSince;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantAddressSuburbWork = v.ApplicationApplicants.MainApplicantDetails.ApplicantAddressSuburbWork;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCanRetrieveStatement = v.ApplicationApplicants.MainApplicantDetails.ApplicantCanRetrieveStatement;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCanSupplyStatement = v.ApplicationApplicants.MainApplicantDetails.ApplicantCanSupplyStatement;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCellphone = v.ApplicationApplicants.MainApplicantDetails.ApplicantCellphone;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCorrespondenceLanguage = v.ApplicationApplicants.MainApplicantDetails.ApplicantCorrespondenceLanguage;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCountryOfBirth = v.ApplicationApplicants.MainApplicantDetails.ApplicantCountryOfBirth;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCountryOfPermResidenceCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantCountryOfPermResidenceCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCountryPassportIssued = v.ApplicationApplicants.MainApplicantDetails.ApplicantCountryPassportIssued;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDateJoinedEmployer = v.ApplicationApplicants.MainApplicantDetails.ApplicantDateJoinedEmployer;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDateOfBirth = v.ApplicationApplicants.MainApplicantDetails.ApplicantDateOfBirth;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDateRehabilitated = v.ApplicationApplicants.MainApplicantDetails.ApplicantDateRehabilitated;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDebtConsolidationAmount = v.ApplicationApplicants.MainApplicantDetails.ApplicantDebtConsolidationAmount;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDebtCounsellorName = v.ApplicationApplicants.MainApplicantDetails.ApplicantDebtCounsellorName;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDebtCounsellorNumber = v.ApplicationApplicants.MainApplicantDetails.ApplicantDebtCounsellorNumber;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDeclaredInsolvent = v.ApplicationApplicants.MainApplicantDetails.ApplicantDeclaredInsolvent;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmailAddress = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmailAddress;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployeeNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployeeNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerFaxCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerFaxCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerFaxNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerFaxNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerName = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerName;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerTelCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerTelCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerTelNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerTelNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEthnicGroup = v.ApplicationApplicants.MainApplicantDetails.ApplicantEthnicGroup;

            //request.ApplicationApplicants.MainApplicantDetails.ApplicantExistingHomeLoanAccountBalance = v.ApplicationApplicants.MainApplicantDetails.ApplicantExistingHomeLoanAccountBalance;

            //request.ApplicationApplicants.MainApplicantDetails.ApplicantExistingHomeLoanInstitution = v.ApplicationApplicants.MainApplicantDetails.ApplicantExistingHomeLoanInstitution;

            //request.ApplicationApplicants.MainApplicantDetails.ApplicantExistingHomeLoanIsSettlingHomeLoan = v.ApplicationApplicants.MainApplicantDetails.ApplicantExistingHomeLoanIsSettlingHomeLoan;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFirstName = v.ApplicationApplicants.MainApplicantDetails.ApplicantFirstName;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantForeignNational = v.ApplicationApplicants.MainApplicantDetails.ApplicantForeignNational;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantGender = v.ApplicationApplicants.MainApplicantDetails.ApplicantGender;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantHasChequeAccount = v.ApplicationApplicants.MainApplicantDetails.ApplicantHasChequeAccount;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantHasCreditCard = v.ApplicationApplicants.MainApplicantDetails.ApplicantHasCreditCard;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantHomeLanguage = v.ApplicationApplicants.MainApplicantDetails.ApplicantHomeLanguage;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantHomePhone = v.ApplicationApplicants.MainApplicantDetails.ApplicantHomePhone;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantHomePhoneCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantHomePhoneCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantIdentificationNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantIdentificationNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantIsInternationalHomeNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantIsInternationalHomeNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantIsInternationalWorkNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantIsInternationalWorkNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantIsUnderDebtReview = v.ApplicationApplicants.MainApplicantDetails.ApplicantIsUnderDebtReview;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMaritalStatus = v.ApplicationApplicants.MainApplicantDetails.ApplicantMaritalStatus;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMarriedStatus = v.ApplicationApplicants.MainApplicantDetails.ApplicantMarriedStatus;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMayDoCreditBureauEnquiry = v.ApplicationApplicants.MainApplicantDetails.ApplicantMayDoCreditBureauEnquiry;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantNationality = v.ApplicationApplicants.MainApplicantDetails.ApplicantNationality;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantOccupationStatus = v.ApplicationApplicants.MainApplicantDetails.ApplicantOccupationStatus;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantOtherDeductionsDescription = v.ApplicationApplicants.MainApplicantDetails.ApplicantOtherDeductionsDescription;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPassportNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantPassportNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPermanentResident = v.ApplicationApplicants.MainApplicantDetails.ApplicantPermanentResident;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPermanentResidentCountry = v.ApplicationApplicants.MainApplicantDetails.ApplicantPermanentResidentCountry;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressCity = v.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressCity;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressLine1 = v.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressLine1;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressLine2 = v.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressLine2;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressSuburb = v.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressSuburb;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressCity = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressCity;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressLine1 = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressLine1;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressLine2 = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressLine2;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressSuburb = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressSuburb;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalCodeWork = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalCodeWork;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPreferredContactDelivery = v.ApplicationApplicants.MainApplicantDetails.ApplicantPreferredContactDelivery;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantRightOfRefusalConsent = v.ApplicationApplicants.MainApplicantDetails.ApplicantRightOfRefusalConsent;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSettleNonABSABondAccount = v.ApplicationApplicants.MainApplicantDetails.ApplicantSettleNonABSABondAccount;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSocialGrant = v.ApplicationApplicants.MainApplicantDetails.ApplicantSocialGrant;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSourceOfIncome = v.ApplicationApplicants.MainApplicantDetails.ApplicantSourceOfIncome;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSpouseDetailsAvailable = v.ApplicationApplicants.MainApplicantDetails.ApplicantSpouseDetailsAvailable;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSpouseParticipant = v.ApplicationApplicants.MainApplicantDetails.ApplicantSpouseParticipant;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSurname = v.ApplicationApplicants.MainApplicantDetails.ApplicantSurname;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTempResident = v.ApplicationApplicants.MainApplicantDetails.ApplicantTempResident;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTempResidentPermitExpiry = v.ApplicationApplicants.MainApplicantDetails.ApplicantTempResidentPermitExpiry;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTempResidentPermitNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantTempResidentPermitNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTitle = v.ApplicationApplicants.MainApplicantDetails.ApplicantTitle;

            request.ApplicationDetails.ApplicaionABSAIsPrimaryResident = v.ApplicationDetails.ApplicaionABSAIsPrimaryResident;

            request.ApplicationDetails.ApplicationABSABondAttorney = v.ApplicationDetails.ApplicationABSABondAttorney;

            request.ApplicationDetails.ApplicationABSAComplexName = v.ApplicationDetails.ApplicationABSAComplexName;

            request.ApplicationDetails.ApplicationABSAFamilySpringboard = v.ApplicationDetails.ApplicationABSAFamilySpringboard;

            request.ApplicationDetails.ApplicationABSAFurtherLoanAccountNumber = v.ApplicationDetails.ApplicationABSAFurtherLoanAccountNumber;

            request.ApplicationDetails.ApplicationABSAFurtherLoanAmount = v.ApplicationDetails.ApplicationABSAFurtherLoanAmount;

            request.ApplicationDetails.ApplicationABSAIsNewDevelopment = v.ApplicationDetails.ApplicationABSAIsNewDevelopment;

            request.ApplicationDetails.ApplicationABSALoyaltyHomeLoan = v.ApplicationDetails.ApplicationABSALoyaltyHomeLoan;

            request.ApplicationDetails.ApplicationABSAMyHome = v.ApplicationDetails.ApplicationABSAMyHome;

            request.ApplicationDetails.ApplicationABSANewDevelopmentRefNum = v.ApplicationDetails.ApplicationABSANewDevelopmentRefNum;

            request.ApplicationDetails.ApplicationABSANotificationCellPhoneNumber = v.ApplicationDetails.ApplicationABSANotificationCellPhoneNumber;

            request.ApplicationDetails.ApplicationABSANotificationEmailAddress = v.ApplicationDetails.ApplicationABSANotificationEmailAddress;

            request.ApplicationDetails.ApplicationABSANotificationMethodTypeId = v.ApplicationDetails.ApplicationABSANotificationMethodTypeId;

            request.ApplicationDetails.ApplicationABSAPassword = v.ApplicationDetails.ApplicationABSAPassword;

            request.ApplicationDetails.ApplicationABSAPReviousApplicationNumber = v.ApplicationDetails.ApplicationABSAPReviousApplicationNumber;

            request.ApplicationDetails.ApplicationABSAPropertyType = v.ApplicationDetails.ApplicationABSAPropertyType;

            request.ApplicationDetails.ApplicationABSAPurposeOfApplication = v.ApplicationDetails.ApplicationABSAPurposeOfApplication;

            request.ApplicationDetails.ApplicationABSAReApplication = v.ApplicationDetails.ApplicationABSAReApplication;

            request.ApplicationDetails.ApplicationABSASubClassification = v.ApplicationDetails.ApplicationABSASubClassification;

            request.ApplicationDetails.ApplicationABSATransferAttorney = v.ApplicationDetails.ApplicationABSATransferAttorney;

            request.ApplicationDetails.ApplicationABSATransferAttorneyCode = v.ApplicationDetails.ApplicationABSATransferAttorneyCode;

            request.ApplicationDetails.ApplicationABSATypeOfApplication = v.ApplicationDetails.ApplicationABSATypeOfApplication;

            request.ApplicationDetails.ApplicationABSAVendorDescription = v.ApplicationDetails.ApplicationABSAVendorDescription;

            request.ApplicationDetails.ApplicationAgencyInvolved = v.ApplicationDetails.ApplicationAgencyInvolved;

            request.ApplicationDetails.ApplicationAgencyNotifyEmailAddress = v.ApplicationDetails.ApplicationAgencyNotifyEmailAddress;

            request.ApplicationDetails.ApplicationAgencyNotifyOption = v.ApplicationDetails.ApplicationAgencyNotifyOption;

            request.ApplicationDetails.ApplicationAgentName = v.ApplicationDetails.ApplicationAgentName;

            request.ApplicationDetails.ApplicationAIPBanks = v.ApplicationDetails.ApplicationAIPBanks;

            request.ApplicationDetails.ApplicationAltPropertyContact = v.ApplicationDetails.ApplicationAltPropertyContact;

            request.ApplicationDetails.ApplicationAmountOfGuarantee = v.ApplicationDetails.ApplicationAmountOfGuarantee;

            request.ApplicationDetails.ApplicationApplicationType = v.ApplicationDetails.ApplicationApplicationType;

            request.ApplicationDetails.ApplicationBondAmountToBeRegistered = v.ApplicationDetails.ApplicationBondAmountToBeRegistered;

            request.ApplicationDetails.ApplicationBondInstitution = v.ApplicationDetails.ApplicationBondInstitution;

            request.ApplicationDetails.ApplicationBondRegistrationLegalCosts = v.ApplicationDetails.ApplicationBondRegistrationLegalCosts;

            request.ApplicationDetails.ApplicationCampaignRefNumber = v.ApplicationDetails.ApplicationCampaignRefNumber;

            request.ApplicationDetails.ApplicationCashDeposit = v.ApplicationDetails.ApplicationCashDeposit;

            request.ApplicationDetails.ApplicationCellNumberEstateAgency = v.ApplicationDetails.ApplicationCellNumberEstateAgency;

            request.ApplicationDetails.ApplicationConsultantEmailAddress = v.ApplicationDetails.ApplicationConsultantEmailAddress;

            request.ApplicationDetails.ApplicationCurrentBondBalance = v.ApplicationDetails.ApplicationCurrentBondBalance;

            request.ApplicationDetails.ApplicationDebtConsolidationOption = v.ApplicationDetails.ApplicationDebtConsolidationOption;

            request.ApplicationDetails.ApplicationDeclinedBanks = v.ApplicationDetails.ApplicationDeclinedBanks;

            request.ApplicationDetails.ApplicationEmployerHousingScheme = v.ApplicationDetails.ApplicationEmployerHousingScheme;

            request.ApplicationDetails.ApplicationEstateAgency = v.ApplicationDetails.ApplicationEstateAgency;

            request.ApplicationDetails.ApplicationExistingHomeLoan = v.ApplicationDetails.ApplicationExistingHomeLoan;

            request.ApplicationDetails.ApplicationFirstPropertyPurchase = v.ApplicationDetails.ApplicationFirstPropertyPurchase;

            request.ApplicationDetails.ApplicationFixedRateTerm = v.ApplicationDetails.ApplicationFixedRateTerm;

            request.ApplicationDetails.ApplicationFlexiReserveFurtherOption = v.ApplicationDetails.ApplicationFlexiReserveFurtherOption;

            request.ApplicationDetails.ApplicationFlexiReserveOption = v.ApplicationDetails.ApplicationFlexiReserveOption;

            request.ApplicationDetails.ApplicationGovernmentSubsidy = v.ApplicationDetails.ApplicationGovernmentSubsidy;

            request.ApplicationDetails.ApplicationInsuranceQuoteRequired = v.ApplicationDetails.ApplicationInsuranceQuoteRequired;

            request.ApplicationDetails.ApplicationIsCampaign = v.ApplicationDetails.ApplicationIsCampaign;

            request.ApplicationDetails.ApplicationIsDebtConsolidation = v.ApplicationDetails.ApplicationIsDebtConsolidation;

            request.ApplicationDetails.ApplicationLapa = v.ApplicationDetails.ApplicationLapa;

            request.ApplicationDetails.ApplicationLoanAmountRequired = v.ApplicationDetails.ApplicationLoanAmountRequired;

            request.ApplicationDetails.ApplicationLoanType = v.ApplicationDetails.ApplicationLoanType;

            request.ApplicationDetails.ApplicationLoanTypeId = v.ApplicationDetails.ApplicationLoanTypeId;

            request.ApplicationDetails.ApplicationMultiPlanFacility = v.ApplicationDetails.ApplicationMultiPlanFacility;

            request.ApplicationDetails.ApplicationMultiPlanLoanAmount1 = v.ApplicationDetails.ApplicationMultiPlanLoanAmount1;

            request.ApplicationDetails.ApplicationMultiPlanLoanAmount2 = v.ApplicationDetails.ApplicationMultiPlanLoanAmount2;

            request.ApplicationDetails.ApplicationMultiPlanLoanTerm1 = v.ApplicationDetails.ApplicationMultiPlanLoanTerm1;

            request.ApplicationDetails.ApplicationMultiPlanLoanTerm2 = v.ApplicationDetails.ApplicationMultiPlanLoanTerm2;

            request.ApplicationDetails.ApplicationMultiPlanPurpose1 = v.ApplicationDetails.ApplicationMultiPlanPurpose1;

            request.ApplicationDetails.ApplicationMultiPlanPurpose2 = v.ApplicationDetails.ApplicationMultiPlanPurpose2;

            request.ApplicationDetails.ApplicationNegotiateFixedRate = v.ApplicationDetails.ApplicationNegotiateFixedRate;

            request.ApplicationDetails.ApplicationNetwork = v.ApplicationDetails.ApplicationNetwork;

            request.ApplicationDetails.ApplicationNoOfMultiPlanAccounts = v.ApplicationDetails.ApplicationNoOfMultiPlanAccounts;

            request.ApplicationDetails.ApplicationOriginatorInvolved = v.ApplicationDetails.ApplicationOriginatorInvolved;

            request.ApplicationDetails.ApplicationOriginatorNotifyCellphone = v.ApplicationDetails.ApplicationOriginatorNotifyCellphone;

            request.ApplicationDetails.ApplicationOriginatorNotifyOption = v.ApplicationDetails.ApplicationOriginatorNotifyOption;

            request.ApplicationDetails.ApplicationOriginatorNotifyPhoneCode = v.ApplicationDetails.ApplicationOriginatorNotifyPhoneCode;

            request.ApplicationDetails.ApplicationOriginatorNotifyPhoneNo = v.ApplicationDetails.ApplicationOriginatorNotifyPhoneNo;

            request.ApplicationDetails.ApplicationOtherGuaranteeAmount = v.ApplicationDetails.ApplicationOtherGuaranteeAmount;

            request.ApplicationDetails.ApplicationPhoneDialCodeEstateAgency = v.ApplicationDetails.ApplicationPhoneDialCodeEstateAgency;

            request.ApplicationDetails.ApplicationPhoneNumberEstateAgency = v.ApplicationDetails.ApplicationPhoneNumberEstateAgency;

            request.ApplicationDetails.ApplicationPortionNo = v.ApplicationDetails.ApplicationPortionNo;

            request.ApplicationDetails.ApplicationPreferredABSABranch = v.ApplicationDetails.ApplicationPreferredABSABranch;

            request.ApplicationDetails.ApplicationPreferredABSABranchCode = v.ApplicationDetails.ApplicationPreferredABSABranchCode;

            request.ApplicationDetails.ApplicationPropertyAddressCity = v.ApplicationDetails.ApplicationPropertyAddressCity;

            request.ApplicationDetails.ApplicationPropertyAddressSuburb = v.ApplicationDetails.ApplicationPropertyAddressSuburb;

            request.ApplicationDetails.ApplicationPropertyContactCellphone = v.ApplicationDetails.ApplicationPropertyContactCellphone;

            request.ApplicationDetails.ApplicationPropertyContactName = v.ApplicationDetails.ApplicationPropertyContactName;

            request.ApplicationDetails.ApplicationPropertyContactTelCode = v.ApplicationDetails.ApplicationPropertyContactTelCode;

            request.ApplicationDetails.ApplicationPropertyContactTelNo = v.ApplicationDetails.ApplicationPropertyContactTelNo;

            request.ApplicationDetails.ApplicationPropertyMarketValue = v.ApplicationDetails.ApplicationPropertyMarketValue;

            request.ApplicationDetails.ApplicationPropertyOccupiedBy = v.ApplicationDetails.ApplicationPropertyOccupiedBy;

            request.ApplicationDetails.ApplicationPropertyPurchaseDate = v.ApplicationDetails.ApplicationPropertyPurchaseDate;

            request.ApplicationDetails.ApplicationPropertyPurchasePrice = v.ApplicationDetails.ApplicationPropertyPurchasePrice;

            request.ApplicationDetails.ApplicationPropertyRoofConstruction = v.ApplicationDetails.ApplicationPropertyRoofConstruction;

            request.ApplicationDetails.ApplicationPropertyStreetName = v.ApplicationDetails.ApplicationPropertyStreetName;

            request.ApplicationDetails.ApplicationPropertyStreetNo = v.ApplicationDetails.ApplicationPropertyStreetNo;

            request.ApplicationDetails.ApplicationPropertyTownship = v.ApplicationDetails.ApplicationPropertyTownship;

            request.ApplicationDetails.ApplicationPropertyWallConstruction = v.ApplicationDetails.ApplicationPropertyWallConstruction;

            request.ApplicationDetails.ApplicationRepaymentDay = v.ApplicationDetails.ApplicationRepaymentDay;

            request.ApplicationDetails.ApplicationSectionalTitleFlatNo = v.ApplicationDetails.ApplicationSectionalTitleFlatNo;

            request.ApplicationDetails.ApplicationSectionalTitleUnitNo = v.ApplicationDetails.ApplicationSectionalTitleUnitNo;

            request.ApplicationDetails.ApplicationSellerIDNo = v.ApplicationDetails.ApplicationSellerIDNo;

            request.ApplicationDetails.ApplicationSellerIdType = v.ApplicationDetails.ApplicationSellerIdType;

            request.ApplicationDetails.ApplicationSettleAbsaMortgageLoan = v.ApplicationDetails.ApplicationSettleAbsaMortgageLoan;

            request.ApplicationDetails.ApplicationSignLegalDocsProvince = v.ApplicationDetails.ApplicationSignLegalDocsProvince;

            request.ApplicationDetails.ApplicationSignLegalDocsRegion = v.ApplicationDetails.ApplicationSignLegalDocsRegion;

            request.ApplicationDetails.ApplicationSingleHousehold = v.ApplicationDetails.ApplicationSingleHousehold;

            request.ApplicationDetails.ApplicationSourceOfFunds = v.ApplicationDetails.ApplicationSourceOfFunds;

            request.ApplicationDetails.ApplicationSourceOfFunds1 = v.ApplicationDetails.ApplicationSourceOfFunds1;

            request.ApplicationDetails.ApplicationSourceOfFunds2 = v.ApplicationDetails.ApplicationSourceOfFunds2;

            request.ApplicationDetails.ApplicationSourceOfFunds3 = v.ApplicationDetails.ApplicationSourceOfFunds3;

            request.ApplicationDetails.ApplicationSourceOfFunds4 = v.ApplicationDetails.ApplicationSourceOfFunds4;

            request.ApplicationDetails.ApplicationStandErfNo = v.ApplicationDetails.ApplicationStandErfNo;

            request.ApplicationDetails.ApplicationSubmittingBanks = v.ApplicationDetails.ApplicationSubmittingBanks;

            request.ApplicationDetails.ApplicationSuretyshipOffered = v.ApplicationDetails.ApplicationSuretyshipOffered;

            request.ApplicationDetails.ApplicationTermOfLoan = v.ApplicationDetails.ApplicationTermOfLoan;

            request.ApplicationDetails.ApplicationTransferAttorneyPhoneNo = v.ApplicationDetails.ApplicationTransferAttorneyPhoneNo;

            request.ApplicationDetails.ApplicationTypeOfInterest = v.ApplicationDetails.ApplicationTypeOfInterest;


            return request;
        }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("SubmitApplication.Request", Namespace = "", IsNullable = false)]
    public class SubmitFnbApplicationRequest : SubmitApplicationRequest
    {
        [System.Xml.Serialization.XmlElementAttribute("Application.Details")]
        public FnbApplicationRequest.SubmitApplicationRequestApplicationDetails ApplicationDetails { get; set; } = null;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Application.Applicants")]
        public FnbApplicationRequest.SubmitApplicationRequestApplicationApplicants ApplicationApplicants { get; set; } = null;


        public static explicit operator SubmitFnbApplicationRequest(SubmitIncomingApplicationRequest v)
        {
            SubmitFnbApplicationRequest request = new SubmitFnbApplicationRequest();
            request.ServiceHeader = v.ServiceHeader;
            request.ApplicationApplicants = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicants();
            request.ApplicationApplicants.MainApplicantDetails = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetails();
            request.ApplicationDetails = new FnbApplicationRequest.SubmitApplicationRequestApplicationDetails();
            request.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount[v.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts.Length];
            for (int i = 0; i < v.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts.Length; ++i)
            {
                request.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i] = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount();
                ObjectMappingTools.TransferObject(v.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i], request.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i]);
               
            }
            
            request.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem[v.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems.Length];
            for (int i = 0; i < v.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems.Length; ++i)
            {
                request.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i] = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem();
                ObjectMappingTools.TransferObject(v.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i], request.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i]);
                
            }
            request.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem[v.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems.Length];
            for (int i = 0; i < v.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems.Length; ++i)
            {
                request.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i] = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem();
                ObjectMappingTools.TransferObject(v.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i], request.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i]);
                
            }


            if (v.ApplicationApplicants.CoApplicantDetails != null)
            {
                request.ApplicationApplicants.CoApplicantDetails = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsCoApplicantDetails();
                ObjectMappingTools.TransferObject(v.ApplicationApplicants.CoApplicantDetails, request.ApplicationApplicants.CoApplicantDetails);

            }

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCellphone = v.ApplicationApplicants.MainApplicantDetails.ApplicantCellphone;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCorrespondenceLanguage = v.ApplicationApplicants.MainApplicantDetails.ApplicantCorrespondenceLanguage;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCountryOfBirth = v.ApplicationApplicants.MainApplicantDetails.ApplicantCountryOfBirth;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCountryPermitIssued = v.ApplicationApplicants.MainApplicantDetails.ApplicantCountryPermitIssued;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDateJoinedEmployer = v.ApplicationApplicants.MainApplicantDetails.ApplicantDateJoinedEmployer;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDateOfBirth = v.ApplicationApplicants.MainApplicantDetails.ApplicantDateOfBirth;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDatePassportExpires = v.ApplicationApplicants.MainApplicantDetails.ApplicantDatePassportExpires;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDateRehabilitated = v.ApplicationApplicants.MainApplicantDetails.ApplicantDateRehabilitated;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDateWorkContractExpires = v.ApplicationApplicants.MainApplicantDetails.ApplicantDateWorkContractExpires;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDateWorkContractIssued = v.ApplicationApplicants.MainApplicantDetails.ApplicantDateWorkContractIssued;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDeclaredInsolvent = v.ApplicationApplicants.MainApplicantDetails.ApplicantDeclaredInsolvent;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmailAddress = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmailAddress;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployeeStatus = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployeeStatus;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerName = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerName;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerOperatingYears = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerOperatingYears;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEthnicGroup = v.ApplicationApplicants.MainApplicantDetails.ApplicantEthnicGroup;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFaxCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantFaxCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFaxNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantFaxNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFirstName = v.ApplicationApplicants.MainApplicantDetails.ApplicantFirstName;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBCityOfBirth = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBCityOfBirth;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBClient = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBClient;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBCountryOfCitizenship = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBCountryOfCitizenship;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBCountryOfMarriage = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBCountryOfMarriage;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBCountryResideWork = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBCountryResideWork;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBEmploymentSector = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBEmploymentSector;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBEmploymentType = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBEmploymentType;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBForeignTaxNumber = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBForeignTaxNumber;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBForeignTaxReturnId = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBForeignTaxReturnId;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBHighestQualification = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBHighestQualification;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBInternationalWorkAddress = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBInternationalWorkAddress;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBIsFirstRandEmployee = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBIsFirstRandEmployee;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBIsInternationalAddress = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBIsInternationalAddress;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBMarketingConsentId = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBMarketingConsentId;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBPostalAddressCountry = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBPostalAddressCountry;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBRandEmployeeNumber = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBRandEmployeeNumber;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBResidentialAddressCountry = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBResidentialAddressCountry;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBSourceOfIncome1 = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBSourceOfIncome1;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBSourceOfIncome2 = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBSourceOfIncome2;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBSourceOfIncome3 = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBSourceOfIncome3;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBSourceOfIncome4 = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBSourceOfIncome4;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBSourceOfIncome5 = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBSourceOfIncome5;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBTaxPayerInResidentCountry = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBTaxPayerInResidentCountry;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFNBTypeOfPermit = v.ApplicationApplicants.MainApplicantDetails.ApplicantFNBTypeOfPermit;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantGender = v.ApplicationApplicants.MainApplicantDetails.ApplicantGender;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantHomePhone = v.ApplicationApplicants.MainApplicantDetails.ApplicantHomePhone;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantHomePhoneCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantHomePhoneCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantHouseholdSize = v.ApplicationApplicants.MainApplicantDetails.ApplicantHouseholdSize;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantIdentificationNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantIdentificationNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantIdentificationType = v.ApplicationApplicants.MainApplicantDetails.ApplicantIdentificationType;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantInsolventDate = v.ApplicationApplicants.MainApplicantDetails.ApplicantInsolventDate;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantJurisdiction = v.ApplicationApplicants.MainApplicantDetails.ApplicantJurisdiction;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantJurisdiction1 = v.ApplicationApplicants.MainApplicantDetails.ApplicantJurisdiction1;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantJurisdiction2 = v.ApplicationApplicants.MainApplicantDetails.ApplicantJurisdiction2;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantJurisdiction3 = v.ApplicationApplicants.MainApplicantDetails.ApplicantJurisdiction3;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantJurisdiction4 = v.ApplicationApplicants.MainApplicantDetails.ApplicantJurisdiction4;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantLifeAssuranceOption = v.ApplicationApplicants.MainApplicantDetails.ApplicantLifeAssuranceOption;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMaritalStatus = v.ApplicationApplicants.MainApplicantDetails.ApplicantMaritalStatus;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMarriedStatus = v.ApplicationApplicants.MainApplicantDetails.ApplicantMarriedStatus;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMayBankContactYou = v.ApplicationApplicants.MainApplicantDetails.ApplicantMayBankContactYou;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMayDoCreditBureauEnquiry = v.ApplicationApplicants.MainApplicantDetails.ApplicantMayDoCreditBureauEnquiry;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantNoOfDependents = v.ApplicationApplicants.MainApplicantDetails.ApplicantNoOfDependents;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantOccupation = v.ApplicationApplicants.MainApplicantDetails.ApplicantOccupation;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantOccupationLevel = v.ApplicationApplicants.MainApplicantDetails.ApplicantOccupationLevel;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPassportNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantPassportNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPermanentResident = v.ApplicationApplicants.MainApplicantDetails.ApplicantPermanentResident;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPermanentResidentCountry = v.ApplicationApplicants.MainApplicantDetails.ApplicantPermanentResidentCountry;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPermanentResidentNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantPermanentResidentNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPermitIssueDate = v.ApplicationApplicants.MainApplicantDetails.ApplicantPermitIssueDate;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressCity = v.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressCity;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressLine1 = v.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressLine1;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressLine2 = v.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressLine2;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressSuburb = v.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressSuburb;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressCity = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressCity;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressLine1 = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressLine1;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressLine2 = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressLine2;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressSuburb = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressSuburb;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPreferredContactDelivery = v.ApplicationApplicants.MainApplicantDetails.ApplicantPreferredContactDelivery;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPreviousEmployerName = v.ApplicationApplicants.MainApplicantDetails.ApplicantPreviousEmployerName;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPreviousEmployerPeriod = v.ApplicationApplicants.MainApplicantDetails.ApplicantPreviousEmployerPeriod;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantRehabilitated = v.ApplicationApplicants.MainApplicantDetails.ApplicantRehabilitated;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantRightOfRefusalConsent = v.ApplicationApplicants.MainApplicantDetails.ApplicantRightOfRefusalConsent;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSACitizen = v.ApplicationApplicants.MainApplicantDetails.ApplicantSACitizen;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSurname = v.ApplicationApplicants.MainApplicantDetails.ApplicantSurname;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationNumber = v.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationNumber;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationNumber1 = v.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationNumber1;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationNumber2 = v.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationNumber2;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationNumber3 = v.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationNumber3;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationNumber4 = v.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationNumber4;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationReason = v.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationReason;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationReason1 = v.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationReason1;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationReason2 = v.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationReason2;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationReason3 = v.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationReason3;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationReason4 = v.ApplicationApplicants.MainApplicantDetails.ApplicantTaxIdentificationReason4;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTempResident = v.ApplicationApplicants.MainApplicantDetails.ApplicantTempResident;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTempResidentPermitExpiry = v.ApplicationApplicants.MainApplicantDetails.ApplicantTempResidentPermitExpiry;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTempResidentPermitNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantTempResidentPermitNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTitle = v.ApplicationApplicants.MainApplicantDetails.ApplicantTitle;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTypeOfIncome = v.ApplicationApplicants.MainApplicantDetails.ApplicantTypeOfIncome;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantWorkPhone = v.ApplicationApplicants.MainApplicantDetails.ApplicantWorkPhone;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantWorkPhoneCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantWorkPhoneCode;

            request.ApplicationDetails.ApplicationAgencyFax = v.ApplicationDetails.ApplicationAgencyFax;

            request.ApplicationDetails.ApplicationAgentName = v.ApplicationDetails.ApplicationAgentName;

            request.ApplicationDetails.ApplicationAIPBanks = v.ApplicationDetails.ApplicationAIPBanks;

            request.ApplicationDetails.ApplicationApplicantYearOfPurchase = v.ApplicationDetails.ApplicationApplicantYearOfPurchase;

            request.ApplicationDetails.ApplicationBondAmountToBeRegistered = v.ApplicationDetails.ApplicationBondAmountToBeRegistered;

            request.ApplicationDetails.ApplicationBrandType = v.ApplicationDetails.ApplicationBrandType;

            request.ApplicationDetails.ApplicationCollateralSecurity = v.ApplicationDetails.ApplicationCollateralSecurity;

            request.ApplicationDetails.ApplicationComplexName = v.ApplicationDetails.ApplicationComplexName;

            request.ApplicationDetails.ApplicationConsultantCellphone = v.ApplicationDetails.ApplicationConsultantCellphone;

            request.ApplicationDetails.ApplicationConsultantFaxNo = v.ApplicationDetails.ApplicationConsultantFaxNo;

            request.ApplicationDetails.ApplicationConsultantFirstName = v.ApplicationDetails.ApplicationConsultantFirstName;

            request.ApplicationDetails.ApplicationConsultantSurname = v.ApplicationDetails.ApplicationConsultantSurname;
            
            request.ApplicationDetails.ApplicationDebitAccountBranch = v.ApplicationDetails.ApplicationDebitAccountBranch;

            request.ApplicationDetails.ApplicationDebitAccountBranchCode = v.ApplicationDetails.ApplicationDebitAccountBranchCode;

            request.ApplicationDetails.ApplicationDebitAccountInstitution = v.ApplicationDetails.ApplicationDebitAccountInstitution;

            request.ApplicationDetails.ApplicationDebitAccountName = v.ApplicationDetails.ApplicationDebitAccountName;

            request.ApplicationDetails.ApplicationDebitAccountNo = v.ApplicationDetails.ApplicationDebitAccountNo;

            request.ApplicationDetails.ApplicationDebitAccountType = v.ApplicationDetails.ApplicationDebitAccountType;

            request.ApplicationDetails.ApplicationDeclinedBanks = v.ApplicationDetails.ApplicationDeclinedBanks;

            request.ApplicationDetails.ApplicationDepositCash = v.ApplicationDetails.ApplicationDepositCash;

            request.ApplicationDetails.ApplicationDepositOther = v.ApplicationDetails.ApplicationDepositOther;

            request.ApplicationDetails.ApplicationDwellingPurpose = v.ApplicationDetails.ApplicationDwellingPurpose;

            request.ApplicationDetails.ApplicationEstateAgency = v.ApplicationDetails.ApplicationEstateAgency;

            request.ApplicationDetails.ApplicationFirstPropertyPurchase = v.ApplicationDetails.ApplicationFirstPropertyPurchase;

            request.ApplicationDetails.ApplicationFNBBondAccountNumber = v.ApplicationDetails.ApplicationFNBBondAccountNumber;

            request.ApplicationDetails.ApplicationFNBBondAttorney = v.ApplicationDetails.ApplicationFNBBondAttorney;

            request.ApplicationDetails.ApplicationFNBBondFree = v.ApplicationDetails.ApplicationFNBBondFree;

            request.ApplicationDetails.ApplicationFNBBondHolderName = v.ApplicationDetails.ApplicationFNBBondHolderName;

            request.ApplicationDetails.ApplicationFNBBondInstitutionBranchName = v.ApplicationDetails.ApplicationFNBBondInstitutionBranchName;

            request.ApplicationDetails.ApplicationFNBBondInstitutionName = v.ApplicationDetails.ApplicationFNBBondInstitutionName;

            request.ApplicationDetails.ApplicationFNBDirectors = v.ApplicationDetails.ApplicationFNBDirectors;

            request.ApplicationDetails.ApplicationFNBFutureChoiceRegistrationAmount = v.ApplicationDetails.ApplicationFNBFutureChoiceRegistrationAmount;

            request.ApplicationDetails.ApplicationFNBFuturePostalAddressCountry = v.ApplicationDetails.ApplicationFNBFuturePostalAddressCountry;

            request.ApplicationDetails.ApplicationFNBHFVendorCode = v.ApplicationDetails.ApplicationFNBHFVendorCode;

            request.ApplicationDetails.ApplicationFNBHFVendorDescription = v.ApplicationDetails.ApplicationFNBHFVendorDescription;

            request.ApplicationDetails.ApplicationFNBILPNumber = v.ApplicationDetails.ApplicationFNBILPNumber;

            request.ApplicationDetails.ApplicationFNBIsDevelopment = v.ApplicationDetails.ApplicationFNBIsDevelopment;

            request.ApplicationDetails.ApplicationFNBLoanType = v.ApplicationDetails.ApplicationFNBLoanType;

            request.ApplicationDetails.ApplicationFNBMoveHomeNotHomeloanId = v.ApplicationDetails.ApplicationFNBMoveHomeNotHomeloanId;

            request.ApplicationDetails.ApplicationFNBNumberofStakeholders = v.ApplicationDetails.ApplicationFNBNumberofStakeholders;

            request.ApplicationDetails.ApplicationFNBPropertyHoldingId = v.ApplicationDetails.ApplicationFNBPropertyHoldingId;

            request.ApplicationDetails.ApplicationFNBSubPropertyType = v.ApplicationDetails.ApplicationFNBSubPropertyType;

            request.ApplicationDetails.ApplicationFNBSwitchingBondRegisteredAmount = v.ApplicationDetails.ApplicationFNBSwitchingBondRegisteredAmount;

            request.ApplicationDetails.ApplicationFNBSwitchingTypeId = v.ApplicationDetails.ApplicationFNBSwitchingTypeId;

            request.ApplicationDetails.ApplicationFNBTransferAttorney = v.ApplicationDetails.ApplicationFNBTransferAttorney;

            request.ApplicationDetails.ApplicationFNBTypeOfApplication = v.ApplicationDetails.ApplicationFNBTypeOfApplication;

            request.ApplicationDetails.ApplicationFNBTypeOfProperty = v.ApplicationDetails.ApplicationFNBTypeOfProperty;

            request.ApplicationDetails.ApplicationFNBVendorDescription = v.ApplicationDetails.ApplicationFNBVendorDescription;

            request.ApplicationDetails.ApplicationFutureChoicePrincipleAmount = v.ApplicationDetails.ApplicationFutureChoicePrincipleAmount;

            request.ApplicationDetails.ApplicationFuturePostalAddress1 = v.ApplicationDetails.ApplicationFuturePostalAddress1;

            request.ApplicationDetails.ApplicationFuturePostalAddressCity = v.ApplicationDetails.ApplicationFuturePostalAddressCity;

            request.ApplicationDetails.ApplicationFuturePostalAddressCode = v.ApplicationDetails.ApplicationFuturePostalAddressCode;

            request.ApplicationDetails.ApplicationFuturePostalAddressSuburb = v.ApplicationDetails.ApplicationFuturePostalAddressSuburb;

            request.ApplicationDetails.ApplicationGenericLoanType = v.ApplicationDetails.ApplicationGenericLoanType;

            request.ApplicationDetails.ApplicationIncludeBondTransferCosts = v.ApplicationDetails.ApplicationIncludeBondTransferCosts;

            request.ApplicationDetails.ApplicationInstalmentMethod = v.ApplicationDetails.ApplicationInstalmentMethod;

            request.ApplicationDetails.ApplicationInterestPeriod = v.ApplicationDetails.ApplicationInterestPeriod;

            request.ApplicationDetails.ApplicationIsTrustCompanyCC = v.ApplicationDetails.ApplicationIsTrustCompanyCC;

            request.ApplicationDetails.ApplicationLoanAmountRequired = v.ApplicationDetails.ApplicationLoanAmountRequired;

            request.ApplicationDetails.ApplicationMonthlyRepayments = v.ApplicationDetails.ApplicationMonthlyRepayments;

            request.ApplicationDetails.ApplicationNamePropertyRegistered = v.ApplicationDetails.ApplicationNamePropertyRegistered;

            request.ApplicationDetails.ApplicationNetwork = v.ApplicationDetails.ApplicationNetwork;

            request.ApplicationDetails.ApplicationOfferToPurchaseDate = v.ApplicationDetails.ApplicationOfferToPurchaseDate;

            request.ApplicationDetails.ApplicationOneAccountConvertCheque = v.ApplicationDetails.ApplicationOneAccountConvertCheque;

            request.ApplicationDetails.ApplicationOneAccountConvertChequeAccountNumber = v.ApplicationDetails.ApplicationOneAccountConvertChequeAccountNumber;

            request.ApplicationDetails.ApplicationOneAccountConvertILP = v.ApplicationDetails.ApplicationOneAccountConvertILP;

            request.ApplicationDetails.ApplicationOriginatorEmail = v.ApplicationDetails.ApplicationOriginatorEmail;

            request.ApplicationDetails.ApplicationPortionNo = v.ApplicationDetails.ApplicationPortionNo;

            request.ApplicationDetails.ApplicationPrevMortgagePeriod = v.ApplicationDetails.ApplicationPrevMortgagePeriod;

            request.ApplicationDetails.ApplicationProcessingBranch = v.ApplicationDetails.ApplicationProcessingBranch;

            request.ApplicationDetails.ApplicationPropertyAddressCity = v.ApplicationDetails.ApplicationPropertyAddressCity;

            request.ApplicationDetails.ApplicationPropertyAddressSuburb = v.ApplicationDetails.ApplicationPropertyAddressSuburb;

            request.ApplicationDetails.ApplicationPropertyContactCellphone = v.ApplicationDetails.ApplicationPropertyContactCellphone;

            request.ApplicationDetails.ApplicationPropertyContactName = v.ApplicationDetails.ApplicationPropertyContactName;

            request.ApplicationDetails.ApplicationPropertyContactTelCode = v.ApplicationDetails.ApplicationPropertyContactTelCode;

            request.ApplicationDetails.ApplicationPropertyContactTelNo = v.ApplicationDetails.ApplicationPropertyContactTelNo;

            request.ApplicationDetails.ApplicationPropertyPostalCode = v.ApplicationDetails.ApplicationPropertyPostalCode;

            request.ApplicationDetails.ApplicationPropertyProvince = v.ApplicationDetails.ApplicationPropertyProvince;

            request.ApplicationDetails.ApplicationPropertyPurchasePrice = v.ApplicationDetails.ApplicationPropertyPurchasePrice;

            request.ApplicationDetails.ApplicationPropertyRight = v.ApplicationDetails.ApplicationPropertyRight;

            request.ApplicationDetails.ApplicationPropertyStreetName = v.ApplicationDetails.ApplicationPropertyStreetName;

            request.ApplicationDetails.ApplicationPropertyStreetNo = v.ApplicationDetails.ApplicationPropertyStreetNo;

            request.ApplicationDetails.ApplicationSectionalTitleUnitNo = v.ApplicationDetails.ApplicationSectionalTitleUnitNo;

            request.ApplicationDetails.ApplicationSectionNo = v.ApplicationDetails.ApplicationSectionNo;

            request.ApplicationDetails.ApplicationSecurityBonds = v.ApplicationDetails.ApplicationSecurityBonds;

            request.ApplicationDetails.ApplicationStandErfNo = v.ApplicationDetails.ApplicationStandErfNo;

            request.ApplicationDetails.ApplicationSubmittingBanks = v.ApplicationDetails.ApplicationSubmittingBanks;

            request.ApplicationDetails.ApplicationSuretyship = v.ApplicationDetails.ApplicationSuretyship;

            request.ApplicationDetails.ApplicationTermOfLoan = v.ApplicationDetails.ApplicationTermOfLoan;

            request.ApplicationDetails.ApplicationTypeOfBond = v.ApplicationDetails.ApplicationTypeOfBond;

            request.ApplicationDetails.ApplicationTypeOfInterest = v.ApplicationDetails.ApplicationTypeOfInterest;

            request.ApplicationDetails.ApplicationTypeOfOffer = v.ApplicationDetails.ApplicationTypeOfOffer;

            request.ApplicationDetails.ApplicationTypeOfStreet = v.ApplicationDetails.ApplicationTypeOfStreet;

            return request;
        }

    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("SubmitApplication.Request", Namespace = "", IsNullable = false)]
    public class SubmitNedApplicationRequest : SubmitApplicationRequest
    {
        [System.Xml.Serialization.XmlElementAttribute("Application.Details")]
        public NedApplicationRequest.SubmitApplicationRequestApplicationDetails ApplicationDetails { get; set; } = null;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Application.Applicants")]
        public NedApplicationRequest.SubmitApplicationRequestApplicationApplicants ApplicationApplicants { get; set; } = null;

        public static explicit operator SubmitNedApplicationRequest(SubmitIncomingApplicationRequest v)
        {
            SubmitNedApplicationRequest request = new SubmitNedApplicationRequest();
            request.ServiceHeader = v.ServiceHeader;
            request.ApplicationApplicants = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicants();
            request.ApplicationApplicants.MainApplicantDetails = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetails();
            request.ApplicationDetails = new NedApplicationRequest.SubmitApplicationRequestApplicationDetails();

            request.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount[v.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts.Length];
            for (int i = 0; i < v.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts.Length; ++i)
            {
                request.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i] = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount();
                ObjectMappingTools.TransferObject(v.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i], request.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i]);

            }

            request.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem[v.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems.Length];
            for (int i = 0; i < v.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems.Length; ++i)
            {
                request.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i] = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem();
                ObjectMappingTools.TransferObject(v.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i], request.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i]);

            }
            request.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem[v.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems.Length];
            for (int i = 0; i < v.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems.Length; ++i)
            {
                request.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i] = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem();
                ObjectMappingTools.TransferObject(v.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i], request.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i]);

            }

            if (v.ApplicationApplicants.MainApplicantDetails.ApplicantLiabilityItems != null && v.ApplicationApplicants.MainApplicantDetails.ApplicantLiabilityItems.Length > 0)
            {
                request.ApplicationApplicants.MainApplicantDetails.ApplicantLiabilityItems = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantLiabilityItem[v.ApplicationApplicants.MainApplicantDetails.ApplicantLiabilityItems.Length];
                for (int i = 0; i < v.ApplicationApplicants.MainApplicantDetails.ApplicantLiabilityItems.Length; ++i)
                {
                    request.ApplicationApplicants.MainApplicantDetails.ApplicantLiabilityItems[i] = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantLiabilityItem();
                    ObjectMappingTools.TransferObject(v.ApplicationApplicants.MainApplicantDetails.ApplicantLiabilityItems[i], request.ApplicationApplicants.MainApplicantDetails.ApplicantLiabilityItems[i]);
                }
            }

            if ((v.ApplicationApplicants.MainApplicantDetails.ApplicantAssetItems != null) && (v.ApplicationApplicants.MainApplicantDetails.ApplicantAssetItems.Length > 0))
            {
                request.ApplicationApplicants.MainApplicantDetails.ApplicantAssetItems = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantAssetItem[v.ApplicationApplicants.MainApplicantDetails.ApplicantAssetItems.Length];
                for (int i = 0; i < v.ApplicationApplicants.MainApplicantDetails.ApplicantLiabilityItems.Length; ++i)
                {
                    request.ApplicationApplicants.MainApplicantDetails.ApplicantAssetItems[i] = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantAssetItem();
                    ObjectMappingTools.TransferObject(v.ApplicationApplicants.MainApplicantDetails.ApplicantAssetItems[i], request.ApplicationApplicants.MainApplicantDetails.ApplicantAssetItems[i]);

                }
            }

            if (v.ApplicationApplicants.CoApplicantDetails != null)
            {
                request.ApplicationApplicants.CoApplicantDetails = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsCoApplicantDetails();
                ObjectMappingTools.TransferObject(v.ApplicationApplicants.CoApplicantDetails, request.ApplicationApplicants.CoApplicantDetails);

            }


            request.ApplicationApplicants.MainApplicantDetails.ApplicantCanRetrieveStatement = v.ApplicationApplicants.MainApplicantDetails.ApplicantCanRetrieveStatement;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCellphone = v.ApplicationApplicants.MainApplicantDetails.ApplicantCellphone;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCorrespondenceLanguage = v.ApplicationApplicants.MainApplicantDetails.ApplicantCorrespondenceLanguage;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCountryOfBirth = v.ApplicationApplicants.MainApplicantDetails.ApplicantCountryOfBirth;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCountryPassportIssued = v.ApplicationApplicants.MainApplicantDetails.ApplicantCountryPassportIssued;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDateJoinedEmployer = v.ApplicationApplicants.MainApplicantDetails.ApplicantDateJoinedEmployer;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDateOfBirth = v.ApplicationApplicants.MainApplicantDetails.ApplicantDateOfBirth;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDatePassportExpires = v.ApplicationApplicants.MainApplicantDetails.ApplicantDatePassportExpires;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDatePassportIssued = v.ApplicationApplicants.MainApplicantDetails.ApplicantDatePassportIssued;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDateRehabilitated = v.ApplicationApplicants.MainApplicantDetails.ApplicantDateRehabilitated;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDeclaredInsolvent = v.ApplicationApplicants.MainApplicantDetails.ApplicantDeclaredInsolvent;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDisputeWithCreditBureau = v.ApplicationApplicants.MainApplicantDetails.ApplicantDisputeWithCreditBureau;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmailAddress = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmailAddress;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerName = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerName;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerTelCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerTelCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerTelNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerTelNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmploymentIndustry = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmploymentIndustry;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEthnicGroup = v.ApplicationApplicants.MainApplicantDetails.ApplicantEthnicGroup;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFaxCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantFaxCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFaxNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantFaxNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFirstName = v.ApplicationApplicants.MainApplicantDetails.ApplicantFirstName;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantGender = v.ApplicationApplicants.MainApplicantDetails.ApplicantGender;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantHadJudgement = v.ApplicationApplicants.MainApplicantDetails.ApplicantHadJudgement;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantHomePhone = v.ApplicationApplicants.MainApplicantDetails.ApplicantHomePhone;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantHomePhoneCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantHomePhoneCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantIdentificationNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantIdentificationNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantIdentificationType = v.ApplicationApplicants.MainApplicantDetails.ApplicantIdentificationType;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeTaxNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeTaxNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantInsolventDate = v.ApplicationApplicants.MainApplicantDetails.ApplicantInsolventDate;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantIsUnderAdminOrder = v.ApplicationApplicants.MainApplicantDetails.ApplicantIsUnderAdminOrder;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantIsUnderDebtReview = v.ApplicationApplicants.MainApplicantDetails.ApplicantIsUnderDebtReview;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantJobChange = v.ApplicationApplicants.MainApplicantDetails.ApplicantJobChange;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMaritalStatus = v.ApplicationApplicants.MainApplicantDetails.ApplicantMaritalStatus;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMarriedStatus = v.ApplicationApplicants.MainApplicantDetails.ApplicantMarriedStatus;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMassContact = v.ApplicationApplicants.MainApplicantDetails.ApplicantMassContact;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMayBankContactYou = v.ApplicationApplicants.MainApplicantDetails.ApplicantMayBankContactYou;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMaySubsidiariesContactYou = v.ApplicationApplicants.MainApplicantDetails.ApplicantMaySubsidiariesContactYou;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantNationality = v.ApplicationApplicants.MainApplicantDetails.ApplicantNationality;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantNedBranch = v.ApplicationApplicants.MainApplicantDetails.ApplicantNedBranch;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantNedEmploymentType = v.ApplicationApplicants.MainApplicantDetails.ApplicantNedEmploymentType;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantNedMultipleNationalities = v.ApplicationApplicants.MainApplicantDetails.ApplicantNedMultipleNationalities;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantNedOccupation = v.ApplicationApplicants.MainApplicantDetails.ApplicantNedOccupation;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantNedSecondaryNationality = v.ApplicationApplicants.MainApplicantDetails.ApplicantNedSecondaryNationality;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantNoOfDependents = v.ApplicationApplicants.MainApplicantDetails.ApplicantNoOfDependents;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPassportNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantPassportNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPermanentResidentCountry = v.ApplicationApplicants.MainApplicantDetails.ApplicantPermanentResidentCountry;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressCity = v.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressCity;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressLine1 = v.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressLine1;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressLine2 = v.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressLine2;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressSuburb = v.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressSuburb;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressCity = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressCity;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressLine1 = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressLine1;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressLine2 = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressLine2;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressSuburb = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressSuburb;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalSameIndicator = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalSameIndicator;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPreferredContactDelivery = v.ApplicationApplicants.MainApplicantDetails.ApplicantPreferredContactDelivery;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPreviousEmployerPeriod = v.ApplicationApplicants.MainApplicantDetails.ApplicantPreviousEmployerPeriod;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantRearrangementInPlace = v.ApplicationApplicants.MainApplicantDetails.ApplicantRearrangementInPlace;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantResidentialStatus = v.ApplicationApplicants.MainApplicantDetails.ApplicantResidentialStatus;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantRightOfRefusalConsent = v.ApplicationApplicants.MainApplicantDetails.ApplicantRightOfRefusalConsent;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSACitizen = v.ApplicationApplicants.MainApplicantDetails.ApplicantSACitizen;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSelfEmployed = v.ApplicationApplicants.MainApplicantDetails.ApplicantSelfEmployed;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSourceOfIncome = v.ApplicationApplicants.MainApplicantDetails.ApplicantSourceOfIncome;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSourceOfIncomeNone = v.ApplicationApplicants.MainApplicantDetails.ApplicantSourceOfIncomeNone;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSourceOfIncomeOther = v.ApplicationApplicants.MainApplicantDetails.ApplicantSourceOfIncomeOther;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSurname = v.ApplicationApplicants.MainApplicantDetails.ApplicantSurname;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTitle = v.ApplicationApplicants.MainApplicantDetails.ApplicantTitle;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantWasUnderAdminOrder = v.ApplicationApplicants.MainApplicantDetails.ApplicantWasUnderAdminOrder;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantWorkPhone = v.ApplicationApplicants.MainApplicantDetails.ApplicantWorkPhone;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantWorkPhoneCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantWorkPhoneCode;
           
            request.ApplicationDetails.ApplicationAdvancePaymentOption = v.ApplicationDetails.ApplicationAdvancePaymentOption;

            request.ApplicationDetails.ApplicationAgencyCellphone = v.ApplicationDetails.ApplicationAgencyCellphone;

            request.ApplicationDetails.ApplicationAgencyFax = v.ApplicationDetails.ApplicationAgencyFax;

            request.ApplicationDetails.ApplicationAgencyPhysicalAddress = v.ApplicationDetails.ApplicationAgencyPhysicalAddress;

            request.ApplicationDetails.ApplicationAgencyPhysicalCity = v.ApplicationDetails.ApplicationAgencyPhysicalCity;

            request.ApplicationDetails.ApplicationAgencyTel = v.ApplicationDetails.ApplicationAgencyTel;

            request.ApplicationDetails.ApplicationAgentName = v.ApplicationDetails.ApplicationAgentName;

            request.ApplicationDetails.ApplicationAgriculturalIndicator = v.ApplicationDetails.ApplicationAgriculturalIndicator;

            request.ApplicationDetails.ApplicationAIPBanks = v.ApplicationDetails.ApplicationAIPBanks;

            request.ApplicationDetails.ApplicationApplicationOrigin = v.ApplicationDetails.ApplicationApplicationOrigin;

            request.ApplicationDetails.ApplicationAreaOfLand = v.ApplicationDetails.ApplicationAreaOfLand;

            request.ApplicationDetails.ApplicationAssuranceLPAType = v.ApplicationDetails.ApplicationAssuranceLPAType;

            request.ApplicationDetails.ApplicationAssuranceMonthlyPremium = v.ApplicationDetails.ApplicationAssuranceMonthlyPremium;

            request.ApplicationDetails.ApplicationAssurancePaymentMethod = v.ApplicationDetails.ApplicationAssurancePaymentMethod;

            request.ApplicationDetails.ApplicationAttorneyRequestedBy = v.ApplicationDetails.ApplicationAttorneyRequestedBy;

            request.ApplicationDetails.ApplicationBondAmount = v.ApplicationDetails.ApplicationBondAmount;

            request.ApplicationDetails.ApplicationBondAttorney = v.ApplicationDetails.ApplicationBondAttorney;

            request.ApplicationDetails.ApplicationBusinessCountry = v.ApplicationDetails.ApplicationBusinessCountry;

            request.ApplicationDetails.ApplicationBusinessEmail = v.ApplicationDetails.ApplicationBusinessEmail;

            request.ApplicationDetails.ApplicationBusinessFaxCode = v.ApplicationDetails.ApplicationBusinessFaxCode;

            request.ApplicationDetails.ApplicationBusinessFaxNumber = v.ApplicationDetails.ApplicationBusinessFaxNumber;

            request.ApplicationDetails.ApplicationBusinessSourceOfIncomeOther = v.ApplicationDetails.ApplicationBusinessSourceOfIncomeOther;

            request.ApplicationDetails.ApplicationBusinessTelephoneCode = v.ApplicationDetails.ApplicationBusinessTelephoneCode;

            request.ApplicationDetails.ApplicationBusinessTelephoneNumber = v.ApplicationDetails.ApplicationBusinessTelephoneNumber;

            request.ApplicationDetails.ApplicationCommercialOrBusiness = v.ApplicationDetails.ApplicationCommercialOrBusiness;

            request.ApplicationDetails.ApplicationCommercialTitle = v.ApplicationDetails.ApplicationCommercialTitle;

            request.ApplicationDetails.ApplicationComplexName = v.ApplicationDetails.ApplicationComplexName;

            request.ApplicationDetails.ApplicationConsultantCellphone = v.ApplicationDetails.ApplicationConsultantCellphone;

            request.ApplicationDetails.ApplicationConsultantEmailAddress = v.ApplicationDetails.ApplicationConsultantEmailAddress;

            request.ApplicationDetails.ApplicationConsultantFaxNo = v.ApplicationDetails.ApplicationConsultantFaxNo;

            request.ApplicationDetails.ApplicationConsultantWorkTelNo = v.ApplicationDetails.ApplicationConsultantWorkTelNo;

            request.ApplicationDetails.ApplicationContractPrice = v.ApplicationDetails.ApplicationContractPrice;

            request.ApplicationDetails.ApplicationDebitAccountNo = v.ApplicationDetails.ApplicationDebitAccountNo;

            request.ApplicationDetails.ApplicationDebitAccountType = v.ApplicationDetails.ApplicationDebitAccountType;

            request.ApplicationDetails.ApplicationDeclinedBanks = v.ApplicationDetails.ApplicationDeclinedBanks;

            request.ApplicationDetails.ApplicationDwellingPurpose = v.ApplicationDetails.ApplicationDwellingPurpose;

            request.ApplicationDetails.ApplicationEconomicSector = v.ApplicationDetails.ApplicationEconomicSector;

            request.ApplicationDetails.ApplicationEstateAgency = v.ApplicationDetails.ApplicationEstateAgency;

            request.ApplicationDetails.ApplicationFinancialYearEnd = v.ApplicationDetails.ApplicationFinancialYearEnd;

            request.ApplicationDetails.ApplicationFirstPropertyPurchase = v.ApplicationDetails.ApplicationFirstPropertyPurchase;

            request.ApplicationDetails.ApplicationFuturePostalAddress1 = v.ApplicationDetails.ApplicationFuturePostalAddress1;

            request.ApplicationDetails.ApplicationFuturePostalAddressCity = v.ApplicationDetails.ApplicationFuturePostalAddressCity;

            request.ApplicationDetails.ApplicationFuturePostalAddressCode = v.ApplicationDetails.ApplicationFuturePostalAddressCode;

            request.ApplicationDetails.ApplicationFuturePostalAddressSuburb = v.ApplicationDetails.ApplicationFuturePostalAddressSuburb;

            request.ApplicationDetails.ApplicationIncludeBondTransferCosts = v.ApplicationDetails.ApplicationIncludeBondTransferCosts;

            request.ApplicationDetails.ApplicationIndicateInsuranceOption = v.ApplicationDetails.ApplicationIndicateInsuranceOption;

            request.ApplicationDetails.ApplicationInitFeePaymentOption = v.ApplicationDetails.ApplicationInitFeePaymentOption;

            request.ApplicationDetails.ApplicationInstalmentMethod = v.ApplicationDetails.ApplicationInstalmentMethod;

            request.ApplicationDetails.ApplicationInsuranceCompany = v.ApplicationDetails.ApplicationInsuranceCompany;

            request.ApplicationDetails.ApplicationInsuranceCoverReason = v.ApplicationDetails.ApplicationInsuranceCoverReason;

            request.ApplicationDetails.ApplicationInsuranceMonthlyPremium = v.ApplicationDetails.ApplicationInsuranceMonthlyPremium;

            request.ApplicationDetails.ApplicationInsurancePaymentMethod = v.ApplicationDetails.ApplicationInsurancePaymentMethod;

            request.ApplicationDetails.ApplicationInsurancePolicyNumber = v.ApplicationDetails.ApplicationInsurancePolicyNumber;

            request.ApplicationDetails.ApplicationLapa = v.ApplicationDetails.ApplicationLapa;

            request.ApplicationDetails.ApplicationLapaDistance = v.ApplicationDetails.ApplicationLapaDistance;

            request.ApplicationDetails.ApplicationLapaSize = v.ApplicationDetails.ApplicationLapaSize;

            request.ApplicationDetails.ApplicationLoanAmountRequired = v.ApplicationDetails.ApplicationLoanAmountRequired;

            request.ApplicationDetails.ApplicationMainBuildingSize = v.ApplicationDetails.ApplicationMainBuildingSize;

            request.ApplicationDetails.ApplicationManagingAgentDetails = v.ApplicationDetails.ApplicationManagingAgentDetails;

            request.ApplicationDetails.ApplicationNamePropertyRegistered = v.ApplicationDetails.ApplicationNamePropertyRegistered;

            request.ApplicationDetails.ApplicationNedAgencyCode = v.ApplicationDetails.ApplicationNedAgencyCode;

            request.ApplicationDetails.ApplicationNedAgencyName = v.ApplicationDetails.ApplicationNedAgencyName;

            request.ApplicationDetails.ApplicationNedAssuranceCompany = v.ApplicationDetails.ApplicationNedAssuranceCompany;

            request.ApplicationDetails.ApplicationNedAssuranceCoverAmount = v.ApplicationDetails.ApplicationNedAssuranceCoverAmount;

            request.ApplicationDetails.ApplicationNEDCompanyName = v.ApplicationDetails.ApplicationNEDCompanyName;

            request.ApplicationDetails.ApplicationNEDCompanyName2 = v.ApplicationDetails.ApplicationNEDCompanyName2;

            request.ApplicationDetails.ApplicationNedDebitAccountBranch = v.ApplicationDetails.ApplicationNedDebitAccountBranch;

            request.ApplicationDetails.ApplicationNedDebitAccountBranchCode = v.ApplicationDetails.ApplicationNedDebitAccountBranchCode;

            request.ApplicationDetails.ApplicationNedDebitAccountInstitution = v.ApplicationDetails.ApplicationNedDebitAccountInstitution;

            request.ApplicationDetails.ApplicationNEDDeclarationOfWarranty = v.ApplicationDetails.ApplicationNEDDeclarationOfWarranty;

            request.ApplicationDetails.ApplicationNedLoanReason = v.ApplicationDetails.ApplicationNedLoanReason;

            request.ApplicationDetails.ApplicationNEDMOIDateOfIssue = v.ApplicationDetails.ApplicationNEDMOIDateOfIssue;

            request.ApplicationDetails.ApplicationNEDMOIIndexed = v.ApplicationDetails.ApplicationNEDMOIIndexed;

            request.ApplicationDetails.ApplicationNEDMOIIndicator = v.ApplicationDetails.ApplicationNEDMOIIndicator;

            request.ApplicationDetails.ApplicationNEDMOIType = v.ApplicationDetails.ApplicationNEDMOIType;

            request.ApplicationDetails.ApplicationNedTypeOfProperty = v.ApplicationDetails.ApplicationNedTypeOfProperty;

            request.ApplicationDetails.ApplicationNedVendorDescription = v.ApplicationDetails.ApplicationNedVendorDescription;

            request.ApplicationDetails.ApplicationNetwork = v.ApplicationDetails.ApplicationNetwork;

            request.ApplicationDetails.ApplicationOriginatorEmail = v.ApplicationDetails.ApplicationOriginatorEmail;

            request.ApplicationDetails.ApplicationOutBuildingNo = v.ApplicationDetails.ApplicationOutBuildingNo;

            request.ApplicationDetails.ApplicationOwnAttorneyReason = v.ApplicationDetails.ApplicationOwnAttorneyReason;

            request.ApplicationDetails.ApplicationParkingBayNo = v.ApplicationDetails.ApplicationParkingBayNo;

            request.ApplicationDetails.ApplicationPaymentHoliday = v.ApplicationDetails.ApplicationPaymentHoliday;

            request.ApplicationDetails.ApplicationPortionNo = v.ApplicationDetails.ApplicationPortionNo;

            request.ApplicationDetails.ApplicationProcessingRegion = v.ApplicationDetails.ApplicationProcessingRegion;

            request.ApplicationDetails.ApplicationPropertyAddressCity = v.ApplicationDetails.ApplicationPropertyAddressCity;

            request.ApplicationDetails.ApplicationPropertyAddressSuburb = v.ApplicationDetails.ApplicationPropertyAddressSuburb;

            request.ApplicationDetails.ApplicationPropertyBondAccountNo = v.ApplicationDetails.ApplicationPropertyBondAccountNo;

            request.ApplicationDetails.ApplicationPropertyBondBank = v.ApplicationDetails.ApplicationPropertyBondBank;

            request.ApplicationDetails.ApplicationPropertyBondBranch = v.ApplicationDetails.ApplicationPropertyBondBranch;

            request.ApplicationDetails.ApplicationPropertyBondBranchCode = v.ApplicationDetails.ApplicationPropertyBondBranchCode;

            request.ApplicationDetails.ApplicationPropertyContactCellphone = v.ApplicationDetails.ApplicationPropertyContactCellphone;

            request.ApplicationDetails.ApplicationPropertyContactName = v.ApplicationDetails.ApplicationPropertyContactName;

            request.ApplicationDetails.ApplicationPropertyContactTelCode = v.ApplicationDetails.ApplicationPropertyContactTelCode;

            request.ApplicationDetails.ApplicationPropertyContactTelNo = v.ApplicationDetails.ApplicationPropertyContactTelNo;

            request.ApplicationDetails.ApplicationPropertyCurrentlyBonded = v.ApplicationDetails.ApplicationPropertyCurrentlyBonded;

            request.ApplicationDetails.ApplicationPropertyDescription = v.ApplicationDetails.ApplicationPropertyDescription;

            request.ApplicationDetails.ApplicationPropertyOccupantContact = v.ApplicationDetails.ApplicationPropertyOccupantContact;

            request.ApplicationDetails.ApplicationPropertyPostalCode = v.ApplicationDetails.ApplicationPropertyPostalCode;

            request.ApplicationDetails.ApplicationPropertyProvince = v.ApplicationDetails.ApplicationPropertyProvince;

            request.ApplicationDetails.ApplicationPropertyPurchaseDate = v.ApplicationDetails.ApplicationPropertyPurchaseDate;

            request.ApplicationDetails.ApplicationPropertyPurchasePrice = v.ApplicationDetails.ApplicationPropertyPurchasePrice;

            request.ApplicationDetails.ApplicationPropertyRight = v.ApplicationDetails.ApplicationPropertyRight;

            request.ApplicationDetails.ApplicationPropertyRoofConstruction = v.ApplicationDetails.ApplicationPropertyRoofConstruction;

            request.ApplicationDetails.ApplicationPropertyStreetName = v.ApplicationDetails.ApplicationPropertyStreetName;

            request.ApplicationDetails.ApplicationPropertyStreetNo = v.ApplicationDetails.ApplicationPropertyStreetNo;

            request.ApplicationDetails.ApplicationPropertyWallConstruction = v.ApplicationDetails.ApplicationPropertyWallConstruction;

            request.ApplicationDetails.ApplicationSectionalTitleRegister = v.ApplicationDetails.ApplicationSectionalTitleRegister;

            request.ApplicationDetails.ApplicationSectionalTitleUnitNo = v.ApplicationDetails.ApplicationSectionalTitleUnitNo;

            request.ApplicationDetails.ApplicationSectionNo = v.ApplicationDetails.ApplicationSectionNo;

            request.ApplicationDetails.ApplicationSellerCellphone = v.ApplicationDetails.ApplicationSellerCellphone;

            request.ApplicationDetails.ApplicationSellerName = v.ApplicationDetails.ApplicationSellerName;

            request.ApplicationDetails.ApplicationSellerTelNo = v.ApplicationDetails.ApplicationSellerTelNo;

            request.ApplicationDetails.ApplicationStandErfNo = v.ApplicationDetails.ApplicationStandErfNo;

            request.ApplicationDetails.ApplicationStatementSentToIndicator = v.ApplicationDetails.ApplicationStatementSentToIndicator;

            request.ApplicationDetails.ApplicationSubmittingBanks = v.ApplicationDetails.ApplicationSubmittingBanks;

            request.ApplicationDetails.ApplicationTermOfLoan = v.ApplicationDetails.ApplicationTermOfLoan;

            request.ApplicationDetails.ApplicationTransferAttorney = v.ApplicationDetails.ApplicationTransferAttorney;

            request.ApplicationDetails.ApplicationTypeOfAssurance = v.ApplicationDetails.ApplicationTypeOfAssurance;

            request.ApplicationDetails.ApplicationTypeOfGroupScheme = v.ApplicationDetails.ApplicationTypeOfGroupScheme;

                                                                                                                
            return request;
        }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("SubmitApplication.Request", Namespace = "", IsNullable = false)]
    public class SubmitSbsaApplicationRequest : SubmitApplicationRequest
    {
        [System.Xml.Serialization.XmlElementAttribute("Application.Details")]
        public SbsaApplicationRequest.SubmitApplicationRequestApplicationDetails ApplicationDetails { get; set; } = null;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Application.Applicants")]
        public SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicants ApplicationApplicants { get; set; } = null;

        public static explicit operator SubmitSbsaApplicationRequest(SubmitIncomingApplicationRequest v)
        {
            SubmitSbsaApplicationRequest request = new SubmitSbsaApplicationRequest();
            request.ServiceHeader = v.ServiceHeader;
            request.ApplicationApplicants = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicants();
            request.ApplicationApplicants.MainApplicantDetails = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetails();
            request.ApplicationDetails = new SbsaApplicationRequest.SubmitApplicationRequestApplicationDetails();
            
            if (v.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts != null && v.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts.Length>0)
            { 
                request.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount[v.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts.Length];
                for (int i = 0; i < v.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts.Length; ++i)
                {
                    request.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i] = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount();
                    ObjectMappingTools.TransferObject(v.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i], request.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i]);
                    request.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i].ApplicantSTDAccountBranch = v.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i].ApplicantAccountBranch;
                    request.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i].ApplicantSTDAccountBranchCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i].ApplicantAccountBranchCode;
                }
            }

            request.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem[v.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems.Length];
            for (int i = 0; i < v.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems.Length; ++i)
            {

                request.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i] = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem();
                ObjectMappingTools.TransferObject(v.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i], request.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i]);

            }
            request.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem[v.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems.Length];
            for (int i = 0; i < v.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems.Length; ++i)
            {
                request.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i] = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem();
                ObjectMappingTools.TransferObject(v.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i], request.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i]);

            }

            

            if (v.ApplicationApplicants.CoApplicantDetails != null)
            {
                request.ApplicationApplicants.CoApplicantDetails = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsCoApplicantDetails();
                ObjectMappingTools.TransferObject(v.ApplicationApplicants.CoApplicantDetails, request.ApplicationApplicants.CoApplicantDetails);

            }
            
           
            request.ApplicationApplicants.MainApplicantDetails.ApplicantBankPackage = v.ApplicationApplicants.MainApplicantDetails.ApplicantBankPackage;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCellphone = v.ApplicationApplicants.MainApplicantDetails.ApplicantCellphone;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCompanyRegistrationNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantCompanyRegistrationNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCorrespondenceLanguage = v.ApplicationApplicants.MainApplicantDetails.ApplicantCorrespondenceLanguage;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCountryOfBirth = v.ApplicationApplicants.MainApplicantDetails.ApplicantCountryOfBirth;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCountryOfPermResidenceCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantCountryOfPermResidenceCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCurrentEmploymentStatus = v.ApplicationApplicants.MainApplicantDetails.ApplicantCurrentEmploymentStatus;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantCurrentMonthlyInstallment = v.ApplicationApplicants.MainApplicantDetails.ApplicantCurrentMonthlyInstallment;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDateJoinedEmployer = v.ApplicationApplicants.MainApplicantDetails.ApplicantDateJoinedEmployer;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDateOfBirth = v.ApplicationApplicants.MainApplicantDetails.ApplicantDateOfBirth;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDatePassportExpires = v.ApplicationApplicants.MainApplicantDetails.ApplicantDatePassportExpires;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDateRehabilitated = v.ApplicationApplicants.MainApplicantDetails.ApplicantDateRehabilitated;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantDeclaredInsolvent = v.ApplicationApplicants.MainApplicantDetails.ApplicantDeclaredInsolvent;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmailAddress = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmailAddress;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployeeNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployeeNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerAddress = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerAddress;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerFaxCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerFaxCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerFaxNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerFaxNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerName = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerName;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerTelCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerTelCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerTelNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmployerTelNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEmploymentIndustry = v.ApplicationApplicants.MainApplicantDetails.ApplicantEmploymentIndustry;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantEthnicGroup = v.ApplicationApplicants.MainApplicantDetails.ApplicantEthnicGroup;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFaxCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantFaxCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFaxNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantFaxNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFirstName = v.ApplicationApplicants.MainApplicantDetails.ApplicantFirstName;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantFrequencyOfSalaryPayments = v.ApplicationApplicants.MainApplicantDetails.ApplicantFrequencyOfSalaryPayments;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantGender = v.ApplicationApplicants.MainApplicantDetails.ApplicantGender;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantHighestQualification = v.ApplicationApplicants.MainApplicantDetails.ApplicantHighestQualification;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantHomePhone = v.ApplicationApplicants.MainApplicantDetails.ApplicantHomePhone;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantHomePhoneCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantHomePhoneCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantIdentificationNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantIdentificationNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantIdentificationType = v.ApplicationApplicants.MainApplicantDetails.ApplicantIdentificationType;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeMix = v.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeMix;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeTaxNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeTaxNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantInitials = v.ApplicationApplicants.MainApplicantDetails.ApplicantInitials;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantIsUnderAdminOrder = v.ApplicationApplicants.MainApplicantDetails.ApplicantIsUnderAdminOrder;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantIsUnderDebtReview = v.ApplicationApplicants.MainApplicantDetails.ApplicantIsUnderDebtReview;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMaritalStatus = v.ApplicationApplicants.MainApplicantDetails.ApplicantMaritalStatus;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMarriedStatus = v.ApplicationApplicants.MainApplicantDetails.ApplicantMarriedStatus;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMayBankContactYou = v.ApplicationApplicants.MainApplicantDetails.ApplicantMayBankContactYou;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMayBankShareInfo = v.ApplicationApplicants.MainApplicantDetails.ApplicantMayBankShareInfo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMayOthersContactYou = v.ApplicationApplicants.MainApplicantDetails.ApplicantMayOthersContactYou;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMaySubsidiariesContactYou = v.ApplicationApplicants.MainApplicantDetails.ApplicantMaySubsidiariesContactYou;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantMayUseForResearch = v.ApplicationApplicants.MainApplicantDetails.ApplicantMayUseForResearch;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantNationality = v.ApplicationApplicants.MainApplicantDetails.ApplicantNationality;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantNoOfDependents = v.ApplicationApplicants.MainApplicantDetails.ApplicantNoOfDependents;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantOccupation = v.ApplicationApplicants.MainApplicantDetails.ApplicantOccupation;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantOccupationLevel = v.ApplicationApplicants.MainApplicantDetails.ApplicantOccupationLevel;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPassportNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantPassportNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPermanentResident = v.ApplicationApplicants.MainApplicantDetails.ApplicantPermanentResident;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPermanentResidentCountry = v.ApplicationApplicants.MainApplicantDetails.ApplicantPermanentResidentCountry;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPermitIssueDate = v.ApplicationApplicants.MainApplicantDetails.ApplicantPermitIssueDate;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPermitNumber = v.ApplicationApplicants.MainApplicantDetails.ApplicantPermitNumber;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressLine1 = v.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressLine1;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressLine2 = v.ApplicationApplicants.MainApplicantDetails.ApplicantPhysicalAddressLine2;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressLine1 = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressLine1;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressLine2 = v.ApplicationApplicants.MainApplicantDetails.ApplicantPostalAddressLine2;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPreviousEmployerName = v.ApplicationApplicants.MainApplicantDetails.ApplicantPreviousEmployerName;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantPreviousEmployerPeriod = v.ApplicationApplicants.MainApplicantDetails.ApplicantPreviousEmployerPeriod;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantRentingProperty = v.ApplicationApplicants.MainApplicantDetails.ApplicantRentingProperty;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantRightOfRefusalConsent = v.ApplicationApplicants.MainApplicantDetails.ApplicantRightOfRefusalConsent;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSACitizen = v.ApplicationApplicants.MainApplicantDetails.ApplicantSACitizen;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSBSAIsAssociatedToOffical = v.ApplicationApplicants.MainApplicantDetails.ApplicantSBSAIsAssociatedToOffical;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSBSAIsPublicOffical = v.ApplicationApplicants.MainApplicantDetails.ApplicantSBSAIsPublicOffical;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSBSANatureOfRelationship = v.ApplicationApplicants.MainApplicantDetails.ApplicantSBSANatureOfRelationship;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSBSAPOFirstName = v.ApplicationApplicants.MainApplicantDetails.ApplicantSBSAPOFirstName;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSBSAPOSurname = v.ApplicationApplicants.MainApplicantDetails.ApplicantSBSAPOSurname;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantShareHolderPercentage = v.ApplicationApplicants.MainApplicantDetails.ApplicantShareHolderPercentage;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSourceOfIncome = v.ApplicationApplicants.MainApplicantDetails.ApplicantSourceOfIncome;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSourceOfIncome1 = v.ApplicationApplicants.MainApplicantDetails.ApplicantSourceOfIncome1;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSourceOfIncome2 = v.ApplicationApplicants.MainApplicantDetails.ApplicantSourceOfIncome2;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSouthAfricanBank = v.ApplicationApplicants.MainApplicantDetails.ApplicantSouthAfricanBank;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDBondInstitution = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDBondInstitution;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDCountryPassportIssuedId = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDCountryPassportIssuedId;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDDebitOrderResponsible = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDDebitOrderResponsible;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDEmployerSuburb = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDEmployerSuburb;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDEmployerSuburbCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDEmployerSuburbCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDEverCitixen = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDEverCitixen;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDIDXIndicator = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDIDXIndicator;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDIsSurety = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDIsSurety;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDMaintenanceIncome = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDMaintenanceIncome;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDPostalSuburb = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDPostalSuburb;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDPostalSuburbCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDPostalSuburbCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDRentalIncome = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDRentalIncome;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDResidentialSuburb = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDResidentialSuburb;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDResidentialSuburbCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDResidentialSuburbCode;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDSelfEmployedProfessionalLevel = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDSelfEmployedProfessionalLevel;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDSellingExistingProperty = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDSellingExistingProperty;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDSmokerStatus = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDSmokerStatus;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDSourceOfIncomeAmount = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDSourceOfIncomeAmount;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDSourceOfIncomeAmount1 = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDSourceOfIncomeAmount1;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDSourceOfIncomeAmount2 = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDSourceOfIncomeAmount2;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSTDTypeOfPermit = v.ApplicationApplicants.MainApplicantDetails.ApplicantSTDTypeOfPermit;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantSurname = v.ApplicationApplicants.MainApplicantDetails.ApplicantSurname;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTempResident = v.ApplicationApplicants.MainApplicantDetails.ApplicantTempResident;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTempResidentPermitExpiry = v.ApplicationApplicants.MainApplicantDetails.ApplicantTempResidentPermitExpiry;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTempResidentPermitNo = v.ApplicationApplicants.MainApplicantDetails.ApplicantTempResidentPermitNo;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantTitle = v.ApplicationApplicants.MainApplicantDetails.ApplicantTitle;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantWorkPhone = v.ApplicationApplicants.MainApplicantDetails.ApplicantWorkPhone;

            request.ApplicationApplicants.MainApplicantDetails.ApplicantWorkPhoneCode = v.ApplicationApplicants.MainApplicantDetails.ApplicantWorkPhoneCode;

            request.ApplicationDetails.ApplicationAgentName = v.ApplicationDetails.ApplicationAgentName;

            request.ApplicationDetails.ApplicationAIPBanks = v.ApplicationDetails.ApplicationAIPBanks;

            request.ApplicationDetails.ApplicationAreaOfLand = v.ApplicationDetails.ApplicationAreaOfLand;

            request.ApplicationDetails.ApplicationBondAmount = v.ApplicationDetails.ApplicationBondAmount;

            request.ApplicationDetails.ApplicationCollateralAmount = v.ApplicationDetails.ApplicationCollateralAmount;

            request.ApplicationDetails.ApplicationCollateralType = v.ApplicationDetails.ApplicationCollateralType;

            request.ApplicationDetails.ApplicationComplexName = v.ApplicationDetails.ApplicationComplexName;

            request.ApplicationDetails.ApplicationComplexType = v.ApplicationDetails.ApplicationComplexType;

            request.ApplicationDetails.ApplicationConsentClause1 = v.ApplicationDetails.ApplicationConsentClause1;

            request.ApplicationDetails.ApplicationConsentClause2 = v.ApplicationDetails.ApplicationConsentClause2;

            request.ApplicationDetails.ApplicationConsentClause3 = v.ApplicationDetails.ApplicationConsentClause3;

            request.ApplicationDetails.ApplicationConsentClause4 = v.ApplicationDetails.ApplicationConsentClause4;

            request.ApplicationDetails.ApplicationCorrespondenceTitle = v.ApplicationDetails.ApplicationCorrespondenceTitle;

            request.ApplicationDetails.ApplicationDebitAccountInstitution = v.ApplicationDetails.ApplicationDebitAccountInstitution;

            request.ApplicationDetails.ApplicationDebitAccountNo = v.ApplicationDetails.ApplicationDebitAccountNo;

            request.ApplicationDetails.ApplicationDebitAccountType = v.ApplicationDetails.ApplicationDebitAccountType;

            request.ApplicationDetails.ApplicationDeclinedBanks = v.ApplicationDetails.ApplicationDeclinedBanks;

            request.ApplicationDetails.ApplicationDomicileBranch = v.ApplicationDetails.ApplicationDomicileBranch;

            request.ApplicationDetails.ApplicationDomicileBranchCode = v.ApplicationDetails.ApplicationDomicileBranchCode;

            request.ApplicationDetails.ApplicationEstateAgency = v.ApplicationDetails.ApplicationEstateAgency;

            request.ApplicationDetails.ApplicationExistingSTDHomeLoan = v.ApplicationDetails.ApplicationExistingSTDHomeLoan;

            request.ApplicationDetails.ApplicationExistingSTDHomeLoanAccountNo = v.ApplicationDetails.ApplicationExistingSTDHomeLoanAccountNo;

            request.ApplicationDetails.ApplicationFirstPropertyPurchase = v.ApplicationDetails.ApplicationFirstPropertyPurchase;

            request.ApplicationDetails.ApplicationGarageBayNo = v.ApplicationDetails.ApplicationGarageBayNo;

            request.ApplicationDetails.ApplicationInitFeePaymentOption = v.ApplicationDetails.ApplicationInitFeePaymentOption;

            request.ApplicationDetails.ApplicationInstalmentMethod = v.ApplicationDetails.ApplicationInstalmentMethod;

            request.ApplicationDetails.ApplicationJumpStartOption = v.ApplicationDetails.ApplicationJumpStartOption;

            request.ApplicationDetails.ApplicationLoanAmountRequired = v.ApplicationDetails.ApplicationLoanAmountRequired;

            request.ApplicationDetails.ApplicationLoanProtectionPlan = v.ApplicationDetails.ApplicationLoanProtectionPlan;

            request.ApplicationDetails.ApplicationLoanReason = v.ApplicationDetails.ApplicationLoanReason;

            request.ApplicationDetails.ApplicationLoanType = v.ApplicationDetails.ApplicationLoanType;

            request.ApplicationDetails.ApplicationManagingAgentDetails = v.ApplicationDetails.ApplicationManagingAgentDetails;

            request.ApplicationDetails.ApplicationManagingAgentPhoneCode = v.ApplicationDetails.ApplicationManagingAgentPhoneCode;

            request.ApplicationDetails.ApplicationManagingAgentPhoneNo = v.ApplicationDetails.ApplicationManagingAgentPhoneNo;

            request.ApplicationDetails.ApplicationNamePropertyRegistered = v.ApplicationDetails.ApplicationNamePropertyRegistered;

            request.ApplicationDetails.ApplicationNetwork = v.ApplicationDetails.ApplicationNetwork;

            request.ApplicationDetails.ApplicationOriginatorName = v.ApplicationDetails.ApplicationOriginatorName;

            request.ApplicationDetails.ApplicationOtherLoanAmount = v.ApplicationDetails.ApplicationOtherLoanAmount;

            request.ApplicationDetails.ApplicationOtherLoanInstallment = v.ApplicationDetails.ApplicationOtherLoanInstallment;

            request.ApplicationDetails.ApplicationParkingBayNo = v.ApplicationDetails.ApplicationParkingBayNo;

            request.ApplicationDetails.ApplicationPortionNo = v.ApplicationDetails.ApplicationPortionNo;

            request.ApplicationDetails.ApplicationPropertyAddressCity = v.ApplicationDetails.ApplicationPropertyAddressCity;

            request.ApplicationDetails.ApplicationPropertyContactName = v.ApplicationDetails.ApplicationPropertyContactName;

            request.ApplicationDetails.ApplicationPropertyContactTelCode = v.ApplicationDetails.ApplicationPropertyContactTelCode;

            request.ApplicationDetails.ApplicationPropertyContactTelNo = v.ApplicationDetails.ApplicationPropertyContactTelNo;

            request.ApplicationDetails.ApplicationPropertyPurchaseDate = v.ApplicationDetails.ApplicationPropertyPurchaseDate;

            request.ApplicationDetails.ApplicationPropertyPurchasePrice = v.ApplicationDetails.ApplicationPropertyPurchasePrice;

            request.ApplicationDetails.ApplicationPropertyRoofConstruction = v.ApplicationDetails.ApplicationPropertyRoofConstruction;

            request.ApplicationDetails.ApplicationPropertyStreetName = v.ApplicationDetails.ApplicationPropertyStreetName;

            request.ApplicationDetails.ApplicationSectionalTitleUnitNo = v.ApplicationDetails.ApplicationSectionalTitleUnitNo;

            request.ApplicationDetails.ApplicationSellerIDNo = v.ApplicationDetails.ApplicationSellerIDNo;

            request.ApplicationDetails.ApplicationSellerName = v.ApplicationDetails.ApplicationSellerName;

            request.ApplicationDetails.ApplicationStandErfNo = v.ApplicationDetails.ApplicationStandErfNo;

            request.ApplicationDetails.ApplicationSTDAccountHolder = v.ApplicationDetails.ApplicationSTDAccountHolder;

            request.ApplicationDetails.ApplicationSTDBondAttorney = v.ApplicationDetails.ApplicationSTDBondAttorney;

            request.ApplicationDetails.ApplicationSTDDebitAccountBranch = v.ApplicationDetails.ApplicationSTDDebitAccountBranch;

            request.ApplicationDetails.ApplicationSTDDebitAccountBranchCode = v.ApplicationDetails.ApplicationSTDDebitAccountBranchCode;

            request.ApplicationDetails.ApplicationSTDDomicleAddress1 = v.ApplicationDetails.ApplicationSTDDomicleAddress1;

            request.ApplicationDetails.ApplicationSTDDomicleAddress2 = v.ApplicationDetails.ApplicationSTDDomicleAddress2;

            request.ApplicationDetails.ApplicationSTDDomicleDeliveryMethod = v.ApplicationDetails.ApplicationSTDDomicleDeliveryMethod;

            request.ApplicationDetails.ApplicationSTDDomiclePaymentDay = v.ApplicationDetails.ApplicationSTDDomiclePaymentDay;

            request.ApplicationDetails.ApplicationSTDDomicleSuburb = v.ApplicationDetails.ApplicationSTDDomicleSuburb;

            request.ApplicationDetails.ApplicationSTDDomicleSuburbCode = v.ApplicationDetails.ApplicationSTDDomicleSuburbCode;

            request.ApplicationDetails.ApplicationSTDEmailAddress = v.ApplicationDetails.ApplicationSTDEmailAddress;

            request.ApplicationDetails.ApplicationSTDIntendedUseOfAccount = v.ApplicationDetails.ApplicationSTDIntendedUseOfAccount;

            request.ApplicationDetails.ApplicationSTDPropertyCurrentlyBonded = v.ApplicationDetails.ApplicationSTDPropertyCurrentlyBonded;

            request.ApplicationDetails.ApplicationSTDPropertySuburb = v.ApplicationDetails.ApplicationSTDPropertySuburb;

            request.ApplicationDetails.ApplicationSTDPropertySuburbCode = v.ApplicationDetails.ApplicationSTDPropertySuburbCode;

            request.ApplicationDetails.ApplicationSTDPropertyUse = v.ApplicationDetails.ApplicationSTDPropertyUse;

            request.ApplicationDetails.ApplicationSTDTransferAttorney = v.ApplicationDetails.ApplicationSTDTransferAttorney;

            request.ApplicationDetails.ApplicationSTDTypeOfApplication = v.ApplicationDetails.ApplicationSTDTypeOfApplication;

            request.ApplicationDetails.ApplicationSTDTypeOfLoan = v.ApplicationDetails.ApplicationSTDTypeOfLoan;

            request.ApplicationDetails.ApplicationSTDTypeOfProperty = v.ApplicationDetails.ApplicationSTDTypeOfProperty;

            request.ApplicationDetails.ApplicationSTDVendorChannel = v.ApplicationDetails.ApplicationSTDVendorChannel;

            request.ApplicationDetails.ApplicationSTDVendorCode = v.ApplicationDetails.ApplicationSTDVendorCode;

            request.ApplicationDetails.ApplicationSTDVendorDescription = v.ApplicationDetails.ApplicationSTDVendorDescription;

            request.ApplicationDetails.ApplicationSTDVendorUser = v.ApplicationDetails.ApplicationSTDVendorUser;

            request.ApplicationDetails.ApplicationSubmittingBanks = v.ApplicationDetails.ApplicationSubmittingBanks;

            request.ApplicationDetails.ApplicationSuretyAmount = v.ApplicationDetails.ApplicationSuretyAmount;

            request.ApplicationDetails.ApplicationSuretyName = v.ApplicationDetails.ApplicationSuretyName;

            request.ApplicationDetails.ApplicationSuretyType = v.ApplicationDetails.ApplicationSuretyType;

            request.ApplicationDetails.ApplicationTermOfLoan = v.ApplicationDetails.ApplicationTermOfLoan;

            request.ApplicationDetails.ApplicationTypeOfRate = v.ApplicationDetails.ApplicationTypeOfRate;

            return request;
        }
    }

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("SubmitApplication.Request", Namespace = "", IsNullable = false)]
    public partial class SubmitApplicationRequest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Service.Header")]
        public RequestServiceHeader ServiceHeader { get; set; }

    }


}
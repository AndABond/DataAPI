using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortageDataSwitch.Models.SubmitService
{
    public static class FnbApplicationRequest
    {

        /// <remarks/>        
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationDetails
        {

            private string applicationAgencyFaxField;

            private string applicationAgentNameField;

            private string applicationAIPBanksField;

            private string applicationApplicantYearOfPurchaseField;

            private string applicationBondAmountToBeRegisteredField;

            private string applicationBrandTypeField;

            private string applicationCollateralSecurityField;

            private string applicationComplexNameField;

            private string applicationConsultantCellphoneField;

            private string applicationConsultantFaxNoField;

            private string applicationConsultantFirstNameField;

            private string applicationConsultantSurnameField;

            private string applicationDebitAccountBranchField;

            private string applicationDebitAccountBranchCodeField;

            private string applicationDebitAccountInstitutionField;

            private string applicationDebitAccountNameField;

            private string applicationDebitAccountNoField;

            private string applicationDebitAccountTypeField;

            private string applicationDeclinedBanksField;

            private string applicationDepositCashField;

            private string applicationDepositOtherField;

            private string applicationDwellingPurposeField;

            private string applicationEstateAgencyField;

            private string applicationFirstPropertyPurchaseField;

            private string applicationFNBBondAccountNumberField;

            private string applicationFNBBondAttorneyField;

            private string applicationFNBBondFreeField;

            private string applicationFNBBondHolderNameField;

            private string applicationFNBBondInstitutionBranchNameField;

            private string applicationFNBBondInstitutionNameField;

            private string applicationFNBDirectorsField;

            private string applicationFNBFutureChoiceRegistrationAmountField;

            private string applicationFNBFuturePostalAddressCountryField;

            private string applicationFNBHFVendorCodeField;

            private string applicationFNBHFVendorDescriptionField;

            private string applicationFNBILPNumberField;

            private string applicationFNBIsDevelopmentField;

            private string applicationFNBLoanTypeField;

            private string applicationFNBMoveHomeNotHomeloanIdField;

            private string applicationFNBNumberofStakeholdersField;

            private string applicationFNBPropertyHoldingIdField;

            private string applicationFNBSubPropertyTypeField;

            private string applicationFNBSwitchingBondRegisteredAmountField;

            private string applicationFNBSwitchingTypeIdField;

            private string applicationFNBTransferAttorneyField;

            private string applicationFNBTypeOfApplicationField;

            private string applicationFNBTypeOfPropertyField;

            private string applicationFNBVendorDescriptionField;

            private string applicationFutureChoicePrincipleAmountField;

            private string applicationFuturePostalAddress1Field;

            private string applicationFuturePostalAddressCityField;

            private string applicationFuturePostalAddressCodeField;

            private string applicationFuturePostalAddressSuburbField;

            private string applicationGenericLoanTypeField;

            private string applicationIncludeBondTransferCostsField;

            private string applicationInstalmentMethodField;

            private string applicationInterestPeriodField;

            private string applicationIsTrustCompanyCCField;

            private string applicationLoanAmountRequiredField;

            private string applicationMonthlyRepaymentsField;

            private string applicationNamePropertyRegisteredField;

            private string applicationNetworkField;

            private string applicationOfferToPurchaseDateField;

            private string applicationOneAccountConvertChequeField;

            private string applicationOneAccountConvertChequeAccountNumberField;

            private string applicationOneAccountConvertILPField;

            private string applicationOriginatorEmailField;

            private string applicationPortionNoField;

            private string applicationPrevMortgagePeriodField;

            private string applicationProcessingBranchField;

            private string applicationPropertyAddressCityField;

            private string applicationPropertyAddressSuburbField;

            private string applicationPropertyContactCellphoneField;

            private string applicationPropertyContactNameField;

            private string applicationPropertyContactTelCodeField;

            private string applicationPropertyContactTelNoField;

            private string applicationPropertyPostalCodeField;

            private string applicationPropertyProvinceField;

            private string applicationPropertyPurchasePriceField;

            private string applicationPropertyRightField;

            private string applicationPropertyStreetNameField;

            private string applicationPropertyStreetNoField;

            private string applicationSectionalTitleUnitNoField;

            private string applicationSectionNoField;

            private string applicationSecurityBondsField;

            private string applicationStandErfNoField;

            private string applicationSubmittingBanksField;

            private string applicationSuretyshipField;

            private string applicationTermOfLoanField;

            private string applicationTypeOfBondField;

            private string applicationTypeOfInterestField;

            private string applicationTypeOfOfferField;

            private string applicationTypeOfStreetField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.AgencyFax")]
            public string ApplicationAgencyFax
            {
                get
                {
                    return this.applicationAgencyFaxField;
                }
                set
                {
                    this.applicationAgencyFaxField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.AgentName")]
            public string ApplicationAgentName
            {
                get
                {
                    return this.applicationAgentNameField;
                }
                set
                {
                    this.applicationAgentNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.AIPBanks")]
            public string ApplicationAIPBanks
            {
                get
                {
                    return this.applicationAIPBanksField;
                }
                set
                {
                    this.applicationAIPBanksField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.ApplicantYearOfPurchase")]
            public string ApplicationApplicantYearOfPurchase
            {
                get
                {
                    return this.applicationApplicantYearOfPurchaseField;
                }
                set
                {
                    this.applicationApplicantYearOfPurchaseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.BondAmountToBeRegistered")]
            public string ApplicationBondAmountToBeRegistered
            {
                get
                {
                    return this.applicationBondAmountToBeRegisteredField;
                }
                set
                {
                    this.applicationBondAmountToBeRegisteredField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.BrandType")]
            public string ApplicationBrandType
            {
                get
                {
                    return this.applicationBrandTypeField;
                }
                set
                {
                    this.applicationBrandTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.CollateralSecurity")]
            public string ApplicationCollateralSecurity
            {
                get
                {
                    return this.applicationCollateralSecurityField;
                }
                set
                {
                    this.applicationCollateralSecurityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.ComplexName")]
            public string ApplicationComplexName
            {
                get
                {
                    return this.applicationComplexNameField;
                }
                set
                {
                    this.applicationComplexNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.ConsultantCellphone")]
            public string ApplicationConsultantCellphone
            {
                get
                {
                    return this.applicationConsultantCellphoneField;
                }
                set
                {
                    this.applicationConsultantCellphoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.ConsultantFaxNo")]
            public string ApplicationConsultantFaxNo
            {
                get
                {
                    return this.applicationConsultantFaxNoField;
                }
                set
                {
                    this.applicationConsultantFaxNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.ConsultantFirstName")]
            public string ApplicationConsultantFirstName
            {
                get
                {
                    return this.applicationConsultantFirstNameField;
                }
                set
                {
                    this.applicationConsultantFirstNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.ConsultantSurname")]
            public string ApplicationConsultantSurname
            {
                get
                {
                    return this.applicationConsultantSurnameField;
                }
                set
                {
                    this.applicationConsultantSurnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.DebitAccountBranch")]
            public string ApplicationDebitAccountBranch
            {
                get
                {
                    return this.applicationDebitAccountBranchField;
                }
                set
                {
                    this.applicationDebitAccountBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.DebitAccountBranchCode")]
            public string ApplicationDebitAccountBranchCode
            {
                get
                {
                    return this.applicationDebitAccountBranchCodeField;
                }
                set
                {
                    this.applicationDebitAccountBranchCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.DebitAccountInstitution")]
            public string ApplicationDebitAccountInstitution
            {
                get
                {
                    return this.applicationDebitAccountInstitutionField;
                }
                set
                {
                    this.applicationDebitAccountInstitutionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.DebitAccountName")]
            public string ApplicationDebitAccountName
            {
                get
                {
                    return this.applicationDebitAccountNameField;
                }
                set
                {
                    this.applicationDebitAccountNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.DebitAccountNo")]
            public string ApplicationDebitAccountNo
            {
                get
                {
                    return this.applicationDebitAccountNoField;
                }
                set
                {
                    this.applicationDebitAccountNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.DebitAccountType")]
            public string ApplicationDebitAccountType
            {
                get
                {
                    return this.applicationDebitAccountTypeField;
                }
                set
                {
                    this.applicationDebitAccountTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.DeclinedBanks")]
            public string ApplicationDeclinedBanks
            {
                get
                {
                    return this.applicationDeclinedBanksField;
                }
                set
                {
                    this.applicationDeclinedBanksField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.DepositCash")]
            public string ApplicationDepositCash
            {
                get
                {
                    return this.applicationDepositCashField;
                }
                set
                {
                    this.applicationDepositCashField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.DepositOther")]
            public string ApplicationDepositOther
            {
                get
                {
                    return this.applicationDepositOtherField;
                }
                set
                {
                    this.applicationDepositOtherField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.DwellingPurpose")]
            public string ApplicationDwellingPurpose
            {
                get
                {
                    return this.applicationDwellingPurposeField;
                }
                set
                {
                    this.applicationDwellingPurposeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.EstateAgency")]
            public string ApplicationEstateAgency
            {
                get
                {
                    return this.applicationEstateAgencyField;
                }
                set
                {
                    this.applicationEstateAgencyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FirstPropertyPurchase")]
            public string ApplicationFirstPropertyPurchase
            {
                get
                {
                    return this.applicationFirstPropertyPurchaseField;
                }
                set
                {
                    this.applicationFirstPropertyPurchaseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBBondAccountNumber")]
            public string ApplicationFNBBondAccountNumber
            {
                get
                {
                    return this.applicationFNBBondAccountNumberField;
                }
                set
                {
                    this.applicationFNBBondAccountNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBBondAttorney")]
            public string ApplicationFNBBondAttorney
            {
                get
                {
                    return this.applicationFNBBondAttorneyField;
                }
                set
                {
                    this.applicationFNBBondAttorneyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBBondFree")]
            public string ApplicationFNBBondFree
            {
                get
                {
                    return this.applicationFNBBondFreeField;
                }
                set
                {
                    this.applicationFNBBondFreeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBBondHolderName")]
            public string ApplicationFNBBondHolderName
            {
                get
                {
                    return this.applicationFNBBondHolderNameField;
                }
                set
                {
                    this.applicationFNBBondHolderNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBBondInstitutionBranchName")]
            public string ApplicationFNBBondInstitutionBranchName
            {
                get
                {
                    return this.applicationFNBBondInstitutionBranchNameField;
                }
                set
                {
                    this.applicationFNBBondInstitutionBranchNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBBondInstitutionName")]
            public string ApplicationFNBBondInstitutionName
            {
                get
                {
                    return this.applicationFNBBondInstitutionNameField;
                }
                set
                {
                    this.applicationFNBBondInstitutionNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBDirectors")]
            public string ApplicationFNBDirectors
            {
                get
                {
                    return this.applicationFNBDirectorsField;
                }
                set
                {
                    this.applicationFNBDirectorsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBFutureChoiceRegistrationAmount")]
            public string ApplicationFNBFutureChoiceRegistrationAmount
            {
                get
                {
                    return this.applicationFNBFutureChoiceRegistrationAmountField;
                }
                set
                {
                    this.applicationFNBFutureChoiceRegistrationAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBFuturePostalAddressCountry")]
            public string ApplicationFNBFuturePostalAddressCountry
            {
                get
                {
                    return this.applicationFNBFuturePostalAddressCountryField;
                }
                set
                {
                    this.applicationFNBFuturePostalAddressCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBHFVendorCode")]
            public string ApplicationFNBHFVendorCode
            {
                get
                {
                    return this.applicationFNBHFVendorCodeField;
                }
                set
                {
                    this.applicationFNBHFVendorCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBHFVendorDescription")]
            public string ApplicationFNBHFVendorDescription
            {
                get
                {
                    return this.applicationFNBHFVendorDescriptionField;
                }
                set
                {
                    this.applicationFNBHFVendorDescriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBILPNumber")]
            public string ApplicationFNBILPNumber
            {
                get
                {
                    return this.applicationFNBILPNumberField;
                }
                set
                {
                    this.applicationFNBILPNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBIsDevelopment")]
            public string ApplicationFNBIsDevelopment
            {
                get
                {
                    return this.applicationFNBIsDevelopmentField;
                }
                set
                {
                    this.applicationFNBIsDevelopmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBLoanType")]
            public string ApplicationFNBLoanType
            {
                get
                {
                    return this.applicationFNBLoanTypeField;
                }
                set
                {
                    this.applicationFNBLoanTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBMoveHomeNotHomeloanId")]
            public string ApplicationFNBMoveHomeNotHomeloanId
            {
                get
                {
                    return this.applicationFNBMoveHomeNotHomeloanIdField;
                }
                set
                {
                    this.applicationFNBMoveHomeNotHomeloanIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBNumberofStakeholders")]
            public string ApplicationFNBNumberofStakeholders
            {
                get
                {
                    return this.applicationFNBNumberofStakeholdersField;
                }
                set
                {
                    this.applicationFNBNumberofStakeholdersField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBPropertyHoldingId")]
            public string ApplicationFNBPropertyHoldingId
            {
                get
                {
                    return this.applicationFNBPropertyHoldingIdField;
                }
                set
                {
                    this.applicationFNBPropertyHoldingIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBSubPropertyType")]
            public string ApplicationFNBSubPropertyType
            {
                get
                {
                    return this.applicationFNBSubPropertyTypeField;
                }
                set
                {
                    this.applicationFNBSubPropertyTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBSwitchingBondRegisteredAmount")]
            public string ApplicationFNBSwitchingBondRegisteredAmount
            {
                get
                {
                    return this.applicationFNBSwitchingBondRegisteredAmountField;
                }
                set
                {
                    this.applicationFNBSwitchingBondRegisteredAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBSwitchingTypeId")]
            public string ApplicationFNBSwitchingTypeId
            {
                get
                {
                    return this.applicationFNBSwitchingTypeIdField;
                }
                set
                {
                    this.applicationFNBSwitchingTypeIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBTransferAttorney")]
            public string ApplicationFNBTransferAttorney
            {
                get
                {
                    return this.applicationFNBTransferAttorneyField;
                }
                set
                {
                    this.applicationFNBTransferAttorneyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBTypeOfApplication")]
            public string ApplicationFNBTypeOfApplication
            {
                get
                {
                    return this.applicationFNBTypeOfApplicationField;
                }
                set
                {
                    this.applicationFNBTypeOfApplicationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBTypeOfProperty")]
            public string ApplicationFNBTypeOfProperty
            {
                get
                {
                    return this.applicationFNBTypeOfPropertyField;
                }
                set
                {
                    this.applicationFNBTypeOfPropertyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FNBVendorDescription")]
            public string ApplicationFNBVendorDescription
            {
                get
                {
                    return this.applicationFNBVendorDescriptionField;
                }
                set
                {
                    this.applicationFNBVendorDescriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FutureChoicePrincipleAmount")]
            public string ApplicationFutureChoicePrincipleAmount
            {
                get
                {
                    return this.applicationFutureChoicePrincipleAmountField;
                }
                set
                {
                    this.applicationFutureChoicePrincipleAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FuturePostalAddress1")]
            public string ApplicationFuturePostalAddress1
            {
                get
                {
                    return this.applicationFuturePostalAddress1Field;
                }
                set
                {
                    this.applicationFuturePostalAddress1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FuturePostalAddressCity")]
            public string ApplicationFuturePostalAddressCity
            {
                get
                {
                    return this.applicationFuturePostalAddressCityField;
                }
                set
                {
                    this.applicationFuturePostalAddressCityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FuturePostalAddressCode")]
            public string ApplicationFuturePostalAddressCode
            {
                get
                {
                    return this.applicationFuturePostalAddressCodeField;
                }
                set
                {
                    this.applicationFuturePostalAddressCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.FuturePostalAddressSuburb")]
            public string ApplicationFuturePostalAddressSuburb
            {
                get
                {
                    return this.applicationFuturePostalAddressSuburbField;
                }
                set
                {
                    this.applicationFuturePostalAddressSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.GenericLoanType")]
            public string ApplicationGenericLoanType
            {
                get
                {
                    return this.applicationGenericLoanTypeField;
                }
                set
                {
                    this.applicationGenericLoanTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.IncludeBondTransferCosts")]
            public string ApplicationIncludeBondTransferCosts
            {
                get
                {
                    return this.applicationIncludeBondTransferCostsField;
                }
                set
                {
                    this.applicationIncludeBondTransferCostsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.InstalmentMethod")]
            public string ApplicationInstalmentMethod
            {
                get
                {
                    return this.applicationInstalmentMethodField;
                }
                set
                {
                    this.applicationInstalmentMethodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.InterestPeriod")]
            public string ApplicationInterestPeriod
            {
                get
                {
                    return this.applicationInterestPeriodField;
                }
                set
                {
                    this.applicationInterestPeriodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.IsTrustCompanyCC")]
            public string ApplicationIsTrustCompanyCC
            {
                get
                {
                    return this.applicationIsTrustCompanyCCField;
                }
                set
                {
                    this.applicationIsTrustCompanyCCField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.LoanAmountRequired")]
            public string ApplicationLoanAmountRequired
            {
                get
                {
                    return this.applicationLoanAmountRequiredField;
                }
                set
                {
                    this.applicationLoanAmountRequiredField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.MonthlyRepayments")]
            public string ApplicationMonthlyRepayments
            {
                get
                {
                    return this.applicationMonthlyRepaymentsField;
                }
                set
                {
                    this.applicationMonthlyRepaymentsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.NamePropertyRegistered")]
            public string ApplicationNamePropertyRegistered
            {
                get
                {
                    return this.applicationNamePropertyRegisteredField;
                }
                set
                {
                    this.applicationNamePropertyRegisteredField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.Network")]
            public string ApplicationNetwork
            {
                get
                {
                    return this.applicationNetworkField;
                }
                set
                {
                    this.applicationNetworkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.OfferToPurchaseDate")]
            public string ApplicationOfferToPurchaseDate
            {
                get
                {
                    return this.applicationOfferToPurchaseDateField;
                }
                set
                {
                    this.applicationOfferToPurchaseDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.OneAccountConvertCheque")]
            public string ApplicationOneAccountConvertCheque
            {
                get
                {
                    return this.applicationOneAccountConvertChequeField;
                }
                set
                {
                    this.applicationOneAccountConvertChequeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.OneAccountConvertChequeAccountNumber")]
            public string ApplicationOneAccountConvertChequeAccountNumber
            {
                get
                {
                    return this.applicationOneAccountConvertChequeAccountNumberField;
                }
                set
                {
                    this.applicationOneAccountConvertChequeAccountNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.OneAccountConvertILP")]
            public string ApplicationOneAccountConvertILP
            {
                get
                {
                    return this.applicationOneAccountConvertILPField;
                }
                set
                {
                    this.applicationOneAccountConvertILPField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.OriginatorEmail")]
            public string ApplicationOriginatorEmail
            {
                get
                {
                    return this.applicationOriginatorEmailField;
                }
                set
                {
                    this.applicationOriginatorEmailField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PortionNo")]
            public string ApplicationPortionNo
            {
                get
                {
                    return this.applicationPortionNoField;
                }
                set
                {
                    this.applicationPortionNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PrevMortgagePeriod")]
            public string ApplicationPrevMortgagePeriod
            {
                get
                {
                    return this.applicationPrevMortgagePeriodField;
                }
                set
                {
                    this.applicationPrevMortgagePeriodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.ProcessingBranch")]
            public string ApplicationProcessingBranch
            {
                get
                {
                    return this.applicationProcessingBranchField;
                }
                set
                {
                    this.applicationProcessingBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyAddressCity")]
            public string ApplicationPropertyAddressCity
            {
                get
                {
                    return this.applicationPropertyAddressCityField;
                }
                set
                {
                    this.applicationPropertyAddressCityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyAddressSuburb")]
            public string ApplicationPropertyAddressSuburb
            {
                get
                {
                    return this.applicationPropertyAddressSuburbField;
                }
                set
                {
                    this.applicationPropertyAddressSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyContactCellphone")]
            public string ApplicationPropertyContactCellphone
            {
                get
                {
                    return this.applicationPropertyContactCellphoneField;
                }
                set
                {
                    this.applicationPropertyContactCellphoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyContactName")]
            public string ApplicationPropertyContactName
            {
                get
                {
                    return this.applicationPropertyContactNameField;
                }
                set
                {
                    this.applicationPropertyContactNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyContactTelCode")]
            public string ApplicationPropertyContactTelCode
            {
                get
                {
                    return this.applicationPropertyContactTelCodeField;
                }
                set
                {
                    this.applicationPropertyContactTelCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyContactTelNo")]
            public string ApplicationPropertyContactTelNo
            {
                get
                {
                    return this.applicationPropertyContactTelNoField;
                }
                set
                {
                    this.applicationPropertyContactTelNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyPostalCode")]
            public string ApplicationPropertyPostalCode
            {
                get
                {
                    return this.applicationPropertyPostalCodeField;
                }
                set
                {
                    this.applicationPropertyPostalCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyProvince")]
            public string ApplicationPropertyProvince
            {
                get
                {
                    return this.applicationPropertyProvinceField;
                }
                set
                {
                    this.applicationPropertyProvinceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyPurchasePrice")]
            public string ApplicationPropertyPurchasePrice
            {
                get
                {
                    return this.applicationPropertyPurchasePriceField;
                }
                set
                {
                    this.applicationPropertyPurchasePriceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyRight")]
            public string ApplicationPropertyRight
            {
                get
                {
                    return this.applicationPropertyRightField;
                }
                set
                {
                    this.applicationPropertyRightField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyStreetName")]
            public string ApplicationPropertyStreetName
            {
                get
                {
                    return this.applicationPropertyStreetNameField;
                }
                set
                {
                    this.applicationPropertyStreetNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyStreetNo")]
            public string ApplicationPropertyStreetNo
            {
                get
                {
                    return this.applicationPropertyStreetNoField;
                }
                set
                {
                    this.applicationPropertyStreetNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.SectionalTitleUnitNo")]
            public string ApplicationSectionalTitleUnitNo
            {
                get
                {
                    return this.applicationSectionalTitleUnitNoField;
                }
                set
                {
                    this.applicationSectionalTitleUnitNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.SectionNo")]
            public string ApplicationSectionNo
            {
                get
                {
                    return this.applicationSectionNoField;
                }
                set
                {
                    this.applicationSectionNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.SecurityBonds")]
            public string ApplicationSecurityBonds
            {
                get
                {
                    return this.applicationSecurityBondsField;
                }
                set
                {
                    this.applicationSecurityBondsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.StandErfNo")]
            public string ApplicationStandErfNo
            {
                get
                {
                    return this.applicationStandErfNoField;
                }
                set
                {
                    this.applicationStandErfNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.SubmittingBanks")]
            public string ApplicationSubmittingBanks
            {
                get
                {
                    return this.applicationSubmittingBanksField;
                }
                set
                {
                    this.applicationSubmittingBanksField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.Suretyship")]
            public string ApplicationSuretyship
            {
                get
                {
                    return this.applicationSuretyshipField;
                }
                set
                {
                    this.applicationSuretyshipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.TermOfLoan")]
            public string ApplicationTermOfLoan
            {
                get
                {
                    return this.applicationTermOfLoanField;
                }
                set
                {
                    this.applicationTermOfLoanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.TypeOfBond")]
            public string ApplicationTypeOfBond
            {
                get
                {
                    return this.applicationTypeOfBondField;
                }
                set
                {
                    this.applicationTypeOfBondField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.TypeOfInterest")]
            public string ApplicationTypeOfInterest
            {
                get
                {
                    return this.applicationTypeOfInterestField;
                }
                set
                {
                    this.applicationTypeOfInterestField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.TypeOfOffer")]
            public string ApplicationTypeOfOffer
            {
                get
                {
                    return this.applicationTypeOfOfferField;
                }
                set
                {
                    this.applicationTypeOfOfferField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.TypeOfStreet")]
            public string ApplicationTypeOfStreet
            {
                get
                {
                    return this.applicationTypeOfStreetField;
                }
                set
                {
                    this.applicationTypeOfStreetField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicants
        {

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetails mainApplicantDetailsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetails coApplicantDetailsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Main.Applicant.Details")]
            public SubmitApplicationRequestApplicationApplicantsMainApplicantDetails MainApplicantDetails
            {
                get
                {
                    return this.mainApplicantDetailsField;
                }
                set
                {
                    this.mainApplicantDetailsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Co.Applicant.Details")]
            public SubmitApplicationRequestApplicationApplicantsCoApplicantDetails CoApplicantDetails
            {
                get
                {
                    return this.coApplicantDetailsField;
                }
                set
                {
                    this.coApplicantDetailsField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsMainApplicantDetails
        {

            private string applicantCellphoneField;

            private string applicantCorrespondenceLanguageField;

            private string applicantCountryOfBirthField;

            private string applicantCountryPermitIssuedField;

            private string applicantDateJoinedEmployerField;

            private string applicantDateOfBirthField;

            private string applicantDatePassportExpiresField;

            private string applicantDateRehabilitatedField;

            private string applicantDateWorkContractExpiresField;

            private string applicantDateWorkContractIssuedField;

            private string applicantDeclaredInsolventField;

            private string applicantEmailAddressField;

            private string applicantEmployeeStatusField;

            private string applicantEmployerNameField;

            private string applicantEmployerOperatingYearsField;

            private string applicantEthnicGroupField;

            private string applicantFaxCodeField;

            private string applicantFaxNoField;

            private string applicantFirstNameField;

            private string applicantFNBCityOfBirthField;

            private string applicantFNBClientField;

            private string applicantFNBCountryOfCitizenshipField;

            private string applicantFNBCountryOfMarriageField;

            private string applicantFNBCountryResideWorkField;

            private string applicantFNBEmploymentSectorField;

            private string applicantFNBEmploymentTypeField;

            private string applicantFNBForeignTaxNumberField;

            private string applicantFNBForeignTaxReturnIdField;

            private string applicantFNBHighestQualificationField;

            private string applicantFNBInternationalWorkAddressField;

            private string applicantFNBIsFirstRandEmployeeField;

            private string applicantFNBIsInternationalAddressField;

            private string applicantFNBMarketingConsentIdField;

            private string applicantFNBPostalAddressCountryField;

            private string applicantFNBRandEmployeeNumberField;

            private string applicantFNBResidentialAddressCountryField;

            private string applicantFNBSourceOfIncome1Field;

            private string applicantFNBSourceOfIncome2Field;

            private string applicantFNBSourceOfIncome3Field;

            private string applicantFNBSourceOfIncome4Field;

            private string applicantFNBSourceOfIncome5Field;

            private string applicantFNBTaxPayerInResidentCountryField;

            private string applicantFNBTypeOfPermitField;

            private string applicantGenderField;

            private string applicantHomePhoneField;

            private string applicantHomePhoneCodeField;

            private string applicantHouseholdSizeField;

            private string applicantIdentificationNoField;

            private string applicantIdentificationTypeField;

            private string applicantInsolventDateField;

            private string applicantJurisdictionField;

            private string applicantJurisdiction1Field;

            private string applicantJurisdiction2Field;

            private string applicantJurisdiction3Field;

            private string applicantJurisdiction4Field;

            private string applicantLifeAssuranceOptionField;

            private string applicantMaritalStatusField;

            private string applicantMarriedStatusField;

            private string applicantMayBankContactYouField;

            private string applicantMayDoCreditBureauEnquiryField;

            private string applicantNoOfDependentsField;

            private string applicantOccupationField;

            private string applicantOccupationLevelField;

            private string applicantPassportNoField;

            private string applicantPermanentResidentField;

            private string applicantPermanentResidentCountryField;

            private string applicantPermanentResidentNoField;

            private string applicantPermitIssueDateField;

            private string applicantPhysicalAddressCityField;

            private string applicantPhysicalAddressCodeField;

            private string applicantPhysicalAddressLine1Field;

            private string applicantPhysicalAddressLine2Field;

            private string applicantPhysicalAddressSuburbField;

            private string applicantPostalAddressCityField;

            private string applicantPostalAddressCodeField;

            private string applicantPostalAddressLine1Field;

            private string applicantPostalAddressLine2Field;

            private string applicantPostalAddressSuburbField;

            private string applicantPreferredContactDeliveryField;

            private string applicantPreviousEmployerNameField;

            private string applicantPreviousEmployerPeriodField;

            private string applicantRehabilitatedField;

            private string applicantRightOfRefusalConsentField;

            private string applicantSACitizenField;

            private string applicantSurnameField;

            private string applicantTaxIdentificationNumberField;

            private string applicantTaxIdentificationNumber1Field;

            private string applicantTaxIdentificationNumber2Field;

            private string applicantTaxIdentificationNumber3Field;

            private string applicantTaxIdentificationNumber4Field;

            private string applicantTaxIdentificationReasonField;

            private string applicantTaxIdentificationReason1Field;

            private string applicantTaxIdentificationReason2Field;

            private string applicantTaxIdentificationReason3Field;

            private string applicantTaxIdentificationReason4Field;

            private string applicantTempResidentField;

            private string applicantTempResidentPermitExpiryField;

            private string applicantTempResidentPermitNoField;

            private string applicantTitleField;

            private string applicantTypeOfIncomeField;

            private string applicantWorkPhoneField;

            private string applicantWorkPhoneCodeField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem[] applicantIncomeItemsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem[] applicantExpenditureItemsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount[] applicantBankAccountsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetails applicantSpouseDetailsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Cellphone")]
            public string ApplicantCellphone
            {
                get
                {
                    return this.applicantCellphoneField;
                }
                set
                {
                    this.applicantCellphoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CorrespondenceLanguage")]
            public string ApplicantCorrespondenceLanguage
            {
                get
                {
                    return this.applicantCorrespondenceLanguageField;
                }
                set
                {
                    this.applicantCorrespondenceLanguageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CountryOfBirth")]
            public string ApplicantCountryOfBirth
            {
                get
                {
                    return this.applicantCountryOfBirthField;
                }
                set
                {
                    this.applicantCountryOfBirthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CountryPermitIssued")]
            public string ApplicantCountryPermitIssued
            {
                get
                {
                    return this.applicantCountryPermitIssuedField;
                }
                set
                {
                    this.applicantCountryPermitIssuedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateJoinedEmployer")]
            public string ApplicantDateJoinedEmployer
            {
                get
                {
                    return this.applicantDateJoinedEmployerField;
                }
                set
                {
                    this.applicantDateJoinedEmployerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateOfBirth")]
            public string ApplicantDateOfBirth
            {
                get
                {
                    return this.applicantDateOfBirthField;
                }
                set
                {
                    this.applicantDateOfBirthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DatePassportExpires")]
            public string ApplicantDatePassportExpires
            {
                get
                {
                    return this.applicantDatePassportExpiresField;
                }
                set
                {
                    this.applicantDatePassportExpiresField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateRehabilitated")]
            public string ApplicantDateRehabilitated
            {
                get
                {
                    return this.applicantDateRehabilitatedField;
                }
                set
                {
                    this.applicantDateRehabilitatedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateWorkContractExpires")]
            public string ApplicantDateWorkContractExpires
            {
                get
                {
                    return this.applicantDateWorkContractExpiresField;
                }
                set
                {
                    this.applicantDateWorkContractExpiresField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateWorkContractIssued")]
            public string ApplicantDateWorkContractIssued
            {
                get
                {
                    return this.applicantDateWorkContractIssuedField;
                }
                set
                {
                    this.applicantDateWorkContractIssuedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DeclaredInsolvent")]
            public string ApplicantDeclaredInsolvent
            {
                get
                {
                    return this.applicantDeclaredInsolventField;
                }
                set
                {
                    this.applicantDeclaredInsolventField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmailAddress")]
            public string ApplicantEmailAddress
            {
                get
                {
                    return this.applicantEmailAddressField;
                }
                set
                {
                    this.applicantEmailAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployeeStatus")]
            public string ApplicantEmployeeStatus
            {
                get
                {
                    return this.applicantEmployeeStatusField;
                }
                set
                {
                    this.applicantEmployeeStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerName")]
            public string ApplicantEmployerName
            {
                get
                {
                    return this.applicantEmployerNameField;
                }
                set
                {
                    this.applicantEmployerNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerOperatingYears")]
            public string ApplicantEmployerOperatingYears
            {
                get
                {
                    return this.applicantEmployerOperatingYearsField;
                }
                set
                {
                    this.applicantEmployerOperatingYearsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EthnicGroup")]
            public string ApplicantEthnicGroup
            {
                get
                {
                    return this.applicantEthnicGroupField;
                }
                set
                {
                    this.applicantEthnicGroupField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FaxCode")]
            public string ApplicantFaxCode
            {
                get
                {
                    return this.applicantFaxCodeField;
                }
                set
                {
                    this.applicantFaxCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FaxNo")]
            public string ApplicantFaxNo
            {
                get
                {
                    return this.applicantFaxNoField;
                }
                set
                {
                    this.applicantFaxNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FirstName")]
            public string ApplicantFirstName
            {
                get
                {
                    return this.applicantFirstNameField;
                }
                set
                {
                    this.applicantFirstNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBCityOfBirth")]
            public string ApplicantFNBCityOfBirth
            {
                get
                {
                    return this.applicantFNBCityOfBirthField;
                }
                set
                {
                    this.applicantFNBCityOfBirthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBClient")]
            public string ApplicantFNBClient
            {
                get
                {
                    return this.applicantFNBClientField;
                }
                set
                {
                    this.applicantFNBClientField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBCountryOfCitizenship")]
            public string ApplicantFNBCountryOfCitizenship
            {
                get
                {
                    return this.applicantFNBCountryOfCitizenshipField;
                }
                set
                {
                    this.applicantFNBCountryOfCitizenshipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBCountryOfMarriage")]
            public string ApplicantFNBCountryOfMarriage
            {
                get
                {
                    return this.applicantFNBCountryOfMarriageField;
                }
                set
                {
                    this.applicantFNBCountryOfMarriageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBCountryResideWork")]
            public string ApplicantFNBCountryResideWork
            {
                get
                {
                    return this.applicantFNBCountryResideWorkField;
                }
                set
                {
                    this.applicantFNBCountryResideWorkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBEmploymentSector")]
            public string ApplicantFNBEmploymentSector
            {
                get
                {
                    return this.applicantFNBEmploymentSectorField;
                }
                set
                {
                    this.applicantFNBEmploymentSectorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBEmploymentType")]
            public string ApplicantFNBEmploymentType
            {
                get
                {
                    return this.applicantFNBEmploymentTypeField;
                }
                set
                {
                    this.applicantFNBEmploymentTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBForeignTaxNumber")]
            public string ApplicantFNBForeignTaxNumber
            {
                get
                {
                    return this.applicantFNBForeignTaxNumberField;
                }
                set
                {
                    this.applicantFNBForeignTaxNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBForeignTaxReturnId")]
            public string ApplicantFNBForeignTaxReturnId
            {
                get
                {
                    return this.applicantFNBForeignTaxReturnIdField;
                }
                set
                {
                    this.applicantFNBForeignTaxReturnIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBHighestQualification")]
            public string ApplicantFNBHighestQualification
            {
                get
                {
                    return this.applicantFNBHighestQualificationField;
                }
                set
                {
                    this.applicantFNBHighestQualificationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBInternationalWorkAddress")]
            public string ApplicantFNBInternationalWorkAddress
            {
                get
                {
                    return this.applicantFNBInternationalWorkAddressField;
                }
                set
                {
                    this.applicantFNBInternationalWorkAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBIsFirstRandEmployee")]
            public string ApplicantFNBIsFirstRandEmployee
            {
                get
                {
                    return this.applicantFNBIsFirstRandEmployeeField;
                }
                set
                {
                    this.applicantFNBIsFirstRandEmployeeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBIsInternationalAddress")]
            public string ApplicantFNBIsInternationalAddress
            {
                get
                {
                    return this.applicantFNBIsInternationalAddressField;
                }
                set
                {
                    this.applicantFNBIsInternationalAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBMarketingConsentId")]
            public string ApplicantFNBMarketingConsentId
            {
                get
                {
                    return this.applicantFNBMarketingConsentIdField;
                }
                set
                {
                    this.applicantFNBMarketingConsentIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBPostalAddressCountry")]
            public string ApplicantFNBPostalAddressCountry
            {
                get
                {
                    return this.applicantFNBPostalAddressCountryField;
                }
                set
                {
                    this.applicantFNBPostalAddressCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBRandEmployeeNumber")]
            public string ApplicantFNBRandEmployeeNumber
            {
                get
                {
                    return this.applicantFNBRandEmployeeNumberField;
                }
                set
                {
                    this.applicantFNBRandEmployeeNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBResidentialAddressCountry")]
            public string ApplicantFNBResidentialAddressCountry
            {
                get
                {
                    return this.applicantFNBResidentialAddressCountryField;
                }
                set
                {
                    this.applicantFNBResidentialAddressCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome1")]
            public string ApplicantFNBSourceOfIncome1
            {
                get
                {
                    return this.applicantFNBSourceOfIncome1Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome2")]
            public string ApplicantFNBSourceOfIncome2
            {
                get
                {
                    return this.applicantFNBSourceOfIncome2Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome3")]
            public string ApplicantFNBSourceOfIncome3
            {
                get
                {
                    return this.applicantFNBSourceOfIncome3Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome4")]
            public string ApplicantFNBSourceOfIncome4
            {
                get
                {
                    return this.applicantFNBSourceOfIncome4Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome4Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome5")]
            public string ApplicantFNBSourceOfIncome5
            {
                get
                {
                    return this.applicantFNBSourceOfIncome5Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome5Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBTaxPayerInResidentCountry")]
            public string ApplicantFNBTaxPayerInResidentCountry
            {
                get
                {
                    return this.applicantFNBTaxPayerInResidentCountryField;
                }
                set
                {
                    this.applicantFNBTaxPayerInResidentCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBTypeOfPermit")]
            public string ApplicantFNBTypeOfPermit
            {
                get
                {
                    return this.applicantFNBTypeOfPermitField;
                }
                set
                {
                    this.applicantFNBTypeOfPermitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Gender")]
            public string ApplicantGender
            {
                get
                {
                    return this.applicantGenderField;
                }
                set
                {
                    this.applicantGenderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HomePhone")]
            public string ApplicantHomePhone
            {
                get
                {
                    return this.applicantHomePhoneField;
                }
                set
                {
                    this.applicantHomePhoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HomePhoneCode")]
            public string ApplicantHomePhoneCode
            {
                get
                {
                    return this.applicantHomePhoneCodeField;
                }
                set
                {
                    this.applicantHomePhoneCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HouseholdSize")]
            public string ApplicantHouseholdSize
            {
                get
                {
                    return this.applicantHouseholdSizeField;
                }
                set
                {
                    this.applicantHouseholdSizeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IdentificationNo")]
            public string ApplicantIdentificationNo
            {
                get
                {
                    return this.applicantIdentificationNoField;
                }
                set
                {
                    this.applicantIdentificationNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IdentificationType")]
            public string ApplicantIdentificationType
            {
                get
                {
                    return this.applicantIdentificationTypeField;
                }
                set
                {
                    this.applicantIdentificationTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.InsolventDate")]
            public string ApplicantInsolventDate
            {
                get
                {
                    return this.applicantInsolventDateField;
                }
                set
                {
                    this.applicantInsolventDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction")]
            public string ApplicantJurisdiction
            {
                get
                {
                    return this.applicantJurisdictionField;
                }
                set
                {
                    this.applicantJurisdictionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction1")]
            public string ApplicantJurisdiction1
            {
                get
                {
                    return this.applicantJurisdiction1Field;
                }
                set
                {
                    this.applicantJurisdiction1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction2")]
            public string ApplicantJurisdiction2
            {
                get
                {
                    return this.applicantJurisdiction2Field;
                }
                set
                {
                    this.applicantJurisdiction2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction3")]
            public string ApplicantJurisdiction3
            {
                get
                {
                    return this.applicantJurisdiction3Field;
                }
                set
                {
                    this.applicantJurisdiction3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction4")]
            public string ApplicantJurisdiction4
            {
                get
                {
                    return this.applicantJurisdiction4Field;
                }
                set
                {
                    this.applicantJurisdiction4Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.LifeAssuranceOption")]
            public string ApplicantLifeAssuranceOption
            {
                get
                {
                    return this.applicantLifeAssuranceOptionField;
                }
                set
                {
                    this.applicantLifeAssuranceOptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MaritalStatus")]
            public string ApplicantMaritalStatus
            {
                get
                {
                    return this.applicantMaritalStatusField;
                }
                set
                {
                    this.applicantMaritalStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MarriedStatus")]
            public string ApplicantMarriedStatus
            {
                get
                {
                    return this.applicantMarriedStatusField;
                }
                set
                {
                    this.applicantMarriedStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayBankContactYou")]
            public string ApplicantMayBankContactYou
            {
                get
                {
                    return this.applicantMayBankContactYouField;
                }
                set
                {
                    this.applicantMayBankContactYouField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayDoCreditBureauEnquiry")]
            public string ApplicantMayDoCreditBureauEnquiry
            {
                get
                {
                    return this.applicantMayDoCreditBureauEnquiryField;
                }
                set
                {
                    this.applicantMayDoCreditBureauEnquiryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NoOfDependents")]
            public string ApplicantNoOfDependents
            {
                get
                {
                    return this.applicantNoOfDependentsField;
                }
                set
                {
                    this.applicantNoOfDependentsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Occupation")]
            public string ApplicantOccupation
            {
                get
                {
                    return this.applicantOccupationField;
                }
                set
                {
                    this.applicantOccupationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.OccupationLevel")]
            public string ApplicantOccupationLevel
            {
                get
                {
                    return this.applicantOccupationLevelField;
                }
                set
                {
                    this.applicantOccupationLevelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PassportNo")]
            public string ApplicantPassportNo
            {
                get
                {
                    return this.applicantPassportNoField;
                }
                set
                {
                    this.applicantPassportNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermanentResident")]
            public string ApplicantPermanentResident
            {
                get
                {
                    return this.applicantPermanentResidentField;
                }
                set
                {
                    this.applicantPermanentResidentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermanentResidentCountry")]
            public string ApplicantPermanentResidentCountry
            {
                get
                {
                    return this.applicantPermanentResidentCountryField;
                }
                set
                {
                    this.applicantPermanentResidentCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermanentResidentNo")]
            public string ApplicantPermanentResidentNo
            {
                get
                {
                    return this.applicantPermanentResidentNoField;
                }
                set
                {
                    this.applicantPermanentResidentNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermitIssueDate")]
            public string ApplicantPermitIssueDate
            {
                get
                {
                    return this.applicantPermitIssueDateField;
                }
                set
                {
                    this.applicantPermitIssueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressCity")]
            public string ApplicantPhysicalAddressCity
            {
                get
                {
                    return this.applicantPhysicalAddressCityField;
                }
                set
                {
                    this.applicantPhysicalAddressCityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressCode")]
            public string ApplicantPhysicalAddressCode
            {
                get
                {
                    return this.applicantPhysicalAddressCodeField;
                }
                set
                {
                    this.applicantPhysicalAddressCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressLine1")]
            public string ApplicantPhysicalAddressLine1
            {
                get
                {
                    return this.applicantPhysicalAddressLine1Field;
                }
                set
                {
                    this.applicantPhysicalAddressLine1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressLine2")]
            public string ApplicantPhysicalAddressLine2
            {
                get
                {
                    return this.applicantPhysicalAddressLine2Field;
                }
                set
                {
                    this.applicantPhysicalAddressLine2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressSuburb")]
            public string ApplicantPhysicalAddressSuburb
            {
                get
                {
                    return this.applicantPhysicalAddressSuburbField;
                }
                set
                {
                    this.applicantPhysicalAddressSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressCity")]
            public string ApplicantPostalAddressCity
            {
                get
                {
                    return this.applicantPostalAddressCityField;
                }
                set
                {
                    this.applicantPostalAddressCityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressCode")]
            public string ApplicantPostalAddressCode
            {
                get
                {
                    return this.applicantPostalAddressCodeField;
                }
                set
                {
                    this.applicantPostalAddressCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressLine1")]
            public string ApplicantPostalAddressLine1
            {
                get
                {
                    return this.applicantPostalAddressLine1Field;
                }
                set
                {
                    this.applicantPostalAddressLine1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressLine2")]
            public string ApplicantPostalAddressLine2
            {
                get
                {
                    return this.applicantPostalAddressLine2Field;
                }
                set
                {
                    this.applicantPostalAddressLine2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressSuburb")]
            public string ApplicantPostalAddressSuburb
            {
                get
                {
                    return this.applicantPostalAddressSuburbField;
                }
                set
                {
                    this.applicantPostalAddressSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PreferredContactDelivery")]
            public string ApplicantPreferredContactDelivery
            {
                get
                {
                    return this.applicantPreferredContactDeliveryField;
                }
                set
                {
                    this.applicantPreferredContactDeliveryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PreviousEmployerName")]
            public string ApplicantPreviousEmployerName
            {
                get
                {
                    return this.applicantPreviousEmployerNameField;
                }
                set
                {
                    this.applicantPreviousEmployerNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PreviousEmployerPeriod")]
            public string ApplicantPreviousEmployerPeriod
            {
                get
                {
                    return this.applicantPreviousEmployerPeriodField;
                }
                set
                {
                    this.applicantPreviousEmployerPeriodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Rehabilitated")]
            public string ApplicantRehabilitated
            {
                get
                {
                    return this.applicantRehabilitatedField;
                }
                set
                {
                    this.applicantRehabilitatedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.RightOfRefusalConsent")]
            public string ApplicantRightOfRefusalConsent
            {
                get
                {
                    return this.applicantRightOfRefusalConsentField;
                }
                set
                {
                    this.applicantRightOfRefusalConsentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SACitizen")]
            public string ApplicantSACitizen
            {
                get
                {
                    return this.applicantSACitizenField;
                }
                set
                {
                    this.applicantSACitizenField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Surname")]
            public string ApplicantSurname
            {
                get
                {
                    return this.applicantSurnameField;
                }
                set
                {
                    this.applicantSurnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber")]
            public string ApplicantTaxIdentificationNumber
            {
                get
                {
                    return this.applicantTaxIdentificationNumberField;
                }
                set
                {
                    this.applicantTaxIdentificationNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber1")]
            public string ApplicantTaxIdentificationNumber1
            {
                get
                {
                    return this.applicantTaxIdentificationNumber1Field;
                }
                set
                {
                    this.applicantTaxIdentificationNumber1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber2")]
            public string ApplicantTaxIdentificationNumber2
            {
                get
                {
                    return this.applicantTaxIdentificationNumber2Field;
                }
                set
                {
                    this.applicantTaxIdentificationNumber2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber3")]
            public string ApplicantTaxIdentificationNumber3
            {
                get
                {
                    return this.applicantTaxIdentificationNumber3Field;
                }
                set
                {
                    this.applicantTaxIdentificationNumber3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber4")]
            public string ApplicantTaxIdentificationNumber4
            {
                get
                {
                    return this.applicantTaxIdentificationNumber4Field;
                }
                set
                {
                    this.applicantTaxIdentificationNumber4Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason")]
            public string ApplicantTaxIdentificationReason
            {
                get
                {
                    return this.applicantTaxIdentificationReasonField;
                }
                set
                {
                    this.applicantTaxIdentificationReasonField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason1")]
            public string ApplicantTaxIdentificationReason1
            {
                get
                {
                    return this.applicantTaxIdentificationReason1Field;
                }
                set
                {
                    this.applicantTaxIdentificationReason1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason2")]
            public string ApplicantTaxIdentificationReason2
            {
                get
                {
                    return this.applicantTaxIdentificationReason2Field;
                }
                set
                {
                    this.applicantTaxIdentificationReason2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason3")]
            public string ApplicantTaxIdentificationReason3
            {
                get
                {
                    return this.applicantTaxIdentificationReason3Field;
                }
                set
                {
                    this.applicantTaxIdentificationReason3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason4")]
            public string ApplicantTaxIdentificationReason4
            {
                get
                {
                    return this.applicantTaxIdentificationReason4Field;
                }
                set
                {
                    this.applicantTaxIdentificationReason4Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TempResident")]
            public string ApplicantTempResident
            {
                get
                {
                    return this.applicantTempResidentField;
                }
                set
                {
                    this.applicantTempResidentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TempResidentPermitExpiry")]
            public string ApplicantTempResidentPermitExpiry
            {
                get
                {
                    return this.applicantTempResidentPermitExpiryField;
                }
                set
                {
                    this.applicantTempResidentPermitExpiryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TempResidentPermitNo")]
            public string ApplicantTempResidentPermitNo
            {
                get
                {
                    return this.applicantTempResidentPermitNoField;
                }
                set
                {
                    this.applicantTempResidentPermitNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Title")]
            public string ApplicantTitle
            {
                get
                {
                    return this.applicantTitleField;
                }
                set
                {
                    this.applicantTitleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TypeOfIncome")]
            public string ApplicantTypeOfIncome
            {
                get
                {
                    return this.applicantTypeOfIncomeField;
                }
                set
                {
                    this.applicantTypeOfIncomeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.WorkPhone")]
            public string ApplicantWorkPhone
            {
                get
                {
                    return this.applicantWorkPhoneField;
                }
                set
                {
                    this.applicantWorkPhoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.WorkPhoneCode")]
            public string ApplicantWorkPhoneCode
            {
                get
                {
                    return this.applicantWorkPhoneCodeField;
                }
                set
                {
                    this.applicantWorkPhoneCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.IncomeItems")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.IncomeItem", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem[] ApplicantIncomeItems
            {
                get
                {
                    return this.applicantIncomeItemsField;
                }
                set
                {
                    this.applicantIncomeItemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.ExpenditureItems")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.ExpenditureItem", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem[] ApplicantExpenditureItems
            {
                get
                {
                    return this.applicantExpenditureItemsField;
                }
                set
                {
                    this.applicantExpenditureItemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.BankAccounts")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.BankAccount", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount[] ApplicantBankAccounts
            {
                get
                {
                    return this.applicantBankAccountsField;
                }
                set
                {
                    this.applicantBankAccountsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SpouseDetails")]
            public SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetails ApplicantSpouseDetails
            {
                get
                {
                    return this.applicantSpouseDetailsField;
                }
                set
                {
                    this.applicantSpouseDetailsField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem
        {

            private string applicantIncomeAmountField;

            private string applicantIncomeDescField;

            private string applicantIncomeTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeAmount")]
            public string ApplicantIncomeAmount
            {
                get
                {
                    return this.applicantIncomeAmountField;
                }
                set
                {
                    this.applicantIncomeAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeDesc")]
            public string ApplicantIncomeDesc
            {
                get
                {
                    return this.applicantIncomeDescField;
                }
                set
                {
                    this.applicantIncomeDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeType")]
            public string ApplicantIncomeType
            {
                get
                {
                    return this.applicantIncomeTypeField;
                }
                set
                {
                    this.applicantIncomeTypeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem
        {

            private string applicantExpenditureAmountField;

            private string applicantExpenditureDescField;

            private string applicantExpenditureTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ExpenditureAmount")]
            public string ApplicantExpenditureAmount
            {
                get
                {
                    return this.applicantExpenditureAmountField;
                }
                set
                {
                    this.applicantExpenditureAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ExpenditureDesc")]
            public string ApplicantExpenditureDesc
            {
                get
                {
                    return this.applicantExpenditureDescField;
                }
                set
                {
                    this.applicantExpenditureDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ExpenditureType")]
            public string ApplicantExpenditureType
            {
                get
                {
                    return this.applicantExpenditureTypeField;
                }
                set
                {
                    this.applicantExpenditureTypeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount
        {

            private string applicantAccountBalanceField;

            private string applicantAccountBranchField;

            private string applicantAccountInstitutionField;

            private string applicantAccountNameField;

            private string applicantAccountNumberField;

            private string applicantAccountTypeField;

            private string applicantIsMainAccountField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountBalance")]
            public string ApplicantAccountBalance
            {
                get
                {
                    return this.applicantAccountBalanceField;
                }
                set
                {
                    this.applicantAccountBalanceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountBranch")]
            public string ApplicantAccountBranch
            {
                get
                {
                    return this.applicantAccountBranchField;
                }
                set
                {
                    this.applicantAccountBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountInstitution")]
            public string ApplicantAccountInstitution
            {
                get
                {
                    return this.applicantAccountInstitutionField;
                }
                set
                {
                    this.applicantAccountInstitutionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountName")]
            public string ApplicantAccountName
            {
                get
                {
                    return this.applicantAccountNameField;
                }
                set
                {
                    this.applicantAccountNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountNumber")]
            public string ApplicantAccountNumber
            {
                get
                {
                    return this.applicantAccountNumberField;
                }
                set
                {
                    this.applicantAccountNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountType")]
            public string ApplicantAccountType
            {
                get
                {
                    return this.applicantAccountTypeField;
                }
                set
                {
                    this.applicantAccountTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IsMainAccount")]
            public string ApplicantIsMainAccount
            {
                get
                {
                    return this.applicantIsMainAccountField;
                }
                set
                {
                    this.applicantIsMainAccountField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetails
        {

            private string applicantCellphoneField;

            private string applicantCorrespondenceLanguageField;

            private string applicantCountryOfBirthField;

            private string applicantCountryPermitIssuedField;

            private string applicantDateJoinedEmployerField;

            private string applicantDateOfBirthField;

            private string applicantDatePassportExpiresField;

            private string applicantDateRehabilitatedField;

            private string applicantDateWorkContractExpiresField;

            private string applicantDateWorkContractIssuedField;

            private string applicantDeclaredInsolventField;

            private string applicantEmailAddressField;

            private string applicantEmployeeStatusField;

            private string applicantEmployerNameField;

            private string applicantEmployerOperatingYearsField;

            private string applicantEthnicGroupField;

            private string applicantFaxCodeField;

            private string applicantFaxNoField;

            private string applicantFirstNameField;

            private string applicantFNBCityOfBirthField;

            private string applicantFNBClientField;

            private string applicantFNBCountryOfCitizenshipField;

            private string applicantFNBCountryOfMarriageField;

            private string applicantFNBCountryResideWorkField;

            private string applicantFNBEmploymentSectorField;

            private string applicantFNBEmploymentTypeField;

            private string applicantFNBForeignTaxNumberField;

            private string applicantFNBForeignTaxReturnIdField;

            private string applicantFNBHighestQualificationField;

            private string applicantFNBInternationalWorkAddressField;

            private string applicantFNBIsFirstRandEmployeeField;

            private string applicantFNBIsInternationalAddressField;

            private string applicantFNBIsSuretyField;

            private string applicantFNBMarketingConsentIdField;

            private string applicantFNBPostalAddressCountryField;

            private string applicantFNBRandEmployeeNumberField;

            private string applicantFNBResidentialAddressCountryField;

            private string applicantFNBSourceOfIncome1Field;

            private string applicantFNBSourceOfIncome2Field;

            private string applicantFNBSourceOfIncome3Field;

            private string applicantFNBSourceOfIncome4Field;

            private string applicantFNBSourceOfIncome5Field;

            private string applicantFNBTaxPayerInResidentCountryField;

            private string applicantFNBTypeOfPermitField;

            private string applicantGenderField;

            private string applicantHomePhoneField;

            private string applicantHomePhoneCodeField;

            private string applicantIdentificationNoField;

            private string applicantIdentificationTypeField;

            private string applicantInsolventDateField;

            private string applicantJurisdictionField;

            private string applicantJurisdiction1Field;

            private string applicantJurisdiction2Field;

            private string applicantJurisdiction3Field;

            private string applicantJurisdiction4Field;

            private string applicantMaritalStatusField;

            private string applicantMarriedStatusField;

            private string applicantMayBankContactYouField;

            private string applicantMayDoCreditBureauEnquiryField;

            private string applicantNationalityField;

            private string applicantNoOfDependentsField;

            private string applicantOccupationField;

            private string applicantOccupationLevelField;

            private string applicantPassportNoField;

            private string applicantPermanentResidentField;

            private string applicantPermanentResidentCountryField;

            private string applicantPermanentResidentNoField;

            private string applicantPermitIssueDateField;

            private string applicantPhysicalAddressCityField;

            private string applicantPhysicalAddressCodeField;

            private string applicantPhysicalAddressLine1Field;

            private string applicantPhysicalAddressLine2Field;

            private string applicantPhysicalAddressSuburbField;

            private string applicantPostalAddressCityField;

            private string applicantPostalAddressCodeField;

            private string applicantPostalAddressLine1Field;

            private string applicantPostalAddressLine2Field;

            private string applicantPostalAddressSuburbField;

            private string applicantPreferredContactDeliveryField;

            private string applicantPreviousEmployerNameField;

            private string applicantPreviousEmployerPeriodField;

            private string applicantRehabilitatedField;

            private string applicantRightOfRefusalConsentField;

            private string applicantSACitizenField;

            private string applicantSurnameField;

            private string applicantTaxIdentificationNumberField;

            private string applicantTaxIdentificationNumber1Field;

            private string applicantTaxIdentificationNumber2Field;

            private string applicantTaxIdentificationNumber3Field;

            private string applicantTaxIdentificationNumber4Field;

            private string applicantTaxIdentificationReasonField;

            private string applicantTaxIdentificationReason1Field;

            private string applicantTaxIdentificationReason2Field;

            private string applicantTaxIdentificationReason3Field;

            private string applicantTaxIdentificationReason4Field;

            private string applicantTempResidentField;

            private string applicantTempResidentPermitExpiryField;

            private string applicantTempResidentPermitNoField;

            private string applicantTitleField;

            private string applicantTypeOfIncomeField;

            private string applicantWorkPhoneField;

            private string applicantWorkPhoneCodeField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem[] applicantIncomeItemsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem[] applicantExpenditureItemsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantBankAccount[] applicantBankAccountsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Cellphone")]
            public string ApplicantCellphone
            {
                get
                {
                    return this.applicantCellphoneField;
                }
                set
                {
                    this.applicantCellphoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CorrespondenceLanguage")]
            public string ApplicantCorrespondenceLanguage
            {
                get
                {
                    return this.applicantCorrespondenceLanguageField;
                }
                set
                {
                    this.applicantCorrespondenceLanguageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CountryOfBirth")]
            public string ApplicantCountryOfBirth
            {
                get
                {
                    return this.applicantCountryOfBirthField;
                }
                set
                {
                    this.applicantCountryOfBirthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CountryPermitIssued")]
            public string ApplicantCountryPermitIssued
            {
                get
                {
                    return this.applicantCountryPermitIssuedField;
                }
                set
                {
                    this.applicantCountryPermitIssuedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateJoinedEmployer")]
            public string ApplicantDateJoinedEmployer
            {
                get
                {
                    return this.applicantDateJoinedEmployerField;
                }
                set
                {
                    this.applicantDateJoinedEmployerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateOfBirth")]
            public string ApplicantDateOfBirth
            {
                get
                {
                    return this.applicantDateOfBirthField;
                }
                set
                {
                    this.applicantDateOfBirthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DatePassportExpires")]
            public string ApplicantDatePassportExpires
            {
                get
                {
                    return this.applicantDatePassportExpiresField;
                }
                set
                {
                    this.applicantDatePassportExpiresField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateRehabilitated")]
            public string ApplicantDateRehabilitated
            {
                get
                {
                    return this.applicantDateRehabilitatedField;
                }
                set
                {
                    this.applicantDateRehabilitatedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateWorkContractExpires")]
            public string ApplicantDateWorkContractExpires
            {
                get
                {
                    return this.applicantDateWorkContractExpiresField;
                }
                set
                {
                    this.applicantDateWorkContractExpiresField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateWorkContractIssued")]
            public string ApplicantDateWorkContractIssued
            {
                get
                {
                    return this.applicantDateWorkContractIssuedField;
                }
                set
                {
                    this.applicantDateWorkContractIssuedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DeclaredInsolvent")]
            public string ApplicantDeclaredInsolvent
            {
                get
                {
                    return this.applicantDeclaredInsolventField;
                }
                set
                {
                    this.applicantDeclaredInsolventField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmailAddress")]
            public string ApplicantEmailAddress
            {
                get
                {
                    return this.applicantEmailAddressField;
                }
                set
                {
                    this.applicantEmailAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployeeStatus")]
            public string ApplicantEmployeeStatus
            {
                get
                {
                    return this.applicantEmployeeStatusField;
                }
                set
                {
                    this.applicantEmployeeStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerName")]
            public string ApplicantEmployerName
            {
                get
                {
                    return this.applicantEmployerNameField;
                }
                set
                {
                    this.applicantEmployerNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerOperatingYears")]
            public string ApplicantEmployerOperatingYears
            {
                get
                {
                    return this.applicantEmployerOperatingYearsField;
                }
                set
                {
                    this.applicantEmployerOperatingYearsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EthnicGroup")]
            public string ApplicantEthnicGroup
            {
                get
                {
                    return this.applicantEthnicGroupField;
                }
                set
                {
                    this.applicantEthnicGroupField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FaxCode")]
            public string ApplicantFaxCode
            {
                get
                {
                    return this.applicantFaxCodeField;
                }
                set
                {
                    this.applicantFaxCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FaxNo")]
            public string ApplicantFaxNo
            {
                get
                {
                    return this.applicantFaxNoField;
                }
                set
                {
                    this.applicantFaxNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FirstName")]
            public string ApplicantFirstName
            {
                get
                {
                    return this.applicantFirstNameField;
                }
                set
                {
                    this.applicantFirstNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBCityOfBirth")]
            public string ApplicantFNBCityOfBirth
            {
                get
                {
                    return this.applicantFNBCityOfBirthField;
                }
                set
                {
                    this.applicantFNBCityOfBirthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBClient")]
            public string ApplicantFNBClient
            {
                get
                {
                    return this.applicantFNBClientField;
                }
                set
                {
                    this.applicantFNBClientField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBCountryOfCitizenship")]
            public string ApplicantFNBCountryOfCitizenship
            {
                get
                {
                    return this.applicantFNBCountryOfCitizenshipField;
                }
                set
                {
                    this.applicantFNBCountryOfCitizenshipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBCountryOfMarriage")]
            public string ApplicantFNBCountryOfMarriage
            {
                get
                {
                    return this.applicantFNBCountryOfMarriageField;
                }
                set
                {
                    this.applicantFNBCountryOfMarriageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBCountryResideWork")]
            public string ApplicantFNBCountryResideWork
            {
                get
                {
                    return this.applicantFNBCountryResideWorkField;
                }
                set
                {
                    this.applicantFNBCountryResideWorkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBEmploymentSector")]
            public string ApplicantFNBEmploymentSector
            {
                get
                {
                    return this.applicantFNBEmploymentSectorField;
                }
                set
                {
                    this.applicantFNBEmploymentSectorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBEmploymentType")]
            public string ApplicantFNBEmploymentType
            {
                get
                {
                    return this.applicantFNBEmploymentTypeField;
                }
                set
                {
                    this.applicantFNBEmploymentTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBForeignTaxNumber")]
            public string ApplicantFNBForeignTaxNumber
            {
                get
                {
                    return this.applicantFNBForeignTaxNumberField;
                }
                set
                {
                    this.applicantFNBForeignTaxNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBForeignTaxReturnId")]
            public string ApplicantFNBForeignTaxReturnId
            {
                get
                {
                    return this.applicantFNBForeignTaxReturnIdField;
                }
                set
                {
                    this.applicantFNBForeignTaxReturnIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBHighestQualification")]
            public string ApplicantFNBHighestQualification
            {
                get
                {
                    return this.applicantFNBHighestQualificationField;
                }
                set
                {
                    this.applicantFNBHighestQualificationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBInternationalWorkAddress")]
            public string ApplicantFNBInternationalWorkAddress
            {
                get
                {
                    return this.applicantFNBInternationalWorkAddressField;
                }
                set
                {
                    this.applicantFNBInternationalWorkAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBIsFirstRandEmployee")]
            public string ApplicantFNBIsFirstRandEmployee
            {
                get
                {
                    return this.applicantFNBIsFirstRandEmployeeField;
                }
                set
                {
                    this.applicantFNBIsFirstRandEmployeeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBIsInternationalAddress")]
            public string ApplicantFNBIsInternationalAddress
            {
                get
                {
                    return this.applicantFNBIsInternationalAddressField;
                }
                set
                {
                    this.applicantFNBIsInternationalAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBIsSurety")]
            public string ApplicantFNBIsSurety
            {
                get
                {
                    return this.applicantFNBIsSuretyField;
                }
                set
                {
                    this.applicantFNBIsSuretyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBMarketingConsentId")]
            public string ApplicantFNBMarketingConsentId
            {
                get
                {
                    return this.applicantFNBMarketingConsentIdField;
                }
                set
                {
                    this.applicantFNBMarketingConsentIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBPostalAddressCountry")]
            public string ApplicantFNBPostalAddressCountry
            {
                get
                {
                    return this.applicantFNBPostalAddressCountryField;
                }
                set
                {
                    this.applicantFNBPostalAddressCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBRandEmployeeNumber")]
            public string ApplicantFNBRandEmployeeNumber
            {
                get
                {
                    return this.applicantFNBRandEmployeeNumberField;
                }
                set
                {
                    this.applicantFNBRandEmployeeNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBResidentialAddressCountry")]
            public string ApplicantFNBResidentialAddressCountry
            {
                get
                {
                    return this.applicantFNBResidentialAddressCountryField;
                }
                set
                {
                    this.applicantFNBResidentialAddressCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome1")]
            public string ApplicantFNBSourceOfIncome1
            {
                get
                {
                    return this.applicantFNBSourceOfIncome1Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome2")]
            public string ApplicantFNBSourceOfIncome2
            {
                get
                {
                    return this.applicantFNBSourceOfIncome2Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome3")]
            public string ApplicantFNBSourceOfIncome3
            {
                get
                {
                    return this.applicantFNBSourceOfIncome3Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome4")]
            public string ApplicantFNBSourceOfIncome4
            {
                get
                {
                    return this.applicantFNBSourceOfIncome4Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome4Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome5")]
            public string ApplicantFNBSourceOfIncome5
            {
                get
                {
                    return this.applicantFNBSourceOfIncome5Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome5Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBTaxPayerInResidentCountry")]
            public string ApplicantFNBTaxPayerInResidentCountry
            {
                get
                {
                    return this.applicantFNBTaxPayerInResidentCountryField;
                }
                set
                {
                    this.applicantFNBTaxPayerInResidentCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBTypeOfPermit")]
            public string ApplicantFNBTypeOfPermit
            {
                get
                {
                    return this.applicantFNBTypeOfPermitField;
                }
                set
                {
                    this.applicantFNBTypeOfPermitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Gender")]
            public string ApplicantGender
            {
                get
                {
                    return this.applicantGenderField;
                }
                set
                {
                    this.applicantGenderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HomePhone")]
            public string ApplicantHomePhone
            {
                get
                {
                    return this.applicantHomePhoneField;
                }
                set
                {
                    this.applicantHomePhoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HomePhoneCode")]
            public string ApplicantHomePhoneCode
            {
                get
                {
                    return this.applicantHomePhoneCodeField;
                }
                set
                {
                    this.applicantHomePhoneCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IdentificationNo")]
            public string ApplicantIdentificationNo
            {
                get
                {
                    return this.applicantIdentificationNoField;
                }
                set
                {
                    this.applicantIdentificationNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IdentificationType")]
            public string ApplicantIdentificationType
            {
                get
                {
                    return this.applicantIdentificationTypeField;
                }
                set
                {
                    this.applicantIdentificationTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.InsolventDate")]
            public string ApplicantInsolventDate
            {
                get
                {
                    return this.applicantInsolventDateField;
                }
                set
                {
                    this.applicantInsolventDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction")]
            public string ApplicantJurisdiction
            {
                get
                {
                    return this.applicantJurisdictionField;
                }
                set
                {
                    this.applicantJurisdictionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction1")]
            public string ApplicantJurisdiction1
            {
                get
                {
                    return this.applicantJurisdiction1Field;
                }
                set
                {
                    this.applicantJurisdiction1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction2")]
            public string ApplicantJurisdiction2
            {
                get
                {
                    return this.applicantJurisdiction2Field;
                }
                set
                {
                    this.applicantJurisdiction2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction3")]
            public string ApplicantJurisdiction3
            {
                get
                {
                    return this.applicantJurisdiction3Field;
                }
                set
                {
                    this.applicantJurisdiction3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction4")]
            public string ApplicantJurisdiction4
            {
                get
                {
                    return this.applicantJurisdiction4Field;
                }
                set
                {
                    this.applicantJurisdiction4Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MaritalStatus")]
            public string ApplicantMaritalStatus
            {
                get
                {
                    return this.applicantMaritalStatusField;
                }
                set
                {
                    this.applicantMaritalStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MarriedStatus")]
            public string ApplicantMarriedStatus
            {
                get
                {
                    return this.applicantMarriedStatusField;
                }
                set
                {
                    this.applicantMarriedStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayBankContactYou")]
            public string ApplicantMayBankContactYou
            {
                get
                {
                    return this.applicantMayBankContactYouField;
                }
                set
                {
                    this.applicantMayBankContactYouField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayDoCreditBureauEnquiry")]
            public string ApplicantMayDoCreditBureauEnquiry
            {
                get
                {
                    return this.applicantMayDoCreditBureauEnquiryField;
                }
                set
                {
                    this.applicantMayDoCreditBureauEnquiryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Nationality")]
            public string ApplicantNationality
            {
                get
                {
                    return this.applicantNationalityField;
                }
                set
                {
                    this.applicantNationalityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NoOfDependents")]
            public string ApplicantNoOfDependents
            {
                get
                {
                    return this.applicantNoOfDependentsField;
                }
                set
                {
                    this.applicantNoOfDependentsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Occupation")]
            public string ApplicantOccupation
            {
                get
                {
                    return this.applicantOccupationField;
                }
                set
                {
                    this.applicantOccupationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.OccupationLevel")]
            public string ApplicantOccupationLevel
            {
                get
                {
                    return this.applicantOccupationLevelField;
                }
                set
                {
                    this.applicantOccupationLevelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PassportNo")]
            public string ApplicantPassportNo
            {
                get
                {
                    return this.applicantPassportNoField;
                }
                set
                {
                    this.applicantPassportNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermanentResident")]
            public string ApplicantPermanentResident
            {
                get
                {
                    return this.applicantPermanentResidentField;
                }
                set
                {
                    this.applicantPermanentResidentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermanentResidentCountry")]
            public string ApplicantPermanentResidentCountry
            {
                get
                {
                    return this.applicantPermanentResidentCountryField;
                }
                set
                {
                    this.applicantPermanentResidentCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermanentResidentNo")]
            public string ApplicantPermanentResidentNo
            {
                get
                {
                    return this.applicantPermanentResidentNoField;
                }
                set
                {
                    this.applicantPermanentResidentNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermitIssueDate")]
            public string ApplicantPermitIssueDate
            {
                get
                {
                    return this.applicantPermitIssueDateField;
                }
                set
                {
                    this.applicantPermitIssueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressCity")]
            public string ApplicantPhysicalAddressCity
            {
                get
                {
                    return this.applicantPhysicalAddressCityField;
                }
                set
                {
                    this.applicantPhysicalAddressCityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressCode")]
            public string ApplicantPhysicalAddressCode
            {
                get
                {
                    return this.applicantPhysicalAddressCodeField;
                }
                set
                {
                    this.applicantPhysicalAddressCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressLine1")]
            public string ApplicantPhysicalAddressLine1
            {
                get
                {
                    return this.applicantPhysicalAddressLine1Field;
                }
                set
                {
                    this.applicantPhysicalAddressLine1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressLine2")]
            public string ApplicantPhysicalAddressLine2
            {
                get
                {
                    return this.applicantPhysicalAddressLine2Field;
                }
                set
                {
                    this.applicantPhysicalAddressLine2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressSuburb")]
            public string ApplicantPhysicalAddressSuburb
            {
                get
                {
                    return this.applicantPhysicalAddressSuburbField;
                }
                set
                {
                    this.applicantPhysicalAddressSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressCity")]
            public string ApplicantPostalAddressCity
            {
                get
                {
                    return this.applicantPostalAddressCityField;
                }
                set
                {
                    this.applicantPostalAddressCityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressCode")]
            public string ApplicantPostalAddressCode
            {
                get
                {
                    return this.applicantPostalAddressCodeField;
                }
                set
                {
                    this.applicantPostalAddressCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressLine1")]
            public string ApplicantPostalAddressLine1
            {
                get
                {
                    return this.applicantPostalAddressLine1Field;
                }
                set
                {
                    this.applicantPostalAddressLine1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressLine2")]
            public string ApplicantPostalAddressLine2
            {
                get
                {
                    return this.applicantPostalAddressLine2Field;
                }
                set
                {
                    this.applicantPostalAddressLine2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressSuburb")]
            public string ApplicantPostalAddressSuburb
            {
                get
                {
                    return this.applicantPostalAddressSuburbField;
                }
                set
                {
                    this.applicantPostalAddressSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PreferredContactDelivery")]
            public string ApplicantPreferredContactDelivery
            {
                get
                {
                    return this.applicantPreferredContactDeliveryField;
                }
                set
                {
                    this.applicantPreferredContactDeliveryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PreviousEmployerName")]
            public string ApplicantPreviousEmployerName
            {
                get
                {
                    return this.applicantPreviousEmployerNameField;
                }
                set
                {
                    this.applicantPreviousEmployerNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PreviousEmployerPeriod")]
            public string ApplicantPreviousEmployerPeriod
            {
                get
                {
                    return this.applicantPreviousEmployerPeriodField;
                }
                set
                {
                    this.applicantPreviousEmployerPeriodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Rehabilitated")]
            public string ApplicantRehabilitated
            {
                get
                {
                    return this.applicantRehabilitatedField;
                }
                set
                {
                    this.applicantRehabilitatedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.RightOfRefusalConsent")]
            public string ApplicantRightOfRefusalConsent
            {
                get
                {
                    return this.applicantRightOfRefusalConsentField;
                }
                set
                {
                    this.applicantRightOfRefusalConsentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SACitizen")]
            public string ApplicantSACitizen
            {
                get
                {
                    return this.applicantSACitizenField;
                }
                set
                {
                    this.applicantSACitizenField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Surname")]
            public string ApplicantSurname
            {
                get
                {
                    return this.applicantSurnameField;
                }
                set
                {
                    this.applicantSurnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber")]
            public string ApplicantTaxIdentificationNumber
            {
                get
                {
                    return this.applicantTaxIdentificationNumberField;
                }
                set
                {
                    this.applicantTaxIdentificationNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber1")]
            public string ApplicantTaxIdentificationNumber1
            {
                get
                {
                    return this.applicantTaxIdentificationNumber1Field;
                }
                set
                {
                    this.applicantTaxIdentificationNumber1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber2")]
            public string ApplicantTaxIdentificationNumber2
            {
                get
                {
                    return this.applicantTaxIdentificationNumber2Field;
                }
                set
                {
                    this.applicantTaxIdentificationNumber2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber3")]
            public string ApplicantTaxIdentificationNumber3
            {
                get
                {
                    return this.applicantTaxIdentificationNumber3Field;
                }
                set
                {
                    this.applicantTaxIdentificationNumber3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber4")]
            public string ApplicantTaxIdentificationNumber4
            {
                get
                {
                    return this.applicantTaxIdentificationNumber4Field;
                }
                set
                {
                    this.applicantTaxIdentificationNumber4Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason")]
            public string ApplicantTaxIdentificationReason
            {
                get
                {
                    return this.applicantTaxIdentificationReasonField;
                }
                set
                {
                    this.applicantTaxIdentificationReasonField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason1")]
            public string ApplicantTaxIdentificationReason1
            {
                get
                {
                    return this.applicantTaxIdentificationReason1Field;
                }
                set
                {
                    this.applicantTaxIdentificationReason1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason2")]
            public string ApplicantTaxIdentificationReason2
            {
                get
                {
                    return this.applicantTaxIdentificationReason2Field;
                }
                set
                {
                    this.applicantTaxIdentificationReason2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason3")]
            public string ApplicantTaxIdentificationReason3
            {
                get
                {
                    return this.applicantTaxIdentificationReason3Field;
                }
                set
                {
                    this.applicantTaxIdentificationReason3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason4")]
            public string ApplicantTaxIdentificationReason4
            {
                get
                {
                    return this.applicantTaxIdentificationReason4Field;
                }
                set
                {
                    this.applicantTaxIdentificationReason4Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TempResident")]
            public string ApplicantTempResident
            {
                get
                {
                    return this.applicantTempResidentField;
                }
                set
                {
                    this.applicantTempResidentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TempResidentPermitExpiry")]
            public string ApplicantTempResidentPermitExpiry
            {
                get
                {
                    return this.applicantTempResidentPermitExpiryField;
                }
                set
                {
                    this.applicantTempResidentPermitExpiryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TempResidentPermitNo")]
            public string ApplicantTempResidentPermitNo
            {
                get
                {
                    return this.applicantTempResidentPermitNoField;
                }
                set
                {
                    this.applicantTempResidentPermitNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Title")]
            public string ApplicantTitle
            {
                get
                {
                    return this.applicantTitleField;
                }
                set
                {
                    this.applicantTitleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TypeOfIncome")]
            public string ApplicantTypeOfIncome
            {
                get
                {
                    return this.applicantTypeOfIncomeField;
                }
                set
                {
                    this.applicantTypeOfIncomeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.WorkPhone")]
            public string ApplicantWorkPhone
            {
                get
                {
                    return this.applicantWorkPhoneField;
                }
                set
                {
                    this.applicantWorkPhoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.WorkPhoneCode")]
            public string ApplicantWorkPhoneCode
            {
                get
                {
                    return this.applicantWorkPhoneCodeField;
                }
                set
                {
                    this.applicantWorkPhoneCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.IncomeItems")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.IncomeItem", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem[] ApplicantIncomeItems
            {
                get
                {
                    return this.applicantIncomeItemsField;
                }
                set
                {
                    this.applicantIncomeItemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.ExpenditureItems")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.ExpenditureItem", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem[] ApplicantExpenditureItems
            {
                get
                {
                    return this.applicantExpenditureItemsField;
                }
                set
                {
                    this.applicantExpenditureItemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.BankAccounts")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.BankAccount", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantBankAccount[] ApplicantBankAccounts
            {
                get
                {
                    return this.applicantBankAccountsField;
                }
                set
                {
                    this.applicantBankAccountsField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem
        {

            private string applicantIncomeAmountField;

            private string applicantIncomeDescField;

            private string applicantIncomeTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeAmount")]
            public string ApplicantIncomeAmount
            {
                get
                {
                    return this.applicantIncomeAmountField;
                }
                set
                {
                    this.applicantIncomeAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeDesc")]
            public string ApplicantIncomeDesc
            {
                get
                {
                    return this.applicantIncomeDescField;
                }
                set
                {
                    this.applicantIncomeDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeType")]
            public string ApplicantIncomeType
            {
                get
                {
                    return this.applicantIncomeTypeField;
                }
                set
                {
                    this.applicantIncomeTypeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem
        {

            private string applicantExpenditureAmountField;

            private string applicantExpenditureDescField;

            private string applicantExpenditureTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ExpenditureAmount")]
            public string ApplicantExpenditureAmount
            {
                get
                {
                    return this.applicantExpenditureAmountField;
                }
                set
                {
                    this.applicantExpenditureAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ExpenditureDesc")]
            public string ApplicantExpenditureDesc
            {
                get
                {
                    return this.applicantExpenditureDescField;
                }
                set
                {
                    this.applicantExpenditureDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ExpenditureType")]
            public string ApplicantExpenditureType
            {
                get
                {
                    return this.applicantExpenditureTypeField;
                }
                set
                {
                    this.applicantExpenditureTypeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantBankAccount
        {

            private string applicantAccountBalanceField;

            private string applicantAccountBranchField;

            private string applicantAccountInstitutionField;

            private string applicantAccountNameField;

            private string applicantAccountNumberField;

            private string applicantAccountTypeField;

            private string applicantIsMainAccountField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountBalance")]
            public string ApplicantAccountBalance
            {
                get
                {
                    return this.applicantAccountBalanceField;
                }
                set
                {
                    this.applicantAccountBalanceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountBranch")]
            public string ApplicantAccountBranch
            {
                get
                {
                    return this.applicantAccountBranchField;
                }
                set
                {
                    this.applicantAccountBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountInstitution")]
            public string ApplicantAccountInstitution
            {
                get
                {
                    return this.applicantAccountInstitutionField;
                }
                set
                {
                    this.applicantAccountInstitutionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountName")]
            public string ApplicantAccountName
            {
                get
                {
                    return this.applicantAccountNameField;
                }
                set
                {
                    this.applicantAccountNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountNumber")]
            public string ApplicantAccountNumber
            {
                get
                {
                    return this.applicantAccountNumberField;
                }
                set
                {
                    this.applicantAccountNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountType")]
            public string ApplicantAccountType
            {
                get
                {
                    return this.applicantAccountTypeField;
                }
                set
                {
                    this.applicantAccountTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IsMainAccount")]
            public string ApplicantIsMainAccount
            {
                get
                {
                    return this.applicantIsMainAccountField;
                }
                set
                {
                    this.applicantIsMainAccountField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetails
        {

            private string applicantCellphoneField;

            private string applicantCorrespondenceLanguageField;

            private string applicantCountryOfBirthField;

            private string applicantCountryPermitIssuedField;

            private string applicantDateJoinedEmployerField;

            private string applicantDateOfBirthField;

            private string applicantDatePassportExpiresField;

            private string applicantDateRehabilitatedField;

            private string applicantDateWorkContractExpiresField;

            private string applicantDateWorkContractIssuedField;

            private string applicantDeclaredInsolventField;

            private string applicantEmailAddressField;

            private string applicantEmployeeStatusField;

            private string applicantEmployerNameField;

            private string applicantEmployerOperatingYearsField;

            private string applicantEthnicGroupField;

            private string applicantFaxCodeField;

            private string applicantFaxNoField;

            private string applicantFirstNameField;

            private string applicantFNBCityOfBirthField;

            private string applicantFNBClientField;

            private string applicantFNBCountryOfCitizenshipField;

            private string applicantFNBCountryOfMarriageField;

            private string applicantFNBCountryResideWorkField;

            private string applicantFNBEmploymentSectorField;

            private string applicantFNBEmploymentTypeField;

            private string applicantFNBForeignTaxNumberField;

            private string applicantFNBForeignTaxReturnIdField;

            private string applicantFNBHighestQualificationField;

            private string applicantFNBInternationalWorkAddressField;

            private string applicantFNBIsFirstRandEmployeeField;

            private string applicantFNBIsInternationalAddressField;

            private string applicantFNBIsSuretyField;

            private string applicantFNBMarketingConsentIdField;

            private string applicantFNBPostalAddressCountryField;

            private string applicantFNBRandEmployeeNumberField;

            private string applicantFNBResidentialAddressCountryField;

            private string applicantFNBSourceOfIncome1Field;

            private string applicantFNBSourceOfIncome2Field;

            private string applicantFNBSourceOfIncome3Field;

            private string applicantFNBSourceOfIncome4Field;

            private string applicantFNBSourceOfIncome5Field;

            private string applicantFNBTaxPayerInResidentCountryField;

            private string applicantFNBTypeOfPermitField;

            private string applicantGenderField;

            private string applicantHomePhoneField;

            private string applicantHomePhoneCodeField;

            private string applicantHouseholdSizeField;

            private string applicantIdentificationNoField;

            private string applicantIdentificationTypeField;

            private string applicantInsolventDateField;

            private string applicantJurisdictionField;

            private string applicantJurisdiction1Field;

            private string applicantJurisdiction2Field;

            private string applicantJurisdiction3Field;

            private string applicantJurisdiction4Field;

            private string applicantMaritalStatusField;

            private string applicantMarriedStatusField;

            private string applicantMayBankContactYouField;

            private string applicantMayDoCreditBureauEnquiryField;

            private string applicantNationalityField;

            private string applicantNoOfDependentsField;

            private string applicantOccupationField;

            private string applicantOccupationLevelField;

            private string applicantPassportNoField;

            private string applicantPermanentResidentField;

            private string applicantPermanentResidentCountryField;

            private string applicantPermanentResidentNoField;

            private string applicantPermitIssueDateField;

            private string applicantPhysicalAddressCityField;

            private string applicantPhysicalAddressCodeField;

            private string applicantPhysicalAddressLine1Field;

            private string applicantPhysicalAddressLine2Field;

            private string applicantPhysicalAddressSuburbField;

            private string applicantPostalAddressCityField;

            private string applicantPostalAddressCodeField;

            private string applicantPostalAddressLine1Field;

            private string applicantPostalAddressLine2Field;

            private string applicantPostalAddressSuburbField;

            private string applicantPreferredContactDeliveryField;

            private string applicantPreviousEmployerNameField;

            private string applicantPreviousEmployerPeriodField;

            private string applicantRehabilitatedField;

            private string applicantRightOfRefusalConsentField;

            private string applicantSACitizenField;

            private string applicantSurnameField;

            private string applicantTaxIdentificationNumberField;

            private string applicantTaxIdentificationNumber1Field;

            private string applicantTaxIdentificationNumber2Field;

            private string applicantTaxIdentificationNumber3Field;

            private string applicantTaxIdentificationNumber4Field;

            private string applicantTaxIdentificationReasonField;

            private string applicantTaxIdentificationReason1Field;

            private string applicantTaxIdentificationReason2Field;

            private string applicantTaxIdentificationReason3Field;

            private string applicantTaxIdentificationReason4Field;

            private string applicantTempResidentField;

            private string applicantTempResidentPermitExpiryField;

            private string applicantTempResidentPermitNoField;

            private string applicantTitleField;

            private string applicantTypeOfIncomeField;

            private string applicantWorkPhoneField;

            private string applicantWorkPhoneCodeField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantIncomeItem[] applicantIncomeItemsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantExpenditureItem[] applicantExpenditureItemsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantBankAccount[] applicantBankAccountsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetails applicantSpouseDetailsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Cellphone")]
            public string ApplicantCellphone
            {
                get
                {
                    return this.applicantCellphoneField;
                }
                set
                {
                    this.applicantCellphoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CorrespondenceLanguage")]
            public string ApplicantCorrespondenceLanguage
            {
                get
                {
                    return this.applicantCorrespondenceLanguageField;
                }
                set
                {
                    this.applicantCorrespondenceLanguageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CountryOfBirth")]
            public string ApplicantCountryOfBirth
            {
                get
                {
                    return this.applicantCountryOfBirthField;
                }
                set
                {
                    this.applicantCountryOfBirthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CountryPermitIssued")]
            public string ApplicantCountryPermitIssued
            {
                get
                {
                    return this.applicantCountryPermitIssuedField;
                }
                set
                {
                    this.applicantCountryPermitIssuedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateJoinedEmployer")]
            public string ApplicantDateJoinedEmployer
            {
                get
                {
                    return this.applicantDateJoinedEmployerField;
                }
                set
                {
                    this.applicantDateJoinedEmployerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateOfBirth")]
            public string ApplicantDateOfBirth
            {
                get
                {
                    return this.applicantDateOfBirthField;
                }
                set
                {
                    this.applicantDateOfBirthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DatePassportExpires")]
            public string ApplicantDatePassportExpires
            {
                get
                {
                    return this.applicantDatePassportExpiresField;
                }
                set
                {
                    this.applicantDatePassportExpiresField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateRehabilitated")]
            public string ApplicantDateRehabilitated
            {
                get
                {
                    return this.applicantDateRehabilitatedField;
                }
                set
                {
                    this.applicantDateRehabilitatedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateWorkContractExpires")]
            public string ApplicantDateWorkContractExpires
            {
                get
                {
                    return this.applicantDateWorkContractExpiresField;
                }
                set
                {
                    this.applicantDateWorkContractExpiresField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateWorkContractIssued")]
            public string ApplicantDateWorkContractIssued
            {
                get
                {
                    return this.applicantDateWorkContractIssuedField;
                }
                set
                {
                    this.applicantDateWorkContractIssuedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DeclaredInsolvent")]
            public string ApplicantDeclaredInsolvent
            {
                get
                {
                    return this.applicantDeclaredInsolventField;
                }
                set
                {
                    this.applicantDeclaredInsolventField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmailAddress")]
            public string ApplicantEmailAddress
            {
                get
                {
                    return this.applicantEmailAddressField;
                }
                set
                {
                    this.applicantEmailAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployeeStatus")]
            public string ApplicantEmployeeStatus
            {
                get
                {
                    return this.applicantEmployeeStatusField;
                }
                set
                {
                    this.applicantEmployeeStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerName")]
            public string ApplicantEmployerName
            {
                get
                {
                    return this.applicantEmployerNameField;
                }
                set
                {
                    this.applicantEmployerNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerOperatingYears")]
            public string ApplicantEmployerOperatingYears
            {
                get
                {
                    return this.applicantEmployerOperatingYearsField;
                }
                set
                {
                    this.applicantEmployerOperatingYearsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EthnicGroup")]
            public string ApplicantEthnicGroup
            {
                get
                {
                    return this.applicantEthnicGroupField;
                }
                set
                {
                    this.applicantEthnicGroupField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FaxCode")]
            public string ApplicantFaxCode
            {
                get
                {
                    return this.applicantFaxCodeField;
                }
                set
                {
                    this.applicantFaxCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FaxNo")]
            public string ApplicantFaxNo
            {
                get
                {
                    return this.applicantFaxNoField;
                }
                set
                {
                    this.applicantFaxNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FirstName")]
            public string ApplicantFirstName
            {
                get
                {
                    return this.applicantFirstNameField;
                }
                set
                {
                    this.applicantFirstNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBCityOfBirth")]
            public string ApplicantFNBCityOfBirth
            {
                get
                {
                    return this.applicantFNBCityOfBirthField;
                }
                set
                {
                    this.applicantFNBCityOfBirthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBClient")]
            public string ApplicantFNBClient
            {
                get
                {
                    return this.applicantFNBClientField;
                }
                set
                {
                    this.applicantFNBClientField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBCountryOfCitizenship")]
            public string ApplicantFNBCountryOfCitizenship
            {
                get
                {
                    return this.applicantFNBCountryOfCitizenshipField;
                }
                set
                {
                    this.applicantFNBCountryOfCitizenshipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBCountryOfMarriage")]
            public string ApplicantFNBCountryOfMarriage
            {
                get
                {
                    return this.applicantFNBCountryOfMarriageField;
                }
                set
                {
                    this.applicantFNBCountryOfMarriageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBCountryResideWork")]
            public string ApplicantFNBCountryResideWork
            {
                get
                {
                    return this.applicantFNBCountryResideWorkField;
                }
                set
                {
                    this.applicantFNBCountryResideWorkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBEmploymentSector")]
            public string ApplicantFNBEmploymentSector
            {
                get
                {
                    return this.applicantFNBEmploymentSectorField;
                }
                set
                {
                    this.applicantFNBEmploymentSectorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBEmploymentType")]
            public string ApplicantFNBEmploymentType
            {
                get
                {
                    return this.applicantFNBEmploymentTypeField;
                }
                set
                {
                    this.applicantFNBEmploymentTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBForeignTaxNumber")]
            public string ApplicantFNBForeignTaxNumber
            {
                get
                {
                    return this.applicantFNBForeignTaxNumberField;
                }
                set
                {
                    this.applicantFNBForeignTaxNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBForeignTaxReturnId")]
            public string ApplicantFNBForeignTaxReturnId
            {
                get
                {
                    return this.applicantFNBForeignTaxReturnIdField;
                }
                set
                {
                    this.applicantFNBForeignTaxReturnIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBHighestQualification")]
            public string ApplicantFNBHighestQualification
            {
                get
                {
                    return this.applicantFNBHighestQualificationField;
                }
                set
                {
                    this.applicantFNBHighestQualificationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBInternationalWorkAddress")]
            public string ApplicantFNBInternationalWorkAddress
            {
                get
                {
                    return this.applicantFNBInternationalWorkAddressField;
                }
                set
                {
                    this.applicantFNBInternationalWorkAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBIsFirstRandEmployee")]
            public string ApplicantFNBIsFirstRandEmployee
            {
                get
                {
                    return this.applicantFNBIsFirstRandEmployeeField;
                }
                set
                {
                    this.applicantFNBIsFirstRandEmployeeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBIsInternationalAddress")]
            public string ApplicantFNBIsInternationalAddress
            {
                get
                {
                    return this.applicantFNBIsInternationalAddressField;
                }
                set
                {
                    this.applicantFNBIsInternationalAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBIsSurety")]
            public string ApplicantFNBIsSurety
            {
                get
                {
                    return this.applicantFNBIsSuretyField;
                }
                set
                {
                    this.applicantFNBIsSuretyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBMarketingConsentId")]
            public string ApplicantFNBMarketingConsentId
            {
                get
                {
                    return this.applicantFNBMarketingConsentIdField;
                }
                set
                {
                    this.applicantFNBMarketingConsentIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBPostalAddressCountry")]
            public string ApplicantFNBPostalAddressCountry
            {
                get
                {
                    return this.applicantFNBPostalAddressCountryField;
                }
                set
                {
                    this.applicantFNBPostalAddressCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBRandEmployeeNumber")]
            public string ApplicantFNBRandEmployeeNumber
            {
                get
                {
                    return this.applicantFNBRandEmployeeNumberField;
                }
                set
                {
                    this.applicantFNBRandEmployeeNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBResidentialAddressCountry")]
            public string ApplicantFNBResidentialAddressCountry
            {
                get
                {
                    return this.applicantFNBResidentialAddressCountryField;
                }
                set
                {
                    this.applicantFNBResidentialAddressCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome1")]
            public string ApplicantFNBSourceOfIncome1
            {
                get
                {
                    return this.applicantFNBSourceOfIncome1Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome2")]
            public string ApplicantFNBSourceOfIncome2
            {
                get
                {
                    return this.applicantFNBSourceOfIncome2Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome3")]
            public string ApplicantFNBSourceOfIncome3
            {
                get
                {
                    return this.applicantFNBSourceOfIncome3Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome4")]
            public string ApplicantFNBSourceOfIncome4
            {
                get
                {
                    return this.applicantFNBSourceOfIncome4Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome4Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome5")]
            public string ApplicantFNBSourceOfIncome5
            {
                get
                {
                    return this.applicantFNBSourceOfIncome5Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome5Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBTaxPayerInResidentCountry")]
            public string ApplicantFNBTaxPayerInResidentCountry
            {
                get
                {
                    return this.applicantFNBTaxPayerInResidentCountryField;
                }
                set
                {
                    this.applicantFNBTaxPayerInResidentCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBTypeOfPermit")]
            public string ApplicantFNBTypeOfPermit
            {
                get
                {
                    return this.applicantFNBTypeOfPermitField;
                }
                set
                {
                    this.applicantFNBTypeOfPermitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Gender")]
            public string ApplicantGender
            {
                get
                {
                    return this.applicantGenderField;
                }
                set
                {
                    this.applicantGenderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HomePhone")]
            public string ApplicantHomePhone
            {
                get
                {
                    return this.applicantHomePhoneField;
                }
                set
                {
                    this.applicantHomePhoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HomePhoneCode")]
            public string ApplicantHomePhoneCode
            {
                get
                {
                    return this.applicantHomePhoneCodeField;
                }
                set
                {
                    this.applicantHomePhoneCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HouseholdSize")]
            public string ApplicantHouseholdSize
            {
                get
                {
                    return this.applicantHouseholdSizeField;
                }
                set
                {
                    this.applicantHouseholdSizeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IdentificationNo")]
            public string ApplicantIdentificationNo
            {
                get
                {
                    return this.applicantIdentificationNoField;
                }
                set
                {
                    this.applicantIdentificationNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IdentificationType")]
            public string ApplicantIdentificationType
            {
                get
                {
                    return this.applicantIdentificationTypeField;
                }
                set
                {
                    this.applicantIdentificationTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.InsolventDate")]
            public string ApplicantInsolventDate
            {
                get
                {
                    return this.applicantInsolventDateField;
                }
                set
                {
                    this.applicantInsolventDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction")]
            public string ApplicantJurisdiction
            {
                get
                {
                    return this.applicantJurisdictionField;
                }
                set
                {
                    this.applicantJurisdictionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction1")]
            public string ApplicantJurisdiction1
            {
                get
                {
                    return this.applicantJurisdiction1Field;
                }
                set
                {
                    this.applicantJurisdiction1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction2")]
            public string ApplicantJurisdiction2
            {
                get
                {
                    return this.applicantJurisdiction2Field;
                }
                set
                {
                    this.applicantJurisdiction2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction3")]
            public string ApplicantJurisdiction3
            {
                get
                {
                    return this.applicantJurisdiction3Field;
                }
                set
                {
                    this.applicantJurisdiction3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction4")]
            public string ApplicantJurisdiction4
            {
                get
                {
                    return this.applicantJurisdiction4Field;
                }
                set
                {
                    this.applicantJurisdiction4Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MaritalStatus")]
            public string ApplicantMaritalStatus
            {
                get
                {
                    return this.applicantMaritalStatusField;
                }
                set
                {
                    this.applicantMaritalStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MarriedStatus")]
            public string ApplicantMarriedStatus
            {
                get
                {
                    return this.applicantMarriedStatusField;
                }
                set
                {
                    this.applicantMarriedStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayBankContactYou")]
            public string ApplicantMayBankContactYou
            {
                get
                {
                    return this.applicantMayBankContactYouField;
                }
                set
                {
                    this.applicantMayBankContactYouField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayDoCreditBureauEnquiry")]
            public string ApplicantMayDoCreditBureauEnquiry
            {
                get
                {
                    return this.applicantMayDoCreditBureauEnquiryField;
                }
                set
                {
                    this.applicantMayDoCreditBureauEnquiryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Nationality")]
            public string ApplicantNationality
            {
                get
                {
                    return this.applicantNationalityField;
                }
                set
                {
                    this.applicantNationalityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NoOfDependents")]
            public string ApplicantNoOfDependents
            {
                get
                {
                    return this.applicantNoOfDependentsField;
                }
                set
                {
                    this.applicantNoOfDependentsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Occupation")]
            public string ApplicantOccupation
            {
                get
                {
                    return this.applicantOccupationField;
                }
                set
                {
                    this.applicantOccupationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.OccupationLevel")]
            public string ApplicantOccupationLevel
            {
                get
                {
                    return this.applicantOccupationLevelField;
                }
                set
                {
                    this.applicantOccupationLevelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PassportNo")]
            public string ApplicantPassportNo
            {
                get
                {
                    return this.applicantPassportNoField;
                }
                set
                {
                    this.applicantPassportNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermanentResident")]
            public string ApplicantPermanentResident
            {
                get
                {
                    return this.applicantPermanentResidentField;
                }
                set
                {
                    this.applicantPermanentResidentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermanentResidentCountry")]
            public string ApplicantPermanentResidentCountry
            {
                get
                {
                    return this.applicantPermanentResidentCountryField;
                }
                set
                {
                    this.applicantPermanentResidentCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermanentResidentNo")]
            public string ApplicantPermanentResidentNo
            {
                get
                {
                    return this.applicantPermanentResidentNoField;
                }
                set
                {
                    this.applicantPermanentResidentNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermitIssueDate")]
            public string ApplicantPermitIssueDate
            {
                get
                {
                    return this.applicantPermitIssueDateField;
                }
                set
                {
                    this.applicantPermitIssueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressCity")]
            public string ApplicantPhysicalAddressCity
            {
                get
                {
                    return this.applicantPhysicalAddressCityField;
                }
                set
                {
                    this.applicantPhysicalAddressCityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressCode")]
            public string ApplicantPhysicalAddressCode
            {
                get
                {
                    return this.applicantPhysicalAddressCodeField;
                }
                set
                {
                    this.applicantPhysicalAddressCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressLine1")]
            public string ApplicantPhysicalAddressLine1
            {
                get
                {
                    return this.applicantPhysicalAddressLine1Field;
                }
                set
                {
                    this.applicantPhysicalAddressLine1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressLine2")]
            public string ApplicantPhysicalAddressLine2
            {
                get
                {
                    return this.applicantPhysicalAddressLine2Field;
                }
                set
                {
                    this.applicantPhysicalAddressLine2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressSuburb")]
            public string ApplicantPhysicalAddressSuburb
            {
                get
                {
                    return this.applicantPhysicalAddressSuburbField;
                }
                set
                {
                    this.applicantPhysicalAddressSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressCity")]
            public string ApplicantPostalAddressCity
            {
                get
                {
                    return this.applicantPostalAddressCityField;
                }
                set
                {
                    this.applicantPostalAddressCityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressCode")]
            public string ApplicantPostalAddressCode
            {
                get
                {
                    return this.applicantPostalAddressCodeField;
                }
                set
                {
                    this.applicantPostalAddressCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressLine1")]
            public string ApplicantPostalAddressLine1
            {
                get
                {
                    return this.applicantPostalAddressLine1Field;
                }
                set
                {
                    this.applicantPostalAddressLine1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressLine2")]
            public string ApplicantPostalAddressLine2
            {
                get
                {
                    return this.applicantPostalAddressLine2Field;
                }
                set
                {
                    this.applicantPostalAddressLine2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressSuburb")]
            public string ApplicantPostalAddressSuburb
            {
                get
                {
                    return this.applicantPostalAddressSuburbField;
                }
                set
                {
                    this.applicantPostalAddressSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PreferredContactDelivery")]
            public string ApplicantPreferredContactDelivery
            {
                get
                {
                    return this.applicantPreferredContactDeliveryField;
                }
                set
                {
                    this.applicantPreferredContactDeliveryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PreviousEmployerName")]
            public string ApplicantPreviousEmployerName
            {
                get
                {
                    return this.applicantPreviousEmployerNameField;
                }
                set
                {
                    this.applicantPreviousEmployerNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PreviousEmployerPeriod")]
            public string ApplicantPreviousEmployerPeriod
            {
                get
                {
                    return this.applicantPreviousEmployerPeriodField;
                }
                set
                {
                    this.applicantPreviousEmployerPeriodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Rehabilitated")]
            public string ApplicantRehabilitated
            {
                get
                {
                    return this.applicantRehabilitatedField;
                }
                set
                {
                    this.applicantRehabilitatedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.RightOfRefusalConsent")]
            public string ApplicantRightOfRefusalConsent
            {
                get
                {
                    return this.applicantRightOfRefusalConsentField;
                }
                set
                {
                    this.applicantRightOfRefusalConsentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SACitizen")]
            public string ApplicantSACitizen
            {
                get
                {
                    return this.applicantSACitizenField;
                }
                set
                {
                    this.applicantSACitizenField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Surname")]
            public string ApplicantSurname
            {
                get
                {
                    return this.applicantSurnameField;
                }
                set
                {
                    this.applicantSurnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber")]
            public string ApplicantTaxIdentificationNumber
            {
                get
                {
                    return this.applicantTaxIdentificationNumberField;
                }
                set
                {
                    this.applicantTaxIdentificationNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber1")]
            public string ApplicantTaxIdentificationNumber1
            {
                get
                {
                    return this.applicantTaxIdentificationNumber1Field;
                }
                set
                {
                    this.applicantTaxIdentificationNumber1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber2")]
            public string ApplicantTaxIdentificationNumber2
            {
                get
                {
                    return this.applicantTaxIdentificationNumber2Field;
                }
                set
                {
                    this.applicantTaxIdentificationNumber2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber3")]
            public string ApplicantTaxIdentificationNumber3
            {
                get
                {
                    return this.applicantTaxIdentificationNumber3Field;
                }
                set
                {
                    this.applicantTaxIdentificationNumber3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber4")]
            public string ApplicantTaxIdentificationNumber4
            {
                get
                {
                    return this.applicantTaxIdentificationNumber4Field;
                }
                set
                {
                    this.applicantTaxIdentificationNumber4Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason")]
            public string ApplicantTaxIdentificationReason
            {
                get
                {
                    return this.applicantTaxIdentificationReasonField;
                }
                set
                {
                    this.applicantTaxIdentificationReasonField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason1")]
            public string ApplicantTaxIdentificationReason1
            {
                get
                {
                    return this.applicantTaxIdentificationReason1Field;
                }
                set
                {
                    this.applicantTaxIdentificationReason1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason2")]
            public string ApplicantTaxIdentificationReason2
            {
                get
                {
                    return this.applicantTaxIdentificationReason2Field;
                }
                set
                {
                    this.applicantTaxIdentificationReason2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason3")]
            public string ApplicantTaxIdentificationReason3
            {
                get
                {
                    return this.applicantTaxIdentificationReason3Field;
                }
                set
                {
                    this.applicantTaxIdentificationReason3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason4")]
            public string ApplicantTaxIdentificationReason4
            {
                get
                {
                    return this.applicantTaxIdentificationReason4Field;
                }
                set
                {
                    this.applicantTaxIdentificationReason4Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TempResident")]
            public string ApplicantTempResident
            {
                get
                {
                    return this.applicantTempResidentField;
                }
                set
                {
                    this.applicantTempResidentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TempResidentPermitExpiry")]
            public string ApplicantTempResidentPermitExpiry
            {
                get
                {
                    return this.applicantTempResidentPermitExpiryField;
                }
                set
                {
                    this.applicantTempResidentPermitExpiryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TempResidentPermitNo")]
            public string ApplicantTempResidentPermitNo
            {
                get
                {
                    return this.applicantTempResidentPermitNoField;
                }
                set
                {
                    this.applicantTempResidentPermitNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Title")]
            public string ApplicantTitle
            {
                get
                {
                    return this.applicantTitleField;
                }
                set
                {
                    this.applicantTitleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TypeOfIncome")]
            public string ApplicantTypeOfIncome
            {
                get
                {
                    return this.applicantTypeOfIncomeField;
                }
                set
                {
                    this.applicantTypeOfIncomeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.WorkPhone")]
            public string ApplicantWorkPhone
            {
                get
                {
                    return this.applicantWorkPhoneField;
                }
                set
                {
                    this.applicantWorkPhoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.WorkPhoneCode")]
            public string ApplicantWorkPhoneCode
            {
                get
                {
                    return this.applicantWorkPhoneCodeField;
                }
                set
                {
                    this.applicantWorkPhoneCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.IncomeItems")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.IncomeItem", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantIncomeItem[] ApplicantIncomeItems
            {
                get
                {
                    return this.applicantIncomeItemsField;
                }
                set
                {
                    this.applicantIncomeItemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.ExpenditureItems")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.ExpenditureItem", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantExpenditureItem[] ApplicantExpenditureItems
            {
                get
                {
                    return this.applicantExpenditureItemsField;
                }
                set
                {
                    this.applicantExpenditureItemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.BankAccounts")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.BankAccount", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantBankAccount[] ApplicantBankAccounts
            {
                get
                {
                    return this.applicantBankAccountsField;
                }
                set
                {
                    this.applicantBankAccountsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SpouseDetails")]
            public SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetails ApplicantSpouseDetails
            {
                get
                {
                    return this.applicantSpouseDetailsField;
                }
                set
                {
                    this.applicantSpouseDetailsField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantIncomeItem
        {

            private string applicantIncomeAmountField;

            private string applicantIncomeDescField;

            private string applicantIncomeTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeAmount")]
            public string ApplicantIncomeAmount
            {
                get
                {
                    return this.applicantIncomeAmountField;
                }
                set
                {
                    this.applicantIncomeAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeDesc")]
            public string ApplicantIncomeDesc
            {
                get
                {
                    return this.applicantIncomeDescField;
                }
                set
                {
                    this.applicantIncomeDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeType")]
            public string ApplicantIncomeType
            {
                get
                {
                    return this.applicantIncomeTypeField;
                }
                set
                {
                    this.applicantIncomeTypeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantExpenditureItem
        {

            private string applicantExpenditureAmountField;

            private string applicantExpenditureDescField;

            private string applicantExpenditureTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ExpenditureAmount")]
            public string ApplicantExpenditureAmount
            {
                get
                {
                    return this.applicantExpenditureAmountField;
                }
                set
                {
                    this.applicantExpenditureAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ExpenditureDesc")]
            public string ApplicantExpenditureDesc
            {
                get
                {
                    return this.applicantExpenditureDescField;
                }
                set
                {
                    this.applicantExpenditureDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ExpenditureType")]
            public string ApplicantExpenditureType
            {
                get
                {
                    return this.applicantExpenditureTypeField;
                }
                set
                {
                    this.applicantExpenditureTypeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantBankAccount
        {

            private string applicantAccountBalanceField;

            private string applicantAccountBranchField;

            private string applicantAccountInstitutionField;

            private string applicantAccountNameField;

            private string applicantAccountNumberField;

            private string applicantAccountTypeField;

            private string applicantIsMainAccountField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountBalance")]
            public string ApplicantAccountBalance
            {
                get
                {
                    return this.applicantAccountBalanceField;
                }
                set
                {
                    this.applicantAccountBalanceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountBranch")]
            public string ApplicantAccountBranch
            {
                get
                {
                    return this.applicantAccountBranchField;
                }
                set
                {
                    this.applicantAccountBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountInstitution")]
            public string ApplicantAccountInstitution
            {
                get
                {
                    return this.applicantAccountInstitutionField;
                }
                set
                {
                    this.applicantAccountInstitutionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountName")]
            public string ApplicantAccountName
            {
                get
                {
                    return this.applicantAccountNameField;
                }
                set
                {
                    this.applicantAccountNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountNumber")]
            public string ApplicantAccountNumber
            {
                get
                {
                    return this.applicantAccountNumberField;
                }
                set
                {
                    this.applicantAccountNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountType")]
            public string ApplicantAccountType
            {
                get
                {
                    return this.applicantAccountTypeField;
                }
                set
                {
                    this.applicantAccountTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IsMainAccount")]
            public string ApplicantIsMainAccount
            {
                get
                {
                    return this.applicantIsMainAccountField;
                }
                set
                {
                    this.applicantIsMainAccountField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetails
        {

            private string applicantCellphoneField;

            private string applicantCorrespondenceLanguageField;

            private string applicantCountryOfBirthField;

            private string applicantCountryPermitIssuedField;

            private string applicantDateJoinedEmployerField;

            private string applicantDateOfBirthField;

            private string applicantDatePassportExpiresField;

            private string applicantDateRehabilitatedField;

            private string applicantDateWorkContractExpiresField;

            private string applicantDateWorkContractIssuedField;

            private string applicantDeclaredInsolventField;

            private string applicantEmailAddressField;

            private string applicantEmployeeStatusField;

            private string applicantEmployerNameField;

            private string applicantEmployerOperatingYearsField;

            private string applicantEthnicGroupField;

            private string applicantFaxCodeField;

            private string applicantFaxNoField;

            private string applicantFirstNameField;

            private string applicantFNBCityOfBirthField;

            private string applicantFNBClientField;

            private string applicantFNBCountryOfCitizenshipField;

            private string applicantFNBCountryOfMarriageField;

            private string applicantFNBCountryResideWorkField;

            private string applicantFNBEmploymentSectorField;

            private string applicantFNBEmploymentTypeField;

            private string applicantFNBForeignTaxNumberField;

            private string applicantFNBForeignTaxReturnIdField;

            private string applicantFNBHighestQualificationField;

            private string applicantFNBInternationalWorkAddressField;

            private string applicantFNBIsFirstRandEmployeeField;

            private string applicantFNBIsInternationalAddressField;

            private string applicantFNBIsSuretyField;

            private string applicantFNBMarketingConsentIdField;

            private string applicantFNBPostalAddressCountryField;

            private string applicantFNBRandEmployeeNumberField;

            private string applicantFNBResidentialAddressCountryField;

            private string applicantFNBSourceOfIncome1Field;

            private string applicantFNBSourceOfIncome2Field;

            private string applicantFNBSourceOfIncome3Field;

            private string applicantFNBSourceOfIncome4Field;

            private string applicantFNBSourceOfIncome5Field;

            private string applicantFNBTaxPayerInResidentCountryField;

            private string applicantFNBTypeOfPermitField;

            private string applicantGenderField;

            private string applicantHomePhoneField;

            private string applicantHomePhoneCodeField;

            private string applicantIdentificationNoField;

            private string applicantIdentificationTypeField;

            private string applicantInsolventDateField;

            private string applicantJurisdictionField;

            private string applicantJurisdiction1Field;

            private string applicantJurisdiction2Field;

            private string applicantJurisdiction3Field;

            private string applicantJurisdiction4Field;

            private string applicantMaritalStatusField;

            private string applicantMarriedStatusField;

            private string applicantMayBankContactYouField;

            private string applicantMayDoCreditBureauEnquiryField;

            private string applicantNationalityField;

            private string applicantNoOfDependentsField;

            private string applicantOccupationField;

            private string applicantOccupationLevelField;

            private string applicantPassportNoField;

            private string applicantPermanentResidentField;

            private string applicantPermanentResidentCountryField;

            private string applicantPermanentResidentNoField;

            private string applicantPermitIssueDateField;

            private string applicantPhysicalAddressCityField;

            private string applicantPhysicalAddressCodeField;

            private string applicantPhysicalAddressLine1Field;

            private string applicantPhysicalAddressLine2Field;

            private string applicantPhysicalAddressSuburbField;

            private string applicantPostalAddressCityField;

            private string applicantPostalAddressCodeField;

            private string applicantPostalAddressLine1Field;

            private string applicantPostalAddressLine2Field;

            private string applicantPostalAddressSuburbField;

            private string applicantPreferredContactDeliveryField;

            private string applicantPreviousEmployerNameField;

            private string applicantPreviousEmployerPeriodField;

            private string applicantRehabilitatedField;

            private string applicantRightOfRefusalConsentField;

            private string applicantSACitizenField;

            private string applicantSurnameField;

            private string applicantTaxIdentificationNumberField;

            private string applicantTaxIdentificationNumber1Field;

            private string applicantTaxIdentificationNumber2Field;

            private string applicantTaxIdentificationNumber3Field;

            private string applicantTaxIdentificationNumber4Field;

            private string applicantTaxIdentificationReasonField;

            private string applicantTaxIdentificationReason1Field;

            private string applicantTaxIdentificationReason2Field;

            private string applicantTaxIdentificationReason3Field;

            private string applicantTaxIdentificationReason4Field;

            private string applicantTempResidentField;

            private string applicantTempResidentPermitExpiryField;

            private string applicantTempResidentPermitNoField;

            private string applicantTitleField;

            private string applicantTypeOfIncomeField;

            private string applicantWorkPhoneField;

            private string applicantWorkPhoneCodeField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem[] applicantIncomeItemsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem[] applicantExpenditureItemsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantBankAccount[] applicantBankAccountsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Cellphone")]
            public string ApplicantCellphone
            {
                get
                {
                    return this.applicantCellphoneField;
                }
                set
                {
                    this.applicantCellphoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CorrespondenceLanguage")]
            public string ApplicantCorrespondenceLanguage
            {
                get
                {
                    return this.applicantCorrespondenceLanguageField;
                }
                set
                {
                    this.applicantCorrespondenceLanguageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CountryOfBirth")]
            public string ApplicantCountryOfBirth
            {
                get
                {
                    return this.applicantCountryOfBirthField;
                }
                set
                {
                    this.applicantCountryOfBirthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CountryPermitIssued")]
            public string ApplicantCountryPermitIssued
            {
                get
                {
                    return this.applicantCountryPermitIssuedField;
                }
                set
                {
                    this.applicantCountryPermitIssuedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateJoinedEmployer")]
            public string ApplicantDateJoinedEmployer
            {
                get
                {
                    return this.applicantDateJoinedEmployerField;
                }
                set
                {
                    this.applicantDateJoinedEmployerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateOfBirth")]
            public string ApplicantDateOfBirth
            {
                get
                {
                    return this.applicantDateOfBirthField;
                }
                set
                {
                    this.applicantDateOfBirthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DatePassportExpires")]
            public string ApplicantDatePassportExpires
            {
                get
                {
                    return this.applicantDatePassportExpiresField;
                }
                set
                {
                    this.applicantDatePassportExpiresField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateRehabilitated")]
            public string ApplicantDateRehabilitated
            {
                get
                {
                    return this.applicantDateRehabilitatedField;
                }
                set
                {
                    this.applicantDateRehabilitatedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateWorkContractExpires")]
            public string ApplicantDateWorkContractExpires
            {
                get
                {
                    return this.applicantDateWorkContractExpiresField;
                }
                set
                {
                    this.applicantDateWorkContractExpiresField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DateWorkContractIssued")]
            public string ApplicantDateWorkContractIssued
            {
                get
                {
                    return this.applicantDateWorkContractIssuedField;
                }
                set
                {
                    this.applicantDateWorkContractIssuedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DeclaredInsolvent")]
            public string ApplicantDeclaredInsolvent
            {
                get
                {
                    return this.applicantDeclaredInsolventField;
                }
                set
                {
                    this.applicantDeclaredInsolventField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmailAddress")]
            public string ApplicantEmailAddress
            {
                get
                {
                    return this.applicantEmailAddressField;
                }
                set
                {
                    this.applicantEmailAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployeeStatus")]
            public string ApplicantEmployeeStatus
            {
                get
                {
                    return this.applicantEmployeeStatusField;
                }
                set
                {
                    this.applicantEmployeeStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerName")]
            public string ApplicantEmployerName
            {
                get
                {
                    return this.applicantEmployerNameField;
                }
                set
                {
                    this.applicantEmployerNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerOperatingYears")]
            public string ApplicantEmployerOperatingYears
            {
                get
                {
                    return this.applicantEmployerOperatingYearsField;
                }
                set
                {
                    this.applicantEmployerOperatingYearsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EthnicGroup")]
            public string ApplicantEthnicGroup
            {
                get
                {
                    return this.applicantEthnicGroupField;
                }
                set
                {
                    this.applicantEthnicGroupField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FaxCode")]
            public string ApplicantFaxCode
            {
                get
                {
                    return this.applicantFaxCodeField;
                }
                set
                {
                    this.applicantFaxCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FaxNo")]
            public string ApplicantFaxNo
            {
                get
                {
                    return this.applicantFaxNoField;
                }
                set
                {
                    this.applicantFaxNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FirstName")]
            public string ApplicantFirstName
            {
                get
                {
                    return this.applicantFirstNameField;
                }
                set
                {
                    this.applicantFirstNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBCityOfBirth")]
            public string ApplicantFNBCityOfBirth
            {
                get
                {
                    return this.applicantFNBCityOfBirthField;
                }
                set
                {
                    this.applicantFNBCityOfBirthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBClient")]
            public string ApplicantFNBClient
            {
                get
                {
                    return this.applicantFNBClientField;
                }
                set
                {
                    this.applicantFNBClientField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBCountryOfCitizenship")]
            public string ApplicantFNBCountryOfCitizenship
            {
                get
                {
                    return this.applicantFNBCountryOfCitizenshipField;
                }
                set
                {
                    this.applicantFNBCountryOfCitizenshipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBCountryOfMarriage")]
            public string ApplicantFNBCountryOfMarriage
            {
                get
                {
                    return this.applicantFNBCountryOfMarriageField;
                }
                set
                {
                    this.applicantFNBCountryOfMarriageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBCountryResideWork")]
            public string ApplicantFNBCountryResideWork
            {
                get
                {
                    return this.applicantFNBCountryResideWorkField;
                }
                set
                {
                    this.applicantFNBCountryResideWorkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBEmploymentSector")]
            public string ApplicantFNBEmploymentSector
            {
                get
                {
                    return this.applicantFNBEmploymentSectorField;
                }
                set
                {
                    this.applicantFNBEmploymentSectorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBEmploymentType")]
            public string ApplicantFNBEmploymentType
            {
                get
                {
                    return this.applicantFNBEmploymentTypeField;
                }
                set
                {
                    this.applicantFNBEmploymentTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBForeignTaxNumber")]
            public string ApplicantFNBForeignTaxNumber
            {
                get
                {
                    return this.applicantFNBForeignTaxNumberField;
                }
                set
                {
                    this.applicantFNBForeignTaxNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBForeignTaxReturnId")]
            public string ApplicantFNBForeignTaxReturnId
            {
                get
                {
                    return this.applicantFNBForeignTaxReturnIdField;
                }
                set
                {
                    this.applicantFNBForeignTaxReturnIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBHighestQualification")]
            public string ApplicantFNBHighestQualification
            {
                get
                {
                    return this.applicantFNBHighestQualificationField;
                }
                set
                {
                    this.applicantFNBHighestQualificationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBInternationalWorkAddress")]
            public string ApplicantFNBInternationalWorkAddress
            {
                get
                {
                    return this.applicantFNBInternationalWorkAddressField;
                }
                set
                {
                    this.applicantFNBInternationalWorkAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBIsFirstRandEmployee")]
            public string ApplicantFNBIsFirstRandEmployee
            {
                get
                {
                    return this.applicantFNBIsFirstRandEmployeeField;
                }
                set
                {
                    this.applicantFNBIsFirstRandEmployeeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBIsInternationalAddress")]
            public string ApplicantFNBIsInternationalAddress
            {
                get
                {
                    return this.applicantFNBIsInternationalAddressField;
                }
                set
                {
                    this.applicantFNBIsInternationalAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBIsSurety")]
            public string ApplicantFNBIsSurety
            {
                get
                {
                    return this.applicantFNBIsSuretyField;
                }
                set
                {
                    this.applicantFNBIsSuretyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBMarketingConsentId")]
            public string ApplicantFNBMarketingConsentId
            {
                get
                {
                    return this.applicantFNBMarketingConsentIdField;
                }
                set
                {
                    this.applicantFNBMarketingConsentIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBPostalAddressCountry")]
            public string ApplicantFNBPostalAddressCountry
            {
                get
                {
                    return this.applicantFNBPostalAddressCountryField;
                }
                set
                {
                    this.applicantFNBPostalAddressCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBRandEmployeeNumber")]
            public string ApplicantFNBRandEmployeeNumber
            {
                get
                {
                    return this.applicantFNBRandEmployeeNumberField;
                }
                set
                {
                    this.applicantFNBRandEmployeeNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBResidentialAddressCountry")]
            public string ApplicantFNBResidentialAddressCountry
            {
                get
                {
                    return this.applicantFNBResidentialAddressCountryField;
                }
                set
                {
                    this.applicantFNBResidentialAddressCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome1")]
            public string ApplicantFNBSourceOfIncome1
            {
                get
                {
                    return this.applicantFNBSourceOfIncome1Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome2")]
            public string ApplicantFNBSourceOfIncome2
            {
                get
                {
                    return this.applicantFNBSourceOfIncome2Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome3")]
            public string ApplicantFNBSourceOfIncome3
            {
                get
                {
                    return this.applicantFNBSourceOfIncome3Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome4")]
            public string ApplicantFNBSourceOfIncome4
            {
                get
                {
                    return this.applicantFNBSourceOfIncome4Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome4Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBSourceOfIncome5")]
            public string ApplicantFNBSourceOfIncome5
            {
                get
                {
                    return this.applicantFNBSourceOfIncome5Field;
                }
                set
                {
                    this.applicantFNBSourceOfIncome5Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBTaxPayerInResidentCountry")]
            public string ApplicantFNBTaxPayerInResidentCountry
            {
                get
                {
                    return this.applicantFNBTaxPayerInResidentCountryField;
                }
                set
                {
                    this.applicantFNBTaxPayerInResidentCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FNBTypeOfPermit")]
            public string ApplicantFNBTypeOfPermit
            {
                get
                {
                    return this.applicantFNBTypeOfPermitField;
                }
                set
                {
                    this.applicantFNBTypeOfPermitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Gender")]
            public string ApplicantGender
            {
                get
                {
                    return this.applicantGenderField;
                }
                set
                {
                    this.applicantGenderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HomePhone")]
            public string ApplicantHomePhone
            {
                get
                {
                    return this.applicantHomePhoneField;
                }
                set
                {
                    this.applicantHomePhoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HomePhoneCode")]
            public string ApplicantHomePhoneCode
            {
                get
                {
                    return this.applicantHomePhoneCodeField;
                }
                set
                {
                    this.applicantHomePhoneCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IdentificationNo")]
            public string ApplicantIdentificationNo
            {
                get
                {
                    return this.applicantIdentificationNoField;
                }
                set
                {
                    this.applicantIdentificationNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IdentificationType")]
            public string ApplicantIdentificationType
            {
                get
                {
                    return this.applicantIdentificationTypeField;
                }
                set
                {
                    this.applicantIdentificationTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.InsolventDate")]
            public string ApplicantInsolventDate
            {
                get
                {
                    return this.applicantInsolventDateField;
                }
                set
                {
                    this.applicantInsolventDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction")]
            public string ApplicantJurisdiction
            {
                get
                {
                    return this.applicantJurisdictionField;
                }
                set
                {
                    this.applicantJurisdictionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction1")]
            public string ApplicantJurisdiction1
            {
                get
                {
                    return this.applicantJurisdiction1Field;
                }
                set
                {
                    this.applicantJurisdiction1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction2")]
            public string ApplicantJurisdiction2
            {
                get
                {
                    return this.applicantJurisdiction2Field;
                }
                set
                {
                    this.applicantJurisdiction2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction3")]
            public string ApplicantJurisdiction3
            {
                get
                {
                    return this.applicantJurisdiction3Field;
                }
                set
                {
                    this.applicantJurisdiction3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Jurisdiction4")]
            public string ApplicantJurisdiction4
            {
                get
                {
                    return this.applicantJurisdiction4Field;
                }
                set
                {
                    this.applicantJurisdiction4Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MaritalStatus")]
            public string ApplicantMaritalStatus
            {
                get
                {
                    return this.applicantMaritalStatusField;
                }
                set
                {
                    this.applicantMaritalStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MarriedStatus")]
            public string ApplicantMarriedStatus
            {
                get
                {
                    return this.applicantMarriedStatusField;
                }
                set
                {
                    this.applicantMarriedStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayBankContactYou")]
            public string ApplicantMayBankContactYou
            {
                get
                {
                    return this.applicantMayBankContactYouField;
                }
                set
                {
                    this.applicantMayBankContactYouField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayDoCreditBureauEnquiry")]
            public string ApplicantMayDoCreditBureauEnquiry
            {
                get
                {
                    return this.applicantMayDoCreditBureauEnquiryField;
                }
                set
                {
                    this.applicantMayDoCreditBureauEnquiryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Nationality")]
            public string ApplicantNationality
            {
                get
                {
                    return this.applicantNationalityField;
                }
                set
                {
                    this.applicantNationalityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NoOfDependents")]
            public string ApplicantNoOfDependents
            {
                get
                {
                    return this.applicantNoOfDependentsField;
                }
                set
                {
                    this.applicantNoOfDependentsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Occupation")]
            public string ApplicantOccupation
            {
                get
                {
                    return this.applicantOccupationField;
                }
                set
                {
                    this.applicantOccupationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.OccupationLevel")]
            public string ApplicantOccupationLevel
            {
                get
                {
                    return this.applicantOccupationLevelField;
                }
                set
                {
                    this.applicantOccupationLevelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PassportNo")]
            public string ApplicantPassportNo
            {
                get
                {
                    return this.applicantPassportNoField;
                }
                set
                {
                    this.applicantPassportNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermanentResident")]
            public string ApplicantPermanentResident
            {
                get
                {
                    return this.applicantPermanentResidentField;
                }
                set
                {
                    this.applicantPermanentResidentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermanentResidentCountry")]
            public string ApplicantPermanentResidentCountry
            {
                get
                {
                    return this.applicantPermanentResidentCountryField;
                }
                set
                {
                    this.applicantPermanentResidentCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermanentResidentNo")]
            public string ApplicantPermanentResidentNo
            {
                get
                {
                    return this.applicantPermanentResidentNoField;
                }
                set
                {
                    this.applicantPermanentResidentNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermitIssueDate")]
            public string ApplicantPermitIssueDate
            {
                get
                {
                    return this.applicantPermitIssueDateField;
                }
                set
                {
                    this.applicantPermitIssueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressCity")]
            public string ApplicantPhysicalAddressCity
            {
                get
                {
                    return this.applicantPhysicalAddressCityField;
                }
                set
                {
                    this.applicantPhysicalAddressCityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressCode")]
            public string ApplicantPhysicalAddressCode
            {
                get
                {
                    return this.applicantPhysicalAddressCodeField;
                }
                set
                {
                    this.applicantPhysicalAddressCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressLine1")]
            public string ApplicantPhysicalAddressLine1
            {
                get
                {
                    return this.applicantPhysicalAddressLine1Field;
                }
                set
                {
                    this.applicantPhysicalAddressLine1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressLine2")]
            public string ApplicantPhysicalAddressLine2
            {
                get
                {
                    return this.applicantPhysicalAddressLine2Field;
                }
                set
                {
                    this.applicantPhysicalAddressLine2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PhysicalAddressSuburb")]
            public string ApplicantPhysicalAddressSuburb
            {
                get
                {
                    return this.applicantPhysicalAddressSuburbField;
                }
                set
                {
                    this.applicantPhysicalAddressSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressCity")]
            public string ApplicantPostalAddressCity
            {
                get
                {
                    return this.applicantPostalAddressCityField;
                }
                set
                {
                    this.applicantPostalAddressCityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressCode")]
            public string ApplicantPostalAddressCode
            {
                get
                {
                    return this.applicantPostalAddressCodeField;
                }
                set
                {
                    this.applicantPostalAddressCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressLine1")]
            public string ApplicantPostalAddressLine1
            {
                get
                {
                    return this.applicantPostalAddressLine1Field;
                }
                set
                {
                    this.applicantPostalAddressLine1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressLine2")]
            public string ApplicantPostalAddressLine2
            {
                get
                {
                    return this.applicantPostalAddressLine2Field;
                }
                set
                {
                    this.applicantPostalAddressLine2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalAddressSuburb")]
            public string ApplicantPostalAddressSuburb
            {
                get
                {
                    return this.applicantPostalAddressSuburbField;
                }
                set
                {
                    this.applicantPostalAddressSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PreferredContactDelivery")]
            public string ApplicantPreferredContactDelivery
            {
                get
                {
                    return this.applicantPreferredContactDeliveryField;
                }
                set
                {
                    this.applicantPreferredContactDeliveryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PreviousEmployerName")]
            public string ApplicantPreviousEmployerName
            {
                get
                {
                    return this.applicantPreviousEmployerNameField;
                }
                set
                {
                    this.applicantPreviousEmployerNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PreviousEmployerPeriod")]
            public string ApplicantPreviousEmployerPeriod
            {
                get
                {
                    return this.applicantPreviousEmployerPeriodField;
                }
                set
                {
                    this.applicantPreviousEmployerPeriodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Rehabilitated")]
            public string ApplicantRehabilitated
            {
                get
                {
                    return this.applicantRehabilitatedField;
                }
                set
                {
                    this.applicantRehabilitatedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.RightOfRefusalConsent")]
            public string ApplicantRightOfRefusalConsent
            {
                get
                {
                    return this.applicantRightOfRefusalConsentField;
                }
                set
                {
                    this.applicantRightOfRefusalConsentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SACitizen")]
            public string ApplicantSACitizen
            {
                get
                {
                    return this.applicantSACitizenField;
                }
                set
                {
                    this.applicantSACitizenField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Surname")]
            public string ApplicantSurname
            {
                get
                {
                    return this.applicantSurnameField;
                }
                set
                {
                    this.applicantSurnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber")]
            public string ApplicantTaxIdentificationNumber
            {
                get
                {
                    return this.applicantTaxIdentificationNumberField;
                }
                set
                {
                    this.applicantTaxIdentificationNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber1")]
            public string ApplicantTaxIdentificationNumber1
            {
                get
                {
                    return this.applicantTaxIdentificationNumber1Field;
                }
                set
                {
                    this.applicantTaxIdentificationNumber1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber2")]
            public string ApplicantTaxIdentificationNumber2
            {
                get
                {
                    return this.applicantTaxIdentificationNumber2Field;
                }
                set
                {
                    this.applicantTaxIdentificationNumber2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber3")]
            public string ApplicantTaxIdentificationNumber3
            {
                get
                {
                    return this.applicantTaxIdentificationNumber3Field;
                }
                set
                {
                    this.applicantTaxIdentificationNumber3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationNumber4")]
            public string ApplicantTaxIdentificationNumber4
            {
                get
                {
                    return this.applicantTaxIdentificationNumber4Field;
                }
                set
                {
                    this.applicantTaxIdentificationNumber4Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason")]
            public string ApplicantTaxIdentificationReason
            {
                get
                {
                    return this.applicantTaxIdentificationReasonField;
                }
                set
                {
                    this.applicantTaxIdentificationReasonField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason1")]
            public string ApplicantTaxIdentificationReason1
            {
                get
                {
                    return this.applicantTaxIdentificationReason1Field;
                }
                set
                {
                    this.applicantTaxIdentificationReason1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason2")]
            public string ApplicantTaxIdentificationReason2
            {
                get
                {
                    return this.applicantTaxIdentificationReason2Field;
                }
                set
                {
                    this.applicantTaxIdentificationReason2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason3")]
            public string ApplicantTaxIdentificationReason3
            {
                get
                {
                    return this.applicantTaxIdentificationReason3Field;
                }
                set
                {
                    this.applicantTaxIdentificationReason3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TaxIdentificationReason4")]
            public string ApplicantTaxIdentificationReason4
            {
                get
                {
                    return this.applicantTaxIdentificationReason4Field;
                }
                set
                {
                    this.applicantTaxIdentificationReason4Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TempResident")]
            public string ApplicantTempResident
            {
                get
                {
                    return this.applicantTempResidentField;
                }
                set
                {
                    this.applicantTempResidentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TempResidentPermitExpiry")]
            public string ApplicantTempResidentPermitExpiry
            {
                get
                {
                    return this.applicantTempResidentPermitExpiryField;
                }
                set
                {
                    this.applicantTempResidentPermitExpiryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TempResidentPermitNo")]
            public string ApplicantTempResidentPermitNo
            {
                get
                {
                    return this.applicantTempResidentPermitNoField;
                }
                set
                {
                    this.applicantTempResidentPermitNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Title")]
            public string ApplicantTitle
            {
                get
                {
                    return this.applicantTitleField;
                }
                set
                {
                    this.applicantTitleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.TypeOfIncome")]
            public string ApplicantTypeOfIncome
            {
                get
                {
                    return this.applicantTypeOfIncomeField;
                }
                set
                {
                    this.applicantTypeOfIncomeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.WorkPhone")]
            public string ApplicantWorkPhone
            {
                get
                {
                    return this.applicantWorkPhoneField;
                }
                set
                {
                    this.applicantWorkPhoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.WorkPhoneCode")]
            public string ApplicantWorkPhoneCode
            {
                get
                {
                    return this.applicantWorkPhoneCodeField;
                }
                set
                {
                    this.applicantWorkPhoneCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.IncomeItems")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.IncomeItem", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem[] ApplicantIncomeItems
            {
                get
                {
                    return this.applicantIncomeItemsField;
                }
                set
                {
                    this.applicantIncomeItemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.ExpenditureItems")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.ExpenditureItem", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem[] ApplicantExpenditureItems
            {
                get
                {
                    return this.applicantExpenditureItemsField;
                }
                set
                {
                    this.applicantExpenditureItemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.BankAccounts")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.BankAccount", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantBankAccount[] ApplicantBankAccounts
            {
                get
                {
                    return this.applicantBankAccountsField;
                }
                set
                {
                    this.applicantBankAccountsField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem
        {

            private string applicantIncomeAmountField;

            private string applicantIncomeDescField;

            private string applicantIncomeTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeAmount")]
            public string ApplicantIncomeAmount
            {
                get
                {
                    return this.applicantIncomeAmountField;
                }
                set
                {
                    this.applicantIncomeAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeDesc")]
            public string ApplicantIncomeDesc
            {
                get
                {
                    return this.applicantIncomeDescField;
                }
                set
                {
                    this.applicantIncomeDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeType")]
            public string ApplicantIncomeType
            {
                get
                {
                    return this.applicantIncomeTypeField;
                }
                set
                {
                    this.applicantIncomeTypeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem
        {

            private string applicantExpenditureAmountField;

            private string applicantExpenditureDescField;

            private string applicantExpenditureTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ExpenditureAmount")]
            public string ApplicantExpenditureAmount
            {
                get
                {
                    return this.applicantExpenditureAmountField;
                }
                set
                {
                    this.applicantExpenditureAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ExpenditureDesc")]
            public string ApplicantExpenditureDesc
            {
                get
                {
                    return this.applicantExpenditureDescField;
                }
                set
                {
                    this.applicantExpenditureDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ExpenditureType")]
            public string ApplicantExpenditureType
            {
                get
                {
                    return this.applicantExpenditureTypeField;
                }
                set
                {
                    this.applicantExpenditureTypeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantBankAccount
        {

            private string applicantAccountBalanceField;

            private string applicantAccountBranchField;

            private string applicantAccountInstitutionField;

            private string applicantAccountNameField;

            private string applicantAccountNumberField;

            private string applicantAccountTypeField;

            private string applicantIsMainAccountField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountBalance")]
            public string ApplicantAccountBalance
            {
                get
                {
                    return this.applicantAccountBalanceField;
                }
                set
                {
                    this.applicantAccountBalanceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountBranch")]
            public string ApplicantAccountBranch
            {
                get
                {
                    return this.applicantAccountBranchField;
                }
                set
                {
                    this.applicantAccountBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountInstitution")]
            public string ApplicantAccountInstitution
            {
                get
                {
                    return this.applicantAccountInstitutionField;
                }
                set
                {
                    this.applicantAccountInstitutionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountName")]
            public string ApplicantAccountName
            {
                get
                {
                    return this.applicantAccountNameField;
                }
                set
                {
                    this.applicantAccountNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountNumber")]
            public string ApplicantAccountNumber
            {
                get
                {
                    return this.applicantAccountNumberField;
                }
                set
                {
                    this.applicantAccountNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountType")]
            public string ApplicantAccountType
            {
                get
                {
                    return this.applicantAccountTypeField;
                }
                set
                {
                    this.applicantAccountTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IsMainAccount")]
            public string ApplicantIsMainAccount
            {
                get
                {
                    return this.applicantIsMainAccountField;
                }
                set
                {
                    this.applicantIsMainAccountField = value;
                }
            }
        }
    }
}
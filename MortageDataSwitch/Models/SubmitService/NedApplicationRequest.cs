using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortageDataSwitch.Models.SubmitService
{
    public static class NedApplicationRequest
    {

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationDetails
        {

            private string applicationAdvancePaymentOptionField;

            private string applicationAgencyCellphoneField;

            private string applicationAgencyFaxField;

            private string applicationAgencyPhysicalAddressField;

            private string applicationAgencyPhysicalCityField;

            private string applicationAgencyTelField;

            private string applicationAgentNameField;

            private string applicationAgriculturalIndicatorField;

            private string applicationAIPBanksField;

            private string applicationApplicationOriginField;

            private string applicationAreaOfLandField;

            private string applicationAssuranceLPATypeField;

            private string applicationAssuranceMonthlyPremiumField;

            private string applicationAssurancePaymentMethodField;

            private string applicationAttorneyRequestedByField;

            private string applicationBondAmountField;

            private string applicationBondAttorneyField;

            private string applicationBusinessCountryField;

            private string applicationBusinessEmailField;

            private string applicationBusinessFaxCodeField;

            private string applicationBusinessFaxNumberField;

            private string applicationBusinessSourceOfIncomeOtherField;

            private string applicationBusinessTelephoneCodeField = null;

            private string applicationBusinessTelephoneNumberField;

            private string applicationCommercialOrBusinessField;

            private string applicationCommercialTitleField;

            private string applicationComplexNameField;

            private string applicationConsultantCellphoneField;

            private string applicationConsultantEmailAddressField;

            private string applicationConsultantFaxNoField;

            private string applicationConsultantWorkTelNoField;

            private string applicationContractPriceField;

            private string applicationDebitAccountNoField;

            private string applicationDebitAccountTypeField;

            private string applicationDeclinedBanksField;

            private string applicationDwellingPurposeField;

            private string applicationEconomicSectorField;

            private string applicationEstateAgencyField;

            private string applicationFinancialYearEndField;

            private string applicationFirstPropertyPurchaseField;

            private string applicationFuturePostalAddress1Field;

            private string applicationFuturePostalAddressCityField;

            private string applicationFuturePostalAddressCodeField;

            private string applicationFuturePostalAddressSuburbField;

            private string applicationIncludeBondTransferCostsField;

            private string applicationIndicateInsuranceOptionField;

            private string applicationInitFeePaymentOptionField;

            private string applicationInstalmentMethodField;

            private string applicationInsuranceCompanyField;

            private string applicationInsuranceCoverReasonField;

            private string applicationInsuranceMonthlyPremiumField;

            private string applicationInsurancePaymentMethodField;

            private string applicationInsurancePolicyNumberField;

            private string applicationLapaField;

            private string applicationLapaDistanceField;

            private string applicationLapaSizeField;

            private string applicationLoanAmountRequiredField;

            private string applicationMainBuildingSizeField;

            private string applicationManagingAgentDetailsField;

            private string applicationNamePropertyRegisteredField;

            private string applicationNedAgencyCodeField;

            private string applicationNedAgencyNameField;

            private string applicationNedAssuranceCompanyField;

            private string applicationNedAssuranceCoverAmountField;

            private string applicationNEDCompanyNameField;

            private string applicationNEDCompanyName2Field;

            private string applicationNedDebitAccountBranchField;

            private string applicationNedDebitAccountBranchCodeField;

            private string applicationNedDebitAccountInstitutionField;

            private string applicationNEDDeclarationOfWarrantyField;

            private string applicationNedLoanReasonField;

            private string applicationNEDMOIDateOfIssueField;

            private string applicationNEDMOIIndexedField;

            private string applicationNEDMOIIndicatorField;

            private string applicationNEDMOITypeField;

            private string applicationNedTypeOfPropertyField;

            private string applicationNedVendorDescriptionField;

            private string applicationNetworkField;

            private string applicationOriginatorEmailField;

            private string applicationOutBuildingNoField;

            private string applicationOwnAttorneyReasonField;

            private string applicationParkingBayNoField;

            private string applicationPaymentHolidayField;

            private string applicationPortionNoField;

            private string applicationProcessingRegionField;

            private string applicationPropertyAddressCityField;

            private string applicationPropertyAddressSuburbField;

            private string applicationPropertyBondAccountNoField;

            private string applicationPropertyBondBankField;

            private string applicationPropertyBondBranchField;

            private string applicationPropertyBondBranchCodeField;

            private string applicationPropertyContactCellphoneField;

            private string applicationPropertyContactNameField;

            private string applicationPropertyContactTelCodeField;

            private string applicationPropertyContactTelNoField;

            private string applicationPropertyCurrentlyBondedField;

            private string applicationPropertyDescriptionField;

            private string applicationPropertyOccupantContactField;

            private string applicationPropertyPostalCodeField;

            private string applicationPropertyProvinceField;

            private string applicationPropertyPurchaseDateField;

            private string applicationPropertyPurchasePriceField;

            private string applicationPropertyRightField;

            private string applicationPropertyRoofConstructionField;

            private string applicationPropertyStreetNameField;

            private string applicationPropertyStreetNoField;

            private string applicationPropertyWallConstructionField;

            private string applicationSectionalTitleRegisterField;

            private string applicationSectionalTitleUnitNoField;

            private string applicationSectionNoField;

            private string applicationSellerCellphoneField;

            private string applicationSellerNameField;

            private string applicationSellerTelNoField;

            private string applicationStandErfNoField;

            private string applicationStatementSentToIndicatorField;

            private string applicationSubmittingBanksField;

            private string applicationTermOfLoanField;

            private string applicationTransferAttorneyField;

            private string applicationTypeOfAssuranceField;

            private string applicationTypeOfGroupSchemeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.AdvancePaymentOption")]
            public string ApplicationAdvancePaymentOption
            {
                get
                {
                    return this.applicationAdvancePaymentOptionField;
                }
                set
                {
                    this.applicationAdvancePaymentOptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.AgencyCellphone")]
            public string ApplicationAgencyCellphone
            {
                get
                {
                    return this.applicationAgencyCellphoneField;
                }
                set
                {
                    this.applicationAgencyCellphoneField = value;
                }
            }

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
            [System.Xml.Serialization.XmlElementAttribute("Application.AgencyPhysicalAddress")]
            public string ApplicationAgencyPhysicalAddress
            {
                get
                {
                    return this.applicationAgencyPhysicalAddressField;
                }
                set
                {
                    this.applicationAgencyPhysicalAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.AgencyPhysicalCity")]
            public string ApplicationAgencyPhysicalCity
            {
                get
                {
                    return this.applicationAgencyPhysicalCityField;
                }
                set
                {
                    this.applicationAgencyPhysicalCityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.AgencyTel")]
            public string ApplicationAgencyTel
            {
                get
                {
                    return this.applicationAgencyTelField;
                }
                set
                {
                    this.applicationAgencyTelField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.AgriculturalIndicator")]
            public string ApplicationAgriculturalIndicator
            {
                get
                {
                    return this.applicationAgriculturalIndicatorField;
                }
                set
                {
                    this.applicationAgriculturalIndicatorField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.ApplicationOrigin")]
            public string ApplicationApplicationOrigin
            {
                get
                {
                    return this.applicationApplicationOriginField;
                }
                set
                {
                    this.applicationApplicationOriginField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.AreaOfLand")]
            public string ApplicationAreaOfLand
            {
                get
                {
                    return this.applicationAreaOfLandField;
                }
                set
                {
                    this.applicationAreaOfLandField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.AssuranceLPAType")]
            public string ApplicationAssuranceLPAType
            {
                get
                {
                    return this.applicationAssuranceLPATypeField;
                }
                set
                {
                    this.applicationAssuranceLPATypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.AssuranceMonthlyPremium")]
            public string ApplicationAssuranceMonthlyPremium
            {
                get
                {
                    return this.applicationAssuranceMonthlyPremiumField;
                }
                set
                {
                    this.applicationAssuranceMonthlyPremiumField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.AssurancePaymentMethod")]
            public string ApplicationAssurancePaymentMethod
            {
                get
                {
                    return this.applicationAssurancePaymentMethodField;
                }
                set
                {
                    this.applicationAssurancePaymentMethodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.AttorneyRequestedBy")]
            public string ApplicationAttorneyRequestedBy
            {
                get
                {
                    return this.applicationAttorneyRequestedByField;
                }
                set
                {
                    this.applicationAttorneyRequestedByField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.BondAmount")]
            public string ApplicationBondAmount
            {
                get
                {
                    return this.applicationBondAmountField;
                }
                set
                {
                    this.applicationBondAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.BondAttorney")]
            public string ApplicationBondAttorney
            {
                get
                {
                    return this.applicationBondAttorneyField;
                }
                set
                {
                    this.applicationBondAttorneyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.BusinessCountry")]
            public string ApplicationBusinessCountry
            {
                get
                {
                    return this.applicationBusinessCountryField;
                }
                set
                {
                    this.applicationBusinessCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.BusinessEmail")]
            public string ApplicationBusinessEmail
            {
                get
                {
                    return this.applicationBusinessEmailField;
                }
                set
                {
                    this.applicationBusinessEmailField = value;
                }
            }

            ///// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.BusinessFaxCode", IsNullable = false)]
            public string ApplicationBusinessFaxCode
            {
                get
                {
                    return this.applicationBusinessFaxCodeField;
                }
                set
                {
                    this.applicationBusinessFaxCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.BusinessFaxNumber")]
            public string ApplicationBusinessFaxNumber
            {
                get
                {
                    return this.applicationBusinessFaxNumberField;
                }
                set
                {
                    this.applicationBusinessFaxNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.BusinessSourceOfIncomeOther")]
            public string ApplicationBusinessSourceOfIncomeOther
            {
                get
                {
                    return this.applicationBusinessSourceOfIncomeOtherField;
                }
                set
                {
                    this.applicationBusinessSourceOfIncomeOtherField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.BusinessTelephoneCode", IsNullable = false)]
            public string ApplicationBusinessTelephoneCode
            {
                get
                {
                    return this.applicationBusinessTelephoneCodeField;
                }
                set
                {
                    this.applicationBusinessTelephoneCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.BusinessTelephoneNumber", IsNullable = false)]
            public string ApplicationBusinessTelephoneNumber
            {
                get
                {
                    return this.applicationBusinessTelephoneNumberField;
                }
                set
                {
                    this.applicationBusinessTelephoneNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.CommercialOrBusiness")]
            public string ApplicationCommercialOrBusiness
            {
                get
                {
                    return this.applicationCommercialOrBusinessField;
                }
                set
                {
                    this.applicationCommercialOrBusinessField = value;
                }
            }

            ///// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.CommercialTitle", IsNullable = false)]
            public string ApplicationCommercialTitle
            {
                get
                {
                    return this.applicationCommercialTitleField;
                }
                set
                {
                    this.applicationCommercialTitleField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.ConsultantEmailAddress")]
            public string ApplicationConsultantEmailAddress
            {
                get
                {
                    return this.applicationConsultantEmailAddressField;
                }
                set
                {
                    this.applicationConsultantEmailAddressField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.ConsultantWorkTelNo")]
            public string ApplicationConsultantWorkTelNo
            {
                get
                {
                    return this.applicationConsultantWorkTelNoField;
                }
                set
                {
                    this.applicationConsultantWorkTelNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.ContractPrice")]
            public string ApplicationContractPrice
            {
                get
                {
                    return this.applicationContractPriceField;
                }
                set
                {
                    this.applicationContractPriceField = value;
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

            ///// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.EconomicSector", IsNullable = false)]
            public string ApplicationEconomicSector
            {
                get
                {
                    return this.applicationEconomicSectorField;
                }
                set
                {
                    this.applicationEconomicSectorField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.FinancialYearEnd", IsNullable = false)]
            public string ApplicationFinancialYearEnd
            {
                get
                {
                    return this.applicationFinancialYearEndField;
                }
                set
                {
                    this.applicationFinancialYearEndField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.IndicateInsuranceOption")]
            public string ApplicationIndicateInsuranceOption
            {
                get
                {
                    return this.applicationIndicateInsuranceOptionField;
                }
                set
                {
                    this.applicationIndicateInsuranceOptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.InitFeePaymentOption")]
            public string ApplicationInitFeePaymentOption
            {
                get
                {
                    return this.applicationInitFeePaymentOptionField;
                }
                set
                {
                    this.applicationInitFeePaymentOptionField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.InsuranceCompany")]
            public string ApplicationInsuranceCompany
            {
                get
                {
                    return this.applicationInsuranceCompanyField;
                }
                set
                {
                    this.applicationInsuranceCompanyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.InsuranceCoverReason")]
            public string ApplicationInsuranceCoverReason
            {
                get
                {
                    return this.applicationInsuranceCoverReasonField;
                }
                set
                {
                    this.applicationInsuranceCoverReasonField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.InsuranceMonthlyPremium")]
            public string ApplicationInsuranceMonthlyPremium
            {
                get
                {
                    return this.applicationInsuranceMonthlyPremiumField;
                }
                set
                {
                    this.applicationInsuranceMonthlyPremiumField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.InsurancePaymentMethod")]
            public string ApplicationInsurancePaymentMethod
            {
                get
                {
                    return this.applicationInsurancePaymentMethodField;
                }
                set
                {
                    this.applicationInsurancePaymentMethodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.InsurancePolicyNumber")]
            public string ApplicationInsurancePolicyNumber
            {
                get
                {
                    return this.applicationInsurancePolicyNumberField;
                }
                set
                {
                    this.applicationInsurancePolicyNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.Lapa")]
            public string ApplicationLapa
            {
                get
                {
                    return this.applicationLapaField;
                }
                set
                {
                    this.applicationLapaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.LapaDistance")]
            public string ApplicationLapaDistance
            {
                get
                {
                    return this.applicationLapaDistanceField;
                }
                set
                {
                    this.applicationLapaDistanceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.LapaSize")]
            public string ApplicationLapaSize
            {
                get
                {
                    return this.applicationLapaSizeField;
                }
                set
                {
                    this.applicationLapaSizeField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.MainBuildingSize")]
            public string ApplicationMainBuildingSize
            {
                get
                {
                    return this.applicationMainBuildingSizeField;
                }
                set
                {
                    this.applicationMainBuildingSizeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.ManagingAgentDetails")]
            public string ApplicationManagingAgentDetails
            {
                get
                {
                    return this.applicationManagingAgentDetailsField;
                }
                set
                {
                    this.applicationManagingAgentDetailsField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.NedAgencyCode")]
            public string ApplicationNedAgencyCode
            {
                get
                {
                    return this.applicationNedAgencyCodeField;
                }
                set
                {
                    this.applicationNedAgencyCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.NedAgencyName")]
            public string ApplicationNedAgencyName
            {
                get
                {
                    return this.applicationNedAgencyNameField;
                }
                set
                {
                    this.applicationNedAgencyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.NedAssuranceCompany")]
            public string ApplicationNedAssuranceCompany
            {
                get
                {
                    return this.applicationNedAssuranceCompanyField;
                }
                set
                {
                    this.applicationNedAssuranceCompanyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.NedAssuranceCoverAmount")]
            public string ApplicationNedAssuranceCoverAmount
            {
                get
                {
                    return this.applicationNedAssuranceCoverAmountField;
                }
                set
                {
                    this.applicationNedAssuranceCoverAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.NEDCompanyName")]
            public string ApplicationNEDCompanyName
            {
                get
                {
                    return this.applicationNEDCompanyNameField;
                }
                set
                {
                    this.applicationNEDCompanyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.NEDCompanyName2")]
            public string ApplicationNEDCompanyName2
            {
                get
                {
                    return this.applicationNEDCompanyName2Field;
                }
                set
                {
                    this.applicationNEDCompanyName2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.NedDebitAccountBranch")]
            public string ApplicationNedDebitAccountBranch
            {
                get
                {
                    return this.applicationNedDebitAccountBranchField;
                }
                set
                {
                    this.applicationNedDebitAccountBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.NedDebitAccountBranchCode")]
            public string ApplicationNedDebitAccountBranchCode
            {
                get
                {
                    return this.applicationNedDebitAccountBranchCodeField;
                }
                set
                {
                    this.applicationNedDebitAccountBranchCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.NedDebitAccountInstitution")]
            public string ApplicationNedDebitAccountInstitution
            {
                get
                {
                    return this.applicationNedDebitAccountInstitutionField;
                }
                set
                {
                    this.applicationNedDebitAccountInstitutionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.NEDDeclarationOfWarranty")]
            public string ApplicationNEDDeclarationOfWarranty
            {
                get
                {
                    return this.applicationNEDDeclarationOfWarrantyField;
                }
                set
                {
                    this.applicationNEDDeclarationOfWarrantyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.NedLoanReason")]
            public string ApplicationNedLoanReason
            {
                get
                {
                    return this.applicationNedLoanReasonField;
                }
                set
                {
                    this.applicationNedLoanReasonField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.NEDMOIDateOfIssue")]
            public string ApplicationNEDMOIDateOfIssue
            {
                get
                {
                    return this.applicationNEDMOIDateOfIssueField;
                }
                set
                {
                    this.applicationNEDMOIDateOfIssueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.NEDMOIIndexed")]
            public string ApplicationNEDMOIIndexed
            {
                get
                {
                    return this.applicationNEDMOIIndexedField;
                }
                set
                {
                    this.applicationNEDMOIIndexedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.NEDMOIIndicator")]
            public string ApplicationNEDMOIIndicator
            {
                get
                {
                    return this.applicationNEDMOIIndicatorField;
                }
                set
                {
                    this.applicationNEDMOIIndicatorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.NEDMOIType")]
            public string ApplicationNEDMOIType
            {
                get
                {
                    return this.applicationNEDMOITypeField;
                }
                set
                {
                    this.applicationNEDMOITypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.NedTypeOfProperty")]
            public string ApplicationNedTypeOfProperty
            {
                get
                {
                    return this.applicationNedTypeOfPropertyField;
                }
                set
                {
                    this.applicationNedTypeOfPropertyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.NedVendorDescription")]
            public string ApplicationNedVendorDescription
            {
                get
                {
                    return this.applicationNedVendorDescriptionField;
                }
                set
                {
                    this.applicationNedVendorDescriptionField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.OutBuildingNo")]
            public string ApplicationOutBuildingNo
            {
                get
                {
                    return this.applicationOutBuildingNoField;
                }
                set
                {
                    this.applicationOutBuildingNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.OwnAttorneyReason")]
            public string ApplicationOwnAttorneyReason
            {
                get
                {
                    return this.applicationOwnAttorneyReasonField;
                }
                set
                {
                    this.applicationOwnAttorneyReasonField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.ParkingBayNo")]
            public string ApplicationParkingBayNo
            {
                get
                {
                    return this.applicationParkingBayNoField;
                }
                set
                {
                    this.applicationParkingBayNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PaymentHoliday")]
            public string ApplicationPaymentHoliday
            {
                get
                {
                    return this.applicationPaymentHolidayField;
                }
                set
                {
                    this.applicationPaymentHolidayField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.ProcessingRegion")]
            public string ApplicationProcessingRegion
            {
                get
                {
                    return this.applicationProcessingRegionField;
                }
                set
                {
                    this.applicationProcessingRegionField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyBondAccountNo")]
            public string ApplicationPropertyBondAccountNo
            {
                get
                {
                    return this.applicationPropertyBondAccountNoField;
                }
                set
                {
                    this.applicationPropertyBondAccountNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyBondBank")]
            public string ApplicationPropertyBondBank
            {
                get
                {
                    return this.applicationPropertyBondBankField;
                }
                set
                {
                    this.applicationPropertyBondBankField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyBondBranch")]
            public string ApplicationPropertyBondBranch
            {
                get
                {
                    return this.applicationPropertyBondBranchField;
                }
                set
                {
                    this.applicationPropertyBondBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyBondBranchCode")]
            public string ApplicationPropertyBondBranchCode
            {
                get
                {
                    return this.applicationPropertyBondBranchCodeField;
                }
                set
                {
                    this.applicationPropertyBondBranchCodeField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyCurrentlyBonded")]
            public string ApplicationPropertyCurrentlyBonded
            {
                get
                {
                    return this.applicationPropertyCurrentlyBondedField;
                }
                set
                {
                    this.applicationPropertyCurrentlyBondedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyDescription")]
            public string ApplicationPropertyDescription
            {
                get
                {
                    return this.applicationPropertyDescriptionField;
                }
                set
                {
                    this.applicationPropertyDescriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyOccupantContact")]
            public string ApplicationPropertyOccupantContact
            {
                get
                {
                    return this.applicationPropertyOccupantContactField;
                }
                set
                {
                    this.applicationPropertyOccupantContactField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyPurchaseDate")]
            public string ApplicationPropertyPurchaseDate
            {
                get
                {
                    return this.applicationPropertyPurchaseDateField;
                }
                set
                {
                    this.applicationPropertyPurchaseDateField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyRoofConstruction")]
            public string ApplicationPropertyRoofConstruction
            {
                get
                {
                    return this.applicationPropertyRoofConstructionField;
                }
                set
                {
                    this.applicationPropertyRoofConstructionField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.PropertyWallConstruction")]
            public string ApplicationPropertyWallConstruction
            {
                get
                {
                    return this.applicationPropertyWallConstructionField;
                }
                set
                {
                    this.applicationPropertyWallConstructionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.SectionalTitleRegister")]
            public string ApplicationSectionalTitleRegister
            {
                get
                {
                    return this.applicationSectionalTitleRegisterField;
                }
                set
                {
                    this.applicationSectionalTitleRegisterField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.SellerCellphone")]
            public string ApplicationSellerCellphone
            {
                get
                {
                    return this.applicationSellerCellphoneField;
                }
                set
                {
                    this.applicationSellerCellphoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.SellerName")]
            public string ApplicationSellerName
            {
                get
                {
                    return this.applicationSellerNameField;
                }
                set
                {
                    this.applicationSellerNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.SellerTelNo")]
            public string ApplicationSellerTelNo
            {
                get
                {
                    return this.applicationSellerTelNoField;
                }
                set
                {
                    this.applicationSellerTelNoField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.StatementSentToIndicator")]
            public string ApplicationStatementSentToIndicator
            {
                get
                {
                    return this.applicationStatementSentToIndicatorField;
                }
                set
                {
                    this.applicationStatementSentToIndicatorField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.TransferAttorney")]
            public string ApplicationTransferAttorney
            {
                get
                {
                    return this.applicationTransferAttorneyField;
                }
                set
                {
                    this.applicationTransferAttorneyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.TypeOfAssurance")]
            public string ApplicationTypeOfAssurance
            {
                get
                {
                    return this.applicationTypeOfAssuranceField;
                }
                set
                {
                    this.applicationTypeOfAssuranceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.TypeOfGroupScheme")]
            public string ApplicationTypeOfGroupScheme
            {
                get
                {
                    return this.applicationTypeOfGroupSchemeField;
                }
                set
                {
                    this.applicationTypeOfGroupSchemeField = value;
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

            private string applicantCanRetrieveStatementField;

            private string applicantCellphoneField;

            private string applicantCorrespondenceLanguageField;

            private string applicantCountryOfBirthField;

            private string applicantCountryPassportIssuedField;

            private string applicantDateJoinedEmployerField;

            private string applicantDateOfBirthField;

            private string applicantDatePassportExpiresField;

            private string applicantDatePassportIssuedField;

            private string applicantDateRehabilitatedField;

            private string applicantDeclaredInsolventField;

            private string applicantDisputeWithCreditBureauField;

            private string applicantEmailAddressField;

            private string applicantEmployerNameField;

            private string applicantEmployerTelCodeField;

            private string applicantEmployerTelNoField;

            private string applicantEmploymentIndustryField;

            private string applicantEthnicGroupField;

            private string applicantFaxCodeField;

            private string applicantFaxNoField;

            private string applicantFirstNameField;

            private string applicantGenderField;

            private string applicantHadJudgementField;

            private string applicantHomePhoneField;

            private string applicantHomePhoneCodeField;

            private string applicantIdentificationNoField;

            private string applicantIdentificationTypeField;

            private string applicantIncomeTaxNoField;

            private string applicantInsolventDateField;

            private string applicantIsUnderAdminOrderField;

            private string applicantIsUnderDebtReviewField;

            private string applicantJobChangeField;

            private string applicantMaritalStatusField;

            private string applicantMarriedStatusField;

            private string applicantMassContactField;

            private string applicantMayBankContactYouField;

            private string applicantMaySubsidiariesContactYouField;

            private string applicantNationalityField;

            private string applicantNedBranchField;

            private string applicantNedEmploymentTypeField;

            private string applicantNedMultipleNationalitiesField;

            private string applicantNedOccupationField;

            private string applicantNedSecondaryNationalityField;

            private string applicantNoOfDependentsField;

            private string applicantPassportNoField;

            private string applicantPermanentResidentCountryField;

            private string applicantPhysicalAddressCityField;

            private string applicantPhysicalAddressLine1Field;

            private string applicantPhysicalAddressLine2Field;

            private string applicantPhysicalAddressSuburbField;

            private string applicantPostalAddressCityField;

            private string applicantPostalAddressCodeField;

            private string applicantPostalAddressLine1Field;

            private string applicantPostalAddressLine2Field;

            private string applicantPostalAddressSuburbField;

            private string applicantPostalSameIndicatorField;

            private string applicantPreferredContactDeliveryField;

            private string applicantPreviousEmployerPeriodField;

            private string applicantRearrangementInPlaceField;

            private string applicantResidentialStatusField;

            private string applicantRightOfRefusalConsentField;

            private string applicantSACitizenField;

            private string applicantSelfEmployedField;

            private string applicantSourceOfIncomeField;

            private string applicantSourceOfIncomeNoneField;

            private string applicantSourceOfIncomeOtherField;

            private string applicantSurnameField;

            private string applicantTitleField;

            private string applicantWasUnderAdminOrderField;

            private string applicantWorkPhoneField;

            private string applicantWorkPhoneCodeField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem[] applicantIncomeItemsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem[] applicantExpenditureItemsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantAssetItem[] applicantAssetItemsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantLiabilityItem[] applicantLiabilityItemsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount[] applicantBankAccountsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetails applicantSpouseDetailsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CanRetrieveStatement")]
            public string ApplicantCanRetrieveStatement
            {
                get
                {
                    return this.applicantCanRetrieveStatementField;
                }
                set
                {
                    this.applicantCanRetrieveStatementField = value;
                }
            }

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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CountryPassportIssued")]
            public string ApplicantCountryPassportIssued
            {
                get
                {
                    return this.applicantCountryPassportIssuedField;
                }
                set
                {
                    this.applicantCountryPassportIssuedField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DatePassportIssued")]
            public string ApplicantDatePassportIssued
            {
                get
                {
                    return this.applicantDatePassportIssuedField;
                }
                set
                {
                    this.applicantDatePassportIssuedField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DisputeWithCreditBureau")]
            public string ApplicantDisputeWithCreditBureau
            {
                get
                {
                    return this.applicantDisputeWithCreditBureauField;
                }
                set
                {
                    this.applicantDisputeWithCreditBureauField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerTelCode")]
            public string ApplicantEmployerTelCode
            {
                get
                {
                    return this.applicantEmployerTelCodeField;
                }
                set
                {
                    this.applicantEmployerTelCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerTelNo")]
            public string ApplicantEmployerTelNo
            {
                get
                {
                    return this.applicantEmployerTelNoField;
                }
                set
                {
                    this.applicantEmployerTelNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmploymentIndustry")]
            public string ApplicantEmploymentIndustry
            {
                get
                {
                    return this.applicantEmploymentIndustryField;
                }
                set
                {
                    this.applicantEmploymentIndustryField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HadJudgement")]
            public string ApplicantHadJudgement
            {
                get
                {
                    return this.applicantHadJudgementField;
                }
                set
                {
                    this.applicantHadJudgementField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeTaxNo")]
            public string ApplicantIncomeTaxNo
            {
                get
                {
                    return this.applicantIncomeTaxNoField;
                }
                set
                {
                    this.applicantIncomeTaxNoField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IsUnderAdminOrder")]
            public string ApplicantIsUnderAdminOrder
            {
                get
                {
                    return this.applicantIsUnderAdminOrderField;
                }
                set
                {
                    this.applicantIsUnderAdminOrderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IsUnderDebtReview")]
            public string ApplicantIsUnderDebtReview
            {
                get
                {
                    return this.applicantIsUnderDebtReviewField;
                }
                set
                {
                    this.applicantIsUnderDebtReviewField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.JobChange")]
            public string ApplicantJobChange
            {
                get
                {
                    return this.applicantJobChangeField;
                }
                set
                {
                    this.applicantJobChangeField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MassContact")]
            public string ApplicantMassContact
            {
                get
                {
                    return this.applicantMassContactField;
                }
                set
                {
                    this.applicantMassContactField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MaySubsidiariesContactYou")]
            public string ApplicantMaySubsidiariesContactYou
            {
                get
                {
                    return this.applicantMaySubsidiariesContactYouField;
                }
                set
                {
                    this.applicantMaySubsidiariesContactYouField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedBranch")]
            public string ApplicantNedBranch
            {
                get
                {
                    return this.applicantNedBranchField;
                }
                set
                {
                    this.applicantNedBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedEmploymentType")]
            public string ApplicantNedEmploymentType
            {
                get
                {
                    return this.applicantNedEmploymentTypeField;
                }
                set
                {
                    this.applicantNedEmploymentTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedMultipleNationalities")]
            public string ApplicantNedMultipleNationalities
            {
                get
                {
                    return this.applicantNedMultipleNationalitiesField;
                }
                set
                {
                    this.applicantNedMultipleNationalitiesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedOccupation")]
            public string ApplicantNedOccupation
            {
                get
                {
                    return this.applicantNedOccupationField;
                }
                set
                {
                    this.applicantNedOccupationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedSecondaryNationality")]
            public string ApplicantNedSecondaryNationality
            {
                get
                {
                    return this.applicantNedSecondaryNationalityField;
                }
                set
                {
                    this.applicantNedSecondaryNationalityField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalSameIndicator")]
            public string ApplicantPostalSameIndicator
            {
                get
                {
                    return this.applicantPostalSameIndicatorField;
                }
                set
                {
                    this.applicantPostalSameIndicatorField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.RearrangementInPlace")]
            public string ApplicantRearrangementInPlace
            {
                get
                {
                    return this.applicantRearrangementInPlaceField;
                }
                set
                {
                    this.applicantRearrangementInPlaceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ResidentialStatus")]
            public string ApplicantResidentialStatus
            {
                get
                {
                    return this.applicantResidentialStatusField;
                }
                set
                {
                    this.applicantResidentialStatusField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SelfEmployed")]
            public string ApplicantSelfEmployed
            {
                get
                {
                    return this.applicantSelfEmployedField;
                }
                set
                {
                    this.applicantSelfEmployedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncome")]
            public string ApplicantSourceOfIncome
            {
                get
                {
                    return this.applicantSourceOfIncomeField;
                }
                set
                {
                    this.applicantSourceOfIncomeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncomeNone")]
            public string ApplicantSourceOfIncomeNone
            {
                get
                {
                    return this.applicantSourceOfIncomeNoneField;
                }
                set
                {
                    this.applicantSourceOfIncomeNoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncomeOther")]
            public string ApplicantSourceOfIncomeOther
            {
                get
                {
                    return this.applicantSourceOfIncomeOtherField;
                }
                set
                {
                    this.applicantSourceOfIncomeOtherField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.WasUnderAdminOrder")]
            public string ApplicantWasUnderAdminOrder
            {
                get
                {
                    return this.applicantWasUnderAdminOrderField;
                }
                set
                {
                    this.applicantWasUnderAdminOrderField = value;
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
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.AssetItems")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.AssetItem", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantAssetItem[] ApplicantAssetItems
            {
                get
                {
                    return this.applicantAssetItemsField;
                }
                set
                {
                    this.applicantAssetItemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.LiabilityItems")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.LiabilityItem", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantLiabilityItem[] ApplicantLiabilityItems
            {
                get
                {
                    return this.applicantLiabilityItemsField;
                }
                set
                {
                    this.applicantLiabilityItemsField = value;
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
        public partial class SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantAssetItem
        {

            private string applicantAssetAmountField;

            private string applicantAssetDescField;

            private string applicantAssetTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AssetAmount")]
            public string ApplicantAssetAmount
            {
                get
                {
                    return this.applicantAssetAmountField;
                }
                set
                {
                    this.applicantAssetAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AssetDesc")]
            public string ApplicantAssetDesc
            {
                get
                {
                    return this.applicantAssetDescField;
                }
                set
                {
                    this.applicantAssetDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AssetType")]
            public string ApplicantAssetType
            {
                get
                {
                    return this.applicantAssetTypeField;
                }
                set
                {
                    this.applicantAssetTypeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantLiabilityItem
        {

            private string applicantLiabilityAmountField;

            private string applicantLiabilityDescField;

            private string applicantLiabilityTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.LiabilityAmount")]
            public string ApplicantLiabilityAmount
            {
                get
                {
                    return this.applicantLiabilityAmountField;
                }
                set
                {
                    this.applicantLiabilityAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.LiabilityDesc")]
            public string ApplicantLiabilityDesc
            {
                get
                {
                    return this.applicantLiabilityDescField;
                }
                set
                {
                    this.applicantLiabilityDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.LiabilityType")]
            public string ApplicantLiabilityType
            {
                get
                {
                    return this.applicantLiabilityTypeField;
                }
                set
                {
                    this.applicantLiabilityTypeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount
        {

            private string applicantAccountBranchField;

            private string applicantAccountBranchCodeField;

            private string applicantAccountInstitutionField;

            private string applicantAccountNameField;

            private string applicantAccountNumberField;

            private string applicantAccountTypeField;

            private string applicantIsMainAccountField;

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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountBranchCode")]
            public string ApplicantAccountBranchCode
            {
                get
                {
                    return this.applicantAccountBranchCodeField;
                }
                set
                {
                    this.applicantAccountBranchCodeField = value;
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

            private string applicantCanRetrieveStatementField;

            private string applicantCellphoneField;

            private string applicantCorrespondenceLanguageField;

            private string applicantCountryOfBirthField;

            private string applicantCountryPassportIssuedField;

            private string applicantDateJoinedEmployerField;

            private string applicantDateOfBirthField;

            private string applicantDatePassportExpiresField;

            private string applicantDatePassportIssuedField;

            private string applicantDateRehabilitatedField;

            private string applicantDeclaredInsolventField;

            private string applicantDisputeWithCreditBureauField;

            private string applicantEmailAddressField;

            private string applicantEmployerNameField;

            private string applicantEmployerTelCodeField;

            private string applicantEmployerTelNoField;

            private string applicantEmploymentIndustryField;

            private string applicantEthnicGroupField;

            private string applicantFaxCodeField;

            private string applicantFaxNoField;

            private string applicantFirstNameField;

            private string applicantGenderField;

            private string applicantHadJudgementField;

            private string applicantHomePhoneField;

            private string applicantHomePhoneCodeField;

            private string applicantIdentificationNoField;

            private string applicantIdentificationTypeField;

            private string applicantIncomeTaxNoField;

            private string applicantInsolventDateField;

            private string applicantIsUnderAdminOrderField;

            private string applicantIsUnderDebtReviewField;

            private string applicantJobChangeField;

            private string applicantMaritalStatusField;

            private string applicantMarriedStatusField;

            private string applicantMassContactField;

            private string applicantMayBankContactYouField;

            private string applicantMaySubsidiariesContactYouField;

            private string applicantNationalityField;

            private string applicantNedBranchField;

            private string applicantNedEmploymentTypeField;

            private string applicantNEDIsSuretyField;

            private string applicantNedMultipleNationalitiesField;

            private string applicantNedOccupationField;

            private string applicantNedSecondaryNationalityField;

            private string applicantNoOfDependentsField;

            private string applicantPassportNoField;

            private string applicantPermanentResidentCountryField;

            private string applicantPhysicalAddressCityField;

            private string applicantPhysicalAddressLine1Field;

            private string applicantPhysicalAddressLine2Field;

            private string applicantPhysicalAddressSuburbField;

            private string applicantPostalAddressCityField;

            private string applicantPostalAddressCodeField;

            private string applicantPostalAddressLine1Field;

            private string applicantPostalAddressLine2Field;

            private string applicantPostalAddressSuburbField;

            private string applicantPostalSameIndicatorField;

            private string applicantPreferredContactDeliveryField;

            private string applicantPreviousEmployerPeriodField;

            private string applicantRearrangementInPlaceField;

            private string applicantResidentialStatusField;

            private string applicantRightOfRefusalConsentField;

            private string applicantSACitizenField;

            private string applicantSelfEmployedField;

            private string applicantSourceOfIncomeField;

            private string applicantSourceOfIncomeNoneField;

            private string applicantSourceOfIncomeOtherField;

            private string applicantSurnameField;

            private string applicantTitleField;

            private string applicantWasUnderAdminOrderField;

            private string applicantWorkPhoneField;

            private string applicantWorkPhoneCodeField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem[] applicantIncomeItemsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem[] applicantExpenditureItemsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantAssetItem[] applicantAssetItemsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantLiabilityItem[] applicantLiabilityItemsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantBankAccount[] applicantBankAccountsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CanRetrieveStatement")]
            public string ApplicantCanRetrieveStatement
            {
                get
                {
                    return this.applicantCanRetrieveStatementField;
                }
                set
                {
                    this.applicantCanRetrieveStatementField = value;
                }
            }

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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CountryPassportIssued")]
            public string ApplicantCountryPassportIssued
            {
                get
                {
                    return this.applicantCountryPassportIssuedField;
                }
                set
                {
                    this.applicantCountryPassportIssuedField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DatePassportIssued")]
            public string ApplicantDatePassportIssued
            {
                get
                {
                    return this.applicantDatePassportIssuedField;
                }
                set
                {
                    this.applicantDatePassportIssuedField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DisputeWithCreditBureau")]
            public string ApplicantDisputeWithCreditBureau
            {
                get
                {
                    return this.applicantDisputeWithCreditBureauField;
                }
                set
                {
                    this.applicantDisputeWithCreditBureauField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerTelCode")]
            public string ApplicantEmployerTelCode
            {
                get
                {
                    return this.applicantEmployerTelCodeField;
                }
                set
                {
                    this.applicantEmployerTelCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerTelNo")]
            public string ApplicantEmployerTelNo
            {
                get
                {
                    return this.applicantEmployerTelNoField;
                }
                set
                {
                    this.applicantEmployerTelNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmploymentIndustry")]
            public string ApplicantEmploymentIndustry
            {
                get
                {
                    return this.applicantEmploymentIndustryField;
                }
                set
                {
                    this.applicantEmploymentIndustryField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HadJudgement")]
            public string ApplicantHadJudgement
            {
                get
                {
                    return this.applicantHadJudgementField;
                }
                set
                {
                    this.applicantHadJudgementField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeTaxNo")]
            public string ApplicantIncomeTaxNo
            {
                get
                {
                    return this.applicantIncomeTaxNoField;
                }
                set
                {
                    this.applicantIncomeTaxNoField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IsUnderAdminOrder")]
            public string ApplicantIsUnderAdminOrder
            {
                get
                {
                    return this.applicantIsUnderAdminOrderField;
                }
                set
                {
                    this.applicantIsUnderAdminOrderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IsUnderDebtReview")]
            public string ApplicantIsUnderDebtReview
            {
                get
                {
                    return this.applicantIsUnderDebtReviewField;
                }
                set
                {
                    this.applicantIsUnderDebtReviewField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.JobChange")]
            public string ApplicantJobChange
            {
                get
                {
                    return this.applicantJobChangeField;
                }
                set
                {
                    this.applicantJobChangeField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MassContact")]
            public string ApplicantMassContact
            {
                get
                {
                    return this.applicantMassContactField;
                }
                set
                {
                    this.applicantMassContactField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MaySubsidiariesContactYou")]
            public string ApplicantMaySubsidiariesContactYou
            {
                get
                {
                    return this.applicantMaySubsidiariesContactYouField;
                }
                set
                {
                    this.applicantMaySubsidiariesContactYouField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedBranch")]
            public string ApplicantNedBranch
            {
                get
                {
                    return this.applicantNedBranchField;
                }
                set
                {
                    this.applicantNedBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedEmploymentType")]
            public string ApplicantNedEmploymentType
            {
                get
                {
                    return this.applicantNedEmploymentTypeField;
                }
                set
                {
                    this.applicantNedEmploymentTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NEDIsSurety")]
            public string ApplicantNEDIsSurety
            {
                get
                {
                    return this.applicantNEDIsSuretyField;
                }
                set
                {
                    this.applicantNEDIsSuretyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedMultipleNationalities")]
            public string ApplicantNedMultipleNationalities
            {
                get
                {
                    return this.applicantNedMultipleNationalitiesField;
                }
                set
                {
                    this.applicantNedMultipleNationalitiesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedOccupation")]
            public string ApplicantNedOccupation
            {
                get
                {
                    return this.applicantNedOccupationField;
                }
                set
                {
                    this.applicantNedOccupationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedSecondaryNationality")]
            public string ApplicantNedSecondaryNationality
            {
                get
                {
                    return this.applicantNedSecondaryNationalityField;
                }
                set
                {
                    this.applicantNedSecondaryNationalityField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalSameIndicator")]
            public string ApplicantPostalSameIndicator
            {
                get
                {
                    return this.applicantPostalSameIndicatorField;
                }
                set
                {
                    this.applicantPostalSameIndicatorField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.RearrangementInPlace")]
            public string ApplicantRearrangementInPlace
            {
                get
                {
                    return this.applicantRearrangementInPlaceField;
                }
                set
                {
                    this.applicantRearrangementInPlaceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ResidentialStatus")]
            public string ApplicantResidentialStatus
            {
                get
                {
                    return this.applicantResidentialStatusField;
                }
                set
                {
                    this.applicantResidentialStatusField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SelfEmployed")]
            public string ApplicantSelfEmployed
            {
                get
                {
                    return this.applicantSelfEmployedField;
                }
                set
                {
                    this.applicantSelfEmployedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncome")]
            public string ApplicantSourceOfIncome
            {
                get
                {
                    return this.applicantSourceOfIncomeField;
                }
                set
                {
                    this.applicantSourceOfIncomeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncomeNone")]
            public string ApplicantSourceOfIncomeNone
            {
                get
                {
                    return this.applicantSourceOfIncomeNoneField;
                }
                set
                {
                    this.applicantSourceOfIncomeNoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncomeOther")]
            public string ApplicantSourceOfIncomeOther
            {
                get
                {
                    return this.applicantSourceOfIncomeOtherField;
                }
                set
                {
                    this.applicantSourceOfIncomeOtherField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.WasUnderAdminOrder")]
            public string ApplicantWasUnderAdminOrder
            {
                get
                {
                    return this.applicantWasUnderAdminOrderField;
                }
                set
                {
                    this.applicantWasUnderAdminOrderField = value;
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
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.AssetItems")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.AssetItem", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantAssetItem[] ApplicantAssetItems
            {
                get
                {
                    return this.applicantAssetItemsField;
                }
                set
                {
                    this.applicantAssetItemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.LiabilityItems")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.LiabilityItem", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantLiabilityItem[] ApplicantLiabilityItems
            {
                get
                {
                    return this.applicantLiabilityItemsField;
                }
                set
                {
                    this.applicantLiabilityItemsField = value;
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
        public partial class SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantAssetItem
        {

            private string applicantAssetAmountField;

            private string applicantAssetDescField;

            private string applicantAssetTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AssetAmount")]
            public string ApplicantAssetAmount
            {
                get
                {
                    return this.applicantAssetAmountField;
                }
                set
                {
                    this.applicantAssetAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AssetDesc")]
            public string ApplicantAssetDesc
            {
                get
                {
                    return this.applicantAssetDescField;
                }
                set
                {
                    this.applicantAssetDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AssetType")]
            public string ApplicantAssetType
            {
                get
                {
                    return this.applicantAssetTypeField;
                }
                set
                {
                    this.applicantAssetTypeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantLiabilityItem
        {

            private string applicantLiabilityAmountField;

            private string applicantLiabilityDescField;

            private string applicantLiabilityTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.LiabilityAmount")]
            public string ApplicantLiabilityAmount
            {
                get
                {
                    return this.applicantLiabilityAmountField;
                }
                set
                {
                    this.applicantLiabilityAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.LiabilityDesc")]
            public string ApplicantLiabilityDesc
            {
                get
                {
                    return this.applicantLiabilityDescField;
                }
                set
                {
                    this.applicantLiabilityDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.LiabilityType")]
            public string ApplicantLiabilityType
            {
                get
                {
                    return this.applicantLiabilityTypeField;
                }
                set
                {
                    this.applicantLiabilityTypeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantBankAccount
        {

            private string applicantAccountBranchField;

            private string applicantAccountBranchCodeField;

            private string applicantAccountInstitutionField;

            private string applicantAccountNameField;

            private string applicantAccountNumberField;

            private string applicantAccountTypeField;

            private string applicantIsMainAccountField;

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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountBranchCode")]
            public string ApplicantAccountBranchCode
            {
                get
                {
                    return this.applicantAccountBranchCodeField;
                }
                set
                {
                    this.applicantAccountBranchCodeField = value;
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

            private string applicantCanRetrieveStatementField;

            private string applicantCellphoneField;

            private string applicantCorrespondenceLanguageField;

            private string applicantCountryOfBirthField;

            private string applicantCountryPassportIssuedField;

            private string applicantDateJoinedEmployerField;

            private string applicantDateOfBirthField;

            private string applicantDatePassportExpiresField;

            private string applicantDatePassportIssuedField;

            private string applicantDateRehabilitatedField;

            private string applicantDeclaredInsolventField;

            private string applicantDisputeWithCreditBureauField;

            private string applicantEmailAddressField;

            private string applicantEmployerNameField;

            private string applicantEmployerTelCodeField;

            private string applicantEmployerTelNoField;

            private string applicantEmploymentIndustryField;

            private string applicantEthnicGroupField;

            private string applicantFaxCodeField;

            private string applicantFaxNoField;

            private string applicantFirstNameField;

            private string applicantGenderField;

            private string applicantHadJudgementField;

            private string applicantHomePhoneField;

            private string applicantHomePhoneCodeField;

            private string applicantIdentificationNoField;

            private string applicantIdentificationTypeField;

            private string applicantIncomeTaxNoField;

            private string applicantInsolventDateField;

            private string applicantIsUnderAdminOrderField;

            private string applicantIsUnderDebtReviewField;

            private string applicantJobChangeField;

            private string applicantMaritalStatusField;

            private string applicantMarriedStatusField;

            private string applicantMassContactField;

            private string applicantMayBankContactYouField;

            private string applicantMaySubsidiariesContactYouField;

            private string applicantNationalityField;

            private string applicantNedBranchField;

            private string applicantNedEmploymentTypeField;

            private string applicantNEDIsSuretyField;

            private string applicantNedMultipleNationalitiesField;

            private string applicantNedOccupationField;

            private string applicantNedSecondaryNationalityField;

            private string applicantNoOfDependentsField;

            private string applicantPassportNoField;

            private string applicantPermanentResidentCountryField;

            private string applicantPhysicalAddressCityField;

            private string applicantPhysicalAddressLine1Field;

            private string applicantPhysicalAddressLine2Field;

            private string applicantPhysicalAddressSuburbField;

            private string applicantPostalAddressCityField;

            private string applicantPostalAddressCodeField;

            private string applicantPostalAddressLine1Field;

            private string applicantPostalAddressLine2Field;

            private string applicantPostalAddressSuburbField;

            private string applicantPostalSameIndicatorField;

            private string applicantPreferredContactDeliveryField;

            private string applicantPreviousEmployerPeriodField;

            private string applicantRearrangementInPlaceField;

            private string applicantResidentialStatusField;

            private string applicantRightOfRefusalConsentField;

            private string applicantSACitizenField;

            private string applicantSelfEmployedField;

            private string applicantSourceOfIncomeField;

            private string applicantSourceOfIncomeNoneField;

            private string applicantSourceOfIncomeOtherField;

            private string applicantSurnameField;

            private string applicantTitleField;

            private string applicantWasUnderAdminOrderField;

            private string applicantWorkPhoneField;

            private string applicantWorkPhoneCodeField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantIncomeItem[] applicantIncomeItemsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantExpenditureItem[] applicantExpenditureItemsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantAssetItem[] applicantAssetItemsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantLiabilityItem[] applicantLiabilityItemsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantBankAccount[] applicantBankAccountsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetails applicantSpouseDetailsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CanRetrieveStatement")]
            public string ApplicantCanRetrieveStatement
            {
                get
                {
                    return this.applicantCanRetrieveStatementField;
                }
                set
                {
                    this.applicantCanRetrieveStatementField = value;
                }
            }

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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CountryPassportIssued")]
            public string ApplicantCountryPassportIssued
            {
                get
                {
                    return this.applicantCountryPassportIssuedField;
                }
                set
                {
                    this.applicantCountryPassportIssuedField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DatePassportIssued")]
            public string ApplicantDatePassportIssued
            {
                get
                {
                    return this.applicantDatePassportIssuedField;
                }
                set
                {
                    this.applicantDatePassportIssuedField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DisputeWithCreditBureau")]
            public string ApplicantDisputeWithCreditBureau
            {
                get
                {
                    return this.applicantDisputeWithCreditBureauField;
                }
                set
                {
                    this.applicantDisputeWithCreditBureauField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerTelCode")]
            public string ApplicantEmployerTelCode
            {
                get
                {
                    return this.applicantEmployerTelCodeField;
                }
                set
                {
                    this.applicantEmployerTelCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerTelNo")]
            public string ApplicantEmployerTelNo
            {
                get
                {
                    return this.applicantEmployerTelNoField;
                }
                set
                {
                    this.applicantEmployerTelNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmploymentIndustry")]
            public string ApplicantEmploymentIndustry
            {
                get
                {
                    return this.applicantEmploymentIndustryField;
                }
                set
                {
                    this.applicantEmploymentIndustryField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HadJudgement")]
            public string ApplicantHadJudgement
            {
                get
                {
                    return this.applicantHadJudgementField;
                }
                set
                {
                    this.applicantHadJudgementField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeTaxNo")]
            public string ApplicantIncomeTaxNo
            {
                get
                {
                    return this.applicantIncomeTaxNoField;
                }
                set
                {
                    this.applicantIncomeTaxNoField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IsUnderAdminOrder")]
            public string ApplicantIsUnderAdminOrder
            {
                get
                {
                    return this.applicantIsUnderAdminOrderField;
                }
                set
                {
                    this.applicantIsUnderAdminOrderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IsUnderDebtReview")]
            public string ApplicantIsUnderDebtReview
            {
                get
                {
                    return this.applicantIsUnderDebtReviewField;
                }
                set
                {
                    this.applicantIsUnderDebtReviewField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.JobChange")]
            public string ApplicantJobChange
            {
                get
                {
                    return this.applicantJobChangeField;
                }
                set
                {
                    this.applicantJobChangeField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MassContact")]
            public string ApplicantMassContact
            {
                get
                {
                    return this.applicantMassContactField;
                }
                set
                {
                    this.applicantMassContactField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MaySubsidiariesContactYou")]
            public string ApplicantMaySubsidiariesContactYou
            {
                get
                {
                    return this.applicantMaySubsidiariesContactYouField;
                }
                set
                {
                    this.applicantMaySubsidiariesContactYouField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedBranch")]
            public string ApplicantNedBranch
            {
                get
                {
                    return this.applicantNedBranchField;
                }
                set
                {
                    this.applicantNedBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedEmploymentType")]
            public string ApplicantNedEmploymentType
            {
                get
                {
                    return this.applicantNedEmploymentTypeField;
                }
                set
                {
                    this.applicantNedEmploymentTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NEDIsSurety")]
            public string ApplicantNEDIsSurety
            {
                get
                {
                    return this.applicantNEDIsSuretyField;
                }
                set
                {
                    this.applicantNEDIsSuretyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedMultipleNationalities")]
            public string ApplicantNedMultipleNationalities
            {
                get
                {
                    return this.applicantNedMultipleNationalitiesField;
                }
                set
                {
                    this.applicantNedMultipleNationalitiesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedOccupation")]
            public string ApplicantNedOccupation
            {
                get
                {
                    return this.applicantNedOccupationField;
                }
                set
                {
                    this.applicantNedOccupationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedSecondaryNationality")]
            public string ApplicantNedSecondaryNationality
            {
                get
                {
                    return this.applicantNedSecondaryNationalityField;
                }
                set
                {
                    this.applicantNedSecondaryNationalityField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalSameIndicator")]
            public string ApplicantPostalSameIndicator
            {
                get
                {
                    return this.applicantPostalSameIndicatorField;
                }
                set
                {
                    this.applicantPostalSameIndicatorField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.RearrangementInPlace")]
            public string ApplicantRearrangementInPlace
            {
                get
                {
                    return this.applicantRearrangementInPlaceField;
                }
                set
                {
                    this.applicantRearrangementInPlaceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ResidentialStatus")]
            public string ApplicantResidentialStatus
            {
                get
                {
                    return this.applicantResidentialStatusField;
                }
                set
                {
                    this.applicantResidentialStatusField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SelfEmployed")]
            public string ApplicantSelfEmployed
            {
                get
                {
                    return this.applicantSelfEmployedField;
                }
                set
                {
                    this.applicantSelfEmployedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncome")]
            public string ApplicantSourceOfIncome
            {
                get
                {
                    return this.applicantSourceOfIncomeField;
                }
                set
                {
                    this.applicantSourceOfIncomeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncomeNone")]
            public string ApplicantSourceOfIncomeNone
            {
                get
                {
                    return this.applicantSourceOfIncomeNoneField;
                }
                set
                {
                    this.applicantSourceOfIncomeNoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncomeOther")]
            public string ApplicantSourceOfIncomeOther
            {
                get
                {
                    return this.applicantSourceOfIncomeOtherField;
                }
                set
                {
                    this.applicantSourceOfIncomeOtherField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.WasUnderAdminOrder")]
            public string ApplicantWasUnderAdminOrder
            {
                get
                {
                    return this.applicantWasUnderAdminOrderField;
                }
                set
                {
                    this.applicantWasUnderAdminOrderField = value;
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
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.AssetItems")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.AssetItem", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantAssetItem[] ApplicantAssetItems
            {
                get
                {
                    return this.applicantAssetItemsField;
                }
                set
                {
                    this.applicantAssetItemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.LiabilityItems")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.LiabilityItem", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantLiabilityItem[] ApplicantLiabilityItems
            {
                get
                {
                    return this.applicantLiabilityItemsField;
                }
                set
                {
                    this.applicantLiabilityItemsField = value;
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
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantAssetItem
        {

            private string applicantAssetAmountField;

            private string applicantAssetDescField;

            private string applicantAssetTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AssetAmount")]
            public string ApplicantAssetAmount
            {
                get
                {
                    return this.applicantAssetAmountField;
                }
                set
                {
                    this.applicantAssetAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AssetDesc")]
            public string ApplicantAssetDesc
            {
                get
                {
                    return this.applicantAssetDescField;
                }
                set
                {
                    this.applicantAssetDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AssetType")]
            public string ApplicantAssetType
            {
                get
                {
                    return this.applicantAssetTypeField;
                }
                set
                {
                    this.applicantAssetTypeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantLiabilityItem
        {

            private string applicantLiabilityAmountField;

            private string applicantLiabilityDescField;

            private string applicantLiabilityTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.LiabilityAmount")]
            public string ApplicantLiabilityAmount
            {
                get
                {
                    return this.applicantLiabilityAmountField;
                }
                set
                {
                    this.applicantLiabilityAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.LiabilityDesc")]
            public string ApplicantLiabilityDesc
            {
                get
                {
                    return this.applicantLiabilityDescField;
                }
                set
                {
                    this.applicantLiabilityDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.LiabilityType")]
            public string ApplicantLiabilityType
            {
                get
                {
                    return this.applicantLiabilityTypeField;
                }
                set
                {
                    this.applicantLiabilityTypeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantBankAccount
        {

            private string applicantAccountBranchField;

            private string applicantAccountBranchCodeField;

            private string applicantAccountInstitutionField;

            private string applicantAccountNameField;

            private string applicantAccountNumberField;

            private string applicantAccountTypeField;

            private string applicantIsMainAccountField;

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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountBranchCode")]
            public string ApplicantAccountBranchCode
            {
                get
                {
                    return this.applicantAccountBranchCodeField;
                }
                set
                {
                    this.applicantAccountBranchCodeField = value;
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

            private string applicantCanRetrieveStatementField;

            private string applicantCellphoneField;

            private string applicantCorrespondenceLanguageField;

            private string applicantCountryOfBirthField;

            private string applicantCountryPassportIssuedField;

            private string applicantDateJoinedEmployerField;

            private string applicantDateOfBirthField;

            private string applicantDatePassportExpiresField;

            private string applicantDatePassportIssuedField;

            private string applicantDateRehabilitatedField;

            private string applicantDeclaredInsolventField;

            private string applicantDisputeWithCreditBureauField;

            private string applicantEmailAddressField;

            private string applicantEmployerNameField;

            private string applicantEmployerTelCodeField;

            private string applicantEmployerTelNoField;

            private string applicantEmploymentIndustryField;

            private string applicantEthnicGroupField;

            private string applicantFaxCodeField;

            private string applicantFaxNoField;

            private string applicantFirstNameField;

            private string applicantGenderField;

            private string applicantHadJudgementField;

            private string applicantHomePhoneField;

            private string applicantHomePhoneCodeField;

            private string applicantIdentificationNoField;

            private string applicantIdentificationTypeField;

            private string applicantIncomeTaxNoField;

            private string applicantInsolventDateField;

            private string applicantIsUnderAdminOrderField;

            private string applicantIsUnderDebtReviewField;

            private string applicantJobChangeField;

            private string applicantMaritalStatusField;

            private string applicantMarriedStatusField;

            private string applicantMassContactField;

            private string applicantMayBankContactYouField;

            private string applicantMaySubsidiariesContactYouField;

            private string applicantNationalityField;

            private string applicantNedBranchField;

            private string applicantNedEmploymentTypeField;

            private string applicantNEDIsSuretyField;

            private string applicantNedMultipleNationalitiesField;

            private string applicantNedOccupationField;

            private string applicantNedSecondaryNationalityField;

            private string applicantNoOfDependentsField;

            private string applicantPassportNoField;

            private string applicantPermanentResidentCountryField;

            private string applicantPhysicalAddressCityField;

            private string applicantPhysicalAddressLine1Field;

            private string applicantPhysicalAddressLine2Field;

            private string applicantPhysicalAddressSuburbField;

            private string applicantPostalAddressCityField;

            private string applicantPostalAddressCodeField;

            private string applicantPostalAddressLine1Field;

            private string applicantPostalAddressLine2Field;

            private string applicantPostalAddressSuburbField;

            private string applicantPostalSameIndicatorField;

            private string applicantPreferredContactDeliveryField;

            private string applicantPreviousEmployerPeriodField;

            private string applicantRearrangementInPlaceField;

            private string applicantResidentialStatusField;

            private string applicantRightOfRefusalConsentField;

            private string applicantSACitizenField;

            private string applicantSelfEmployedField;

            private string applicantSourceOfIncomeField;

            private string applicantSourceOfIncomeNoneField;

            private string applicantSourceOfIncomeOtherField;

            private string applicantSurnameField;

            private string applicantTitleField;

            private string applicantWasUnderAdminOrderField;

            private string applicantWorkPhoneField;

            private string applicantWorkPhoneCodeField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem[] applicantIncomeItemsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem[] applicantExpenditureItemsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantAssetItem[] applicantAssetItemsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantLiabilityItem[] applicantLiabilityItemsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantBankAccount[] applicantBankAccountsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CanRetrieveStatement")]
            public string ApplicantCanRetrieveStatement
            {
                get
                {
                    return this.applicantCanRetrieveStatementField;
                }
                set
                {
                    this.applicantCanRetrieveStatementField = value;
                }
            }

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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CountryPassportIssued")]
            public string ApplicantCountryPassportIssued
            {
                get
                {
                    return this.applicantCountryPassportIssuedField;
                }
                set
                {
                    this.applicantCountryPassportIssuedField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DatePassportIssued")]
            public string ApplicantDatePassportIssued
            {
                get
                {
                    return this.applicantDatePassportIssuedField;
                }
                set
                {
                    this.applicantDatePassportIssuedField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.DisputeWithCreditBureau")]
            public string ApplicantDisputeWithCreditBureau
            {
                get
                {
                    return this.applicantDisputeWithCreditBureauField;
                }
                set
                {
                    this.applicantDisputeWithCreditBureauField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerTelCode")]
            public string ApplicantEmployerTelCode
            {
                get
                {
                    return this.applicantEmployerTelCodeField;
                }
                set
                {
                    this.applicantEmployerTelCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerTelNo")]
            public string ApplicantEmployerTelNo
            {
                get
                {
                    return this.applicantEmployerTelNoField;
                }
                set
                {
                    this.applicantEmployerTelNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmploymentIndustry")]
            public string ApplicantEmploymentIndustry
            {
                get
                {
                    return this.applicantEmploymentIndustryField;
                }
                set
                {
                    this.applicantEmploymentIndustryField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HadJudgement")]
            public string ApplicantHadJudgement
            {
                get
                {
                    return this.applicantHadJudgementField;
                }
                set
                {
                    this.applicantHadJudgementField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeTaxNo")]
            public string ApplicantIncomeTaxNo
            {
                get
                {
                    return this.applicantIncomeTaxNoField;
                }
                set
                {
                    this.applicantIncomeTaxNoField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IsUnderAdminOrder")]
            public string ApplicantIsUnderAdminOrder
            {
                get
                {
                    return this.applicantIsUnderAdminOrderField;
                }
                set
                {
                    this.applicantIsUnderAdminOrderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IsUnderDebtReview")]
            public string ApplicantIsUnderDebtReview
            {
                get
                {
                    return this.applicantIsUnderDebtReviewField;
                }
                set
                {
                    this.applicantIsUnderDebtReviewField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.JobChange")]
            public string ApplicantJobChange
            {
                get
                {
                    return this.applicantJobChangeField;
                }
                set
                {
                    this.applicantJobChangeField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MassContact")]
            public string ApplicantMassContact
            {
                get
                {
                    return this.applicantMassContactField;
                }
                set
                {
                    this.applicantMassContactField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MaySubsidiariesContactYou")]
            public string ApplicantMaySubsidiariesContactYou
            {
                get
                {
                    return this.applicantMaySubsidiariesContactYouField;
                }
                set
                {
                    this.applicantMaySubsidiariesContactYouField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedBranch")]
            public string ApplicantNedBranch
            {
                get
                {
                    return this.applicantNedBranchField;
                }
                set
                {
                    this.applicantNedBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedEmploymentType")]
            public string ApplicantNedEmploymentType
            {
                get
                {
                    return this.applicantNedEmploymentTypeField;
                }
                set
                {
                    this.applicantNedEmploymentTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NEDIsSurety")]
            public string ApplicantNEDIsSurety
            {
                get
                {
                    return this.applicantNEDIsSuretyField;
                }
                set
                {
                    this.applicantNEDIsSuretyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedMultipleNationalities")]
            public string ApplicantNedMultipleNationalities
            {
                get
                {
                    return this.applicantNedMultipleNationalitiesField;
                }
                set
                {
                    this.applicantNedMultipleNationalitiesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedOccupation")]
            public string ApplicantNedOccupation
            {
                get
                {
                    return this.applicantNedOccupationField;
                }
                set
                {
                    this.applicantNedOccupationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.NedSecondaryNationality")]
            public string ApplicantNedSecondaryNationality
            {
                get
                {
                    return this.applicantNedSecondaryNationalityField;
                }
                set
                {
                    this.applicantNedSecondaryNationalityField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PostalSameIndicator")]
            public string ApplicantPostalSameIndicator
            {
                get
                {
                    return this.applicantPostalSameIndicatorField;
                }
                set
                {
                    this.applicantPostalSameIndicatorField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.RearrangementInPlace")]
            public string ApplicantRearrangementInPlace
            {
                get
                {
                    return this.applicantRearrangementInPlaceField;
                }
                set
                {
                    this.applicantRearrangementInPlaceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ResidentialStatus")]
            public string ApplicantResidentialStatus
            {
                get
                {
                    return this.applicantResidentialStatusField;
                }
                set
                {
                    this.applicantResidentialStatusField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SelfEmployed")]
            public string ApplicantSelfEmployed
            {
                get
                {
                    return this.applicantSelfEmployedField;
                }
                set
                {
                    this.applicantSelfEmployedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncome")]
            public string ApplicantSourceOfIncome
            {
                get
                {
                    return this.applicantSourceOfIncomeField;
                }
                set
                {
                    this.applicantSourceOfIncomeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncomeNone")]
            public string ApplicantSourceOfIncomeNone
            {
                get
                {
                    return this.applicantSourceOfIncomeNoneField;
                }
                set
                {
                    this.applicantSourceOfIncomeNoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncomeOther")]
            public string ApplicantSourceOfIncomeOther
            {
                get
                {
                    return this.applicantSourceOfIncomeOtherField;
                }
                set
                {
                    this.applicantSourceOfIncomeOtherField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.WasUnderAdminOrder")]
            public string ApplicantWasUnderAdminOrder
            {
                get
                {
                    return this.applicantWasUnderAdminOrderField;
                }
                set
                {
                    this.applicantWasUnderAdminOrderField = value;
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
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.AssetItems")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.AssetItem", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantAssetItem[] ApplicantAssetItems
            {
                get
                {
                    return this.applicantAssetItemsField;
                }
                set
                {
                    this.applicantAssetItemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Applicant.LiabilityItems")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Applicant.LiabilityItem", IsNullable = false)]
            public SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantLiabilityItem[] ApplicantLiabilityItems
            {
                get
                {
                    return this.applicantLiabilityItemsField;
                }
                set
                {
                    this.applicantLiabilityItemsField = value;
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
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantAssetItem
        {

            private string applicantAssetAmountField;

            private string applicantAssetDescField;

            private string applicantAssetTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AssetAmount")]
            public string ApplicantAssetAmount
            {
                get
                {
                    return this.applicantAssetAmountField;
                }
                set
                {
                    this.applicantAssetAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AssetDesc")]
            public string ApplicantAssetDesc
            {
                get
                {
                    return this.applicantAssetDescField;
                }
                set
                {
                    this.applicantAssetDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AssetType")]
            public string ApplicantAssetType
            {
                get
                {
                    return this.applicantAssetTypeField;
                }
                set
                {
                    this.applicantAssetTypeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantLiabilityItem
        {

            private string applicantLiabilityAmountField;

            private string applicantLiabilityDescField;

            private string applicantLiabilityTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.LiabilityAmount")]
            public string ApplicantLiabilityAmount
            {
                get
                {
                    return this.applicantLiabilityAmountField;
                }
                set
                {
                    this.applicantLiabilityAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.LiabilityDesc")]
            public string ApplicantLiabilityDesc
            {
                get
                {
                    return this.applicantLiabilityDescField;
                }
                set
                {
                    this.applicantLiabilityDescField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.LiabilityType")]
            public string ApplicantLiabilityType
            {
                get
                {
                    return this.applicantLiabilityTypeField;
                }
                set
                {
                    this.applicantLiabilityTypeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantBankAccount
        {

            private string applicantAccountBranchField;

            private string applicantAccountBranchCodeField;

            private string applicantAccountInstitutionField;

            private string applicantAccountNameField;

            private string applicantAccountNumberField;

            private string applicantAccountTypeField;

            private string applicantIsMainAccountField;

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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.AccountBranchCode")]
            public string ApplicantAccountBranchCode
            {
                get
                {
                    return this.applicantAccountBranchCodeField;
                }
                set
                {
                    this.applicantAccountBranchCodeField = value;
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
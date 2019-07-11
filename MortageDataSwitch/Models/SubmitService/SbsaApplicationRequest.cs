using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortageDataSwitch.Models.SubmitService
{
    public static class SbsaApplicationRequest
    {
        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationDetails
        {

            private string applicationAgentNameField;

            private string applicationAIPBanksField;

            private string applicationAreaOfLandField;

            private string applicationBondAmountField;

            private string applicationCollateralAmountField;

            private string applicationCollateralTypeField;

            private string applicationComplexNameField;

            private string applicationComplexTypeField;

            private string applicationConsentClause1Field;

            private string applicationConsentClause2Field;

            private string applicationConsentClause3Field;

            private string applicationConsentClause4Field;

            private string applicationCorrespondenceTitleField;

            private string applicationDebitAccountInstitutionField;

            private string applicationDebitAccountNoField;

            private string applicationDebitAccountTypeField;

            private string applicationDeclinedBanksField;

            private string applicationDomicileBranchField;

            private string applicationDomicileBranchCodeField;

            private string applicationEstateAgencyField;

            private string applicationExistingSTDHomeLoanField;

            private string applicationExistingSTDHomeLoanAccountNoField;

            private string applicationFirstPropertyPurchaseField;

            private string applicationGarageBayNoField;

            private string applicationInitFeePaymentOptionField;

            private string applicationInstalmentMethodField;

            private string applicationJumpStartOptionField;

            private string applicationLoanAmountRequiredField;

            private string applicationLoanProtectionPlanField;

            private string applicationLoanReasonField;

            private string applicationLoanTypeField;

            private string applicationManagingAgentDetailsField;

            private string applicationManagingAgentPhoneCodeField;

            private string applicationManagingAgentPhoneNoField;

            private string applicationNamePropertyRegisteredField;

            private string applicationNetworkField;

            private string applicationOriginatorNameField;

            private string applicationOtherLoanAmountField;

            private string applicationOtherLoanInstallmentField;

            private string applicationParkingBayNoField;

            private string applicationPortionNoField;

            private string applicationPropertyAddressCityField;

            private string applicationPropertyContactNameField;

            private string applicationPropertyContactTelCodeField;

            private string applicationPropertyContactTelNoField;

            private string applicationPropertyPurchaseDateField;

            private string applicationPropertyPurchasePriceField;

            private string applicationPropertyRoofConstructionField;

            private string applicationPropertyStreetNameField;

            private string applicationSectionalTitleUnitNoField;

            private string applicationSellerIDNoField;

            private string applicationSellerNameField;

            private string applicationStandErfNoField;

            private string applicationSTDAccountHolderField;

            private string applicationSTDBondAttorneyField;

            private string applicationSTDDebitAccountBranchField;

            private string applicationSTDDebitAccountBranchCodeField;

            private string applicationSTDDomicleAddress1Field;

            private string applicationSTDDomicleAddress2Field;

            private string applicationSTDDomicleDeliveryMethodField;

            private string applicationSTDDomiclePaymentDayField;

            private string applicationSTDDomicleSuburbField;

            private string applicationSTDDomicleSuburbCodeField;

            private string applicationSTDEmailAddressField;

            private string applicationSTDIntendedUseOfAccountField;

            private string applicationSTDPropertyCurrentlyBondedField;

            private string applicationSTDPropertySuburbField;

            private string applicationSTDPropertySuburbCodeField;

            private string applicationSTDPropertyUseField;

            private string applicationSTDTransferAttorneyField;

            private string applicationSTDTypeOfApplicationField;

            private string applicationSTDTypeOfLoanField;

            private string applicationSTDTypeOfPropertyField;

            private string applicationSTDVendorChannelField;

            private string applicationSTDVendorCodeField;

            private string applicationSTDVendorDescriptionField;

            private string applicationSTDVendorUserField;

            private string applicationSubmittingBanksField;

            private string applicationSuretyAmountField;

            private string applicationSuretyNameField;

            private string applicationSuretyTypeField;

            private string applicationTermOfLoanField;

            private string applicationTypeOfRateField;

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
            [System.Xml.Serialization.XmlElementAttribute("Application.CollateralAmount")]
            public string ApplicationCollateralAmount
            {
                get
                {
                    return this.applicationCollateralAmountField;
                }
                set
                {
                    this.applicationCollateralAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.CollateralType")]
            public string ApplicationCollateralType
            {
                get
                {
                    return this.applicationCollateralTypeField;
                }
                set
                {
                    this.applicationCollateralTypeField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.ComplexType")]
            public string ApplicationComplexType
            {
                get
                {
                    return this.applicationComplexTypeField;
                }
                set
                {
                    this.applicationComplexTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.ConsentClause1")]
            public string ApplicationConsentClause1
            {
                get
                {
                    return this.applicationConsentClause1Field;
                }
                set
                {
                    this.applicationConsentClause1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.ConsentClause2")]
            public string ApplicationConsentClause2
            {
                get
                {
                    return this.applicationConsentClause2Field;
                }
                set
                {
                    this.applicationConsentClause2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.ConsentClause3")]
            public string ApplicationConsentClause3
            {
                get
                {
                    return this.applicationConsentClause3Field;
                }
                set
                {
                    this.applicationConsentClause3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.ConsentClause4")]
            public string ApplicationConsentClause4
            {
                get
                {
                    return this.applicationConsentClause4Field;
                }
                set
                {
                    this.applicationConsentClause4Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.CorrespondenceTitle")]
            public string ApplicationCorrespondenceTitle
            {
                get
                {
                    return this.applicationCorrespondenceTitleField;
                }
                set
                {
                    this.applicationCorrespondenceTitleField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.DomicileBranch")]
            public string ApplicationDomicileBranch
            {
                get
                {
                    return this.applicationDomicileBranchField;
                }
                set
                {
                    this.applicationDomicileBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.DomicileBranchCode")]
            public string ApplicationDomicileBranchCode
            {
                get
                {
                    return this.applicationDomicileBranchCodeField;
                }
                set
                {
                    this.applicationDomicileBranchCodeField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.ExistingSTDHomeLoan")]
            public string ApplicationExistingSTDHomeLoan
            {
                get
                {
                    return this.applicationExistingSTDHomeLoanField;
                }
                set
                {
                    this.applicationExistingSTDHomeLoanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.ExistingSTDHomeLoanAccountNo")]
            public string ApplicationExistingSTDHomeLoanAccountNo
            {
                get
                {
                    return this.applicationExistingSTDHomeLoanAccountNoField;
                }
                set
                {
                    this.applicationExistingSTDHomeLoanAccountNoField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.GarageBayNo")]
            public string ApplicationGarageBayNo
            {
                get
                {
                    return this.applicationGarageBayNoField;
                }
                set
                {
                    this.applicationGarageBayNoField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.JumpStartOption")]
            public string ApplicationJumpStartOption
            {
                get
                {
                    return this.applicationJumpStartOptionField;
                }
                set
                {
                    this.applicationJumpStartOptionField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.LoanProtectionPlan")]
            public string ApplicationLoanProtectionPlan
            {
                get
                {
                    return this.applicationLoanProtectionPlanField;
                }
                set
                {
                    this.applicationLoanProtectionPlanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.LoanReason")]
            public string ApplicationLoanReason
            {
                get
                {
                    return this.applicationLoanReasonField;
                }
                set
                {
                    this.applicationLoanReasonField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.LoanType")]
            public string ApplicationLoanType
            {
                get
                {
                    return this.applicationLoanTypeField;
                }
                set
                {
                    this.applicationLoanTypeField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.ManagingAgentPhoneCode")]
            public string ApplicationManagingAgentPhoneCode
            {
                get
                {
                    return this.applicationManagingAgentPhoneCodeField;
                }
                set
                {
                    this.applicationManagingAgentPhoneCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.ManagingAgentPhoneNo")]
            public string ApplicationManagingAgentPhoneNo
            {
                get
                {
                    return this.applicationManagingAgentPhoneNoField;
                }
                set
                {
                    this.applicationManagingAgentPhoneNoField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.OriginatorName")]
            public string ApplicationOriginatorName
            {
                get
                {
                    return this.applicationOriginatorNameField;
                }
                set
                {
                    this.applicationOriginatorNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.OtherLoanAmount")]
            public string ApplicationOtherLoanAmount
            {
                get
                {
                    return this.applicationOtherLoanAmountField;
                }
                set
                {
                    this.applicationOtherLoanAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.OtherLoanInstallment")]
            public string ApplicationOtherLoanInstallment
            {
                get
                {
                    return this.applicationOtherLoanInstallmentField;
                }
                set
                {
                    this.applicationOtherLoanInstallmentField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.SellerIDNo")]
            public string ApplicationSellerIDNo
            {
                get
                {
                    return this.applicationSellerIDNoField;
                }
                set
                {
                    this.applicationSellerIDNoField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.STDAccountHolder")]
            public string ApplicationSTDAccountHolder
            {
                get
                {
                    return this.applicationSTDAccountHolderField;
                }
                set
                {
                    this.applicationSTDAccountHolderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDBondAttorney")]
            public string ApplicationSTDBondAttorney
            {
                get
                {
                    return this.applicationSTDBondAttorneyField;
                }
                set
                {
                    this.applicationSTDBondAttorneyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDDebitAccountBranch")]
            public string ApplicationSTDDebitAccountBranch
            {
                get
                {
                    return this.applicationSTDDebitAccountBranchField;
                }
                set
                {
                    this.applicationSTDDebitAccountBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDDebitAccountBranchCode")]
            public string ApplicationSTDDebitAccountBranchCode
            {
                get
                {
                    return this.applicationSTDDebitAccountBranchCodeField;
                }
                set
                {
                    this.applicationSTDDebitAccountBranchCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDDomicleAddress1")]
            public string ApplicationSTDDomicleAddress1
            {
                get
                {
                    return this.applicationSTDDomicleAddress1Field;
                }
                set
                {
                    this.applicationSTDDomicleAddress1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDDomicleAddress2")]
            public string ApplicationSTDDomicleAddress2
            {
                get
                {
                    return this.applicationSTDDomicleAddress2Field;
                }
                set
                {
                    this.applicationSTDDomicleAddress2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDDomicleDeliveryMethod")]
            public string ApplicationSTDDomicleDeliveryMethod
            {
                get
                {
                    return this.applicationSTDDomicleDeliveryMethodField;
                }
                set
                {
                    this.applicationSTDDomicleDeliveryMethodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDDomiclePaymentDay")]
            public string ApplicationSTDDomiclePaymentDay
            {
                get
                {
                    return this.applicationSTDDomiclePaymentDayField;
                }
                set
                {
                    this.applicationSTDDomiclePaymentDayField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDDomicleSuburb")]
            public string ApplicationSTDDomicleSuburb
            {
                get
                {
                    return this.applicationSTDDomicleSuburbField;
                }
                set
                {
                    this.applicationSTDDomicleSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDDomicleSuburbCode")]
            public string ApplicationSTDDomicleSuburbCode
            {
                get
                {
                    return this.applicationSTDDomicleSuburbCodeField;
                }
                set
                {
                    this.applicationSTDDomicleSuburbCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDEmailAddress")]
            public string ApplicationSTDEmailAddress
            {
                get
                {
                    return this.applicationSTDEmailAddressField;
                }
                set
                {
                    this.applicationSTDEmailAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDIntendedUseOfAccount")]
            public string ApplicationSTDIntendedUseOfAccount
            {
                get
                {
                    return this.applicationSTDIntendedUseOfAccountField;
                }
                set
                {
                    this.applicationSTDIntendedUseOfAccountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDPropertyCurrentlyBonded")]
            public string ApplicationSTDPropertyCurrentlyBonded
            {
                get
                {
                    return this.applicationSTDPropertyCurrentlyBondedField;
                }
                set
                {
                    this.applicationSTDPropertyCurrentlyBondedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDPropertySuburb")]
            public string ApplicationSTDPropertySuburb
            {
                get
                {
                    return this.applicationSTDPropertySuburbField;
                }
                set
                {
                    this.applicationSTDPropertySuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDPropertySuburbCode")]
            public string ApplicationSTDPropertySuburbCode
            {
                get
                {
                    return this.applicationSTDPropertySuburbCodeField;
                }
                set
                {
                    this.applicationSTDPropertySuburbCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDPropertyUse")]
            public string ApplicationSTDPropertyUse
            {
                get
                {
                    return this.applicationSTDPropertyUseField;
                }
                set
                {
                    this.applicationSTDPropertyUseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDTransferAttorney")]
            public string ApplicationSTDTransferAttorney
            {
                get
                {
                    return this.applicationSTDTransferAttorneyField;
                }
                set
                {
                    this.applicationSTDTransferAttorneyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDTypeOfApplication")]
            public string ApplicationSTDTypeOfApplication
            {
                get
                {
                    return this.applicationSTDTypeOfApplicationField;
                }
                set
                {
                    this.applicationSTDTypeOfApplicationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDTypeOfLoan")]
            public string ApplicationSTDTypeOfLoan
            {
                get
                {
                    return this.applicationSTDTypeOfLoanField;
                }
                set
                {
                    this.applicationSTDTypeOfLoanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDTypeOfProperty")]
            public string ApplicationSTDTypeOfProperty
            {
                get
                {
                    return this.applicationSTDTypeOfPropertyField;
                }
                set
                {
                    this.applicationSTDTypeOfPropertyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDVendorChannel")]
            public string ApplicationSTDVendorChannel
            {
                get
                {
                    return this.applicationSTDVendorChannelField;
                }
                set
                {
                    this.applicationSTDVendorChannelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDVendorCode")]
            public string ApplicationSTDVendorCode
            {
                get
                {
                    return this.applicationSTDVendorCodeField;
                }
                set
                {
                    this.applicationSTDVendorCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDVendorDescription")]
            public string ApplicationSTDVendorDescription
            {
                get
                {
                    return this.applicationSTDVendorDescriptionField;
                }
                set
                {
                    this.applicationSTDVendorDescriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.STDVendorUser")]
            public string ApplicationSTDVendorUser
            {
                get
                {
                    return this.applicationSTDVendorUserField;
                }
                set
                {
                    this.applicationSTDVendorUserField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.SuretyAmount")]
            public string ApplicationSuretyAmount
            {
                get
                {
                    return this.applicationSuretyAmountField;
                }
                set
                {
                    this.applicationSuretyAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.SuretyName")]
            public string ApplicationSuretyName
            {
                get
                {
                    return this.applicationSuretyNameField;
                }
                set
                {
                    this.applicationSuretyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Application.SuretyType")]
            public string ApplicationSuretyType
            {
                get
                {
                    return this.applicationSuretyTypeField;
                }
                set
                {
                    this.applicationSuretyTypeField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Application.TypeOfRate")]
            public string ApplicationTypeOfRate
            {
                get
                {
                    return this.applicationTypeOfRateField;
                }
                set
                {
                    this.applicationTypeOfRateField = value;
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

            private string applicantBankPackageField;

            private string applicantCellphoneField;

            private string applicantCompanyRegistrationNoField;

            private string applicantCorrespondenceLanguageField;

            private string applicantCountryOfBirthField;

            private string applicantCountryOfPermResidenceCodeField;

            private string applicantCurrentEmploymentStatusField;

            private string applicantCurrentMonthlyInstallmentField;

            private string applicantDateJoinedEmployerField;

            private string applicantDateOfBirthField;

            private string applicantDatePassportExpiresField;

            private string applicantDateRehabilitatedField;

            private string applicantDeclaredInsolventField;

            private string applicantEmailAddressField;

            private string applicantEmployeeNoField;

            private string applicantEmployerAddressField;

            private string applicantEmployerFaxCodeField;

            private string applicantEmployerFaxNoField;

            private string applicantEmployerNameField;

            private string applicantEmployerTelCodeField;

            private string applicantEmployerTelNoField;

            private string applicantEmploymentIndustryField;

            private string applicantEthnicGroupField;

            private string applicantFaxCodeField;

            private string applicantFaxNoField;

            private string applicantFirstNameField;

            private string applicantFrequencyOfSalaryPaymentsField;

            private string applicantGenderField;

            private string applicantHighestQualificationField;

            private string applicantHomePhoneField;

            private string applicantHomePhoneCodeField;

            private string applicantIdentificationNoField;

            private string applicantIdentificationTypeField;

            private string applicantIncomeMixField;

            private string applicantIncomeTaxNoField;

            private string applicantInitialsField;

            private string applicantIsUnderAdminOrderField;

            private string applicantIsUnderDebtReviewField;

            private string applicantMaritalStatusField;

            private string applicantMarriedStatusField;

            private string applicantMayBankContactYouField;

            private string applicantMayBankShareInfoField;

            private string applicantMayOthersContactYouField;

            private string applicantMaySubsidiariesContactYouField;

            private string applicantMayUseForResearchField;

            private string applicantNationalityField;

            private string applicantNoOfDependentsField;

            private string applicantOccupationField;

            private string applicantOccupationLevelField;

            private string applicantPassportNoField;

            private string applicantPermanentResidentField;

            private string applicantPermanentResidentCountryField;

            private string applicantPermitIssueDateField;

            private string applicantPermitNumberField;

            private string applicantPhysicalAddressLine1Field;

            private string applicantPhysicalAddressLine2Field;

            private string applicantPostalAddressCodeField;

            private string applicantPostalAddressLine1Field;

            private string applicantPostalAddressLine2Field;

            private string applicantPreviousEmployerNameField;

            private string applicantPreviousEmployerPeriodField;

            private string applicantRentingPropertyField;

            private string applicantRightOfRefusalConsentField;

            private string applicantSACitizenField;

            private string applicantSBSAIsAssociatedToOfficalField;

            private string applicantSBSAIsPublicOfficalField;

            private string applicantSBSANatureOfRelationshipField;

            private string applicantSBSAPOFirstNameField;

            private string applicantSBSAPOSurnameField;

            private string applicantShareHolderPercentageField;

            private string applicantSourceOfIncomeField;

            private string applicantSourceOfIncome1Field;

            private string applicantSourceOfIncome2Field;

            private string applicantSouthAfricanBankField;

            private string applicantSTDBondInstitutionField;

            private string applicantSTDCountryPassportIssuedIdField;

            private string applicantSTDDebitOrderResponsibleField;

            private string applicantSTDEmployerSuburbField;

            private string applicantSTDEmployerSuburbCodeField;

            private string applicantSTDEverCitixenField;

            private string applicantSTDIDXIndicatorField;

            private string applicantSTDIsSuretyField;

            private string applicantSTDMaintenanceIncomeField;

            private string applicantSTDPostalSuburbField;

            private string applicantSTDPostalSuburbCodeField;

            private string applicantSTDRentalIncomeField;

            private string applicantSTDResidentialSuburbField;

            private string applicantSTDResidentialSuburbCodeField;

            private string applicantSTDSelfEmployedProfessionalLevelField;

            private string applicantSTDSellingExistingPropertyField;

            private string applicantSTDSmokerStatusField;

            private string applicantSTDSourceOfIncomeAmountField;

            private string applicantSTDSourceOfIncomeAmount1Field;

            private string applicantSTDSourceOfIncomeAmount2Field;

            private string applicantSTDTypeOfPermitField;

            private string applicantSurnameField;

            private string applicantTempResidentField;

            private string applicantTempResidentPermitExpiryField;

            private string applicantTempResidentPermitNoField;

            private string applicantTitleField;

            private string applicantWorkPhoneField;

            private string applicantWorkPhoneCodeField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem[] applicantIncomeItemsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem[] applicantExpenditureItemsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount[] applicantBankAccountsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetails applicantSpouseDetailsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.BankPackage")]
            public string ApplicantBankPackage
            {
                get
                {
                    return this.applicantBankPackageField;
                }
                set
                {
                    this.applicantBankPackageField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CompanyRegistrationNo")]
            public string ApplicantCompanyRegistrationNo
            {
                get
                {
                    return this.applicantCompanyRegistrationNoField;
                }
                set
                {
                    this.applicantCompanyRegistrationNoField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CountryOfPermResidenceCode")]
            public string ApplicantCountryOfPermResidenceCode
            {
                get
                {
                    return this.applicantCountryOfPermResidenceCodeField;
                }
                set
                {
                    this.applicantCountryOfPermResidenceCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CurrentEmploymentStatus")]
            public string ApplicantCurrentEmploymentStatus
            {
                get
                {
                    return this.applicantCurrentEmploymentStatusField;
                }
                set
                {
                    this.applicantCurrentEmploymentStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CurrentMonthlyInstallment")]
            public string ApplicantCurrentMonthlyInstallment
            {
                get
                {
                    return this.applicantCurrentMonthlyInstallmentField;
                }
                set
                {
                    this.applicantCurrentMonthlyInstallmentField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployeeNo")]
            public string ApplicantEmployeeNo
            {
                get
                {
                    return this.applicantEmployeeNoField;
                }
                set
                {
                    this.applicantEmployeeNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerAddress")]
            public string ApplicantEmployerAddress
            {
                get
                {
                    return this.applicantEmployerAddressField;
                }
                set
                {
                    this.applicantEmployerAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerFaxCode")]
            public string ApplicantEmployerFaxCode
            {
                get
                {
                    return this.applicantEmployerFaxCodeField;
                }
                set
                {
                    this.applicantEmployerFaxCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerFaxNo")]
            public string ApplicantEmployerFaxNo
            {
                get
                {
                    return this.applicantEmployerFaxNoField;
                }
                set
                {
                    this.applicantEmployerFaxNoField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FrequencyOfSalaryPayments")]
            public string ApplicantFrequencyOfSalaryPayments
            {
                get
                {
                    return this.applicantFrequencyOfSalaryPaymentsField;
                }
                set
                {
                    this.applicantFrequencyOfSalaryPaymentsField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HighestQualification")]
            public string ApplicantHighestQualification
            {
                get
                {
                    return this.applicantHighestQualificationField;
                }
                set
                {
                    this.applicantHighestQualificationField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeMix")]
            public string ApplicantIncomeMix
            {
                get
                {
                    return this.applicantIncomeMixField;
                }
                set
                {
                    this.applicantIncomeMixField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Initials")]
            public string ApplicantInitials
            {
                get
                {
                    return this.applicantInitialsField;
                }
                set
                {
                    this.applicantInitialsField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayBankShareInfo")]
            public string ApplicantMayBankShareInfo
            {
                get
                {
                    return this.applicantMayBankShareInfoField;
                }
                set
                {
                    this.applicantMayBankShareInfoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayOthersContactYou")]
            public string ApplicantMayOthersContactYou
            {
                get
                {
                    return this.applicantMayOthersContactYouField;
                }
                set
                {
                    this.applicantMayOthersContactYouField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayUseForResearch")]
            public string ApplicantMayUseForResearch
            {
                get
                {
                    return this.applicantMayUseForResearchField;
                }
                set
                {
                    this.applicantMayUseForResearchField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermitNumber")]
            public string ApplicantPermitNumber
            {
                get
                {
                    return this.applicantPermitNumberField;
                }
                set
                {
                    this.applicantPermitNumberField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.RentingProperty")]
            public string ApplicantRentingProperty
            {
                get
                {
                    return this.applicantRentingPropertyField;
                }
                set
                {
                    this.applicantRentingPropertyField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSAIsAssociatedToOffical")]
            public string ApplicantSBSAIsAssociatedToOffical
            {
                get
                {
                    return this.applicantSBSAIsAssociatedToOfficalField;
                }
                set
                {
                    this.applicantSBSAIsAssociatedToOfficalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSAIsPublicOffical")]
            public string ApplicantSBSAIsPublicOffical
            {
                get
                {
                    return this.applicantSBSAIsPublicOfficalField;
                }
                set
                {
                    this.applicantSBSAIsPublicOfficalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSANatureOfRelationship")]
            public string ApplicantSBSANatureOfRelationship
            {
                get
                {
                    return this.applicantSBSANatureOfRelationshipField;
                }
                set
                {
                    this.applicantSBSANatureOfRelationshipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSAPOFirstName")]
            public string ApplicantSBSAPOFirstName
            {
                get
                {
                    return this.applicantSBSAPOFirstNameField;
                }
                set
                {
                    this.applicantSBSAPOFirstNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSAPOSurname")]
            public string ApplicantSBSAPOSurname
            {
                get
                {
                    return this.applicantSBSAPOSurnameField;
                }
                set
                {
                    this.applicantSBSAPOSurnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ShareHolderPercentage")]
            public string ApplicantShareHolderPercentage
            {
                get
                {
                    return this.applicantShareHolderPercentageField;
                }
                set
                {
                    this.applicantShareHolderPercentageField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncome1")]
            public string ApplicantSourceOfIncome1
            {
                get
                {
                    return this.applicantSourceOfIncome1Field;
                }
                set
                {
                    this.applicantSourceOfIncome1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncome2")]
            public string ApplicantSourceOfIncome2
            {
                get
                {
                    return this.applicantSourceOfIncome2Field;
                }
                set
                {
                    this.applicantSourceOfIncome2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SouthAfricanBank")]
            public string ApplicantSouthAfricanBank
            {
                get
                {
                    return this.applicantSouthAfricanBankField;
                }
                set
                {
                    this.applicantSouthAfricanBankField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDBondInstitution")]
            public string ApplicantSTDBondInstitution
            {
                get
                {
                    return this.applicantSTDBondInstitutionField;
                }
                set
                {
                    this.applicantSTDBondInstitutionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDCountryPassportIssuedId")]
            public string ApplicantSTDCountryPassportIssuedId
            {
                get
                {
                    return this.applicantSTDCountryPassportIssuedIdField;
                }
                set
                {
                    this.applicantSTDCountryPassportIssuedIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDDebitOrderResponsible")]
            public string ApplicantSTDDebitOrderResponsible
            {
                get
                {
                    return this.applicantSTDDebitOrderResponsibleField;
                }
                set
                {
                    this.applicantSTDDebitOrderResponsibleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDEmployerSuburb")]
            public string ApplicantSTDEmployerSuburb
            {
                get
                {
                    return this.applicantSTDEmployerSuburbField;
                }
                set
                {
                    this.applicantSTDEmployerSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDEmployerSuburbCode")]
            public string ApplicantSTDEmployerSuburbCode
            {
                get
                {
                    return this.applicantSTDEmployerSuburbCodeField;
                }
                set
                {
                    this.applicantSTDEmployerSuburbCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDEverCitixen")]
            public string ApplicantSTDEverCitixen
            {
                get
                {
                    return this.applicantSTDEverCitixenField;
                }
                set
                {
                    this.applicantSTDEverCitixenField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDIDXIndicator")]
            public string ApplicantSTDIDXIndicator
            {
                get
                {
                    return this.applicantSTDIDXIndicatorField;
                }
                set
                {
                    this.applicantSTDIDXIndicatorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDIsSurety")]
            public string ApplicantSTDIsSurety
            {
                get
                {
                    return this.applicantSTDIsSuretyField;
                }
                set
                {
                    this.applicantSTDIsSuretyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDMaintenanceIncome")]
            public string ApplicantSTDMaintenanceIncome
            {
                get
                {
                    return this.applicantSTDMaintenanceIncomeField;
                }
                set
                {
                    this.applicantSTDMaintenanceIncomeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDPostalSuburb")]
            public string ApplicantSTDPostalSuburb
            {
                get
                {
                    return this.applicantSTDPostalSuburbField;
                }
                set
                {
                    this.applicantSTDPostalSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDPostalSuburbCode")]
            public string ApplicantSTDPostalSuburbCode
            {
                get
                {
                    return this.applicantSTDPostalSuburbCodeField;
                }
                set
                {
                    this.applicantSTDPostalSuburbCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDRentalIncome")]
            public string ApplicantSTDRentalIncome
            {
                get
                {
                    return this.applicantSTDRentalIncomeField;
                }
                set
                {
                    this.applicantSTDRentalIncomeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDResidentialSuburb")]
            public string ApplicantSTDResidentialSuburb
            {
                get
                {
                    return this.applicantSTDResidentialSuburbField;
                }
                set
                {
                    this.applicantSTDResidentialSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDResidentialSuburbCode")]
            public string ApplicantSTDResidentialSuburbCode
            {
                get
                {
                    return this.applicantSTDResidentialSuburbCodeField;
                }
                set
                {
                    this.applicantSTDResidentialSuburbCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSelfEmployedProfessionalLevel")]
            public string ApplicantSTDSelfEmployedProfessionalLevel
            {
                get
                {
                    return this.applicantSTDSelfEmployedProfessionalLevelField;
                }
                set
                {
                    this.applicantSTDSelfEmployedProfessionalLevelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSellingExistingProperty")]
            public string ApplicantSTDSellingExistingProperty
            {
                get
                {
                    return this.applicantSTDSellingExistingPropertyField;
                }
                set
                {
                    this.applicantSTDSellingExistingPropertyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSmokerStatus")]
            public string ApplicantSTDSmokerStatus
            {
                get
                {
                    return this.applicantSTDSmokerStatusField;
                }
                set
                {
                    this.applicantSTDSmokerStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSourceOfIncomeAmount")]
            public string ApplicantSTDSourceOfIncomeAmount
            {
                get
                {
                    return this.applicantSTDSourceOfIncomeAmountField;
                }
                set
                {
                    this.applicantSTDSourceOfIncomeAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSourceOfIncomeAmount1")]
            public string ApplicantSTDSourceOfIncomeAmount1
            {
                get
                {
                    return this.applicantSTDSourceOfIncomeAmount1Field;
                }
                set
                {
                    this.applicantSTDSourceOfIncomeAmount1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSourceOfIncomeAmount2")]
            public string ApplicantSTDSourceOfIncomeAmount2
            {
                get
                {
                    return this.applicantSTDSourceOfIncomeAmount2Field;
                }
                set
                {
                    this.applicantSTDSourceOfIncomeAmount2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDTypeOfPermit")]
            public string ApplicantSTDTypeOfPermit
            {
                get
                {
                    return this.applicantSTDTypeOfPermitField;
                }
                set
                {
                    this.applicantSTDTypeOfPermitField = value;
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

            private string applicantAccountInstitutionField;

            private string applicantAccountNameField;

            private string applicantAccountNumberField;

            private string applicantAccountTypeField;

            private string applicantIsMainAccountField;

            private string applicantSTDAccountBranchField;

            private string applicantSTDAccountBranchCodeField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDAccountBranch")]
            public string ApplicantSTDAccountBranch
            {
                get
                {
                    return this.applicantSTDAccountBranchField;
                }
                set
                {
                    this.applicantSTDAccountBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDAccountBranchCode")]
            public string ApplicantSTDAccountBranchCode
            {
                get
                {
                    return this.applicantSTDAccountBranchCodeField;
                }
                set
                {
                    this.applicantSTDAccountBranchCodeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetails
        {

            private string applicantBankPackageField;

            private string applicantCellphoneField;

            private string applicantCompanyRegistrationNoField;

            private string applicantCorrespondenceLanguageField;

            private string applicantCountryOfBirthField;

            private string applicantCountryOfPermResidenceCodeField;

            private string applicantCurrentEmploymentStatusField;

            private string applicantCurrentMonthlyInstallmentField;

            private string applicantDateJoinedEmployerField;

            private string applicantDateOfBirthField;

            private string applicantDatePassportExpiresField;

            private string applicantDateRehabilitatedField;

            private string applicantDeclaredInsolventField;

            private string applicantEmailAddressField;

            private string applicantEmployeeNoField;

            private string applicantEmployerAddressField;

            private string applicantEmployerFaxCodeField;

            private string applicantEmployerFaxNoField;

            private string applicantEmployerNameField;

            private string applicantEmployerTelCodeField;

            private string applicantEmployerTelNoField;

            private string applicantEmploymentIndustryField;

            private string applicantEthnicGroupField;

            private string applicantFaxCodeField;

            private string applicantFaxNoField;

            private string applicantFirstNameField;

            private string applicantFrequencyOfSalaryPaymentsField;

            private string applicantGenderField;

            private string applicantHighestQualificationField;

            private string applicantHomePhoneField;

            private string applicantHomePhoneCodeField;

            private string applicantIdentificationNoField;

            private string applicantIdentificationTypeField;

            private string applicantIncomeMixField;

            private string applicantIncomeTaxNoField;

            private string applicantInitialsField;

            private string applicantIsUnderAdminOrderField;

            private string applicantIsUnderDebtReviewField;

            private string applicantMaritalStatusField;

            private string applicantMarriedStatusField;

            private string applicantMayBankContactYouField;

            private string applicantMayBankShareInfoField;

            private string applicantMayOthersContactYouField;

            private string applicantMaySubsidiariesContactYouField;

            private string applicantMayUseForResearchField;

            private string applicantNationalityField;

            private string applicantNoOfDependentsField;

            private string applicantOccupationField;

            private string applicantOccupationLevelField;

            private string applicantPassportNoField;

            private string applicantPermanentResidentField;

            private string applicantPermanentResidentCountryField;

            private string applicantPermitIssueDateField;

            private string applicantPermitNumberField;

            private string applicantPhysicalAddressLine1Field;

            private string applicantPhysicalAddressLine2Field;

            private string applicantPostalAddressCodeField;

            private string applicantPostalAddressLine1Field;

            private string applicantPostalAddressLine2Field;

            private string applicantPreviousEmployerNameField;

            private string applicantPreviousEmployerPeriodField;

            private string applicantRentingPropertyField;

            private string applicantRightOfRefusalConsentField;

            private string applicantSACitizenField;

            private string applicantSBSAIsAssociatedToOfficalField;

            private string applicantSBSAIsPublicOfficalField;

            private string applicantSBSANatureOfRelationshipField;

            private string applicantSBSAPOFirstNameField;

            private string applicantSBSAPOSurnameField;

            private string applicantShareHolderPercentageField;

            private string applicantSourceOfIncomeField;

            private string applicantSourceOfIncome1Field;

            private string applicantSourceOfIncome2Field;

            private string applicantSouthAfricanBankField;

            private string applicantSTDBondInstitutionField;

            private string applicantSTDCountryPassportIssuedIdField;

            private string applicantSTDDebitOrderResponsibleField;

            private string applicantSTDEmployerSuburbField;

            private string applicantSTDEmployerSuburbCodeField;

            private string applicantSTDEverCitixenField;

            private string applicantSTDIDXIndicatorField;

            private string applicantSTDIsSuretyField;

            private string applicantSTDMaintenanceIncomeField;

            private string applicantSTDPostalSuburbField;

            private string applicantSTDPostalSuburbCodeField;

            private string applicantSTDRentalIncomeField;

            private string applicantSTDResidentialSuburbField;

            private string applicantSTDResidentialSuburbCodeField;

            private string applicantSTDSelfEmployedProfessionalLevelField;

            private string applicantSTDSellingExistingPropertyField;

            private string applicantSTDSmokerStatusField;

            private string applicantSTDSourceOfIncomeAmountField;

            private string applicantSTDSourceOfIncomeAmount1Field;

            private string applicantSTDSourceOfIncomeAmount2Field;

            private string applicantSTDTypeOfPermitField;

            private string applicantSurnameField;

            private string applicantTempResidentField;

            private string applicantTempResidentPermitExpiryField;

            private string applicantTempResidentPermitNoField;

            private string applicantTitleField;

            private string applicantWorkPhoneField;

            private string applicantWorkPhoneCodeField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem[] applicantIncomeItemsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem[] applicantExpenditureItemsField;

            private SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantBankAccount[] applicantBankAccountsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.BankPackage")]
            public string ApplicantBankPackage
            {
                get
                {
                    return this.applicantBankPackageField;
                }
                set
                {
                    this.applicantBankPackageField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CompanyRegistrationNo")]
            public string ApplicantCompanyRegistrationNo
            {
                get
                {
                    return this.applicantCompanyRegistrationNoField;
                }
                set
                {
                    this.applicantCompanyRegistrationNoField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CountryOfPermResidenceCode")]
            public string ApplicantCountryOfPermResidenceCode
            {
                get
                {
                    return this.applicantCountryOfPermResidenceCodeField;
                }
                set
                {
                    this.applicantCountryOfPermResidenceCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CurrentEmploymentStatus")]
            public string ApplicantCurrentEmploymentStatus
            {
                get
                {
                    return this.applicantCurrentEmploymentStatusField;
                }
                set
                {
                    this.applicantCurrentEmploymentStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CurrentMonthlyInstallment")]
            public string ApplicantCurrentMonthlyInstallment
            {
                get
                {
                    return this.applicantCurrentMonthlyInstallmentField;
                }
                set
                {
                    this.applicantCurrentMonthlyInstallmentField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployeeNo")]
            public string ApplicantEmployeeNo
            {
                get
                {
                    return this.applicantEmployeeNoField;
                }
                set
                {
                    this.applicantEmployeeNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerAddress")]
            public string ApplicantEmployerAddress
            {
                get
                {
                    return this.applicantEmployerAddressField;
                }
                set
                {
                    this.applicantEmployerAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerFaxCode")]
            public string ApplicantEmployerFaxCode
            {
                get
                {
                    return this.applicantEmployerFaxCodeField;
                }
                set
                {
                    this.applicantEmployerFaxCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerFaxNo")]
            public string ApplicantEmployerFaxNo
            {
                get
                {
                    return this.applicantEmployerFaxNoField;
                }
                set
                {
                    this.applicantEmployerFaxNoField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FrequencyOfSalaryPayments")]
            public string ApplicantFrequencyOfSalaryPayments
            {
                get
                {
                    return this.applicantFrequencyOfSalaryPaymentsField;
                }
                set
                {
                    this.applicantFrequencyOfSalaryPaymentsField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HighestQualification")]
            public string ApplicantHighestQualification
            {
                get
                {
                    return this.applicantHighestQualificationField;
                }
                set
                {
                    this.applicantHighestQualificationField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeMix")]
            public string ApplicantIncomeMix
            {
                get
                {
                    return this.applicantIncomeMixField;
                }
                set
                {
                    this.applicantIncomeMixField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Initials")]
            public string ApplicantInitials
            {
                get
                {
                    return this.applicantInitialsField;
                }
                set
                {
                    this.applicantInitialsField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayBankShareInfo")]
            public string ApplicantMayBankShareInfo
            {
                get
                {
                    return this.applicantMayBankShareInfoField;
                }
                set
                {
                    this.applicantMayBankShareInfoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayOthersContactYou")]
            public string ApplicantMayOthersContactYou
            {
                get
                {
                    return this.applicantMayOthersContactYouField;
                }
                set
                {
                    this.applicantMayOthersContactYouField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayUseForResearch")]
            public string ApplicantMayUseForResearch
            {
                get
                {
                    return this.applicantMayUseForResearchField;
                }
                set
                {
                    this.applicantMayUseForResearchField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermitNumber")]
            public string ApplicantPermitNumber
            {
                get
                {
                    return this.applicantPermitNumberField;
                }
                set
                {
                    this.applicantPermitNumberField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.RentingProperty")]
            public string ApplicantRentingProperty
            {
                get
                {
                    return this.applicantRentingPropertyField;
                }
                set
                {
                    this.applicantRentingPropertyField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSAIsAssociatedToOffical")]
            public string ApplicantSBSAIsAssociatedToOffical
            {
                get
                {
                    return this.applicantSBSAIsAssociatedToOfficalField;
                }
                set
                {
                    this.applicantSBSAIsAssociatedToOfficalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSAIsPublicOffical")]
            public string ApplicantSBSAIsPublicOffical
            {
                get
                {
                    return this.applicantSBSAIsPublicOfficalField;
                }
                set
                {
                    this.applicantSBSAIsPublicOfficalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSANatureOfRelationship")]
            public string ApplicantSBSANatureOfRelationship
            {
                get
                {
                    return this.applicantSBSANatureOfRelationshipField;
                }
                set
                {
                    this.applicantSBSANatureOfRelationshipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSAPOFirstName")]
            public string ApplicantSBSAPOFirstName
            {
                get
                {
                    return this.applicantSBSAPOFirstNameField;
                }
                set
                {
                    this.applicantSBSAPOFirstNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSAPOSurname")]
            public string ApplicantSBSAPOSurname
            {
                get
                {
                    return this.applicantSBSAPOSurnameField;
                }
                set
                {
                    this.applicantSBSAPOSurnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ShareHolderPercentage")]
            public string ApplicantShareHolderPercentage
            {
                get
                {
                    return this.applicantShareHolderPercentageField;
                }
                set
                {
                    this.applicantShareHolderPercentageField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncome1")]
            public string ApplicantSourceOfIncome1
            {
                get
                {
                    return this.applicantSourceOfIncome1Field;
                }
                set
                {
                    this.applicantSourceOfIncome1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncome2")]
            public string ApplicantSourceOfIncome2
            {
                get
                {
                    return this.applicantSourceOfIncome2Field;
                }
                set
                {
                    this.applicantSourceOfIncome2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SouthAfricanBank")]
            public string ApplicantSouthAfricanBank
            {
                get
                {
                    return this.applicantSouthAfricanBankField;
                }
                set
                {
                    this.applicantSouthAfricanBankField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDBondInstitution")]
            public string ApplicantSTDBondInstitution
            {
                get
                {
                    return this.applicantSTDBondInstitutionField;
                }
                set
                {
                    this.applicantSTDBondInstitutionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDCountryPassportIssuedId")]
            public string ApplicantSTDCountryPassportIssuedId
            {
                get
                {
                    return this.applicantSTDCountryPassportIssuedIdField;
                }
                set
                {
                    this.applicantSTDCountryPassportIssuedIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDDebitOrderResponsible")]
            public string ApplicantSTDDebitOrderResponsible
            {
                get
                {
                    return this.applicantSTDDebitOrderResponsibleField;
                }
                set
                {
                    this.applicantSTDDebitOrderResponsibleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDEmployerSuburb")]
            public string ApplicantSTDEmployerSuburb
            {
                get
                {
                    return this.applicantSTDEmployerSuburbField;
                }
                set
                {
                    this.applicantSTDEmployerSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDEmployerSuburbCode")]
            public string ApplicantSTDEmployerSuburbCode
            {
                get
                {
                    return this.applicantSTDEmployerSuburbCodeField;
                }
                set
                {
                    this.applicantSTDEmployerSuburbCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDEverCitixen")]
            public string ApplicantSTDEverCitixen
            {
                get
                {
                    return this.applicantSTDEverCitixenField;
                }
                set
                {
                    this.applicantSTDEverCitixenField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDIDXIndicator")]
            public string ApplicantSTDIDXIndicator
            {
                get
                {
                    return this.applicantSTDIDXIndicatorField;
                }
                set
                {
                    this.applicantSTDIDXIndicatorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDIsSurety")]
            public string ApplicantSTDIsSurety
            {
                get
                {
                    return this.applicantSTDIsSuretyField;
                }
                set
                {
                    this.applicantSTDIsSuretyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDMaintenanceIncome")]
            public string ApplicantSTDMaintenanceIncome
            {
                get
                {
                    return this.applicantSTDMaintenanceIncomeField;
                }
                set
                {
                    this.applicantSTDMaintenanceIncomeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDPostalSuburb")]
            public string ApplicantSTDPostalSuburb
            {
                get
                {
                    return this.applicantSTDPostalSuburbField;
                }
                set
                {
                    this.applicantSTDPostalSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDPostalSuburbCode")]
            public string ApplicantSTDPostalSuburbCode
            {
                get
                {
                    return this.applicantSTDPostalSuburbCodeField;
                }
                set
                {
                    this.applicantSTDPostalSuburbCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDRentalIncome")]
            public string ApplicantSTDRentalIncome
            {
                get
                {
                    return this.applicantSTDRentalIncomeField;
                }
                set
                {
                    this.applicantSTDRentalIncomeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDResidentialSuburb")]
            public string ApplicantSTDResidentialSuburb
            {
                get
                {
                    return this.applicantSTDResidentialSuburbField;
                }
                set
                {
                    this.applicantSTDResidentialSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDResidentialSuburbCode")]
            public string ApplicantSTDResidentialSuburbCode
            {
                get
                {
                    return this.applicantSTDResidentialSuburbCodeField;
                }
                set
                {
                    this.applicantSTDResidentialSuburbCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSelfEmployedProfessionalLevel")]
            public string ApplicantSTDSelfEmployedProfessionalLevel
            {
                get
                {
                    return this.applicantSTDSelfEmployedProfessionalLevelField;
                }
                set
                {
                    this.applicantSTDSelfEmployedProfessionalLevelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSellingExistingProperty")]
            public string ApplicantSTDSellingExistingProperty
            {
                get
                {
                    return this.applicantSTDSellingExistingPropertyField;
                }
                set
                {
                    this.applicantSTDSellingExistingPropertyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSmokerStatus")]
            public string ApplicantSTDSmokerStatus
            {
                get
                {
                    return this.applicantSTDSmokerStatusField;
                }
                set
                {
                    this.applicantSTDSmokerStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSourceOfIncomeAmount")]
            public string ApplicantSTDSourceOfIncomeAmount
            {
                get
                {
                    return this.applicantSTDSourceOfIncomeAmountField;
                }
                set
                {
                    this.applicantSTDSourceOfIncomeAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSourceOfIncomeAmount1")]
            public string ApplicantSTDSourceOfIncomeAmount1
            {
                get
                {
                    return this.applicantSTDSourceOfIncomeAmount1Field;
                }
                set
                {
                    this.applicantSTDSourceOfIncomeAmount1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSourceOfIncomeAmount2")]
            public string ApplicantSTDSourceOfIncomeAmount2
            {
                get
                {
                    return this.applicantSTDSourceOfIncomeAmount2Field;
                }
                set
                {
                    this.applicantSTDSourceOfIncomeAmount2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDTypeOfPermit")]
            public string ApplicantSTDTypeOfPermit
            {
                get
                {
                    return this.applicantSTDTypeOfPermitField;
                }
                set
                {
                    this.applicantSTDTypeOfPermitField = value;
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

            private string applicantAccountInstitutionField;

            private string applicantAccountNameField;

            private string applicantAccountNumberField;

            private string applicantAccountTypeField;

            private string applicantIsMainAccountField;

            private string applicantSTDAccountBranchField;

            private string applicantSTDAccountBranchCodeField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDAccountBranch")]
            public string ApplicantSTDAccountBranch
            {
                get
                {
                    return this.applicantSTDAccountBranchField;
                }
                set
                {
                    this.applicantSTDAccountBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDAccountBranchCode")]
            public string ApplicantSTDAccountBranchCode
            {
                get
                {
                    return this.applicantSTDAccountBranchCodeField;
                }
                set
                {
                    this.applicantSTDAccountBranchCodeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetails
        {

            private string applicantBankPackageField;

            private string applicantCellphoneField;

            private string applicantCompanyRegistrationNoField;

            private string applicantCorrespondenceLanguageField;

            private string applicantCountryOfBirthField;

            private string applicantCountryOfPermResidenceCodeField;

            private string applicantCurrentEmploymentStatusField;

            private string applicantCurrentMonthlyInstallmentField;

            private string applicantDateJoinedEmployerField;

            private string applicantDateOfBirthField;

            private string applicantDatePassportExpiresField;

            private string applicantDateRehabilitatedField;

            private string applicantDeclaredInsolventField;

            private string applicantEmailAddressField;

            private string applicantEmployeeNoField;

            private string applicantEmployerAddressField;

            private string applicantEmployerFaxCodeField;

            private string applicantEmployerFaxNoField;

            private string applicantEmployerNameField;

            private string applicantEmployerTelCodeField;

            private string applicantEmployerTelNoField;

            private string applicantEmploymentIndustryField;

            private string applicantEthnicGroupField;

            private string applicantFaxCodeField;

            private string applicantFaxNoField;

            private string applicantFirstNameField;

            private string applicantFrequencyOfSalaryPaymentsField;

            private string applicantGenderField;

            private string applicantHighestQualificationField;

            private string applicantHomePhoneField;

            private string applicantHomePhoneCodeField;

            private string applicantIdentificationNoField;

            private string applicantIdentificationTypeField;

            private string applicantIncomeMixField;

            private string applicantIncomeTaxNoField;

            private string applicantInitialsField;

            private string applicantIsUnderAdminOrderField;

            private string applicantIsUnderDebtReviewField;

            private string applicantMaritalStatusField;

            private string applicantMarriedStatusField;

            private string applicantMayBankContactYouField;

            private string applicantMayBankShareInfoField;

            private string applicantMayOthersContactYouField;

            private string applicantMaySubsidiariesContactYouField;

            private string applicantMayUseForResearchField;

            private string applicantNationalityField;

            private string applicantNoOfDependentsField;

            private string applicantOccupationField;

            private string applicantOccupationLevelField;

            private string applicantPassportNoField;

            private string applicantPermanentResidentField;

            private string applicantPermanentResidentCountryField;

            private string applicantPermitIssueDateField;

            private string applicantPermitNumberField;

            private string applicantPhysicalAddressLine1Field;

            private string applicantPhysicalAddressLine2Field;

            private string applicantPostalAddressCodeField;

            private string applicantPostalAddressLine1Field;

            private string applicantPostalAddressLine2Field;

            private string applicantPreviousEmployerNameField;

            private string applicantPreviousEmployerPeriodField;

            private string applicantRentingPropertyField;

            private string applicantRightOfRefusalConsentField;

            private string applicantSACitizenField;

            private string applicantSBSAIsAssociatedToOfficalField;

            private string applicantSBSAIsPublicOfficalField;

            private string applicantSBSANatureOfRelationshipField;

            private string applicantSBSAPOFirstNameField;

            private string applicantSBSAPOSurnameField;

            private string applicantShareHolderPercentageField;

            private string applicantSourceOfIncomeField;

            private string applicantSourceOfIncome1Field;

            private string applicantSourceOfIncome2Field;

            private string applicantSouthAfricanBankField;

            private string applicantSTDBondInstitutionField;

            private string applicantSTDCountryPassportIssuedIdField;

            private string applicantSTDDebitOrderResponsibleField;

            private string applicantSTDEmployerSuburbField;

            private string applicantSTDEmployerSuburbCodeField;

            private string applicantSTDEverCitixenField;

            private string applicantSTDIDXIndicatorField;

            private string applicantSTDIsSuretyField;

            private string applicantSTDMaintenanceIncomeField;

            private string applicantSTDPostalSuburbField;

            private string applicantSTDPostalSuburbCodeField;

            private string applicantSTDRentalIncomeField;

            private string applicantSTDResidentialSuburbField;

            private string applicantSTDResidentialSuburbCodeField;

            private string applicantSTDSelfEmployedProfessionalLevelField;

            private string applicantSTDSellingExistingPropertyField;

            private string applicantSTDSmokerStatusField;

            private string applicantSTDSourceOfIncomeAmountField;

            private string applicantSTDSourceOfIncomeAmount1Field;

            private string applicantSTDSourceOfIncomeAmount2Field;

            private string applicantSTDTypeOfPermitField;

            private string applicantSurnameField;

            private string applicantTempResidentField;

            private string applicantTempResidentPermitExpiryField;

            private string applicantTempResidentPermitNoField;

            private string applicantTitleField;

            private string applicantWorkPhoneField;

            private string applicantWorkPhoneCodeField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantIncomeItem[] applicantIncomeItemsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantExpenditureItem[] applicantExpenditureItemsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantBankAccounts applicantBankAccountsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetails applicantSpouseDetailsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.BankPackage")]
            public string ApplicantBankPackage
            {
                get
                {
                    return this.applicantBankPackageField;
                }
                set
                {
                    this.applicantBankPackageField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CompanyRegistrationNo")]
            public string ApplicantCompanyRegistrationNo
            {
                get
                {
                    return this.applicantCompanyRegistrationNoField;
                }
                set
                {
                    this.applicantCompanyRegistrationNoField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CountryOfPermResidenceCode")]
            public string ApplicantCountryOfPermResidenceCode
            {
                get
                {
                    return this.applicantCountryOfPermResidenceCodeField;
                }
                set
                {
                    this.applicantCountryOfPermResidenceCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CurrentEmploymentStatus")]
            public string ApplicantCurrentEmploymentStatus
            {
                get
                {
                    return this.applicantCurrentEmploymentStatusField;
                }
                set
                {
                    this.applicantCurrentEmploymentStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CurrentMonthlyInstallment")]
            public string ApplicantCurrentMonthlyInstallment
            {
                get
                {
                    return this.applicantCurrentMonthlyInstallmentField;
                }
                set
                {
                    this.applicantCurrentMonthlyInstallmentField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployeeNo")]
            public string ApplicantEmployeeNo
            {
                get
                {
                    return this.applicantEmployeeNoField;
                }
                set
                {
                    this.applicantEmployeeNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerAddress")]
            public string ApplicantEmployerAddress
            {
                get
                {
                    return this.applicantEmployerAddressField;
                }
                set
                {
                    this.applicantEmployerAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerFaxCode")]
            public string ApplicantEmployerFaxCode
            {
                get
                {
                    return this.applicantEmployerFaxCodeField;
                }
                set
                {
                    this.applicantEmployerFaxCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerFaxNo")]
            public string ApplicantEmployerFaxNo
            {
                get
                {
                    return this.applicantEmployerFaxNoField;
                }
                set
                {
                    this.applicantEmployerFaxNoField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FrequencyOfSalaryPayments")]
            public string ApplicantFrequencyOfSalaryPayments
            {
                get
                {
                    return this.applicantFrequencyOfSalaryPaymentsField;
                }
                set
                {
                    this.applicantFrequencyOfSalaryPaymentsField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HighestQualification")]
            public string ApplicantHighestQualification
            {
                get
                {
                    return this.applicantHighestQualificationField;
                }
                set
                {
                    this.applicantHighestQualificationField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeMix")]
            public string ApplicantIncomeMix
            {
                get
                {
                    return this.applicantIncomeMixField;
                }
                set
                {
                    this.applicantIncomeMixField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Initials")]
            public string ApplicantInitials
            {
                get
                {
                    return this.applicantInitialsField;
                }
                set
                {
                    this.applicantInitialsField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayBankShareInfo")]
            public string ApplicantMayBankShareInfo
            {
                get
                {
                    return this.applicantMayBankShareInfoField;
                }
                set
                {
                    this.applicantMayBankShareInfoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayOthersContactYou")]
            public string ApplicantMayOthersContactYou
            {
                get
                {
                    return this.applicantMayOthersContactYouField;
                }
                set
                {
                    this.applicantMayOthersContactYouField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayUseForResearch")]
            public string ApplicantMayUseForResearch
            {
                get
                {
                    return this.applicantMayUseForResearchField;
                }
                set
                {
                    this.applicantMayUseForResearchField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermitNumber")]
            public string ApplicantPermitNumber
            {
                get
                {
                    return this.applicantPermitNumberField;
                }
                set
                {
                    this.applicantPermitNumberField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.RentingProperty")]
            public string ApplicantRentingProperty
            {
                get
                {
                    return this.applicantRentingPropertyField;
                }
                set
                {
                    this.applicantRentingPropertyField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSAIsAssociatedToOffical")]
            public string ApplicantSBSAIsAssociatedToOffical
            {
                get
                {
                    return this.applicantSBSAIsAssociatedToOfficalField;
                }
                set
                {
                    this.applicantSBSAIsAssociatedToOfficalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSAIsPublicOffical")]
            public string ApplicantSBSAIsPublicOffical
            {
                get
                {
                    return this.applicantSBSAIsPublicOfficalField;
                }
                set
                {
                    this.applicantSBSAIsPublicOfficalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSANatureOfRelationship")]
            public string ApplicantSBSANatureOfRelationship
            {
                get
                {
                    return this.applicantSBSANatureOfRelationshipField;
                }
                set
                {
                    this.applicantSBSANatureOfRelationshipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSAPOFirstName")]
            public string ApplicantSBSAPOFirstName
            {
                get
                {
                    return this.applicantSBSAPOFirstNameField;
                }
                set
                {
                    this.applicantSBSAPOFirstNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSAPOSurname")]
            public string ApplicantSBSAPOSurname
            {
                get
                {
                    return this.applicantSBSAPOSurnameField;
                }
                set
                {
                    this.applicantSBSAPOSurnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ShareHolderPercentage")]
            public string ApplicantShareHolderPercentage
            {
                get
                {
                    return this.applicantShareHolderPercentageField;
                }
                set
                {
                    this.applicantShareHolderPercentageField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncome1")]
            public string ApplicantSourceOfIncome1
            {
                get
                {
                    return this.applicantSourceOfIncome1Field;
                }
                set
                {
                    this.applicantSourceOfIncome1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncome2")]
            public string ApplicantSourceOfIncome2
            {
                get
                {
                    return this.applicantSourceOfIncome2Field;
                }
                set
                {
                    this.applicantSourceOfIncome2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SouthAfricanBank")]
            public string ApplicantSouthAfricanBank
            {
                get
                {
                    return this.applicantSouthAfricanBankField;
                }
                set
                {
                    this.applicantSouthAfricanBankField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDBondInstitution")]
            public string ApplicantSTDBondInstitution
            {
                get
                {
                    return this.applicantSTDBondInstitutionField;
                }
                set
                {
                    this.applicantSTDBondInstitutionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDCountryPassportIssuedId")]
            public string ApplicantSTDCountryPassportIssuedId
            {
                get
                {
                    return this.applicantSTDCountryPassportIssuedIdField;
                }
                set
                {
                    this.applicantSTDCountryPassportIssuedIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDDebitOrderResponsible")]
            public string ApplicantSTDDebitOrderResponsible
            {
                get
                {
                    return this.applicantSTDDebitOrderResponsibleField;
                }
                set
                {
                    this.applicantSTDDebitOrderResponsibleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDEmployerSuburb")]
            public string ApplicantSTDEmployerSuburb
            {
                get
                {
                    return this.applicantSTDEmployerSuburbField;
                }
                set
                {
                    this.applicantSTDEmployerSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDEmployerSuburbCode")]
            public string ApplicantSTDEmployerSuburbCode
            {
                get
                {
                    return this.applicantSTDEmployerSuburbCodeField;
                }
                set
                {
                    this.applicantSTDEmployerSuburbCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDEverCitixen")]
            public string ApplicantSTDEverCitixen
            {
                get
                {
                    return this.applicantSTDEverCitixenField;
                }
                set
                {
                    this.applicantSTDEverCitixenField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDIDXIndicator")]
            public string ApplicantSTDIDXIndicator
            {
                get
                {
                    return this.applicantSTDIDXIndicatorField;
                }
                set
                {
                    this.applicantSTDIDXIndicatorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDIsSurety")]
            public string ApplicantSTDIsSurety
            {
                get
                {
                    return this.applicantSTDIsSuretyField;
                }
                set
                {
                    this.applicantSTDIsSuretyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDMaintenanceIncome")]
            public string ApplicantSTDMaintenanceIncome
            {
                get
                {
                    return this.applicantSTDMaintenanceIncomeField;
                }
                set
                {
                    this.applicantSTDMaintenanceIncomeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDPostalSuburb")]
            public string ApplicantSTDPostalSuburb
            {
                get
                {
                    return this.applicantSTDPostalSuburbField;
                }
                set
                {
                    this.applicantSTDPostalSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDPostalSuburbCode")]
            public string ApplicantSTDPostalSuburbCode
            {
                get
                {
                    return this.applicantSTDPostalSuburbCodeField;
                }
                set
                {
                    this.applicantSTDPostalSuburbCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDRentalIncome")]
            public string ApplicantSTDRentalIncome
            {
                get
                {
                    return this.applicantSTDRentalIncomeField;
                }
                set
                {
                    this.applicantSTDRentalIncomeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDResidentialSuburb")]
            public string ApplicantSTDResidentialSuburb
            {
                get
                {
                    return this.applicantSTDResidentialSuburbField;
                }
                set
                {
                    this.applicantSTDResidentialSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDResidentialSuburbCode")]
            public string ApplicantSTDResidentialSuburbCode
            {
                get
                {
                    return this.applicantSTDResidentialSuburbCodeField;
                }
                set
                {
                    this.applicantSTDResidentialSuburbCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSelfEmployedProfessionalLevel")]
            public string ApplicantSTDSelfEmployedProfessionalLevel
            {
                get
                {
                    return this.applicantSTDSelfEmployedProfessionalLevelField;
                }
                set
                {
                    this.applicantSTDSelfEmployedProfessionalLevelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSellingExistingProperty")]
            public string ApplicantSTDSellingExistingProperty
            {
                get
                {
                    return this.applicantSTDSellingExistingPropertyField;
                }
                set
                {
                    this.applicantSTDSellingExistingPropertyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSmokerStatus")]
            public string ApplicantSTDSmokerStatus
            {
                get
                {
                    return this.applicantSTDSmokerStatusField;
                }
                set
                {
                    this.applicantSTDSmokerStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSourceOfIncomeAmount")]
            public string ApplicantSTDSourceOfIncomeAmount
            {
                get
                {
                    return this.applicantSTDSourceOfIncomeAmountField;
                }
                set
                {
                    this.applicantSTDSourceOfIncomeAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSourceOfIncomeAmount1")]
            public string ApplicantSTDSourceOfIncomeAmount1
            {
                get
                {
                    return this.applicantSTDSourceOfIncomeAmount1Field;
                }
                set
                {
                    this.applicantSTDSourceOfIncomeAmount1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSourceOfIncomeAmount2")]
            public string ApplicantSTDSourceOfIncomeAmount2
            {
                get
                {
                    return this.applicantSTDSourceOfIncomeAmount2Field;
                }
                set
                {
                    this.applicantSTDSourceOfIncomeAmount2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDTypeOfPermit")]
            public string ApplicantSTDTypeOfPermit
            {
                get
                {
                    return this.applicantSTDTypeOfPermitField;
                }
                set
                {
                    this.applicantSTDTypeOfPermitField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.BankAccounts")]
            public SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantBankAccounts ApplicantBankAccounts
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
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantBankAccounts
        {

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantBankAccountsApplicantBankAccount applicantBankAccountField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.BankAccount")]
            public SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantBankAccountsApplicantBankAccount ApplicantBankAccount
            {
                get
                {
                    return this.applicantBankAccountField;
                }
                set
                {
                    this.applicantBankAccountField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantBankAccountsApplicantBankAccount
        {

            private string applicantAccountBalanceField;

            private string applicantAccountInstitutionField;

            private string applicantAccountNameField;

            private string applicantAccountNumberField;

            private string applicantAccountTypeField;

            private string applicantIsMainAccountField;

            private string applicantSTDAccountBranchField;

            private string applicantSTDAccountBranchCodeField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDAccountBranch")]
            public string ApplicantSTDAccountBranch
            {
                get
                {
                    return this.applicantSTDAccountBranchField;
                }
                set
                {
                    this.applicantSTDAccountBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDAccountBranchCode")]
            public string ApplicantSTDAccountBranchCode
            {
                get
                {
                    return this.applicantSTDAccountBranchCodeField;
                }
                set
                {
                    this.applicantSTDAccountBranchCodeField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetails
        {

            private string applicantBankPackageField;

            private string applicantCellphoneField;

            private string applicantCompanyRegistrationNoField;

            private string applicantCorrespondenceLanguageField;

            private string applicantCountryOfBirthField;

            private string applicantCountryOfPermResidenceCodeField;

            private string applicantCurrentEmploymentStatusField;

            private string applicantCurrentMonthlyInstallmentField;

            private string applicantDateJoinedEmployerField;

            private string applicantDateOfBirthField;

            private string applicantDatePassportExpiresField;

            private string applicantDateRehabilitatedField;

            private string applicantDeclaredInsolventField;

            private string applicantEmailAddressField;

            private string applicantEmployeeNoField;

            private string applicantEmployerAddressField;

            private string applicantEmployerFaxCodeField;

            private string applicantEmployerFaxNoField;

            private string applicantEmployerNameField;

            private string applicantEmployerTelCodeField;

            private string applicantEmployerTelNoField;

            private string applicantEmploymentIndustryField;

            private string applicantEthnicGroupField;

            private string applicantFaxCodeField;

            private string applicantFaxNoField;

            private string applicantFirstNameField;

            private string applicantFrequencyOfSalaryPaymentsField;

            private string applicantGenderField;

            private string applicantHighestQualificationField;

            private string applicantHomePhoneField;

            private string applicantHomePhoneCodeField;

            private string applicantIdentificationNoField;

            private string applicantIdentificationTypeField;

            private string applicantIncomeMixField;

            private string applicantIncomeTaxNoField;

            private string applicantInitialsField;

            private string applicantIsUnderAdminOrderField;

            private string applicantIsUnderDebtReviewField;

            private string applicantMaritalStatusField;

            private string applicantMarriedStatusField;

            private string applicantMayBankContactYouField;

            private string applicantMayBankShareInfoField;

            private string applicantMayOthersContactYouField;

            private string applicantMaySubsidiariesContactYouField;

            private string applicantMayUseForResearchField;

            private string applicantNationalityField;

            private string applicantNoOfDependentsField;

            private string applicantOccupationField;

            private string applicantOccupationLevelField;

            private string applicantPassportNoField;

            private string applicantPermanentResidentField;

            private string applicantPermanentResidentCountryField;

            private string applicantPermitIssueDateField;

            private string applicantPermitNumberField;

            private string applicantPhysicalAddressLine1Field;

            private string applicantPhysicalAddressLine2Field;

            private string applicantPostalAddressCodeField;

            private string applicantPostalAddressLine1Field;

            private string applicantPostalAddressLine2Field;

            private string applicantPreviousEmployerNameField;

            private string applicantPreviousEmployerPeriodField;

            private string applicantRentingPropertyField;

            private string applicantRightOfRefusalConsentField;

            private string applicantSACitizenField;

            private string applicantSBSAIsAssociatedToOfficalField;

            private string applicantSBSAIsPublicOfficalField;

            private string applicantSBSANatureOfRelationshipField;

            private string applicantSBSAPOFirstNameField;

            private string applicantSBSAPOSurnameField;

            private string applicantShareHolderPercentageField;

            private string applicantSourceOfIncomeField;

            private string applicantSourceOfIncome1Field;

            private string applicantSourceOfIncome2Field;

            private string applicantSouthAfricanBankField;

            private string applicantSTDBondInstitutionField;

            private string applicantSTDCountryPassportIssuedIdField;

            private string applicantSTDDebitOrderResponsibleField;

            private string applicantSTDEmployerSuburbField;

            private string applicantSTDEmployerSuburbCodeField;

            private string applicantSTDEverCitixenField;

            private string applicantSTDIDXIndicatorField;

            private string applicantSTDIsSuretyField;

            private string applicantSTDMaintenanceIncomeField;

            private string applicantSTDPostalSuburbField;

            private string applicantSTDPostalSuburbCodeField;

            private string applicantSTDRentalIncomeField;

            private string applicantSTDResidentialSuburbField;

            private string applicantSTDResidentialSuburbCodeField;

            private string applicantSTDSelfEmployedProfessionalLevelField;

            private string applicantSTDSellingExistingPropertyField;

            private string applicantSTDSmokerStatusField;

            private string applicantSTDSourceOfIncomeAmountField;

            private string applicantSTDSourceOfIncomeAmount1Field;

            private string applicantSTDSourceOfIncomeAmount2Field;

            private string applicantSTDTypeOfPermitField;

            private string applicantSurnameField;

            private string applicantTempResidentField;

            private string applicantTempResidentPermitExpiryField;

            private string applicantTempResidentPermitNoField;

            private string applicantTitleField;

            private string applicantWorkPhoneField;

            private string applicantWorkPhoneCodeField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem[] applicantIncomeItemsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem[] applicantExpenditureItemsField;

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantBankAccounts applicantBankAccountsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.BankPackage")]
            public string ApplicantBankPackage
            {
                get
                {
                    return this.applicantBankPackageField;
                }
                set
                {
                    this.applicantBankPackageField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CompanyRegistrationNo")]
            public string ApplicantCompanyRegistrationNo
            {
                get
                {
                    return this.applicantCompanyRegistrationNoField;
                }
                set
                {
                    this.applicantCompanyRegistrationNoField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CountryOfPermResidenceCode")]
            public string ApplicantCountryOfPermResidenceCode
            {
                get
                {
                    return this.applicantCountryOfPermResidenceCodeField;
                }
                set
                {
                    this.applicantCountryOfPermResidenceCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CurrentEmploymentStatus")]
            public string ApplicantCurrentEmploymentStatus
            {
                get
                {
                    return this.applicantCurrentEmploymentStatusField;
                }
                set
                {
                    this.applicantCurrentEmploymentStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.CurrentMonthlyInstallment")]
            public string ApplicantCurrentMonthlyInstallment
            {
                get
                {
                    return this.applicantCurrentMonthlyInstallmentField;
                }
                set
                {
                    this.applicantCurrentMonthlyInstallmentField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployeeNo")]
            public string ApplicantEmployeeNo
            {
                get
                {
                    return this.applicantEmployeeNoField;
                }
                set
                {
                    this.applicantEmployeeNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerAddress")]
            public string ApplicantEmployerAddress
            {
                get
                {
                    return this.applicantEmployerAddressField;
                }
                set
                {
                    this.applicantEmployerAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerFaxCode")]
            public string ApplicantEmployerFaxCode
            {
                get
                {
                    return this.applicantEmployerFaxCodeField;
                }
                set
                {
                    this.applicantEmployerFaxCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.EmployerFaxNo")]
            public string ApplicantEmployerFaxNo
            {
                get
                {
                    return this.applicantEmployerFaxNoField;
                }
                set
                {
                    this.applicantEmployerFaxNoField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.FrequencyOfSalaryPayments")]
            public string ApplicantFrequencyOfSalaryPayments
            {
                get
                {
                    return this.applicantFrequencyOfSalaryPaymentsField;
                }
                set
                {
                    this.applicantFrequencyOfSalaryPaymentsField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.HighestQualification")]
            public string ApplicantHighestQualification
            {
                get
                {
                    return this.applicantHighestQualificationField;
                }
                set
                {
                    this.applicantHighestQualificationField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.IncomeMix")]
            public string ApplicantIncomeMix
            {
                get
                {
                    return this.applicantIncomeMixField;
                }
                set
                {
                    this.applicantIncomeMixField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.Initials")]
            public string ApplicantInitials
            {
                get
                {
                    return this.applicantInitialsField;
                }
                set
                {
                    this.applicantInitialsField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayBankShareInfo")]
            public string ApplicantMayBankShareInfo
            {
                get
                {
                    return this.applicantMayBankShareInfoField;
                }
                set
                {
                    this.applicantMayBankShareInfoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayOthersContactYou")]
            public string ApplicantMayOthersContactYou
            {
                get
                {
                    return this.applicantMayOthersContactYouField;
                }
                set
                {
                    this.applicantMayOthersContactYouField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.MayUseForResearch")]
            public string ApplicantMayUseForResearch
            {
                get
                {
                    return this.applicantMayUseForResearchField;
                }
                set
                {
                    this.applicantMayUseForResearchField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.PermitNumber")]
            public string ApplicantPermitNumber
            {
                get
                {
                    return this.applicantPermitNumberField;
                }
                set
                {
                    this.applicantPermitNumberField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.RentingProperty")]
            public string ApplicantRentingProperty
            {
                get
                {
                    return this.applicantRentingPropertyField;
                }
                set
                {
                    this.applicantRentingPropertyField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSAIsAssociatedToOffical")]
            public string ApplicantSBSAIsAssociatedToOffical
            {
                get
                {
                    return this.applicantSBSAIsAssociatedToOfficalField;
                }
                set
                {
                    this.applicantSBSAIsAssociatedToOfficalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSAIsPublicOffical")]
            public string ApplicantSBSAIsPublicOffical
            {
                get
                {
                    return this.applicantSBSAIsPublicOfficalField;
                }
                set
                {
                    this.applicantSBSAIsPublicOfficalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSANatureOfRelationship")]
            public string ApplicantSBSANatureOfRelationship
            {
                get
                {
                    return this.applicantSBSANatureOfRelationshipField;
                }
                set
                {
                    this.applicantSBSANatureOfRelationshipField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSAPOFirstName")]
            public string ApplicantSBSAPOFirstName
            {
                get
                {
                    return this.applicantSBSAPOFirstNameField;
                }
                set
                {
                    this.applicantSBSAPOFirstNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SBSAPOSurname")]
            public string ApplicantSBSAPOSurname
            {
                get
                {
                    return this.applicantSBSAPOSurnameField;
                }
                set
                {
                    this.applicantSBSAPOSurnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.ShareHolderPercentage")]
            public string ApplicantShareHolderPercentage
            {
                get
                {
                    return this.applicantShareHolderPercentageField;
                }
                set
                {
                    this.applicantShareHolderPercentageField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncome1")]
            public string ApplicantSourceOfIncome1
            {
                get
                {
                    return this.applicantSourceOfIncome1Field;
                }
                set
                {
                    this.applicantSourceOfIncome1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SourceOfIncome2")]
            public string ApplicantSourceOfIncome2
            {
                get
                {
                    return this.applicantSourceOfIncome2Field;
                }
                set
                {
                    this.applicantSourceOfIncome2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.SouthAfricanBank")]
            public string ApplicantSouthAfricanBank
            {
                get
                {
                    return this.applicantSouthAfricanBankField;
                }
                set
                {
                    this.applicantSouthAfricanBankField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDBondInstitution")]
            public string ApplicantSTDBondInstitution
            {
                get
                {
                    return this.applicantSTDBondInstitutionField;
                }
                set
                {
                    this.applicantSTDBondInstitutionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDCountryPassportIssuedId")]
            public string ApplicantSTDCountryPassportIssuedId
            {
                get
                {
                    return this.applicantSTDCountryPassportIssuedIdField;
                }
                set
                {
                    this.applicantSTDCountryPassportIssuedIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDDebitOrderResponsible")]
            public string ApplicantSTDDebitOrderResponsible
            {
                get
                {
                    return this.applicantSTDDebitOrderResponsibleField;
                }
                set
                {
                    this.applicantSTDDebitOrderResponsibleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDEmployerSuburb")]
            public string ApplicantSTDEmployerSuburb
            {
                get
                {
                    return this.applicantSTDEmployerSuburbField;
                }
                set
                {
                    this.applicantSTDEmployerSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDEmployerSuburbCode")]
            public string ApplicantSTDEmployerSuburbCode
            {
                get
                {
                    return this.applicantSTDEmployerSuburbCodeField;
                }
                set
                {
                    this.applicantSTDEmployerSuburbCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDEverCitixen")]
            public string ApplicantSTDEverCitixen
            {
                get
                {
                    return this.applicantSTDEverCitixenField;
                }
                set
                {
                    this.applicantSTDEverCitixenField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDIDXIndicator")]
            public string ApplicantSTDIDXIndicator
            {
                get
                {
                    return this.applicantSTDIDXIndicatorField;
                }
                set
                {
                    this.applicantSTDIDXIndicatorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDIsSurety")]
            public string ApplicantSTDIsSurety
            {
                get
                {
                    return this.applicantSTDIsSuretyField;
                }
                set
                {
                    this.applicantSTDIsSuretyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDMaintenanceIncome")]
            public string ApplicantSTDMaintenanceIncome
            {
                get
                {
                    return this.applicantSTDMaintenanceIncomeField;
                }
                set
                {
                    this.applicantSTDMaintenanceIncomeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDPostalSuburb")]
            public string ApplicantSTDPostalSuburb
            {
                get
                {
                    return this.applicantSTDPostalSuburbField;
                }
                set
                {
                    this.applicantSTDPostalSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDPostalSuburbCode")]
            public string ApplicantSTDPostalSuburbCode
            {
                get
                {
                    return this.applicantSTDPostalSuburbCodeField;
                }
                set
                {
                    this.applicantSTDPostalSuburbCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDRentalIncome")]
            public string ApplicantSTDRentalIncome
            {
                get
                {
                    return this.applicantSTDRentalIncomeField;
                }
                set
                {
                    this.applicantSTDRentalIncomeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDResidentialSuburb")]
            public string ApplicantSTDResidentialSuburb
            {
                get
                {
                    return this.applicantSTDResidentialSuburbField;
                }
                set
                {
                    this.applicantSTDResidentialSuburbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDResidentialSuburbCode")]
            public string ApplicantSTDResidentialSuburbCode
            {
                get
                {
                    return this.applicantSTDResidentialSuburbCodeField;
                }
                set
                {
                    this.applicantSTDResidentialSuburbCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSelfEmployedProfessionalLevel")]
            public string ApplicantSTDSelfEmployedProfessionalLevel
            {
                get
                {
                    return this.applicantSTDSelfEmployedProfessionalLevelField;
                }
                set
                {
                    this.applicantSTDSelfEmployedProfessionalLevelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSellingExistingProperty")]
            public string ApplicantSTDSellingExistingProperty
            {
                get
                {
                    return this.applicantSTDSellingExistingPropertyField;
                }
                set
                {
                    this.applicantSTDSellingExistingPropertyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSmokerStatus")]
            public string ApplicantSTDSmokerStatus
            {
                get
                {
                    return this.applicantSTDSmokerStatusField;
                }
                set
                {
                    this.applicantSTDSmokerStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSourceOfIncomeAmount")]
            public string ApplicantSTDSourceOfIncomeAmount
            {
                get
                {
                    return this.applicantSTDSourceOfIncomeAmountField;
                }
                set
                {
                    this.applicantSTDSourceOfIncomeAmountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSourceOfIncomeAmount1")]
            public string ApplicantSTDSourceOfIncomeAmount1
            {
                get
                {
                    return this.applicantSTDSourceOfIncomeAmount1Field;
                }
                set
                {
                    this.applicantSTDSourceOfIncomeAmount1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDSourceOfIncomeAmount2")]
            public string ApplicantSTDSourceOfIncomeAmount2
            {
                get
                {
                    return this.applicantSTDSourceOfIncomeAmount2Field;
                }
                set
                {
                    this.applicantSTDSourceOfIncomeAmount2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDTypeOfPermit")]
            public string ApplicantSTDTypeOfPermit
            {
                get
                {
                    return this.applicantSTDTypeOfPermitField;
                }
                set
                {
                    this.applicantSTDTypeOfPermitField = value;
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
            [System.Xml.Serialization.XmlElementAttribute("Applicant.BankAccounts")]
            public SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantBankAccounts ApplicantBankAccounts
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
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantBankAccounts
        {

            private SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantBankAccountsApplicantBankAccount applicantBankAccountField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.BankAccount")]
            public SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantBankAccountsApplicantBankAccount ApplicantBankAccount
            {
                get
                {
                    return this.applicantBankAccountField;
                }
                set
                {
                    this.applicantBankAccountField = value;
                }
            }
        }

        /// <remarks/>

        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SubmitApplicationRequestApplicationApplicantsCoApplicantDetailsApplicantSpouseDetailsApplicantBankAccountsApplicantBankAccount
        {

            private string applicantAccountBalanceField;

            private string applicantAccountInstitutionField;

            private string applicantAccountNameField;

            private string applicantAccountNumberField;

            private string applicantAccountTypeField;

            private string applicantIsMainAccountField;

            private string applicantSTDAccountBranchField;

            private string applicantSTDAccountBranchCodeField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDAccountBranch")]
            public string ApplicantSTDAccountBranch
            {
                get
                {
                    return this.applicantSTDAccountBranchField;
                }
                set
                {
                    this.applicantSTDAccountBranchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Applicant.STDAccountBranchCode")]
            public string ApplicantSTDAccountBranchCode
            {
                get
                {
                    return this.applicantSTDAccountBranchCodeField;
                }
                set
                {
                    this.applicantSTDAccountBranchCodeField = value;
                }
            }
        }
    }
}
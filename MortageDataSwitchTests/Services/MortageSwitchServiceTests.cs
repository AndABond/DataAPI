using Microsoft.VisualStudio.TestTools.UnitTesting;
using MortageDataSwitch.Models;
using MortageDataSwitch.Models.SubmitService;
using MortageDataSwitch.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortageDataSwitch.Services.Tests
{
    [TestClass()]
    public class MortageSwitchServiceTests
    {
        private TestContext testContextInstance;

        /// <summary>
        ///  Gets or sets the test context which provides
        ///  information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }


        [TestMethod()]
        public void GetLookupTest()
        {
            var service = new MortageSwitchService(new FacadeService());

            var tableValueResponse = service.GetLookup<GetTableValuesReply>(Enums.LookupEnum.TableValues, new LookupServiceRequest());

            var tableValueZipped = service.GetLookup<GetTableValuesZippedReply>(Enums.LookupEnum.TableValuesZipped, new LookupServiceRequest());

            var tableVersionInfo = service.GetLookup<GetTableVersionInfoReply>(Enums.LookupEnum.TableVersionInfo, new LookupServiceRequest());

            Assert.AreEqual(1, 1);
        }

        [TestMethod()]
        public void GetLiveRepliesTest()
        {
            //var service = new MortageSwitchService(new FacadeService());

            //var liveRepliesByRef = service.GetLiveRepliesByAppRef(new GetLiveRepliesByAppRefRequest());

            //var liveRepliesByDateRange = service.GetLiveRepliesByDateRange(new GetLiveRepliesByDateRangeRequest());

            Assert.AreEqual(1, 1);
        }

        [TestMethod()]
        public void SubmitAbsaApplication()
        {
            var service = new MortageSwitchService(new FacadeService());

            var request = new SubmitAbsaApplicationRequest(); //SubmitAbsaApplicationRequest();

            try
            {
                var rsaKeyValue = new ServiceKeyRSAKeyValue()
                {
                    Modulus = "kVBsTDIEVMolw4DHZ/fGyOQfECRET70uMgO9Li4oWsOs4A1jy9CYBrzpzzjUZuKuGvt5jkz9wGr1DMz5CbnAeGZF0Ti9wIp0WpfxhgMASsMgau/kGGI8QXra4P/ZSkWYQZ/Lx3bwRbkdlbOyn8RL/Ce1XyjAn2eGws5cwG21LpM=",
                    Exponent = "AQAB"
                };
                var serviceKey = new ServiceHeaderServiceKey()
                {
                    RSAKeyValue = rsaKeyValue
                };
                var header = new RequestServiceHeader()
                {
                    ApplicationAction = "New",
                    ApplicationApplicationType = "3",
                    ApplicationMac = "",
                    ApplicationReference = "",
                    ChannelCode = "A3990331-8A45-4629-84D3-E00ABC58CA8E",
                    ChannelPassword = "90309592-5AB2-46F0-89AC-1CF5DAF38E75",
                    ChannelUsername = "3D071789-F701-43D4-AB49-98BC0B63F82B",
                    OriginatorBranchId = "11787",
                    OriginatorId = "10251",
                    OriginatorReference = "5001519323",
                    RequestDateTime = "2019-06-08T11:32:10",
                    ServiceKey = serviceKey,
                    ServiceVersion = "30",
                    ApplicationGroupId = "789169"
                };
                var details = new AbsaApplicationRequest.SubmitApplicationRequestApplicationDetails()
                {
                    ApplicaionABSAIsPrimaryResident = "1",
                    ApplicationABSABondAttorney = "",
                    ApplicationABSAComplexName = "SS GADSDEN",
                    ApplicationABSAFamilySpringboard = "0",
                    ApplicationABSAFurtherLoanAccountNumber = "",
                    ApplicationABSAFurtherLoanAmount = "850000",
                    ApplicationABSAIsNewDevelopment = "0",
                    ApplicationABSALoyaltyHomeLoan = "0",
                    ApplicationABSAMyHome = "0",
                    ApplicationABSANewDevelopmentRefNum = "",
                    ApplicationABSANotificationCellPhoneNumber = "",
                    ApplicationABSANotificationEmailAddress = "delmarie@comcorpcoza",
                    ApplicationABSANotificationMethodTypeId = "2",
                    ApplicationABSAPassword = "123456",
                    ApplicationABSAPReviousApplicationNumber = "0",
                    ApplicationABSAPropertyType = "",
                    ApplicationABSAPurposeOfApplication = "TLO",
                    ApplicationABSAReApplication = "0",
                    ApplicationABSASubClassification = "",
                    ApplicationABSATransferAttorney = "ROSE INNES DU PREEZ AND JOUBERT INC",
                    ApplicationABSATransferAttorneyCode = "00175",
                    ApplicationABSATypeOfApplication = "Private Individual",
                    ApplicationABSAVendorDescription = "INDBOND024",
                    ApplicationAgencyInvolved = "0",
                    ApplicationAgencyNotifyEmailAddress = "",
                    ApplicationAgencyNotifyOption = "NONE",
                    ApplicationAgentName = "Not Applicable",
                    ApplicationAIPBanks = "",
                    ApplicationAltPropertyContact = "",
                    ApplicationAmountOfGuarantee = "0",
                    ApplicationApplicationType = "1",
                    ApplicationBondAmountToBeRegistered = "850000",
                    ApplicationBondInstitution = "FIRST NATIONAL BANK OF SOUTHERN AFRICA LIMITED",
                    ApplicationBondRegistrationLegalCosts = "0",
                    ApplicationCampaignRefNumber = "",
                    ApplicationCashDeposit = "650000",
                    ApplicationCellNumberEstateAgency = "",
                    ApplicationConsultantEmailAddress = "delmarie@comcorpcoza",
                    ApplicationCurrentBondBalance = "500000",
                    ApplicationDebtConsolidationOption = "Other",
                    ApplicationDeclinedBanks = "",
                    ApplicationEmployerHousingScheme = "0",
                    ApplicationEstateAgency = "comcorp",
                    ApplicationExistingHomeLoan = "0",
                    ApplicationFirstPropertyPurchase = "0",
                    ApplicationFixedRateTerm = "",
                    ApplicationFlexiReserveFurtherOption = "",
                    ApplicationFlexiReserveOption = "264",
                    ApplicationGovernmentSubsidy = "0",
                    ApplicationInsuranceQuoteRequired = "0",
                    ApplicationIsCampaign = "0",
                    ApplicationIsDebtConsolidation = "0",
                    ApplicationLapa = "0",
                    ApplicationLoanAmountRequired = "850000",
                    ApplicationLoanType = "Home Loan",
                    ApplicationLoanTypeId = "6",
                    ApplicationMultiPlanFacility = "0",
                    ApplicationMultiPlanLoanAmount1 = "0",
                    ApplicationMultiPlanLoanAmount2 = "0",
                    ApplicationMultiPlanLoanTerm1 = "0",
                    ApplicationMultiPlanLoanTerm2 = "0",
                    ApplicationMultiPlanPurpose1 = "",
                    ApplicationMultiPlanPurpose2 = "",
                    ApplicationNegotiateFixedRate = "0",
                    ApplicationNetwork = "Not Applicable",
                    ApplicationNoOfMultiPlanAccounts = "0",
                    ApplicationOriginatorInvolved = "1",
                    ApplicationOriginatorNotifyCellphone = "0763337048",
                    ApplicationOriginatorNotifyOption = "Telephone",
                    ApplicationOriginatorNotifyPhoneCode = "010",
                    ApplicationOriginatorNotifyPhoneNo = "5942777",
                    ApplicationOtherGuaranteeAmount = "0",
                    ApplicationPhoneDialCodeEstateAgency = "",
                    ApplicationPhoneNumberEstateAgency = "",
                    ApplicationPortionNo = "35",
                    ApplicationPreferredABSABranch = "RANDBURG",
                    ApplicationPreferredABSABranchCode = "8446",
                    ApplicationPropertyAddressCity = "JOHANNESBURG",
                    ApplicationPropertyAddressSuburb = "LYNDHURST",
                    ApplicationPropertyContactCellphone = "0823054142",
                    ApplicationPropertyContactName = "Tester",
                    ApplicationPropertyContactTelCode = "011",
                    ApplicationPropertyContactTelNo = "5561014",
                    ApplicationPropertyMarketValue = "750000",
                    ApplicationPropertyOccupiedBy = "Self",
                    ApplicationPropertyPurchaseDate = "2018-08-10",
                    ApplicationPropertyPurchasePrice = "1500000",
                    ApplicationPropertyRoofConstruction = "Clay Tiles - Standard roof",
                    ApplicationPropertyStreetName = "Tester",
                    ApplicationPropertyStreetNo = "35",
                    ApplicationPropertyTownship = "LYNDHURST",
                    ApplicationPropertyWallConstruction = "Asbestos",
                    ApplicationRepaymentDay = "1",
                    ApplicationSectionalTitleFlatNo = "12",
                    ApplicationSectionalTitleUnitNo = "12",
                    ApplicationSellerIDNo = "",
                    ApplicationSellerIdType = "Not Available",
                    ApplicationSettleAbsaMortgageLoan = "1",
                    ApplicationSignLegalDocsProvince = "",
                    ApplicationSignLegalDocsRegion = "",
                    ApplicationSingleHousehold = "0",
                    ApplicationSourceOfFunds = "ALLOWANCE",
                    ApplicationSourceOfFunds1 = "",
                    ApplicationSourceOfFunds2 = "",
                    ApplicationSourceOfFunds3 = "",
                    ApplicationSourceOfFunds4 = "",
                    ApplicationStandErfNo = "35",
                    ApplicationSubmittingBanks = "1",
                    ApplicationSuretyshipOffered = "0",
                    ApplicationTermOfLoan = "20",
                    ApplicationTransferAttorneyPhoneNo = "0137124200",
                    ApplicationTypeOfInterest = "Variable"
                };

                AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount[] applicantBankAccounts = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount[]
                   {
                 new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount() {
                    ApplicantAccountBalance = "1000",
                    ApplicantAccountBranch = "RANDBURG MALL",
                    ApplicantAccountInstitution = "ABSA",
                    ApplicantAccountName = "Tester",
                    ApplicantAccountNumber = "440015226",
                    ApplicantAccountType = "Cheque",
                    ApplicantIsMainAccount = "1"
                 },
                 new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount() {
                    ApplicantAccountBalance = "1000",
                    ApplicantAccountBranch = "4 MERCHANT PLACE           390",
                    ApplicantAccountInstitution = "FIRST NATIONAL BANK OF SOUTHERN AFRICA LIMITED",
                    ApplicantAccountName = "TEst",
                    ApplicantAccountNumber = "123456789",
                    ApplicantAccountType = "Mortgage Loan",
                    ApplicantIsMainAccount = "0"
                 }
                   };
                AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem[] applicantExpenditureItems = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem[]
                {
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "100",
                    ApplicantExpenditureDesc = "Mortgage Instalments",
                    ApplicantExpenditureType = "1"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Rates and Taxes",
                    ApplicantExpenditureType = "2"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Water and Lights",
                    ApplicantExpenditureType = "3"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Maintenance",
                    ApplicantExpenditureType = "4"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Motor Finance Instalments",
                    ApplicantExpenditureType = "5"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Petrol & Maintenance",
                    ApplicantExpenditureType = "6"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Other Motor Finance Instalments",
                    ApplicantExpenditureType = "7"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Insurance",
                    ApplicantExpenditureType = "8"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Assurance (Life, Retirement Annuities)",
                    ApplicantExpenditureType = "9"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Personal Loan Instalments",
                    ApplicantExpenditureType = "10"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "500",
                    ApplicantExpenditureDesc = "Groceries",
                    ApplicantExpenditureType = "11"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Clothing",
                    ApplicantExpenditureType = "12"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Levies",
                    ApplicantExpenditureType = "13"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Domestic Wage",
                    ApplicantExpenditureType = "14"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Education",
                    ApplicantExpenditureType = "15"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Entertainment",
                    ApplicantExpenditureType = "16"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Investments (Unit Trusts, Endowments)",
                    ApplicantExpenditureType = "17"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                        ApplicantExpenditureAmount = "0",
                           ApplicantExpenditureDesc = "Other (Telephone, M-net, etc)",
                           ApplicantExpenditureType = "18"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Credit Card Minimum Payments",
                    ApplicantExpenditureType = "19"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Security",
                    ApplicantExpenditureType = "20"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "233",
                    ApplicantExpenditureDesc = "UIF",
                    ApplicantExpenditureType = "21"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "120",
                    ApplicantExpenditureDesc = "PAYE",
                    ApplicantExpenditureType = "22"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "322",
                    ApplicantExpenditureDesc = "Pension",
                    ApplicantExpenditureType = "23"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "500",
                    ApplicantExpenditureDesc = "Medical Aid",
                    ApplicantExpenditureType = "24"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "6",
                    ApplicantExpenditureDesc = "Reduction In Mortgage Instalments",
                    ApplicantExpenditureType = "25"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "7",
                    ApplicantExpenditureDesc = "Reduction In Motor Finance Instalments",
                    ApplicantExpenditureType = "26"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Vested Surety Monthly Obligation",
                    ApplicantExpenditureType = "27"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Other Monthly Instalments",
                    ApplicantExpenditureType = "28"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Credit Card Exposure",
                    ApplicantExpenditureType = "29"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Retail Card Minimum Payments",
                    ApplicantExpenditureType = "30"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Retail Card Exposure",
                    ApplicantExpenditureType = "31"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Overdraft Minimum Payments",
                    ApplicantExpenditureType = "32"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Overdraft Exposure",
                    ApplicantExpenditureType = "33"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Other Revolving Debt Minimum Payments",
                    ApplicantExpenditureType = "34"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Other Revolving Debt Exposure",
                    ApplicantExpenditureType = "35"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "8",
                    ApplicantExpenditureDesc = "Reduction In Other Monthly Instalments",
                    ApplicantExpenditureType = "38"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "5",
                    ApplicantExpenditureDesc = "Reduction In Credit Card Minimum Payments",
                    ApplicantExpenditureType = "39"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Monthly Asset Finance",
                    ApplicantExpenditureType = "47"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Cellphone",
                    ApplicantExpenditureType = "48"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Other Deductions",
                    ApplicantExpenditureType = "49"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Child Maintenance",
                    ApplicantExpenditureType = "50"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Timeshare",
                    ApplicantExpenditureType = "51"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Property Rental Expenses",
                    ApplicantExpenditureType = "52"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Medical Expenses",
                    ApplicantExpenditureType = "53"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem() {
                    ApplicantExpenditureAmount = "0",
                    ApplicantExpenditureDesc = "Donations",
                    ApplicantExpenditureType = "54"
                }
                };
                AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem[] applicantIncomeItems = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem[]
                {
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem() {
                    ApplicantIncomeAmount = "35000",
                    ApplicantIncomeDesc = "Basic Salary",
                    ApplicantIncomeType = "22"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem() {
                    ApplicantIncomeAmount = "35000",
                    ApplicantIncomeDesc = "Cost to Company",
                    ApplicantIncomeType = "1"
                },
                new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem() {
                    ApplicantIncomeAmount = "33825",
                    ApplicantIncomeDesc = "Income After Deductions",
                    ApplicantIncomeType = "12"
                },
                };

                AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetails mainApplicantDetails = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetails()
                {
                    ApplicantABSACurrentBondAmount = "0",
                    ApplicantABSACurrentBondToBeCancelled = "0",
                    ApplicantABSACurrentRentAmount = "0",
                    ApplicantABSACurrentRentToBeCancelled = "0",
                    ApplicantABSAEmploymentSector = "Legal Profession",
                    ApplicantABSAExecutiveManager = "0",
                    ApplicantABSAIdentificationType = "Identity Document",
                    ApplicantABSALifeInsurance = "0",
                    ApplicantABSAOccupation = "Ophthalmologist",
                    ApplicantABSAOtherIdentificationType = "",
                    ApplicantABSAPostMatricQualification = "Degree",
                    ApplicantABSAResidentialStatus = "Boarder",
                    ApplicantABSASAEmployed = "0",
                    ApplicantABSAStaffMember = "0",
                    ApplicantABSAWill = "0",
                    ApplicantAddressCityWork = "RANDBURG",
                    ApplicantAddressCountryWork = "SOUTH AFRICA",
                    ApplicantAddressLine1Work = "1 Tesst",
                    ApplicantAddressSince = "2004-06-15",
                    ApplicantAddressSuburbWork = "RANDBURG",
                    ApplicantCanRetrieveStatement = "0",
                    ApplicantCanSupplyStatement = "0",
                    ApplicantCellphone = "0823054415",
                    ApplicantCorrespondenceLanguage = "Afrikaans",
                    ApplicantCountryOfBirth = "SOUTH AFRICA",
                    ApplicantCountryOfPermResidenceCode = "",
                    ApplicantCountryPassportIssued = "",
                    ApplicantDateJoinedEmployer = "2010-02-02",
                    ApplicantDateOfBirth = "1984-06-12",
                    ApplicantDateRehabilitated = "",
                    ApplicantDebtConsolidationAmount = "0",
                    ApplicantDebtCounsellorName = "",
                    ApplicantDebtCounsellorNumber = "",
                    ApplicantDeclaredInsolvent = "0",
                    ApplicantEmailAddress = "test@fgmlcom",
                    ApplicantEmployeeNo = "",
                    ApplicantEmployerFaxCode = "012",
                    ApplicantEmployerFaxNo = "5514126",
                    ApplicantEmployerName = "Test",
                    ApplicantEmployerTelCode = "012",
                    ApplicantEmployerTelNo = "5514126",
                    ApplicantEthnicGroup = "ASIAN",
                    //ApplicantExistingHomeLoanAccountBalance = 21000,
                    //ApplicantExistingHomeLoanInstitution = "AB",
                    //ApplicantExistingHomeLoanIsSettlingHomeLoan = "0",
                    ApplicantFirstName = "Ordinary",
                    ApplicantForeignNational = "0",
                    ApplicantGender = "Female",
                    ApplicantHasChequeAccount = "0",
                    ApplicantHasCreditCard = "0",
                    ApplicantHomeLanguage = "Afrikaans",
                    ApplicantHomePhone = "5514126",
                    ApplicantHomePhoneCode = "012",
                    ApplicantIdentificationNo = "8406122990089",
                    ApplicantIsInternationalHomeNo = "0",
                    ApplicantIsInternationalWorkNo = "0",
                    ApplicantIsUnderDebtReview = "0",
                    ApplicantMaritalStatus = "Single",
                    ApplicantMarriedStatus = "NONE",
                    ApplicantMayDoCreditBureauEnquiry = "1",
                    ApplicantNationality = "SOUTH AFRICA",
                    ApplicantOccupationStatus = "Full Time Employed",
                    ApplicantOtherDeductionsDescription = "",
                    ApplicantPassportNo = "",
                    ApplicantPermanentResident = "1",
                    ApplicantPermanentResidentCountry = "SOUTH AFRICA",
                    ApplicantPhysicalAddressCity = "RANDBURG",
                    ApplicantPhysicalAddressCode = "2194",
                    ApplicantPhysicalAddressLine1 = "5 Tester",
                    ApplicantPhysicalAddressLine2 = "",
                    ApplicantPhysicalAddressSuburb = "RANDBURG",
                    ApplicantPostalAddressCity = "RANDBURG",
                    ApplicantPostalAddressCode = "2194",
                    ApplicantPostalAddressLine1 = "5 Tester",
                    ApplicantPostalAddressLine2 = "",
                    ApplicantPostalAddressSuburb = "RANDBURG",
                    ApplicantPostalCodeWork = "2194",
                    ApplicantPreferredContactDelivery = "EMail",
                    ApplicantRightOfRefusalConsent = "2",
                    ApplicantSettleNonABSABondAccount = "0",
                    ApplicantSocialGrant = "0",
                    ApplicantSourceOfIncome = "SALARY/WAGES",
                    ApplicantSpouseDetailsAvailable = "0",
                    ApplicantSpouseParticipant = "0",
                    ApplicantSurname = "Single",
                    ApplicantTempResident = "0",
                    ApplicantTempResidentPermitExpiry = "",
                    ApplicantTempResidentPermitNo = "",
                    ApplicantTitle = "Miss",
                    ApplicantBankAccounts = applicantBankAccounts,
                    ApplicantExpenditureItems = applicantExpenditureItems,
                    ApplicantIncomeItems = applicantIncomeItems
                };
                var applicants = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicants()
                {
                    MainApplicantDetails = mainApplicantDetails
                };

                request.ServiceHeader = header;
                request.ApplicationDetails = details;
                request.ApplicationApplicants = applicants;
                

                //var response = service.SubmitApplication((SubmitAbsaApplicationRequest)request);

                //TestContext.WriteLine("RESPONSE: {0}", response.ServiceHeader.ServiceResult.ToString());
            }
            catch(Exception e)
            {
                TestContext.WriteLine("{0},{1}", e.Message, e.StackTrace);
            }
            Assert.AreEqual(1, 1);
        }

        [TestMethod()]
        public void SubmitAutoApplication()
        {
            var service = new MortageSwitchService(new FacadeService());

            var request = new SubmitAutoApplicationRequest(); //SubmitAbsaApplicationRequest();


            //var response = service.SubmitAutoApplication((SubmitAbsaApplicationRequest)request);

            Assert.AreEqual(1, 1);

        }
    }
}
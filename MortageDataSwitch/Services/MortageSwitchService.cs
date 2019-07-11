using MortageDataSwitch.Enums;
using MortageDataSwitch.Interface;
using MortageDataSwitch.Models;
using MortageDataSwitch.Models.SubmitService;
using MortageDataSwitch.StaticModels;
using MortageDataSwitch.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MortageDataSwitch.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class MortageSwitchService : IMortageSwitchService
    {
        private readonly IFacadeService _facadeService;

        /// <summary>
        /// Main service to expose facades
        /// </summary>
        /// <param name="facadeService"></param>
        public MortageSwitchService(IFacadeService facadeService)
        {
            _facadeService = facadeService;
        }

        /// <summary>
        /// GetTableValues - Returns GetTableValuesReply
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lookup"></param>
        /// <returns></returns>
        public T GetLookup<T>(LookupEnum lookup, LookupServiceRequest lookupRequest)
        {
            switch(lookup)
            {
                case LookupEnum.TableValues:
                    return (T)Convert.ChangeType(_facadeService.GetTableValues(lookupRequest), typeof(T));
                case LookupEnum.TableValuesZipped:
                    return (T)Convert.ChangeType(_facadeService.GetTableValuesZipped(lookupRequest), typeof(T));
                case LookupEnum.TableVersionInfo:
                    return (T)Convert.ChangeType(_facadeService.GetTableVersionInfo(lookupRequest), typeof(T));
            }

            return (T)Convert.ChangeType("", typeof(T));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestXml"></param>
        /// <returns></returns>
        //public GetLiveRepliesAppRefReply GetLiveRepliesByAppRef(GetLiveRepliesByAppRefRequest request)
        //{
        //    return _facadeService.GetLiveRepliesByAppRef(request);
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetLiveRepliesByDateRangeReply GetLiveRepliesByDateRange(GetLiveRepliesByDateRangeRequest request)
        {
            return _facadeService.GetLiveRepliesByDateRange(request);
        }

        /// <summary>
        /// Service to submit application
        /// </summary>
        /// <param name="applicationRequest"></param>
        /// <returns></returns>
        public SubmitServiceReply SubmitApplication(SubmitIncomingApplicationRequest applicationRequest)
        {
            var bank = SchemaManager.GetBankSchemas().Where(a => (a.ApplicationType == Convert.ToInt32(applicationRequest.ServiceHeader.ApplicationApplicationType))).Select(a => a.Bank).FirstOrDefault();

            SubmitApplicationRequest request = null;
            if (bank.Equals("ABSA"))
            {
                return _facadeService.SubmitApplication((SubmitAbsaApplicationRequest)applicationRequest);
            }
            if (bank.Equals("FNB"))
            {
                return _facadeService.SubmitApplication((SubmitFnbApplicationRequest)applicationRequest);
            }
            if (bank.Equals("NED"))
            {
                return _facadeService.SubmitApplication((SubmitNedApplicationRequest)applicationRequest);
            }
            if (bank.Equals("STD"))
            {
                return _facadeService.SubmitApplication((SubmitSbsaApplicationRequest)applicationRequest);
            }

            return _facadeService.SubmitApplication(request);
        }

        public SubmitAutoApplicationResponse SubmitAutoApplication(SubmitAutoApplicationRequest applicationRequest)
        {
            var response = new SubmitAutoApplicationResponse();

            var serviceHeader = new RequestServiceHeader();
            serviceHeader.ChannelCode = WebConfigurationManager.AppSettings["ChannelCode"];
            serviceHeader.ChannelPassword = WebConfigurationManager.AppSettings["ChannelPassword"];
            serviceHeader.ChannelUsername = WebConfigurationManager.AppSettings["ChannelUsername"];
            serviceHeader.OriginatorBranchId = WebConfigurationManager.AppSettings["OriginatorBranchId"];
            serviceHeader.OriginatorId = WebConfigurationManager.AppSettings["OriginatorId"];
            serviceHeader.ServiceKey = new ServiceHeaderServiceKey();
            serviceHeader.ServiceKey.RSAKeyValue = new ServiceKeyRSAKeyValue();
            serviceHeader.ServiceKey.RSAKeyValue.Modulus = WebConfigurationManager.AppSettings["Modulus"];
            serviceHeader.ServiceKey.RSAKeyValue.Exponent = WebConfigurationManager.AppSettings["Exponent"];
            serviceHeader.RequestDateTime = TimeUtils.GetRSATime().ToString();
            serviceHeader.ApplicationMac = "";
            serviceHeader.ApplicationReference = "";

            try
            {

                var absaRequest = GenerateAbsaRequest(serviceHeader, applicationRequest);
                response.Absa = _facadeService.SubmitApplication(absaRequest);

            }
            catch (Exception epx)
            {
                response.Absa = new SubmitServiceReply
                {
                    StatusMessage = epx.Message
                };
            }
            try
            {
                var fnbRequest = GenerateFnbRequest(serviceHeader, applicationRequest);
                response.Fnb = _facadeService.SubmitApplication(fnbRequest);
            }
            catch (Exception epx)
            {
                response.Fnb = new SubmitServiceReply
                {
                    StatusMessage = epx.Message
                };
            }
            try
            {
                var nedRequest = GenerateNedRequest(serviceHeader, applicationRequest);
                response.Nedbank = _facadeService.SubmitApplication(nedRequest);
            }
            catch (Exception epx)
            {
                response.Nedbank = new SubmitServiceReply
                {
                    StatusMessage = epx.Message
                };
            }
            try
            {
                var stdRequest = GenerateStdRequest(serviceHeader, applicationRequest);
                response.Sbsa = _facadeService.SubmitApplication(stdRequest);
            }
            catch (Exception epx)
            {
                response.Sbsa = new SubmitServiceReply
                {
                    StatusMessage = epx.Message
                };
            }


            return response;
        }

        private SubmitAbsaApplicationRequest GenerateAbsaRequest(RequestServiceHeader serviceHeader, SubmitAutoApplicationRequest applicationRequest)
        {
            if(applicationRequest.ApplicationType == ApplicationType.Single)
            {
                serviceHeader.ApplicationApplicationType = "3";
            }
            if (applicationRequest.ApplicationType == ApplicationType.Joint)
            {
                serviceHeader.ApplicationApplicationType = "27";
            }
            serviceHeader.ApplicationAction = "New";
            serviceHeader.ServiceVersion = "30";
            serviceHeader.ApplicationGroupId = "Andabond";
            serviceHeader.OriginatorReference = Utils.GenerateOriginatorReference();

            var absaRequest = new SubmitAbsaApplicationRequest();
            absaRequest.ServiceHeader = serviceHeader;

            //ApplicationDetails
            absaRequest.ApplicationDetails = new Models.SubmitService.AbsaApplicationRequest.SubmitApplicationRequestApplicationDetails();
            ObjectMappingTools.TransferObject(applicationRequest.ApplicationDetails.Absa, absaRequest.ApplicationDetails);
            ObjectMappingTools.TransferObject(applicationRequest.ApplicationDetails.Common, absaRequest.ApplicationDetails);

            //ApplicationApplicants
            absaRequest.ApplicationApplicants = new Models.SubmitService.AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicants();
            absaRequest.ApplicationApplicants.MainApplicantDetails = new Models.SubmitService.AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetails();
            ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Absa, absaRequest.ApplicationApplicants.MainApplicantDetails);
            ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common, absaRequest.ApplicationApplicants.MainApplicantDetails);

            if (applicationRequest.ApplicationApplicants.MainApplicantDetails.SpouseDetails != null)
            {
                absaRequest.ApplicationApplicants.MainApplicantDetails.ApplicantSpouseDetails = CopyAbsaSpouseDetails(applicationRequest.ApplicationApplicants.MainApplicantDetails.SpouseDetails);
                
            }

            // Copy over array items
            if(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts != null)
            {
                absaRequest.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount[applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts.Count];
                for (int i = 0; i < applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts.Count; ++i)
                {
                    absaRequest.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i] = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount();
                    ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts[i], absaRequest.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i]);
                }

            }

            if (applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantExpenditureItems != null)
            {
                absaRequest.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem[applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantExpenditureItems.Count];
                for (int i = 0; i < applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantExpenditureItems.Count; ++i)
                {
                    absaRequest.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i] = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem();
                    ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantExpenditureItems[i], absaRequest.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i]);
                }

            }

            if (applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantIncomeItems != null)
            {
                absaRequest.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem[applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantIncomeItems.Count];
                for (int i = 0; i < applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantIncomeItems.Count; ++i)
                {
                    absaRequest.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i] = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem();
                    ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantIncomeItems[i], absaRequest.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i]);
                }

            }

            return absaRequest;
        }

        private AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetails CopyAbsaSpouseDetails(ApplicantDetails spouseDetails)
        {
            var spouse = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetails();
            ObjectMappingTools.TransferObject(spouseDetails.Absa, spouse);
            ObjectMappingTools.TransferObject(spouseDetails.Common, spouse);

            if (spouseDetails.Common.ApplicantBankAccounts != null)
            {
                spouse.ApplicantBankAccounts = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantBankAccount[spouseDetails.Common.ApplicantBankAccounts.Count];
                for (int i = 0; i < spouseDetails.Common.ApplicantBankAccounts.Count; ++i)
                {
                    spouse.ApplicantBankAccounts[i] = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantBankAccount();
                    ObjectMappingTools.TransferObject(spouseDetails.Common.ApplicantBankAccounts[i], spouse.ApplicantBankAccounts[i]);
                }

            }

            if (spouseDetails.Common.ApplicantExpenditureItems != null)
            {
                spouse.ApplicantExpenditureItems = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem[spouseDetails.Common.ApplicantExpenditureItems.Count];
                for (int i = 0; i < spouseDetails.Common.ApplicantExpenditureItems.Count; ++i)
                {
                    spouse.ApplicantExpenditureItems[i] = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem();
                    ObjectMappingTools.TransferObject(spouseDetails.Common.ApplicantExpenditureItems[i], spouse.ApplicantExpenditureItems[i]);
                }

            }

            if (spouseDetails.Common.ApplicantIncomeItems != null)
            {
                spouse.ApplicantIncomeItems = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem[spouseDetails.Common.ApplicantIncomeItems.Count];
                for (int i = 0; i < spouseDetails.Common.ApplicantIncomeItems.Count; ++i)
                {
                    spouse.ApplicantIncomeItems[i] = new AbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem();
                    ObjectMappingTools.TransferObject(spouseDetails.Common.ApplicantIncomeItems[i], spouse.ApplicantIncomeItems[i]);
                }

            }

            return spouse;
        }

        private SubmitFnbApplicationRequest GenerateFnbRequest(RequestServiceHeader serviceHeader, SubmitAutoApplicationRequest applicationRequest)
        {
            if (applicationRequest.ApplicationType == ApplicationType.Single)
            {
                serviceHeader.ApplicationApplicationType = "7";
            }
            if (applicationRequest.ApplicationType == ApplicationType.Joint)
            {
                serviceHeader.ApplicationApplicationType = "31";
            }
            serviceHeader.ApplicationAction = "New";
            serviceHeader.ServiceVersion = "30";
            serviceHeader.ApplicationGroupId = "Andabond";
            serviceHeader.OriginatorReference = Utils.GenerateOriginatorReference();

            var fnbRequest = new SubmitFnbApplicationRequest();
            fnbRequest.ServiceHeader = serviceHeader;

            //ApplicationDetails
            fnbRequest.ApplicationDetails = new Models.SubmitService.FnbApplicationRequest.SubmitApplicationRequestApplicationDetails();
            ObjectMappingTools.TransferObject(applicationRequest.ApplicationDetails.Fnb, fnbRequest.ApplicationDetails);
            ObjectMappingTools.TransferObject(applicationRequest.ApplicationDetails.Common, fnbRequest.ApplicationDetails);

            //ApplicationApplicants
            fnbRequest.ApplicationApplicants = new Models.SubmitService.FnbApplicationRequest.SubmitApplicationRequestApplicationApplicants();
            fnbRequest.ApplicationApplicants.MainApplicantDetails = new Models.SubmitService.FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetails();
            ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Fnb, fnbRequest.ApplicationApplicants.MainApplicantDetails);
            ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common, fnbRequest.ApplicationApplicants.MainApplicantDetails);

            if (applicationRequest.ApplicationType == ApplicationType.Joint)
            {
                if (applicationRequest.ApplicationApplicants.MainApplicantDetails.SpouseDetails != null)
                {
                    fnbRequest.ApplicationApplicants.MainApplicantDetails.ApplicantSpouseDetails = CopyFnbSpouseDetails(applicationRequest.ApplicationApplicants.MainApplicantDetails.SpouseDetails);
                    
                }
            }
            // Copy over array items
            if (applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts != null)
            {
                fnbRequest.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount[applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts.Count];
                for (int i = 0; i < applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts.Count; ++i)
                {
                    fnbRequest.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i] = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount();
                    ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts[i], fnbRequest.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i]);
                }

            }

            if (applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantExpenditureItems != null)
            {
                fnbRequest.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem[applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantExpenditureItems.Count];
                for (int i = 0; i < applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantExpenditureItems.Count; ++i)
                {
                    fnbRequest.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i] = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem();
                    ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantExpenditureItems[i], fnbRequest.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i]);
                }

            }

            if (applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantIncomeItems != null)
            {
                fnbRequest.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem[applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantIncomeItems.Count];
                for (int i = 0; i < applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantIncomeItems.Count; ++i)
                {
                    fnbRequest.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i] = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem();
                    ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantIncomeItems[i], fnbRequest.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i]);
                }

            }
            return fnbRequest;
        }

        private FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetails CopyFnbSpouseDetails(ApplicantDetails spouseDetails)
        {
            var spouse = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetails();
            ObjectMappingTools.TransferObject(spouseDetails.Fnb, spouse);
            ObjectMappingTools.TransferObject(spouseDetails.Common, spouse);

            if (spouseDetails.Common.ApplicantBankAccounts != null)
            {
                spouse.ApplicantBankAccounts = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantBankAccount[spouseDetails.Common.ApplicantBankAccounts.Count];
                for (int i = 0; i < spouseDetails.Common.ApplicantBankAccounts.Count; ++i)
                {
                    spouse.ApplicantBankAccounts[i] = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantBankAccount();
                    ObjectMappingTools.TransferObject(spouseDetails.Common.ApplicantBankAccounts[i], spouse.ApplicantBankAccounts[i]);
                }

            }

            if (spouseDetails.Common.ApplicantExpenditureItems != null)
            {
                spouse.ApplicantExpenditureItems = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem[spouseDetails.Common.ApplicantExpenditureItems.Count];
                for (int i = 0; i < spouseDetails.Common.ApplicantExpenditureItems.Count; ++i)
                {
                    spouse.ApplicantExpenditureItems[i] = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem();
                    ObjectMappingTools.TransferObject(spouseDetails.Common.ApplicantExpenditureItems[i], spouse.ApplicantExpenditureItems[i]);
                }

            }

            if (spouseDetails.Common.ApplicantIncomeItems != null)
            {
                spouse.ApplicantIncomeItems = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem[spouseDetails.Common.ApplicantIncomeItems.Count];
                for (int i = 0; i < spouseDetails.Common.ApplicantIncomeItems.Count; ++i)
                {
                    spouse.ApplicantIncomeItems[i] = new FnbApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem();
                    ObjectMappingTools.TransferObject(spouseDetails.Common.ApplicantIncomeItems[i], spouse.ApplicantIncomeItems[i]);
                }

            }

            return spouse;
        }

        private SubmitNedApplicationRequest GenerateNedRequest(RequestServiceHeader serviceHeader, SubmitAutoApplicationRequest applicationRequest)
        {
            if (applicationRequest.ApplicationType == ApplicationType.Single)
            {
                serviceHeader.ApplicationApplicationType = "11";
            }
            if (applicationRequest.ApplicationType == ApplicationType.Joint)
            {
                serviceHeader.ApplicationApplicationType = "35";
            }
            serviceHeader.ApplicationAction = "New";
            serviceHeader.ServiceVersion = "27";
            serviceHeader.ApplicationGroupId = "Andabond";
            serviceHeader.OriginatorReference = Utils.GenerateOriginatorReference();

            var nedRequest = new SubmitNedApplicationRequest();
            nedRequest.ServiceHeader = serviceHeader;

            //ApplicationDetails
            nedRequest.ApplicationDetails = new Models.SubmitService.NedApplicationRequest.SubmitApplicationRequestApplicationDetails();
            ObjectMappingTools.TransferObject(applicationRequest.ApplicationDetails.Nedbank, nedRequest.ApplicationDetails);
            ObjectMappingTools.TransferObject(applicationRequest.ApplicationDetails.Common, nedRequest.ApplicationDetails);

            //ApplicationApplicants
            nedRequest.ApplicationApplicants = new Models.SubmitService.NedApplicationRequest.SubmitApplicationRequestApplicationApplicants();
            nedRequest.ApplicationApplicants.MainApplicantDetails = new Models.SubmitService.NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetails();
            ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Nedbank, nedRequest.ApplicationApplicants.MainApplicantDetails);
            ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common, nedRequest.ApplicationApplicants.MainApplicantDetails);

            if (applicationRequest.ApplicationType == ApplicationType.Joint)
            {
                if (applicationRequest.ApplicationApplicants.MainApplicantDetails.SpouseDetails != null)
                {
                    nedRequest.ApplicationApplicants.MainApplicantDetails.ApplicantSpouseDetails = CopyNedbankSpouseDetails(applicationRequest.ApplicationApplicants.MainApplicantDetails.SpouseDetails);

                }
            }
            // Copy over array items
            if (applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts != null)
            {
                nedRequest.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount[applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts.Count];
                for (int i = 0; i < applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts.Count; ++i)
                {
                    nedRequest.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i] = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount();
                    ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts[i], nedRequest.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i]);
                }

            }

            if (applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantExpenditureItems != null)
            {
                nedRequest.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem[applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantExpenditureItems.Count];
                for (int i = 0; i < applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantExpenditureItems.Count; ++i)
                {
                    nedRequest.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i] = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem();
                    ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantExpenditureItems[i], nedRequest.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i]);
                }

            }

            if (applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantIncomeItems != null)
            {
                nedRequest.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem[applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantIncomeItems.Count];
                for (int i = 0; i < applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantIncomeItems.Count; ++i)
                {
                    nedRequest.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i] = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem();
                    ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantIncomeItems[i], nedRequest.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i]);
                }

            }

            if (applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Nedbank.ApplicantAssetItems != null)
            {
                nedRequest.ApplicationApplicants.MainApplicantDetails.ApplicantAssetItems = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantAssetItem[applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Nedbank.ApplicantAssetItems.Count];
                for (int i = 0; i < applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Nedbank.ApplicantAssetItems.Count; ++i)
                {
                    nedRequest.ApplicationApplicants.MainApplicantDetails.ApplicantAssetItems[i] = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantAssetItem();
                    ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Nedbank.ApplicantAssetItems[i], nedRequest.ApplicationApplicants.MainApplicantDetails.ApplicantAssetItems[i]);
                }

            }

            if (applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Nedbank.ApplicantLiabilityItems != null)
            {
                nedRequest.ApplicationApplicants.MainApplicantDetails.ApplicantLiabilityItems = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantLiabilityItem[applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Nedbank.ApplicantLiabilityItems.Count];
                for (int i = 0; i < applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Nedbank.ApplicantLiabilityItems.Count; ++i)
                {
                    nedRequest.ApplicationApplicants.MainApplicantDetails.ApplicantLiabilityItems[i] = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantLiabilityItem();
                    ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Nedbank.ApplicantLiabilityItems[i], nedRequest.ApplicationApplicants.MainApplicantDetails.ApplicantLiabilityItems[i]);
                }

            }
            return nedRequest;
        }

        private NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetails CopyNedbankSpouseDetails(ApplicantDetails spouseDetails)
        {
            var spouse = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetails();
            ObjectMappingTools.TransferObject(spouseDetails.Nedbank, spouse);
            ObjectMappingTools.TransferObject(spouseDetails.Common, spouse);

            if (spouseDetails.Common.ApplicantBankAccounts != null)
            {
                spouse.ApplicantBankAccounts = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantBankAccount[spouseDetails.Common.ApplicantBankAccounts.Count];
                for (int i = 0; i < spouseDetails.Common.ApplicantBankAccounts.Count; ++i)
                {
                    spouse.ApplicantBankAccounts[i] = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantBankAccount();
                    ObjectMappingTools.TransferObject(spouseDetails.Common.ApplicantBankAccounts[i], spouse.ApplicantBankAccounts[i]);
                }

            }

            if (spouseDetails.Common.ApplicantExpenditureItems != null)
            {
                spouse.ApplicantExpenditureItems = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem[spouseDetails.Common.ApplicantExpenditureItems.Count];
                for (int i = 0; i < spouseDetails.Common.ApplicantExpenditureItems.Count; ++i)
                {
                    spouse.ApplicantExpenditureItems[i] = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem();
                    ObjectMappingTools.TransferObject(spouseDetails.Common.ApplicantExpenditureItems[i], spouse.ApplicantExpenditureItems[i]);
                }

            }

            if (spouseDetails.Common.ApplicantIncomeItems != null)
            {
                spouse.ApplicantIncomeItems = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem[spouseDetails.Common.ApplicantIncomeItems.Count];
                for (int i = 0; i < spouseDetails.Common.ApplicantIncomeItems.Count; ++i)
                {
                    spouse.ApplicantIncomeItems[i] = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem();
                    ObjectMappingTools.TransferObject(spouseDetails.Common.ApplicantIncomeItems[i], spouse.ApplicantIncomeItems[i]);
                }

            }

            if (spouseDetails.Nedbank.ApplicantAssetItems != null)
            {
                spouse.ApplicantAssetItems = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantAssetItem[spouseDetails.Nedbank.ApplicantAssetItems.Count];
                for (int i = 0; i < spouseDetails.Nedbank.ApplicantAssetItems.Count; ++i)
                {
                    spouse.ApplicantAssetItems[i] = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantAssetItem();
                    ObjectMappingTools.TransferObject(spouseDetails.Nedbank.ApplicantAssetItems[i], spouse.ApplicantAssetItems[i]);
                }

            }

            if (spouseDetails.Nedbank.ApplicantLiabilityItems != null)
            {
                spouse.ApplicantLiabilityItems = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantLiabilityItem[spouseDetails.Nedbank.ApplicantLiabilityItems.Count];
                for (int i = 0; i < spouseDetails.Nedbank.ApplicantLiabilityItems.Count; ++i)
                {
                    spouse.ApplicantLiabilityItems[i] = new NedApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantLiabilityItem();
                    ObjectMappingTools.TransferObject(spouseDetails.Nedbank.ApplicantLiabilityItems[i], spouse.ApplicantLiabilityItems[i]);
                }

            }

            return spouse;
        }


        private SubmitSbsaApplicationRequest GenerateStdRequest(RequestServiceHeader serviceHeader, SubmitAutoApplicationRequest applicationRequest)
        {
            if (applicationRequest.ApplicationType == ApplicationType.Single)
            {
                serviceHeader.ApplicationApplicationType = "23";
            }
            if (applicationRequest.ApplicationType == ApplicationType.Joint)
            {
                serviceHeader.ApplicationApplicationType = "47";
            }
            serviceHeader.ApplicationAction = "New";
            serviceHeader.ServiceVersion = "29";
            serviceHeader.ApplicationGroupId = "Andabond";
            serviceHeader.OriginatorReference = Utils.GenerateOriginatorReference();

            var stdRequest = new SubmitSbsaApplicationRequest();
            stdRequest.ServiceHeader = serviceHeader;
            
            //ApplicationDetails
            stdRequest.ApplicationDetails = new Models.SubmitService.SbsaApplicationRequest.SubmitApplicationRequestApplicationDetails();
            ObjectMappingTools.TransferObject(applicationRequest.ApplicationDetails.Sbsa, stdRequest.ApplicationDetails);
            ObjectMappingTools.TransferObject(applicationRequest.ApplicationDetails.Common, stdRequest.ApplicationDetails);

            //ApplicationApplicants
            stdRequest.ApplicationApplicants = new Models.SubmitService.SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicants();
            stdRequest.ApplicationApplicants.MainApplicantDetails = new Models.SubmitService.SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetails();
            ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Sbsa, stdRequest.ApplicationApplicants.MainApplicantDetails);
            ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common, stdRequest.ApplicationApplicants.MainApplicantDetails);

            if (applicationRequest.ApplicationType == ApplicationType.Joint)
            {
                if (applicationRequest.ApplicationApplicants.MainApplicantDetails.SpouseDetails != null)
                {
                    stdRequest.ApplicationApplicants.MainApplicantDetails.ApplicantSpouseDetails = CopySbsaSpouseDetails(applicationRequest.ApplicationApplicants.MainApplicantDetails.SpouseDetails);

                }
            }
            // Copy over array items
            if (applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts != null)
            {
                stdRequest.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount[applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts.Count];
                for (int i = 0; i < applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts.Count; ++i)
                {
                    stdRequest.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i] = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantBankAccount();
                    ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts[i], stdRequest.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i]);
                    stdRequest.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i].ApplicantSTDAccountBranch = applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts[i].ApplicantAccountBranch;
                    stdRequest.ApplicationApplicants.MainApplicantDetails.ApplicantBankAccounts[i].ApplicantSTDAccountBranchCode = applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantBankAccounts[i].ApplicantAccountBranchCode;
                }
               
            }

            if (applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantExpenditureItems != null)
            {
                stdRequest.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem[applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantExpenditureItems.Count];
                for (int i = 0; i < applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantExpenditureItems.Count; ++i)
                {
                    stdRequest.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i] = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantExpenditureItem();
                    ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantExpenditureItems[i], stdRequest.ApplicationApplicants.MainApplicantDetails.ApplicantExpenditureItems[i]);
                }

            }

            if (applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantIncomeItems != null)
            {
                stdRequest.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem[applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantIncomeItems.Count];
                for (int i = 0; i < applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantIncomeItems.Count; ++i)
                {
                    stdRequest.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i] = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantIncomeItem();
                    ObjectMappingTools.TransferObject(applicationRequest.ApplicationApplicants.MainApplicantDetails.ApplicantDetails.Common.ApplicantIncomeItems[i], stdRequest.ApplicationApplicants.MainApplicantDetails.ApplicantIncomeItems[i]);
                }

            }

            return stdRequest;
        }


        private SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetails CopySbsaSpouseDetails(ApplicantDetails spouseDetails)
        {
            var spouse = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetails();
            ObjectMappingTools.TransferObject(spouseDetails.Sbsa, spouse);
            ObjectMappingTools.TransferObject(spouseDetails.Common, spouse);

            if (spouseDetails.Common.ApplicantBankAccounts != null)
            {
                spouse.ApplicantBankAccounts = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantBankAccount[spouseDetails.Common.ApplicantBankAccounts.Count];
                for (int i = 0; i < spouseDetails.Common.ApplicantBankAccounts.Count; ++i)
                {
                    spouse.ApplicantBankAccounts[i] = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantBankAccount();
                    ObjectMappingTools.TransferObject(spouseDetails.Common.ApplicantBankAccounts[i], spouse.ApplicantBankAccounts[i]);
                    spouse.ApplicantBankAccounts[i].ApplicantSTDAccountBranch = spouseDetails.Common.ApplicantBankAccounts[i].ApplicantAccountBranch;
                    spouse.ApplicantBankAccounts[i].ApplicantSTDAccountBranchCode = spouseDetails.Common.ApplicantBankAccounts[i].ApplicantAccountBranchCode;
                
                }

            }

            if (spouseDetails.Common.ApplicantExpenditureItems != null)
            {
                spouse.ApplicantExpenditureItems = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem[spouseDetails.Common.ApplicantExpenditureItems.Count];
                for (int i = 0; i < spouseDetails.Common.ApplicantExpenditureItems.Count; ++i)
                {
                    spouse.ApplicantExpenditureItems[i] = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantExpenditureItem();
                    ObjectMappingTools.TransferObject(spouseDetails.Common.ApplicantExpenditureItems[i], spouse.ApplicantExpenditureItems[i]);
                }

            }

            if (spouseDetails.Common.ApplicantIncomeItems != null)
            {
                spouse.ApplicantIncomeItems = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem[spouseDetails.Common.ApplicantIncomeItems.Count];
                for (int i = 0; i < spouseDetails.Common.ApplicantIncomeItems.Count; ++i)
                {
                    spouse.ApplicantIncomeItems[i] = new SbsaApplicationRequest.SubmitApplicationRequestApplicationApplicantsMainApplicantDetailsApplicantSpouseDetailsApplicantIncomeItem();
                    ObjectMappingTools.TransferObject(spouseDetails.Common.ApplicantIncomeItems[i], spouse.ApplicantIncomeItems[i]);
                }

            }

            return spouse;
        }

        /// <summary>
        /// Service to get templates
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetTemplatesReply GetTemplatesRequest(GetTemplatesRequest request)
        {
            return _facadeService.GetTemplatesRequest(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="validationRequest"></param>
        /// <returns></returns>
        public GetValidationErrorsReply GetValidationError(GetValidationErrorRequest validationRequest)
        {
            return _facadeService.GetValidationError(validationRequest);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="statusRequest"></param>
        /// <returns></returns>
        public GetApplicationStatusReply GetApplicationStatus(GetApplicationStatusRequest statusRequest)
        {
            return _facadeService.GetApplicationStatus(statusRequest);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="feedBackRequest"></param>
        /// <returns></returns>
        public GetFeedbackReply ReceiveReply(GetFeedbackRequest feedBackRequest)
        {
            return _facadeService.ReceiveReply(feedBackRequest);
        }
    }
}
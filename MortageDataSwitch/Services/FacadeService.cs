using MortageDataSwitch.Facades;
using MortageDataSwitch.Interface;
using MortageDataSwitch.Models;
using MortageDataSwitch.TemplateService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using GetTemplatesRequest = MortageDataSwitch.Models.GetTemplatesRequest;

namespace MortageDataSwitch.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class FacadeService : IFacadeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lookupRequest"></param>
        /// <returns></returns>
        public GetTableValuesReply GetTableValues(LookupServiceRequest lookupRequest)
        {
            return LookupDataServiceFacade.GetTableValues(lookupRequest);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lookupRequest"></param>
        /// <returns></returns>
        public GetTableValuesZippedReply GetTableValuesZipped(LookupServiceRequest lookupRequest)
        {
            return LookupDataServiceFacade.GetTableValuesZipped(lookupRequest);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lookupRequest"></param>
        /// <returns></returns>
        public GetTableVersionInfoReply GetTableVersionInfo(LookupServiceRequest lookupRequest)
        {
            return LookupDataServiceFacade.GetTableVersionInfo(lookupRequest);
        }

       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetLiveRepliesByDateRangeReply GetLiveRepliesByDateRange(GetLiveRepliesByDateRangeRequest request)
        {
            return LiveRepliesServiceFacade.GetLiveRepliesByDateRange(request);
        }

       

        /// <summary>
        /// Submit application to bank
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public SubmitServiceReply SubmitApplication(SubmitApplicationRequest request)
        {
            return SubmitApplicationFacade.SubmitApplication(request);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetTemplatesReply GetTemplatesRequest(GetTemplatesRequest request)
        {
            return TemplateServiceFacade.GetTemplatesRequest(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="validationRequest"></param>
        /// <returns></returns>
        public GetValidationErrorsReply GetValidationError(GetValidationErrorRequest validationRequest)
        {
            return ValidationErrorsServiceFacade.GetValidationError(validationRequest);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="statusRequest"></param>
        /// <returns></returns>
        public GetApplicationStatusReply GetApplicationStatus(GetApplicationStatusRequest statusRequest)
        {
            return SubmitStatusServiceFacade.GetApplicationStatus(statusRequest);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="feedBackRequest"></param>
        /// <returns></returns>
        public GetFeedbackReply ReceiveReply(GetFeedbackRequest feedBackRequest)
        {
            return FeedbackServiceFacades.ReceiveReply(feedBackRequest);
        }
    }
}
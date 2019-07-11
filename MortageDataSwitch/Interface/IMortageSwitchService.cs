using MortageDataSwitch.Enums;
using MortageDataSwitch.Models;
using MortageDataSwitch.TemplateService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetTemplatesRequest = MortageDataSwitch.Models.GetTemplatesRequest;

namespace MortageDataSwitch.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMortageSwitchService
    {
        T GetLookup<T>(LookupEnum lookup, LookupServiceRequest lookupRequest);
        GetLiveRepliesByDateRangeReply GetLiveRepliesByDateRange(GetLiveRepliesByDateRangeRequest request);
        //GetLiveRepliesAppRefReply GetLiveRepliesByAppRef(GetLiveRepliesByAppRefRequest request);
        SubmitServiceReply SubmitApplication(SubmitIncomingApplicationRequest applicationRequest);
        SubmitAutoApplicationResponse SubmitAutoApplication(SubmitAutoApplicationRequest applicationRequest);
        GetTemplatesReply GetTemplatesRequest(GetTemplatesRequest request);
        GetValidationErrorsReply GetValidationError(GetValidationErrorRequest validationRequest);
        GetApplicationStatusReply GetApplicationStatus(GetApplicationStatusRequest statusRequest);
        GetFeedbackReply ReceiveReply(GetFeedbackRequest feedBackRequest);
    }
}

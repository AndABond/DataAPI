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
    /// The interface to bind all facades
    /// </summary>
    public interface IFacadeService
    {
        GetTableValuesReply GetTableValues(LookupServiceRequest lookupRequest);
        GetTableValuesZippedReply GetTableValuesZipped(LookupServiceRequest lookupRequest);
        GetTableVersionInfoReply GetTableVersionInfo(LookupServiceRequest lookupRequest);
        GetLiveRepliesByDateRangeReply GetLiveRepliesByDateRange(GetLiveRepliesByDateRangeRequest request);

        SubmitServiceReply SubmitApplication(SubmitApplicationRequest request);
        
        GetTemplatesReply GetTemplatesRequest(GetTemplatesRequest request);
        GetValidationErrorsReply GetValidationError(GetValidationErrorRequest validationRequest);
        GetApplicationStatusReply GetApplicationStatus(GetApplicationStatusRequest statusRequest);
        GetFeedbackReply ReceiveReply(GetFeedbackRequest feedBackRequest);
    }
}

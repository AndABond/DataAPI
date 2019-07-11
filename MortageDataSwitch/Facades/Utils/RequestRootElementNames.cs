using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortageDataSwitch.Facades.Utils
{
    public class RequestRootElementNames
    {
        public const string Submit = "SubmitApplication.Request";
        public const string Status = "GetApplicationStatus.Request";
        public const string Validation = "GetValidationError.Request";
        public const string SubmitError = "GetSubmissionError.Request";
        public const string Info = "GetApplicationInfo.Request";
        public const string LiveReply = "GetLiveRepliesByDateRange.Request";
        public const string Feedback = "Feedback.Request";
        public const string GetFeedback = "GetFeedback.Request";
        public const string Template = "GetTemplates.Request";
        public const string QuickCheck = "QuickCheck.Request";
        public const string Affordability = "AffordabilityCheck.Request";
        public const string SearchWorks = "SearchWorks.Request";
        public const string CreditCheck = "CreditCheck.Request";
    }
}
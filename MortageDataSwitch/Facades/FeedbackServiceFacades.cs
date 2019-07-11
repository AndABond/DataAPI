using MortageDataSwitch.Models;
using MortageDataSwitch.Services;
using MortageDataSwitch.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Web;

namespace MortageDataSwitch.Facades
{
    /// <summary>
    /// 
    /// </summary>
    public static class FeedbackServiceFacades
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="feedBackRequest"></param>
        /// <returns></returns>
        public static GetFeedbackReply ReceiveReply(GetFeedbackRequest feedBackRequest)
        {
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(RsaUtils.ValidateRemoteCertificate);

            var request = new FeedbackService.FeedbackServiceSoapClient("Feedback.ServiceSoap");

            var xml = XmlUtils.SerializeXml<GetFeedbackRequest>(feedBackRequest);

            xml = XmlUtils.FormatMacXml(xml);

            var response = request.ReceiveReply(xml);

            var reply = XmlUtils.DeserializeXml<GetFeedbackReply>(response);

            if(reply.ServiceHeader.ServiceResult == 2)
            {
                EmailProvider.SendEmail("ReceiveReply", xml, string.Empty);
            }

            return reply;
        }

        public static void SendRequest()
        {

        }
    }
}
using MortageDataSwitch.Facades.Utils;
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
    public static class SubmitStatusServiceFacade
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="applicationRequest"></param>
        public static GetApplicationStatusReply GetApplicationStatus(GetApplicationStatusRequest applicationRequest)
        {
            
            var xml = XmlUtils.SerializeXml<GetApplicationStatusRequest>(applicationRequest);

            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(RsaUtils.ValidateRemoteCertificate);

            var request = new SubmitStatusService.SubmitStatusServiceSoapClient();

            xml = XmlUtils.FormatMacXml(xml);

            var response = request.GetApplicationStatus(xml);

            var reply = XmlUtils.DeserializeXml<GetApplicationStatusReply>(response);

            if (reply.ServiceHeader.ServiceResult == 2)
            {
                EmailProvider.SendEmail("GetApplicationStatus", xml, string.Empty);
            }

            return reply;
        }
    }
}
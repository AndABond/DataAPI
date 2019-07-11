using MortageDataSwitch.Models;
using MortageDataSwitch.Services;
using MortageDataSwitch.TemplateService;
using MortageDataSwitch.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Web;
using GetTemplatesRequest = MortageDataSwitch.Models.GetTemplatesRequest;

namespace MortageDataSwitch.Facades
{
    /// <summary>
    /// 
    /// </summary>
    public static class TemplateServiceFacade
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="templateRequest"></param>
        /// <returns></returns>
        public static GetTemplatesReply GetTemplatesRequest(GetTemplatesRequest templateRequest)
        {
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(RsaUtils.ValidateRemoteCertificate);

            var request = new TemplateService.TemplateServiceSoapClient("Template.Service");

            var xml = XmlUtils.SerializeXml<GetTemplatesRequest>(templateRequest);

            xml = XmlUtils.FormatMacXml(xml);

            var response = request.GetTemplates(xml);

            var reply = XmlUtils.DeserializeXml<GetTemplatesReply>(response);

            if (reply.ServiceHeader.ServiceResult == 2)
            {
                EmailProvider.SendEmail("GetTemplatesRequest", xml, string.Empty);
            }

            return reply;
        }
    }
}
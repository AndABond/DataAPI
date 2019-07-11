using MortageDataSwitch.Models;
using MortageDataSwitch.Services;
using MortageDataSwitch.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text.RegularExpressions;
using System.Web;

namespace MortageDataSwitch.Facades
{
    /// <summary>
    /// 
    /// </summary>
    public static class ValidationErrorsServiceFacade
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="validationRequest"></param>
        public static GetValidationErrorsReply GetValidationError(GetValidationErrorRequest validationRequest)
        {
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(RsaUtils.ValidateRemoteCertificate);

            var request = new ValidationErrorService.ValidationErrorsServiceSoapClient("ValidationErrors.ServiceSoap");

            var xml = XmlUtils.SerializeXml<GetValidationErrorRequest>(validationRequest);

            xml = Regex.Replace(xml, "<Application.Group.Id />", "");
            xml = Regex.Replace(xml, "<Application.Action />", "");
            xml = Regex.Replace(xml, "<Application.ApplicationType />", "");

            xml = XmlUtils.FormatMacXml(xml);

            

            var response = request.GetValidationError(xml);

            var reply = XmlUtils.DeserializeXml<GetValidationErrorsReply>(response);

            if(reply.ServiceHeader.ServiceResult == 2)
            {
                EmailProvider.SendEmail("GetValidationError", xml, string.Empty);
            }

            return reply;
        }
    }
}
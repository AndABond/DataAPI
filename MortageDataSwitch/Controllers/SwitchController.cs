using MortageDataSwitch.Interface;
using MortageDataSwitch.LiveRepliesService;
using MortageDataSwitch.Models;
using MortageDataSwitch.Models.Controller;
using MortageDataSwitch.StaticModels;
using MortageDataSwitch.SubmitService;
using MortageDataSwitch.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using SubmitApplicationRequest = MortageDataSwitch.Models.SubmitApplicationRequest;

namespace MortageDataSwitch.Controllers
{

    /// <summary>
    /// SwitchController
    /// </summary>
    [RoutePrefix("api/switch")]
    public class SwitchController : ApiController
    {
        private static readonly log4net.ILog LOG = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly IMortageSwitchService _service;

        /// <summary>
        /// SimpleInjector injected IMortageSwitchService from Global.asax
        /// </summary>
        /// <param name="service"></param>
        public SwitchController(IMortageSwitchService service)
        {
            _service = service;
        }
        /// <summary>
        /// SubmitApplication
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [SecurityAuthenticationFilter]
        [Route("SubmitApplication")]
        public SubmitServiceReply SubmitApplication([FromBody]SubmitIncomingApplicationRequest request)
        {
            //string incoming = JsonConvert.SerializeObject(request);
            try
            {
                if (request == null)
                {
                    var postStream = Request.Content.ReadAsStreamAsync().Result;
                    postStream.Seek(0, SeekOrigin.Begin);
                    var postBodyString = new StreamReader(postStream).ReadToEnd();

                    request = JsonConvert.DeserializeObject<SubmitIncomingApplicationRequest>(postBodyString);

                }
                request.ServiceHeader = HeaderTools.GetHeader(string.Empty, request.ServiceHeader.ApplicationApplicationType, request.ServiceHeader.ApplicationAction, request.ServiceHeader.ApplicationGroupId);
                request.ServiceHeader.ApplicationApplicationType = request.ServiceHeader.ApplicationApplicationType;
                return _service.SubmitApplication(request);
            }
            catch (Exception epx)
            {
                LOG.Error("SubmitApplication: " + epx.Message, epx);
                return new SubmitServiceReply
                {
                    StatusMessage = epx.Message
                };
            }

        }

        /// <summary>
        /// SubmitAutoApplication
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [SecurityAuthenticationFilter]
        [Route("SubmitAutoApplication")]
        public SubmitAutoApplicationResponse SubmitAutoApplication([FromBody]SubmitAutoApplicationRequest request)
        {
            //string incoming = JsonConvert.SerializeObject(request);
            try
            {
                if (request == null)
                {
                    var postStream = Request.Content.ReadAsStreamAsync().Result;
                    postStream.Seek(0, SeekOrigin.Begin);
                    var postBodyString = new StreamReader(postStream).ReadToEnd();

                    request = JsonConvert.DeserializeObject<SubmitAutoApplicationRequest>(postBodyString);

                }
                return _service.SubmitAutoApplication(request);
            }
            catch (Exception epx)
            {
                LOG.Error("SubmitApplication: " + epx.Message, epx);
                return new SubmitAutoApplicationResponse
                {
                    StatusMessage = epx.Message
                };
            }

        }

        /// <summary>
        /// GetApplicationStatus
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [SecurityAuthenticationFilter]
        [Route("SubmitDocuments")]
        public SubmitDocumentsResponse SubmitDocuments([FromBody]SubmitDocumentsRequest request)
        {
            return new SubmitDocumentsResponse
            {
                Result = "SubmitDocuments Result"
            };
        }

        /// <summary>
        /// GetApplicationStatuses
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [SecurityAuthenticationFilter]
        [Route("GetApplicationStatus")]
        public GetApplicationStatusReply GetApplicationStatus([FromBody]ControllerApplicationStatusRequest request)
        {
            var serviceRequest = new GetApplicationStatusRequest()
            {
                ServiceHeader = HeaderTools.GetHeader(request.ApplicationReference)
            };

            return _service.GetApplicationStatus(serviceRequest);
        }

        /// <summary>
        /// GetLiveRepliesByDateRange
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [SecurityAuthenticationFilter]
        [Route("GetLiveRepliesByDateRange")]
        public GetLiveRepliesByDateRangeReply GetLiveRepliesByDateRange([FromBody]ControllerLiveRepliesByDateRangeRequest request)
        {
            var serviceRequest = new Models.GetLiveRepliesByDateRangeRequest()
            {
                ServiceHeader = HeaderTools.GetHeader(request.ApplicationReference),
                LiveReplyRequestInfo = new GetLiveRepliesByDateRangeRequestLiveReplyRequestInfo()
                {
                    LiveReplyDateFrom = request.DateFrom,
                    LiveReplyDateTo = request.DateFrom,
                    OriginatorId = WebConfigurationManager.AppSettings["OriginatorId"]
                }
            };

            return _service.GetLiveRepliesByDateRange(serviceRequest);
        }

        /// <summary>
        /// GetValidationError
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [SecurityAuthenticationFilter]
        [Route("GetValidationError")]
        public GetValidationErrorsReply GetValidationError([FromBody]ControllerValidationErrorRequest request)
        {
            var serviceRequest = new GetValidationErrorRequest()
            {
                ServiceHeader = HeaderTools.GetHeader(request.ApplicationReference)
            };

            return _service.GetValidationError(serviceRequest);
        }

        /// <summary>
        /// GetBankSchemas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SecurityAuthenticationFilter]
        [Route("GetBankSchemas")]
        public List<BankSchema> GetBankSchemas()
        {
            return SchemaManager.GetBankSchemas();
        }
    }
}

using Cosmos.Core.Enums;
using Cosmos.Core.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Core.Utilities
{
    public class HttpResponse
    {
        #region Public Properties
        public bool Status { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        #endregion

        #region Constructor
        public HttpResponse()
        {

        }

        public HttpResponse(bool status)
        {
            this.Status = status;
        }

        #endregion

        #region Static Properties
        public static HttpResponse Instance
        {
            get { return new HttpResponse(); }
        }

        #endregion

        #region Public Methods
        // Chain Programming
        public HttpResponse Ok()
        {
            this.Status = true;
            return this;
        }

        public HttpResponse OK(string message = null, object data = null)
        {
            this.Status = true;
            this.Message = message;
            this.Data = data;
            return this;
        }

        // Set Response context of after requesting  from server
        public HttpResponse Set(HttpResponseType httpResponseType,bool? status,string message)
        {
            this.Code = ((int)httpResponseType).ToString();
            if (status!=null)
            {
                this.Status =(bool) status;
            }
            if (!string.IsNullOrEmpty(message))
            {
                this.Message = message;
                return this;
            }
            this.Message = httpResponseType.GetMessage();
            return this;
        }


        /// Set Reponsse Context when status equal null
        public HttpResponse Set(HttpResponseType httpResponseType,string message)
        {
            bool? status= null;
            return this.Set(httpResponseType,status, message);
        }


        // Set Reponse Context when there is no message
        public HttpResponse Set(HttpResponseType httpResponseType,bool? status)
        {
            return this.Set(httpResponseType, status,null );
        }


        public HttpResponse Error(HttpResponseType httpResponseType)
        {
            return this.Set(httpResponseType, false);
        }

        //
        // Custom error message
        public HttpResponse Error(string message=null)
        {
            this.Status = false;
            this.Message = message;
            return this;
        }
        #endregion

    }
}

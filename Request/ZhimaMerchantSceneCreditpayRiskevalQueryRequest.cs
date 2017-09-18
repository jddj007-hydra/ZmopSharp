using System;
using System.Collections.Generic;
using Zmop.Api.Response;

namespace Zmop.Api.Request
{
    /// <summary>
    /// ZMOP API: zhima.merchant.scene.creditpay.riskeval.query
    /// </summary>
    public class ZhimaMerchantSceneCreditpayRiskevalQueryRequest : IZmopRequest<ZhimaMerchantSceneCreditpayRiskevalQueryResponse>
    {
        /// <summary>
        /// 是否需要授权
        /// </summary>
        public Nullable<bool> NeedAuth { get; set; }

        /// <summary>
        /// 支付宝userid
        /// </summary>
        public string UserId { get; set; }

        #region IZmopRequest Members
        private string apiVersion = "1.0";
		private string channel;
		private string platform;
        private string scene;
		private string extParams;

		public void SetChannel(string channel){
            this.channel = channel;
        }

        public string GetChannel(){
            return this.channel;
        }

        public void SetPlatform(String platform){
			this.platform=platform;
		}

    	public string GetPlatform(){
    		return this.platform;
    	}

    	public void SetScene(String scene){
    		this.scene=scene;
    	}

    	public string GetScene(){
    		return this.scene;
    	}

        public void SetExtParams(String extParams){
            this.extParams=extParams;
        }

        public string GetExtParams(){
            return this.extParams;
        }

        public string GetApiName()
        {
            return "zhima.merchant.scene.creditpay.riskeval.query";
        }

        public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            ZmopDictionary parameters = new ZmopDictionary();
            parameters.Add("need_auth", this.NeedAuth);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
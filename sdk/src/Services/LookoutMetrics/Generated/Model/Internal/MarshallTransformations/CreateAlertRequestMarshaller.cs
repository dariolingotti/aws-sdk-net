/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutMetrics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LookoutMetrics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAlert Request Marshaller
    /// </summary>       
    public class CreateAlertRequestMarshaller : IMarshaller<IRequest, CreateAlertRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAlertRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAlertRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LookoutMetrics");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "/CreateAlert";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAction())
                {
                    context.Writer.WritePropertyName("Action");
                    context.Writer.WriteObjectStart();

                    var marshaller = ActionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Action, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAlertDescription())
                {
                    context.Writer.WritePropertyName("AlertDescription");
                    context.Writer.Write(publicRequest.AlertDescription);
                }

                if(publicRequest.IsSetAlertName())
                {
                    context.Writer.WritePropertyName("AlertName");
                    context.Writer.Write(publicRequest.AlertName);
                }

                if(publicRequest.IsSetAlertSensitivityThreshold())
                {
                    context.Writer.WritePropertyName("AlertSensitivityThreshold");
                    context.Writer.Write(publicRequest.AlertSensitivityThreshold);
                }

                if(publicRequest.IsSetAnomalyDetectorArn())
                {
                    context.Writer.WritePropertyName("AnomalyDetectorArn");
                    context.Writer.Write(publicRequest.AnomalyDetectorArn);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateAlertRequestMarshaller _instance = new CreateAlertRequestMarshaller();        

        internal static CreateAlertRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAlertRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
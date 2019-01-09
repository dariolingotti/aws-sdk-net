/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ModifySnapshotSchedule operation
    /// </summary>  
    public class ModifySnapshotScheduleResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ModifySnapshotScheduleResponse response = new ModifySnapshotScheduleResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("ModifySnapshotScheduleResult", 2))
                    {
                        UnmarshallResult(context, response);                        
                        continue;
                    }
                    
                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.Instance.Unmarshall(context);
                    }
                }
            }

            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, ModifySnapshotScheduleResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("AssociatedClusterCount", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.AssociatedClusterCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AssociatedClusters/ClusterAssociatedToSchedule", targetDepth))
                    {
                        var unmarshaller = ClusterAssociatedToScheduleUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        response.AssociatedClusters.Add(item);
                        continue;
                    }
                    if (context.TestExpression("NextInvocations/SnapshotTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        response.NextInvocations.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ScheduleDefinitions/ScheduleDefinition", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        response.ScheduleDefinitions.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ScheduleDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ScheduleDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ScheduleIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ScheduleIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Tags/Tag", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        response.Tags.Add(item);
                        continue;
                    }
                } 
           }

            return;
        }


        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidSchedule"))
            {
                return new InvalidScheduleException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("SnapshotScheduleNotFound"))
            {
                return new SnapshotScheduleNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("SnapshotScheduleUpdateInProgress"))
            {
                return new SnapshotScheduleUpdateInProgressException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonRedshiftException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static ModifySnapshotScheduleResponseUnmarshaller _instance = new ModifySnapshotScheduleResponseUnmarshaller();        

        internal static ModifySnapshotScheduleResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifySnapshotScheduleResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
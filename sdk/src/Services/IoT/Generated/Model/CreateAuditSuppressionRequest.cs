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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAuditSuppression operation.
    /// Creates a Device Defender audit suppression. 
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateAuditSuppression</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class CreateAuditSuppressionRequest : AmazonIoTRequest
    {
        private string _checkName;
        private string _clientRequestToken;
        private string _description;
        private DateTime? _expirationDate;
        private ResourceIdentifier _resourceIdentifier;
        private bool? _suppressIndefinitely;

        /// <summary>
        /// Gets and sets the property CheckName.
        /// </summary>
        [AWSProperty(Required=true)]
        public string CheckName
        {
            get { return this._checkName; }
            set { this._checkName = value; }
        }

        // Check to see if CheckName property is set
        internal bool IsSetCheckName()
        {
            return this._checkName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        ///  Each audit supression must have a unique client request token. If you try to create
        /// a new audit suppression with the same token as one that already exists, an exception
        /// occurs. If you omit this value, Amazon Web Services SDKs will automatically generate
        /// a unique client request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the audit suppression. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        ///  The epoch timestamp in seconds at which this suppression expires. 
        /// </para>
        /// </summary>
        public DateTime ExpirationDate
        {
            get { return this._expirationDate.GetValueOrDefault(); }
            set { this._expirationDate = value; }
        }

        // Check to see if ExpirationDate property is set
        internal bool IsSetExpirationDate()
        {
            return this._expirationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier.
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceIdentifier ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SuppressIndefinitely. 
        /// <para>
        ///  Indicates whether a suppression should exist indefinitely or not. 
        /// </para>
        /// </summary>
        public bool SuppressIndefinitely
        {
            get { return this._suppressIndefinitely.GetValueOrDefault(); }
            set { this._suppressIndefinitely = value; }
        }

        // Check to see if SuppressIndefinitely property is set
        internal bool IsSetSuppressIndefinitely()
        {
            return this._suppressIndefinitely.HasValue; 
        }

    }
}
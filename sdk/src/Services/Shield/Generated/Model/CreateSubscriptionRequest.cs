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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSubscription operation.
    /// Activates Shield Advanced for an account.
    /// 
    ///  
    /// <para>
    /// When you initally create a subscription, your subscription is set to be automatically
    /// renewed at the end of the existing subscription period. You can change this by submitting
    /// an <code>UpdateSubscription</code> request. 
    /// </para>
    /// </summary>
    public partial class CreateSubscriptionRequest : AmazonShieldRequest
    {

    }
}
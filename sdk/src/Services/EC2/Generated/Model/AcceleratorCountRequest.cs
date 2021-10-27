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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The minimum and maximum number of accelerators (GPUs, FPGAs, or Amazon Web Services
    /// Inferentia chips) on an instance. To exclude accelerator-enabled instance types, set
    /// <code>Max</code> to <code>0</code>.
    /// </summary>
    public partial class AcceleratorCountRequest
    {
        private int? _max;
        private int? _min;

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// The maximum number of accelerators. To specify no maximum limit, omit this parameter.
        /// To exclude accelerator-enabled instance types, set <code>Max</code> to <code>0</code>.
        /// </para>
        /// </summary>
        public int Max
        {
            get { return this._max.GetValueOrDefault(); }
            set { this._max = value; }
        }

        // Check to see if Max property is set
        internal bool IsSetMax()
        {
            return this._max.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Min. 
        /// <para>
        /// The minimum number of accelerators. To specify no minimum limit, omit this parameter.
        /// </para>
        /// </summary>
        public int Min
        {
            get { return this._min.GetValueOrDefault(); }
            set { this._min = value; }
        }

        // Check to see if Min property is set
        internal bool IsSetMin()
        {
            return this._min.HasValue; 
        }

    }
}
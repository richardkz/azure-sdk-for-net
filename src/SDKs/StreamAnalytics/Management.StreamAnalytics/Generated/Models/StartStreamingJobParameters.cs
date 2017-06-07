// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StreamAnalytics;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Start Streaming Job operation.
    /// </summary>
    public partial class StartStreamingJobParameters
    {
        /// <summary>
        /// Initializes a new instance of the StartStreamingJobParameters
        /// class.
        /// </summary>
        public StartStreamingJobParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StartStreamingJobParameters
        /// class.
        /// </summary>
        /// <param name="outputStartMode">Value may be JobStartTime,
        /// CustomTime, or LastOutputEventTime to indicate whether the starting
        /// point of the output event stream should start whenever the job is
        /// started, start at a custom user time stamp specified via the
        /// outputStartTime property, or start from the last event output time.
        /// Possible values include: 'JobStartTime', 'CustomTime',
        /// 'LastOutputEventTime'</param>
        /// <param name="outputStartTime">Value is either an ISO-8601 formatted
        /// time stamp that indicates the starting point of the output event
        /// stream, or null to indicate that the output event stream will start
        /// whenever the streaming job is started. This property must have a
        /// value if outputStartMode is set to CustomTime.</param>
        public StartStreamingJobParameters(string outputStartMode = default(string), System.DateTime? outputStartTime = default(System.DateTime?))
        {
            OutputStartMode = outputStartMode;
            OutputStartTime = outputStartTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets value may be JobStartTime, CustomTime, or
        /// LastOutputEventTime to indicate whether the starting point of the
        /// output event stream should start whenever the job is started, start
        /// at a custom user time stamp specified via the outputStartTime
        /// property, or start from the last event output time. Possible values
        /// include: 'JobStartTime', 'CustomTime', 'LastOutputEventTime'
        /// </summary>
        [JsonProperty(PropertyName = "outputStartMode")]
        public string OutputStartMode { get; set; }

        /// <summary>
        /// Gets or sets value is either an ISO-8601 formatted time stamp that
        /// indicates the starting point of the output event stream, or null to
        /// indicate that the output event stream will start whenever the
        /// streaming job is started. This property must have a value if
        /// outputStartMode is set to CustomTime.
        /// </summary>
        [JsonProperty(PropertyName = "outputStartTime")]
        public System.DateTime? OutputStartTime { get; set; }

    }
}

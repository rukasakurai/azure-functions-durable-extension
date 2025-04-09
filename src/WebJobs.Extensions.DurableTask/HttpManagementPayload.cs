// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Newtonsoft.Json;

namespace Microsoft.Azure.WebJobs.Extensions.DurableTask
{
    /// <summary>
    /// Data structure containing status, terminate and send external event HTTP endpoints.
    /// </summary>
    public class HttpManagementPayload
    {
        /// <summary>
        /// Gets the ID of the orchestration instance.
        /// </summary>
        /// <value>
        /// The ID of the orchestration instance.
        /// </value>
        [JsonProperty("id")]
        public string Id { get; internal set; }

        /// <summary>
        /// Gets the HTTP GET status query endpoint URL.
        /// </summary>
        /// <value>
        /// The HTTP URL for fetching the instance status.
        /// </value>
        [JsonProperty("statusQueryGetUri")]
        public string StatusQueryGetUri { get; internal set; }

        /// <summary>
        /// Gets the HTTP POST external event sending endpoint URL.
        /// </summary>
        /// <value>
        /// The HTTP URL for posting external event notifications.
        /// </value>
        [JsonProperty("sendEventPostUri")]
        public string SendEventPostUri { get; internal set; }

        /// <summary>
        /// Gets the HTTP POST instance termination endpoint.
        /// </summary>
        /// <value>
        /// The HTTP URL for posting instance termination commands.
        /// </value>
        [JsonProperty("terminatePostUri")]
        public string TerminatePostUri { get; internal set; }

        /// <summary>
        /// Gets the HTTP POST instance rewind endpoint.
        /// </summary>
        /// <value>
        /// The HTTP URL for rewinding orchestration instances.
        /// </value>
        [JsonProperty("rewindPostUri")]
        public string RewindPostUri { get; internal set; }

        /// <summary>
        /// Gets the HTTP DELETE purge instance history by instance ID endpoint.
        /// </summary>
        /// <value>
        /// The HTTP URL for purging instance history by instance ID.
        /// </value>
        [JsonProperty("purgeHistoryDeleteUri")]
        public string PurgeHistoryDeleteUri { get; internal set; }

        /// <summary>
        /// Gets the HTTP POST instance restart endpoint.
        /// </summary>
        /// <value>
        /// The HTTP URL for restarting an orchestration instance.
        /// </value>
        [JsonProperty("restartPostUri")]
        public string RestartPostUri { get; internal set; }

        /// <summary>
        /// Gets the HTTP POST instance suspend endpoint.
        /// </summary>
        /// <value>
        /// The HTTP URL for suspending an orchestration instance.
        /// </value>
        [JsonProperty("suspendPostUri")]
        public string SuspendPostUri { get; internal set; }

        /// <summary>
        /// Gets the HTTP POST instance resume endpoint.
        /// </summary>
        /// <value>
        /// The HTTP URL for resuming an orchestration instance.
        /// </value>
        [JsonProperty("resumePostUri")]
        public string ResumePostUri { get; internal set; }

        /// <summary>
        /// Gets or sets the forwarded proto header value.
        /// </summary>
        /// <value>
        /// The forwarded proto header value.
        /// </value>
        [JsonProperty("forwardedProto")]
        public string ForwardedProto { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpManagementPayload"/> class.
        /// </summary>
        /// <param name="id">The ID of the orchestration instance.</param>
        /// <param name="statusQueryGetUri">The HTTP URL for fetching the instance status.</param>
        /// <param name="sendEventPostUri">The HTTP URL for posting external event notifications.</param>
        /// <param name="terminatePostUri">The HTTP URL for posting instance termination commands.</param>
        /// <param name="rewindPostUri">The HTTP URL for rewinding orchestration instances.</param>
        /// <param name="purgeHistoryDeleteUri">The HTTP URL for purging instance history by instance ID.</param>
        /// <param name="restartPostUri">The HTTP URL for restarting an orchestration instance.</param>
        /// <param name="suspendPostUri">The HTTP URL for suspending an orchestration instance.</param>
        /// <param name="resumePostUri">The HTTP URL for resuming an orchestration instance.</param>
        /// <param name="forwardedHost">The forwarded host header value.</param>
        /// <param name="forwardedProto">The forwarded proto header value.</param>
        public HttpManagementPayload(
            string id,
            string statusQueryGetUri,
            string sendEventPostUri,
            string terminatePostUri,
            string rewindPostUri,
            string purgeHistoryDeleteUri,
            string restartPostUri,
            string suspendPostUri,
            string resumePostUri,
            string forwardedHost,
            string forwardedProto)
        {
            this.Id = id;
            this.StatusQueryGetUri = statusQueryGetUri;
            this.SendEventPostUri = sendEventPostUri;
            this.TerminatePostUri = terminatePostUri;
            this.RewindPostUri = rewindPostUri;
            this.PurgeHistoryDeleteUri = purgeHistoryDeleteUri;
            this.RestartPostUri = restartPostUri;
            this.SuspendPostUri = suspendPostUri;
            this.ResumePostUri = resumePostUri;
            this.ForwardedHost = forwardedHost;
            this.ForwardedProto = forwardedProto;
        }
    }
}

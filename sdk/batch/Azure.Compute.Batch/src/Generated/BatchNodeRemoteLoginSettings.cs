// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.Compute.Batch
{
    /// <summary> The remote login settings for a Compute Node. </summary>
    public partial class BatchNodeRemoteLoginSettings
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BatchNodeRemoteLoginSettings"/>. </summary>
        /// <param name="remoteLoginIpAddress"> The IP address used for remote login to the Compute Node. </param>
        /// <param name="remoteLoginPort"> The port used for remote login to the Compute Node. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="remoteLoginIpAddress"/> is null. </exception>
        internal BatchNodeRemoteLoginSettings(IPAddress remoteLoginIpAddress, int remoteLoginPort)
        {
            Argument.AssertNotNull(remoteLoginIpAddress, nameof(remoteLoginIpAddress));

            RemoteLoginIpAddress = remoteLoginIpAddress;
            RemoteLoginPort = remoteLoginPort;
        }

        /// <summary> Initializes a new instance of <see cref="BatchNodeRemoteLoginSettings"/>. </summary>
        /// <param name="remoteLoginIpAddress"> The IP address used for remote login to the Compute Node. </param>
        /// <param name="remoteLoginPort"> The port used for remote login to the Compute Node. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchNodeRemoteLoginSettings(IPAddress remoteLoginIpAddress, int remoteLoginPort, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RemoteLoginIpAddress = remoteLoginIpAddress;
            RemoteLoginPort = remoteLoginPort;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchNodeRemoteLoginSettings"/> for deserialization. </summary>
        internal BatchNodeRemoteLoginSettings()
        {
        }

        /// <summary> The IP address used for remote login to the Compute Node. </summary>
        public IPAddress RemoteLoginIpAddress { get; }
        /// <summary> The port used for remote login to the Compute Node. </summary>
        public int RemoteLoginPort { get; }
    }
}

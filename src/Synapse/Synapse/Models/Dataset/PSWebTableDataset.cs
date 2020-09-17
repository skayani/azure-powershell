// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Synapse.Models
{
    using global::Azure.Analytics.Synapse.Artifacts.Models;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The dataset points to a HTML table in the web page.
    /// </summary>
    [Newtonsoft.Json.JsonObject("WebTable")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSWebTableDataset : PSDataset
    {
        /// <summary>
        /// Initializes a new instance of the PSWebTableDataset class.
        /// </summary>
        public PSWebTableDataset()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the zero-based index of the table in the web page.
        /// Type: integer (or Expression with resultType integer), minimum: 0.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.index")]
        public object Index { get; set; }

        /// <summary>
        /// Gets or sets the relative URL to the web page from the linked
        /// service URL. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.path")]
        public object Path { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Index == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Index");
            }
        }

        public override Dataset ToSdkObject()
        {
            var dataset = new WebTableDataset(this.LinkedServiceName, this.Index);
            dataset.Path = this.Path;
            SetProperties(dataset);
            return dataset;
        }
    }
}


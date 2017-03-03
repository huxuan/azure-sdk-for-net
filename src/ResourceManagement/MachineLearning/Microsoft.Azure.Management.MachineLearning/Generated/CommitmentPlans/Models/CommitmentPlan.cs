// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.CommitmentPlans.Models
{
    using System.Linq;

    /// <summary>
    /// An Azure ML commitment plan resource.
    /// </summary>
    public partial class CommitmentPlan : Resource
    {
        /// <summary>
        /// Initializes a new instance of the CommitmentPlan class.
        /// </summary>
        public CommitmentPlan() { }

        /// <summary>
        /// Initializes a new instance of the CommitmentPlan class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">User-defined tags for the resource.</param>
        /// <param name="etag">An entity tag used to enforce optimistic
        /// concurrency.</param>
        /// <param name="properties">The commitment plan properties.</param>
        /// <param name="sku">The commitment plan SKU.</param>
        public CommitmentPlan(string location, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string etag = default(string), CommitmentPlanProperties properties = default(CommitmentPlanProperties), ResourceSku sku = default(ResourceSku))
            : base(location, id, name, type, tags)
        {
            Etag = etag;
            Properties = properties;
            Sku = sku;
        }

        /// <summary>
        /// Gets or sets an entity tag used to enforce optimistic concurrency.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets the commitment plan properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public CommitmentPlanProperties Properties { get; private set; }

        /// <summary>
        /// Gets or sets the commitment plan SKU.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public ResourceSku Sku { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
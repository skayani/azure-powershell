namespace Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Extensions;

    /// <summary>Operation supported by the Microsoft.ManagedIdentity REST API.</summary>
    public partial class Operation :
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130.IOperation,
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130.IOperationInternal
    {

        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130.IOperationDisplay _display;

        /// <summary>The object that describes the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130.IOperationDisplay Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130.OperationDisplay()); set => this._display = value; }

        /// <summary>A description of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inlined)]
        public string DisplayDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130.IOperationDisplayInternal)Display).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130.IOperationDisplayInternal)Display).Description = value; }

        /// <summary>The type of operation. For example: read, write, delete.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inlined)]
        public string DisplayOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130.IOperationDisplayInternal)Display).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130.IOperationDisplayInternal)Display).Operation = value; }

        /// <summary>Friendly name of the resource provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inlined)]
        public string DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130.IOperationDisplayInternal)Display).Provider; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130.IOperationDisplayInternal)Display).Provider = value; }

        /// <summary>The resource type on which the operation is performed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inlined)]
        public string DisplayResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130.IOperationDisplayInternal)Display).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130.IOperationDisplayInternal)Display).Resource = value; }

        /// <summary>Internal Acessors for Display</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130.IOperationDisplay Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130.IOperationInternal.Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130.OperationDisplay()); set { {_display = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// The name of the REST Operation. This is of the format {provider}/{resource}/{operation}.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="Operation" /> instance.</summary>
        public Operation()
        {

        }
    }
    /// Operation supported by the Microsoft.ManagedIdentity REST API.
    public partial interface IOperation :
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.IJsonSerializable
    {
        /// <summary>A description of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A description of the operation.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get; set; }
        /// <summary>The type of operation. For example: read, write, delete.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of operation. For example: read, write, delete.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayOperation { get; set; }
        /// <summary>Friendly name of the resource provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Friendly name of the resource provider.",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayProvider { get; set; }
        /// <summary>The resource type on which the operation is performed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource type on which the operation is performed.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayResource { get; set; }
        /// <summary>
        /// The name of the REST Operation. This is of the format {provider}/{resource}/{operation}.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the REST Operation. This is of the format {provider}/{resource}/{operation}.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Operation supported by the Microsoft.ManagedIdentity REST API.
    internal partial interface IOperationInternal

    {
        /// <summary>The object that describes the operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20181130.IOperationDisplay Display { get; set; }
        /// <summary>A description of the operation.</summary>
        string DisplayDescription { get; set; }
        /// <summary>The type of operation. For example: read, write, delete.</summary>
        string DisplayOperation { get; set; }
        /// <summary>Friendly name of the resource provider.</summary>
        string DisplayProvider { get; set; }
        /// <summary>The resource type on which the operation is performed.</summary>
        string DisplayResource { get; set; }
        /// <summary>
        /// The name of the REST Operation. This is of the format {provider}/{resource}/{operation}.
        /// </summary>
        string Name { get; set; }

    }
}
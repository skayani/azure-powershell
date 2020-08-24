// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support
{

    public partial struct BlockchainMemberProvisioningState :
        System.IEquatable<BlockchainMemberProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.BlockchainMemberProvisioningState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.BlockchainMemberProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.BlockchainMemberProvisioningState NotSpecified = @"NotSpecified";

        public static Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.BlockchainMemberProvisioningState Stale = @"Stale";

        public static Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.BlockchainMemberProvisioningState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.BlockchainMemberProvisioningState Updating = @"Updating";

        /// <summary>
        /// the value for an instance of the <see cref="BlockchainMemberProvisioningState" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>
        /// Creates an instance of the <see cref="BlockchainMemberProvisioningState" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private BlockchainMemberProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to BlockchainMemberProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="BlockchainMemberProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new BlockchainMemberProvisioningState(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type BlockchainMemberProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.BlockchainMemberProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type BlockchainMemberProvisioningState (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is BlockchainMemberProvisioningState && Equals((BlockchainMemberProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum BlockchainMemberProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for BlockchainMemberProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to BlockchainMemberProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="BlockchainMemberProvisioningState" />.</param>

        public static implicit operator BlockchainMemberProvisioningState(string value)
        {
            return new BlockchainMemberProvisioningState(value);
        }

        /// <summary>Implicit operator to convert BlockchainMemberProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="BlockchainMemberProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.BlockchainMemberProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum BlockchainMemberProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.BlockchainMemberProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.BlockchainMemberProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum BlockchainMemberProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.BlockchainMemberProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.BlockchainMemberProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}
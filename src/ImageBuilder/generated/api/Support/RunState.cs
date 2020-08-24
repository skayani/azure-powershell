// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support
{

    public partial struct RunState :
        System.IEquatable<RunState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunState Canceled = @"Canceled";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunState Canceling = @"Canceling";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunState PartiallySucceeded = @"PartiallySucceeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunState Running = @"Running";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunState Succeeded = @"Succeeded";

        /// <summary>the value for an instance of the <see cref="RunState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to RunState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RunState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new RunState(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type RunState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type RunState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is RunState && Equals((RunState)obj);
        }

        /// <summary>Returns hashCode for enum RunState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="RunState" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private RunState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for RunState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to RunState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RunState" />.</param>

        public static implicit operator RunState(string value)
        {
            return new RunState(value);
        }

        /// <summary>Implicit operator to convert RunState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="RunState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum RunState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunState e1, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum RunState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunState e1, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.RunState e2)
        {
            return e2.Equals(e1);
        }
    }
}
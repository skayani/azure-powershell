﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models
{
    using Microsoft.Azure.Management.ManagedServices.Models;
    using Microsoft.WindowsAzure.Commands.Common.Attributes;
    using System.Management.Automation.Language;

    public class PSGetRegistrationAssignment : PSRegistrationAssignment
    {
        [Ps1Xml(Label = "Scope", Target = ViewControl.Table, Position = 2)]
        public string Scope { get; set; }

        public PSGetRegistrationAssignment(RegistrationAssignment registrationAssignment, string scope) : base(registrationAssignment)
        {
            if (registrationAssignment != null)
            {
                this.Id = registrationAssignment.Id;
                this.Name = registrationAssignment.Name;
                this.Type = registrationAssignment.Type;
                this.Properties = new PSRegistrationAssignmentProperties(registrationAssignment.Properties);
                this.Scope = scope;
            }
        }
    }
}

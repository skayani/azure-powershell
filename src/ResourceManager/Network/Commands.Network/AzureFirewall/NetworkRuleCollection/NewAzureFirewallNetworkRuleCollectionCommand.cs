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

using System;
using System.Collections.Generic;
using System.Management.Automation;
using Microsoft.Azure.Commands.Network.Models;
using MNM = Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Commands.Network
{

    [Cmdlet(VerbsCommon.New, "AzureRmFirewallNetworkRuleCollection", SupportsShouldProcess = true), OutputType(typeof(PSAzureFirewallNetworkRuleCollection))]
    public class NewAzureFirewallNetworkRuleCollectionCommand : NetworkBaseCmdlet
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "The name of the Network Rule Collection")]
        [ValidateNotNullOrEmpty]
        public virtual string Name { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "The priority of the rule collection")]
        [ValidateNotNullOrEmpty]
        public uint Priority { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "The list of network rules")]
        [ValidateNotNullOrEmpty]
        public List<PSAzureFirewallNetworkRule> Rule { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "The type of the rule action")]
        [ValidateNotNullOrEmpty]
        [ValidateSet(
            MNM.AzureFirewallRCActionType.Allow,
            MNM.AzureFirewallRCActionType.Deny,
            IgnoreCase = false)]
        public string ActionType { get; set; }

        public override void Execute()
        {
            base.Execute();

            if (this.Priority < 100 || this.Priority > 65000)
            {
                throw new ArgumentException("Rule collection priority should be set to a value between 100 and 65000.");
            }

            if (this.Rule == null || this.Rule.Count == 0)
            {
                throw new ArgumentException("At least one application rule should be specified!");
            }

            var networkRuleCollection = new PSAzureFirewallNetworkRuleCollection
            {
                Name = this.Name,
                Priority = this.Priority,
                Rules = this.Rule,
                Action = new PSAzureFirewallRCAction { Type = ActionType }
            };

            WriteObject(networkRuleCollection);
        }
    }
}

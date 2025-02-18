﻿// ----------------------------------------------------------------------------------
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

namespace Microsoft.Azure.Commands.Cdn.Common
{
    public static class AfdResourceConstants
    {
        public const int AfdEndpointOriginResponseTimeoutSecondsMin = 16;
        public const string AfdResourceLocation = "Global";
    }

    public static class AfdResourceProcessMessage
    {
        public const string AfdCustomDomainCreateMessage = "Creating the Azure Front Door custom domain.";
        public const string AfdCustomDomainDeleteMessage = "Deleting the Azure Front Door custom domain.";
        public const string AfdEndpointCreateMessage = "Creating the Azure Front Door endpoint.";
        public const string AfdEndpointDeleteMessage = "Deleting the Azure Front Door endpoint";
        public const string AfdEndpointUpdateMessage = "Updating the Azure Front Door endpoint.";
        public const string AfdOriginCreateMessage = "Creating the Azure Front Door origin.";
        public const string AfdOriginDeleteMessage = "Deleting the Azure Front Door origin.";
        public const string AfdOriginUpdateMessage = "Updating the Azure Front Door origin.";
        public const string AfdOriginGroupCreateMessage = "Creating the Azure Front Door origin group.";
        public const string AfdOriginGroupDeleteMessage = "Deleting the Azure Front Door origin group.";
        public const string AfdOriginGroupUpdateMessage = "Updating the Azure Front Door origin group.";
        public const string AfdProfileCreateMessage = "Creating the Azure Front Door profile.";
        public const string AfdProfileDeleteMessage = "Deleting the Azure Front Door profile.";
        public const string AfdProfileUpdateMessage = "Updating the Azure Front Door profile.";
        public const string AfdRouteCreateMessage = "Creating the Azure Front Door route.";
        public const string AfdRouteDeleteMessage = "Deleting the Azure Front Door route.";
        public const string AfdRouteUpdateMessage = "Updating the Azure Front Door route.";
        public const string AfdRuleCreateMessage = "Creating the Azure Front Door rule.";
        public const string AfdRuleDeleteMessage = "Deleting the Azure Front Door rule.";
        public const string AfdRuleSetCreateMessage = "Creating the Azure Front Door rule set.";
        public const string AfdRuleSetDeleteMessage = "Deleting the Azure Front Door rule set.";
        public const string AfdSecurityPolicyCreateMessage = "Creating the Azure Front Door security policy.";
        public const string AfdSecurityPolicyDeleteMessage = "Deleting the Azure Front Door security policy.";
        public const string AfdSecurityPolicyUpdateMessage = "Updating the Azure Front Door security policy.";
    }

    public static class AfdSkuConstants
    {
        public const string PremiumAzureFrontDoor = "Premium_AzureFrontDoor";
        public const string StandardAzureFrontDoor = "Standard_AzureFrontDoor";
    }

    public static class HelpMessageConstants
    {
        public const string AfdCustomDomainHostName = "The host name of the domain. Must be a domain name.";
        public const string AfdCustomDomainIds = "The resource ids of the Azure Front Door custom domains.";
        public const string AfdCustomDomainName = "The Azure Front Door custom domain name.";
        public const string AfdCustomDomainObject = "The Azure Front Door custom domain object.";
        public const string AfdEndpointObject = "The Azure Front Door endpoint object.";
        public const string AfdEndpointOriginResponseTimeoutSeconds = "The send and receive timeout on forwarding request to origin.";
        public const string AfdEndpointName = "The Azure Front Door endpoint name.";
        public const string AfdOriginGroupAdditionalLatencyInMilliseconds = "The additional latency in milliseconds for probes to fall into the lowest latency bucket.";
        public const string AfdOriginHostHeader = "The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value.";
        public const string AfdOriginHostName = "The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across all origins in an endpoint.";
        public const string AfdOriginHttpPort = "The value of the HTTP port. Must be between 1 and 65535.";
        public const string AfdOriginHttpsPort = "The value of the HTTPS port. Must be between 1 and 65535.";
        public const string AfdOriginGroupId = "The resource id of the Azure Front Door origin group.";
        public const string AfdOriginGroupName = "The Azure Front Door origin group name.";
        public const string AfdOriginGroupObject = "The Azure Front Door origin group object.";
        public const string AfdOriginGroupProbeIntervalInSeconds = "The number of seconds between health probes.";
        public const string AfdOriginGroupProbePath = "The path relative to the origin that is used to determine the health of the origin.";
        public const string AfdOriginGroupProbeProtocol = "Protocol to use for health probe.";
        public const string AfdOriginGroupProbeRequestType = "The type of health probe request that is made.";
        public const string AfdOriginGroupSampleSize = "The number of samples to consider for load balancing decisions.";
        public const string AfdOriginGroupSuccessfulSamplesRequired = "The number of samples within the sample period that must succeed.";
        public const string AfdOriginGroupTrafficRestorationTimeToHealedOrNewEndpointsInMinutes = "Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint is added.";
        public const string AfdOriginName = "The Azure Front Door origin name.";
        public const string AfdOriginObject = "The Azure Front Door origin object.";
        public const string AfdOriginPriority = "Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if any lower priority origin is healthy.";
        public const string AfdOriginPrivateLinkId = "The Azure resource id of the shared private link resource.";
        public const string AfdOriginPrivateLinkLocation = "The location of the shared private link resource.";
        public const string AfdOriginPrivateLinkRequestMessage = "The request message for requesting approval of the shared private link resource.";
        public const string AfdOriginWeight = "Weight of the origin in given origin group for load balancing.";
        public const string AfdProfileName = "The Azure Front Door profile name.";
        public const string AfdProfileSku = "The Azure Front Door profile SKU.";
        public const string AfdProfileObject = "The Azure Front Door profile object.";
        public const string AfdRouteForwardingProtocol = "Protocol this rule will use when forwarding traffic to backends.";
        public const string AfdRouteHttpsRedirect = "Whether to automatically redirect HTTP traffic to HTTPS traffic.";
        public const string AfdRouteName = "The Azure Front Door route name.";
        public const string AfdRouteObject = "The Azure Front Door route object.";
        public const string AfdRouteOriginPath = "A directory path on the origin that Azure Front Door can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.";
        public const string AfdRouteQueryStringCachingBehavior = "Defines how Azure Front Door caches requests that include query strings.";
        public const string AfdRouteSupportedProtocols = "List of supported protocols for this route.";
        public const string AfdRuleBypassCache = "Sets the caching behavior to Bypass caching. This prevents requests that contain query strings from being cached.";
        public const string AfdRuleCacheDuration = "The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss";
        public const string AfdRuleCacheExpirationActionObject = "The cache expiration rule action object.";
        public const string AfdRuleMatchProcessingBehavior = "If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults to Continue.";
        public const string AfdRuleName = "The Azure Front Door rule name.";
        public const string AfdRuleObject = "The Azure Front Door rule object.";
        public const string AfdRuleOverride = "Sets the caching behavior to Override.";
        public const string AfdRuleOrder = "The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will be applied before a rule with a greater order.";
        public const string AfdRuleSetIds = "The resource ids of the Azure Front Door rule sets.";
        public const string AfdRuleSetIfMissing = "Sets the caching behavior to SetIfMissing.";
        public const string AfdRuleSetName = "The Azure Front Door rule set name.";
        public const string AfdRuleSetObject = "The Azure Front Door rule set object.";
        public const string AfdSecurityPolicyDomainIds = "The resource ids of the domains which will be linked to the Azure Front Door web application firewall.";
        public const string AfdSecurityPolicyObject = "The Azure Front Door security policy object.";
        public const string AfdSecurityPolicyName = "The Azure Front Door security policy name.";
        public const string AfdSecurityPolicyWafPolicyId = "The resource id of the Azure Front Door web application firewall.";
        public const string PassThruParameter = "Set by the user to signal that they would like to receive output from a cmdlet which does not return anything.";
        public const string ResourceId = "The Azure resource id.";
        public const string ResourceGroupName = "The Azure resource group name.";
        public const string TagsDescription = "The tags associated to the Azure resource.";
    }

    public static class AfdParameterSet 
    {
        public const string AfdRuleBypassCache = "AfdRuleBypassCache";
        public const string AfdRuleOverride = "AfdRuleOverride";
        public const string AfdRuleSetIfMissing = "AfdRuleSetIfMissing";
        public const string SharedPrivateLinkResource = "SharedPrivateLinkResource";
    }
}

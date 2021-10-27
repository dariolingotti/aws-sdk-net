/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyFleet Request Marshaller
    /// </summary>       
    public class ModifyFleetRequestMarshaller : IMarshaller<IRequest, ModifyFleetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyFleetRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyFleet");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetContext())
                {
                    request.Parameters.Add("Context", StringUtils.FromString(publicRequest.Context));
                }
                if(publicRequest.IsSetExcessCapacityTerminationPolicy())
                {
                    request.Parameters.Add("ExcessCapacityTerminationPolicy", StringUtils.FromString(publicRequest.ExcessCapacityTerminationPolicy));
                }
                if(publicRequest.IsSetFleetId())
                {
                    request.Parameters.Add("FleetId", StringUtils.FromString(publicRequest.FleetId));
                }
                if(publicRequest.IsSetLaunchTemplateConfigs())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.LaunchTemplateConfigs)
                    {
                        if(publicRequestlistValue.IsSetLaunchTemplateSpecification())
                        {
                            if(publicRequestlistValue.LaunchTemplateSpecification.IsSetLaunchTemplateId())
                            {
                                request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateId", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.LaunchTemplateId));
                            }
                            if(publicRequestlistValue.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                            {
                                request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateName", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.LaunchTemplateName));
                            }
                            if(publicRequestlistValue.LaunchTemplateSpecification.IsSetVersion())
                            {
                                request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "Version", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.Version));
                            }
                        }
                        if(publicRequestlistValue.IsSetOverrides())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Overrides)
                            {
                                if(publicRequestlistValuelistValue.IsSetAvailabilityZone())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "AvailabilityZone", StringUtils.FromString(publicRequestlistValuelistValue.AvailabilityZone));
                                }
                                if(publicRequestlistValuelistValue.IsSetInstanceRequirements())
                                {
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorCount())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorCount.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorCount.Max));
                                        }
                                        if(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorCount.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorCount.Min));
                                        }
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorManufacturers())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.AcceleratorManufacturers)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorManufacturer" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorNames())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.AcceleratorNames)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorName" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Max));
                                        }
                                        if(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Min));
                                        }
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorTypes())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTypes)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorType" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetBareMetal())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BareMetal", StringUtils.FromString(publicRequestlistValuelistValue.InstanceRequirements.BareMetal));
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Max));
                                        }
                                        if(publicRequestlistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Min));
                                        }
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetBurstablePerformance())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BurstablePerformance", StringUtils.FromString(publicRequestlistValuelistValue.InstanceRequirements.BurstablePerformance));
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetCpuManufacturers())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.CpuManufacturers)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "CpuManufacturer" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetExcludedInstanceTypes())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.ExcludedInstanceTypes)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "ExcludedInstanceType" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetInstanceGenerations())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.InstanceGenerations)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "InstanceGeneration" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetLocalStorage())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorage", StringUtils.FromString(publicRequestlistValuelistValue.InstanceRequirements.LocalStorage));
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetLocalStorageTypes())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.LocalStorageTypes)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorageType" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Max", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.Max));
                                        }
                                        if(publicRequestlistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Min", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.Min));
                                        }
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetMemoryMiB())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.MemoryMiB.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.MemoryMiB.Max));
                                        }
                                        if(publicRequestlistValuelistValue.InstanceRequirements.MemoryMiB.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.MemoryMiB.Min));
                                        }
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetNetworkInterfaceCount())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.NetworkInterfaceCount.Max));
                                        }
                                        if(publicRequestlistValuelistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.NetworkInterfaceCount.Min));
                                        }
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice));
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetRequireHibernateSupport())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "RequireHibernateSupport", StringUtils.FromBool(publicRequestlistValuelistValue.InstanceRequirements.RequireHibernateSupport));
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice));
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetTotalLocalStorageGB())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Max", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.TotalLocalStorageGB.Max));
                                        }
                                        if(publicRequestlistValuelistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Min", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.TotalLocalStorageGB.Min));
                                        }
                                    }
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetVCpuCount())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.VCpuCount.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.VCpuCount.Max));
                                        }
                                        if(publicRequestlistValuelistValue.InstanceRequirements.VCpuCount.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.VCpuCount.Min));
                                        }
                                    }
                                }
                                if(publicRequestlistValuelistValue.IsSetInstanceType())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceType", StringUtils.FromString(publicRequestlistValuelistValue.InstanceType));
                                }
                                if(publicRequestlistValuelistValue.IsSetMaxPrice())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "MaxPrice", StringUtils.FromString(publicRequestlistValuelistValue.MaxPrice));
                                }
                                if(publicRequestlistValuelistValue.IsSetPlacement())
                                {
                                    if(publicRequestlistValuelistValue.Placement.IsSetAffinity())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "Affinity", StringUtils.FromString(publicRequestlistValuelistValue.Placement.Affinity));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetAvailabilityZone())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "AvailabilityZone", StringUtils.FromString(publicRequestlistValuelistValue.Placement.AvailabilityZone));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetGroupName())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "GroupName", StringUtils.FromString(publicRequestlistValuelistValue.Placement.GroupName));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetHostId())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "HostId", StringUtils.FromString(publicRequestlistValuelistValue.Placement.HostId));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetHostResourceGroupArn())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "HostResourceGroupArn", StringUtils.FromString(publicRequestlistValuelistValue.Placement.HostResourceGroupArn));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetPartitionNumber())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "PartitionNumber", StringUtils.FromInt(publicRequestlistValuelistValue.Placement.PartitionNumber));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetSpreadDomain())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "SpreadDomain", StringUtils.FromString(publicRequestlistValuelistValue.Placement.SpreadDomain));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetTenancy())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "Tenancy", StringUtils.FromString(publicRequestlistValuelistValue.Placement.Tenancy));
                                    }
                                }
                                if(publicRequestlistValuelistValue.IsSetPriority())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Priority", StringUtils.FromDouble(publicRequestlistValuelistValue.Priority));
                                }
                                if(publicRequestlistValuelistValue.IsSetSubnetId())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestlistValuelistValue.SubnetId));
                                }
                                if(publicRequestlistValuelistValue.IsSetWeightedCapacity())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "WeightedCapacity", StringUtils.FromDouble(publicRequestlistValuelistValue.WeightedCapacity));
                                }
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetTargetCapacitySpecification())
                {
                    if(publicRequest.TargetCapacitySpecification.IsSetDefaultTargetCapacityType())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "DefaultTargetCapacityType", StringUtils.FromString(publicRequest.TargetCapacitySpecification.DefaultTargetCapacityType));
                    }
                    if(publicRequest.TargetCapacitySpecification.IsSetOnDemandTargetCapacity())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "OnDemandTargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacitySpecification.OnDemandTargetCapacity));
                    }
                    if(publicRequest.TargetCapacitySpecification.IsSetSpotTargetCapacity())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "SpotTargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacitySpecification.SpotTargetCapacity));
                    }
                    if(publicRequest.TargetCapacitySpecification.IsSetTargetCapacityUnitType())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "TargetCapacityUnitType", StringUtils.FromString(publicRequest.TargetCapacitySpecification.TargetCapacityUnitType));
                    }
                    if(publicRequest.TargetCapacitySpecification.IsSetTotalTargetCapacity())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "TotalTargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacitySpecification.TotalTargetCapacity));
                    }
                }
            }
            return request;
        }
                    private static ModifyFleetRequestMarshaller _instance = new ModifyFleetRequestMarshaller();        

        internal static ModifyFleetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyFleetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
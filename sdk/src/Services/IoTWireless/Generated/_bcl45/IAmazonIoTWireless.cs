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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTWireless.Model;

namespace Amazon.IoTWireless
{
    /// <summary>
    /// Interface for accessing IoTWireless
    ///
    /// AWS IoT Wireless API documentation
    /// </summary>
    public partial interface IAmazonIoTWireless : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIoTWirelessPaginatorFactory Paginators { get; }

        
        #region  AssociateAwsAccountWithPartnerAccount


        /// <summary>
        /// Associates a partner account with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAwsAccountWithPartnerAccount service method.</param>
        /// 
        /// <returns>The response from the AssociateAwsAccountWithPartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateAwsAccountWithPartnerAccount">REST API Reference for AssociateAwsAccountWithPartnerAccount Operation</seealso>
        AssociateAwsAccountWithPartnerAccountResponse AssociateAwsAccountWithPartnerAccount(AssociateAwsAccountWithPartnerAccountRequest request);



        /// <summary>
        /// Associates a partner account with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAwsAccountWithPartnerAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAwsAccountWithPartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateAwsAccountWithPartnerAccount">REST API Reference for AssociateAwsAccountWithPartnerAccount Operation</seealso>
        Task<AssociateAwsAccountWithPartnerAccountResponse> AssociateAwsAccountWithPartnerAccountAsync(AssociateAwsAccountWithPartnerAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateMulticastGroupWithFuotaTask


        /// <summary>
        /// Associate a multicast group with a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMulticastGroupWithFuotaTask service method.</param>
        /// 
        /// <returns>The response from the AssociateMulticastGroupWithFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateMulticastGroupWithFuotaTask">REST API Reference for AssociateMulticastGroupWithFuotaTask Operation</seealso>
        AssociateMulticastGroupWithFuotaTaskResponse AssociateMulticastGroupWithFuotaTask(AssociateMulticastGroupWithFuotaTaskRequest request);



        /// <summary>
        /// Associate a multicast group with a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMulticastGroupWithFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateMulticastGroupWithFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateMulticastGroupWithFuotaTask">REST API Reference for AssociateMulticastGroupWithFuotaTask Operation</seealso>
        Task<AssociateMulticastGroupWithFuotaTaskResponse> AssociateMulticastGroupWithFuotaTaskAsync(AssociateMulticastGroupWithFuotaTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateWirelessDeviceWithFuotaTask


        /// <summary>
        /// Associate a wireless device with a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithFuotaTask service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessDeviceWithFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithFuotaTask">REST API Reference for AssociateWirelessDeviceWithFuotaTask Operation</seealso>
        AssociateWirelessDeviceWithFuotaTaskResponse AssociateWirelessDeviceWithFuotaTask(AssociateWirelessDeviceWithFuotaTaskRequest request);



        /// <summary>
        /// Associate a wireless device with a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateWirelessDeviceWithFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithFuotaTask">REST API Reference for AssociateWirelessDeviceWithFuotaTask Operation</seealso>
        Task<AssociateWirelessDeviceWithFuotaTaskResponse> AssociateWirelessDeviceWithFuotaTaskAsync(AssociateWirelessDeviceWithFuotaTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateWirelessDeviceWithMulticastGroup


        /// <summary>
        /// Associates a wireless device with a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessDeviceWithMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithMulticastGroup">REST API Reference for AssociateWirelessDeviceWithMulticastGroup Operation</seealso>
        AssociateWirelessDeviceWithMulticastGroupResponse AssociateWirelessDeviceWithMulticastGroup(AssociateWirelessDeviceWithMulticastGroupRequest request);



        /// <summary>
        /// Associates a wireless device with a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateWirelessDeviceWithMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithMulticastGroup">REST API Reference for AssociateWirelessDeviceWithMulticastGroup Operation</seealso>
        Task<AssociateWirelessDeviceWithMulticastGroupResponse> AssociateWirelessDeviceWithMulticastGroupAsync(AssociateWirelessDeviceWithMulticastGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateWirelessDeviceWithThing


        /// <summary>
        /// Associates a wireless device with a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithThing service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessDeviceWithThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithThing">REST API Reference for AssociateWirelessDeviceWithThing Operation</seealso>
        AssociateWirelessDeviceWithThingResponse AssociateWirelessDeviceWithThing(AssociateWirelessDeviceWithThingRequest request);



        /// <summary>
        /// Associates a wireless device with a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateWirelessDeviceWithThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithThing">REST API Reference for AssociateWirelessDeviceWithThing Operation</seealso>
        Task<AssociateWirelessDeviceWithThingResponse> AssociateWirelessDeviceWithThingAsync(AssociateWirelessDeviceWithThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateWirelessGatewayWithCertificate


        /// <summary>
        /// Associates a wireless gateway with a certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithCertificate service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessGatewayWithCertificate service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithCertificate">REST API Reference for AssociateWirelessGatewayWithCertificate Operation</seealso>
        AssociateWirelessGatewayWithCertificateResponse AssociateWirelessGatewayWithCertificate(AssociateWirelessGatewayWithCertificateRequest request);



        /// <summary>
        /// Associates a wireless gateway with a certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateWirelessGatewayWithCertificate service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithCertificate">REST API Reference for AssociateWirelessGatewayWithCertificate Operation</seealso>
        Task<AssociateWirelessGatewayWithCertificateResponse> AssociateWirelessGatewayWithCertificateAsync(AssociateWirelessGatewayWithCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateWirelessGatewayWithThing


        /// <summary>
        /// Associates a wireless gateway with a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithThing service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessGatewayWithThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithThing">REST API Reference for AssociateWirelessGatewayWithThing Operation</seealso>
        AssociateWirelessGatewayWithThingResponse AssociateWirelessGatewayWithThing(AssociateWirelessGatewayWithThingRequest request);



        /// <summary>
        /// Associates a wireless gateway with a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateWirelessGatewayWithThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithThing">REST API Reference for AssociateWirelessGatewayWithThing Operation</seealso>
        Task<AssociateWirelessGatewayWithThingResponse> AssociateWirelessGatewayWithThingAsync(AssociateWirelessGatewayWithThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelMulticastGroupSession


        /// <summary>
        /// Cancels an existing multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMulticastGroupSession service method.</param>
        /// 
        /// <returns>The response from the CancelMulticastGroupSession service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CancelMulticastGroupSession">REST API Reference for CancelMulticastGroupSession Operation</seealso>
        CancelMulticastGroupSessionResponse CancelMulticastGroupSession(CancelMulticastGroupSessionRequest request);



        /// <summary>
        /// Cancels an existing multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMulticastGroupSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelMulticastGroupSession service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CancelMulticastGroupSession">REST API Reference for CancelMulticastGroupSession Operation</seealso>
        Task<CancelMulticastGroupSessionResponse> CancelMulticastGroupSessionAsync(CancelMulticastGroupSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDestination


        /// <summary>
        /// Creates a new destination that maps a device message to an AWS IoT rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDestination service method.</param>
        /// 
        /// <returns>The response from the CreateDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        CreateDestinationResponse CreateDestination(CreateDestinationRequest request);



        /// <summary>
        /// Creates a new destination that maps a device message to an AWS IoT rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        Task<CreateDestinationResponse> CreateDestinationAsync(CreateDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDeviceProfile


        /// <summary>
        /// Creates a new device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateDeviceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDeviceProfile">REST API Reference for CreateDeviceProfile Operation</seealso>
        CreateDeviceProfileResponse CreateDeviceProfile(CreateDeviceProfileRequest request);



        /// <summary>
        /// Creates a new device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeviceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDeviceProfile">REST API Reference for CreateDeviceProfile Operation</seealso>
        Task<CreateDeviceProfileResponse> CreateDeviceProfileAsync(CreateDeviceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFuotaTask


        /// <summary>
        /// Creates a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFuotaTask service method.</param>
        /// 
        /// <returns>The response from the CreateFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateFuotaTask">REST API Reference for CreateFuotaTask Operation</seealso>
        CreateFuotaTaskResponse CreateFuotaTask(CreateFuotaTaskRequest request);



        /// <summary>
        /// Creates a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateFuotaTask">REST API Reference for CreateFuotaTask Operation</seealso>
        Task<CreateFuotaTaskResponse> CreateFuotaTaskAsync(CreateFuotaTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateMulticastGroup


        /// <summary>
        /// Creates a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the CreateMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateMulticastGroup">REST API Reference for CreateMulticastGroup Operation</seealso>
        CreateMulticastGroupResponse CreateMulticastGroup(CreateMulticastGroupRequest request);



        /// <summary>
        /// Creates a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateMulticastGroup">REST API Reference for CreateMulticastGroup Operation</seealso>
        Task<CreateMulticastGroupResponse> CreateMulticastGroupAsync(CreateMulticastGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateServiceProfile


        /// <summary>
        /// Creates a new service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateServiceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateServiceProfile">REST API Reference for CreateServiceProfile Operation</seealso>
        CreateServiceProfileResponse CreateServiceProfile(CreateServiceProfileRequest request);



        /// <summary>
        /// Creates a new service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateServiceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateServiceProfile">REST API Reference for CreateServiceProfile Operation</seealso>
        Task<CreateServiceProfileResponse> CreateServiceProfileAsync(CreateServiceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWirelessDevice


        /// <summary>
        /// Provisions a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the CreateWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessDevice">REST API Reference for CreateWirelessDevice Operation</seealso>
        CreateWirelessDeviceResponse CreateWirelessDevice(CreateWirelessDeviceRequest request);



        /// <summary>
        /// Provisions a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessDevice">REST API Reference for CreateWirelessDevice Operation</seealso>
        Task<CreateWirelessDeviceResponse> CreateWirelessDeviceAsync(CreateWirelessDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWirelessGateway


        /// <summary>
        /// Provisions a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGateway service method.</param>
        /// 
        /// <returns>The response from the CreateWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGateway">REST API Reference for CreateWirelessGateway Operation</seealso>
        CreateWirelessGatewayResponse CreateWirelessGateway(CreateWirelessGatewayRequest request);



        /// <summary>
        /// Provisions a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGateway">REST API Reference for CreateWirelessGateway Operation</seealso>
        Task<CreateWirelessGatewayResponse> CreateWirelessGatewayAsync(CreateWirelessGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWirelessGatewayTask


        /// <summary>
        /// Creates a task for a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTask service method.</param>
        /// 
        /// <returns>The response from the CreateWirelessGatewayTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTask">REST API Reference for CreateWirelessGatewayTask Operation</seealso>
        CreateWirelessGatewayTaskResponse CreateWirelessGatewayTask(CreateWirelessGatewayTaskRequest request);



        /// <summary>
        /// Creates a task for a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWirelessGatewayTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTask">REST API Reference for CreateWirelessGatewayTask Operation</seealso>
        Task<CreateWirelessGatewayTaskResponse> CreateWirelessGatewayTaskAsync(CreateWirelessGatewayTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWirelessGatewayTaskDefinition


        /// <summary>
        /// Creates a gateway task definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateWirelessGatewayTaskDefinition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTaskDefinition">REST API Reference for CreateWirelessGatewayTaskDefinition Operation</seealso>
        CreateWirelessGatewayTaskDefinitionResponse CreateWirelessGatewayTaskDefinition(CreateWirelessGatewayTaskDefinitionRequest request);



        /// <summary>
        /// Creates a gateway task definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTaskDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWirelessGatewayTaskDefinition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTaskDefinition">REST API Reference for CreateWirelessGatewayTaskDefinition Operation</seealso>
        Task<CreateWirelessGatewayTaskDefinitionResponse> CreateWirelessGatewayTaskDefinitionAsync(CreateWirelessGatewayTaskDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDestination


        /// <summary>
        /// Deletes a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        DeleteDestinationResponse DeleteDestination(DeleteDestinationRequest request);



        /// <summary>
        /// Deletes a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        Task<DeleteDestinationResponse> DeleteDestinationAsync(DeleteDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDeviceProfile


        /// <summary>
        /// Deletes a device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteDeviceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDeviceProfile">REST API Reference for DeleteDeviceProfile Operation</seealso>
        DeleteDeviceProfileResponse DeleteDeviceProfile(DeleteDeviceProfileRequest request);



        /// <summary>
        /// Deletes a device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeviceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDeviceProfile">REST API Reference for DeleteDeviceProfile Operation</seealso>
        Task<DeleteDeviceProfileResponse> DeleteDeviceProfileAsync(DeleteDeviceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFuotaTask


        /// <summary>
        /// Deletes a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFuotaTask service method.</param>
        /// 
        /// <returns>The response from the DeleteFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteFuotaTask">REST API Reference for DeleteFuotaTask Operation</seealso>
        DeleteFuotaTaskResponse DeleteFuotaTask(DeleteFuotaTaskRequest request);



        /// <summary>
        /// Deletes a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteFuotaTask">REST API Reference for DeleteFuotaTask Operation</seealso>
        Task<DeleteFuotaTaskResponse> DeleteFuotaTaskAsync(DeleteFuotaTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMulticastGroup


        /// <summary>
        /// Deletes a multicast group if it is not in use by a fuota task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteMulticastGroup">REST API Reference for DeleteMulticastGroup Operation</seealso>
        DeleteMulticastGroupResponse DeleteMulticastGroup(DeleteMulticastGroupRequest request);



        /// <summary>
        /// Deletes a multicast group if it is not in use by a fuota task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteMulticastGroup">REST API Reference for DeleteMulticastGroup Operation</seealso>
        Task<DeleteMulticastGroupResponse> DeleteMulticastGroupAsync(DeleteMulticastGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteServiceProfile


        /// <summary>
        /// Deletes a service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteServiceProfile">REST API Reference for DeleteServiceProfile Operation</seealso>
        DeleteServiceProfileResponse DeleteServiceProfile(DeleteServiceProfileRequest request);



        /// <summary>
        /// Deletes a service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServiceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteServiceProfile">REST API Reference for DeleteServiceProfile Operation</seealso>
        Task<DeleteServiceProfileResponse> DeleteServiceProfileAsync(DeleteServiceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWirelessDevice


        /// <summary>
        /// Deletes a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessDevice">REST API Reference for DeleteWirelessDevice Operation</seealso>
        DeleteWirelessDeviceResponse DeleteWirelessDevice(DeleteWirelessDeviceRequest request);



        /// <summary>
        /// Deletes a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessDevice">REST API Reference for DeleteWirelessDevice Operation</seealso>
        Task<DeleteWirelessDeviceResponse> DeleteWirelessDeviceAsync(DeleteWirelessDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWirelessGateway


        /// <summary>
        /// Deletes a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGateway">REST API Reference for DeleteWirelessGateway Operation</seealso>
        DeleteWirelessGatewayResponse DeleteWirelessGateway(DeleteWirelessGatewayRequest request);



        /// <summary>
        /// Deletes a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGateway">REST API Reference for DeleteWirelessGateway Operation</seealso>
        Task<DeleteWirelessGatewayResponse> DeleteWirelessGatewayAsync(DeleteWirelessGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWirelessGatewayTask


        /// <summary>
        /// Deletes a wireless gateway task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTask service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessGatewayTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTask">REST API Reference for DeleteWirelessGatewayTask Operation</seealso>
        DeleteWirelessGatewayTaskResponse DeleteWirelessGatewayTask(DeleteWirelessGatewayTaskRequest request);



        /// <summary>
        /// Deletes a wireless gateway task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWirelessGatewayTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTask">REST API Reference for DeleteWirelessGatewayTask Operation</seealso>
        Task<DeleteWirelessGatewayTaskResponse> DeleteWirelessGatewayTaskAsync(DeleteWirelessGatewayTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWirelessGatewayTaskDefinition


        /// <summary>
        /// Deletes a wireless gateway task definition. Deleting this task definition does not
        /// affect tasks that are currently in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessGatewayTaskDefinition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTaskDefinition">REST API Reference for DeleteWirelessGatewayTaskDefinition Operation</seealso>
        DeleteWirelessGatewayTaskDefinitionResponse DeleteWirelessGatewayTaskDefinition(DeleteWirelessGatewayTaskDefinitionRequest request);



        /// <summary>
        /// Deletes a wireless gateway task definition. Deleting this task definition does not
        /// affect tasks that are currently in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTaskDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWirelessGatewayTaskDefinition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTaskDefinition">REST API Reference for DeleteWirelessGatewayTaskDefinition Operation</seealso>
        Task<DeleteWirelessGatewayTaskDefinitionResponse> DeleteWirelessGatewayTaskDefinitionAsync(DeleteWirelessGatewayTaskDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateAwsAccountFromPartnerAccount


        /// <summary>
        /// Disassociates your AWS account from a partner account. If <code>PartnerAccountId</code>
        /// and <code>PartnerType</code> are <code>null</code>, disassociates your AWS account
        /// from all partner accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAwsAccountFromPartnerAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateAwsAccountFromPartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateAwsAccountFromPartnerAccount">REST API Reference for DisassociateAwsAccountFromPartnerAccount Operation</seealso>
        DisassociateAwsAccountFromPartnerAccountResponse DisassociateAwsAccountFromPartnerAccount(DisassociateAwsAccountFromPartnerAccountRequest request);



        /// <summary>
        /// Disassociates your AWS account from a partner account. If <code>PartnerAccountId</code>
        /// and <code>PartnerType</code> are <code>null</code>, disassociates your AWS account
        /// from all partner accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAwsAccountFromPartnerAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateAwsAccountFromPartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateAwsAccountFromPartnerAccount">REST API Reference for DisassociateAwsAccountFromPartnerAccount Operation</seealso>
        Task<DisassociateAwsAccountFromPartnerAccountResponse> DisassociateAwsAccountFromPartnerAccountAsync(DisassociateAwsAccountFromPartnerAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateMulticastGroupFromFuotaTask


        /// <summary>
        /// Disassociates a multicast group from a fuota task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMulticastGroupFromFuotaTask service method.</param>
        /// 
        /// <returns>The response from the DisassociateMulticastGroupFromFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateMulticastGroupFromFuotaTask">REST API Reference for DisassociateMulticastGroupFromFuotaTask Operation</seealso>
        DisassociateMulticastGroupFromFuotaTaskResponse DisassociateMulticastGroupFromFuotaTask(DisassociateMulticastGroupFromFuotaTaskRequest request);



        /// <summary>
        /// Disassociates a multicast group from a fuota task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMulticastGroupFromFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMulticastGroupFromFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateMulticastGroupFromFuotaTask">REST API Reference for DisassociateMulticastGroupFromFuotaTask Operation</seealso>
        Task<DisassociateMulticastGroupFromFuotaTaskResponse> DisassociateMulticastGroupFromFuotaTaskAsync(DisassociateMulticastGroupFromFuotaTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateWirelessDeviceFromFuotaTask


        /// <summary>
        /// Disassociates a wireless device from a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromFuotaTask service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessDeviceFromFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromFuotaTask">REST API Reference for DisassociateWirelessDeviceFromFuotaTask Operation</seealso>
        DisassociateWirelessDeviceFromFuotaTaskResponse DisassociateWirelessDeviceFromFuotaTask(DisassociateWirelessDeviceFromFuotaTaskRequest request);



        /// <summary>
        /// Disassociates a wireless device from a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateWirelessDeviceFromFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromFuotaTask">REST API Reference for DisassociateWirelessDeviceFromFuotaTask Operation</seealso>
        Task<DisassociateWirelessDeviceFromFuotaTaskResponse> DisassociateWirelessDeviceFromFuotaTaskAsync(DisassociateWirelessDeviceFromFuotaTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateWirelessDeviceFromMulticastGroup


        /// <summary>
        /// Disassociates a wireless device from a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessDeviceFromMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromMulticastGroup">REST API Reference for DisassociateWirelessDeviceFromMulticastGroup Operation</seealso>
        DisassociateWirelessDeviceFromMulticastGroupResponse DisassociateWirelessDeviceFromMulticastGroup(DisassociateWirelessDeviceFromMulticastGroupRequest request);



        /// <summary>
        /// Disassociates a wireless device from a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateWirelessDeviceFromMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromMulticastGroup">REST API Reference for DisassociateWirelessDeviceFromMulticastGroup Operation</seealso>
        Task<DisassociateWirelessDeviceFromMulticastGroupResponse> DisassociateWirelessDeviceFromMulticastGroupAsync(DisassociateWirelessDeviceFromMulticastGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateWirelessDeviceFromThing


        /// <summary>
        /// Disassociates a wireless device from its currently associated thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromThing service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessDeviceFromThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromThing">REST API Reference for DisassociateWirelessDeviceFromThing Operation</seealso>
        DisassociateWirelessDeviceFromThingResponse DisassociateWirelessDeviceFromThing(DisassociateWirelessDeviceFromThingRequest request);



        /// <summary>
        /// Disassociates a wireless device from its currently associated thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateWirelessDeviceFromThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromThing">REST API Reference for DisassociateWirelessDeviceFromThing Operation</seealso>
        Task<DisassociateWirelessDeviceFromThingResponse> DisassociateWirelessDeviceFromThingAsync(DisassociateWirelessDeviceFromThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateWirelessGatewayFromCertificate


        /// <summary>
        /// Disassociates a wireless gateway from its currently associated certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromCertificate service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessGatewayFromCertificate service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromCertificate">REST API Reference for DisassociateWirelessGatewayFromCertificate Operation</seealso>
        DisassociateWirelessGatewayFromCertificateResponse DisassociateWirelessGatewayFromCertificate(DisassociateWirelessGatewayFromCertificateRequest request);



        /// <summary>
        /// Disassociates a wireless gateway from its currently associated certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateWirelessGatewayFromCertificate service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromCertificate">REST API Reference for DisassociateWirelessGatewayFromCertificate Operation</seealso>
        Task<DisassociateWirelessGatewayFromCertificateResponse> DisassociateWirelessGatewayFromCertificateAsync(DisassociateWirelessGatewayFromCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateWirelessGatewayFromThing


        /// <summary>
        /// Disassociates a wireless gateway from its currently associated thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromThing service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessGatewayFromThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromThing">REST API Reference for DisassociateWirelessGatewayFromThing Operation</seealso>
        DisassociateWirelessGatewayFromThingResponse DisassociateWirelessGatewayFromThing(DisassociateWirelessGatewayFromThingRequest request);



        /// <summary>
        /// Disassociates a wireless gateway from its currently associated thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateWirelessGatewayFromThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromThing">REST API Reference for DisassociateWirelessGatewayFromThing Operation</seealso>
        Task<DisassociateWirelessGatewayFromThingResponse> DisassociateWirelessGatewayFromThingAsync(DisassociateWirelessGatewayFromThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDestination


        /// <summary>
        /// Gets information about a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDestination service method.</param>
        /// 
        /// <returns>The response from the GetDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDestination">REST API Reference for GetDestination Operation</seealso>
        GetDestinationResponse GetDestination(GetDestinationRequest request);



        /// <summary>
        /// Gets information about a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDestination">REST API Reference for GetDestination Operation</seealso>
        Task<GetDestinationResponse> GetDestinationAsync(GetDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDeviceProfile


        /// <summary>
        /// Gets information about a device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceProfile service method.</param>
        /// 
        /// <returns>The response from the GetDeviceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDeviceProfile">REST API Reference for GetDeviceProfile Operation</seealso>
        GetDeviceProfileResponse GetDeviceProfile(GetDeviceProfileRequest request);



        /// <summary>
        /// Gets information about a device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeviceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDeviceProfile">REST API Reference for GetDeviceProfile Operation</seealso>
        Task<GetDeviceProfileResponse> GetDeviceProfileAsync(GetDeviceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFuotaTask


        /// <summary>
        /// Gets information about a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFuotaTask service method.</param>
        /// 
        /// <returns>The response from the GetFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetFuotaTask">REST API Reference for GetFuotaTask Operation</seealso>
        GetFuotaTaskResponse GetFuotaTask(GetFuotaTaskRequest request);



        /// <summary>
        /// Gets information about a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetFuotaTask">REST API Reference for GetFuotaTask Operation</seealso>
        Task<GetFuotaTaskResponse> GetFuotaTaskAsync(GetFuotaTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLogLevelsByResourceTypes


        /// <summary>
        /// Returns current default log levels or log levels by resource types. Based on resource
        /// types, log levels can be for wireless device log options or wireless gateway log options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLogLevelsByResourceTypes service method.</param>
        /// 
        /// <returns>The response from the GetLogLevelsByResourceTypes service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetLogLevelsByResourceTypes">REST API Reference for GetLogLevelsByResourceTypes Operation</seealso>
        GetLogLevelsByResourceTypesResponse GetLogLevelsByResourceTypes(GetLogLevelsByResourceTypesRequest request);



        /// <summary>
        /// Returns current default log levels or log levels by resource types. Based on resource
        /// types, log levels can be for wireless device log options or wireless gateway log options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLogLevelsByResourceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLogLevelsByResourceTypes service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetLogLevelsByResourceTypes">REST API Reference for GetLogLevelsByResourceTypes Operation</seealso>
        Task<GetLogLevelsByResourceTypesResponse> GetLogLevelsByResourceTypesAsync(GetLogLevelsByResourceTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMulticastGroup


        /// <summary>
        /// Gets information about a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the GetMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetMulticastGroup">REST API Reference for GetMulticastGroup Operation</seealso>
        GetMulticastGroupResponse GetMulticastGroup(GetMulticastGroupRequest request);



        /// <summary>
        /// Gets information about a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetMulticastGroup">REST API Reference for GetMulticastGroup Operation</seealso>
        Task<GetMulticastGroupResponse> GetMulticastGroupAsync(GetMulticastGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMulticastGroupSession


        /// <summary>
        /// Gets information about a multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMulticastGroupSession service method.</param>
        /// 
        /// <returns>The response from the GetMulticastGroupSession service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetMulticastGroupSession">REST API Reference for GetMulticastGroupSession Operation</seealso>
        GetMulticastGroupSessionResponse GetMulticastGroupSession(GetMulticastGroupSessionRequest request);



        /// <summary>
        /// Gets information about a multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMulticastGroupSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMulticastGroupSession service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetMulticastGroupSession">REST API Reference for GetMulticastGroupSession Operation</seealso>
        Task<GetMulticastGroupSessionResponse> GetMulticastGroupSessionAsync(GetMulticastGroupSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetNetworkAnalyzerConfiguration


        /// <summary>
        /// Get NetworkAnalyzer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkAnalyzerConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetNetworkAnalyzerConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetNetworkAnalyzerConfiguration">REST API Reference for GetNetworkAnalyzerConfiguration Operation</seealso>
        GetNetworkAnalyzerConfigurationResponse GetNetworkAnalyzerConfiguration(GetNetworkAnalyzerConfigurationRequest request);



        /// <summary>
        /// Get NetworkAnalyzer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkAnalyzerConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetworkAnalyzerConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetNetworkAnalyzerConfiguration">REST API Reference for GetNetworkAnalyzerConfiguration Operation</seealso>
        Task<GetNetworkAnalyzerConfigurationResponse> GetNetworkAnalyzerConfigurationAsync(GetNetworkAnalyzerConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPartnerAccount


        /// <summary>
        /// Gets information about a partner account. If <code>PartnerAccountId</code> and <code>PartnerType</code>
        /// are <code>null</code>, returns all partner accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartnerAccount service method.</param>
        /// 
        /// <returns>The response from the GetPartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPartnerAccount">REST API Reference for GetPartnerAccount Operation</seealso>
        GetPartnerAccountResponse GetPartnerAccount(GetPartnerAccountRequest request);



        /// <summary>
        /// Gets information about a partner account. If <code>PartnerAccountId</code> and <code>PartnerType</code>
        /// are <code>null</code>, returns all partner accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartnerAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPartnerAccount">REST API Reference for GetPartnerAccount Operation</seealso>
        Task<GetPartnerAccountResponse> GetPartnerAccountAsync(GetPartnerAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResourceEventConfiguration


        /// <summary>
        /// Get the event configuration for a particular resource identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceEventConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetResourceEventConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourceEventConfiguration">REST API Reference for GetResourceEventConfiguration Operation</seealso>
        GetResourceEventConfigurationResponse GetResourceEventConfiguration(GetResourceEventConfigurationRequest request);



        /// <summary>
        /// Get the event configuration for a particular resource identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceEventConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceEventConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourceEventConfiguration">REST API Reference for GetResourceEventConfiguration Operation</seealso>
        Task<GetResourceEventConfigurationResponse> GetResourceEventConfigurationAsync(GetResourceEventConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResourceLogLevel


        /// <summary>
        /// Fetches the log-level override, if any, for a given resource-ID and resource-type.
        /// It can be used for a wireless device or a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceLogLevel service method.</param>
        /// 
        /// <returns>The response from the GetResourceLogLevel service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourceLogLevel">REST API Reference for GetResourceLogLevel Operation</seealso>
        GetResourceLogLevelResponse GetResourceLogLevel(GetResourceLogLevelRequest request);



        /// <summary>
        /// Fetches the log-level override, if any, for a given resource-ID and resource-type.
        /// It can be used for a wireless device or a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceLogLevel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceLogLevel service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourceLogLevel">REST API Reference for GetResourceLogLevel Operation</seealso>
        Task<GetResourceLogLevelResponse> GetResourceLogLevelAsync(GetResourceLogLevelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetServiceEndpoint


        /// <summary>
        /// Gets the account-specific endpoint for Configuration and Update Server (CUPS) protocol
        /// or LoRaWAN Network Server (LNS) connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetServiceEndpoint service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceEndpoint">REST API Reference for GetServiceEndpoint Operation</seealso>
        GetServiceEndpointResponse GetServiceEndpoint(GetServiceEndpointRequest request);



        /// <summary>
        /// Gets the account-specific endpoint for Configuration and Update Server (CUPS) protocol
        /// or LoRaWAN Network Server (LNS) connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceEndpoint service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceEndpoint">REST API Reference for GetServiceEndpoint Operation</seealso>
        Task<GetServiceEndpointResponse> GetServiceEndpointAsync(GetServiceEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetServiceProfile


        /// <summary>
        /// Gets information about a service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceProfile service method.</param>
        /// 
        /// <returns>The response from the GetServiceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceProfile">REST API Reference for GetServiceProfile Operation</seealso>
        GetServiceProfileResponse GetServiceProfile(GetServiceProfileRequest request);



        /// <summary>
        /// Gets information about a service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceProfile">REST API Reference for GetServiceProfile Operation</seealso>
        Task<GetServiceProfileResponse> GetServiceProfileAsync(GetServiceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWirelessDevice


        /// <summary>
        /// Gets information about a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the GetWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDevice">REST API Reference for GetWirelessDevice Operation</seealso>
        GetWirelessDeviceResponse GetWirelessDevice(GetWirelessDeviceRequest request);



        /// <summary>
        /// Gets information about a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDevice">REST API Reference for GetWirelessDevice Operation</seealso>
        Task<GetWirelessDeviceResponse> GetWirelessDeviceAsync(GetWirelessDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWirelessDeviceStatistics


        /// <summary>
        /// Gets operating information about a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDeviceStatistics service method.</param>
        /// 
        /// <returns>The response from the GetWirelessDeviceStatistics service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDeviceStatistics">REST API Reference for GetWirelessDeviceStatistics Operation</seealso>
        GetWirelessDeviceStatisticsResponse GetWirelessDeviceStatistics(GetWirelessDeviceStatisticsRequest request);



        /// <summary>
        /// Gets operating information about a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDeviceStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWirelessDeviceStatistics service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDeviceStatistics">REST API Reference for GetWirelessDeviceStatistics Operation</seealso>
        Task<GetWirelessDeviceStatisticsResponse> GetWirelessDeviceStatisticsAsync(GetWirelessDeviceStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWirelessGateway


        /// <summary>
        /// Gets information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGateway service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGateway">REST API Reference for GetWirelessGateway Operation</seealso>
        GetWirelessGatewayResponse GetWirelessGateway(GetWirelessGatewayRequest request);



        /// <summary>
        /// Gets information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGateway">REST API Reference for GetWirelessGateway Operation</seealso>
        Task<GetWirelessGatewayResponse> GetWirelessGatewayAsync(GetWirelessGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWirelessGatewayCertificate


        /// <summary>
        /// Gets the ID of the certificate that is currently associated with a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayCertificate service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayCertificate service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayCertificate">REST API Reference for GetWirelessGatewayCertificate Operation</seealso>
        GetWirelessGatewayCertificateResponse GetWirelessGatewayCertificate(GetWirelessGatewayCertificateRequest request);



        /// <summary>
        /// Gets the ID of the certificate that is currently associated with a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWirelessGatewayCertificate service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayCertificate">REST API Reference for GetWirelessGatewayCertificate Operation</seealso>
        Task<GetWirelessGatewayCertificateResponse> GetWirelessGatewayCertificateAsync(GetWirelessGatewayCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWirelessGatewayFirmwareInformation


        /// <summary>
        /// Gets the firmware version and other information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayFirmwareInformation service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayFirmwareInformation service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayFirmwareInformation">REST API Reference for GetWirelessGatewayFirmwareInformation Operation</seealso>
        GetWirelessGatewayFirmwareInformationResponse GetWirelessGatewayFirmwareInformation(GetWirelessGatewayFirmwareInformationRequest request);



        /// <summary>
        /// Gets the firmware version and other information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayFirmwareInformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWirelessGatewayFirmwareInformation service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayFirmwareInformation">REST API Reference for GetWirelessGatewayFirmwareInformation Operation</seealso>
        Task<GetWirelessGatewayFirmwareInformationResponse> GetWirelessGatewayFirmwareInformationAsync(GetWirelessGatewayFirmwareInformationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWirelessGatewayStatistics


        /// <summary>
        /// Gets operating information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayStatistics service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayStatistics service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayStatistics">REST API Reference for GetWirelessGatewayStatistics Operation</seealso>
        GetWirelessGatewayStatisticsResponse GetWirelessGatewayStatistics(GetWirelessGatewayStatisticsRequest request);



        /// <summary>
        /// Gets operating information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWirelessGatewayStatistics service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayStatistics">REST API Reference for GetWirelessGatewayStatistics Operation</seealso>
        Task<GetWirelessGatewayStatisticsResponse> GetWirelessGatewayStatisticsAsync(GetWirelessGatewayStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWirelessGatewayTask


        /// <summary>
        /// Gets information about a wireless gateway task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTask service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTask">REST API Reference for GetWirelessGatewayTask Operation</seealso>
        GetWirelessGatewayTaskResponse GetWirelessGatewayTask(GetWirelessGatewayTaskRequest request);



        /// <summary>
        /// Gets information about a wireless gateway task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWirelessGatewayTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTask">REST API Reference for GetWirelessGatewayTask Operation</seealso>
        Task<GetWirelessGatewayTaskResponse> GetWirelessGatewayTaskAsync(GetWirelessGatewayTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWirelessGatewayTaskDefinition


        /// <summary>
        /// Gets information about a wireless gateway task definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayTaskDefinition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTaskDefinition">REST API Reference for GetWirelessGatewayTaskDefinition Operation</seealso>
        GetWirelessGatewayTaskDefinitionResponse GetWirelessGatewayTaskDefinition(GetWirelessGatewayTaskDefinitionRequest request);



        /// <summary>
        /// Gets information about a wireless gateway task definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTaskDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWirelessGatewayTaskDefinition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTaskDefinition">REST API Reference for GetWirelessGatewayTaskDefinition Operation</seealso>
        Task<GetWirelessGatewayTaskDefinitionResponse> GetWirelessGatewayTaskDefinitionAsync(GetWirelessGatewayTaskDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDestinations


        /// <summary>
        /// Lists the destinations registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDestinations service method.</param>
        /// 
        /// <returns>The response from the ListDestinations service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        ListDestinationsResponse ListDestinations(ListDestinationsRequest request);



        /// <summary>
        /// Lists the destinations registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDestinations service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        Task<ListDestinationsResponse> ListDestinationsAsync(ListDestinationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDeviceProfiles


        /// <summary>
        /// Lists the device profiles registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceProfiles service method.</param>
        /// 
        /// <returns>The response from the ListDeviceProfiles service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDeviceProfiles">REST API Reference for ListDeviceProfiles Operation</seealso>
        ListDeviceProfilesResponse ListDeviceProfiles(ListDeviceProfilesRequest request);



        /// <summary>
        /// Lists the device profiles registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeviceProfiles service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDeviceProfiles">REST API Reference for ListDeviceProfiles Operation</seealso>
        Task<ListDeviceProfilesResponse> ListDeviceProfilesAsync(ListDeviceProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFuotaTasks


        /// <summary>
        /// Lists the FUOTA tasks registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFuotaTasks service method.</param>
        /// 
        /// <returns>The response from the ListFuotaTasks service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListFuotaTasks">REST API Reference for ListFuotaTasks Operation</seealso>
        ListFuotaTasksResponse ListFuotaTasks(ListFuotaTasksRequest request);



        /// <summary>
        /// Lists the FUOTA tasks registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFuotaTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFuotaTasks service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListFuotaTasks">REST API Reference for ListFuotaTasks Operation</seealso>
        Task<ListFuotaTasksResponse> ListFuotaTasksAsync(ListFuotaTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMulticastGroups


        /// <summary>
        /// Lists the multicast groups registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMulticastGroups service method.</param>
        /// 
        /// <returns>The response from the ListMulticastGroups service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListMulticastGroups">REST API Reference for ListMulticastGroups Operation</seealso>
        ListMulticastGroupsResponse ListMulticastGroups(ListMulticastGroupsRequest request);



        /// <summary>
        /// Lists the multicast groups registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMulticastGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMulticastGroups service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListMulticastGroups">REST API Reference for ListMulticastGroups Operation</seealso>
        Task<ListMulticastGroupsResponse> ListMulticastGroupsAsync(ListMulticastGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMulticastGroupsByFuotaTask


        /// <summary>
        /// List all multicast groups associated with a fuota task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMulticastGroupsByFuotaTask service method.</param>
        /// 
        /// <returns>The response from the ListMulticastGroupsByFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListMulticastGroupsByFuotaTask">REST API Reference for ListMulticastGroupsByFuotaTask Operation</seealso>
        ListMulticastGroupsByFuotaTaskResponse ListMulticastGroupsByFuotaTask(ListMulticastGroupsByFuotaTaskRequest request);



        /// <summary>
        /// List all multicast groups associated with a fuota task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMulticastGroupsByFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMulticastGroupsByFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListMulticastGroupsByFuotaTask">REST API Reference for ListMulticastGroupsByFuotaTask Operation</seealso>
        Task<ListMulticastGroupsByFuotaTaskResponse> ListMulticastGroupsByFuotaTaskAsync(ListMulticastGroupsByFuotaTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPartnerAccounts


        /// <summary>
        /// Lists the partner accounts associated with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerAccounts service method.</param>
        /// 
        /// <returns>The response from the ListPartnerAccounts service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListPartnerAccounts">REST API Reference for ListPartnerAccounts Operation</seealso>
        ListPartnerAccountsResponse ListPartnerAccounts(ListPartnerAccountsRequest request);



        /// <summary>
        /// Lists the partner accounts associated with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPartnerAccounts service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListPartnerAccounts">REST API Reference for ListPartnerAccounts Operation</seealso>
        Task<ListPartnerAccountsResponse> ListPartnerAccountsAsync(ListPartnerAccountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListServiceProfiles


        /// <summary>
        /// Lists the service profiles registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceProfiles service method.</param>
        /// 
        /// <returns>The response from the ListServiceProfiles service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListServiceProfiles">REST API Reference for ListServiceProfiles Operation</seealso>
        ListServiceProfilesResponse ListServiceProfiles(ListServiceProfilesRequest request);



        /// <summary>
        /// Lists the service profiles registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceProfiles service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListServiceProfiles">REST API Reference for ListServiceProfiles Operation</seealso>
        Task<ListServiceProfilesResponse> ListServiceProfilesAsync(ListServiceProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags (metadata) you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags (metadata) you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWirelessDevices


        /// <summary>
        /// Lists the wireless devices registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessDevices service method.</param>
        /// 
        /// <returns>The response from the ListWirelessDevices service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessDevices">REST API Reference for ListWirelessDevices Operation</seealso>
        ListWirelessDevicesResponse ListWirelessDevices(ListWirelessDevicesRequest request);



        /// <summary>
        /// Lists the wireless devices registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWirelessDevices service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessDevices">REST API Reference for ListWirelessDevices Operation</seealso>
        Task<ListWirelessDevicesResponse> ListWirelessDevicesAsync(ListWirelessDevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWirelessGateways


        /// <summary>
        /// Lists the wireless gateways registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGateways service method.</param>
        /// 
        /// <returns>The response from the ListWirelessGateways service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGateways">REST API Reference for ListWirelessGateways Operation</seealso>
        ListWirelessGatewaysResponse ListWirelessGateways(ListWirelessGatewaysRequest request);



        /// <summary>
        /// Lists the wireless gateways registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWirelessGateways service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGateways">REST API Reference for ListWirelessGateways Operation</seealso>
        Task<ListWirelessGatewaysResponse> ListWirelessGatewaysAsync(ListWirelessGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWirelessGatewayTaskDefinitions


        /// <summary>
        /// List the wireless gateway tasks definitions registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGatewayTaskDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListWirelessGatewayTaskDefinitions service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGatewayTaskDefinitions">REST API Reference for ListWirelessGatewayTaskDefinitions Operation</seealso>
        ListWirelessGatewayTaskDefinitionsResponse ListWirelessGatewayTaskDefinitions(ListWirelessGatewayTaskDefinitionsRequest request);



        /// <summary>
        /// List the wireless gateway tasks definitions registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGatewayTaskDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWirelessGatewayTaskDefinitions service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGatewayTaskDefinitions">REST API Reference for ListWirelessGatewayTaskDefinitions Operation</seealso>
        Task<ListWirelessGatewayTaskDefinitionsResponse> ListWirelessGatewayTaskDefinitionsAsync(ListWirelessGatewayTaskDefinitionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutResourceLogLevel


        /// <summary>
        /// Sets the log-level override for a resource-ID and resource-type. This option can be
        /// specified for a wireless gateway or a wireless device. A limit of 200 log level override
        /// can be set per account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourceLogLevel service method.</param>
        /// 
        /// <returns>The response from the PutResourceLogLevel service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/PutResourceLogLevel">REST API Reference for PutResourceLogLevel Operation</seealso>
        PutResourceLogLevelResponse PutResourceLogLevel(PutResourceLogLevelRequest request);



        /// <summary>
        /// Sets the log-level override for a resource-ID and resource-type. This option can be
        /// specified for a wireless gateway or a wireless device. A limit of 200 log level override
        /// can be set per account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourceLogLevel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourceLogLevel service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/PutResourceLogLevel">REST API Reference for PutResourceLogLevel Operation</seealso>
        Task<PutResourceLogLevelResponse> PutResourceLogLevelAsync(PutResourceLogLevelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResetAllResourceLogLevels


        /// <summary>
        /// Removes the log-level overrides for all resources; both wireless devices and wireless
        /// gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetAllResourceLogLevels service method.</param>
        /// 
        /// <returns>The response from the ResetAllResourceLogLevels service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ResetAllResourceLogLevels">REST API Reference for ResetAllResourceLogLevels Operation</seealso>
        ResetAllResourceLogLevelsResponse ResetAllResourceLogLevels(ResetAllResourceLogLevelsRequest request);



        /// <summary>
        /// Removes the log-level overrides for all resources; both wireless devices and wireless
        /// gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetAllResourceLogLevels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetAllResourceLogLevels service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ResetAllResourceLogLevels">REST API Reference for ResetAllResourceLogLevels Operation</seealso>
        Task<ResetAllResourceLogLevelsResponse> ResetAllResourceLogLevelsAsync(ResetAllResourceLogLevelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResetResourceLogLevel


        /// <summary>
        /// Removes the log-level override, if any, for a specific resource-ID and resource-type.
        /// It can be used for a wireless device or a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetResourceLogLevel service method.</param>
        /// 
        /// <returns>The response from the ResetResourceLogLevel service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ResetResourceLogLevel">REST API Reference for ResetResourceLogLevel Operation</seealso>
        ResetResourceLogLevelResponse ResetResourceLogLevel(ResetResourceLogLevelRequest request);



        /// <summary>
        /// Removes the log-level override, if any, for a specific resource-ID and resource-type.
        /// It can be used for a wireless device or a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetResourceLogLevel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetResourceLogLevel service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ResetResourceLogLevel">REST API Reference for ResetResourceLogLevel Operation</seealso>
        Task<ResetResourceLogLevelResponse> ResetResourceLogLevelAsync(ResetResourceLogLevelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendDataToMulticastGroup


        /// <summary>
        /// Sends the specified data to a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDataToMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the SendDataToMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToMulticastGroup">REST API Reference for SendDataToMulticastGroup Operation</seealso>
        SendDataToMulticastGroupResponse SendDataToMulticastGroup(SendDataToMulticastGroupRequest request);



        /// <summary>
        /// Sends the specified data to a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDataToMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendDataToMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToMulticastGroup">REST API Reference for SendDataToMulticastGroup Operation</seealso>
        Task<SendDataToMulticastGroupResponse> SendDataToMulticastGroupAsync(SendDataToMulticastGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendDataToWirelessDevice


        /// <summary>
        /// Sends a decrypted application data frame to a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDataToWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the SendDataToWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToWirelessDevice">REST API Reference for SendDataToWirelessDevice Operation</seealso>
        SendDataToWirelessDeviceResponse SendDataToWirelessDevice(SendDataToWirelessDeviceRequest request);



        /// <summary>
        /// Sends a decrypted application data frame to a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDataToWirelessDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendDataToWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToWirelessDevice">REST API Reference for SendDataToWirelessDevice Operation</seealso>
        Task<SendDataToWirelessDeviceResponse> SendDataToWirelessDeviceAsync(SendDataToWirelessDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartBulkAssociateWirelessDeviceWithMulticastGroup


        /// <summary>
        /// Starts a bulk association of all qualifying wireless devices with a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBulkAssociateWirelessDeviceWithMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the StartBulkAssociateWirelessDeviceWithMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartBulkAssociateWirelessDeviceWithMulticastGroup">REST API Reference for StartBulkAssociateWirelessDeviceWithMulticastGroup Operation</seealso>
        StartBulkAssociateWirelessDeviceWithMulticastGroupResponse StartBulkAssociateWirelessDeviceWithMulticastGroup(StartBulkAssociateWirelessDeviceWithMulticastGroupRequest request);



        /// <summary>
        /// Starts a bulk association of all qualifying wireless devices with a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBulkAssociateWirelessDeviceWithMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartBulkAssociateWirelessDeviceWithMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartBulkAssociateWirelessDeviceWithMulticastGroup">REST API Reference for StartBulkAssociateWirelessDeviceWithMulticastGroup Operation</seealso>
        Task<StartBulkAssociateWirelessDeviceWithMulticastGroupResponse> StartBulkAssociateWirelessDeviceWithMulticastGroupAsync(StartBulkAssociateWirelessDeviceWithMulticastGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartBulkDisassociateWirelessDeviceFromMulticastGroup


        /// <summary>
        /// Starts a bulk disassociatin of all qualifying wireless devices from a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBulkDisassociateWirelessDeviceFromMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the StartBulkDisassociateWirelessDeviceFromMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartBulkDisassociateWirelessDeviceFromMulticastGroup">REST API Reference for StartBulkDisassociateWirelessDeviceFromMulticastGroup Operation</seealso>
        StartBulkDisassociateWirelessDeviceFromMulticastGroupResponse StartBulkDisassociateWirelessDeviceFromMulticastGroup(StartBulkDisassociateWirelessDeviceFromMulticastGroupRequest request);



        /// <summary>
        /// Starts a bulk disassociatin of all qualifying wireless devices from a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBulkDisassociateWirelessDeviceFromMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartBulkDisassociateWirelessDeviceFromMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartBulkDisassociateWirelessDeviceFromMulticastGroup">REST API Reference for StartBulkDisassociateWirelessDeviceFromMulticastGroup Operation</seealso>
        Task<StartBulkDisassociateWirelessDeviceFromMulticastGroupResponse> StartBulkDisassociateWirelessDeviceFromMulticastGroupAsync(StartBulkDisassociateWirelessDeviceFromMulticastGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartFuotaTask


        /// <summary>
        /// Starts a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFuotaTask service method.</param>
        /// 
        /// <returns>The response from the StartFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartFuotaTask">REST API Reference for StartFuotaTask Operation</seealso>
        StartFuotaTaskResponse StartFuotaTask(StartFuotaTaskRequest request);



        /// <summary>
        /// Starts a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartFuotaTask">REST API Reference for StartFuotaTask Operation</seealso>
        Task<StartFuotaTaskResponse> StartFuotaTaskAsync(StartFuotaTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartMulticastGroupSession


        /// <summary>
        /// Starts a multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMulticastGroupSession service method.</param>
        /// 
        /// <returns>The response from the StartMulticastGroupSession service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartMulticastGroupSession">REST API Reference for StartMulticastGroupSession Operation</seealso>
        StartMulticastGroupSessionResponse StartMulticastGroupSession(StartMulticastGroupSessionRequest request);



        /// <summary>
        /// Starts a multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMulticastGroupSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMulticastGroupSession service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartMulticastGroupSession">REST API Reference for StartMulticastGroupSession Operation</seealso>
        Task<StartMulticastGroupSessionResponse> StartMulticastGroupSessionAsync(StartMulticastGroupSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.TooManyTagsException">
        /// The request was denied because the resource can't have any more tags.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.TooManyTagsException">
        /// The request was denied because the resource can't have any more tags.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TestWirelessDevice


        /// <summary>
        /// Simulates a provisioned device by sending an uplink data payload of <code>Hello</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the TestWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TestWirelessDevice">REST API Reference for TestWirelessDevice Operation</seealso>
        TestWirelessDeviceResponse TestWirelessDevice(TestWirelessDeviceRequest request);



        /// <summary>
        /// Simulates a provisioned device by sending an uplink data payload of <code>Hello</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestWirelessDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TestWirelessDevice">REST API Reference for TestWirelessDevice Operation</seealso>
        Task<TestWirelessDeviceResponse> TestWirelessDeviceAsync(TestWirelessDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDestination


        /// <summary>
        /// Updates properties of a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        UpdateDestinationResponse UpdateDestination(UpdateDestinationRequest request);



        /// <summary>
        /// Updates properties of a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        Task<UpdateDestinationResponse> UpdateDestinationAsync(UpdateDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFuotaTask


        /// <summary>
        /// Updates properties of a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFuotaTask service method.</param>
        /// 
        /// <returns>The response from the UpdateFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateFuotaTask">REST API Reference for UpdateFuotaTask Operation</seealso>
        UpdateFuotaTaskResponse UpdateFuotaTask(UpdateFuotaTaskRequest request);



        /// <summary>
        /// Updates properties of a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFuotaTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateFuotaTask">REST API Reference for UpdateFuotaTask Operation</seealso>
        Task<UpdateFuotaTaskResponse> UpdateFuotaTaskAsync(UpdateFuotaTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLogLevelsByResourceTypes


        /// <summary>
        /// Set default log level, or log levels by resource types. This can be for wireless device
        /// log options or wireless gateways log options and is used to control the log messages
        /// that'll be displayed in CloudWatch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLogLevelsByResourceTypes service method.</param>
        /// 
        /// <returns>The response from the UpdateLogLevelsByResourceTypes service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateLogLevelsByResourceTypes">REST API Reference for UpdateLogLevelsByResourceTypes Operation</seealso>
        UpdateLogLevelsByResourceTypesResponse UpdateLogLevelsByResourceTypes(UpdateLogLevelsByResourceTypesRequest request);



        /// <summary>
        /// Set default log level, or log levels by resource types. This can be for wireless device
        /// log options or wireless gateways log options and is used to control the log messages
        /// that'll be displayed in CloudWatch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLogLevelsByResourceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLogLevelsByResourceTypes service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateLogLevelsByResourceTypes">REST API Reference for UpdateLogLevelsByResourceTypes Operation</seealso>
        Task<UpdateLogLevelsByResourceTypesResponse> UpdateLogLevelsByResourceTypesAsync(UpdateLogLevelsByResourceTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateMulticastGroup


        /// <summary>
        /// Updates properties of a multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateMulticastGroup">REST API Reference for UpdateMulticastGroup Operation</seealso>
        UpdateMulticastGroupResponse UpdateMulticastGroup(UpdateMulticastGroupRequest request);



        /// <summary>
        /// Updates properties of a multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMulticastGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateMulticastGroup">REST API Reference for UpdateMulticastGroup Operation</seealso>
        Task<UpdateMulticastGroupResponse> UpdateMulticastGroupAsync(UpdateMulticastGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateNetworkAnalyzerConfiguration


        /// <summary>
        /// Update NetworkAnalyzer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkAnalyzerConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkAnalyzerConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateNetworkAnalyzerConfiguration">REST API Reference for UpdateNetworkAnalyzerConfiguration Operation</seealso>
        UpdateNetworkAnalyzerConfigurationResponse UpdateNetworkAnalyzerConfiguration(UpdateNetworkAnalyzerConfigurationRequest request);



        /// <summary>
        /// Update NetworkAnalyzer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkAnalyzerConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNetworkAnalyzerConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateNetworkAnalyzerConfiguration">REST API Reference for UpdateNetworkAnalyzerConfiguration Operation</seealso>
        Task<UpdateNetworkAnalyzerConfigurationResponse> UpdateNetworkAnalyzerConfigurationAsync(UpdateNetworkAnalyzerConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePartnerAccount


        /// <summary>
        /// Updates properties of a partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnerAccount service method.</param>
        /// 
        /// <returns>The response from the UpdatePartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdatePartnerAccount">REST API Reference for UpdatePartnerAccount Operation</seealso>
        UpdatePartnerAccountResponse UpdatePartnerAccount(UpdatePartnerAccountRequest request);



        /// <summary>
        /// Updates properties of a partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnerAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdatePartnerAccount">REST API Reference for UpdatePartnerAccount Operation</seealso>
        Task<UpdatePartnerAccountResponse> UpdatePartnerAccountAsync(UpdatePartnerAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateResourceEventConfiguration


        /// <summary>
        /// Update the event configuration for a particular resource identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceEventConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateResourceEventConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateResourceEventConfiguration">REST API Reference for UpdateResourceEventConfiguration Operation</seealso>
        UpdateResourceEventConfigurationResponse UpdateResourceEventConfiguration(UpdateResourceEventConfigurationRequest request);



        /// <summary>
        /// Update the event configuration for a particular resource identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceEventConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResourceEventConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateResourceEventConfiguration">REST API Reference for UpdateResourceEventConfiguration Operation</seealso>
        Task<UpdateResourceEventConfigurationResponse> UpdateResourceEventConfigurationAsync(UpdateResourceEventConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateWirelessDevice


        /// <summary>
        /// Updates properties of a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the UpdateWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessDevice">REST API Reference for UpdateWirelessDevice Operation</seealso>
        UpdateWirelessDeviceResponse UpdateWirelessDevice(UpdateWirelessDeviceRequest request);



        /// <summary>
        /// Updates properties of a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessDevice">REST API Reference for UpdateWirelessDevice Operation</seealso>
        Task<UpdateWirelessDeviceResponse> UpdateWirelessDeviceAsync(UpdateWirelessDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateWirelessGateway


        /// <summary>
        /// Updates properties of a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessGateway service method.</param>
        /// 
        /// <returns>The response from the UpdateWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessGateway">REST API Reference for UpdateWirelessGateway Operation</seealso>
        UpdateWirelessGatewayResponse UpdateWirelessGateway(UpdateWirelessGatewayRequest request);



        /// <summary>
        /// Updates properties of a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessGateway">REST API Reference for UpdateWirelessGateway Operation</seealso>
        Task<UpdateWirelessGatewayResponse> UpdateWirelessGatewayAsync(UpdateWirelessGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using System.Linq.Expressions;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class WorkflowRunsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of workflow runs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static IPage<WorkflowRun> List(this IWorkflowRunsOperations operations, string resourceGroupName, string workflowName, int? top = default(int?), Expression<Func<WorkflowRunFilter, bool>> filter = default(Expression<Func<WorkflowRunFilter, bool>>))
            {
                return Task.Factory.StartNew(s => ((IWorkflowRunsOperations)s).ListAsync(resourceGroupName, workflowName, top, filter), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of workflow runs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WorkflowRun>> ListAsync( this IWorkflowRunsOperations operations, string resourceGroupName, string workflowName, int? top = default(int?), Expression<Func<WorkflowRunFilter, bool>> filter = default(Expression<Func<WorkflowRunFilter, bool>>), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<WorkflowRun>> result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workflowName, top, filter, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a workflow run.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='runName'>
            /// The workflow run name.
            /// </param>
            public static WorkflowRun Get(this IWorkflowRunsOperations operations, string resourceGroupName, string workflowName, string runName)
            {
                return Task.Factory.StartNew(s => ((IWorkflowRunsOperations)s).GetAsync(resourceGroupName, workflowName, runName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a workflow run.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='runName'>
            /// The workflow run name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkflowRun> GetAsync( this IWorkflowRunsOperations operations, string resourceGroupName, string workflowName, string runName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<WorkflowRun> result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workflowName, runName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Cancels a workflow run.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='runName'>
            /// The workflow run name.
            /// </param>
            public static void Cancel(this IWorkflowRunsOperations operations, string resourceGroupName, string workflowName, string runName)
            {
                Task.Factory.StartNew(s => ((IWorkflowRunsOperations)s).CancelAsync(resourceGroupName, workflowName, runName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels a workflow run.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='runName'>
            /// The workflow run name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CancelAsync( this IWorkflowRunsOperations operations, string resourceGroupName, string workflowName, string runName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.CancelWithHttpMessagesAsync(resourceGroupName, workflowName, runName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets a list of workflow runs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<WorkflowRun> ListNext(this IWorkflowRunsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IWorkflowRunsOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of workflow runs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WorkflowRun>> ListNextAsync( this IWorkflowRunsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<WorkflowRun>> result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
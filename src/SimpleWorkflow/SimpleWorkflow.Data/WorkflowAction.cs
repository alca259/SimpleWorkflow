using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWorkflow.Data
{
    /// <summary>
    /// Actions that a workflow can do
    /// </summary>
    public class WorkflowAction<T>
    {
        /// <summary>
        /// Database identifier
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Coded action
        /// </summary>
        public WorkflowActionType Action { get; set; }
        /// <summary>
        /// Optional user id for action
        /// </summary>
        public T UserId { get; set; }
        /// <summary>
        /// Optional group id for action
        /// </summary>
        public T GroupId { get; set; }
        /// <summary>
        /// Optional role id for action
        /// </summary>
        public T RoleId { get; set; }
    }
}

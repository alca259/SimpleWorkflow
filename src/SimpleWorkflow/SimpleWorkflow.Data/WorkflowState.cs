using System.Collections.Generic;

namespace SimpleWorkflow.Data
{
    /// <summary>
    /// State of a workflow
    /// </summary>
    public class WorkflowState
    {
        /// <summary>
        /// Database identifier
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Name of this state
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// This indicate if this is a entry point for the workflow
        /// </summary>
        public bool IsEntryPoint { get; set; }
        /// <summary>
        /// This indicate if this is a exit point for the workflow
        /// </summary>
        public bool IsExitPoint { get; set; }
        /// <summary>
        /// Actions to be taken when the state was activated
        /// </summary>
        public virtual List<WorkflowAction<string>> Actions { get; set; }
    }
}

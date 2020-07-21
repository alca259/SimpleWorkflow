using System.Collections.Generic;

namespace SimpleWorkflow.Data
{
    /// <summary>
    /// Group of states
    /// </summary>
    public class Workflow
    {
        /// <summary>
        /// Database identifier
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Name of this workflow
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Current workflow states
        /// </summary>
        public virtual List<WorkflowState> States { get; set; }
    }
}

namespace SimpleWorkflow.Data
{
    /// <summary>
    /// Link between states, may have conditions before transition is made
    /// </summary>
    public class WorkflowTransition
    {
        /// <summary>
        /// Database identifier
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Identifier of the initial state
        /// </summary>
        public long StartStateId { get; set; }
        /// <summary>
        /// Identifier of the final state
        /// </summary>
        public long EndStateId { get; set; }
        /// <summary>
        /// Initial state
        /// </summary>
        public virtual WorkflowState StartState { get; set; }
        /// <summary>
        /// Final state
        /// </summary>
        public virtual WorkflowState EndState { get; set; }
        
        // FEATURE: Conditions between transitions
    }
}

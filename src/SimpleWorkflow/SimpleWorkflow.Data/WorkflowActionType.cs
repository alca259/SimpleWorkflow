namespace SimpleWorkflow.Data
{
    /// <summary>
    /// Coded actions that a workflow can do
    /// </summary>
    public enum WorkflowActionType
    {
        SendNotification = 0,
        RequireUserValidation = 1,
        RequireGroupValidation = 2,
        RequireRoleValidation = 3
    }
}

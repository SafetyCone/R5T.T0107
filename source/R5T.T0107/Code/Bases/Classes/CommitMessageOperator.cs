using System;


namespace R5T.T0107
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class CommitMessageOperator : ICommitMessageOperator
    {
        #region Static
        
        public static CommitMessageOperator Instance { get; } = new();

        #endregion
    }
}
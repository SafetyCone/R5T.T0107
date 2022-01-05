using System;


namespace R5T.T0107
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class CommitMessage : ICommitMessage
    {
        #region Static
        
        public static CommitMessage Instance { get; } = new();

        #endregion
    }
}
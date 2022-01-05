using System;


namespace R5T.T0107
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class CommitMessageGenerator : ICommitMessageGenerator
    {
        #region Static
        
        public static CommitMessageGenerator Instance { get; } = new();

        #endregion
    }
}
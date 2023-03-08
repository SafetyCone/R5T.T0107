using System;


namespace R5T.T0107
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    [Obsolete("See R5T.Z0036.CommitMessage")]
    public class CommitMessage : ICommitMessage
    {
        #region Static
        
        public static CommitMessage Instance { get; } = new();

        #endregion
    }
}
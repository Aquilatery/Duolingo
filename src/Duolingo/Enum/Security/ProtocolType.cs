#if !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6

namespace Duolingo.Enum.Security
{
    #region ProtocolType

    /// <summary>
    /// List of supported protocol types.
    /// </summary>
    public enum ProtocolType
    {
        /// <summary>
        /// TLS - 192
        /// </summary>
        TLS,

        /// <summary>
        /// SSL3 - 48
        /// </summary>
        SSL3,

        /// <summary>
        /// TLS11 - 768
        /// </summary>
        TLS11,

        /// <summary>
        /// TLS12 - 3072
        /// </summary>
        TLS12,

        /// <summary>
        /// TLS13 - 12288
        /// </summary>
        TLS13,

        /// <summary>
        /// Default - 0
        /// </summary>
        Default
    }

    #endregion
}

#endif
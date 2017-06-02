//-----------------------------------------------------------------------------------------------------------------------
// <copyright file="VersionInfo.cs" company="Microsoft">
//      Copyright (c) Microsoft. All Rights Reserved.
//      Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
// </copyright>
// <summary>
// Common helper class to define Version Information for all Documenter assemblies
// </summary>
//-----------------------------------------------------------------------------------------------------------------------

namespace MIMConfigDocumenter
{
    /// <summary>
    /// Common helper class to define Version Information for all MIM Documenter assemblies
    /// </summary>
    internal static class VersionInfo
    {
        /// <summary>
        /// Version information for the assembly consists of the following four values:
        ///      Major Version (2)
        ///      Minor Version (YY)
        ///      Build Number (MMDD)
        ///      Revision (if any on the same day)
        /// </summary>
        internal const string Version = "1.17.0602.0";

        /// <summary>
        /// File Version information for the assembly consists of the following four values:
        ///      Major Version (2)
        ///      Minor Version (YY)
        ///      Build Number (MMDD)
        ///      Revision (if any on the same day)
        /// </summary>
        internal const string FileVersion = "1.17.0602.0";
    }
}
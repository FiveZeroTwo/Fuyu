// Copyright (c) 2018-2020, Els_kom org.
// https://github.com/Elskom/
// All rights reserved.
// license: see LICENSE for more details.

namespace Elskom.Generic.Libs
{
    using System;
    using System.IO;

    /// <summary>
    /// Zlib Memory Unpacking failure error.
    /// </summary>
    [Serializable]
    internal sealed class NotUnpackableException : IOException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotUnpackableException"/> class with no argrument.
        /// </summary>
        internal NotUnpackableException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotUnpackableException"/> class with an string argrument.
        /// </summary>
        /// <param name="s">The error string.</param>
        internal NotUnpackableException(string s)
            : base(s)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotUnpackableException"/> class with an string argrument
        /// and the exception that cuased this exception.
        /// </summary>
        /// <param name="s">The error string.</param>
        /// <param name="ex">The Exception that caused this Exception.</param>
        internal NotUnpackableException(string s, Exception ex)
            : base(s, ex)
        {
        }
    }
}

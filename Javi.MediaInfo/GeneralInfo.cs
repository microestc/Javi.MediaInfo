﻿// -----------------------------------------------------------------------
// <copyright file="InfoGeneral.cs">
// All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Javi.MediaInfo
{
    using System;

    public class GeneralInfo
    {
        public string Format { get; set; }
        public string FormatVersion { get; set; }
        public TimeSpan Duration { get; set; }
        public int OverallBitRate { get; set; } // b/s
        public string OverallBitRateAsString { get; set; }
        public DateTime EncodedDate { get; set; }
        public string WritingApplication { get; set; }
        public string WritingLibrary { get; set; }
        public int VideoStreams { get; set; }
        public int AudioStreams { get; set; }
        public int TextStreams { get; set; }
    }
}

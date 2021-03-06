﻿using System;
using System.Collections.Generic;
using System.IO;
using CheckmarxReports.CommandLineOptions;

namespace CheckmarxReports.Reports
{
    /// <summary>
    /// Convert the report results to something human readable.
    /// </summary>
    /// <typeparam name="TReportResult">
    /// The type of entries returned from the report.
    /// </typeparam>
    public interface IReportResultFormatter<TReportResult>
    {
        /// <summary>
        /// Format the report results.
        /// </summary>
        /// <param name="reportResults">
        /// The report results. This cannot be null.
        /// </param>
        /// <param name="output">
        /// The <see cref="TextWriter"/> to write the results to. This cannot be null.
        /// </param>
        /// <param name="options">
        /// The command line options. This cannot be null.
        /// </param>
        /// <param name="username">
        /// The user the report was run by. This cannot be null, empty or whitespace.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// No argument can be null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="username"/> cannot be null, empty or whitespace.
        /// </exception>
        void Format(IList<TReportResult> reportResults, TextWriter output, CheckmarxReportOptions options, string username);
    }
}

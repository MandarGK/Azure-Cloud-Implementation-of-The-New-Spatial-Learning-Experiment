﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyCloudProject.Common
{
    /// <summary>
    /// Defines the interface for experiment.
    /// </summary>
    public interface IExperiment
    {

        /// <summary>
        /// Runs the experiment.
        /// </summary>
        /// <param name="inputData">The name of the local file which contains the experiment's input data.</param>
        /// <returns>The result.</returns>
        Task<IExperimentResult> RunAsync(double minValue, double maxValue, double boostmax, double minimumoctoverlapcycles, int inputbits, int numcolumns, int expcellspercolumn, int expdutycycleperiod, int explocalareadensity, int expactivationthreshold, string filePath);


        /// <summary>
        /// Sets the details of the experiment.
        /// </summary>
        /// <param name="experimentId">The ID of the experiment.</param>
        /// <param name="experimentName">The name of the experiment.</param>
        /// <param name="experimentDescription">The description of the experiment.</param>
        void setExperimentDetails(string experimentId, string experimentName, string experimentDescription);
    }
}

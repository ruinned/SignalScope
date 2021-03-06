﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalScope
{
    class Waveform
    {
        public string WaveFormName
        { get; set; }

        public int Npoints
        { get; set; }

        public double t0
        { get; set; }

        public double dt
        { get; set; }

        /// <summary>
        /// Data.
        /// </summary>
        public List<double> Samples
        { get; set; }

        
        // *** Methods ***
        
        /// <summary>
        /// Get time by point number.
        /// Returnes Tmax = t0 + dt * Npoints if np > Npoints.
        /// </summary>
        public double t(int npoint)
        {
            return (npoint <= Npoints) ? t0 + dt * npoint : t0 + dt * Npoints;
        }
        
        /// <summary>
        /// Get point number by time.
        /// Returnes 0 if time outside the range.
        /// </summary>
        public int np(double t)
        {
            if (t < t0 || t > t0 + dt * Npoints)
                return 0;
            else
                return (int)( Math.Round((t - t0) / dt) );
        }

        /// <summary>
        /// Get sample by time in seconds.
        /// </summary>
        public double u(double t)
        {
            return Samples[np(t)];
        }
        
        /// <summary>
        /// Get sample by point number.
        /// </summary>
        public double u(int npoint)
        {
            return Samples[npoint];
        }

        /// <summary>
        /// Ctor with parameters:
        /// voltage - list of samples
        /// tstart, tend - times in seconds
        /// </summary>
        public Waveform(string name, List<double> voltage, double tstart, double tend)
        {
            // Checks:
            // - tstart < tend
            // - voltage list not empty
            if (tstart < tend && voltage.Count > 0)
            {
                WaveFormName = name;
                t0 = tstart;
                Npoints = voltage.Count;
                dt = (tend - tstart) / Npoints;

                Samples = new List<double>(voltage);
                
            }
        }
        


    // Class
    }
}

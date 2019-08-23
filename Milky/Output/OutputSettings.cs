﻿namespace Milky.Output
{
    public class OutputSettings
    {
        public string
            outputFormat = "%combo%",
            outputWithCaptureFormat = "%combo% %separator% %capture%",
            captureFormat = "%name% = %value%",
            comboCaptureSeparator = "|",
            capturesSeparator = " | ";

        public enum ResultType
        {
            Unknown,
            Invalid,
            Free,
            Hit
        }

        private static OutputSettings _classInstance;
        public static OutputSettings GetOrNewInstance()
        {
            return _classInstance ?? (_classInstance = new OutputSettings());
        }
    }
}
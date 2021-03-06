﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Rejuicer.Engine.MinificationProviders
{
    public class CssMinificationProvider : BaseStringMinificationProvider
    {
        public override string MinifyStringValue(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return "";
            }

            return Yahoo.Yui.Compressor.CssCompressor.Compress(data);
        }

        public override string GetContentType(string filename)
        {
            return "text/css";
        }
    }
}

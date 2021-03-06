﻿// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license. See license.txt file in the project root for full license information.
namespace Scriban.Parsing
{
    public class ParserOptions
    {
        public ParserOptions()
        {
            StatementDepthLimit = 100;
            Mode = ScriptMode.Default;
        }

        public int StatementDepthLimit { get; set; }

        public ScriptMode Mode { get; set; }

        public ParserOptions Clone()
        {
            return (ParserOptions)MemberwiseClone();
        }
    }
}
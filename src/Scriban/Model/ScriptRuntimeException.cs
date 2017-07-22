﻿// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license. 
// See license.txt file in the project root for full license information.
using System;
using System.Collections.Generic;
using Scriban.Helpers;
using Scriban.Parsing;

namespace Scriban.Model
{
    public class ScriptRuntimeException : Exception
    {
        public ScriptRuntimeException(SourceSpan span, string message) : base(message)
        {
            Span = span;
        }

        public ScriptRuntimeException(SourceSpan span, string message, Exception innerException) : base(message, innerException)
        {
            Span = span;
        }

        public SourceSpan Span { get;  }

        public override string ToString()
        {
            return new LogMessage(ParserMessageType.Error, Span, Message).ToString();
        }
    }

    public class ScriptParserRuntimeException : ScriptRuntimeException
    {
        public ScriptParserRuntimeException(SourceSpan span, string message, List<LogMessage> parserMessages) : this(span, message, parserMessages, null)
        {
        }

        public ScriptParserRuntimeException(SourceSpan span, string message, List<LogMessage> parserMessages, Exception innerException) : base(span, message, innerException)
        {
            if (parserMessages == null) throw new ArgumentNullException(nameof(parserMessages));
            ParserMessages = parserMessages;
        }

        public List<LogMessage> ParserMessages { get; }

        public override string ToString()
        {
            var messagesAsText = StringHelper.Join("\n", ParserMessages);

            return $"{base.ToString()} Parser messages:\n {messagesAsText}";
        }
    }
}
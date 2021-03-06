﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="JsonException.cs" company="Chromely">
//   Copyright (c) 2017-2018 Kola Oyewumi
// </copyright>
// <license>
// The authors disclaim copyright to this source code. For more details, see
// the COPYING file included with this distribution @ https://github.com/lbv/litjson
// </license>
// <note>
// Chromely project is licensed under MIT License. CefGlue, CefSharp, Winapi may have additional licensing.
//
// This is a port of LitJson to.NET Standard for Chromely.Mostly provided as-is. 
// For more info: https://github.com/lbv/litjson
// </note>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable All
namespace LitJson
{
    using System;

    /// <summary>
    /// The json exception.
    /// Base class throwed by LitJSON when a parsing error occurs.
    /// </summary>
    public class JsonException : ApplicationException
    {
        public JsonException() : base()
        {
        }

        internal JsonException(ParserToken token) :
            base(string.Format(
                    "Invalid token '{0}' in input string", token))
        {
        }

        internal JsonException(ParserToken token,
                                Exception inner_exception) :
            base(string.Format(
                    "Invalid token '{0}' in input string", token),
                inner_exception)
        {
        }

        internal JsonException(int c) :
            base(string.Format(
                    "Invalid character '{0}' in input string", (char)c))
        {
        }

        internal JsonException(int c, Exception inner_exception) :
            base(string.Format(
                    "Invalid character '{0}' in input string", (char)c),
                inner_exception)
        {
        }


        public JsonException(string message) : base(message)
        {
        }

        public JsonException(string message, Exception inner_exception) :
            base(message, inner_exception)
        {
        }
    }
}
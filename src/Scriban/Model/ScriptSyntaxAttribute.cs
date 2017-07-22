﻿// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license. 
// See license.txt file in the project root for full license information.
using System;
using System.Reflection;
using Scriban.Helpers;

namespace Scriban.Runtime
{
    public class ScriptSyntaxAttribute : Attribute
    {
        private ScriptSyntaxAttribute()
        {
        }

        public ScriptSyntaxAttribute(string name, string example)
        {
            Name = name;
            Example = example;
        }

        public string Name { get; }

        public string Example { get; }

        public static ScriptSyntaxAttribute Get(object obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            return Get(obj.GetType());
        }

        public static ScriptSyntaxAttribute Get(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));

            var attribute = type.GetTypeInfo().GetCustomAttribute<ScriptSyntaxAttribute>() ??
                            new ScriptSyntaxAttribute(type.Name, "...");
            return attribute;
        }
    }
}
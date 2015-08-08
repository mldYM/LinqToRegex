// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
    internal sealed class LazyQuantifier
        : Pattern
    {
        public LazyQuantifier()
        {
        }

        internal override void AppendTo(PatternBuilder builder)
        {
            builder.AppendLazy();
        }
    }
}
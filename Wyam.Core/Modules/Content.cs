﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wyam.Abstractions;

namespace Wyam.Core.Modules
{
    // Overwrites the existing content with the specified content
    public class Content : ContentModule
    {
        public Content(object content)
            : base(content)
        {
        }

        public Content(Func<IDocument, object> content)
            : base(content)
        {
        }

        public Content(params IModule[] modules)
            : base(modules)
        {
        }

        protected override IEnumerable<IDocument> Execute(object content, IDocument input, IExecutionContext context)
        {
            return new [] { content == null ? input : input.Clone(content.ToString()) };
        }
    }
}
﻿using Malina.DOM;
using System.Text;

namespace Malina.Parser.Tests
{
    class DOMPrinterVisitor: DepthFirstTransformer
    {
        private StringBuilder _sb = new StringBuilder();

        public string Text
        {
            get { return _sb.ToString(); }
        }

        public override void OnAliasDefinition(AliasDefinition node)
        {
            _sb.Append(node.Name);
            base.OnAliasDefinition(node);
        }
    }
}

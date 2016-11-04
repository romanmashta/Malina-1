﻿using System;
using System.Text;

namespace Malina.DOM
{
    [Serializable]
    public class Argument : Element
    {
        // Fields
        public bool IsValueArgument;
        public Alias OfAlias;

        // Methods
        public Argument()
        {
        }


        public override void Accept(IDomVisitor visitor)
        {
            visitor.OnArgument(this);
        }

        public override void Assign(Node node)
        {
            base.Assign(node);
            Argument argument = node as Argument;
            OfAlias = argument.OfAlias;
        }

        public override Node Clone()
        {
            Argument argument = new Argument();
            argument.Assign(this);
            return argument;
        }

        public override string ToString()
        {
            return new StringBuilder().Append(OfAlias.Name).Append(":").Append(Name).ToString();
        }
    }



}
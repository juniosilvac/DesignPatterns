﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Builder.Model
{
    public class HtmlElement
    {
      public string Name, Text;
      public List<HtmlElement> Elements = new List<HtmlElement>();
      private const int indentSize = 2;

      public HtmlElement()
      {          
      }

      public HtmlElement(string name, string text)
      {
          Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
          Text = text ?? throw new ArgumentNullException(paramName: nameof(text));
      }

      private string ToStringImpl(int indent)
      {
        var sb = new StringBuilder();
        var i = new string(' ', indentSize * indent);
        sb.AppendLine($"{i}<{Name}>");
        
        if(!string.IsNullOrWhiteSpace(Text))
        {
          sb.Append(new string(' ', indentSize * (indent + 1)));
          sb.AppendLine(Text);
        }

        foreach (var item in Elements)
        {
          sb.Append(item.ToStringImpl(indent + 1));         
        }
        sb.AppendLine($"{i}</{Name}>");
        return sb.ToString();
      }

      public override string ToString()
      {
        return ToStringImpl(0);
      }
    }
}

﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Castle.ActiveWriter.CodeDomExtensions
{
    public static class CodeFieldReferenceExpressionExtensions
    {
        public static CodeFieldReferenceExpression Clone(this CodeFieldReferenceExpression expression)
        {
            if (expression == null) return null;
            CodeFieldReferenceExpression e = new CodeFieldReferenceExpression();
            e.FieldName = expression.FieldName;
            e.TargetObject = expression.TargetObject.Clone();
            e.UserData.AddRange(expression.UserData);
            return e;
        }

        public static void ReplaceType(this CodeFieldReferenceExpression expression, string oldType, string newType)
        {
            if (expression == null) return;
            expression.TargetObject.ReplaceType(oldType, newType);
        }
    }
}

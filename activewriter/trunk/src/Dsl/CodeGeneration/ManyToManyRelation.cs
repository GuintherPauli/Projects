// Copyright 2006 Gokhan Altinoren - http://altinoren.com/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Altinoren.ActiveWriter
{
    using System.CodeDom;
    using CodeGeneration;
    using GeneratedCodeExtensions;

    public partial class ManyToManyRelation
    {
        public RelationType EffectiveSourceRelationType
        {
            get
            {
                return (SourceRelationType == InheritedRelationType.Inherited
                            ? Source.Model.ManyToManyRelationType
                            : SourceRelationType.GetMatchingRelationType());
            }
        }

        public RelationType EffectiveTargetRelationType
        {
            get
            {
                return (TargetRelationType == InheritedRelationType.Inherited
                            ? Source.Model.ManyToManyRelationType
                            : TargetRelationType.GetMatchingRelationType());
            }
        }

        public CodeAttributeDeclaration GetHasAndBelongsToAttributeFromSource()
        {
            var attribute = new CodeAttributeDeclaration("HasAndBelongsToMany");

            attribute.Arguments.Add(AttributeHelper.GetPrimitiveTypeAttributeArgument(Target.Name));
            if (SourceAccess != PropertyAccess.Property)
                attribute.Arguments.Add(AttributeHelper.GetNamedEnumAttributeArgument("Access", "PropertyAccess",
                                                                                      SourceAccess));
            if (SourceCache != CacheEnum.Undefined)
                attribute.Arguments.Add(AttributeHelper.GetNamedEnumAttributeArgument("Cache", "CacheEnum", SourceCache));
            if (SourceCascade != ManyRelationCascadeEnum.None)
                attribute.Arguments.Add(AttributeHelper.GetNamedEnumAttributeArgument("Cascade",
                                                                                      "ManyRelationCascadeEnum",
                                                                                      SourceCascade));
            if (!string.IsNullOrEmpty(SourceCustomAccess))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("CustomAccess", SourceCustomAccess));

            attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("ColumnRef", TargetColumn));
            attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("ColumnKey", SourceColumn));
            if (EffectiveSourceRelationType == RelationType.Map)
            {
                // TODO: Index & IndexType
            }
            if (SourceInverse)
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Inverse", SourceInverse));
            if (SourceLazy)
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Lazy", SourceLazy));
            if (!string.IsNullOrEmpty(SourceMapType))
                attribute.Arguments.Add(AttributeHelper.GetNamedTypeAttributeArgument("MapType", SourceMapType));
            if (!string.IsNullOrEmpty(SourceOrderBy))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("OrderBy", SourceOrderBy));
            if (EffectiveSourceRelationType != RelationType.Guess)
                attribute.Arguments.Add(
                    AttributeHelper.GetNamedEnumAttributeArgument("RelationType", "RelationType", EffectiveSourceRelationType));
            if (EffectiveSourceRelationType == RelationType.Set && !string.IsNullOrEmpty(SourceSort))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Sort", SourceSort));
            if (!string.IsNullOrEmpty(SourceWhere))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Where", SourceWhere));
            if (SourceNotFoundBehaviour != NotFoundBehaviour.Default)
                attribute.Arguments.Add(
                    AttributeHelper.GetNamedEnumAttributeArgument("NotFoundBehaviour", "NotFoundBehaviour",
                                                                  SourceNotFoundBehaviour));

            PopulateCommonFields(attribute);

            return attribute;
        }

        public CodeAttributeDeclaration GetHasAndBelongsToAttributeFromTarget()
        {
            var attribute = new CodeAttributeDeclaration("HasAndBelongsToMany");

            attribute.Arguments.Add(AttributeHelper.GetPrimitiveTypeAttributeArgument(Source.Name));
            if (TargetAccess != PropertyAccess.Property)
                attribute.Arguments.Add(AttributeHelper.GetNamedEnumAttributeArgument("Access", "PropertyAccess",
                                                                                      TargetAccess));
            if (TargetCache != CacheEnum.Undefined)
                attribute.Arguments.Add(AttributeHelper.GetNamedEnumAttributeArgument("Cache", "CacheEnum", TargetCache));
            if (TargetCascade != ManyRelationCascadeEnum.None)
                attribute.Arguments.Add(AttributeHelper.GetNamedEnumAttributeArgument("Cascade",
                                                                                      "ManyRelationCascadeEnum",
                                                                                      TargetCascade));
            if (!string.IsNullOrEmpty(TargetCustomAccess))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("CustomAccess", TargetCustomAccess));

            attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("ColumnRef", SourceColumn));
            attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("ColumnKey", TargetColumn));
            if (EffectiveTargetRelationType == RelationType.Map)
            {
                // TODO: Index & IndexType
            }
            if (TargetInverse)
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Inverse", TargetInverse));
            if (TargetLazy)
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Lazy", TargetLazy));
            if (!string.IsNullOrEmpty(TargetMapType))
                attribute.Arguments.Add(AttributeHelper.GetNamedTypeAttributeArgument("MapType", TargetMapType));
            if (!string.IsNullOrEmpty(TargetOrderBy))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("OrderBy", TargetOrderBy));
            if (EffectiveTargetRelationType != RelationType.Guess)
                attribute.Arguments.Add(
                    AttributeHelper.GetNamedEnumAttributeArgument("RelationType", "RelationType", EffectiveTargetRelationType));
            if (EffectiveTargetRelationType == RelationType.Set && !string.IsNullOrEmpty(TargetSort))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Sort", TargetSort));
            if (!string.IsNullOrEmpty(TargetWhere))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Where", TargetWhere));
            if (TargetNotFoundBehaviour != NotFoundBehaviour.Default)
                attribute.Arguments.Add(
                    AttributeHelper.GetNamedEnumAttributeArgument("NotFoundBehaviour", "NotFoundBehaviour",
                                                                  TargetNotFoundBehaviour));

            PopulateCommonFields(attribute);

            return attribute;
        }


        private void PopulateCommonFields(CodeAttributeDeclaration attribute)
        {
            if (!string.IsNullOrEmpty(Schema))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Schema", Schema));
            if (!string.IsNullOrEmpty(Table))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Table", Table));
        }
    }
}
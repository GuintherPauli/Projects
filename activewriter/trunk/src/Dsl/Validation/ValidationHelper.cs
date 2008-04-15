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

using System.Collections.Generic;
using Microsoft.VisualStudio.Modeling;

namespace Altinoren.ActiveWriter.Validation
{
    public static class ValidationHelper
    {
        internal static int GetPrimaryKeyCount(LinkedElementCollection<ModelProperty> properties)
        {
            return properties.FindAll(property => (property.KeyType == KeyType.PrimaryKey)).Count;
        }

        internal static int GetCompositeKeyCount(LinkedElementCollection<ModelProperty> properties)
        {
            return GetCompositeKeys(properties).Count;
        }

        internal static List<ModelProperty> GetCompositeKeys(LinkedElementCollection<ModelProperty> properties)
        {
            return properties.FindAll(property => (property.KeyType == KeyType.CompositeKey));
        }

        internal static int GetDebuggerDisplayCount(LinkedElementCollection<ModelProperty> properties)
        {
            return properties.FindAll(property => (property.DebuggerDisplay)).Count;
        }

        internal static int GetDefaultMemberCount(LinkedElementCollection<ModelProperty> properties)
        {
            return properties.FindAll(property => (property.DefaultMember)).Count;
        }
    }
}

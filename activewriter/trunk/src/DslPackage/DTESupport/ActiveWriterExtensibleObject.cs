// Copyright 2006 Gokhan Castle - http://altinoren.com/
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

namespace Castle.ActiveWriter
{
    using System.Runtime.InteropServices;

    [ComVisible(true)]
    public class ActiveWriterExtensibleObject : IActiveWriterExtensibleObject
    {
        private Model _model;

        public ActiveWriterExtensibleObject(Model model)
        {
            this._model = model;
        }

        public Model Model
        {
            get { return _model; }
        }
    }
}
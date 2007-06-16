// Copyright 2007 Castle Project - http://www.castleproject.org/
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

using System;
using System.Collections.Generic;
using System.Text;
using Castle.FlexBridge.Gateway;
using Castle.FlexBridge.Messaging.Messages;

namespace Castle.FlexBridge.Messaging.Services
{
    /// <summary>
    /// Abstract base implementation of <see cref="IService" />.
    /// </summary>
    public abstract class BaseService : IService
    {
        /// <inheritdoc />
        public abstract bool OwnsMessageType(string messageClassAlias);

        /// <inheritdoc />
        public abstract IAsyncResult BeginProcessRequest(IAMFContext context, IMessage request, AsyncCallback callback,
            object asyncState);

        /// <inheritdoc />
        public abstract IMessage EndProcessRequest(IAsyncResult asyncResult);
    }
}

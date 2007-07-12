// Copyright 2007 Jonathon Rossi - http://www.jonorossi.com/
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

namespace Castle.NVelocity.Tests.ScannerTests
{
    using NUnit.Framework;

    public abstract class ScannerTestBase
    {
        protected Scanner scanner = new Scanner();

        protected void AssertMatchToken(TokenType tokenType)
        {
            Token token = scanner.GetToken();
            CheckTokenType(token, tokenType);
        }

        protected void AssertMatchToken(TokenType tokenType, string image)
        {
            Token token = scanner.GetToken();
            CheckTokenType(token, tokenType);
            CheckImage(token, image);
        }

        protected void AssertMatchToken(TokenType tokenType, string image, Position position)
        {
            Token token = scanner.GetToken();
            CheckTokenType(token, tokenType);
            CheckImage(token, image);
            CheckPosition(token, position);
        }

        protected void AssertMatchToken(TokenType tokenType, Position position)
        {
            Token token = scanner.GetToken();
            CheckTokenType(token, tokenType);
            CheckPosition(token, position);
        }

        protected void AssertEOF()
        {
            Assert.IsTrue(scanner.GetToken() == null);
        }

        private void CheckTokenType(Token token, TokenType tokenType)
        {
            Assert.IsTrue(token.Type == tokenType,
                string.Format("Expected token: '{0}' was '{1}'", tokenType, token.Type));
        }

        private void CheckPosition(Token token, Position position)
        {
            Assert.IsNotNull(token.Position, "Position is null");
            Assert.IsTrue(token.Position.Equals(position),
                string.Format("Expected position: [{0}] was [{1}]", position, token.Position));
        }

        private void CheckImage(Token token, string image)
        {
            Assert.IsTrue(token.Image == image,
                string.Format("Expected image: '{0}' was '{1}'", image, token.Image));
        }
    }
}
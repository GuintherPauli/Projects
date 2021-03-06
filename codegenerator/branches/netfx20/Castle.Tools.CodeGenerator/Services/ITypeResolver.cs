using System;
using ICSharpCode.NRefactory.Ast;

namespace Castle.Tools.CodeGenerator.Services
{
  public interface ITypeResolver
  {
    void Clear();
    void AddTableEntry(string fullName);
    void UseNamespace(string ns);
    void UseNamespace(string ns, bool includeParents);
    void AliasNamespace(string alias, string ns);
    Type Resolve(string typeName, bool throwOnFail);
	Type Resolve(TypeReference reference, bool throwOnFail);
    string Resolve(string typeName);
    string Resolve(TypeReference reference);	
  }
}

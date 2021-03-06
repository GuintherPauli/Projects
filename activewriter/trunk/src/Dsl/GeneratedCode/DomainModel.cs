﻿#region License
//  Copyright 2004-2010 Castle Project - http:www.castleproject.org/
//  
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  
//      http:www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
// 
#endregion
using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainModel ActiveWriterDomainModel
	/// A Visual Studio 2010 addin to design domain models and to generate code
	/// decorated with ActiveRecord attributes or supported with NHibernate
	/// configuration based on the model.
	/// </summary>
	[DslDesign::DisplayNameResource("Castle.ActiveWriter.ActiveWriterDomainModel.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Castle.ActiveWriter.ActiveWriterDomainModel.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.CoreDomainModel))]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.Diagrams.CoreDesignSurfaceDomainModel))]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
	[DslModeling::DomainObjectId("3a7d8d12-f07c-4dd1-8689-f9610e7a79e1")]
	public partial class ActiveWriterDomainModel : DslModeling::DomainModel
	{
		#region Constructor, domain model Id
	
		/// <summary>
		/// ActiveWriterDomainModel domain model Id.
		/// </summary>
		public static readonly global::System.Guid DomainModelId = new global::System.Guid(0x3a7d8d12, 0xf07c, 0x4dd1, 0x86, 0x89, 0xf9, 0x61, 0x0e, 0x7a, 0x79, 0xe1);
	
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="store">Store containing the domain model.</param>
		public ActiveWriterDomainModel(DslModeling::Store store)
			: base(store, DomainModelId)
		{
			// Call the partial method to allow any required serialization setup to be done.
			InitializeSerialization(store);		
		}
		
	
		///<Summary>
		/// Defines a partial method that will be called from the constructor to
		/// allow any necessary serialization setup to be done.
		///</Summary>
		///<remarks>
		/// For a DSL created with the DSL Designer wizard, an implementation of this 
		/// method will be generated in the GeneratedCode\SerializationHelper.cs class.
		///</remarks>
		partial void InitializeSerialization(DslModeling::Store store);
	
	
		#endregion
		#region Domain model reflection
			
		/// <summary>
		/// Gets the list of generated domain model types (classes, rules, relationships).
		/// </summary>
		/// <returns>List of types.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override global::System.Type[] GetGeneratedDomainModelTypes()
		{
			return new global::System.Type[]
			{
				typeof(Model),
				typeof(ModelClass),
				typeof(ModelProperty),
				typeof(ModelElementWithAccess),
				typeof(NamedElement),
				typeof(NestedClass),
				typeof(ModelHasClass),
				typeof(ManyToOneRelation),
				typeof(ClassHasProperty),
				typeof(ManyToManyRelation),
				typeof(OneToOneRelation),
				typeof(ModelHasNestedClasses),
				typeof(NestedClassHasProperties),
				typeof(NestedClassReferencesModelClasses),
				typeof(InheritanceRelation),
				typeof(ActiveRecordMapping),
				typeof(ManyToOneConnector),
				typeof(ManyToManyConnector),
				typeof(OneToOneConnector),
				typeof(NestedConnector),
				typeof(InheritanceConnector),
				typeof(ClassShape),
				typeof(NestedClassShape),
				typeof(global::Castle.ActiveWriter.FixUpDiagram),
				typeof(global::Castle.ActiveWriter.ConnectorRolePlayerChanged),
				typeof(global::Castle.ActiveWriter.CompartmentItemAddRule),
				typeof(global::Castle.ActiveWriter.CompartmentItemDeleteRule),
				typeof(global::Castle.ActiveWriter.CompartmentItemRolePlayerChangeRule),
				typeof(global::Castle.ActiveWriter.CompartmentItemRolePlayerPositionChangeRule),
				typeof(global::Castle.ActiveWriter.CompartmentItemChangeRule),
			};
		}
		/// <summary>
		/// Gets the list of generated domain properties.
		/// </summary>
		/// <returns>List of property data.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override DomainMemberInfo[] GetGeneratedDomainProperties()
		{
			return new DomainMemberInfo[]
			{
				new DomainMemberInfo(typeof(Model), "UseNullables", Model.UseNullablesDomainPropertyId, typeof(Model.UseNullablesPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "CaseOfPrivateFields", Model.CaseOfPrivateFieldsDomainPropertyId, typeof(Model.CaseOfPrivateFieldsPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "GenerateMonoRailProject", Model.GenerateMonoRailProjectDomainPropertyId, typeof(Model.GenerateMonoRailProjectPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "MonoRailProjectName", Model.MonoRailProjectNameDomainPropertyId, typeof(Model.MonoRailProjectNamePropertyHandler)),
				new DomainMemberInfo(typeof(Model), "MonoRailProjectPath", Model.MonoRailProjectPathDomainPropertyId, typeof(Model.MonoRailProjectPathPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "MonoRailDefaultLayout", Model.MonoRailDefaultLayoutDomainPropertyId, typeof(Model.MonoRailDefaultLayoutPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "MonoRailDefaultRescue", Model.MonoRailDefaultRescueDomainPropertyId, typeof(Model.MonoRailDefaultRescuePropertyHandler)),
				new DomainMemberInfo(typeof(Model), "MonoRailViewFileExtension", Model.MonoRailViewFileExtensionDomainPropertyId, typeof(Model.MonoRailViewFileExtensionPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "UseGenerics", Model.UseGenericsDomainPropertyId, typeof(Model.UseGenericsPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "UseBaseClass", Model.UseBaseClassDomainPropertyId, typeof(Model.UseBaseClassPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "BaseClassName", Model.BaseClassNameDomainPropertyId, typeof(Model.BaseClassNamePropertyHandler)),
				new DomainMemberInfo(typeof(Model), "GeneratesDoubleDerived", Model.GeneratesDoubleDerivedDomainPropertyId, typeof(Model.GeneratesDoubleDerivedPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "DoubleDerivedNameSuffix", Model.DoubleDerivedNameSuffixDomainPropertyId, typeof(Model.DoubleDerivedNameSuffixPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "UseGeneratedCodeAttribute", Model.UseGeneratedCodeAttributeDomainPropertyId, typeof(Model.UseGeneratedCodeAttributePropertyHandler)),
				new DomainMemberInfo(typeof(Model), "Target", Model.TargetDomainPropertyId, typeof(Model.TargetPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "AssemblyPath", Model.AssemblyPathDomainPropertyId, typeof(Model.AssemblyPathPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "ActiveRecordAssemblyName", Model.ActiveRecordAssemblyNameDomainPropertyId, typeof(Model.ActiveRecordAssemblyNamePropertyHandler)),
				new DomainMemberInfo(typeof(Model), "NHibernateAssemblyName", Model.NHibernateAssemblyNameDomainPropertyId, typeof(Model.NHibernateAssemblyNamePropertyHandler)),
				new DomainMemberInfo(typeof(Model), "RelateWithActiwFile", Model.RelateWithActiwFileDomainPropertyId, typeof(Model.RelateWithActiwFilePropertyHandler)),
				new DomainMemberInfo(typeof(Model), "UseVirtualProperties", Model.UseVirtualPropertiesDomainPropertyId, typeof(Model.UseVirtualPropertiesPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "Namespace", Model.NamespaceDomainPropertyId, typeof(Model.NamespacePropertyHandler)),
				new DomainMemberInfo(typeof(Model), "AdditionalImports", Model.AdditionalImportsDomainPropertyId, typeof(Model.AdditionalImportsPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "ImplementINotifyPropertyChanged", Model.ImplementINotifyPropertyChangedDomainPropertyId, typeof(Model.ImplementINotifyPropertyChangedPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "GenerateMetaData", Model.GenerateMetaDataDomainPropertyId, typeof(Model.GenerateMetaDataPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "UseNHQG", Model.UseNHQGDomainPropertyId, typeof(Model.UseNHQGPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "NHQGExecutable", Model.NHQGExecutableDomainPropertyId, typeof(Model.NHQGExecutablePropertyHandler)),
				new DomainMemberInfo(typeof(Model), "UseGenericRelations", Model.UseGenericRelationsDomainPropertyId, typeof(Model.UseGenericRelationsPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "PropertyNameFilterExpression", Model.PropertyNameFilterExpressionDomainPropertyId, typeof(Model.PropertyNameFilterExpressionPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "InitializeIListFields", Model.InitializeIListFieldsDomainPropertyId, typeof(Model.InitializeIListFieldsPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "ImplementINotifyPropertyChanging", Model.ImplementINotifyPropertyChangingDomainPropertyId, typeof(Model.ImplementINotifyPropertyChangingPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "CollectionInterface", Model.CollectionInterfaceDomainPropertyId, typeof(Model.CollectionInterfacePropertyHandler)),
				new DomainMemberInfo(typeof(Model), "CollectionImplementation", Model.CollectionImplementationDomainPropertyId, typeof(Model.CollectionImplementationPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "ManyToManyRelationType", Model.ManyToManyRelationTypeDomainPropertyId, typeof(Model.ManyToManyRelationTypePropertyHandler)),
				new DomainMemberInfo(typeof(Model), "ManyToOneRelationType", Model.ManyToOneRelationTypeDomainPropertyId, typeof(Model.ManyToOneRelationTypePropertyHandler)),
				new DomainMemberInfo(typeof(Model), "ManyToManyCollectionIDColumnFormat", Model.ManyToManyCollectionIDColumnFormatDomainPropertyId, typeof(Model.ManyToManyCollectionIDColumnFormatPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "ManyToManyCollectionIDColumnType", Model.ManyToManyCollectionIDColumnTypeDomainPropertyId, typeof(Model.ManyToManyCollectionIDColumnTypePropertyHandler)),
				new DomainMemberInfo(typeof(Model), "ManyToManyCollectionIDGenerator", Model.ManyToManyCollectionIDGeneratorDomainPropertyId, typeof(Model.ManyToManyCollectionIDGeneratorPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "ManyToManyIUserCollectionType", Model.ManyToManyIUserCollectionTypeDomainPropertyId, typeof(Model.ManyToManyIUserCollectionTypePropertyHandler)),
				new DomainMemberInfo(typeof(Model), "ManyToOneIUserCollectionType", Model.ManyToOneIUserCollectionTypeDomainPropertyId, typeof(Model.ManyToOneIUserCollectionTypePropertyHandler)),
				new DomainMemberInfo(typeof(Model), "AutomaticAssociations", Model.AutomaticAssociationsDomainPropertyId, typeof(Model.AutomaticAssociationsPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "AutomaticAssociationCollectionImplementation", Model.AutomaticAssociationCollectionImplementationDomainPropertyId, typeof(Model.AutomaticAssociationCollectionImplementationPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "ManyToManyTableFormat", Model.ManyToManyTableFormatDomainPropertyId, typeof(Model.ManyToManyTableFormatPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "ForeignKeyFormat", Model.ForeignKeyFormatDomainPropertyId, typeof(Model.ForeignKeyFormatPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "CommonPrimaryKeyPropertyFormat", Model.CommonPrimaryKeyPropertyFormatDomainPropertyId, typeof(Model.CommonPrimaryKeyPropertyFormatPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "CommonPrimaryKeyColumnFormat", Model.CommonPrimaryKeyColumnFormatDomainPropertyId, typeof(Model.CommonPrimaryKeyColumnFormatPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "CommonPrimaryKeyColumnType", Model.CommonPrimaryKeyColumnTypeDomainPropertyId, typeof(Model.CommonPrimaryKeyColumnTypePropertyHandler)),
				new DomainMemberInfo(typeof(Model), "CommonPrimaryKeyGenerator", Model.CommonPrimaryKeyGeneratorDomainPropertyId, typeof(Model.CommonPrimaryKeyGeneratorPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "MemberTemplateFile", Model.MemberTemplateFileDomainPropertyId, typeof(Model.MemberTemplateFilePropertyHandler)),
				new DomainMemberInfo(typeof(Model), "BaseClassPropertyChangedMethod", Model.BaseClassPropertyChangedMethodDomainPropertyId, typeof(Model.BaseClassPropertyChangedMethodPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "BaseClassPropertyChangingMethod", Model.BaseClassPropertyChangingMethodDomainPropertyId, typeof(Model.BaseClassPropertyChangingMethodPropertyHandler)),
				new DomainMemberInfo(typeof(Model), "Access", Model.AccessDomainPropertyId, typeof(Model.AccessPropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "Cache", ModelClass.CacheDomainPropertyId, typeof(ModelClass.CachePropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "DiscriminatorColumn", ModelClass.DiscriminatorColumnDomainPropertyId, typeof(ModelClass.DiscriminatorColumnPropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "DiscriminatorType", ModelClass.DiscriminatorTypeDomainPropertyId, typeof(ModelClass.DiscriminatorTypePropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "DiscriminatorValue", ModelClass.DiscriminatorValueDomainPropertyId, typeof(ModelClass.DiscriminatorValuePropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "Lazy", ModelClass.LazyDomainPropertyId, typeof(ModelClass.LazyPropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "Proxy", ModelClass.ProxyDomainPropertyId, typeof(ModelClass.ProxyPropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "Schema", ModelClass.SchemaDomainPropertyId, typeof(ModelClass.SchemaPropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "Table", ModelClass.TableDomainPropertyId, typeof(ModelClass.TablePropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "Where", ModelClass.WhereDomainPropertyId, typeof(ModelClass.WherePropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "HasKeyProperty", ModelClass.HasKeyPropertyDomainPropertyId, typeof(ModelClass.HasKeyPropertyPropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "IsValidatorSet", ModelClass.IsValidatorSetDomainPropertyId, typeof(ModelClass.IsValidatorSetPropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "DynamicInsert", ModelClass.DynamicInsertDomainPropertyId, typeof(ModelClass.DynamicInsertPropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "DynamicUpdate", ModelClass.DynamicUpdateDomainPropertyId, typeof(ModelClass.DynamicUpdatePropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "Persister", ModelClass.PersisterDomainPropertyId, typeof(ModelClass.PersisterPropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "SelectBeforeUpdate", ModelClass.SelectBeforeUpdateDomainPropertyId, typeof(ModelClass.SelectBeforeUpdatePropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "Polymorphism", ModelClass.PolymorphismDomainPropertyId, typeof(ModelClass.PolymorphismPropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "Mutable", ModelClass.MutableDomainPropertyId, typeof(ModelClass.MutablePropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "BatchSize", ModelClass.BatchSizeDomainPropertyId, typeof(ModelClass.BatchSizePropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "Locking", ModelClass.LockingDomainPropertyId, typeof(ModelClass.LockingPropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "UseAutoImport", ModelClass.UseAutoImportDomainPropertyId, typeof(ModelClass.UseAutoImportPropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "BaseClassName", ModelClass.BaseClassNameDomainPropertyId, typeof(ModelClass.BaseClassNamePropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "UseGenerics", ModelClass.UseGenericsDomainPropertyId, typeof(ModelClass.UseGenericsPropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "ImplementINotifyPropertyChanged", ModelClass.ImplementINotifyPropertyChangedDomainPropertyId, typeof(ModelClass.ImplementINotifyPropertyChangedPropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "UseGenericRelations", ModelClass.UseGenericRelationsDomainPropertyId, typeof(ModelClass.UseGenericRelationsPropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "ImplementINotifyPropertyChanging", ModelClass.ImplementINotifyPropertyChangingDomainPropertyId, typeof(ModelClass.ImplementINotifyPropertyChangingPropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "Column", ModelProperty.ColumnDomainPropertyId, typeof(ModelProperty.ColumnPropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "ColumnType", ModelProperty.ColumnTypeDomainPropertyId, typeof(ModelProperty.ColumnTypePropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "CustomColumnType", ModelProperty.CustomColumnTypeDomainPropertyId, typeof(ModelProperty.CustomColumnTypePropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "CustomMemberType", ModelProperty.CustomMemberTypeDomainPropertyId, typeof(ModelProperty.CustomMemberTypePropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "Formula", ModelProperty.FormulaDomainPropertyId, typeof(ModelProperty.FormulaPropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "Insert", ModelProperty.InsertDomainPropertyId, typeof(ModelProperty.InsertPropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "Length", ModelProperty.LengthDomainPropertyId, typeof(ModelProperty.LengthPropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "NotNull", ModelProperty.NotNullDomainPropertyId, typeof(ModelProperty.NotNullPropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "Unique", ModelProperty.UniqueDomainPropertyId, typeof(ModelProperty.UniquePropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "UnsavedValue", ModelProperty.UnsavedValueDomainPropertyId, typeof(ModelProperty.UnsavedValuePropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "Update", ModelProperty.UpdateDomainPropertyId, typeof(ModelProperty.UpdatePropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "Generator", ModelProperty.GeneratorDomainPropertyId, typeof(ModelProperty.GeneratorPropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "KeyType", ModelProperty.KeyTypeDomainPropertyId, typeof(ModelProperty.KeyTypePropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "Params", ModelProperty.ParamsDomainPropertyId, typeof(ModelProperty.ParamsPropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "SequenceName", ModelProperty.SequenceNameDomainPropertyId, typeof(ModelProperty.SequenceNamePropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "Accessor", ModelProperty.AccessorDomainPropertyId, typeof(ModelProperty.AccessorPropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "CompositeKeyName", ModelProperty.CompositeKeyNameDomainPropertyId, typeof(ModelProperty.CompositeKeyNamePropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "PropertyType", ModelProperty.PropertyTypeDomainPropertyId, typeof(ModelProperty.PropertyTypePropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "DebuggerDisplay", ModelProperty.DebuggerDisplayDomainPropertyId, typeof(ModelProperty.DebuggerDisplayPropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "Validator", ModelProperty.ValidatorDomainPropertyId, typeof(ModelProperty.ValidatorPropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "UniqueKey", ModelProperty.UniqueKeyDomainPropertyId, typeof(ModelProperty.UniqueKeyPropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "Index", ModelProperty.IndexDomainPropertyId, typeof(ModelProperty.IndexPropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "SqlType", ModelProperty.SqlTypeDomainPropertyId, typeof(ModelProperty.SqlTypePropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "Check", ModelProperty.CheckDomainPropertyId, typeof(ModelProperty.CheckPropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "DefaultMember", ModelProperty.DefaultMemberDomainPropertyId, typeof(ModelProperty.DefaultMemberPropertyHandler)),
				new DomainMemberInfo(typeof(ModelProperty), "ColumnDefault", ModelProperty.ColumnDefaultDomainPropertyId, typeof(ModelProperty.ColumnDefaultPropertyHandler)),
				new DomainMemberInfo(typeof(ModelElementWithAccess), "CustomAccess", ModelElementWithAccess.CustomAccessDomainPropertyId, typeof(ModelElementWithAccess.CustomAccessPropertyHandler)),
				new DomainMemberInfo(typeof(ModelElementWithAccess), "Access", ModelElementWithAccess.AccessDomainPropertyId, typeof(ModelElementWithAccess.AccessPropertyHandler)),
				new DomainMemberInfo(typeof(NamedElement), "Name", NamedElement.NameDomainPropertyId, typeof(NamedElement.NamePropertyHandler)),
				new DomainMemberInfo(typeof(NamedElement), "Description", NamedElement.DescriptionDomainPropertyId, typeof(NamedElement.DescriptionPropertyHandler)),
				new DomainMemberInfo(typeof(NestedClass), "ImplementINotifyPropertyChanged", NestedClass.ImplementINotifyPropertyChangedDomainPropertyId, typeof(NestedClass.ImplementINotifyPropertyChangedPropertyHandler)),
				new DomainMemberInfo(typeof(NestedClass), "ImplementINotifyPropertyChanging", NestedClass.ImplementINotifyPropertyChangingDomainPropertyId, typeof(NestedClass.ImplementINotifyPropertyChangingPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetCache", ManyToOneRelation.TargetCacheDomainPropertyId, typeof(ManyToOneRelation.TargetCachePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetCascade", ManyToOneRelation.TargetCascadeDomainPropertyId, typeof(ManyToOneRelation.TargetCascadePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetColumnKey", ManyToOneRelation.TargetColumnKeyDomainPropertyId, typeof(ManyToOneRelation.TargetColumnKeyPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetCustomAccess", ManyToOneRelation.TargetCustomAccessDomainPropertyId, typeof(ManyToOneRelation.TargetCustomAccessPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetInverse", ManyToOneRelation.TargetInverseDomainPropertyId, typeof(ManyToOneRelation.TargetInversePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetLazy", ManyToOneRelation.TargetLazyDomainPropertyId, typeof(ManyToOneRelation.TargetLazyPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetMapType", ManyToOneRelation.TargetMapTypeDomainPropertyId, typeof(ManyToOneRelation.TargetMapTypePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetOrderBy", ManyToOneRelation.TargetOrderByDomainPropertyId, typeof(ManyToOneRelation.TargetOrderByPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetRelationType", ManyToOneRelation.TargetRelationTypeDomainPropertyId, typeof(ManyToOneRelation.TargetRelationTypePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetSchema", ManyToOneRelation.TargetSchemaDomainPropertyId, typeof(ManyToOneRelation.TargetSchemaPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetSort", ManyToOneRelation.TargetSortDomainPropertyId, typeof(ManyToOneRelation.TargetSortPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetTable", ManyToOneRelation.TargetTableDomainPropertyId, typeof(ManyToOneRelation.TargetTablePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetWhere", ManyToOneRelation.TargetWhereDomainPropertyId, typeof(ManyToOneRelation.TargetWherePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetDescription", ManyToOneRelation.TargetDescriptionDomainPropertyId, typeof(ManyToOneRelation.TargetDescriptionPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetPropertyName", ManyToOneRelation.TargetPropertyNameDomainPropertyId, typeof(ManyToOneRelation.TargetPropertyNamePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetPropertyType", ManyToOneRelation.TargetPropertyTypeDomainPropertyId, typeof(ManyToOneRelation.TargetPropertyTypePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "SourceCascade", ManyToOneRelation.SourceCascadeDomainPropertyId, typeof(ManyToOneRelation.SourceCascadePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "SourceColumn", ManyToOneRelation.SourceColumnDomainPropertyId, typeof(ManyToOneRelation.SourceColumnPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "SourceCustomAccess", ManyToOneRelation.SourceCustomAccessDomainPropertyId, typeof(ManyToOneRelation.SourceCustomAccessPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "SourceInsert", ManyToOneRelation.SourceInsertDomainPropertyId, typeof(ManyToOneRelation.SourceInsertPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "SourceNotNull", ManyToOneRelation.SourceNotNullDomainPropertyId, typeof(ManyToOneRelation.SourceNotNullPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "SourceOuterJoin", ManyToOneRelation.SourceOuterJoinDomainPropertyId, typeof(ManyToOneRelation.SourceOuterJoinPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "SourceType", ManyToOneRelation.SourceTypeDomainPropertyId, typeof(ManyToOneRelation.SourceTypePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "SourceUnique", ManyToOneRelation.SourceUniqueDomainPropertyId, typeof(ManyToOneRelation.SourceUniquePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "SourceUpdate", ManyToOneRelation.SourceUpdateDomainPropertyId, typeof(ManyToOneRelation.SourceUpdatePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "SourceDescription", ManyToOneRelation.SourceDescriptionDomainPropertyId, typeof(ManyToOneRelation.SourceDescriptionPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetAccess", ManyToOneRelation.TargetAccessDomainPropertyId, typeof(ManyToOneRelation.TargetAccessPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "SourcePropertyName", ManyToOneRelation.SourcePropertyNameDomainPropertyId, typeof(ManyToOneRelation.SourcePropertyNamePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "SourceNotFoundBehaviour", ManyToOneRelation.SourceNotFoundBehaviourDomainPropertyId, typeof(ManyToOneRelation.SourceNotFoundBehaviourPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetNotFoundBehaviour", ManyToOneRelation.TargetNotFoundBehaviourDomainPropertyId, typeof(ManyToOneRelation.TargetNotFoundBehaviourPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetElement", ManyToOneRelation.TargetElementDomainPropertyId, typeof(ManyToOneRelation.TargetElementPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetIndexType", ManyToOneRelation.TargetIndexTypeDomainPropertyId, typeof(ManyToOneRelation.TargetIndexTypePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetIndex", ManyToOneRelation.TargetIndexDomainPropertyId, typeof(ManyToOneRelation.TargetIndexPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetFetch", ManyToOneRelation.TargetFetchDomainPropertyId, typeof(ManyToOneRelation.TargetFetchPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetIUserCollectionType", ManyToOneRelation.TargetIUserCollectionTypeDomainPropertyId, typeof(ManyToOneRelation.TargetIUserCollectionTypePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "TargetPropertyGenerated", ManyToOneRelation.TargetPropertyGeneratedDomainPropertyId, typeof(ManyToOneRelation.TargetPropertyGeneratedPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "SourcePropertyGenerated", ManyToOneRelation.SourcePropertyGeneratedDomainPropertyId, typeof(ManyToOneRelation.SourcePropertyGeneratedPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToOneRelation), "SourceAccess", ManyToOneRelation.SourceAccessDomainPropertyId, typeof(ManyToOneRelation.SourceAccessPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourceCache", ManyToManyRelation.SourceCacheDomainPropertyId, typeof(ManyToManyRelation.SourceCachePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourceCascade", ManyToManyRelation.SourceCascadeDomainPropertyId, typeof(ManyToManyRelation.SourceCascadePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourceColumn", ManyToManyRelation.SourceColumnDomainPropertyId, typeof(ManyToManyRelation.SourceColumnPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourceCustomAccess", ManyToManyRelation.SourceCustomAccessDomainPropertyId, typeof(ManyToManyRelation.SourceCustomAccessPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourceInverse", ManyToManyRelation.SourceInverseDomainPropertyId, typeof(ManyToManyRelation.SourceInversePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourceLazy", ManyToManyRelation.SourceLazyDomainPropertyId, typeof(ManyToManyRelation.SourceLazyPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourceMapType", ManyToManyRelation.SourceMapTypeDomainPropertyId, typeof(ManyToManyRelation.SourceMapTypePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourceOrderBy", ManyToManyRelation.SourceOrderByDomainPropertyId, typeof(ManyToManyRelation.SourceOrderByPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourceRelationType", ManyToManyRelation.SourceRelationTypeDomainPropertyId, typeof(ManyToManyRelation.SourceRelationTypePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "Schema", ManyToManyRelation.SchemaDomainPropertyId, typeof(ManyToManyRelation.SchemaPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourceSort", ManyToManyRelation.SourceSortDomainPropertyId, typeof(ManyToManyRelation.SourceSortPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "Table", ManyToManyRelation.TableDomainPropertyId, typeof(ManyToManyRelation.TablePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourceWhere", ManyToManyRelation.SourceWhereDomainPropertyId, typeof(ManyToManyRelation.SourceWherePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetCache", ManyToManyRelation.TargetCacheDomainPropertyId, typeof(ManyToManyRelation.TargetCachePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetCascade", ManyToManyRelation.TargetCascadeDomainPropertyId, typeof(ManyToManyRelation.TargetCascadePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetColumn", ManyToManyRelation.TargetColumnDomainPropertyId, typeof(ManyToManyRelation.TargetColumnPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetCustomAccess", ManyToManyRelation.TargetCustomAccessDomainPropertyId, typeof(ManyToManyRelation.TargetCustomAccessPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetInverse", ManyToManyRelation.TargetInverseDomainPropertyId, typeof(ManyToManyRelation.TargetInversePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetLazy", ManyToManyRelation.TargetLazyDomainPropertyId, typeof(ManyToManyRelation.TargetLazyPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetMapType", ManyToManyRelation.TargetMapTypeDomainPropertyId, typeof(ManyToManyRelation.TargetMapTypePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetOrderBy", ManyToManyRelation.TargetOrderByDomainPropertyId, typeof(ManyToManyRelation.TargetOrderByPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetRelationType", ManyToManyRelation.TargetRelationTypeDomainPropertyId, typeof(ManyToManyRelation.TargetRelationTypePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetSort", ManyToManyRelation.TargetSortDomainPropertyId, typeof(ManyToManyRelation.TargetSortPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetWhere", ManyToManyRelation.TargetWhereDomainPropertyId, typeof(ManyToManyRelation.TargetWherePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourceDescription", ManyToManyRelation.SourceDescriptionDomainPropertyId, typeof(ManyToManyRelation.SourceDescriptionPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetDescription", ManyToManyRelation.TargetDescriptionDomainPropertyId, typeof(ManyToManyRelation.TargetDescriptionPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourceAccess", ManyToManyRelation.SourceAccessDomainPropertyId, typeof(ManyToManyRelation.SourceAccessPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetAccess", ManyToManyRelation.TargetAccessDomainPropertyId, typeof(ManyToManyRelation.TargetAccessPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourcePropertyType", ManyToManyRelation.SourcePropertyTypeDomainPropertyId, typeof(ManyToManyRelation.SourcePropertyTypePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetPropertyType", ManyToManyRelation.TargetPropertyTypeDomainPropertyId, typeof(ManyToManyRelation.TargetPropertyTypePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourcePropertyName", ManyToManyRelation.SourcePropertyNameDomainPropertyId, typeof(ManyToManyRelation.SourcePropertyNamePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetPropertyName", ManyToManyRelation.TargetPropertyNameDomainPropertyId, typeof(ManyToManyRelation.TargetPropertyNamePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetNotFoundBehaviour", ManyToManyRelation.TargetNotFoundBehaviourDomainPropertyId, typeof(ManyToManyRelation.TargetNotFoundBehaviourPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourceNotFoundBehaviour", ManyToManyRelation.SourceNotFoundBehaviourDomainPropertyId, typeof(ManyToManyRelation.SourceNotFoundBehaviourPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourceIUserCollectionType", ManyToManyRelation.SourceIUserCollectionTypeDomainPropertyId, typeof(ManyToManyRelation.SourceIUserCollectionTypePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetIUserCollectionType", ManyToManyRelation.TargetIUserCollectionTypeDomainPropertyId, typeof(ManyToManyRelation.TargetIUserCollectionTypePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "CollectionIDColumn", ManyToManyRelation.CollectionIDColumnDomainPropertyId, typeof(ManyToManyRelation.CollectionIDColumnPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "CollectionIDColumnType", ManyToManyRelation.CollectionIDColumnTypeDomainPropertyId, typeof(ManyToManyRelation.CollectionIDColumnTypePropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "CollectionIDGenerator", ManyToManyRelation.CollectionIDGeneratorDomainPropertyId, typeof(ManyToManyRelation.CollectionIDGeneratorPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "TargetPropertyGenerated", ManyToManyRelation.TargetPropertyGeneratedDomainPropertyId, typeof(ManyToManyRelation.TargetPropertyGeneratedPropertyHandler)),
				new DomainMemberInfo(typeof(ManyToManyRelation), "SourcePropertyGenerated", ManyToManyRelation.SourcePropertyGeneratedDomainPropertyId, typeof(ManyToManyRelation.SourcePropertyGeneratedPropertyHandler)),
				new DomainMemberInfo(typeof(OneToOneRelation), "SourceAccess", OneToOneRelation.SourceAccessDomainPropertyId, typeof(OneToOneRelation.SourceAccessPropertyHandler)),
				new DomainMemberInfo(typeof(OneToOneRelation), "SourceCascade", OneToOneRelation.SourceCascadeDomainPropertyId, typeof(OneToOneRelation.SourceCascadePropertyHandler)),
				new DomainMemberInfo(typeof(OneToOneRelation), "SourceConstrained", OneToOneRelation.SourceConstrainedDomainPropertyId, typeof(OneToOneRelation.SourceConstrainedPropertyHandler)),
				new DomainMemberInfo(typeof(OneToOneRelation), "SourceCustomAccess", OneToOneRelation.SourceCustomAccessDomainPropertyId, typeof(OneToOneRelation.SourceCustomAccessPropertyHandler)),
				new DomainMemberInfo(typeof(OneToOneRelation), "SourceOuterJoin", OneToOneRelation.SourceOuterJoinDomainPropertyId, typeof(OneToOneRelation.SourceOuterJoinPropertyHandler)),
				new DomainMemberInfo(typeof(OneToOneRelation), "TargetAccess", OneToOneRelation.TargetAccessDomainPropertyId, typeof(OneToOneRelation.TargetAccessPropertyHandler)),
				new DomainMemberInfo(typeof(OneToOneRelation), "TargetCascade", OneToOneRelation.TargetCascadeDomainPropertyId, typeof(OneToOneRelation.TargetCascadePropertyHandler)),
				new DomainMemberInfo(typeof(OneToOneRelation), "TargetConstrained", OneToOneRelation.TargetConstrainedDomainPropertyId, typeof(OneToOneRelation.TargetConstrainedPropertyHandler)),
				new DomainMemberInfo(typeof(OneToOneRelation), "TargetCustomAccess", OneToOneRelation.TargetCustomAccessDomainPropertyId, typeof(OneToOneRelation.TargetCustomAccessPropertyHandler)),
				new DomainMemberInfo(typeof(OneToOneRelation), "TargetOuterJoin", OneToOneRelation.TargetOuterJoinDomainPropertyId, typeof(OneToOneRelation.TargetOuterJoinPropertyHandler)),
				new DomainMemberInfo(typeof(OneToOneRelation), "SourceDescription", OneToOneRelation.SourceDescriptionDomainPropertyId, typeof(OneToOneRelation.SourceDescriptionPropertyHandler)),
				new DomainMemberInfo(typeof(OneToOneRelation), "TargetDescription", OneToOneRelation.TargetDescriptionDomainPropertyId, typeof(OneToOneRelation.TargetDescriptionPropertyHandler)),
				new DomainMemberInfo(typeof(OneToOneRelation), "Lazy", OneToOneRelation.LazyDomainPropertyId, typeof(OneToOneRelation.LazyPropertyHandler)),
				new DomainMemberInfo(typeof(NestedClassReferencesModelClasses), "MapType", NestedClassReferencesModelClasses.MapTypeDomainPropertyId, typeof(NestedClassReferencesModelClasses.MapTypePropertyHandler)),
				new DomainMemberInfo(typeof(NestedClassReferencesModelClasses), "Insert", NestedClassReferencesModelClasses.InsertDomainPropertyId, typeof(NestedClassReferencesModelClasses.InsertPropertyHandler)),
				new DomainMemberInfo(typeof(NestedClassReferencesModelClasses), "Update", NestedClassReferencesModelClasses.UpdateDomainPropertyId, typeof(NestedClassReferencesModelClasses.UpdatePropertyHandler)),
				new DomainMemberInfo(typeof(NestedClassReferencesModelClasses), "ColumnPrefix", NestedClassReferencesModelClasses.ColumnPrefixDomainPropertyId, typeof(NestedClassReferencesModelClasses.ColumnPrefixPropertyHandler)),
				new DomainMemberInfo(typeof(NestedClassReferencesModelClasses), "Description", NestedClassReferencesModelClasses.DescriptionDomainPropertyId, typeof(NestedClassReferencesModelClasses.DescriptionPropertyHandler)),
				new DomainMemberInfo(typeof(NestedClassReferencesModelClasses), "PropertyName", NestedClassReferencesModelClasses.PropertyNameDomainPropertyId, typeof(NestedClassReferencesModelClasses.PropertyNamePropertyHandler)),
			};
		}
		/// <summary>
		/// Gets the list of generated domain roles.
		/// </summary>
		/// <returns>List of role data.</returns>
		protected sealed override DomainRolePlayerInfo[] GetGeneratedDomainRoles()
		{
			return new DomainRolePlayerInfo[]
			{
				new DomainRolePlayerInfo(typeof(ModelHasClass), "Model", ModelHasClass.ModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelHasClass), "Class", ModelHasClass.ClassDomainRoleId),
				new DomainRolePlayerInfo(typeof(ManyToOneRelation), "Source", ManyToOneRelation.SourceDomainRoleId),
				new DomainRolePlayerInfo(typeof(ManyToOneRelation), "Target", ManyToOneRelation.TargetDomainRoleId),
				new DomainRolePlayerInfo(typeof(ClassHasProperty), "ModelClass", ClassHasProperty.ModelClassDomainRoleId),
				new DomainRolePlayerInfo(typeof(ClassHasProperty), "Property", ClassHasProperty.PropertyDomainRoleId),
				new DomainRolePlayerInfo(typeof(ManyToManyRelation), "Source", ManyToManyRelation.SourceDomainRoleId),
				new DomainRolePlayerInfo(typeof(ManyToManyRelation), "Target", ManyToManyRelation.TargetDomainRoleId),
				new DomainRolePlayerInfo(typeof(OneToOneRelation), "Source", OneToOneRelation.SourceDomainRoleId),
				new DomainRolePlayerInfo(typeof(OneToOneRelation), "Target", OneToOneRelation.TargetDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelHasNestedClasses), "Model", ModelHasNestedClasses.ModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelHasNestedClasses), "NestedClass", ModelHasNestedClasses.NestedClassDomainRoleId),
				new DomainRolePlayerInfo(typeof(NestedClassHasProperties), "NestedClass", NestedClassHasProperties.NestedClassDomainRoleId),
				new DomainRolePlayerInfo(typeof(NestedClassHasProperties), "Property", NestedClassHasProperties.PropertyDomainRoleId),
				new DomainRolePlayerInfo(typeof(NestedClassReferencesModelClasses), "NestedClass", NestedClassReferencesModelClasses.NestedClassDomainRoleId),
				new DomainRolePlayerInfo(typeof(NestedClassReferencesModelClasses), "ModelClass", NestedClassReferencesModelClasses.ModelClassDomainRoleId),
				new DomainRolePlayerInfo(typeof(InheritanceRelation), "SourceModelClass", InheritanceRelation.SourceModelClassDomainRoleId),
				new DomainRolePlayerInfo(typeof(InheritanceRelation), "TargetModelClass", InheritanceRelation.TargetModelClassDomainRoleId),
			};
		}
		#endregion
		#region Factory methods
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementMap;
	
		/// <summary>
		/// Creates an element of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementType">Element type which belongs to this domain model.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		public sealed override DslModeling::ModelElement CreateElement(DslModeling::Partition partition, global::System.Type elementType, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementType == null) throw new global::System.ArgumentNullException("elementType");
	
			if (createElementMap == null)
			{
				createElementMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(14);
				createElementMap.Add(typeof(Model), 0);
				createElementMap.Add(typeof(ModelClass), 1);
				createElementMap.Add(typeof(ModelProperty), 2);
				createElementMap.Add(typeof(NestedClass), 3);
				createElementMap.Add(typeof(ActiveRecordMapping), 4);
				createElementMap.Add(typeof(ManyToOneConnector), 5);
				createElementMap.Add(typeof(ManyToManyConnector), 6);
				createElementMap.Add(typeof(OneToOneConnector), 7);
				createElementMap.Add(typeof(NestedConnector), 8);
				createElementMap.Add(typeof(InheritanceConnector), 9);
				createElementMap.Add(typeof(ClassShape), 10);
				createElementMap.Add(typeof(NestedClassShape), 11);
			}
			int index;
			if (!createElementMap.TryGetValue(elementType, out index))
			{
				// construct exception error message		
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::Castle.ActiveWriter.ActiveWriterDomainModel.SingletonResourceManager.GetString("UnrecognizedElementType"),
								elementType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementType");
			}
			switch (index)
			{
				case 0: return new Model(partition, propertyAssignments);
				case 1: return new ModelClass(partition, propertyAssignments);
				case 2: return new ModelProperty(partition, propertyAssignments);
				case 3: return new NestedClass(partition, propertyAssignments);
				case 4: return new ActiveRecordMapping(partition, propertyAssignments);
				case 5: return new ManyToOneConnector(partition, propertyAssignments);
				case 6: return new ManyToManyConnector(partition, propertyAssignments);
				case 7: return new OneToOneConnector(partition, propertyAssignments);
				case 8: return new NestedConnector(partition, propertyAssignments);
				case 9: return new InheritanceConnector(partition, propertyAssignments);
				case 10: return new ClassShape(partition, propertyAssignments);
				case 11: return new NestedClassShape(partition, propertyAssignments);
				default: return null;
			}
		}
	
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementLinkMap;
	
		/// <summary>
		/// Creates an element link of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementLinkType">Element link type which belongs to this domain model.</param>
		/// <param name="roleAssignments">List of relationship role assignments for the new link.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element link.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		public sealed override DslModeling::ElementLink CreateElementLink(DslModeling::Partition partition, global::System.Type elementLinkType, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementLinkType == null) throw new global::System.ArgumentNullException("elementLinkType");
			if (roleAssignments == null) throw new global::System.ArgumentNullException("roleAssignments");
	
			if (createElementLinkMap == null)
			{
				createElementLinkMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(9);
				createElementLinkMap.Add(typeof(ModelHasClass), 0);
				createElementLinkMap.Add(typeof(ManyToOneRelation), 1);
				createElementLinkMap.Add(typeof(ClassHasProperty), 2);
				createElementLinkMap.Add(typeof(ManyToManyRelation), 3);
				createElementLinkMap.Add(typeof(OneToOneRelation), 4);
				createElementLinkMap.Add(typeof(ModelHasNestedClasses), 5);
				createElementLinkMap.Add(typeof(NestedClassHasProperties), 6);
				createElementLinkMap.Add(typeof(NestedClassReferencesModelClasses), 7);
				createElementLinkMap.Add(typeof(InheritanceRelation), 8);
			}
			int index;
			if (!createElementLinkMap.TryGetValue(elementLinkType, out index))
			{
				// construct exception error message
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::Castle.ActiveWriter.ActiveWriterDomainModel.SingletonResourceManager.GetString("UnrecognizedElementLinkType"),
								elementLinkType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementLinkType");
			
			}
			switch (index)
			{
				case 0: return new ModelHasClass(partition, roleAssignments, propertyAssignments);
				case 1: return new ManyToOneRelation(partition, roleAssignments, propertyAssignments);
				case 2: return new ClassHasProperty(partition, roleAssignments, propertyAssignments);
				case 3: return new ManyToManyRelation(partition, roleAssignments, propertyAssignments);
				case 4: return new OneToOneRelation(partition, roleAssignments, propertyAssignments);
				case 5: return new ModelHasNestedClasses(partition, roleAssignments, propertyAssignments);
				case 6: return new NestedClassHasProperties(partition, roleAssignments, propertyAssignments);
				case 7: return new NestedClassReferencesModelClasses(partition, roleAssignments, propertyAssignments);
				case 8: return new InheritanceRelation(partition, roleAssignments, propertyAssignments);
				default: return null;
			}
		}
		#endregion
		#region Resource manager
		
		private static global::System.Resources.ResourceManager resourceManager;
		
		/// <summary>
		/// The base name of this model's resources.
		/// </summary>
		public const string ResourceBaseName = "Castle.ActiveWriter.GeneratedCode.DomainModelResx";
		
		/// <summary>
		/// Gets the DomainModel's ResourceManager. If the ResourceManager does not already exist, then it is created.
		/// </summary>
		public override global::System.Resources.ResourceManager ResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return ActiveWriterDomainModel.SingletonResourceManager;
			}
		}
	
		/// <summary>
		/// Gets the Singleton ResourceManager for this domain model.
		/// </summary>
		public static global::System.Resources.ResourceManager SingletonResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				if (ActiveWriterDomainModel.resourceManager == null)
				{
					ActiveWriterDomainModel.resourceManager = new global::System.Resources.ResourceManager(ResourceBaseName, typeof(ActiveWriterDomainModel).Assembly);
				}
				return ActiveWriterDomainModel.resourceManager;
			}
		}
		#endregion
		#region Copy/Remove closures
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter copyClosure;
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter removeClosure;
		/// <summary>
		/// Returns an IElementVisitorFilter that corresponds to the ClosureType.
		/// </summary>
		/// <param name="type">closure type</param>
		/// <param name="rootElements">collection of root elements</param>
		/// <returns>IElementVisitorFilter or null</returns>
		public override DslModeling::IElementVisitorFilter GetClosureFilter(DslModeling::ClosureType type, global::System.Collections.Generic.ICollection<DslModeling::ModelElement> rootElements)
		{
			switch (type)
			{
				case DslModeling::ClosureType.CopyClosure:
					return ActiveWriterDomainModel.CopyClosure;
				case DslModeling::ClosureType.DeleteClosure:
					return ActiveWriterDomainModel.DeleteClosure;
			}
			return base.GetClosureFilter(type, rootElements);
		}
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter CopyClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (ActiveWriterDomainModel.copyClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter copyFilter = new DslModeling::ChainingElementVisitorFilter();
					copyFilter.AddFilter(new ActiveWriterCopyClosure());
					copyFilter.AddFilter(new DslModeling::CoreCopyClosure());
					copyFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceCopyClosure());
					
					ActiveWriterDomainModel.copyClosure = copyFilter;
				}
				return ActiveWriterDomainModel.copyClosure;
			}
		}
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter DeleteClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (ActiveWriterDomainModel.removeClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter removeFilter = new DslModeling::ChainingElementVisitorFilter();
					removeFilter.AddFilter(new ActiveWriterDeleteClosure());
					removeFilter.AddFilter(new DslModeling::CoreDeleteClosure());
					removeFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceDeleteClosure());
		
					ActiveWriterDomainModel.removeClosure = removeFilter;
				}
				return ActiveWriterDomainModel.removeClosure;
			}
		}
		#endregion
		#region Diagram rule helpers
		/// <summary>
		/// Enables rules in this domain model related to diagram fixup for the given store.
		/// If diagram data will be loaded into the store, this method should be called first to ensure
		/// that the diagram behaves properly.
		/// </summary>
		public static void EnableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.EnableRule(typeof(global::Castle.ActiveWriter.FixUpDiagram));
			ruleManager.EnableRule(typeof(global::Castle.ActiveWriter.ConnectorRolePlayerChanged));
			ruleManager.EnableRule(typeof(global::Castle.ActiveWriter.CompartmentItemAddRule));
			ruleManager.EnableRule(typeof(global::Castle.ActiveWriter.CompartmentItemDeleteRule));
			ruleManager.EnableRule(typeof(global::Castle.ActiveWriter.CompartmentItemRolePlayerChangeRule));
			ruleManager.EnableRule(typeof(global::Castle.ActiveWriter.CompartmentItemRolePlayerPositionChangeRule));
			ruleManager.EnableRule(typeof(global::Castle.ActiveWriter.CompartmentItemChangeRule));
		}
		
		/// <summary>
		/// Disables rules in this domain model related to diagram fixup for the given store.
		/// </summary>
		public static void DisableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.DisableRule(typeof(global::Castle.ActiveWriter.FixUpDiagram));
			ruleManager.DisableRule(typeof(global::Castle.ActiveWriter.ConnectorRolePlayerChanged));
			ruleManager.DisableRule(typeof(global::Castle.ActiveWriter.CompartmentItemAddRule));
			ruleManager.DisableRule(typeof(global::Castle.ActiveWriter.CompartmentItemDeleteRule));
			ruleManager.DisableRule(typeof(global::Castle.ActiveWriter.CompartmentItemRolePlayerChangeRule));
			ruleManager.DisableRule(typeof(global::Castle.ActiveWriter.CompartmentItemRolePlayerPositionChangeRule));
			ruleManager.DisableRule(typeof(global::Castle.ActiveWriter.CompartmentItemChangeRule));
		}
		#endregion
	}
		
	#region Copy/Remove closure classes
	/// <summary>
	/// Remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class ActiveWriterDeleteClosure : ActiveWriterDeleteClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ActiveWriterDeleteClosure() : base()
		{
		}
	}
	
	/// <summary>
	/// Base class for remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class ActiveWriterDeleteClosureBase : DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary domainRoles;
		/// <summary>
		/// Constructor
		/// </summary>
		public ActiveWriterDeleteClosureBase()
		{
			#region Initialize DomainData Table
			DomainRoles.Add(global::Castle.ActiveWriter.ModelHasClass.ClassDomainRoleId, true);
			DomainRoles.Add(global::Castle.ActiveWriter.ModelHasNestedClasses.NestedClassDomainRoleId, true);
			#endregion
		}
		/// <summary>
		/// Called to ask the filter if a particular relationship from a source element should be included in the traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="sourceRoleInfo">DomainRoleInfo of the role that the source element is playing in the relationship</param>
		/// <param name="domainRelationshipInfo">DomainRelationshipInfo for the ElementLink in question</param>
		/// <param name="targetRelationship">Relationship in question</param>
		/// <returns>Yes if the relationship should be traversed</returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRelationship(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::DomainRoleInfo sourceRoleInfo, DslModeling::DomainRelationshipInfo domainRelationshipInfo, DslModeling::ElementLink targetRelationship)
		{
			return DslModeling::VisitorFilterResult.Yes;
		}
		/// <summary>
		/// Called to ask the filter if a particular role player should be Visited during traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="elementLink">Element Link that forms the relationship to the role player in question</param>
		/// <param name="targetDomainRole">DomainRoleInfo of the target role</param>
		/// <param name="targetRolePlayer">Model Element that plays the target role in the relationship</param>
		/// <returns></returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRolePlayer(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::ElementLink elementLink, DslModeling::DomainRoleInfo targetDomainRole, DslModeling::ModelElement targetRolePlayer)
		{
			if (targetDomainRole == null) throw new global::System.ArgumentNullException("targetDomainRole");
			return DomainRoles.Contains(targetDomainRole.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary DomainRoles
		{
			get
			{
				if (domainRoles == null)
				{
					domainRoles = new global::System.Collections.Specialized.HybridDictionary();
				}
				return domainRoles;
			}
		}
	
	}
	/// <summary>
	/// Copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class ActiveWriterCopyClosure : ActiveWriterCopyClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ActiveWriterCopyClosure() : base()
		{
		}
	}
	/// <summary>
	/// Base class for copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class ActiveWriterCopyClosureBase : DslModeling::CopyClosureFilter, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ActiveWriterCopyClosureBase():base()
		{
		}
	}
	#endregion
		
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: PropertyAccess
	/// Description for Castle.ActiveWriter.PropertyAccess
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum PropertyAccess
	{
		/// <summary>
		/// Property
		/// Description for Castle.ActiveWriter.PropertyAccess.Property
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PropertyAccess/Property.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Property,
		/// <summary>
		/// FieldCamelcase
		/// Description for Castle.ActiveWriter.PropertyAccess.FieldCamelcase
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PropertyAccess/FieldCamelcase.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		FieldCamelcase,
		/// <summary>
		/// FieldCamelcaseUnderscore
		/// Description for Castle.ActiveWriter.PropertyAccess.FieldCamelcaseUnderscore
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PropertyAccess/FieldCamelcaseUnderscore.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		FieldCamelcaseUnderscore,
		/// <summary>
		/// FieldPascalcaseMUnderscore
		/// Description for Castle.ActiveWriter.PropertyAccess.FieldPascalcaseMUnderscore
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PropertyAccess/FieldPascalcaseMUnderscore.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		FieldPascalcaseMUnderscore,
		/// <summary>
		/// FieldLowercaseUnderscore
		/// Description for Castle.ActiveWriter.PropertyAccess.FieldLowercaseUnderscore
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PropertyAccess/FieldLowercaseUnderscore.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		FieldLowercaseUnderscore,
		/// <summary>
		/// NosetterCamelcase
		/// Description for Castle.ActiveWriter.PropertyAccess.NosetterCamelcase
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PropertyAccess/NosetterCamelcase.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		NosetterCamelcase,
		/// <summary>
		/// NosetterCamelcaseUnderscore
		/// Description for Castle.ActiveWriter.PropertyAccess.NosetterCamelcaseUnderscore
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PropertyAccess/NosetterCamelcaseUnderscore.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		NosetterCamelcaseUnderscore,
		/// <summary>
		/// NosetterPascalcaseMUnderscore
		/// Description for Castle.ActiveWriter.PropertyAccess.NosetterPascalcaseMUnderscore
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PropertyAccess/NosetterPascalcaseMUnderscore.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		NosetterPascalcaseMUnderscore,
		/// <summary>
		/// NosetterLowercaseUnderscore
		/// Description for Castle.ActiveWriter.PropertyAccess.NosetterLowercaseUnderscore
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PropertyAccess/NosetterLowercaseUnderscore.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		NosetterLowercaseUnderscore,
		/// <summary>
		/// Field
		/// Description for Castle.ActiveWriter.PropertyAccess.Field
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PropertyAccess/Field.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Field,
		/// <summary>
		/// NosetterLowercase
		/// Description for Castle.ActiveWriter.PropertyAccess.NosetterLowercase
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PropertyAccess/NosetterLowercase.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		NosetterLowercase,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: CacheEnum
	/// Description for Castle.ActiveWriter.CacheEnum
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum CacheEnum
	{
		/// <summary>
		/// Undefined
		/// Description for Castle.ActiveWriter.CacheEnum.Undefined
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.CacheEnum/Undefined.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Undefined,
		/// <summary>
		/// ReadOnly
		/// Description for Castle.ActiveWriter.CacheEnum.ReadOnly
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.CacheEnum/ReadOnly.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		ReadOnly,
		/// <summary>
		/// ReadWrite
		/// Description for Castle.ActiveWriter.CacheEnum.ReadWrite
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.CacheEnum/ReadWrite.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		ReadWrite,
		/// <summary>
		/// NonStrictReadWrite
		/// Description for Castle.ActiveWriter.CacheEnum.NonStrictReadWrite
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.CacheEnum/NonStrictReadWrite.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		NonStrictReadWrite,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: PrimaryKeyType
	/// Description for Castle.ActiveWriter.PrimaryKeyType
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum PrimaryKeyType
	{
		/// <summary>
		/// None
		/// Description for Castle.ActiveWriter.PrimaryKeyType.None
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PrimaryKeyType/None.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		None,
		/// <summary>
		/// Identity
		/// Description for Castle.ActiveWriter.PrimaryKeyType.Identity
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PrimaryKeyType/Identity.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Identity,
		/// <summary>
		/// Sequence
		/// Description for Castle.ActiveWriter.PrimaryKeyType.Sequence
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PrimaryKeyType/Sequence.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Sequence,
		/// <summary>
		/// HiLo
		/// Description for Castle.ActiveWriter.PrimaryKeyType.HiLo
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PrimaryKeyType/HiLo.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		HiLo,
		/// <summary>
		/// SeqHiLo
		/// Description for Castle.ActiveWriter.PrimaryKeyType.SeqHiLo
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PrimaryKeyType/SeqHiLo.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		SeqHiLo,
		/// <summary>
		/// UuidHex
		/// Description for Castle.ActiveWriter.PrimaryKeyType.UuidHex
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PrimaryKeyType/UuidHex.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		UuidHex,
		/// <summary>
		/// UuidString
		/// Description for Castle.ActiveWriter.PrimaryKeyType.UuidString
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PrimaryKeyType/UuidString.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		UuidString,
		/// <summary>
		/// Guid
		/// Description for Castle.ActiveWriter.PrimaryKeyType.Guid
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PrimaryKeyType/Guid.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Guid,
		/// <summary>
		/// GuidComb
		/// Description for Castle.ActiveWriter.PrimaryKeyType.GuidComb
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PrimaryKeyType/GuidComb.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		GuidComb,
		/// <summary>
		/// Native
		/// Description for Castle.ActiveWriter.PrimaryKeyType.Native
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PrimaryKeyType/Native.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Native,
		/// <summary>
		/// Assigned
		/// Description for Castle.ActiveWriter.PrimaryKeyType.Assigned
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PrimaryKeyType/Assigned.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Assigned,
		/// <summary>
		/// Foreign
		/// Description for Castle.ActiveWriter.PrimaryKeyType.Foreign
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PrimaryKeyType/Foreign.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Foreign,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: KeyType
	/// Description for Castle.ActiveWriter.KeyType
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum KeyType
	{
		/// <summary>
		/// None
		/// Description for Castle.ActiveWriter.KeyType.None
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.KeyType/None.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		None,
		/// <summary>
		/// PrimaryKey
		/// Description for Castle.ActiveWriter.KeyType.PrimaryKey
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.KeyType/PrimaryKey.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		PrimaryKey,
		/// <summary>
		/// CompositeKey
		/// Description for Castle.ActiveWriter.KeyType.CompositeKey
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.KeyType/CompositeKey.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		CompositeKey,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: CascadeEnum
	/// Description for Castle.ActiveWriter.CascadeEnum
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum CascadeEnum
	{
		/// <summary>
		/// None
		/// Description for Castle.ActiveWriter.CascadeEnum.None
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.CascadeEnum/None.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		None,
		/// <summary>
		/// All
		/// Description for Castle.ActiveWriter.CascadeEnum.All
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.CascadeEnum/All.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		All,
		/// <summary>
		/// SaveUpdate
		/// Description for Castle.ActiveWriter.CascadeEnum.SaveUpdate
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.CascadeEnum/SaveUpdate.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		SaveUpdate,
		/// <summary>
		/// Delete
		/// Description for Castle.ActiveWriter.CascadeEnum.Delete
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.CascadeEnum/Delete.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Delete,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: OuterJoinEnum
	/// Description for Castle.ActiveWriter.OuterJoinEnum
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum OuterJoinEnum
	{
		/// <summary>
		/// Auto
		/// Description for Castle.ActiveWriter.OuterJoinEnum.Auto
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OuterJoinEnum/Auto.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Auto,
		/// <summary>
		/// True
		/// Description for Castle.ActiveWriter.OuterJoinEnum.True
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OuterJoinEnum/True.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		True,
		/// <summary>
		/// False
		/// Description for Castle.ActiveWriter.OuterJoinEnum.False
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OuterJoinEnum/False.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		False,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: InheritedRelationType
	/// Description for Castle.ActiveWriter.InheritedRelationType
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum InheritedRelationType
	{
		/// <summary>
		/// Inherited
		/// Description for Castle.ActiveWriter.InheritedRelationType.Inherited
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritedRelationType/Inherited.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Inherited,
		/// <summary>
		/// Guess
		/// Description for Castle.ActiveWriter.InheritedRelationType.Guess
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritedRelationType/Guess.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Guess,
		/// <summary>
		/// Bag
		/// Description for Castle.ActiveWriter.InheritedRelationType.Bag
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritedRelationType/Bag.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Bag,
		/// <summary>
		/// Set
		/// Description for Castle.ActiveWriter.InheritedRelationType.Set
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritedRelationType/Set.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Set,
		/// <summary>
		/// IdBag
		/// Description for Castle.ActiveWriter.InheritedRelationType.IdBag
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritedRelationType/IdBag.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		IdBag,
		/// <summary>
		/// Map
		/// Description for Castle.ActiveWriter.InheritedRelationType.Map
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritedRelationType/Map.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Map,
		/// <summary>
		/// List
		/// Description for Castle.ActiveWriter.InheritedRelationType.List
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritedRelationType/List.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		List,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: RelationType
	/// Description for Castle.ActiveWriter.RelationType
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum RelationType
	{
		/// <summary>
		/// Guess
		/// Description for Castle.ActiveWriter.RelationType.Guess
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.RelationType/Guess.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Guess,
		/// <summary>
		/// Bag
		/// Description for Castle.ActiveWriter.RelationType.Bag
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.RelationType/Bag.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Bag,
		/// <summary>
		/// Set
		/// Description for Castle.ActiveWriter.RelationType.Set
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.RelationType/Set.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Set,
		/// <summary>
		/// IdBag
		/// Description for Castle.ActiveWriter.RelationType.IdBag
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.RelationType/IdBag.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		IdBag,
		/// <summary>
		/// Map
		/// Description for Castle.ActiveWriter.RelationType.Map
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.RelationType/Map.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Map,
		/// <summary>
		/// List
		/// Description for Castle.ActiveWriter.RelationType.List
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.RelationType/List.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		List,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: NHibernateType
	/// Description for Castle.ActiveWriter.NHibernateType
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum NHibernateType
	{
		/// <summary>
		/// AnsiChar
		/// Description for Castle.ActiveWriter.NHibernateType.AnsiChar
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/AnsiChar.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		AnsiChar,
		/// <summary>
		/// Single
		/// Description for Castle.ActiveWriter.NHibernateType.Single
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/Single.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Single,
		/// <summary>
		/// AnsiString
		/// Description for Castle.ActiveWriter.NHibernateType.AnsiString
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/AnsiString.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		AnsiString,
		/// <summary>
		/// CultureInfo
		/// Description for Castle.ActiveWriter.NHibernateType.CultureInfo
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/CultureInfo.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		CultureInfo,
		/// <summary>
		/// Binary
		/// Description for Castle.ActiveWriter.NHibernateType.Binary
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/Binary.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Binary,
		/// <summary>
		/// Type
		/// Description for Castle.ActiveWriter.NHibernateType.Type
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/Type.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Type,
		/// <summary>
		/// String
		/// Description for Castle.ActiveWriter.NHibernateType.String
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/String.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		String,
		/// <summary>
		/// StringClob
		/// Description for Castle.ActiveWriter.NHibernateType.StringClob
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/StringClob.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		StringClob,
		/// <summary>
		/// BinaryBlob
		/// Description for Castle.ActiveWriter.NHibernateType.BinaryBlob
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/BinaryBlob.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		BinaryBlob,
		/// <summary>
		/// Boolean
		/// Description for Castle.ActiveWriter.NHibernateType.Boolean
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/Boolean.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Boolean,
		/// <summary>
		/// Byte
		/// Description for Castle.ActiveWriter.NHibernateType.Byte
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/Byte.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Byte,
		/// <summary>
		/// Char
		/// Description for Castle.ActiveWriter.NHibernateType.Char
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/Char.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Char,
		/// <summary>
		/// DateTime
		/// Description for Castle.ActiveWriter.NHibernateType.DateTime
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/DateTime.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		DateTime,
		/// <summary>
		/// Decimal
		/// Description for Castle.ActiveWriter.NHibernateType.Decimal
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/Decimal.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Decimal,
		/// <summary>
		/// Double
		/// Description for Castle.ActiveWriter.NHibernateType.Double
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/Double.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Double,
		/// <summary>
		/// Guid
		/// Description for Castle.ActiveWriter.NHibernateType.Guid
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/Guid.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Guid,
		/// <summary>
		/// Int16
		/// Description for Castle.ActiveWriter.NHibernateType.Int16
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/Int16.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Int16,
		/// <summary>
		/// Int32
		/// Description for Castle.ActiveWriter.NHibernateType.Int32
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/Int32.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Int32,
		/// <summary>
		/// Int64
		/// Description for Castle.ActiveWriter.NHibernateType.Int64
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/Int64.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Int64,
		/// <summary>
		/// Ticks
		/// Description for Castle.ActiveWriter.NHibernateType.Ticks
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/Ticks.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Ticks,
		/// <summary>
		/// TimeSpan
		/// Description for Castle.ActiveWriter.NHibernateType.TimeSpan
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/TimeSpan.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		TimeSpan,
		/// <summary>
		/// Timestamp
		/// Description for Castle.ActiveWriter.NHibernateType.Timestamp
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/Timestamp.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Timestamp,
		/// <summary>
		/// TrueFalse
		/// Description for Castle.ActiveWriter.NHibernateType.TrueFalse
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/TrueFalse.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		TrueFalse,
		/// <summary>
		/// YesNo
		/// Description for Castle.ActiveWriter.NHibernateType.YesNo
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/YesNo.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		YesNo,
		/// <summary>
		/// Custom
		/// Description for Castle.ActiveWriter.NHibernateType.Custom
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NHibernateType/Custom.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Custom,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: Accessor
	/// Description for Castle.ActiveWriter.Accessor
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum Accessor
	{
		/// <summary>
		/// Public
		/// Description for Castle.ActiveWriter.Accessor.Public
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Accessor/Public.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Public,
		/// <summary>
		/// Private
		/// Description for Castle.ActiveWriter.Accessor.Private
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Accessor/Private.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Private,
		/// <summary>
		/// Protected
		/// Description for Castle.ActiveWriter.Accessor.Protected
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Accessor/Protected.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Protected,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: PropertyType
	/// Description for Castle.ActiveWriter.PropertyType
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum PropertyType
	{
		/// <summary>
		/// Property
		/// Description for Castle.ActiveWriter.PropertyType.Property
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PropertyType/Property.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Property,
		/// <summary>
		/// Field
		/// Description for Castle.ActiveWriter.PropertyType.Field
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PropertyType/Field.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Field,
		/// <summary>
		/// Version
		/// Description for Castle.ActiveWriter.PropertyType.Version
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PropertyType/Version.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Version,
		/// <summary>
		/// Timestamp
		/// Description for Castle.ActiveWriter.PropertyType.Timestamp
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.PropertyType/Timestamp.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Timestamp,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: FieldCase
	/// Description for Castle.ActiveWriter.FieldCase
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum FieldCase
	{
		/// <summary>
		/// Unchanged
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.FieldCase/Unchanged.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Unchanged,
		/// <summary>
		/// Camelcase
		/// Description for Castle.ActiveWriter.FieldCase.Camelcase
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.FieldCase/Camelcase.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Camelcase,
		/// <summary>
		/// CamelcaseUnderscore
		/// Description for Castle.ActiveWriter.FieldCase.CamelcaseUnderscore
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.FieldCase/CamelcaseUnderscore.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		CamelcaseUnderscore,
		/// <summary>
		/// CamelcaseMUnderscore
		/// Description for Castle.ActiveWriter.FieldCase.CamelcaseMUnderscore
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.FieldCase/CamelcaseMUnderscore.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		CamelcaseMUnderscore,
		/// <summary>
		/// Pascalcase
		/// Description for Castle.ActiveWriter.FieldCase.Pascalcase
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.FieldCase/Pascalcase.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Pascalcase,
		/// <summary>
		/// PascalcaseUnderscore
		/// Description for Castle.ActiveWriter.FieldCase.PascalcaseUnderscore
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.FieldCase/PascalcaseUnderscore.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		PascalcaseUnderscore,
		/// <summary>
		/// PascalcaseMUnderscore
		/// Description for Castle.ActiveWriter.FieldCase.PascalcaseMUnderscore
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.FieldCase/PascalcaseMUnderscore.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		PascalcaseMUnderscore,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: CodeLanguage
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum CodeLanguage
	{
		/// <summary>
		/// CSharp
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.CodeLanguage/CSharp.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		CSharp,
		/// <summary>
		/// VB
		/// Description for Castle.ActiveWriter.CodeLanguage.VB
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.CodeLanguage/VB.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		VB,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: NullableUsage
	/// Description for Castle.ActiveWriter.NullableUsage
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum NullableUsage
	{
		/// <summary>
		/// No
		/// Description for Castle.ActiveWriter.NullableUsage.No
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NullableUsage/No.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		No,
		/// <summary>
		/// Native
		/// Description for Castle.ActiveWriter.NullableUsage.Native
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NullableUsage/Native.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Native,
		/// <summary>
		/// WithHelperLibrary
		/// Description for Castle.ActiveWriter.NullableUsage.WithHelperLibrary
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NullableUsage/WithHelperLibrary.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		WithHelperLibrary,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: Polymorphism
	/// Description for Castle.ActiveWriter.Polymorphism
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum Polymorphism
	{
		/// <summary>
		/// Implicit
		/// Description for Castle.ActiveWriter.Polymorphism.Implicit
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Polymorphism/Implicit.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Implicit,
		/// <summary>
		/// Explicit
		/// Description for Castle.ActiveWriter.Polymorphism.Explicit
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Polymorphism/Explicit.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Explicit,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: OptimisticLocking
	/// Description for Castle.ActiveWriter.OptimisticLocking
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum OptimisticLocking
	{
		/// <summary>
		/// None
		/// Description for Castle.ActiveWriter.OptimisticLocking.None
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OptimisticLocking/None.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		None,
		/// <summary>
		/// Version
		/// Description for Castle.ActiveWriter.OptimisticLocking.Version
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OptimisticLocking/Version.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Version,
		/// <summary>
		/// Dirty
		/// Description for Castle.ActiveWriter.OptimisticLocking.Dirty
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OptimisticLocking/Dirty.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Dirty,
		/// <summary>
		/// All
		/// Description for Castle.ActiveWriter.OptimisticLocking.All
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OptimisticLocking/All.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		All,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: NotFoundBehaviour
	/// Description for Castle.ActiveWriter.NotFoundBehaviour
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum NotFoundBehaviour
	{
		/// <summary>
		/// Default
		/// Description for Castle.ActiveWriter.NotFoundBehaviour.Default
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NotFoundBehaviour/Default.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Default,
		/// <summary>
		/// Exception
		/// Description for Castle.ActiveWriter.NotFoundBehaviour.Exception
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NotFoundBehaviour/Exception.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Exception,
		/// <summary>
		/// Ignore
		/// Description for Castle.ActiveWriter.NotFoundBehaviour.Ignore
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NotFoundBehaviour/Ignore.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Ignore,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: CodeGenerationTarget
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum CodeGenerationTarget
	{
		/// <summary>
		/// ActiveRecord
		/// Description for Castle.ActiveWriter.CodeGenerationTarget.ActiveRecord
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.CodeGenerationTarget/ActiveRecord.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		ActiveRecord,
		/// <summary>
		/// NHibernate
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.CodeGenerationTarget/NHibernate.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		NHibernate,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: ManyRelationCascadeEnum
	/// Description for Castle.ActiveWriter.ManyRelationCascadeEnum
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum ManyRelationCascadeEnum
	{
		/// <summary>
		/// None
		/// Description for Castle.ActiveWriter.ManyRelationCascadeEnum.None
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyRelationCascadeEnum/None.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		None,
		/// <summary>
		/// All
		/// Description for Castle.ActiveWriter.ManyRelationCascadeEnum.All
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyRelationCascadeEnum/All.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		All,
		/// <summary>
		/// SaveUpdate
		/// Description for Castle.ActiveWriter.ManyRelationCascadeEnum.SaveUpdate
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyRelationCascadeEnum/SaveUpdate.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		SaveUpdate,
		/// <summary>
		/// Delete
		/// Description for Castle.ActiveWriter.ManyRelationCascadeEnum.Delete
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyRelationCascadeEnum/Delete.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Delete,
		/// <summary>
		/// AllDeleteOrphan
		/// Description for Castle.ActiveWriter.ManyRelationCascadeEnum.AllDeleteOrphan
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyRelationCascadeEnum/AllDeleteOrphan.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		AllDeleteOrphan,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: InheritableBoolean
	/// Description for Castle.ActiveWriter.InheritableBoolean
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum InheritableBoolean
	{
		/// <summary>
		/// True
		/// Description for Castle.ActiveWriter.InheritableBoolean.True
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritableBoolean/True.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		True,
		/// <summary>
		/// Inherit
		/// Description for Castle.ActiveWriter.InheritableBoolean.Inherit
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritableBoolean/Inherit.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Inherit,
		/// <summary>
		/// False
		/// Description for Castle.ActiveWriter.InheritableBoolean.False
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritableBoolean/False.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		False,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: FetchEnum
	/// Description for Castle.ActiveWriter.FetchEnum
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum FetchEnum
	{
		/// <summary>
		/// Select
		/// Description for Castle.ActiveWriter.FetchEnum.Select
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.FetchEnum/Select.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Select,
		/// <summary>
		/// Join
		/// Description for Castle.ActiveWriter.FetchEnum.Join
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.FetchEnum/Join.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Join,
		/// <summary>
		/// SubSelect
		/// Description for Castle.ActiveWriter.FetchEnum.SubSelect
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.FetchEnum/SubSelect.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		SubSelect,
		/// <summary>
		/// Unspecified
		/// Description for Castle.ActiveWriter.FetchEnum.Unspecified
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.FetchEnum/Unspecified.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Unspecified,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: MetaDataGeneration
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum MetaDataGeneration
	{
		/// <summary>
		/// False
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.MetaDataGeneration/False.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		False,
		/// <summary>
		/// InClass
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.MetaDataGeneration/InClass.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		InClass,
		/// <summary>
		/// InSubClass
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.MetaDataGeneration/InSubClass.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		InSubClass,
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainEnumeration: InheritablePropertyAccess
	/// Same as PropertyAccess, but with the ability to inherit from parents.
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum InheritablePropertyAccess
	{
		/// <summary>
		/// Inherit
		/// Description for Castle.ActiveWriter.InheritablePropertyAccess.Inherit
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritablePropertyAccess/Inherit.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Inherit,
		/// <summary>
		/// FieldLowercaseUnderscore
		/// Description for
		/// Castle.ActiveWriter.InheritablePropertyAccess.FieldLowercaseUnderscore
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritablePropertyAccess/FieldLowercaseUnderscore.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		FieldLowercaseUnderscore,
		/// <summary>
		/// FieldPascalcaseMUnderscore
		/// Description for
		/// Castle.ActiveWriter.InheritablePropertyAccess.FieldPascalcaseMUnderscore
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritablePropertyAccess/FieldPascalcaseMUnderscore.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		FieldPascalcaseMUnderscore,
		/// <summary>
		/// NosetterCamelcase
		/// Description for Castle.ActiveWriter.InheritablePropertyAccess.NosetterCamelcase
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritablePropertyAccess/NosetterCamelcase.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		NosetterCamelcase,
		/// <summary>
		/// NosetterCamelcaseUnderscore
		/// Description for
		/// Castle.ActiveWriter.InheritablePropertyAccess.NosetterCamelcaseUnderscore
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritablePropertyAccess/NosetterCamelcaseUnderscore.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		NosetterCamelcaseUnderscore,
		/// <summary>
		/// Property
		/// Description for Castle.ActiveWriter.InheritablePropertyAccess.Property
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritablePropertyAccess/Property.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Property,
		/// <summary>
		/// NosetterPascalcaseMUnderscore
		/// Description for
		/// Castle.ActiveWriter.InheritablePropertyAccess.NosetterPascalcaseMUnderscore
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritablePropertyAccess/NosetterPascalcaseMUnderscore.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		NosetterPascalcaseMUnderscore,
		/// <summary>
		/// NosetterLowercaseUnderscore
		/// Description for
		/// Castle.ActiveWriter.InheritablePropertyAccess.NosetterLowercaseUnderscore
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritablePropertyAccess/NosetterLowercaseUnderscore.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		NosetterLowercaseUnderscore,
		/// <summary>
		/// NosetterLowercase
		/// Description for Castle.ActiveWriter.InheritablePropertyAccess.NosetterLowercase
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritablePropertyAccess/NosetterLowercase.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		NosetterLowercase,
		/// <summary>
		/// Field
		/// Description for Castle.ActiveWriter.InheritablePropertyAccess.Field
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritablePropertyAccess/Field.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		Field,
		/// <summary>
		/// FieldCamelcase
		/// Description for Castle.ActiveWriter.InheritablePropertyAccess.FieldCamelcase
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritablePropertyAccess/FieldCamelcase.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		FieldCamelcase,
		/// <summary>
		/// FieldCamelcaseUnderscore
		/// Description for
		/// Castle.ActiveWriter.InheritablePropertyAccess.FieldCamelcaseUnderscore
		/// </summary>
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritablePropertyAccess/FieldCamelcaseUnderscore.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		FieldCamelcaseUnderscore,
	}
}


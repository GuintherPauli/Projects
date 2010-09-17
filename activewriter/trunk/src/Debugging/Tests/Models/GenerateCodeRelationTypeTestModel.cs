﻿ 
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Debugging.Tests.Models {
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using Castle.ActiveRecord;
    
    
    [ActiveRecord()]
    public partial class ModelClass1 : ActiveRecordBase<ModelClass1> {
        
        private string _id;
        
        private IList<ModelClass2> _d;
        
        private IList<ModelClass2> _f;
        
        private IList<ModelClass2> _b;
        
        [PrimaryKey(PrimaryKeyType.Native, ColumnType="String")]
        public virtual string Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [HasMany(typeof(ModelClass2), ColumnKey="c", RelationType=RelationType.List)]
        public virtual IList<ModelClass2> d {
            get {
                return this._d;
            }
            set {
                this._d = value;
            }
        }
        
        [HasMany(typeof(ModelClass2), ColumnKey="e", RelationType=RelationType.Map)]
        public virtual IList<ModelClass2> f {
            get {
                return this._f;
            }
            set {
                this._f = value;
            }
        }
        
        [HasAndBelongsToMany(typeof(ModelClass2), ColumnRef="Id", ColumnKey="Id", RelationType=RelationType.Bag, Table="Dummy")]
        public virtual IList<ModelClass2> b {
            get {
                return this._b;
            }
            set {
                this._b = value;
            }
        }
    }
    
    [ActiveRecord()]
    public partial class ModelClass2 : ActiveRecordBase<ModelClass2> {
        
        private string _id;
        
        private ModelClass1 _c;
        
        private ModelClass1 _e;
        
        private IList<ModelClass1> _a;
        
        [PrimaryKey(PrimaryKeyType.Native, ColumnType="String")]
        public virtual string Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [BelongsTo()]
        public virtual ModelClass1 c {
            get {
                return this._c;
            }
            set {
                this._c = value;
            }
        }
        
        [BelongsTo()]
        public virtual ModelClass1 e {
            get {
                return this._e;
            }
            set {
                this._e = value;
            }
        }
        
        [HasAndBelongsToMany(typeof(ModelClass1), ColumnRef="Id", ColumnKey="Id", RelationType=RelationType.Bag, Table="Dummy")]
        public virtual IList<ModelClass1> a {
            get {
                return this._a;
            }
            set {
                this._a = value;
            }
        }
    }
    
    public class GenerateCodeRelationTypeTestModelHelper {
        
        public static Type[] GetTypes() {
            return new Type[] {
                    typeof(ModelClass1),
                    typeof(ModelClass2)};
        }
    }
}

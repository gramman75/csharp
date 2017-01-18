﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQtoSQL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="gramman")]
	public partial class SampleTableDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 확장성 메서드 정의
    partial void OnCreated();
    partial void InsertSampleTable(SampleTable instance);
    partial void UpdateSampleTable(SampleTable instance);
    partial void DeleteSampleTable(SampleTable instance);
    #endregion
		
		public SampleTableDataContext() : 
				base(global::LINQtoSQL.Properties.Settings.Default.grammanConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SampleTableDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SampleTableDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SampleTableDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SampleTableDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SampleTable> SampleTable
		{
			get
			{
				return this.GetTable<SampleTable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SampleTable")]
	public partial class SampleTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<int> _id;
		
		private string _name;
		
		private System.Nullable<int> _age;
		
		private System.Nullable<System.DateTime> _birthDate;
		
    #region 확장성 메서드 정의
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(System.Nullable<int> value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnageChanging(System.Nullable<int> value);
    partial void OnageChanged();
    partial void OnbirthDateChanging(System.Nullable<System.DateTime> value);
    partial void OnbirthDateChanged();
    #endregion
		
		public SampleTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int", IsPrimaryKey=true)]
		public System.Nullable<int> id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(100)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_age", DbType="Int")]
		public System.Nullable<int> age
		{
			get
			{
				return this._age;
			}
			set
			{
				if ((this._age != value))
				{
					this.OnageChanging(value);
					this.SendPropertyChanging();
					this._age = value;
					this.SendPropertyChanged("age");
					this.OnageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birthDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> birthDate
		{
			get
			{
				return this._birthDate;
			}
			set
			{
				if ((this._birthDate != value))
				{
					this.OnbirthDateChanging(value);
					this.SendPropertyChanging();
					this._birthDate = value;
					this.SendPropertyChanged("birthDate");
					this.OnbirthDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591

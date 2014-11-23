﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication1.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="aspnet-MvcApplication1-20141021183026")]
	public partial class KabinetsModelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKabinet(Kabinet instance);
    partial void UpdateKabinet(Kabinet instance);
    partial void DeleteKabinet(Kabinet instance);
    #endregion
		
		public KabinetsModelDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["aspnet_MvcApplication1_20141021183026ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public KabinetsModelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KabinetsModelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KabinetsModelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KabinetsModelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Kabinet> Kabinets
		{
			get
			{
				return this.GetTable<Kabinet>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Kabinets")]
	public partial class Kabinet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _KabinetId;
		
		private int _UserId;
		
		private string _Name;
		
		private string _SurName;
		
		private string _Patshroryk;
		
		private System.DateTime _DateOfBirths;
		
		private string _PlaseOfBirds;
		
		private string _PlaseOfRegistration;
		
		private string _Street;
		
		private string _House;
		
		private string _Phone;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnKabinetIdChanging(int value);
    partial void OnKabinetIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurNameChanging(string value);
    partial void OnSurNameChanged();
    partial void OnPatshrorykChanging(string value);
    partial void OnPatshrorykChanged();
    partial void OnDateOfBirthsChanging(System.DateTime value);
    partial void OnDateOfBirthsChanged();
    partial void OnPlaseOfBirdsChanging(string value);
    partial void OnPlaseOfBirdsChanged();
    partial void OnPlaseOfRegistrationChanging(string value);
    partial void OnPlaseOfRegistrationChanged();
    partial void OnStreetChanging(string value);
    partial void OnStreetChanged();
    partial void OnHouseChanging(string value);
    partial void OnHouseChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    #endregion
		
		public Kabinet()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KabinetId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int KabinetId
		{
			get
			{
				return this._KabinetId;
			}
			set
			{
				if ((this._KabinetId != value))
				{
					this.OnKabinetIdChanging(value);
					this.SendPropertyChanging();
					this._KabinetId = value;
					this.SendPropertyChanged("KabinetId");
					this.OnKabinetIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SurName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SurName
		{
			get
			{
				return this._SurName;
			}
			set
			{
				if ((this._SurName != value))
				{
					this.OnSurNameChanging(value);
					this.SendPropertyChanging();
					this._SurName = value;
					this.SendPropertyChanged("SurName");
					this.OnSurNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Patshroryk", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Patshroryk
		{
			get
			{
				return this._Patshroryk;
			}
			set
			{
				if ((this._Patshroryk != value))
				{
					this.OnPatshrorykChanging(value);
					this.SendPropertyChanging();
					this._Patshroryk = value;
					this.SendPropertyChanged("Patshroryk");
					this.OnPatshrorykChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfBirths", DbType="Date NOT NULL")]
		public System.DateTime DateOfBirths
		{
			get
			{
				return this._DateOfBirths;
			}
			set
			{
				if ((this._DateOfBirths != value))
				{
					this.OnDateOfBirthsChanging(value);
					this.SendPropertyChanging();
					this._DateOfBirths = value;
					this.SendPropertyChanged("DateOfBirths");
					this.OnDateOfBirthsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlaseOfBirds", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PlaseOfBirds
		{
			get
			{
				return this._PlaseOfBirds;
			}
			set
			{
				if ((this._PlaseOfBirds != value))
				{
					this.OnPlaseOfBirdsChanging(value);
					this.SendPropertyChanging();
					this._PlaseOfBirds = value;
					this.SendPropertyChanged("PlaseOfBirds");
					this.OnPlaseOfBirdsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlaseOfRegistration", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PlaseOfRegistration
		{
			get
			{
				return this._PlaseOfRegistration;
			}
			set
			{
				if ((this._PlaseOfRegistration != value))
				{
					this.OnPlaseOfRegistrationChanging(value);
					this.SendPropertyChanging();
					this._PlaseOfRegistration = value;
					this.SendPropertyChanged("PlaseOfRegistration");
					this.OnPlaseOfRegistrationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Street", DbType="NVarChar(50)")]
		public string Street
		{
			get
			{
				return this._Street;
			}
			set
			{
				if ((this._Street != value))
				{
					this.OnStreetChanging(value);
					this.SendPropertyChanging();
					this._Street = value;
					this.SendPropertyChanged("Street");
					this.OnStreetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_House", DbType="NChar(10)")]
		public string House
		{
			get
			{
				return this._House;
			}
			set
			{
				if ((this._House != value))
				{
					this.OnHouseChanging(value);
					this.SendPropertyChanging();
					this._House = value;
					this.SendPropertyChanged("House");
					this.OnHouseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NChar(12)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
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
﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlsiUtils
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AlsiDb")]
	public partial class WebDbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTradeHistory(TradeHistory instance);
    partial void UpdateTradeHistory(TradeHistory instance);
    partial void DeleteTradeHistory(TradeHistory instance);
    partial void InsertSetting(Setting instance);
    partial void UpdateSetting(Setting instance);
    partial void DeleteSetting(Setting instance);
    partial void InsertIndicatorSetting(IndicatorSetting instance);
    partial void UpdateIndicatorSetting(IndicatorSetting instance);
    partial void DeleteIndicatorSetting(IndicatorSetting instance);
    partial void InsertWebTradeLog(WebTradeLog instance);
    partial void UpdateWebTradeLog(WebTradeLog instance);
    partial void DeleteWebTradeLog(WebTradeLog instance);
    partial void InsertEmailList(EmailList instance);
    partial void UpdateEmailList(EmailList instance);
    partial void DeleteEmailList(EmailList instance);
    partial void InsertSmsList(SmsList instance);
    partial void UpdateSmsList(SmsList instance);
    partial void DeleteSmsList(SmsList instance);
    #endregion
		
		public WebDbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebDbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebDbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebDbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TradeHistory> TradeHistories
		{
			get
			{
				return this.GetTable<TradeHistory>();
			}
		}
		
		public System.Data.Linq.Table<Setting> Settings
		{
			get
			{
				return this.GetTable<Setting>();
			}
		}
		
		public System.Data.Linq.Table<IndicatorSetting> IndicatorSettings
		{
			get
			{
				return this.GetTable<IndicatorSetting>();
			}
		}
		
		public System.Data.Linq.Table<WebTradeLog> WebTradeLogs
		{
			get
			{
				return this.GetTable<WebTradeLog>();
			}
		}
		
		public System.Data.Linq.Table<EmailList> EmailLists
		{
			get
			{
				return this.GetTable<EmailList>();
			}
		}
		
		public System.Data.Linq.Table<SmsList> SmsLists
		{
			get
			{
				return this.GetTable<SmsList>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Pieter.TradeHistory")]
	public partial class TradeHistory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _n;
		
		private System.Nullable<System.DateTime> _TimeStamp;
		
		private string _BuySell;
		
		private string _Reason;
		
		private System.Nullable<int> _Price;
		
		private System.Nullable<int> _Volume;
		
		private System.Nullable<int> _Trade_Profit;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnChanging(int value);
    partial void OnnChanged();
    partial void OnTimeStampChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeStampChanged();
    partial void OnBuySellChanging(string value);
    partial void OnBuySellChanged();
    partial void OnReasonChanging(string value);
    partial void OnReasonChanged();
    partial void OnPriceChanging(System.Nullable<int> value);
    partial void OnPriceChanged();
    partial void OnVolumeChanging(System.Nullable<int> value);
    partial void OnVolumeChanged();
    partial void OnTrade_ProfitChanging(System.Nullable<int> value);
    partial void OnTrade_ProfitChanged();
    #endregion
		
		public TradeHistory()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_n", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int n
		{
			get
			{
				return this._n;
			}
			set
			{
				if ((this._n != value))
				{
					this.OnnChanging(value);
					this.SendPropertyChanging();
					this._n = value;
					this.SendPropertyChanged("n");
					this.OnnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeStamp", DbType="DateTime")]
		public System.Nullable<System.DateTime> TimeStamp
		{
			get
			{
				return this._TimeStamp;
			}
			set
			{
				if ((this._TimeStamp != value))
				{
					this.OnTimeStampChanging(value);
					this.SendPropertyChanging();
					this._TimeStamp = value;
					this.SendPropertyChanged("TimeStamp");
					this.OnTimeStampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BuySell", DbType="VarChar(4)")]
		public string BuySell
		{
			get
			{
				return this._BuySell;
			}
			set
			{
				if ((this._BuySell != value))
				{
					this.OnBuySellChanging(value);
					this.SendPropertyChanging();
					this._BuySell = value;
					this.SendPropertyChanged("BuySell");
					this.OnBuySellChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Reason", DbType="VarChar(50)")]
		public string Reason
		{
			get
			{
				return this._Reason;
			}
			set
			{
				if ((this._Reason != value))
				{
					this.OnReasonChanging(value);
					this.SendPropertyChanging();
					this._Reason = value;
					this.SendPropertyChanged("Reason");
					this.OnReasonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int")]
		public System.Nullable<int> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Volume", DbType="Int")]
		public System.Nullable<int> Volume
		{
			get
			{
				return this._Volume;
			}
			set
			{
				if ((this._Volume != value))
				{
					this.OnVolumeChanging(value);
					this.SendPropertyChanging();
					this._Volume = value;
					this.SendPropertyChanged("Volume");
					this.OnVolumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Trade_Profit", DbType="Int")]
		public System.Nullable<int> Trade_Profit
		{
			get
			{
				return this._Trade_Profit;
			}
			set
			{
				if ((this._Trade_Profit != value))
				{
					this.OnTrade_ProfitChanging(value);
					this.SendPropertyChanging();
					this._Trade_Profit = value;
					this.SendPropertyChanged("Trade_Profit");
					this.OnTrade_ProfitChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Pieter.Settings")]
	public partial class Setting : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Setting_Name;
		
		private string _ValueString;
		
		private System.Nullable<int> _ValueNumber;
		
		private System.Nullable<System.DateTime> _ValueDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnSetting_NameChanging(string value);
    partial void OnSetting_NameChanged();
    partial void OnValueStringChanging(string value);
    partial void OnValueStringChanged();
    partial void OnValueNumberChanging(System.Nullable<int> value);
    partial void OnValueNumberChanged();
    partial void OnValueDateChanging(System.Nullable<System.DateTime> value);
    partial void OnValueDateChanged();
    #endregion
		
		public Setting()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Setting_Name", DbType="VarChar(50)")]
		public string Setting_Name
		{
			get
			{
				return this._Setting_Name;
			}
			set
			{
				if ((this._Setting_Name != value))
				{
					this.OnSetting_NameChanging(value);
					this.SendPropertyChanging();
					this._Setting_Name = value;
					this.SendPropertyChanged("Setting_Name");
					this.OnSetting_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValueString", DbType="VarChar(50)")]
		public string ValueString
		{
			get
			{
				return this._ValueString;
			}
			set
			{
				if ((this._ValueString != value))
				{
					this.OnValueStringChanging(value);
					this.SendPropertyChanging();
					this._ValueString = value;
					this.SendPropertyChanged("ValueString");
					this.OnValueStringChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValueNumber", DbType="Int")]
		public System.Nullable<int> ValueNumber
		{
			get
			{
				return this._ValueNumber;
			}
			set
			{
				if ((this._ValueNumber != value))
				{
					this.OnValueNumberChanging(value);
					this.SendPropertyChanging();
					this._ValueNumber = value;
					this.SendPropertyChanged("ValueNumber");
					this.OnValueNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValueDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ValueDate
		{
			get
			{
				return this._ValueDate;
			}
			set
			{
				if ((this._ValueDate != value))
				{
					this.OnValueDateChanging(value);
					this.SendPropertyChanging();
					this._ValueDate = value;
					this.SendPropertyChanged("ValueDate");
					this.OnValueDateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Pieter.IndicatorSettings")]
	public partial class IndicatorSetting : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private System.Nullable<int> _A1;
		
		private System.Nullable<int> _A2;
		
		private System.Nullable<int> _B1;
		
		private System.Nullable<int> _B2;
		
		private System.Nullable<int> _C1;
		
		private System.Nullable<int> _C2;
		
		private System.Nullable<int> _D1;
		
		private System.Nullable<int> _E1;
		
		private System.Nullable<int> _E2;
		
		private System.Nullable<int> _F1;
		
		private System.Nullable<int> _F2;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnA1Changing(System.Nullable<int> value);
    partial void OnA1Changed();
    partial void OnA2Changing(System.Nullable<int> value);
    partial void OnA2Changed();
    partial void OnB1Changing(System.Nullable<int> value);
    partial void OnB1Changed();
    partial void OnB2Changing(System.Nullable<int> value);
    partial void OnB2Changed();
    partial void OnC1Changing(System.Nullable<int> value);
    partial void OnC1Changed();
    partial void OnC2Changing(System.Nullable<int> value);
    partial void OnC2Changed();
    partial void OnD1Changing(System.Nullable<int> value);
    partial void OnD1Changed();
    partial void OnE1Changing(System.Nullable<int> value);
    partial void OnE1Changed();
    partial void OnE2Changing(System.Nullable<int> value);
    partial void OnE2Changed();
    partial void OnF1Changing(System.Nullable<int> value);
    partial void OnF1Changed();
    partial void OnF2Changing(System.Nullable<int> value);
    partial void OnF2Changed();
    #endregion
		
		public IndicatorSetting()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A1", DbType="Int")]
		public System.Nullable<int> A1
		{
			get
			{
				return this._A1;
			}
			set
			{
				if ((this._A1 != value))
				{
					this.OnA1Changing(value);
					this.SendPropertyChanging();
					this._A1 = value;
					this.SendPropertyChanged("A1");
					this.OnA1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A2", DbType="Int")]
		public System.Nullable<int> A2
		{
			get
			{
				return this._A2;
			}
			set
			{
				if ((this._A2 != value))
				{
					this.OnA2Changing(value);
					this.SendPropertyChanging();
					this._A2 = value;
					this.SendPropertyChanged("A2");
					this.OnA2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_B1", DbType="Int")]
		public System.Nullable<int> B1
		{
			get
			{
				return this._B1;
			}
			set
			{
				if ((this._B1 != value))
				{
					this.OnB1Changing(value);
					this.SendPropertyChanging();
					this._B1 = value;
					this.SendPropertyChanged("B1");
					this.OnB1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_B2", DbType="Int")]
		public System.Nullable<int> B2
		{
			get
			{
				return this._B2;
			}
			set
			{
				if ((this._B2 != value))
				{
					this.OnB2Changing(value);
					this.SendPropertyChanging();
					this._B2 = value;
					this.SendPropertyChanged("B2");
					this.OnB2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C1", DbType="Int")]
		public System.Nullable<int> C1
		{
			get
			{
				return this._C1;
			}
			set
			{
				if ((this._C1 != value))
				{
					this.OnC1Changing(value);
					this.SendPropertyChanging();
					this._C1 = value;
					this.SendPropertyChanged("C1");
					this.OnC1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C2", DbType="Int")]
		public System.Nullable<int> C2
		{
			get
			{
				return this._C2;
			}
			set
			{
				if ((this._C2 != value))
				{
					this.OnC2Changing(value);
					this.SendPropertyChanging();
					this._C2 = value;
					this.SendPropertyChanged("C2");
					this.OnC2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_D1", DbType="Int")]
		public System.Nullable<int> D1
		{
			get
			{
				return this._D1;
			}
			set
			{
				if ((this._D1 != value))
				{
					this.OnD1Changing(value);
					this.SendPropertyChanging();
					this._D1 = value;
					this.SendPropertyChanged("D1");
					this.OnD1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_E1", DbType="Int")]
		public System.Nullable<int> E1
		{
			get
			{
				return this._E1;
			}
			set
			{
				if ((this._E1 != value))
				{
					this.OnE1Changing(value);
					this.SendPropertyChanging();
					this._E1 = value;
					this.SendPropertyChanged("E1");
					this.OnE1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_E2", DbType="Int")]
		public System.Nullable<int> E2
		{
			get
			{
				return this._E2;
			}
			set
			{
				if ((this._E2 != value))
				{
					this.OnE2Changing(value);
					this.SendPropertyChanging();
					this._E2 = value;
					this.SendPropertyChanged("E2");
					this.OnE2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_F1", DbType="Int")]
		public System.Nullable<int> F1
		{
			get
			{
				return this._F1;
			}
			set
			{
				if ((this._F1 != value))
				{
					this.OnF1Changing(value);
					this.SendPropertyChanging();
					this._F1 = value;
					this.SendPropertyChanged("F1");
					this.OnF1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_F2", DbType="Int")]
		public System.Nullable<int> F2
		{
			get
			{
				return this._F2;
			}
			set
			{
				if ((this._F2 != value))
				{
					this.OnF2Changing(value);
					this.SendPropertyChanging();
					this._F2 = value;
					this.SendPropertyChanged("F2");
					this.OnF2Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Pieter.TradeLog")]
	public partial class WebTradeLog : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _N;
		
		private System.DateTime _Time;
		
		private string _BuySell;
		
		private string _Reason;
		
		private int _Price;
		
		private int _Volume;
		
		private string _Notes;
		
		private string _ForeColor;
		
		private string _BackColor;
		
		private int _PriceMatched;
		
		private bool _Matched;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNChanging(int value);
    partial void OnNChanged();
    partial void OnTimeChanging(System.DateTime value);
    partial void OnTimeChanged();
    partial void OnBuySellChanging(string value);
    partial void OnBuySellChanged();
    partial void OnReasonChanging(string value);
    partial void OnReasonChanged();
    partial void OnPriceChanging(int value);
    partial void OnPriceChanged();
    partial void OnVolumeChanging(int value);
    partial void OnVolumeChanged();
    partial void OnNotesChanging(string value);
    partial void OnNotesChanged();
    partial void OnForeColorChanging(string value);
    partial void OnForeColorChanged();
    partial void OnBackColorChanging(string value);
    partial void OnBackColorChanged();
    partial void OnPriceMatchedChanging(int value);
    partial void OnPriceMatchedChanged();
    partial void OnMatchedChanging(bool value);
    partial void OnMatchedChanged();
    #endregion
		
		public WebTradeLog()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_N", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int N
		{
			get
			{
				return this._N;
			}
			set
			{
				if ((this._N != value))
				{
					this.OnNChanging(value);
					this.SendPropertyChanging();
					this._N = value;
					this.SendPropertyChanged("N");
					this.OnNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="DateTime NOT NULL")]
		public System.DateTime Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				if ((this._Time != value))
				{
					this.OnTimeChanging(value);
					this.SendPropertyChanging();
					this._Time = value;
					this.SendPropertyChanged("Time");
					this.OnTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BuySell", DbType="VarChar(4) NOT NULL", CanBeNull=false)]
		public string BuySell
		{
			get
			{
				return this._BuySell;
			}
			set
			{
				if ((this._BuySell != value))
				{
					this.OnBuySellChanging(value);
					this.SendPropertyChanging();
					this._BuySell = value;
					this.SendPropertyChanged("BuySell");
					this.OnBuySellChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Reason", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Reason
		{
			get
			{
				return this._Reason;
			}
			set
			{
				if ((this._Reason != value))
				{
					this.OnReasonChanging(value);
					this.SendPropertyChanging();
					this._Reason = value;
					this.SendPropertyChanged("Reason");
					this.OnReasonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int NOT NULL")]
		public int Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Volume", DbType="Int NOT NULL")]
		public int Volume
		{
			get
			{
				return this._Volume;
			}
			set
			{
				if ((this._Volume != value))
				{
					this.OnVolumeChanging(value);
					this.SendPropertyChanging();
					this._Volume = value;
					this.SendPropertyChanged("Volume");
					this.OnVolumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="VarChar(300)")]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this.OnNotesChanging(value);
					this.SendPropertyChanging();
					this._Notes = value;
					this.SendPropertyChanged("Notes");
					this.OnNotesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ForeColor", DbType="VarChar(50)")]
		public string ForeColor
		{
			get
			{
				return this._ForeColor;
			}
			set
			{
				if ((this._ForeColor != value))
				{
					this.OnForeColorChanging(value);
					this.SendPropertyChanging();
					this._ForeColor = value;
					this.SendPropertyChanged("ForeColor");
					this.OnForeColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BackColor", DbType="VarChar(50)")]
		public string BackColor
		{
			get
			{
				return this._BackColor;
			}
			set
			{
				if ((this._BackColor != value))
				{
					this.OnBackColorChanging(value);
					this.SendPropertyChanging();
					this._BackColor = value;
					this.SendPropertyChanged("BackColor");
					this.OnBackColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PriceMatched", DbType="Int NOT NULL")]
		public int PriceMatched
		{
			get
			{
				return this._PriceMatched;
			}
			set
			{
				if ((this._PriceMatched != value))
				{
					this.OnPriceMatchedChanging(value);
					this.SendPropertyChanging();
					this._PriceMatched = value;
					this.SendPropertyChanged("PriceMatched");
					this.OnPriceMatchedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Matched", DbType="Bit NOT NULL")]
		public bool Matched
		{
			get
			{
				return this._Matched;
			}
			set
			{
				if ((this._Matched != value))
				{
					this.OnMatchedChanging(value);
					this.SendPropertyChanging();
					this._Matched = value;
					this.SendPropertyChanged("Matched");
					this.OnMatchedChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Pieter.EmailList")]
	public partial class EmailList : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Email;
		
		private System.Nullable<bool> _Active;
		
		private System.Nullable<bool> _Admin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    partial void OnAdminChanging(System.Nullable<bool> value);
    partial void OnAdminChanged();
    #endregion
		
		public EmailList()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Admin", DbType="Bit")]
		public System.Nullable<bool> Admin
		{
			get
			{
				return this._Admin;
			}
			set
			{
				if ((this._Admin != value))
				{
					this.OnAdminChanging(value);
					this.SendPropertyChanging();
					this._Admin = value;
					this.SendPropertyChanged("Admin");
					this.OnAdminChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Pieter.SmsList")]
	public partial class SmsList : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _TelNr;
		
		private System.Nullable<bool> _Active;
		
		private System.Nullable<bool> _Admin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnTelNrChanging(string value);
    partial void OnTelNrChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    partial void OnAdminChanging(System.Nullable<bool> value);
    partial void OnAdminChanged();
    #endregion
		
		public SmsList()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelNr", DbType="VarChar(50)")]
		public string TelNr
		{
			get
			{
				return this._TelNr;
			}
			set
			{
				if ((this._TelNr != value))
				{
					this.OnTelNrChanging(value);
					this.SendPropertyChanging();
					this._TelNr = value;
					this.SendPropertyChanged("TelNr");
					this.OnTelNrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Admin", DbType="Bit")]
		public System.Nullable<bool> Admin
		{
			get
			{
				return this._Admin;
			}
			set
			{
				if ((this._Admin != value))
				{
					this.OnAdminChanging(value);
					this.SendPropertyChanging();
					this._Admin = value;
					this.SendPropertyChanged("Admin");
					this.OnAdminChanged();
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

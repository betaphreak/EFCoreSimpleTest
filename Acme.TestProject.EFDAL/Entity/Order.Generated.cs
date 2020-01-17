//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 612
using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using Acme.TestProject.EFDAL;
using Acme.TestProject.EFDAL.EventArguments;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Acme.TestProject.EFDAL.Entity
{
	/// <summary>
	/// The 'Order' entity
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("nHydrate", "7.0.0")]
	[FieldNameConstants(typeof(Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants))]
	[EntityMetadata("Order", false,true, true, true, "", true, false, false, "dbo")]
	[MetadataTypeAttribute(typeof(Acme.TestProject.EFDAL.Entity.Metadata.OrderMetadata))]
	public partial class Order : BaseEntity, Acme.TestProject.EFDAL.IBusinessObject, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging, System.ICloneable, Acme.TestProject.EFDAL.IAuditable, Acme.TestProject.EFDAL.IAuditableSet, Acme.TestProject.EFDAL.ICreatable
	{
		#region FieldNameConstants Enumeration

		/// <summary>
		/// Enumeration to define each property that maps to a database field for the 'Order' table.
		/// </summary>
		public enum FieldNameConstants
		{
			/// <summary>
			/// Field mapping for the 'CustomerId' property
			/// </summary>
			CustomerId,
			/// <summary>
			/// Field mapping for the 'OrderId' property
			/// </summary>
			[System.ComponentModel.DataAnnotations.Key]
			[System.ComponentModel.DataAnnotations.Editable(false)]
			OrderId,
			/// <summary>
			/// Field mapping for the 'Price' property
			/// </summary>
			Price,
			/// <summary>
			/// Field mapping for the 'CreatedBy' property
			/// </summary>
			CreatedBy,
			/// <summary>
			/// Field mapping for the 'CreatedDate' property
			/// </summary>
			CreatedDate,
			/// <summary>
			/// Field mapping for the 'ModifiedBy' property
			/// </summary>
			ModifiedBy,
			/// <summary>
			/// Field mapping for the 'ModifiedDate' property
			/// </summary>
			ModifiedDate,
		}
		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the Order entity
		/// </summary>
		public Order()
		{
		}

		#endregion

		#region Properties

		/// <summary>
		/// The property that maps back to the database 'Order.CustomerId' field.
		/// </summary>
		/// <remarks>Field: [Order].[CustomerId], Not Nullable</remarks>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Always)]
		[System.ComponentModel.DataAnnotations.Display(Name = "CustomerId")]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual int CustomerId
		{
			get { return _customerId; }
			set
			{
				if (value == _customerId) return;
				var eventArg = new Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<int>(value, "CustomerId");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_customerId = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("CustomerId"));
			}
		}

		/// <summary>
		/// The property that maps back to the database 'Order.OrderId' field.
		/// </summary>
		/// <remarks>Field: [Order].[OrderId], Not Nullable, Primary Key, AutoNumber, Unique, Indexed</remarks>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Always)]
		[System.ComponentModel.DataAnnotations.Display(Name = "OrderId")]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual int OrderId
		{
			get { return _orderId; }
			protected internal set
			{
				if (value == _orderId) return;
				var eventArg = new Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<int>(value, "OrderId");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_orderId = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("OrderId"));
			}
		}

		/// <summary>
		/// The property that maps back to the database 'Order.Price' field.
		/// </summary>
		/// <remarks>Field: [Order].[Price], Not Nullable</remarks>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Always)]
		[System.ComponentModel.DataAnnotations.Display(Name = "Price")]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual int Price
		{
			get { return _price; }
			set
			{
				if (value == _price) return;
				var eventArg = new Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<int>(value, "Price");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_price = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("Price"));
			}
		}

		/// <summary>
		/// The audit field for the 'Created By' parameter.
		/// </summary>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Never)]
		[System.Diagnostics.DebuggerNonUserCode()]
		[AuditCreatedBy]
		public virtual string CreatedBy
		{
			get { return _createdby; }
			protected internal set
			{
				var eventArg = new Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<string>(value, "CreatedBy");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_createdby = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("CreatedBy"));
			}
		}

		/// <summary />
		protected string _createdby;

		/// <summary>
		/// The audit field for the 'Created Date' parameter.
		/// </summary>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Never)]
		[System.Diagnostics.DebuggerNonUserCode()]
		[AuditCreatedDate]
		public virtual DateTime CreatedDate
		{
			get { return _createddate; }
			protected internal set
			{
				var eventArg = new Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<DateTime>(value, "CreatedDate");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_createddate = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("CreatedDate"));
			}
		}

		/// <summary />
		protected DateTime _createddate;

		/// <summary>
		/// The audit field for the 'Modified By' parameter.
		/// </summary>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Never)]
		[System.Diagnostics.DebuggerNonUserCode()]
		[AuditModifiedBy]
		public virtual string ModifiedBy
		{
			get { return _modifiedby; }
			protected internal set
			{
				var eventArg = new Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<string>(value, "ModifiedBy");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_modifiedby = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("ModifiedBy"));
			}
		}

		/// <summary />
		protected string _modifiedby;

		/// <summary>
		/// The audit field for the 'Modified Date' parameter.
		/// </summary>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Never)]
		[System.Diagnostics.DebuggerNonUserCode()]
		[AuditModifiedDate]
		public virtual DateTime ModifiedDate
		{
			get { return _modifieddate; }
			protected internal set
			{
				var eventArg = new Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<DateTime>(value, "ModifiedDate");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_modifieddate = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("ModifiedDate"));
			}
		}

		/// <summary />
		protected DateTime _modifieddate;

		/// <summary>
		/// The audit field for the 'Timestamp' parameter.
		/// </summary>
		[System.ComponentModel.EditorBrowsable(EditorBrowsableState.Never)]
		[System.Diagnostics.DebuggerNonUserCode()]
		[AuditTimestamp]
		public virtual byte[] Timestamp
		{
			get { return _timestamp; }
			protected internal set
			{
				var eventArg = new Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<byte[]>(value, "Timestamp");
				this.OnPropertyChanging(eventArg);
				if (eventArg.Cancel) return;
				_timestamp = eventArg.Value;
				this.OnPropertyChanged(new PropertyChangedEventArgs("Timestamp"));
			}
		}

		/// <summary />
		protected byte[] _timestamp;

		#endregion

		#region Property Holders

		/// <summary />
		protected int _customerId;
		/// <summary>
		/// Occurs when the 'CustomerId' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<int>> CustomerIdChanging;

		/// <summary>
		/// Raises the OnCustomerIdChanging event.
		/// </summary>
		protected virtual void OnCustomerIdChanging(Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<int> e)
		{
			if (this.CustomerIdChanging != null)
				this.CustomerIdChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'CustomerId' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<int>> CustomerIdChanged;

		/// <summary>
		/// Raises the OnCustomerIdChanged event.
		/// </summary>
		protected virtual void OnCustomerIdChanged(ChangedEventArgs<int> e)
		{
			if (this.CustomerIdChanged != null)
				this.CustomerIdChanged(this, e);
		}

		/// <summary />
		protected int _orderId;
		/// <summary>
		/// Occurs when the 'OrderId' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<int>> OrderIdChanging;

		/// <summary>
		/// Raises the OnOrderIdChanging event.
		/// </summary>
		protected virtual void OnOrderIdChanging(Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<int> e)
		{
			if (this.OrderIdChanging != null)
				this.OrderIdChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'OrderId' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<int>> OrderIdChanged;

		/// <summary>
		/// Raises the OnOrderIdChanged event.
		/// </summary>
		protected virtual void OnOrderIdChanged(ChangedEventArgs<int> e)
		{
			if (this.OrderIdChanged != null)
				this.OrderIdChanged(this, e);
		}

		/// <summary />
		protected int _price;
		/// <summary>
		/// Occurs when the 'Price' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<int>> PriceChanging;

		/// <summary>
		/// Raises the OnPriceChanging event.
		/// </summary>
		protected virtual void OnPriceChanging(Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<int> e)
		{
			if (this.PriceChanging != null)
				this.PriceChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'Price' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<int>> PriceChanged;

		/// <summary>
		/// Raises the OnPriceChanged event.
		/// </summary>
		protected virtual void OnPriceChanged(ChangedEventArgs<int> e)
		{
			if (this.PriceChanged != null)
				this.PriceChanged(this, e);
		}

		/// <summary>
		/// Occurs when the 'CreatedBy' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<string>> CreatedByChanging;

		/// <summary>
		/// Raises the OnCreatedByChanging event.
		/// </summary>
		protected virtual void OnCreatedByChanging(Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<string> e)
		{
			if (this.CreatedByChanging != null)
				this.CreatedByChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'CreatedBy' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<string>> CreatedByChanged;

		/// <summary>
		/// Raises the OnCreatedByChanged event.
		/// </summary>
		protected virtual void OnCreatedByChanged(ChangedEventArgs<string> e)
		{
			if (this.CreatedByChanged != null)
				this.CreatedByChanged(this, e);
		}

		/// <summary>
		/// Occurs when the 'CreatedDate' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<DateTime>> CreatedDateChanging;

		/// <summary>
		/// Raises the OnCreatedDateChanging event.
		/// </summary>
		protected virtual void OnCreatedDateChanging(Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<DateTime> e)
		{
			if (this.CreatedDateChanging != null)
				this.CreatedDateChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'CreatedDate' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<DateTime>> CreatedDateChanged;

		/// <summary>
		/// Raises the OnCreatedDateChanged event.
		/// </summary>
		protected virtual void OnCreatedDateChanged(ChangedEventArgs<DateTime> e)
		{
			if (this.CreatedDateChanged != null)
				this.CreatedDateChanged(this, e);
		}

		/// <summary>
		/// Occurs when the 'ModifiedBy' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<string>> ModifiedByChanging;

		/// <summary>
		/// Raises the OnModifiedByChanging event.
		/// </summary>
		protected virtual void OnModifiedByChanging(Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<string> e)
		{
			if (this.ModifiedByChanging != null)
				this.ModifiedByChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'ModifiedBy' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<string>> ModifiedByChanged;

		/// <summary>
		/// Raises the OnModifiedByChanged event.
		/// </summary>
		protected virtual void OnModifiedByChanged(ChangedEventArgs<string> e)
		{
			if (this.ModifiedByChanged != null)
				this.ModifiedByChanged(this, e);
		}

		/// <summary>
		/// Occurs when the 'ModifiedDate' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<DateTime>> ModifiedDateChanging;

		/// <summary>
		/// Raises the OnModifiedDateChanging event.
		/// </summary>
		protected virtual void OnModifiedDateChanging(Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<DateTime> e)
		{
			if (this.ModifiedDateChanging != null)
				this.ModifiedDateChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'ModifiedDate' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<DateTime>> ModifiedDateChanged;

		/// <summary>
		/// Raises the OnModifiedDateChanged event.
		/// </summary>
		protected virtual void OnModifiedDateChanged(ChangedEventArgs<DateTime> e)
		{
			if (this.ModifiedDateChanged != null)
				this.ModifiedDateChanged(this, e);
		}

		/// <summary>
		/// Occurs when the 'Timestamp' property value change is a pending.
		/// </summary>
		public event EventHandler<Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<byte[]>> TimestampChanging;

		/// <summary>
		/// Raises the OnTimestampChanging event.
		/// </summary>
		protected virtual void OnTimestampChanging(Acme.TestProject.EFDAL.EventArguments.ChangingEventArgs<byte[]> e)
		{
			if (this.TimestampChanging != null)
				this.TimestampChanging(this, e);
		}

		/// <summary>
		/// Occurs when the 'Timestamp' property value has changed.
		/// </summary>
		public event EventHandler<ChangedEventArgs<byte[]>> TimestampChanged;

		/// <summary>
		/// Raises the OnTimestampChanged event.
		/// </summary>
		protected virtual void OnTimestampChanged(ChangedEventArgs<byte[]> e)
		{
			if (this.TimestampChanged != null)
				this.TimestampChanged(this, e);
		}


		#endregion

		#region GetMaxLength

		/// <summary>
		/// Gets the maximum size of the field value.
		/// </summary>
		public static int GetMaxLength(Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants field)
		{
			switch (field)
			{
				case Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants.CustomerId:
					return 0; //Type=Int
				case Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants.OrderId:
					return 0; //Type=Int
				case Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants.Price:
					return 0; //Type=Int
			}
			return 0;
		}

		int Acme.TestProject.EFDAL.IReadOnlyBusinessObject.GetMaxLength(Enum field)
		{
			return GetMaxLength((Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants)field);
		}

		#endregion

		#region GetFieldNameConstants

		System.Type Acme.TestProject.EFDAL.IReadOnlyBusinessObject.GetFieldNameConstants()
		{
			return typeof(Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants);
		}

		#endregion

		#region GetFieldType

		/// <summary>
		/// Gets the system type of a field on this object
		/// </summary>
		public static System.Type GetFieldType(Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants field)
		{
			if (field.GetType() != typeof(Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants))
				throw new Exception("The field parameter must be of type 'Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants'.");

			switch ((Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants)field)
			{
				case Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants.CustomerId: return typeof(int);
				case Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants.OrderId: return typeof(int);
				case Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants.Price: return typeof(int);
			}
			return null;
		}

		System.Type Acme.TestProject.EFDAL.IReadOnlyBusinessObject.GetFieldType(Enum field)
		{
			if (field.GetType() != typeof(Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants))
				throw new Exception("The field parameter must be of type 'Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants'.");

			return GetFieldType((Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants)field);
		}

		#endregion

		#region Get/Set Value

		object Acme.TestProject.EFDAL.IReadOnlyBusinessObject.GetValue(System.Enum field)
		{
			return ((Acme.TestProject.EFDAL.IReadOnlyBusinessObject)this).GetValue(field, null);
		}

		object Acme.TestProject.EFDAL.IReadOnlyBusinessObject.GetValue(System.Enum field, object defaultValue)
		{
			if (field.GetType() != typeof(Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants))
				throw new Exception("The field parameter must be of type 'Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants'.");
			return this.GetValue((Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants)field, defaultValue);
		}

		void Acme.TestProject.EFDAL.IBusinessObject.SetValue(System.Enum field, object newValue)
		{
			if (field.GetType() != typeof(Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants))
				throw new Exception("The field parameter must be of type 'Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants'.");
			this.SetValue((Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants)field, newValue);
		}

		void Acme.TestProject.EFDAL.IBusinessObject.SetValue(System.Enum field, object newValue, bool fixLength)
		{
			if (field.GetType() != typeof(Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants))
				throw new Exception("The field parameter must be of type 'Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants'.");
			this.SetValue((Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants)field, newValue, fixLength);
		}

		#endregion

		#region PrimaryKey

		/// <summary>
		/// Generic primary key for this object
		/// </summary>
		Acme.TestProject.EFDAL.IPrimaryKey Acme.TestProject.EFDAL.IReadOnlyBusinessObject.PrimaryKey
		{
			get { return new PrimaryKey(Util.HashPK("Order", this.OrderId)); }
		}

		#endregion

		#region Clone

		/// <summary>
		/// Creates a shallow copy of this object
		/// </summary>
		public virtual object Clone()
		{
			return Acme.TestProject.EFDAL.Entity.Order.Clone(this);
		}

		/// <summary>
		/// Creates a shallow copy of this object with defined, default values and new PK
		/// </summary>
		public virtual object CloneAsNew()
		{
			var item = Acme.TestProject.EFDAL.Entity.Order.Clone(this);
			item._orderId = 0;
			return item;
		}

		/// <summary>
		/// Creates a shallow copy of this object
		/// </summary>
		public static Order Clone(Acme.TestProject.EFDAL.Entity.Order item)
		{
			var newItem = new Order();
			newItem.CustomerId = item.CustomerId;
			newItem.OrderId = item.OrderId;
			newItem.Price = item.Price;
			newItem.CreatedDate = item.CreatedDate;
			newItem.CreatedBy = item.CreatedBy;
			newItem.ModifiedDate = item.ModifiedDate;
			newItem.ModifiedBy = item.ModifiedBy;
			return newItem;
		}

		#endregion

		#region GetValue

		/// <summary>
		/// Gets the value of one of this object's properties.
		/// </summary>
		public virtual object GetValue(Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants field)
		{
			return GetValue(field, null);
		}

		/// <summary>
		/// Gets the value of one of this object's properties.
		/// </summary>
		public virtual object GetValue(Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants field, object defaultValue)
		{
			if (field == Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants.CustomerId)
				return this.CustomerId;
			if (field == Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants.OrderId)
				return this.OrderId;
			if (field == Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants.Price)
				return this.Price;
			if (field == Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants.CreatedBy)
				return ((this.CreatedBy == null) ? defaultValue : this.CreatedBy);
			if (field == Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants.CreatedDate)
				return ((this.CreatedDate == null) ? defaultValue : this.CreatedDate);
			if (field == Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants.ModifiedBy)
				return ((this.ModifiedBy == null) ? defaultValue : this.ModifiedBy);
			if (field == Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants.ModifiedDate)
				return ((this.ModifiedDate == null) ? defaultValue : this.ModifiedDate);
			throw new Exception("Field '" + field.ToString() + "' not found!");
		}

		#endregion

		#region SetValue

		/// <summary>
		/// Assigns a value to a field on this object.
		/// </summary>
		/// <param name="field">The field to set</param>
		/// <param name="newValue">The new value to assign to the field</param>
		public virtual void SetValue(Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants field, object newValue)
		{
			SetValue(field, newValue, false);
		}

		/// <summary>
		/// Assigns a value to a field on this object.
		/// </summary>
		/// <param name="field">The field to set</param>
		/// <param name="newValue">The new value to assign to the field</param>
		/// <param name="fixLength">Determines if the length should be truncated if too long. When false, an error will be raised if data is too large to be assigned to the field.</param>
		public virtual void SetValue(Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants field, object newValue, bool fixLength)
		{
			if (field == Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants.CustomerId)
			{
				this.CustomerId = GlobalValues.SetValueHelperIntNotNullableInternal(newValue, "Field 'CustomerId' does not allow null values!");
			}
			else if (field == Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants.OrderId)
			{
				throw new Exception("Field '" + field.ToString() + "' is a primary key and cannot be set!");
			}
			else if (field == Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants.Price)
			{
				this.Price = GlobalValues.SetValueHelperIntNotNullableInternal(newValue, "Field 'Price' does not allow null values!");
			}
			else
				throw new Exception("Field '" + field.ToString() + "' not found!");
		}

		#endregion

		#region Navigation Properties

		/// <summary>
		/// The navigation definition for walking Customer->Order
		/// </summary>
		public virtual Customer Customer { get; set; }

		#endregion

		#region GetDatabaseFieldName

		/// <summary>
		/// Returns the actual database name of the specified field.
		/// </summary>
		internal static string GetDatabaseFieldName(Acme.TestProject.EFDAL.Entity.Order.FieldNameConstants field)
		{
			return GetDatabaseFieldName(field.ToString());
		}

		/// <summary>
		/// Returns the actual database name of the specified field.
		/// </summary>
		internal static string GetDatabaseFieldName(string field)
		{
			switch (field)
			{
				case "CustomerId": return "CustomerId";
				case "OrderId": return "OrderId";
				case "Price": return "Price";
				case "CreatedBy": return "CreatedBy";
				case "CreatedDate": return "CreatedDate";
				case "ModifiedBy": return "ModifiedBy";
				case "ModifiedDate": return "ModifiedDate";
				case "Timestamp": return "Timestamp";
			}
			return string.Empty;
		}

		#endregion

		#region Auditing
		string Acme.TestProject.EFDAL.IAuditableSet.CreatedBy
		{
			set { this.CreatedBy = value; }
		}

		string Acme.TestProject.EFDAL.IAuditableSet.ModifiedBy
		{
			set { this.ModifiedBy = value; }
		}

		string Acme.TestProject.EFDAL.IAuditable.CreatedBy
		{
			get { return this.CreatedBy; }
		}

		System.DateTime? Acme.TestProject.EFDAL.IAuditable.CreatedDate
		{
			get { return this.CreatedDate; }
		}

		bool Acme.TestProject.EFDAL.IAuditable.IsCreateAuditImplemented
		{
			get { return true; }
		}

		bool Acme.TestProject.EFDAL.IAuditable.IsModifyAuditImplemented
		{
			get { return true; }
		}

		bool Acme.TestProject.EFDAL.IAuditable.IsTimestampAuditImplemented
		{
			get { return true; }
		}

		string Acme.TestProject.EFDAL.IAuditable.ModifiedBy
		{
			get { return this.ModifiedBy; }
		}

		System.DateTime? Acme.TestProject.EFDAL.IAuditable.ModifiedDate
		{
			get { return this.ModifiedDate; }
		}

		byte[] Acme.TestProject.EFDAL.IAuditable.TimeStamp
		{
			get { return this.Timestamp; }
		}

		System.DateTime Acme.TestProject.EFDAL.IAuditableSet.CreatedDate
		{
			set { this.CreatedDate = value; }
		}

		System.DateTime Acme.TestProject.EFDAL.IAuditableSet.ModifiedDate
		{
			set { this.ModifiedDate = value; }
		}

		#endregion

		#region Equals
		/// <summary>
		/// Compares two objects of 'Order' type and determines if all properties match
		/// </summary>
		/// <returns>True if all properties match, false otherwise</returns>
		public override bool Equals(object obj)
		{
			var other = obj as Acme.TestProject.EFDAL.Entity.Order;
			if (other == null) return false;
			return (
				other.CustomerId == this.CustomerId &&
				other.OrderId == this.OrderId &&
				other.Price == this.Price
				);
		}

		/// <summary>
		/// Serves as a hash function for this type.
		/// </summary>
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		#endregion

	}
}

#region Metadata Class

namespace Acme.TestProject.EFDAL.Entity.Metadata
{
	/// <summary>
	/// Metadata class for the 'Order' entity
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("nHydrate", "7.0.0")]
	public partial class OrderMetadata : Acme.TestProject.EFDAL.IMetadata
	{
		#region Properties

		/// <summary>
		/// Metadata information for the 'CustomerId' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "'CustomerId' is required.", AllowEmptyStrings = true)]
		[System.ComponentModel.DataAnnotations.Display(Description = "", Name = "CustomerId", AutoGenerateField = true)]
		public object CustomerId;

		/// <summary>
		/// Metadata information for the 'OrderId' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "'OrderId' is required.", AllowEmptyStrings = true)]
		[System.ComponentModel.DataAnnotations.Key()]
		[System.ComponentModel.DataAnnotations.Editable(false)]
		[System.ComponentModel.DataAnnotations.Display(Description = "", Name = "OrderId", AutoGenerateField = true)]
		public object OrderId;

		/// <summary>
		/// Metadata information for the 'Price' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "'Price' is required.", AllowEmptyStrings = true)]
		[System.ComponentModel.DataAnnotations.Display(Description = "", Name = "Price", AutoGenerateField = true)]
		public object Price;

		/// <summary>
		/// Metadata information for the 'CreatedBy' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.StringLength(100, ErrorMessage = "The property 'CreatedBy' has a maximum length of 100")]
		[System.ComponentModel.DataAnnotations.Editable(false)]
		public object CreatedBy;

		/// <summary>
		/// Metadata information for the 'CreatedDate' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Editable(false)]
		public object CreatedDate;

		/// <summary>
		/// Metadata information for the 'ModifiedBy' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.StringLength(100, ErrorMessage = "The property 'ModifiedBy' has a maximum length of 100")]
		[System.ComponentModel.DataAnnotations.Editable(false)]
		public object ModifiedBy;

		/// <summary>
		/// Metadata information for the 'ModifiedDate' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Editable(false)]
		public object ModifiedDate;

		/// <summary>
		/// Metadata information for the 'Timestamp' parameter
		/// </summary>
		[System.ComponentModel.DataAnnotations.Timestamp()]
		[System.ComponentModel.DataAnnotations.ConcurrencyCheck()]
		[System.ComponentModel.DataAnnotations.Editable(false)]
		public object Timestamp;

		#endregion

		#region Methods
		/// <summary />
		public virtual string GetTableName()
		{
			return "Order";
		}

		/// <summary>
		/// Gets a list of all object fields with alias/code facade applied excluding inheritance.
		/// </summary>
		public virtual List<string> GetFields()
		{
			var retval = new List<string>();
			retval.Add("CustomerId");
			retval.Add("OrderId");
			retval.Add("Price");
			return retval;
		}

		/// <summary>
		/// Returns the type of the parent object if one exists.
		/// </summary>
		public virtual System.Type InheritsFrom()
		{
			return null;
		}

		/// <summary>
		/// Returns the database schema name.
		/// </summary>
		public virtual string Schema()
		{
			return "dbo";
		}

		/// <summary>
		/// Returns the actual database name of the specified field.
		/// </summary>
		public virtual string GetDatabaseFieldName(string field)
		{
			switch (field)
			{
				case "CustomerId": return "CustomerId";
				case "OrderId": return "OrderId";
				case "Price": return "Price";
				case "CreatedBy": return "CreatedBy";
				case "CreatedDate": return "CreatedDate";
				case "ModifiedBy": return "ModifiedBy";
				case "ModifiedDate": return "ModifiedDate";
				case "Timestamp": return "Timestamp";
			}
			return string.Empty;
		}

		#endregion

	}

}

#endregion

#pragma warning restore 612

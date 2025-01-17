﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNHANVIENFULL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLNHANVIEN")]
	public partial class EmployeeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertDepartment(Department instance);
    partial void UpdateDepartment(Department instance);
    partial void DeleteDepartment(Department instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertSalary(Salary instance);
    partial void UpdateSalary(Salary instance);
    partial void DeleteSalary(Salary instance);
    #endregion
		
		public EmployeeDataContext() : 
				base(global::QLNHANVIENFULL.Properties.Settings.Default.QLNHANVIENConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EmployeeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmployeeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmployeeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmployeeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<Department> Departments
		{
			get
			{
				return this.GetTable<Department>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Salary> Salaries
		{
			get
			{
				return this.GetTable<Salary>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _username;
		
		private string _password;
		
		private int _ID;
		
		private string _Email;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public Account()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(500)")]
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Department")]
	public partial class Department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DepId;
		
		private string _DepName;
		
		private EntitySet<Employee> _Employees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDepIdChanging(int value);
    partial void OnDepIdChanged();
    partial void OnDepNameChanging(string value);
    partial void OnDepNameChanged();
    #endregion
		
		public Department()
		{
			this._Employees = new EntitySet<Employee>(new Action<Employee>(this.attach_Employees), new Action<Employee>(this.detach_Employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DepId
		{
			get
			{
				return this._DepId;
			}
			set
			{
				if ((this._DepId != value))
				{
					this.OnDepIdChanging(value);
					this.SendPropertyChanging();
					this._DepId = value;
					this.SendPropertyChanged("DepId");
					this.OnDepIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string DepName
		{
			get
			{
				return this._DepName;
			}
			set
			{
				if ((this._DepName != value))
				{
					this.OnDepNameChanging(value);
					this.SendPropertyChanging();
					this._DepName = value;
					this.SendPropertyChanged("DepName");
					this.OnDepNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employee", Storage="_Employees", ThisKey="DepId", OtherKey="EmpDep")]
		public EntitySet<Employee> Employees
		{
			get
			{
				return this._Employees;
			}
			set
			{
				this._Employees.Assign(value);
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
		
		private void attach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Department = this;
		}
		
		private void detach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Department = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmpID;
		
		private string _EmpName;
		
		private string _EmpGen;
		
		private int _EmpDep;
		
		private System.DateTime _EmpDOB;
		
		private System.DateTime _EmpJDate;
		
		private int _EmpSal;
		
		private string _EmpImage;
		
		private EntitySet<Salary> _Salaries;
		
		private EntityRef<Department> _Department;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmpIDChanging(int value);
    partial void OnEmpIDChanged();
    partial void OnEmpNameChanging(string value);
    partial void OnEmpNameChanged();
    partial void OnEmpGenChanging(string value);
    partial void OnEmpGenChanged();
    partial void OnEmpDepChanging(int value);
    partial void OnEmpDepChanged();
    partial void OnEmpDOBChanging(System.DateTime value);
    partial void OnEmpDOBChanged();
    partial void OnEmpJDateChanging(System.DateTime value);
    partial void OnEmpJDateChanged();
    partial void OnEmpSalChanging(int value);
    partial void OnEmpSalChanged();
    partial void OnEmpImageChanging(string value);
    partial void OnEmpImageChanged();
    #endregion
		
		public Employee()
		{
			this._Salaries = new EntitySet<Salary>(new Action<Salary>(this.attach_Salaries), new Action<Salary>(this.detach_Salaries));
			this._Department = default(EntityRef<Department>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EmpID
		{
			get
			{
				return this._EmpID;
			}
			set
			{
				if ((this._EmpID != value))
				{
					this.OnEmpIDChanging(value);
					this.SendPropertyChanging();
					this._EmpID = value;
					this.SendPropertyChanged("EmpID");
					this.OnEmpIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string EmpName
		{
			get
			{
				return this._EmpName;
			}
			set
			{
				if ((this._EmpName != value))
				{
					this.OnEmpNameChanging(value);
					this.SendPropertyChanging();
					this._EmpName = value;
					this.SendPropertyChanged("EmpName");
					this.OnEmpNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpGen", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string EmpGen
		{
			get
			{
				return this._EmpGen;
			}
			set
			{
				if ((this._EmpGen != value))
				{
					this.OnEmpGenChanging(value);
					this.SendPropertyChanging();
					this._EmpGen = value;
					this.SendPropertyChanged("EmpGen");
					this.OnEmpGenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpDep", DbType="Int NOT NULL")]
		public int EmpDep
		{
			get
			{
				return this._EmpDep;
			}
			set
			{
				if ((this._EmpDep != value))
				{
					if (this._Department.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmpDepChanging(value);
					this.SendPropertyChanging();
					this._EmpDep = value;
					this.SendPropertyChanged("EmpDep");
					this.OnEmpDepChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpDOB", DbType="Date NOT NULL")]
		public System.DateTime EmpDOB
		{
			get
			{
				return this._EmpDOB;
			}
			set
			{
				if ((this._EmpDOB != value))
				{
					this.OnEmpDOBChanging(value);
					this.SendPropertyChanging();
					this._EmpDOB = value;
					this.SendPropertyChanged("EmpDOB");
					this.OnEmpDOBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpJDate", DbType="Date NOT NULL")]
		public System.DateTime EmpJDate
		{
			get
			{
				return this._EmpJDate;
			}
			set
			{
				if ((this._EmpJDate != value))
				{
					this.OnEmpJDateChanging(value);
					this.SendPropertyChanging();
					this._EmpJDate = value;
					this.SendPropertyChanged("EmpJDate");
					this.OnEmpJDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpSal", DbType="Int NOT NULL")]
		public int EmpSal
		{
			get
			{
				return this._EmpSal;
			}
			set
			{
				if ((this._EmpSal != value))
				{
					this.OnEmpSalChanging(value);
					this.SendPropertyChanging();
					this._EmpSal = value;
					this.SendPropertyChanged("EmpSal");
					this.OnEmpSalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpImage", DbType="VarChar(500)")]
		public string EmpImage
		{
			get
			{
				return this._EmpImage;
			}
			set
			{
				if ((this._EmpImage != value))
				{
					this.OnEmpImageChanging(value);
					this.SendPropertyChanging();
					this._EmpImage = value;
					this.SendPropertyChanged("EmpImage");
					this.OnEmpImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_Salary", Storage="_Salaries", ThisKey="EmpID", OtherKey="EmployeeID")]
		public EntitySet<Salary> Salaries
		{
			get
			{
				return this._Salaries;
			}
			set
			{
				this._Salaries.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employee", Storage="_Department", ThisKey="EmpDep", OtherKey="DepId", IsForeignKey=true)]
		public Department Department
		{
			get
			{
				return this._Department.Entity;
			}
			set
			{
				Department previousValue = this._Department.Entity;
				if (((previousValue != value) 
							|| (this._Department.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Department.Entity = null;
						previousValue.Employees.Remove(this);
					}
					this._Department.Entity = value;
					if ((value != null))
					{
						value.Employees.Add(this);
						this._EmpDep = value.DepId;
					}
					else
					{
						this._EmpDep = default(int);
					}
					this.SendPropertyChanged("Department");
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
		
		private void attach_Salaries(Salary entity)
		{
			this.SendPropertyChanging();
			entity.Employee = this;
		}
		
		private void detach_Salaries(Salary entity)
		{
			this.SendPropertyChanging();
			entity.Employee = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Salary")]
	public partial class Salary : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Scode;
		
		private int _EmployeeID;
		
		private int _Period;
		
		private int _Salary1;
		
		private System.DateTime _Paydate;
		
		private string _EmployeeName;
		
		private System.DateTime _From;
		
		private System.DateTime _To;
		
		private System.Nullable<int> _totalsal;
		
		private EntityRef<Employee> _Employee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnScodeChanging(int value);
    partial void OnScodeChanged();
    partial void OnEmployeeIDChanging(int value);
    partial void OnEmployeeIDChanged();
    partial void OnPeriodChanging(int value);
    partial void OnPeriodChanged();
    partial void OnSalary1Changing(int value);
    partial void OnSalary1Changed();
    partial void OnPaydateChanging(System.DateTime value);
    partial void OnPaydateChanged();
    partial void OnEmployeeNameChanging(string value);
    partial void OnEmployeeNameChanged();
    partial void OnFromChanging(System.DateTime value);
    partial void OnFromChanged();
    partial void OnToChanging(System.DateTime value);
    partial void OnToChanged();
    partial void OntotalsalChanging(System.Nullable<int> value);
    partial void OntotalsalChanged();
    #endregion
		
		public Salary()
		{
			this._Employee = default(EntityRef<Employee>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Scode", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Scode
		{
			get
			{
				return this._Scode;
			}
			set
			{
				if ((this._Scode != value))
				{
					this.OnScodeChanging(value);
					this.SendPropertyChanging();
					this._Scode = value;
					this.SendPropertyChanged("Scode");
					this.OnScodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", DbType="Int NOT NULL")]
		public int EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					if (this._Employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Period", DbType="Int NOT NULL")]
		public int Period
		{
			get
			{
				return this._Period;
			}
			set
			{
				if ((this._Period != value))
				{
					this.OnPeriodChanging(value);
					this.SendPropertyChanging();
					this._Period = value;
					this.SendPropertyChanged("Period");
					this.OnPeriodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Salary", Storage="_Salary1", DbType="Int NOT NULL")]
		public int Salary1
		{
			get
			{
				return this._Salary1;
			}
			set
			{
				if ((this._Salary1 != value))
				{
					this.OnSalary1Changing(value);
					this.SendPropertyChanging();
					this._Salary1 = value;
					this.SendPropertyChanged("Salary1");
					this.OnSalary1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Paydate", DbType="Date NOT NULL")]
		public System.DateTime Paydate
		{
			get
			{
				return this._Paydate;
			}
			set
			{
				if ((this._Paydate != value))
				{
					this.OnPaydateChanging(value);
					this.SendPropertyChanging();
					this._Paydate = value;
					this.SendPropertyChanged("Paydate");
					this.OnPaydateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string EmployeeName
		{
			get
			{
				return this._EmployeeName;
			}
			set
			{
				if ((this._EmployeeName != value))
				{
					this.OnEmployeeNameChanging(value);
					this.SendPropertyChanging();
					this._EmployeeName = value;
					this.SendPropertyChanged("EmployeeName");
					this.OnEmployeeNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[From]", Storage="_From", DbType="Date NOT NULL")]
		public System.DateTime From
		{
			get
			{
				return this._From;
			}
			set
			{
				if ((this._From != value))
				{
					this.OnFromChanging(value);
					this.SendPropertyChanging();
					this._From = value;
					this.SendPropertyChanged("From");
					this.OnFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[To]", Storage="_To", DbType="Date NOT NULL")]
		public System.DateTime To
		{
			get
			{
				return this._To;
			}
			set
			{
				if ((this._To != value))
				{
					this.OnToChanging(value);
					this.SendPropertyChanging();
					this._To = value;
					this.SendPropertyChanged("To");
					this.OnToChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalsal", DbType="Int")]
		public System.Nullable<int> totalsal
		{
			get
			{
				return this._totalsal;
			}
			set
			{
				if ((this._totalsal != value))
				{
					this.OntotalsalChanging(value);
					this.SendPropertyChanging();
					this._totalsal = value;
					this.SendPropertyChanged("totalsal");
					this.OntotalsalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_Salary", Storage="_Employee", ThisKey="EmployeeID", OtherKey="EmpID", IsForeignKey=true)]
		public Employee Employee
		{
			get
			{
				return this._Employee.Entity;
			}
			set
			{
				Employee previousValue = this._Employee.Entity;
				if (((previousValue != value) 
							|| (this._Employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Employee.Entity = null;
						previousValue.Salaries.Remove(this);
					}
					this._Employee.Entity = value;
					if ((value != null))
					{
						value.Salaries.Add(this);
						this._EmployeeID = value.EmpID;
					}
					else
					{
						this._EmployeeID = default(int);
					}
					this.SendPropertyChanged("Employee");
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

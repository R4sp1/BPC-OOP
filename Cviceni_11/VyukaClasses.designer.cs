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

namespace Cv11
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="C:\\USERS\\STUDENT\\DESKTOP\\CVICENI_10\\VYUKA.MDF")]
	public partial class VyukaClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHodnoceni(Hodnoceni instance);
    partial void UpdateHodnoceni(Hodnoceni instance);
    partial void DeleteHodnoceni(Hodnoceni instance);
    partial void InsertPredmet(Predmet instance);
    partial void UpdatePredmet(Predmet instance);
    partial void DeletePredmet(Predmet instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    partial void InsertStudentPredmet(StudentPredmet instance);
    partial void UpdateStudentPredmet(StudentPredmet instance);
    partial void DeleteStudentPredmet(StudentPredmet instance);
    #endregion
		
		public VyukaClassesDataContext() : 
				base(global::Cv11.Properties.Settings.Default.C__USERS_STUDENT_DESKTOP_CVICENI_10_VYUKA_MDFConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public VyukaClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VyukaClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VyukaClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VyukaClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Hodnoceni> Hodnocenis
		{
			get
			{
				return this.GetTable<Hodnoceni>();
			}
		}
		
		public System.Data.Linq.Table<Predmet> Predmets
		{
			get
			{
				return this.GetTable<Predmet>();
			}
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
		
		public System.Data.Linq.Table<StudentPredmet> StudentPredmets
		{
			get
			{
				return this.GetTable<StudentPredmet>();
			}
		}
		
		public System.Data.Linq.Table<ConnectedView> ConnectedViews
		{
			get
			{
				return this.GetTable<ConnectedView>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Hodnoceni")]
	public partial class Hodnoceni : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StudentKey;
		
		private string _PredmetKey;
		
		private System.DateTime _Date;
		
		private System.Nullable<int> _Hodnoceni1;
		
		private EntityRef<Predmet> _Predmet;
		
		private EntityRef<Student> _Student;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStudentKeyChanging(int value);
    partial void OnStudentKeyChanged();
    partial void OnPredmetKeyChanging(string value);
    partial void OnPredmetKeyChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnHodnoceni1Changing(System.Nullable<int> value);
    partial void OnHodnoceni1Changed();
    #endregion
		
		public Hodnoceni()
		{
			this._Predmet = default(EntityRef<Predmet>);
			this._Student = default(EntityRef<Student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentKey", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int StudentKey
		{
			get
			{
				return this._StudentKey;
			}
			set
			{
				if ((this._StudentKey != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStudentKeyChanging(value);
					this.SendPropertyChanging();
					this._StudentKey = value;
					this.SendPropertyChanged("StudentKey");
					this.OnStudentKeyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PredmetKey", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string PredmetKey
		{
			get
			{
				return this._PredmetKey;
			}
			set
			{
				if ((this._PredmetKey != value))
				{
					if (this._Predmet.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPredmetKeyChanging(value);
					this.SendPropertyChanging();
					this._PredmetKey = value;
					this.SendPropertyChanged("PredmetKey");
					this.OnPredmetKeyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL", IsPrimaryKey=true)]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Hodnoceni", Storage="_Hodnoceni1", DbType="Int")]
		public System.Nullable<int> Hodnoceni1
		{
			get
			{
				return this._Hodnoceni1;
			}
			set
			{
				if ((this._Hodnoceni1 != value))
				{
					this.OnHodnoceni1Changing(value);
					this.SendPropertyChanging();
					this._Hodnoceni1 = value;
					this.SendPropertyChanged("Hodnoceni1");
					this.OnHodnoceni1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Predmet_Hodnoceni", Storage="_Predmet", ThisKey="PredmetKey", OtherKey="Zkratka", IsForeignKey=true)]
		public Predmet Predmet
		{
			get
			{
				return this._Predmet.Entity;
			}
			set
			{
				Predmet previousValue = this._Predmet.Entity;
				if (((previousValue != value) 
							|| (this._Predmet.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Predmet.Entity = null;
						previousValue.Hodnocenis.Remove(this);
					}
					this._Predmet.Entity = value;
					if ((value != null))
					{
						value.Hodnocenis.Add(this);
						this._PredmetKey = value.Zkratka;
					}
					else
					{
						this._PredmetKey = default(string);
					}
					this.SendPropertyChanged("Predmet");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Hodnoceni", Storage="_Student", ThisKey="StudentKey", OtherKey="Id", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.Hodnocenis.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.Hodnocenis.Add(this);
						this._StudentKey = value.Id;
					}
					else
					{
						this._StudentKey = default(int);
					}
					this.SendPropertyChanged("Student");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Predmet")]
	public partial class Predmet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Zkratka;
		
		private string _Nazev;
		
		private EntitySet<Hodnoceni> _Hodnocenis;
		
		private EntitySet<StudentPredmet> _StudentPredmets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnZkratkaChanging(string value);
    partial void OnZkratkaChanged();
    partial void OnNazevChanging(string value);
    partial void OnNazevChanged();
    #endregion
		
		public Predmet()
		{
			this._Hodnocenis = new EntitySet<Hodnoceni>(new Action<Hodnoceni>(this.attach_Hodnocenis), new Action<Hodnoceni>(this.detach_Hodnocenis));
			this._StudentPredmets = new EntitySet<StudentPredmet>(new Action<StudentPredmet>(this.attach_StudentPredmets), new Action<StudentPredmet>(this.detach_StudentPredmets));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zkratka", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Zkratka
		{
			get
			{
				return this._Zkratka;
			}
			set
			{
				if ((this._Zkratka != value))
				{
					this.OnZkratkaChanging(value);
					this.SendPropertyChanging();
					this._Zkratka = value;
					this.SendPropertyChanged("Zkratka");
					this.OnZkratkaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nazev", DbType="VarChar(50)")]
		public string Nazev
		{
			get
			{
				return this._Nazev;
			}
			set
			{
				if ((this._Nazev != value))
				{
					this.OnNazevChanging(value);
					this.SendPropertyChanging();
					this._Nazev = value;
					this.SendPropertyChanged("Nazev");
					this.OnNazevChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Predmet_Hodnoceni", Storage="_Hodnocenis", ThisKey="Zkratka", OtherKey="PredmetKey")]
		public EntitySet<Hodnoceni> Hodnocenis
		{
			get
			{
				return this._Hodnocenis;
			}
			set
			{
				this._Hodnocenis.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Predmet_StudentPredmet", Storage="_StudentPredmets", ThisKey="Zkratka", OtherKey="PredmetKey")]
		public EntitySet<StudentPredmet> StudentPredmets
		{
			get
			{
				return this._StudentPredmets;
			}
			set
			{
				this._StudentPredmets.Assign(value);
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
		
		private void attach_Hodnocenis(Hodnoceni entity)
		{
			this.SendPropertyChanging();
			entity.Predmet = this;
		}
		
		private void detach_Hodnocenis(Hodnoceni entity)
		{
			this.SendPropertyChanging();
			entity.Predmet = null;
		}
		
		private void attach_StudentPredmets(StudentPredmet entity)
		{
			this.SendPropertyChanging();
			entity.Predmet = this;
		}
		
		private void detach_StudentPredmets(StudentPredmet entity)
		{
			this.SendPropertyChanging();
			entity.Predmet = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Student")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Surname;
		
		private System.Nullable<System.DateTime> _DateOfBirth;
		
		private EntitySet<Hodnoceni> _Hodnocenis;
		
		private EntitySet<StudentPredmet> _StudentPredmets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnDateOfBirthChanging(System.Nullable<System.DateTime> value);
    partial void OnDateOfBirthChanged();
    #endregion
		
		public Student()
		{
			this._Hodnocenis = new EntitySet<Hodnoceni>(new Action<Hodnoceni>(this.attach_Hodnocenis), new Action<Hodnoceni>(this.detach_Hodnocenis));
			this._StudentPredmets = new EntitySet<StudentPredmet>(new Action<StudentPredmet>(this.attach_StudentPredmets), new Action<StudentPredmet>(this.detach_StudentPredmets));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(50)")]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfBirth", DbType="Date")]
		public System.Nullable<System.DateTime> DateOfBirth
		{
			get
			{
				return this._DateOfBirth;
			}
			set
			{
				if ((this._DateOfBirth != value))
				{
					this.OnDateOfBirthChanging(value);
					this.SendPropertyChanging();
					this._DateOfBirth = value;
					this.SendPropertyChanged("DateOfBirth");
					this.OnDateOfBirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Hodnoceni", Storage="_Hodnocenis", ThisKey="Id", OtherKey="StudentKey")]
		public EntitySet<Hodnoceni> Hodnocenis
		{
			get
			{
				return this._Hodnocenis;
			}
			set
			{
				this._Hodnocenis.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_StudentPredmet", Storage="_StudentPredmets", ThisKey="Id", OtherKey="StudentKey")]
		public EntitySet<StudentPredmet> StudentPredmets
		{
			get
			{
				return this._StudentPredmets;
			}
			set
			{
				this._StudentPredmets.Assign(value);
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
		
		private void attach_Hodnocenis(Hodnoceni entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_Hodnocenis(Hodnoceni entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
		
		private void attach_StudentPredmets(StudentPredmet entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_StudentPredmets(StudentPredmet entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StudentPredmet")]
	public partial class StudentPredmet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StudentKey;
		
		private string _PredmetKey;
		
		private EntityRef<Predmet> _Predmet;
		
		private EntityRef<Student> _Student;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStudentKeyChanging(int value);
    partial void OnStudentKeyChanged();
    partial void OnPredmetKeyChanging(string value);
    partial void OnPredmetKeyChanged();
    #endregion
		
		public StudentPredmet()
		{
			this._Predmet = default(EntityRef<Predmet>);
			this._Student = default(EntityRef<Student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentKey", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int StudentKey
		{
			get
			{
				return this._StudentKey;
			}
			set
			{
				if ((this._StudentKey != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStudentKeyChanging(value);
					this.SendPropertyChanging();
					this._StudentKey = value;
					this.SendPropertyChanged("StudentKey");
					this.OnStudentKeyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PredmetKey", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string PredmetKey
		{
			get
			{
				return this._PredmetKey;
			}
			set
			{
				if ((this._PredmetKey != value))
				{
					if (this._Predmet.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPredmetKeyChanging(value);
					this.SendPropertyChanging();
					this._PredmetKey = value;
					this.SendPropertyChanged("PredmetKey");
					this.OnPredmetKeyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Predmet_StudentPredmet", Storage="_Predmet", ThisKey="PredmetKey", OtherKey="Zkratka", IsForeignKey=true)]
		public Predmet Predmet
		{
			get
			{
				return this._Predmet.Entity;
			}
			set
			{
				Predmet previousValue = this._Predmet.Entity;
				if (((previousValue != value) 
							|| (this._Predmet.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Predmet.Entity = null;
						previousValue.StudentPredmets.Remove(this);
					}
					this._Predmet.Entity = value;
					if ((value != null))
					{
						value.StudentPredmets.Add(this);
						this._PredmetKey = value.Zkratka;
					}
					else
					{
						this._PredmetKey = default(string);
					}
					this.SendPropertyChanged("Predmet");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_StudentPredmet", Storage="_Student", ThisKey="StudentKey", OtherKey="Id", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.StudentPredmets.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.StudentPredmets.Add(this);
						this._StudentKey = value.Id;
					}
					else
					{
						this._StudentKey = default(int);
					}
					this.SendPropertyChanged("Student");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ConnectedView")]
	public partial class ConnectedView
	{
		
		private int _Id;
		
		private string _Name;
		
		private string _Surname;
		
		private System.Nullable<System.DateTime> _DateOfBirth;
		
		private System.Nullable<int> _StudentKey;
		
		private string _PredmetKey;
		
		private string _Zkratka;
		
		private string _Nazev;
		
		public ConnectedView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
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
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(50)")]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this._Surname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfBirth", DbType="Date")]
		public System.Nullable<System.DateTime> DateOfBirth
		{
			get
			{
				return this._DateOfBirth;
			}
			set
			{
				if ((this._DateOfBirth != value))
				{
					this._DateOfBirth = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentKey", DbType="Int")]
		public System.Nullable<int> StudentKey
		{
			get
			{
				return this._StudentKey;
			}
			set
			{
				if ((this._StudentKey != value))
				{
					this._StudentKey = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PredmetKey", DbType="VarChar(50)")]
		public string PredmetKey
		{
			get
			{
				return this._PredmetKey;
			}
			set
			{
				if ((this._PredmetKey != value))
				{
					this._PredmetKey = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zkratka", DbType="VarChar(50)")]
		public string Zkratka
		{
			get
			{
				return this._Zkratka;
			}
			set
			{
				if ((this._Zkratka != value))
				{
					this._Zkratka = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nazev", DbType="VarChar(50)")]
		public string Nazev
		{
			get
			{
				return this._Nazev;
			}
			set
			{
				if ((this._Nazev != value))
				{
					this._Nazev = value;
				}
			}
		}
	}
}
#pragma warning restore 1591

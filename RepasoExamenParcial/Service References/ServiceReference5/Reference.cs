﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practica2.ServiceReference5 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Profesor", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class Profesor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AnosExpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference5.Especialidad EspecialidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaFinCategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaIngresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaRevalidacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GradoAcademicoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdiomaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegimenDedicacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TelefonoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AnosExp {
            get {
                return this.AnosExpField;
            }
            set {
                if ((this.AnosExpField.Equals(value) != true)) {
                    this.AnosExpField = value;
                    this.RaisePropertyChanged("AnosExp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Categoria {
            get {
                return this.CategoriaField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoriaField, value) != true)) {
                    this.CategoriaField = value;
                    this.RaisePropertyChanged("Categoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Correo {
            get {
                return this.CorreoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoField, value) != true)) {
                    this.CorreoField = value;
                    this.RaisePropertyChanged("Correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Dni {
            get {
                return this.DniField;
            }
            set {
                if ((this.DniField.Equals(value) != true)) {
                    this.DniField = value;
                    this.RaisePropertyChanged("Dni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference5.Especialidad Especialidad {
            get {
                return this.EspecialidadField;
            }
            set {
                if ((object.ReferenceEquals(this.EspecialidadField, value) != true)) {
                    this.EspecialidadField = value;
                    this.RaisePropertyChanged("Especialidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FechaFinCategoria {
            get {
                return this.FechaFinCategoriaField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaFinCategoriaField, value) != true)) {
                    this.FechaFinCategoriaField = value;
                    this.RaisePropertyChanged("FechaFinCategoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FechaIngreso {
            get {
                return this.FechaIngresoField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaIngresoField, value) != true)) {
                    this.FechaIngresoField = value;
                    this.RaisePropertyChanged("FechaIngreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FechaRevalidacion {
            get {
                return this.FechaRevalidacionField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaRevalidacionField, value) != true)) {
                    this.FechaRevalidacionField = value;
                    this.RaisePropertyChanged("FechaRevalidacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GradoAcademico {
            get {
                return this.GradoAcademicoField;
            }
            set {
                if ((object.ReferenceEquals(this.GradoAcademicoField, value) != true)) {
                    this.GradoAcademicoField = value;
                    this.RaisePropertyChanged("GradoAcademico");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Idioma {
            get {
                return this.IdiomaField;
            }
            set {
                if ((this.IdiomaField.Equals(value) != true)) {
                    this.IdiomaField = value;
                    this.RaisePropertyChanged("Idioma");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RegimenDedicacion {
            get {
                return this.RegimenDedicacionField;
            }
            set {
                if ((object.ReferenceEquals(this.RegimenDedicacionField, value) != true)) {
                    this.RegimenDedicacionField = value;
                    this.RaisePropertyChanged("RegimenDedicacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((this.TelefonoField.Equals(value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Especialidad", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class Especialidad : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Alumno", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class Alumno : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CicloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CreditosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference5.Especialidad EspecialidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference5.Especialidad EspecialidadActualField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference5.Especialidad EspecialidadAnteriorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference5.Reunion[] ListaReunionesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResumenReunionesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TelefonoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference5.Profesor TutorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UnidadField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Ciclo {
            get {
                return this.CicloField;
            }
            set {
                if ((this.CicloField.Equals(value) != true)) {
                    this.CicloField = value;
                    this.RaisePropertyChanged("Ciclo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Correo {
            get {
                return this.CorreoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoField, value) != true)) {
                    this.CorreoField = value;
                    this.RaisePropertyChanged("Correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Creditos {
            get {
                return this.CreditosField;
            }
            set {
                if ((this.CreditosField.Equals(value) != true)) {
                    this.CreditosField = value;
                    this.RaisePropertyChanged("Creditos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Dni {
            get {
                return this.DniField;
            }
            set {
                if ((this.DniField.Equals(value) != true)) {
                    this.DniField = value;
                    this.RaisePropertyChanged("Dni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference5.Especialidad Especialidad {
            get {
                return this.EspecialidadField;
            }
            set {
                if ((object.ReferenceEquals(this.EspecialidadField, value) != true)) {
                    this.EspecialidadField = value;
                    this.RaisePropertyChanged("Especialidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference5.Especialidad EspecialidadActual {
            get {
                return this.EspecialidadActualField;
            }
            set {
                if ((object.ReferenceEquals(this.EspecialidadActualField, value) != true)) {
                    this.EspecialidadActualField = value;
                    this.RaisePropertyChanged("EspecialidadActual");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference5.Especialidad EspecialidadAnterior {
            get {
                return this.EspecialidadAnteriorField;
            }
            set {
                if ((object.ReferenceEquals(this.EspecialidadAnteriorField, value) != true)) {
                    this.EspecialidadAnteriorField = value;
                    this.RaisePropertyChanged("EspecialidadAnterior");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference5.Reunion[] ListaReuniones {
            get {
                return this.ListaReunionesField;
            }
            set {
                if ((object.ReferenceEquals(this.ListaReunionesField, value) != true)) {
                    this.ListaReunionesField = value;
                    this.RaisePropertyChanged("ListaReuniones");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ResumenReuniones {
            get {
                return this.ResumenReunionesField;
            }
            set {
                if ((object.ReferenceEquals(this.ResumenReunionesField, value) != true)) {
                    this.ResumenReunionesField = value;
                    this.RaisePropertyChanged("ResumenReuniones");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((this.TelefonoField.Equals(value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference5.Profesor Tutor {
            get {
                return this.TutorField;
            }
            set {
                if ((object.ReferenceEquals(this.TutorField, value) != true)) {
                    this.TutorField = value;
                    this.RaisePropertyChanged("Tutor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Unidad {
            get {
                return this.UnidadField;
            }
            set {
                if ((object.ReferenceEquals(this.UnidadField, value) != true)) {
                    this.UnidadField = value;
                    this.RaisePropertyChanged("Unidad");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Reunion", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class Reunion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference5.Alumno AlumnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference5.Profesor ProfesorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SugerenciasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TemaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference5.Alumno Alumno {
            get {
                return this.AlumnoField;
            }
            set {
                if ((object.ReferenceEquals(this.AlumnoField, value) != true)) {
                    this.AlumnoField = value;
                    this.RaisePropertyChanged("Alumno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fecha {
            get {
                return this.FechaField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaField, value) != true)) {
                    this.FechaField = value;
                    this.RaisePropertyChanged("Fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference5.Profesor Profesor {
            get {
                return this.ProfesorField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfesorField, value) != true)) {
                    this.ProfesorField = value;
                    this.RaisePropertyChanged("Profesor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sugerencias {
            get {
                return this.SugerenciasField;
            }
            set {
                if ((object.ReferenceEquals(this.SugerenciasField, value) != true)) {
                    this.SugerenciasField = value;
                    this.RaisePropertyChanged("Sugerencias");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tema {
            get {
                return this.TemaField;
            }
            set {
                if ((object.ReferenceEquals(this.TemaField, value) != true)) {
                    this.TemaField = value;
                    this.RaisePropertyChanged("Tema");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProfesorTutor", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class ProfesorTutor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference5.Alumno[] ListaAlumnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference5.Reunion[] ListaReunionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NodoProfesorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference5.Profesor ProfesorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference5.Alumno[] ListaAlumno {
            get {
                return this.ListaAlumnoField;
            }
            set {
                if ((object.ReferenceEquals(this.ListaAlumnoField, value) != true)) {
                    this.ListaAlumnoField = value;
                    this.RaisePropertyChanged("ListaAlumno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference5.Reunion[] ListaReunion {
            get {
                return this.ListaReunionField;
            }
            set {
                if ((object.ReferenceEquals(this.ListaReunionField, value) != true)) {
                    this.ListaReunionField = value;
                    this.RaisePropertyChanged("ListaReunion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NodoProfesor {
            get {
                return this.NodoProfesorField;
            }
            set {
                if ((object.ReferenceEquals(this.NodoProfesorField, value) != true)) {
                    this.NodoProfesorField = value;
                    this.RaisePropertyChanged("NodoProfesor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference5.Profesor Profesor {
            get {
                return this.ProfesorField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfesorField, value) != true)) {
                    this.ProfesorField = value;
                    this.RaisePropertyChanged("Profesor");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference5.IService2")]
    public interface IService2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/agregarProfesorTutor", ReplyAction="http://tempuri.org/IService2/agregarProfesorTutorResponse")]
        string agregarProfesorTutor(Practica2.ServiceReference5.Profesor profesor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/buscarProfesor", ReplyAction="http://tempuri.org/IService2/buscarProfesorResponse")]
        Practica2.ServiceReference5.Profesor buscarProfesor(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/agregarAlumno", ReplyAction="http://tempuri.org/IService2/agregarAlumnoResponse")]
        string agregarAlumno(Practica2.ServiceReference5.Alumno alumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/crearProfesor", ReplyAction="http://tempuri.org/IService2/crearProfesorResponse")]
        Practica2.ServiceReference5.Profesor crearProfesor(int cod, string nom, int dn, string corr, int telf, string reg, int idio, int anho, string grad, Practica2.ServiceReference5.Especialidad esp, string fIn, string fRe, string fFin, string categ);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/crearAlumno", ReplyAction="http://tempuri.org/IService2/crearAlumnoResponse")]
        Practica2.ServiceReference5.Alumno crearAlumno(int cod, string nom, int dn, string corr, int telf, int cic, int cred, Practica2.ServiceReference5.Especialidad especialidadActual, Practica2.ServiceReference5.Especialidad especialidadAnterior, string resumenReuniones, string unidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/buscarAlumno", ReplyAction="http://tempuri.org/IService2/buscarAlumnoResponse")]
        Practica2.ServiceReference5.Alumno buscarAlumno(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/getTutoresCount", ReplyAction="http://tempuri.org/IService2/getTutoresCountResponse")]
        int getTutoresCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/getTutor", ReplyAction="http://tempuri.org/IService2/getTutorResponse")]
        Practica2.ServiceReference5.Profesor getTutor(int i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/getAlumnos", ReplyAction="http://tempuri.org/IService2/getAlumnosResponse")]
        Practica2.ServiceReference5.Alumno[] getAlumnos(Practica2.ServiceReference5.Profesor profesor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/agregarReunion", ReplyAction="http://tempuri.org/IService2/agregarReunionResponse")]
        string agregarReunion(Practica2.ServiceReference5.Alumno alumno, Practica2.ServiceReference5.Profesor tutor, string fecha, string tema, string sugerencia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/getProfesorTutor", ReplyAction="http://tempuri.org/IService2/getProfesorTutorResponse")]
        int getProfesorTutor(int i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/buscarTutor", ReplyAction="http://tempuri.org/IService2/buscarTutorResponse")]
        Practica2.ServiceReference5.ProfesorTutor buscarTutor(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/refresh", ReplyAction="http://tempuri.org/IService2/refreshResponse")]
        int refresh();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService2Channel : Practica2.ServiceReference5.IService2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service2Client : System.ServiceModel.ClientBase<Practica2.ServiceReference5.IService2>, Practica2.ServiceReference5.IService2 {
        
        public Service2Client() {
        }
        
        public Service2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string agregarProfesorTutor(Practica2.ServiceReference5.Profesor profesor) {
            return base.Channel.agregarProfesorTutor(profesor);
        }
        
        public Practica2.ServiceReference5.Profesor buscarProfesor(int codigo) {
            return base.Channel.buscarProfesor(codigo);
        }
        
        public string agregarAlumno(Practica2.ServiceReference5.Alumno alumno) {
            return base.Channel.agregarAlumno(alumno);
        }
        
        public Practica2.ServiceReference5.Profesor crearProfesor(int cod, string nom, int dn, string corr, int telf, string reg, int idio, int anho, string grad, Practica2.ServiceReference5.Especialidad esp, string fIn, string fRe, string fFin, string categ) {
            return base.Channel.crearProfesor(cod, nom, dn, corr, telf, reg, idio, anho, grad, esp, fIn, fRe, fFin, categ);
        }
        
        public Practica2.ServiceReference5.Alumno crearAlumno(int cod, string nom, int dn, string corr, int telf, int cic, int cred, Practica2.ServiceReference5.Especialidad especialidadActual, Practica2.ServiceReference5.Especialidad especialidadAnterior, string resumenReuniones, string unidad) {
            return base.Channel.crearAlumno(cod, nom, dn, corr, telf, cic, cred, especialidadActual, especialidadAnterior, resumenReuniones, unidad);
        }
        
        public Practica2.ServiceReference5.Alumno buscarAlumno(int codigo) {
            return base.Channel.buscarAlumno(codigo);
        }
        
        public int getTutoresCount() {
            return base.Channel.getTutoresCount();
        }
        
        public Practica2.ServiceReference5.Profesor getTutor(int i) {
            return base.Channel.getTutor(i);
        }
        
        public Practica2.ServiceReference5.Alumno[] getAlumnos(Practica2.ServiceReference5.Profesor profesor) {
            return base.Channel.getAlumnos(profesor);
        }
        
        public string agregarReunion(Practica2.ServiceReference5.Alumno alumno, Practica2.ServiceReference5.Profesor tutor, string fecha, string tema, string sugerencia) {
            return base.Channel.agregarReunion(alumno, tutor, fecha, tema, sugerencia);
        }
        
        public int getProfesorTutor(int i) {
            return base.Channel.getProfesorTutor(i);
        }
        
        public Practica2.ServiceReference5.ProfesorTutor buscarTutor(int codigo) {
            return base.Channel.buscarTutor(codigo);
        }
        
        public int refresh() {
            return base.Channel.refresh();
        }
    }
}

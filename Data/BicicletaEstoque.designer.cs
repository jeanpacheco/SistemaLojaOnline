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

namespace Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Estoque")]
	public partial class BicicletaEstoqueDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public BicicletaEstoqueDataContext() : 
				base(global::Data.Properties.Settings.Default.EstoqueConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BicicletaEstoqueDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BicicletaEstoqueDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BicicletaEstoqueDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BicicletaEstoqueDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SearchBicicletas")]
		public ISingleResult<SearchBicicletasResult> SearchBicicletas([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Modelo", DbType="VarChar(50)")] string modelo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), modelo);
			return ((ISingleResult<SearchBicicletasResult>)(result.ReturnValue));
		}
	}
	
	public partial class SearchBicicletasResult
	{
		
		private int _Id;
		
		private string _Modelo;
		
		private int _Quantidade;
		
		private decimal _PrecoProposto;
		
		public SearchBicicletasResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modelo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Modelo
		{
			get
			{
				return this._Modelo;
			}
			set
			{
				if ((this._Modelo != value))
				{
					this._Modelo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantidade", DbType="Int NOT NULL")]
		public int Quantidade
		{
			get
			{
				return this._Quantidade;
			}
			set
			{
				if ((this._Quantidade != value))
				{
					this._Quantidade = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrecoProposto", DbType="Decimal(18,0) NOT NULL")]
		public decimal PrecoProposto
		{
			get
			{
				return this._PrecoProposto;
			}
			set
			{
				if ((this._PrecoProposto != value))
				{
					this._PrecoProposto = value;
				}
			}
		}
	}
}
#pragma warning restore 1591

﻿/*********************************************        
作者：曹旭升              
QQ：279060597
访问博客了解详细介绍及更多内容：   
http://blog.shengxunwei.com
**********************************************/
using System;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
namespace Microsoft.Practices.EnterpriseLibrary.Data.Configuration
{
	public interface IDatabaseAssembler
	{
		Database Assemble(string name, ConnectionStringSettings connectionStringSettings, IConfigurationSource configurationSource);
	}
}

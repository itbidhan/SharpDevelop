﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using ICSharpCode.PackageManagement;
using ICSharpCode.SharpDevelop.Project;

namespace PackageManagement.Tests.Helpers
{
	public class FakeSolutionPackageRepositoryFactory : ISolutionPackageRepositoryFactory
	{
		public FakeSolutionPackageRepository FakeSolutionPackageRepository = new FakeSolutionPackageRepository();
		public Solution SolutionPassedToCreateSolutionPackageRepository;
		
		public ISolutionPackageRepository CreateSolutionPackageRepository(Solution solution)
		{
			SolutionPassedToCreateSolutionPackageRepository = solution;
			return FakeSolutionPackageRepository;
		}
	}
}

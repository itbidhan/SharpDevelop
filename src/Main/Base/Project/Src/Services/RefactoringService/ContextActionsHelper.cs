﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Martin Konicek" email="martin.konicek@gmail.com"/>
//     <version>$Revision: $</version>
// </file>
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using ICSharpCode.Core;
using ICSharpCode.Core.Presentation;
using ICSharpCode.SharpDevelop.Dom;
using ICSharpCode.SharpDevelop.Refactoring;

namespace ICSharpCode.SharpDevelop.Refactoring
{
	/// <summary>
	/// Description of ContextCommandsHelper.
	/// </summary>
	public class ContextActionsHelper
	{
		public static ContextActionsPopup MakePopupWithDerivedClasses(IClass baseClass)
		{
			var derivedClassesTree = RefactoringService.FindDerivedClassesTree(baseClass);
			var popupViewModel = new ContextActionsViewModel { Title = MenuService.ConvertLabel(StringParser.Parse(
				"${res:SharpDevelop.Refactoring.ClassesDerivingFrom}", new StringTagPair("Name", baseClass.Name)))};
			popupViewModel.Actions = new PopupTreeViewModelBuilder().BuildTreeViewModel(derivedClassesTree);
			return new ContextActionsPopup { Actions = popupViewModel };
		}
		
		public static ContextActionsPopup MakePopupWithBaseClasses(IClass @class)
		{
			var baseClassList = @class.ClassInheritanceTree.Where(
				baseClass => (baseClass != @class) && (baseClass.CompilationUnit != null) && (baseClass.CompilationUnit.FileName != null));
			// Reverse to show the base classes from the most general to the most derived one
			//.Reverse();
			//baseClassList.Sort(new BaseClassComparer());
			var popupViewModel = new ContextActionsViewModel { Title = MenuService.ConvertLabel(StringParser.Parse(
				"${res:SharpDevelop.Refactoring.BaseClassesOf}", new StringTagPair("Name", @class.Name)))};
			popupViewModel.Actions = new PopupListViewModelBuilder().BuildListViewModel(baseClassList);
			return new ContextActionsPopup { Actions = popupViewModel };
		}
		
		class PopupViewModelBuilder
		{
			protected IAmbience LabelAmbience { get; set; }
			
			protected PopupViewModelBuilder()
			{
				this.LabelAmbience = AmbienceService.GetCurrentAmbience();
				this.LabelAmbience.ConversionFlags = ConversionFlags.ShowTypeParameterList;
			}
			
			protected ContextActionViewModel MakeGoToClassAction(IClass @class, ObservableCollection<ContextActionViewModel> childActions)
			{
				return new ContextActionViewModel {
					Name = this.LabelAmbience.Convert(@class),
					Comment = string.Format("(in {0})", @class.Namespace),
					Action = new GoToClassAction(@class),
					ChildActions = childActions
				};
			}
		}
		
		class PopupListViewModelBuilder : PopupViewModelBuilder
		{
			public ObservableCollection<ContextActionViewModel> BuildListViewModel(IEnumerable<IClass> classList)
			{
				return new ObservableCollection<ContextActionViewModel>(
					classList.Select(@class => MakeGoToClassAction(@class, null)));
			}
		}
		
		class PopupTreeViewModelBuilder : PopupViewModelBuilder
		{
			public ObservableCollection<ContextActionViewModel> BuildTreeViewModel(IEnumerable<ITreeNode<IClass>> classTree)
			{
				return new ObservableCollection<ContextActionViewModel>(
					classTree.Select(
						node => MakeGoToClassAction (node.Content, BuildTreeViewModel(node.Children))));
			}
		}
	}
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ICSharpCode.NRefactory {
	using System;
	using ICSharpCode.NRefactory.Ast;
	
	
	public interface IAstVisitor {
		
		object VisitAddHandlerStatement(AddHandlerStatement addHandlerStatement, object data);
		
		object VisitAddressOfExpression(AddressOfExpression addressOfExpression, object data);
		
		object VisitAnonymousMethodExpression(AnonymousMethodExpression anonymousMethodExpression, object data);
		
		object VisitArrayCreateExpression(ArrayCreateExpression arrayCreateExpression, object data);
		
		object VisitAssignmentExpression(AssignmentExpression assignmentExpression, object data);
		
		object VisitAttribute(ICSharpCode.NRefactory.Ast.Attribute attribute, object data);
		
		object VisitAttributeSection(AttributeSection attributeSection, object data);
		
		object VisitBaseReferenceExpression(BaseReferenceExpression baseReferenceExpression, object data);
		
		object VisitBinaryOperatorExpression(BinaryOperatorExpression binaryOperatorExpression, object data);
		
		object VisitBlockStatement(BlockStatement blockStatement, object data);
		
		object VisitBreakStatement(BreakStatement breakStatement, object data);
		
		object VisitCaseLabel(CaseLabel caseLabel, object data);
		
		object VisitCastExpression(CastExpression castExpression, object data);
		
		object VisitCatchClause(CatchClause catchClause, object data);
		
		object VisitCheckedExpression(CheckedExpression checkedExpression, object data);
		
		object VisitCheckedStatement(CheckedStatement checkedStatement, object data);
		
		object VisitClassReferenceExpression(ClassReferenceExpression classReferenceExpression, object data);
		
		object VisitCollectionInitializerExpression(CollectionInitializerExpression collectionInitializerExpression, object data);
		
		object VisitCompilationUnit(CompilationUnit compilationUnit, object data);
		
		object VisitConditionalExpression(ConditionalExpression conditionalExpression, object data);
		
		object VisitConstructorDeclaration(ConstructorDeclaration constructorDeclaration, object data);
		
		object VisitConstructorInitializer(ConstructorInitializer constructorInitializer, object data);
		
		object VisitContinueStatement(ContinueStatement continueStatement, object data);
		
		object VisitDeclareDeclaration(DeclareDeclaration declareDeclaration, object data);
		
		object VisitDefaultValueExpression(DefaultValueExpression defaultValueExpression, object data);
		
		object VisitDelegateDeclaration(DelegateDeclaration delegateDeclaration, object data);
		
		object VisitDestructorDeclaration(DestructorDeclaration destructorDeclaration, object data);
		
		object VisitDirectionExpression(DirectionExpression directionExpression, object data);
		
		object VisitDoLoopStatement(DoLoopStatement doLoopStatement, object data);
		
		object VisitElseIfSection(ElseIfSection elseIfSection, object data);
		
		object VisitEmptyStatement(EmptyStatement emptyStatement, object data);
		
		object VisitEndStatement(EndStatement endStatement, object data);
		
		object VisitEraseStatement(EraseStatement eraseStatement, object data);
		
		object VisitErrorStatement(ErrorStatement errorStatement, object data);
		
		object VisitEventAddRegion(EventAddRegion eventAddRegion, object data);
		
		object VisitEventDeclaration(EventDeclaration eventDeclaration, object data);
		
		object VisitEventRaiseRegion(EventRaiseRegion eventRaiseRegion, object data);
		
		object VisitEventRemoveRegion(EventRemoveRegion eventRemoveRegion, object data);
		
		object VisitExitStatement(ExitStatement exitStatement, object data);
		
		object VisitExpressionStatement(ExpressionStatement expressionStatement, object data);
		
		object VisitFieldDeclaration(FieldDeclaration fieldDeclaration, object data);
		
		object VisitFieldReferenceExpression(FieldReferenceExpression fieldReferenceExpression, object data);
		
		object VisitFixedStatement(FixedStatement fixedStatement, object data);
		
		object VisitForeachStatement(ForeachStatement foreachStatement, object data);
		
		object VisitForNextStatement(ForNextStatement forNextStatement, object data);
		
		object VisitForStatement(ForStatement forStatement, object data);
		
		object VisitGotoCaseStatement(GotoCaseStatement gotoCaseStatement, object data);
		
		object VisitGotoStatement(GotoStatement gotoStatement, object data);
		
		object VisitIdentifierExpression(IdentifierExpression identifierExpression, object data);
		
		object VisitIfElseStatement(IfElseStatement ifElseStatement, object data);
		
		object VisitIndexerDeclaration(IndexerDeclaration indexerDeclaration, object data);
		
		object VisitIndexerExpression(IndexerExpression indexerExpression, object data);
		
		object VisitInnerClassTypeReference(InnerClassTypeReference innerClassTypeReference, object data);
		
		object VisitInterfaceImplementation(InterfaceImplementation interfaceImplementation, object data);
		
		object VisitInvocationExpression(InvocationExpression invocationExpression, object data);
		
		object VisitLabelStatement(LabelStatement labelStatement, object data);
		
		object VisitLambdaExpression(LambdaExpression lambdaExpression, object data);
		
		object VisitLocalVariableDeclaration(LocalVariableDeclaration localVariableDeclaration, object data);
		
		object VisitLockStatement(LockStatement lockStatement, object data);
		
		object VisitMethodDeclaration(MethodDeclaration methodDeclaration, object data);
		
		object VisitNamedArgumentExpression(NamedArgumentExpression namedArgumentExpression, object data);
		
		object VisitNamespaceDeclaration(NamespaceDeclaration namespaceDeclaration, object data);
		
		object VisitObjectCreateExpression(ObjectCreateExpression objectCreateExpression, object data);
		
		object VisitOnErrorStatement(OnErrorStatement onErrorStatement, object data);
		
		object VisitOperatorDeclaration(OperatorDeclaration operatorDeclaration, object data);
		
		object VisitOptionDeclaration(OptionDeclaration optionDeclaration, object data);
		
		object VisitParameterDeclarationExpression(ParameterDeclarationExpression parameterDeclarationExpression, object data);
		
		object VisitParenthesizedExpression(ParenthesizedExpression parenthesizedExpression, object data);
		
		object VisitPointerReferenceExpression(PointerReferenceExpression pointerReferenceExpression, object data);
		
		object VisitPrimitiveExpression(PrimitiveExpression primitiveExpression, object data);
		
		object VisitPropertyDeclaration(PropertyDeclaration propertyDeclaration, object data);
		
		object VisitPropertyGetRegion(PropertyGetRegion propertyGetRegion, object data);
		
		object VisitPropertySetRegion(PropertySetRegion propertySetRegion, object data);
		
		object VisitQueryExpression(QueryExpression queryExpression, object data);
		
		object VisitQueryExpressionFromClause(QueryExpressionFromClause queryExpressionFromClause, object data);
		
		object VisitQueryExpressionGroupClause(QueryExpressionGroupClause queryExpressionGroupClause, object data);
		
		object VisitQueryExpressionIntoClause(QueryExpressionIntoClause queryExpressionIntoClause, object data);
		
		object VisitQueryExpressionJoinClause(QueryExpressionJoinClause queryExpressionJoinClause, object data);
		
		object VisitQueryExpressionLetClause(QueryExpressionLetClause queryExpressionLetClause, object data);
		
		object VisitQueryExpressionOrdering(QueryExpressionOrdering queryExpressionOrdering, object data);
		
		object VisitQueryExpressionSelectClause(QueryExpressionSelectClause queryExpressionSelectClause, object data);
		
		object VisitQueryExpressionWhereClause(QueryExpressionWhereClause queryExpressionWhereClause, object data);
		
		object VisitRaiseEventStatement(RaiseEventStatement raiseEventStatement, object data);
		
		object VisitReDimStatement(ReDimStatement reDimStatement, object data);
		
		object VisitRemoveHandlerStatement(RemoveHandlerStatement removeHandlerStatement, object data);
		
		object VisitResumeStatement(ResumeStatement resumeStatement, object data);
		
		object VisitReturnStatement(ReturnStatement returnStatement, object data);
		
		object VisitSizeOfExpression(SizeOfExpression sizeOfExpression, object data);
		
		object VisitStackAllocExpression(StackAllocExpression stackAllocExpression, object data);
		
		object VisitStopStatement(StopStatement stopStatement, object data);
		
		object VisitSwitchSection(SwitchSection switchSection, object data);
		
		object VisitSwitchStatement(SwitchStatement switchStatement, object data);
		
		object VisitTemplateDefinition(TemplateDefinition templateDefinition, object data);
		
		object VisitThisReferenceExpression(ThisReferenceExpression thisReferenceExpression, object data);
		
		object VisitThrowStatement(ThrowStatement throwStatement, object data);
		
		object VisitTryCatchStatement(TryCatchStatement tryCatchStatement, object data);
		
		object VisitTypeDeclaration(TypeDeclaration typeDeclaration, object data);
		
		object VisitTypeOfExpression(TypeOfExpression typeOfExpression, object data);
		
		object VisitTypeOfIsExpression(TypeOfIsExpression typeOfIsExpression, object data);
		
		object VisitTypeReference(TypeReference typeReference, object data);
		
		object VisitTypeReferenceExpression(TypeReferenceExpression typeReferenceExpression, object data);
		
		object VisitUnaryOperatorExpression(UnaryOperatorExpression unaryOperatorExpression, object data);
		
		object VisitUncheckedExpression(UncheckedExpression uncheckedExpression, object data);
		
		object VisitUncheckedStatement(UncheckedStatement uncheckedStatement, object data);
		
		object VisitUnsafeStatement(UnsafeStatement unsafeStatement, object data);
		
		object VisitUsing(Using @using, object data);
		
		object VisitUsingDeclaration(UsingDeclaration usingDeclaration, object data);
		
		object VisitUsingStatement(UsingStatement usingStatement, object data);
		
		object VisitVariableDeclaration(VariableDeclaration variableDeclaration, object data);
		
		object VisitWithStatement(WithStatement withStatement, object data);
		
		object VisitYieldStatement(YieldStatement yieldStatement, object data);
	}
}

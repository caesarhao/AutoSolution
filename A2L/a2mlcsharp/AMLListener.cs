//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from AML.g4 by ANTLR 4.9.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace a2mlcsharp {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="AMLParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.CLSCompliant(false)]
public interface IAMLListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.a2ml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA2ml([NotNull] AMLParser.A2mlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.a2ml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA2ml([NotNull] AMLParser.A2mlContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] AMLParser.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] AMLParser.DeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.type_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_definition([NotNull] AMLParser.Type_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.type_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_definition([NotNull] AMLParser.Type_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_name([NotNull] AMLParser.Type_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_name([NotNull] AMLParser.Type_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.predefined_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPredefined_type_name([NotNull] AMLParser.Predefined_type_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.predefined_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPredefined_type_name([NotNull] AMLParser.Predefined_type_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.block_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock_definition([NotNull] AMLParser.Block_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.block_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock_definition([NotNull] AMLParser.Block_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.enum_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnum_type_name([NotNull] AMLParser.Enum_type_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.enum_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnum_type_name([NotNull] AMLParser.Enum_type_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.enumerator_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumerator_list([NotNull] AMLParser.Enumerator_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.enumerator_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumerator_list([NotNull] AMLParser.Enumerator_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.enumerator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumerator([NotNull] AMLParser.EnumeratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.enumerator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumerator([NotNull] AMLParser.EnumeratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.struct_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStruct_type_name([NotNull] AMLParser.Struct_type_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.struct_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStruct_type_name([NotNull] AMLParser.Struct_type_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.struct_member_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStruct_member_list([NotNull] AMLParser.Struct_member_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.struct_member_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStruct_member_list([NotNull] AMLParser.Struct_member_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.struct_member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStruct_member([NotNull] AMLParser.Struct_memberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.struct_member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStruct_member([NotNull] AMLParser.Struct_memberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMember([NotNull] AMLParser.MemberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMember([NotNull] AMLParser.MemberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.array_specifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArray_specifier([NotNull] AMLParser.Array_specifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.array_specifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArray_specifier([NotNull] AMLParser.Array_specifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.taggedstruct_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTaggedstruct_type_name([NotNull] AMLParser.Taggedstruct_type_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.taggedstruct_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTaggedstruct_type_name([NotNull] AMLParser.Taggedstruct_type_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.taggedstruct_member_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTaggedstruct_member_list([NotNull] AMLParser.Taggedstruct_member_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.taggedstruct_member_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTaggedstruct_member_list([NotNull] AMLParser.Taggedstruct_member_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.taggedstruct_member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTaggedstruct_member([NotNull] AMLParser.Taggedstruct_memberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.taggedstruct_member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTaggedstruct_member([NotNull] AMLParser.Taggedstruct_memberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.taggedstruct_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTaggedstruct_definition([NotNull] AMLParser.Taggedstruct_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.taggedstruct_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTaggedstruct_definition([NotNull] AMLParser.Taggedstruct_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.taggedunion_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTaggedunion_type_name([NotNull] AMLParser.Taggedunion_type_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.taggedunion_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTaggedunion_type_name([NotNull] AMLParser.Taggedunion_type_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.taggedunion_member_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTaggedunion_member_list([NotNull] AMLParser.Taggedunion_member_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.taggedunion_member_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTaggedunion_member_list([NotNull] AMLParser.Taggedunion_member_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.tagged_union_member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTagged_union_member([NotNull] AMLParser.Tagged_union_memberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.tagged_union_member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTagged_union_member([NotNull] AMLParser.Tagged_union_memberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] AMLParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] AMLParser.IdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.tag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTag([NotNull] AMLParser.TagContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.tag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTag([NotNull] AMLParser.TagContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyword([NotNull] AMLParser.KeywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyword([NotNull] AMLParser.KeywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AMLParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] AMLParser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AMLParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] AMLParser.ConstantContext context);
}
} // namespace a2mlcsharp
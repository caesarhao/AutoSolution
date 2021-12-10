// Generated from AML.g4 by ANTLR 4.9.3
package a2mljava;
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link AMLParser}.
 */
public interface AMLListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link AMLParser#a2ml}.
	 * @param ctx the parse tree
	 */
	void enterA2ml(AMLParser.A2mlContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#a2ml}.
	 * @param ctx the parse tree
	 */
	void exitA2ml(AMLParser.A2mlContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#declaration_list}.
	 * @param ctx the parse tree
	 */
	void enterDeclaration_list(AMLParser.Declaration_listContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#declaration_list}.
	 * @param ctx the parse tree
	 */
	void exitDeclaration_list(AMLParser.Declaration_listContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#declaration}.
	 * @param ctx the parse tree
	 */
	void enterDeclaration(AMLParser.DeclarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#declaration}.
	 * @param ctx the parse tree
	 */
	void exitDeclaration(AMLParser.DeclarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#type_definition}.
	 * @param ctx the parse tree
	 */
	void enterType_definition(AMLParser.Type_definitionContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#type_definition}.
	 * @param ctx the parse tree
	 */
	void exitType_definition(AMLParser.Type_definitionContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#type_name}.
	 * @param ctx the parse tree
	 */
	void enterType_name(AMLParser.Type_nameContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#type_name}.
	 * @param ctx the parse tree
	 */
	void exitType_name(AMLParser.Type_nameContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#predefined_type_name}.
	 * @param ctx the parse tree
	 */
	void enterPredefined_type_name(AMLParser.Predefined_type_nameContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#predefined_type_name}.
	 * @param ctx the parse tree
	 */
	void exitPredefined_type_name(AMLParser.Predefined_type_nameContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#block_definition}.
	 * @param ctx the parse tree
	 */
	void enterBlock_definition(AMLParser.Block_definitionContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#block_definition}.
	 * @param ctx the parse tree
	 */
	void exitBlock_definition(AMLParser.Block_definitionContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#enum_type_name}.
	 * @param ctx the parse tree
	 */
	void enterEnum_type_name(AMLParser.Enum_type_nameContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#enum_type_name}.
	 * @param ctx the parse tree
	 */
	void exitEnum_type_name(AMLParser.Enum_type_nameContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#enumerator_list}.
	 * @param ctx the parse tree
	 */
	void enterEnumerator_list(AMLParser.Enumerator_listContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#enumerator_list}.
	 * @param ctx the parse tree
	 */
	void exitEnumerator_list(AMLParser.Enumerator_listContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#enumerator}.
	 * @param ctx the parse tree
	 */
	void enterEnumerator(AMLParser.EnumeratorContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#enumerator}.
	 * @param ctx the parse tree
	 */
	void exitEnumerator(AMLParser.EnumeratorContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#struct_type_name}.
	 * @param ctx the parse tree
	 */
	void enterStruct_type_name(AMLParser.Struct_type_nameContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#struct_type_name}.
	 * @param ctx the parse tree
	 */
	void exitStruct_type_name(AMLParser.Struct_type_nameContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#struct_member_list}.
	 * @param ctx the parse tree
	 */
	void enterStruct_member_list(AMLParser.Struct_member_listContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#struct_member_list}.
	 * @param ctx the parse tree
	 */
	void exitStruct_member_list(AMLParser.Struct_member_listContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#struct_member}.
	 * @param ctx the parse tree
	 */
	void enterStruct_member(AMLParser.Struct_memberContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#struct_member}.
	 * @param ctx the parse tree
	 */
	void exitStruct_member(AMLParser.Struct_memberContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#member}.
	 * @param ctx the parse tree
	 */
	void enterMember(AMLParser.MemberContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#member}.
	 * @param ctx the parse tree
	 */
	void exitMember(AMLParser.MemberContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#array_specifier}.
	 * @param ctx the parse tree
	 */
	void enterArray_specifier(AMLParser.Array_specifierContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#array_specifier}.
	 * @param ctx the parse tree
	 */
	void exitArray_specifier(AMLParser.Array_specifierContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#taggedstruct_type_name}.
	 * @param ctx the parse tree
	 */
	void enterTaggedstruct_type_name(AMLParser.Taggedstruct_type_nameContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#taggedstruct_type_name}.
	 * @param ctx the parse tree
	 */
	void exitTaggedstruct_type_name(AMLParser.Taggedstruct_type_nameContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#taggedstruct_member_list}.
	 * @param ctx the parse tree
	 */
	void enterTaggedstruct_member_list(AMLParser.Taggedstruct_member_listContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#taggedstruct_member_list}.
	 * @param ctx the parse tree
	 */
	void exitTaggedstruct_member_list(AMLParser.Taggedstruct_member_listContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#taggedstruct_member}.
	 * @param ctx the parse tree
	 */
	void enterTaggedstruct_member(AMLParser.Taggedstruct_memberContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#taggedstruct_member}.
	 * @param ctx the parse tree
	 */
	void exitTaggedstruct_member(AMLParser.Taggedstruct_memberContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#taggedstruct_definition}.
	 * @param ctx the parse tree
	 */
	void enterTaggedstruct_definition(AMLParser.Taggedstruct_definitionContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#taggedstruct_definition}.
	 * @param ctx the parse tree
	 */
	void exitTaggedstruct_definition(AMLParser.Taggedstruct_definitionContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#taggedunion_type_name}.
	 * @param ctx the parse tree
	 */
	void enterTaggedunion_type_name(AMLParser.Taggedunion_type_nameContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#taggedunion_type_name}.
	 * @param ctx the parse tree
	 */
	void exitTaggedunion_type_name(AMLParser.Taggedunion_type_nameContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#taggedunion_member_list}.
	 * @param ctx the parse tree
	 */
	void enterTaggedunion_member_list(AMLParser.Taggedunion_member_listContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#taggedunion_member_list}.
	 * @param ctx the parse tree
	 */
	void exitTaggedunion_member_list(AMLParser.Taggedunion_member_listContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#tagged_union_member}.
	 * @param ctx the parse tree
	 */
	void enterTagged_union_member(AMLParser.Tagged_union_memberContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#tagged_union_member}.
	 * @param ctx the parse tree
	 */
	void exitTagged_union_member(AMLParser.Tagged_union_memberContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#identifier}.
	 * @param ctx the parse tree
	 */
	void enterIdentifier(AMLParser.IdentifierContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#identifier}.
	 * @param ctx the parse tree
	 */
	void exitIdentifier(AMLParser.IdentifierContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#tag}.
	 * @param ctx the parse tree
	 */
	void enterTag(AMLParser.TagContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#tag}.
	 * @param ctx the parse tree
	 */
	void exitTag(AMLParser.TagContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#keyword}.
	 * @param ctx the parse tree
	 */
	void enterKeyword(AMLParser.KeywordContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#keyword}.
	 * @param ctx the parse tree
	 */
	void exitKeyword(AMLParser.KeywordContext ctx);
	/**
	 * Enter a parse tree produced by {@link AMLParser#constant}.
	 * @param ctx the parse tree
	 */
	void enterConstant(AMLParser.ConstantContext ctx);
	/**
	 * Exit a parse tree produced by {@link AMLParser#constant}.
	 * @param ctx the parse tree
	 */
	void exitConstant(AMLParser.ConstantContext ctx);
}
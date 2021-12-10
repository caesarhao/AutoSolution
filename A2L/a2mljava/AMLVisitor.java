// Generated from AML.g4 by ANTLR 4.9.3
package a2mljava;
import org.antlr.v4.runtime.tree.ParseTreeVisitor;

/**
 * This interface defines a complete generic visitor for a parse tree produced
 * by {@link AMLParser}.
 *
 * @param <T> The return type of the visit operation. Use {@link Void} for
 * operations with no return type.
 */
public interface AMLVisitor<T> extends ParseTreeVisitor<T> {
	/**
	 * Visit a parse tree produced by {@link AMLParser#a2ml}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitA2ml(AMLParser.A2mlContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#declaration_list}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDeclaration_list(AMLParser.Declaration_listContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#declaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDeclaration(AMLParser.DeclarationContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#type_definition}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitType_definition(AMLParser.Type_definitionContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#type_name}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitType_name(AMLParser.Type_nameContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#predefined_type_name}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPredefined_type_name(AMLParser.Predefined_type_nameContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#block_definition}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitBlock_definition(AMLParser.Block_definitionContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#enum_type_name}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEnum_type_name(AMLParser.Enum_type_nameContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#enumerator_list}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEnumerator_list(AMLParser.Enumerator_listContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#enumerator}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEnumerator(AMLParser.EnumeratorContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#struct_type_name}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitStruct_type_name(AMLParser.Struct_type_nameContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#struct_member_list}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitStruct_member_list(AMLParser.Struct_member_listContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#struct_member}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitStruct_member(AMLParser.Struct_memberContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#member}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMember(AMLParser.MemberContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#array_specifier}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitArray_specifier(AMLParser.Array_specifierContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#taggedstruct_type_name}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTaggedstruct_type_name(AMLParser.Taggedstruct_type_nameContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#taggedstruct_member_list}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTaggedstruct_member_list(AMLParser.Taggedstruct_member_listContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#taggedstruct_member}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTaggedstruct_member(AMLParser.Taggedstruct_memberContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#taggedstruct_definition}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTaggedstruct_definition(AMLParser.Taggedstruct_definitionContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#taggedunion_type_name}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTaggedunion_type_name(AMLParser.Taggedunion_type_nameContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#taggedunion_member_list}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTaggedunion_member_list(AMLParser.Taggedunion_member_listContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#tagged_union_member}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTagged_union_member(AMLParser.Tagged_union_memberContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#identifier}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIdentifier(AMLParser.IdentifierContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#tag}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTag(AMLParser.TagContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#keyword}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitKeyword(AMLParser.KeywordContext ctx);
	/**
	 * Visit a parse tree produced by {@link AMLParser#constant}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitConstant(AMLParser.ConstantContext ctx);
}
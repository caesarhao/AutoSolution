# Generated from AML.g4 by ANTLR 4.9.3
from antlr4 import *
if __name__ is not None and "." in __name__:
    from .AMLParser import AMLParser
else:
    from AMLParser import AMLParser

# This class defines a complete generic visitor for a parse tree produced by AMLParser.

class AMLVisitor(ParseTreeVisitor):

    # Visit a parse tree produced by AMLParser#a2ml.
    def visitA2ml(self, ctx:AMLParser.A2mlContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#declaration_list.
    def visitDeclaration_list(self, ctx:AMLParser.Declaration_listContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#declaration.
    def visitDeclaration(self, ctx:AMLParser.DeclarationContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#type_definition.
    def visitType_definition(self, ctx:AMLParser.Type_definitionContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#type_name.
    def visitType_name(self, ctx:AMLParser.Type_nameContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#predefined_type_name.
    def visitPredefined_type_name(self, ctx:AMLParser.Predefined_type_nameContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#block_definition.
    def visitBlock_definition(self, ctx:AMLParser.Block_definitionContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#enum_type_name.
    def visitEnum_type_name(self, ctx:AMLParser.Enum_type_nameContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#enumerator_list.
    def visitEnumerator_list(self, ctx:AMLParser.Enumerator_listContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#enumerator.
    def visitEnumerator(self, ctx:AMLParser.EnumeratorContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#struct_type_name.
    def visitStruct_type_name(self, ctx:AMLParser.Struct_type_nameContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#struct_member_list.
    def visitStruct_member_list(self, ctx:AMLParser.Struct_member_listContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#struct_member.
    def visitStruct_member(self, ctx:AMLParser.Struct_memberContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#member.
    def visitMember(self, ctx:AMLParser.MemberContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#array_specifier.
    def visitArray_specifier(self, ctx:AMLParser.Array_specifierContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#taggedstruct_type_name.
    def visitTaggedstruct_type_name(self, ctx:AMLParser.Taggedstruct_type_nameContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#taggedstruct_member_list.
    def visitTaggedstruct_member_list(self, ctx:AMLParser.Taggedstruct_member_listContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#taggedstruct_member.
    def visitTaggedstruct_member(self, ctx:AMLParser.Taggedstruct_memberContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#taggedstruct_definition.
    def visitTaggedstruct_definition(self, ctx:AMLParser.Taggedstruct_definitionContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#taggedunion_type_name.
    def visitTaggedunion_type_name(self, ctx:AMLParser.Taggedunion_type_nameContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#taggedunion_member_list.
    def visitTaggedunion_member_list(self, ctx:AMLParser.Taggedunion_member_listContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#tagged_union_member.
    def visitTagged_union_member(self, ctx:AMLParser.Tagged_union_memberContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#identifier.
    def visitIdentifier(self, ctx:AMLParser.IdentifierContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#tag.
    def visitTag(self, ctx:AMLParser.TagContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#keyword.
    def visitKeyword(self, ctx:AMLParser.KeywordContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by AMLParser#constant.
    def visitConstant(self, ctx:AMLParser.ConstantContext):
        return self.visitChildren(ctx)



del AMLParser
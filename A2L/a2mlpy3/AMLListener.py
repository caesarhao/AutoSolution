# Generated from AML.g4 by ANTLR 4.9.3
from antlr4 import *
if __name__ is not None and "." in __name__:
    from .AMLParser import AMLParser
else:
    from AMLParser import AMLParser

# This class defines a complete listener for a parse tree produced by AMLParser.
class AMLListener(ParseTreeListener):

    # Enter a parse tree produced by AMLParser#a2ml.
    def enterA2ml(self, ctx:AMLParser.A2mlContext):
        pass

    # Exit a parse tree produced by AMLParser#a2ml.
    def exitA2ml(self, ctx:AMLParser.A2mlContext):
        pass


    # Enter a parse tree produced by AMLParser#declaration.
    def enterDeclaration(self, ctx:AMLParser.DeclarationContext):
        pass

    # Exit a parse tree produced by AMLParser#declaration.
    def exitDeclaration(self, ctx:AMLParser.DeclarationContext):
        pass


    # Enter a parse tree produced by AMLParser#type_definition.
    def enterType_definition(self, ctx:AMLParser.Type_definitionContext):
        pass

    # Exit a parse tree produced by AMLParser#type_definition.
    def exitType_definition(self, ctx:AMLParser.Type_definitionContext):
        pass


    # Enter a parse tree produced by AMLParser#type_name.
    def enterType_name(self, ctx:AMLParser.Type_nameContext):
        pass

    # Exit a parse tree produced by AMLParser#type_name.
    def exitType_name(self, ctx:AMLParser.Type_nameContext):
        pass


    # Enter a parse tree produced by AMLParser#predefined_type_name.
    def enterPredefined_type_name(self, ctx:AMLParser.Predefined_type_nameContext):
        pass

    # Exit a parse tree produced by AMLParser#predefined_type_name.
    def exitPredefined_type_name(self, ctx:AMLParser.Predefined_type_nameContext):
        pass


    # Enter a parse tree produced by AMLParser#block_definition.
    def enterBlock_definition(self, ctx:AMLParser.Block_definitionContext):
        pass

    # Exit a parse tree produced by AMLParser#block_definition.
    def exitBlock_definition(self, ctx:AMLParser.Block_definitionContext):
        pass


    # Enter a parse tree produced by AMLParser#enum_type_name.
    def enterEnum_type_name(self, ctx:AMLParser.Enum_type_nameContext):
        pass

    # Exit a parse tree produced by AMLParser#enum_type_name.
    def exitEnum_type_name(self, ctx:AMLParser.Enum_type_nameContext):
        pass


    # Enter a parse tree produced by AMLParser#enumerator_list.
    def enterEnumerator_list(self, ctx:AMLParser.Enumerator_listContext):
        pass

    # Exit a parse tree produced by AMLParser#enumerator_list.
    def exitEnumerator_list(self, ctx:AMLParser.Enumerator_listContext):
        pass


    # Enter a parse tree produced by AMLParser#enumerator.
    def enterEnumerator(self, ctx:AMLParser.EnumeratorContext):
        pass

    # Exit a parse tree produced by AMLParser#enumerator.
    def exitEnumerator(self, ctx:AMLParser.EnumeratorContext):
        pass


    # Enter a parse tree produced by AMLParser#struct_type_name.
    def enterStruct_type_name(self, ctx:AMLParser.Struct_type_nameContext):
        pass

    # Exit a parse tree produced by AMLParser#struct_type_name.
    def exitStruct_type_name(self, ctx:AMLParser.Struct_type_nameContext):
        pass


    # Enter a parse tree produced by AMLParser#struct_member_list.
    def enterStruct_member_list(self, ctx:AMLParser.Struct_member_listContext):
        pass

    # Exit a parse tree produced by AMLParser#struct_member_list.
    def exitStruct_member_list(self, ctx:AMLParser.Struct_member_listContext):
        pass


    # Enter a parse tree produced by AMLParser#struct_member.
    def enterStruct_member(self, ctx:AMLParser.Struct_memberContext):
        pass

    # Exit a parse tree produced by AMLParser#struct_member.
    def exitStruct_member(self, ctx:AMLParser.Struct_memberContext):
        pass


    # Enter a parse tree produced by AMLParser#member.
    def enterMember(self, ctx:AMLParser.MemberContext):
        pass

    # Exit a parse tree produced by AMLParser#member.
    def exitMember(self, ctx:AMLParser.MemberContext):
        pass


    # Enter a parse tree produced by AMLParser#array_specifier.
    def enterArray_specifier(self, ctx:AMLParser.Array_specifierContext):
        pass

    # Exit a parse tree produced by AMLParser#array_specifier.
    def exitArray_specifier(self, ctx:AMLParser.Array_specifierContext):
        pass


    # Enter a parse tree produced by AMLParser#taggedstruct_type_name.
    def enterTaggedstruct_type_name(self, ctx:AMLParser.Taggedstruct_type_nameContext):
        pass

    # Exit a parse tree produced by AMLParser#taggedstruct_type_name.
    def exitTaggedstruct_type_name(self, ctx:AMLParser.Taggedstruct_type_nameContext):
        pass


    # Enter a parse tree produced by AMLParser#taggedstruct_member_list.
    def enterTaggedstruct_member_list(self, ctx:AMLParser.Taggedstruct_member_listContext):
        pass

    # Exit a parse tree produced by AMLParser#taggedstruct_member_list.
    def exitTaggedstruct_member_list(self, ctx:AMLParser.Taggedstruct_member_listContext):
        pass


    # Enter a parse tree produced by AMLParser#taggedstruct_member.
    def enterTaggedstruct_member(self, ctx:AMLParser.Taggedstruct_memberContext):
        pass

    # Exit a parse tree produced by AMLParser#taggedstruct_member.
    def exitTaggedstruct_member(self, ctx:AMLParser.Taggedstruct_memberContext):
        pass


    # Enter a parse tree produced by AMLParser#taggedstruct_definition.
    def enterTaggedstruct_definition(self, ctx:AMLParser.Taggedstruct_definitionContext):
        pass

    # Exit a parse tree produced by AMLParser#taggedstruct_definition.
    def exitTaggedstruct_definition(self, ctx:AMLParser.Taggedstruct_definitionContext):
        pass


    # Enter a parse tree produced by AMLParser#taggedunion_type_name.
    def enterTaggedunion_type_name(self, ctx:AMLParser.Taggedunion_type_nameContext):
        pass

    # Exit a parse tree produced by AMLParser#taggedunion_type_name.
    def exitTaggedunion_type_name(self, ctx:AMLParser.Taggedunion_type_nameContext):
        pass


    # Enter a parse tree produced by AMLParser#taggedunion_member_list.
    def enterTaggedunion_member_list(self, ctx:AMLParser.Taggedunion_member_listContext):
        pass

    # Exit a parse tree produced by AMLParser#taggedunion_member_list.
    def exitTaggedunion_member_list(self, ctx:AMLParser.Taggedunion_member_listContext):
        pass


    # Enter a parse tree produced by AMLParser#tagged_union_member.
    def enterTagged_union_member(self, ctx:AMLParser.Tagged_union_memberContext):
        pass

    # Exit a parse tree produced by AMLParser#tagged_union_member.
    def exitTagged_union_member(self, ctx:AMLParser.Tagged_union_memberContext):
        pass


    # Enter a parse tree produced by AMLParser#identifier.
    def enterIdentifier(self, ctx:AMLParser.IdentifierContext):
        pass

    # Exit a parse tree produced by AMLParser#identifier.
    def exitIdentifier(self, ctx:AMLParser.IdentifierContext):
        pass


    # Enter a parse tree produced by AMLParser#tag.
    def enterTag(self, ctx:AMLParser.TagContext):
        pass

    # Exit a parse tree produced by AMLParser#tag.
    def exitTag(self, ctx:AMLParser.TagContext):
        pass


    # Enter a parse tree produced by AMLParser#keyword.
    def enterKeyword(self, ctx:AMLParser.KeywordContext):
        pass

    # Exit a parse tree produced by AMLParser#keyword.
    def exitKeyword(self, ctx:AMLParser.KeywordContext):
        pass


    # Enter a parse tree produced by AMLParser#constant.
    def enterConstant(self, ctx:AMLParser.ConstantContext):
        pass

    # Exit a parse tree produced by AMLParser#constant.
    def exitConstant(self, ctx:AMLParser.ConstantContext):
        pass



del AMLParser
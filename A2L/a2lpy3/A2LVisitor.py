# Generated from A2L.g4 by ANTLR 4.9.3
from antlr4 import *
if __name__ is not None and "." in __name__:
    from .A2LParser import A2LParser
else:
    from A2LParser import A2LParser

# This class defines a complete generic visitor for a parse tree produced by A2LParser.

class A2LVisitor(ParseTreeVisitor):

    # Visit a parse tree produced by A2LParser#a2ml.
    def visitA2ml(self, ctx:A2LParser.A2mlContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#declaration_list.
    def visitDeclaration_list(self, ctx:A2LParser.Declaration_listContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#declaration.
    def visitDeclaration(self, ctx:A2LParser.DeclarationContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#type_definition.
    def visitType_definition(self, ctx:A2LParser.Type_definitionContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#type_name.
    def visitType_name(self, ctx:A2LParser.Type_nameContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#predefined_type_name.
    def visitPredefined_type_name(self, ctx:A2LParser.Predefined_type_nameContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#block_definition.
    def visitBlock_definition(self, ctx:A2LParser.Block_definitionContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#enum_type_name.
    def visitEnum_type_name(self, ctx:A2LParser.Enum_type_nameContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#enumerator_list.
    def visitEnumerator_list(self, ctx:A2LParser.Enumerator_listContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#enumerator.
    def visitEnumerator(self, ctx:A2LParser.EnumeratorContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#struct_type_name.
    def visitStruct_type_name(self, ctx:A2LParser.Struct_type_nameContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#struct_member_list.
    def visitStruct_member_list(self, ctx:A2LParser.Struct_member_listContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#struct_member.
    def visitStruct_member(self, ctx:A2LParser.Struct_memberContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#member.
    def visitMember(self, ctx:A2LParser.MemberContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#array_specifier.
    def visitArray_specifier(self, ctx:A2LParser.Array_specifierContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#taggedstruct_type_name.
    def visitTaggedstruct_type_name(self, ctx:A2LParser.Taggedstruct_type_nameContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#taggedstruct_member_list.
    def visitTaggedstruct_member_list(self, ctx:A2LParser.Taggedstruct_member_listContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#taggedstruct_member.
    def visitTaggedstruct_member(self, ctx:A2LParser.Taggedstruct_memberContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#taggedstruct_definition.
    def visitTaggedstruct_definition(self, ctx:A2LParser.Taggedstruct_definitionContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#taggedunion_type_name.
    def visitTaggedunion_type_name(self, ctx:A2LParser.Taggedunion_type_nameContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#taggedunion_member_list.
    def visitTaggedunion_member_list(self, ctx:A2LParser.Taggedunion_member_listContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#tagged_union_member.
    def visitTagged_union_member(self, ctx:A2LParser.Tagged_union_memberContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#identifier.
    def visitIdentifier(self, ctx:A2LParser.IdentifierContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#tag.
    def visitTag(self, ctx:A2LParser.TagContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#keyword.
    def visitKeyword(self, ctx:A2LParser.KeywordContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#constant.
    def visitConstant(self, ctx:A2LParser.ConstantContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#a2l.
    def visitA2l(self, ctx:A2LParser.A2lContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#a2ml_ver.
    def visitA2ml_ver(self, ctx:A2LParser.A2ml_verContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#addr_epk.
    def visitAddr_epk(self, ctx:A2LParser.Addr_epkContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#address_type.
    def visitAddress_type(self, ctx:A2LParser.Address_typeContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#alignment_byte.
    def visitAlignment_byte(self, ctx:A2LParser.Alignment_byteContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#alignment_float16_ieee.
    def visitAlignment_float16_ieee(self, ctx:A2LParser.Alignment_float16_ieeeContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#alignment_float32_ieee.
    def visitAlignment_float32_ieee(self, ctx:A2LParser.Alignment_float32_ieeeContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#alignment_float64_ieee.
    def visitAlignment_float64_ieee(self, ctx:A2LParser.Alignment_float64_ieeeContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#alignment_int64.
    def visitAlignment_int64(self, ctx:A2LParser.Alignment_int64Context):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#alignment_long.
    def visitAlignment_long(self, ctx:A2LParser.Alignment_longContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#alignment_word.
    def visitAlignment_word(self, ctx:A2LParser.Alignment_wordContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#annotation.
    def visitAnnotation(self, ctx:A2LParser.AnnotationContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#annotation_label.
    def visitAnnotation_label(self, ctx:A2LParser.Annotation_labelContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#annotation_origin.
    def visitAnnotation_origin(self, ctx:A2LParser.Annotation_originContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#annotation_text.
    def visitAnnotation_text(self, ctx:A2LParser.Annotation_textContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#array_size.
    def visitArray_size(self, ctx:A2LParser.Array_sizeContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#asap2_ver.
    def visitAsap2_ver(self, ctx:A2LParser.Asap2_verContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#axis_descr.
    def visitAxis_descr(self, ctx:A2LParser.Axis_descrContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#axis_pts.
    def visitAxis_pts(self, ctx:A2LParser.Axis_ptsContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#axis_pts_ref.
    def visitAxis_pts_ref(self, ctx:A2LParser.Axis_pts_refContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#axis_pts_x.
    def visitAxis_pts_x(self, ctx:A2LParser.Axis_pts_xContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#axis_pts_y.
    def visitAxis_pts_y(self, ctx:A2LParser.Axis_pts_yContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#axis_pts_z.
    def visitAxis_pts_z(self, ctx:A2LParser.Axis_pts_zContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#axis_pts_4.
    def visitAxis_pts_4(self, ctx:A2LParser.Axis_pts_4Context):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#axis_pts_5.
    def visitAxis_pts_5(self, ctx:A2LParser.Axis_pts_5Context):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#axis_rescale_x.
    def visitAxis_rescale_x(self, ctx:A2LParser.Axis_rescale_xContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#bit_mask.
    def visitBit_mask(self, ctx:A2LParser.Bit_maskContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#bit_operation.
    def visitBit_operation(self, ctx:A2LParser.Bit_operationContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#blob.
    def visitBlob(self, ctx:A2LParser.BlobContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#byte_order.
    def visitByte_order(self, ctx:A2LParser.Byte_orderContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#calibration_access.
    def visitCalibration_access(self, ctx:A2LParser.Calibration_accessContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#calibration_handle.
    def visitCalibration_handle(self, ctx:A2LParser.Calibration_handleContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#calibration_handle_text.
    def visitCalibration_handle_text(self, ctx:A2LParser.Calibration_handle_textContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#calibration_method.
    def visitCalibration_method(self, ctx:A2LParser.Calibration_methodContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#characteristic.
    def visitCharacteristic(self, ctx:A2LParser.CharacteristicContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#coeffs.
    def visitCoeffs(self, ctx:A2LParser.CoeffsContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#coeffs_linear.
    def visitCoeffs_linear(self, ctx:A2LParser.Coeffs_linearContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#comparison_quantity.
    def visitComparison_quantity(self, ctx:A2LParser.Comparison_quantityContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#compu_method.
    def visitCompu_method(self, ctx:A2LParser.Compu_methodContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#compu_tab.
    def visitCompu_tab(self, ctx:A2LParser.Compu_tabContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#compu_tab_ref.
    def visitCompu_tab_ref(self, ctx:A2LParser.Compu_tab_refContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#compu_vtab.
    def visitCompu_vtab(self, ctx:A2LParser.Compu_vtabContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#compu_vtab_range.
    def visitCompu_vtab_range(self, ctx:A2LParser.Compu_vtab_rangeContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#consistent_exchange.
    def visitConsistent_exchange(self, ctx:A2LParser.Consistent_exchangeContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#conversion.
    def visitConversion(self, ctx:A2LParser.ConversionContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#cpu_type.
    def visitCpu_type(self, ctx:A2LParser.Cpu_typeContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#curve_axis_ref.
    def visitCurve_axis_ref(self, ctx:A2LParser.Curve_axis_refContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#customer.
    def visitCustomer(self, ctx:A2LParser.CustomerContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#customer_no.
    def visitCustomer_no(self, ctx:A2LParser.Customer_noContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#data_size.
    def visitData_size(self, ctx:A2LParser.Data_sizeContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#def_characteristic.
    def visitDef_characteristic(self, ctx:A2LParser.Def_characteristicContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#default_value.
    def visitDefault_value(self, ctx:A2LParser.Default_valueContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#default_value_numeric.
    def visitDefault_value_numeric(self, ctx:A2LParser.Default_value_numericContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#dependent_characteristic.
    def visitDependent_characteristic(self, ctx:A2LParser.Dependent_characteristicContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#deposit.
    def visitDeposit(self, ctx:A2LParser.DepositContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#discrete.
    def visitDiscrete(self, ctx:A2LParser.DiscreteContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#display_identifier.
    def visitDisplay_identifier(self, ctx:A2LParser.Display_identifierContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#dist_op_x.
    def visitDist_op_x(self, ctx:A2LParser.Dist_op_xContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#dist_op_y.
    def visitDist_op_y(self, ctx:A2LParser.Dist_op_yContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#dist_op_z.
    def visitDist_op_z(self, ctx:A2LParser.Dist_op_zContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#dist_op_4.
    def visitDist_op_4(self, ctx:A2LParser.Dist_op_4Context):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#dist_op_5.
    def visitDist_op_5(self, ctx:A2LParser.Dist_op_5Context):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#ecu.
    def visitEcu(self, ctx:A2LParser.EcuContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#ecu_address.
    def visitEcu_address(self, ctx:A2LParser.Ecu_addressContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#ecu_address_extension.
    def visitEcu_address_extension(self, ctx:A2LParser.Ecu_address_extensionContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#ecu_calibration_offset.
    def visitEcu_calibration_offset(self, ctx:A2LParser.Ecu_calibration_offsetContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#encoding.
    def visitEncoding(self, ctx:A2LParser.EncodingContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#epk.
    def visitEpk(self, ctx:A2LParser.EpkContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#error_mask.
    def visitError_mask(self, ctx:A2LParser.Error_maskContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#extended_limits.
    def visitExtended_limits(self, ctx:A2LParser.Extended_limitsContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#fix_axis_par.
    def visitFix_axis_par(self, ctx:A2LParser.Fix_axis_parContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#fix_axis_par_dist.
    def visitFix_axis_par_dist(self, ctx:A2LParser.Fix_axis_par_distContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#fix_axis_par_list.
    def visitFix_axis_par_list(self, ctx:A2LParser.Fix_axis_par_listContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#fix_no_axis_pts_x.
    def visitFix_no_axis_pts_x(self, ctx:A2LParser.Fix_no_axis_pts_xContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#fix_no_axis_pts_y.
    def visitFix_no_axis_pts_y(self, ctx:A2LParser.Fix_no_axis_pts_yContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#fix_no_axis_pts_z.
    def visitFix_no_axis_pts_z(self, ctx:A2LParser.Fix_no_axis_pts_zContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#fix_no_axis_pts_4.
    def visitFix_no_axis_pts_4(self, ctx:A2LParser.Fix_no_axis_pts_4Context):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#fix_no_axis_pts_5.
    def visitFix_no_axis_pts_5(self, ctx:A2LParser.Fix_no_axis_pts_5Context):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#fnc_values.
    def visitFnc_values(self, ctx:A2LParser.Fnc_valuesContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#formate.
    def visitFormate(self, ctx:A2LParser.FormateContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#formula.
    def visitFormula(self, ctx:A2LParser.FormulaContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#formula_inv.
    def visitFormula_inv(self, ctx:A2LParser.Formula_invContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#frame.
    def visitFrame(self, ctx:A2LParser.FrameContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#frame_measurement.
    def visitFrame_measurement(self, ctx:A2LParser.Frame_measurementContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#function.
    def visitFunction(self, ctx:A2LParser.FunctionContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#function_list.
    def visitFunction_list(self, ctx:A2LParser.Function_listContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#function_version.
    def visitFunction_version(self, ctx:A2LParser.Function_versionContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#group.
    def visitGroup(self, ctx:A2LParser.GroupContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#guard_rails.
    def visitGuard_rails(self, ctx:A2LParser.Guard_railsContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#header.
    def visitHeader(self, ctx:A2LParser.HeaderContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#identification.
    def visitIdentification(self, ctx:A2LParser.IdentificationContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#if_data.
    def visitIf_data(self, ctx:A2LParser.If_dataContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#include.
    def visitInclude(self, ctx:A2LParser.IncludeContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#in_measurement.
    def visitIn_measurement(self, ctx:A2LParser.In_measurementContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#input_quantity.
    def visitInput_quantity(self, ctx:A2LParser.Input_quantityContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#instance.
    def visitInstance(self, ctx:A2LParser.InstanceContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#layout.
    def visitLayout(self, ctx:A2LParser.LayoutContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#left_shift.
    def visitLeft_shift(self, ctx:A2LParser.Left_shiftContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#limits.
    def visitLimits(self, ctx:A2LParser.LimitsContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#loc_measurement.
    def visitLoc_measurement(self, ctx:A2LParser.Loc_measurementContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#map_list.
    def visitMap_list(self, ctx:A2LParser.Map_listContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#matrix_dim.
    def visitMatrix_dim(self, ctx:A2LParser.Matrix_dimContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#max_grad.
    def visitMax_grad(self, ctx:A2LParser.Max_gradContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#max_refresh.
    def visitMax_refresh(self, ctx:A2LParser.Max_refreshContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#measurement.
    def visitMeasurement(self, ctx:A2LParser.MeasurementContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#memory_layout.
    def visitMemory_layout(self, ctx:A2LParser.Memory_layoutContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#memory_segment.
    def visitMemory_segment(self, ctx:A2LParser.Memory_segmentContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#mod_common.
    def visitMod_common(self, ctx:A2LParser.Mod_commonContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#mod_par.
    def visitMod_par(self, ctx:A2LParser.Mod_parContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#model_link.
    def visitModel_link(self, ctx:A2LParser.Model_linkContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#module.
    def visitModule(self, ctx:A2LParser.ModuleContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#monotony.
    def visitMonotony(self, ctx:A2LParser.MonotonyContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#no_axis_pts_x.
    def visitNo_axis_pts_x(self, ctx:A2LParser.No_axis_pts_xContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#no_axis_pts_y.
    def visitNo_axis_pts_y(self, ctx:A2LParser.No_axis_pts_yContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#no_axis_pts_z.
    def visitNo_axis_pts_z(self, ctx:A2LParser.No_axis_pts_zContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#no_axis_pts_4.
    def visitNo_axis_pts_4(self, ctx:A2LParser.No_axis_pts_4Context):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#no_axis_pts_5.
    def visitNo_axis_pts_5(self, ctx:A2LParser.No_axis_pts_5Context):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#no_of_interfaces.
    def visitNo_of_interfaces(self, ctx:A2LParser.No_of_interfacesContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#no_rescale_x.
    def visitNo_rescale_x(self, ctx:A2LParser.No_rescale_xContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#number.
    def visitNumber(self, ctx:A2LParser.NumberContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#offset_x.
    def visitOffset_x(self, ctx:A2LParser.Offset_xContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#offset_y.
    def visitOffset_y(self, ctx:A2LParser.Offset_yContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#offset_z.
    def visitOffset_z(self, ctx:A2LParser.Offset_zContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#offset_4.
    def visitOffset_4(self, ctx:A2LParser.Offset_4Context):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#offset_5.
    def visitOffset_5(self, ctx:A2LParser.Offset_5Context):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#out_measurement.
    def visitOut_measurement(self, ctx:A2LParser.Out_measurementContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#overwrite.
    def visitOverwrite(self, ctx:A2LParser.OverwriteContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#phone_no.
    def visitPhone_no(self, ctx:A2LParser.Phone_noContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#phys_unit.
    def visitPhys_unit(self, ctx:A2LParser.Phys_unitContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#project.
    def visitProject(self, ctx:A2LParser.ProjectContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#project_no.
    def visitProject_no(self, ctx:A2LParser.Project_noContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#read_only.
    def visitRead_only(self, ctx:A2LParser.Read_onlyContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#read_write.
    def visitRead_write(self, ctx:A2LParser.Read_writeContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#record_layout.
    def visitRecord_layout(self, ctx:A2LParser.Record_layoutContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#ref_characteristic.
    def visitRef_characteristic(self, ctx:A2LParser.Ref_characteristicContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#ref_group.
    def visitRef_group(self, ctx:A2LParser.Ref_groupContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#ref_measurement.
    def visitRef_measurement(self, ctx:A2LParser.Ref_measurementContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#ref_memory_segment.
    def visitRef_memory_segment(self, ctx:A2LParser.Ref_memory_segmentContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#ref_unit.
    def visitRef_unit(self, ctx:A2LParser.Ref_unitContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#reserved.
    def visitReserved(self, ctx:A2LParser.ReservedContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#right_shift.
    def visitRight_shift(self, ctx:A2LParser.Right_shiftContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#rip_addr_w.
    def visitRip_addr_w(self, ctx:A2LParser.Rip_addr_wContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#rip_addr_x.
    def visitRip_addr_x(self, ctx:A2LParser.Rip_addr_xContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#rip_addr_y.
    def visitRip_addr_y(self, ctx:A2LParser.Rip_addr_yContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#rip_addr_z.
    def visitRip_addr_z(self, ctx:A2LParser.Rip_addr_zContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#rip_addr_4.
    def visitRip_addr_4(self, ctx:A2LParser.Rip_addr_4Context):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#rip_addr_5.
    def visitRip_addr_5(self, ctx:A2LParser.Rip_addr_5Context):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#root.
    def visitRoot(self, ctx:A2LParser.RootContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#shift_op_x.
    def visitShift_op_x(self, ctx:A2LParser.Shift_op_xContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#shift_op_y.
    def visitShift_op_y(self, ctx:A2LParser.Shift_op_yContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#shift_op_z.
    def visitShift_op_z(self, ctx:A2LParser.Shift_op_zContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#shift_op_4.
    def visitShift_op_4(self, ctx:A2LParser.Shift_op_4Context):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#shift_op_5.
    def visitShift_op_5(self, ctx:A2LParser.Shift_op_5Context):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#sign_extend.
    def visitSign_extend(self, ctx:A2LParser.Sign_extendContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#si_exponents.
    def visitSi_exponents(self, ctx:A2LParser.Si_exponentsContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#src_addr_x.
    def visitSrc_addr_x(self, ctx:A2LParser.Src_addr_xContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#src_addr_y.
    def visitSrc_addr_y(self, ctx:A2LParser.Src_addr_yContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#src_addr_z.
    def visitSrc_addr_z(self, ctx:A2LParser.Src_addr_zContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#src_addr_4.
    def visitSrc_addr_4(self, ctx:A2LParser.Src_addr_4Context):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#src_addr_5.
    def visitSrc_addr_5(self, ctx:A2LParser.Src_addr_5Context):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#static_record_layout.
    def visitStatic_record_layout(self, ctx:A2LParser.Static_record_layoutContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#status_string_ref.
    def visitStatus_string_ref(self, ctx:A2LParser.Status_string_refContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#step_size.
    def visitStep_size(self, ctx:A2LParser.Step_sizeContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#structure_component.
    def visitStructure_component(self, ctx:A2LParser.Structure_componentContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#sub_function.
    def visitSub_function(self, ctx:A2LParser.Sub_functionContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#sub_group.
    def visitSub_group(self, ctx:A2LParser.Sub_groupContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#supplier.
    def visitSupplier(self, ctx:A2LParser.SupplierContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#symbol_link.
    def visitSymbol_link(self, ctx:A2LParser.Symbol_linkContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#symbol_type_link.
    def visitSymbol_type_link(self, ctx:A2LParser.Symbol_type_linkContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#system_constant.
    def visitSystem_constant(self, ctx:A2LParser.System_constantContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#transformer.
    def visitTransformer(self, ctx:A2LParser.TransformerContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#transformer_in_objects.
    def visitTransformer_in_objects(self, ctx:A2LParser.Transformer_in_objectsContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#transformer_out_objects.
    def visitTransformer_out_objects(self, ctx:A2LParser.Transformer_out_objectsContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#typedef_axis.
    def visitTypedef_axis(self, ctx:A2LParser.Typedef_axisContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#typedef_blob.
    def visitTypedef_blob(self, ctx:A2LParser.Typedef_blobContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#typedef_characteristic.
    def visitTypedef_characteristic(self, ctx:A2LParser.Typedef_characteristicContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#typedef_measurement.
    def visitTypedef_measurement(self, ctx:A2LParser.Typedef_measurementContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#typedef_structure.
    def visitTypedef_structure(self, ctx:A2LParser.Typedef_structureContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#unit.
    def visitUnit(self, ctx:A2LParser.UnitContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#unit_conversion.
    def visitUnit_conversion(self, ctx:A2LParser.Unit_conversionContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#user.
    def visitUser(self, ctx:A2LParser.UserContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#user_rights.
    def visitUser_rights(self, ctx:A2LParser.User_rightsContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#var_address.
    def visitVar_address(self, ctx:A2LParser.Var_addressContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#var_characteristic.
    def visitVar_characteristic(self, ctx:A2LParser.Var_characteristicContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#var_criterion.
    def visitVar_criterion(self, ctx:A2LParser.Var_criterionContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#var_forbidden_comb.
    def visitVar_forbidden_comb(self, ctx:A2LParser.Var_forbidden_combContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#var_measurement.
    def visitVar_measurement(self, ctx:A2LParser.Var_measurementContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#var_naming.
    def visitVar_naming(self, ctx:A2LParser.Var_namingContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#var_selection_characteristic.
    def visitVar_selection_characteristic(self, ctx:A2LParser.Var_selection_characteristicContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#var_separator.
    def visitVar_separator(self, ctx:A2LParser.Var_separatorContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#variant_coding.
    def visitVariant_coding(self, ctx:A2LParser.Variant_codingContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#version.
    def visitVersion(self, ctx:A2LParser.VersionContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#virtual.
    def visitVirtual(self, ctx:A2LParser.VirtualContext):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by A2LParser#virtual_characteristic.
    def visitVirtual_characteristic(self, ctx:A2LParser.Virtual_characteristicContext):
        return self.visitChildren(ctx)



del A2LParser
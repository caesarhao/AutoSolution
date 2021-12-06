// Generated from A2L.g4 by ANTLR 4.9.3
package a2ljava;
import org.antlr.v4.runtime.tree.ParseTreeVisitor;

/**
 * This interface defines a complete generic visitor for a parse tree produced
 * by {@link A2LParser}.
 *
 * @param <T> The return type of the visit operation. Use {@link Void} for
 * operations with no return type.
 */
public interface A2LVisitor<T> extends ParseTreeVisitor<T> {
	/**
	 * Visit a parse tree produced by {@link A2LParser#a2ml}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitA2ml(A2LParser.A2mlContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#declaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDeclaration(A2LParser.DeclarationContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#type_definition}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitType_definition(A2LParser.Type_definitionContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#type_name}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitType_name(A2LParser.Type_nameContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#block_definition}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitBlock_definition(A2LParser.Block_definitionContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#enum_type_name}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEnum_type_name(A2LParser.Enum_type_nameContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#enumerator_list}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEnumerator_list(A2LParser.Enumerator_listContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#enumerator}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEnumerator(A2LParser.EnumeratorContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#struct_type_name}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitStruct_type_name(A2LParser.Struct_type_nameContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#struct_member_list}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitStruct_member_list(A2LParser.Struct_member_listContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#struct_member}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitStruct_member(A2LParser.Struct_memberContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#member}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMember(A2LParser.MemberContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#array_specifier}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitArray_specifier(A2LParser.Array_specifierContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#taggedstruct_type_name}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTaggedstruct_type_name(A2LParser.Taggedstruct_type_nameContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#taggedstruct_member_list}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTaggedstruct_member_list(A2LParser.Taggedstruct_member_listContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#taggedstruct_member}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTaggedstruct_member(A2LParser.Taggedstruct_memberContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#taggedstruct_definition}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTaggedstruct_definition(A2LParser.Taggedstruct_definitionContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#taggedunion_type_name}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTaggedunion_type_name(A2LParser.Taggedunion_type_nameContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#taggedunion_member_list}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTaggedunion_member_list(A2LParser.Taggedunion_member_listContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#tagged_union_member}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTagged_union_member(A2LParser.Tagged_union_memberContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#identifier}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIdentifier(A2LParser.IdentifierContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#tag}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTag(A2LParser.TagContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#keyword}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitKeyword(A2LParser.KeywordContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#constant}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitConstant(A2LParser.ConstantContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#a2l}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitA2l(A2LParser.A2lContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#a2ml_ver}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitA2ml_ver(A2LParser.A2ml_verContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#addr_epk}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAddr_epk(A2LParser.Addr_epkContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#alignment_byte}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAlignment_byte(A2LParser.Alignment_byteContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#alignment_A2LNUM32_ieee}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAlignment_A2LNUM32_ieee(A2LParser.Alignment_A2LNUM32_ieeeContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#alignment_A2LNUM64_ieee}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAlignment_A2LNUM64_ieee(A2LParser.Alignment_A2LNUM64_ieeeContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#alignment_A2LNUM64}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAlignment_A2LNUM64(A2LParser.Alignment_A2LNUM64Context ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#alignment_long}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAlignment_long(A2LParser.Alignment_longContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#alignment_word}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAlignment_word(A2LParser.Alignment_wordContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#annotation}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAnnotation(A2LParser.AnnotationContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#annotation_label}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAnnotation_label(A2LParser.Annotation_labelContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#annotation_origin}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAnnotation_origin(A2LParser.Annotation_originContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#annotation_text}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAnnotation_text(A2LParser.Annotation_textContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#array_size}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitArray_size(A2LParser.Array_sizeContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#asap2_ver}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAsap2_ver(A2LParser.Asap2_verContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#axis_descr}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAxis_descr(A2LParser.Axis_descrContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#axis_pts}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAxis_pts(A2LParser.Axis_ptsContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#axis_pts_optional}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAxis_pts_optional(A2LParser.Axis_pts_optionalContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#axis_pts_ref}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAxis_pts_ref(A2LParser.Axis_pts_refContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#axis_pts_x}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAxis_pts_x(A2LParser.Axis_pts_xContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#axis_pts_y}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAxis_pts_y(A2LParser.Axis_pts_yContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#axis_pts_z}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAxis_pts_z(A2LParser.Axis_pts_zContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#axis_pts_4}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAxis_pts_4(A2LParser.Axis_pts_4Context ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#axis_pts_5}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAxis_pts_5(A2LParser.Axis_pts_5Context ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#axis_rescale_x}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAxis_rescale_x(A2LParser.Axis_rescale_xContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#bit_mask}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitBit_mask(A2LParser.Bit_maskContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#bit_operation}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitBit_operation(A2LParser.Bit_operationContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#byte_order}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitByte_order(A2LParser.Byte_orderContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#calibration_access}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCalibration_access(A2LParser.Calibration_accessContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#calibration_handle}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCalibration_handle(A2LParser.Calibration_handleContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#calibration_handle_text}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCalibration_handle_text(A2LParser.Calibration_handle_textContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#calibration_method}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCalibration_method(A2LParser.Calibration_methodContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#characteristic}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCharacteristic(A2LParser.CharacteristicContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#characteristic_optional}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCharacteristic_optional(A2LParser.Characteristic_optionalContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#coeffs}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCoeffs(A2LParser.CoeffsContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#coeffs_linear}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCoeffs_linear(A2LParser.Coeffs_linearContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#comparison_quantity}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitComparison_quantity(A2LParser.Comparison_quantityContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#compu_method}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCompu_method(A2LParser.Compu_methodContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#compu_method_optional}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCompu_method_optional(A2LParser.Compu_method_optionalContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#compu_tab}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCompu_tab(A2LParser.Compu_tabContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#compu_tab_optional}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCompu_tab_optional(A2LParser.Compu_tab_optionalContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#compu_tab_ref}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCompu_tab_ref(A2LParser.Compu_tab_refContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#compu_vtab}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCompu_vtab(A2LParser.Compu_vtabContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#compu_vtab_range}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCompu_vtab_range(A2LParser.Compu_vtab_rangeContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#cpu_type}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCpu_type(A2LParser.Cpu_typeContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#curve_axis_ref}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCurve_axis_ref(A2LParser.Curve_axis_refContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#customer}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCustomer(A2LParser.CustomerContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#customer_no}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCustomer_no(A2LParser.Customer_noContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#data_size}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitData_size(A2LParser.Data_sizeContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#def_characteristic}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDef_characteristic(A2LParser.Def_characteristicContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#default_value}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDefault_value(A2LParser.Default_valueContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#default_value_numeric}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDefault_value_numeric(A2LParser.Default_value_numericContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#dependent_characteristic}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDependent_characteristic(A2LParser.Dependent_characteristicContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#deposit}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDeposit(A2LParser.DepositContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#discrete}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDiscrete(A2LParser.DiscreteContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#display_identifier}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDisplay_identifier(A2LParser.Display_identifierContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#dist_op_x}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDist_op_x(A2LParser.Dist_op_xContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#dist_op_y}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDist_op_y(A2LParser.Dist_op_yContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#dist_op_z}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDist_op_z(A2LParser.Dist_op_zContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#dist_op_4}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDist_op_4(A2LParser.Dist_op_4Context ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#dist_op_5}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDist_op_5(A2LParser.Dist_op_5Context ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#ecu}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEcu(A2LParser.EcuContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#ecu_address}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEcu_address(A2LParser.Ecu_addressContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#ecu_address_extension}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEcu_address_extension(A2LParser.Ecu_address_extensionContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#ecu_calibration_offset}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEcu_calibration_offset(A2LParser.Ecu_calibration_offsetContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#epk}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEpk(A2LParser.EpkContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#error_mask}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitError_mask(A2LParser.Error_maskContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#extended_limits}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitExtended_limits(A2LParser.Extended_limitsContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#fix_axis_par}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFix_axis_par(A2LParser.Fix_axis_parContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#fix_axis_par_dist}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFix_axis_par_dist(A2LParser.Fix_axis_par_distContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#fix_axis_par_list}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFix_axis_par_list(A2LParser.Fix_axis_par_listContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#fix_no_axis_pts_x}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFix_no_axis_pts_x(A2LParser.Fix_no_axis_pts_xContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#fix_no_axis_pts_y}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFix_no_axis_pts_y(A2LParser.Fix_no_axis_pts_yContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#fix_no_axis_pts_z}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFix_no_axis_pts_z(A2LParser.Fix_no_axis_pts_zContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#fix_no_axis_pts_4}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFix_no_axis_pts_4(A2LParser.Fix_no_axis_pts_4Context ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#fix_no_axis_pts_5}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFix_no_axis_pts_5(A2LParser.Fix_no_axis_pts_5Context ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#fnc_values}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFnc_values(A2LParser.Fnc_valuesContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#phormat}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPhormat(A2LParser.PhormatContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#formula}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFormula(A2LParser.FormulaContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#formula_inv}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFormula_inv(A2LParser.Formula_invContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#frame}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFrame(A2LParser.FrameContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#frame_measurement}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFrame_measurement(A2LParser.Frame_measurementContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#function}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFunction(A2LParser.FunctionContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#function_optional}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFunction_optional(A2LParser.Function_optionalContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#function_list}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFunction_list(A2LParser.Function_listContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#function_version}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFunction_version(A2LParser.Function_versionContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#group}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitGroup(A2LParser.GroupContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#group_optional}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitGroup_optional(A2LParser.Group_optionalContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#guard_rails}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitGuard_rails(A2LParser.Guard_railsContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#header}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitHeader(A2LParser.HeaderContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#identification}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIdentification(A2LParser.IdentificationContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#if_data}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIf_data(A2LParser.If_dataContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#include}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitInclude(A2LParser.IncludeContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#in_measurement}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIn_measurement(A2LParser.In_measurementContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#layout}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitLayout(A2LParser.LayoutContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#left_shift}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitLeft_shift(A2LParser.Left_shiftContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#loc_measurement}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitLoc_measurement(A2LParser.Loc_measurementContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#map_list}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMap_list(A2LParser.Map_listContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#matrix_dim}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMatrix_dim(A2LParser.Matrix_dimContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#max_grad}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMax_grad(A2LParser.Max_gradContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#max_refresh}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMax_refresh(A2LParser.Max_refreshContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#measurement}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMeasurement(A2LParser.MeasurementContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#measurement_optional}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMeasurement_optional(A2LParser.Measurement_optionalContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#memory_layout}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMemory_layout(A2LParser.Memory_layoutContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#memory_segment}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMemory_segment(A2LParser.Memory_segmentContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#mod_common}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMod_common(A2LParser.Mod_commonContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#mod_common_optional}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMod_common_optional(A2LParser.Mod_common_optionalContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#mod_par}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMod_par(A2LParser.Mod_parContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#mod_par_optional}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMod_par_optional(A2LParser.Mod_par_optionalContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#module}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitModule(A2LParser.ModuleContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#monotony}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMonotony(A2LParser.MonotonyContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#no_axis_pts_x}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNo_axis_pts_x(A2LParser.No_axis_pts_xContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#no_axis_pts_y}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNo_axis_pts_y(A2LParser.No_axis_pts_yContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#no_axis_pts_z}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNo_axis_pts_z(A2LParser.No_axis_pts_zContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#no_axis_pts_4}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNo_axis_pts_4(A2LParser.No_axis_pts_4Context ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#no_axis_pts_5}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNo_axis_pts_5(A2LParser.No_axis_pts_5Context ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#no_of_A2LNUMerfaces}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNo_of_A2LNUMerfaces(A2LParser.No_of_A2LNUMerfacesContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#no_rescale_x}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNo_rescale_x(A2LParser.No_rescale_xContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#number}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNumber(A2LParser.NumberContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#offset_x}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitOffset_x(A2LParser.Offset_xContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#offset_y}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitOffset_y(A2LParser.Offset_yContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#offset_z}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitOffset_z(A2LParser.Offset_zContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#offset_4}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitOffset_4(A2LParser.Offset_4Context ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#offset_5}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitOffset_5(A2LParser.Offset_5Context ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#out_measurement}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitOut_measurement(A2LParser.Out_measurementContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#phone_no}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPhone_no(A2LParser.Phone_noContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#phys_unit}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPhys_unit(A2LParser.Phys_unitContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#project}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitProject(A2LParser.ProjectContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#project_no}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitProject_no(A2LParser.Project_noContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#read_only}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRead_only(A2LParser.Read_onlyContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#read_write}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRead_write(A2LParser.Read_writeContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#record_layout}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRecord_layout(A2LParser.Record_layoutContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#record_layout_optional}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRecord_layout_optional(A2LParser.Record_layout_optionalContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#ref_characteristic}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRef_characteristic(A2LParser.Ref_characteristicContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#ref_group}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRef_group(A2LParser.Ref_groupContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#ref_measurement}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRef_measurement(A2LParser.Ref_measurementContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#ref_memory_segment}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRef_memory_segment(A2LParser.Ref_memory_segmentContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#ref_unit}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRef_unit(A2LParser.Ref_unitContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#reserved}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitReserved(A2LParser.ReservedContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#right_shift}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRight_shift(A2LParser.Right_shiftContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#rip_addr_w}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRip_addr_w(A2LParser.Rip_addr_wContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#rip_addr_x}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRip_addr_x(A2LParser.Rip_addr_xContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#rip_addr_y}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRip_addr_y(A2LParser.Rip_addr_yContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#rip_addr_z}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRip_addr_z(A2LParser.Rip_addr_zContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#rip_addr_4}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRip_addr_4(A2LParser.Rip_addr_4Context ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#rip_addr_5}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRip_addr_5(A2LParser.Rip_addr_5Context ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#root}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRoot(A2LParser.RootContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#shift_op_x}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitShift_op_x(A2LParser.Shift_op_xContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#shift_op_y}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitShift_op_y(A2LParser.Shift_op_yContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#shift_op_z}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitShift_op_z(A2LParser.Shift_op_zContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#shift_op_4}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitShift_op_4(A2LParser.Shift_op_4Context ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#shift_op_5}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitShift_op_5(A2LParser.Shift_op_5Context ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#sign_extend}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSign_extend(A2LParser.Sign_extendContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#si_exponents}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSi_exponents(A2LParser.Si_exponentsContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#src_addr_x}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSrc_addr_x(A2LParser.Src_addr_xContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#src_addr_y}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSrc_addr_y(A2LParser.Src_addr_yContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#src_addr_z}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSrc_addr_z(A2LParser.Src_addr_zContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#src_addr_4}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSrc_addr_4(A2LParser.Src_addr_4Context ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#src_addr_5}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSrc_addr_5(A2LParser.Src_addr_5Context ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#static_record_layout}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitStatic_record_layout(A2LParser.Static_record_layoutContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#status_string_ref}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitStatus_string_ref(A2LParser.Status_string_refContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#step_size}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitStep_size(A2LParser.Step_sizeContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#sub_function}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSub_function(A2LParser.Sub_functionContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#sub_group}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSub_group(A2LParser.Sub_groupContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#supplier}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSupplier(A2LParser.SupplierContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#symbol_link}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSymbol_link(A2LParser.Symbol_linkContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#system_constant}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSystem_constant(A2LParser.System_constantContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#unit}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUnit(A2LParser.UnitContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#unit_optional}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUnit_optional(A2LParser.Unit_optionalContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#unit_conversion}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUnit_conversion(A2LParser.Unit_conversionContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#user}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUser(A2LParser.UserContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#user_rights}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUser_rights(A2LParser.User_rightsContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#var_address}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitVar_address(A2LParser.Var_addressContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#var_characteristic}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitVar_characteristic(A2LParser.Var_characteristicContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#var_criterion}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitVar_criterion(A2LParser.Var_criterionContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#var_forbidden_comb}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitVar_forbidden_comb(A2LParser.Var_forbidden_combContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#var_measurement}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitVar_measurement(A2LParser.Var_measurementContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#var_naming}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitVar_naming(A2LParser.Var_namingContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#var_selection_characteristic}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitVar_selection_characteristic(A2LParser.Var_selection_characteristicContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#var_separator}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitVar_separator(A2LParser.Var_separatorContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#variant_coding}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitVariant_coding(A2LParser.Variant_codingContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#variant_coding_optional}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitVariant_coding_optional(A2LParser.Variant_coding_optionalContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#version}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitVersion(A2LParser.VersionContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#virtual}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitVirtual(A2LParser.VirtualContext ctx);
	/**
	 * Visit a parse tree produced by {@link A2LParser#virtual_characteristic}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitVirtual_characteristic(A2LParser.Virtual_characteristicContext ctx);
}
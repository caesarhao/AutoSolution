grammar A2L;
import AML;


a2l 
	:	(asap2_ver|a2ml_ver)*? 
		project
	;

a2ml_ver
	:	'A2ML_VERSION' VersionNo=UInt UpgradeNo=UInt
	;

addr_epk
	:	'ADDR_EPK'	Address=ULong
	;

alignment_byte
	:	'ALIGNMENT_BYTE'	AlignmentBorder=UInt
	;

alignment_float32_ieee
	:	'ALIGNMENT_FLOAT32_IEEE'	AlignmentBorder=UInt
	;

alignment_float64_ieee
	:	'ALIGNMENT_FLOAT64_IEEE'	AlignmentBorder=UInt
	;

alignment_int64
	:	'ALIGNMENT_INT64'	AlignmentBorder=UInt
	;

alignment_long
	:	'ALIGNMENT_LONG'	AlignmentBorder=UInt
	;

alignment_word
	:	'ALIGNMENT_WORD'	AlignmentBorder=UInt
	;

annotation
	:	Begin 'ANNOTATION'
			annotation_label?
			annotation_origin?
			annotation_text?
		End 'ANNOTATION'
	;

annotation_label
	:	'ANNOTATION_LABEL'	Title=String
	;

annotation_origin
	:	'ANNOTATION_ORIGIN'	Creator=String
	;

annotation_text
	:	Begin 'ANNOTATION_TEXT'
			String*
		End	'ANNOTATION_TEXT'
	;

array_size
	:	'ARRARY_SIZE'	UInt
	;

asap2_ver
	:	'ASAP2_VERSION' VersionNo=UInt UpgradeNo=UInt
	;
	
axis_descr
	:	Begin 'AXIS_DESCR'
			Attribute=AXIS_DESCR_ATTRIBUTE
			InputQuantity=Ident
			Conversion=Ident
			MaxAxisPoints=UInt
			LowerLimit=Float
			UpperLimit=Float
			annotation*
			axis_pts_ref?
			byte_order?
			curve_axis_ref?
			deposit?
			extended_limits?
			fix_axis_par?
			fix_axis_par_dist?
			fix_axis_par_list?
			phormat?
			max_grad?
			monotony?
			phys_unit?
			read_only?
			step_size?
		End	'AXIS_DESCR'
	;

AXIS_DESCR_ATTRIBUTE
	:	'CURVE_AXIS'
	|	'COM_AXIS'
	|	'FIX_AXIS'
	|	'RES_AXIS'
	|	'STD_AXIS'
	;

axis_pts
	:	Begin 'AXIS_PTS' Name=Ident
			LongIdentifier=String
			Address=HexNum
			InputQuantity=Ident
			Deposit=Ident
			MaxDiff=Float
			Conversion=Ident
			MaxAxisPoints=UInt
			LowerLimit=Float
			UpperLimit=Float
			axis_pts_optional*
		End 'AXIS_PTS'
	;

axis_pts_optional
	:	annotation
	|	byte_order
	|	calibration_access
	|	deposit
	|	display_identifier
	|	ecu_address_extension
	|	extended_limits
	|	phormat
	|	function_list
	|	guard_rails
	|	if_data
	|	monotony
	|	phys_unit
	|	read_only
	|	ref_memory_segment
	|	step_size
	|	symbol_link
	;

axis_pts_ref
	:	'AXIS_PTS_REF'	AxisPoints=Ident
	;

axis_pts_x
	:	'AXIS_PTS_X'	Position=UInt
					DataType=DATATYPE
	;

axis_pts_y
	:	'AXIS_PTS_Y'	Position=UInt
					DataType=DATATYPE
	;

axis_pts_z
	:	'AXIS_PTS_Z'	Position=UInt
					DataType=DATATYPE
	;

axis_pts_4
	:	'AXIS_PTS_4'	Position=UInt
					DataType=DATATYPE
	;

axis_pts_5
	:	'AXIS_PTS_5'	Position=UInt
					DataType=DATATYPE
	;

axis_rescale_x
	:	'AXIS_RESCALE_X'	Position=UInt
					DataType=DATATYPE
					MaxNumberOfRescalePairs=UInt
					IndexIncr=('INDEX_INCR'|'INDEX_DECR')
					Addressing=ADDRTYPE
	;

bit_mask
	:	'BIT_MASK'	Mask=UInt64
	;

bit_operation
	:	Begin 'BIT_OPERATION'
			left_shift?
			right_shift?
			sign_extend?
		End 'BIT_OPERATION'
	;

byte_order
	:	'BYTE_ORDER' ByteOrder=BYTEORDER
	;

calibration_access
	:	'CALIBRATION_ACCESS' AccessType=CALIBRATION_ACCESS_TYPE
	;

CALIBRATION_ACCESS_TYPE
	:	'CALIBRATION'
	|	'NO_CALIBRATION'
	|	'NOT_IN_MCD_SYSTEM'
	|	'OFFLINE_CALIBRATION'
	;

calibration_handle
	:	Begin 'CALIBRATION_HANDLE'	Long*
			calibration_handle_text?
		End 'CALIBRATION_HANDLE'
	;

calibration_handle_text
	:	'CALIBRATION_HANDLE_TEXT'	Text=String
	;

calibration_method
	:	Begin 'CALIBRATION_METHOD'
			Method=String
			Version=ULong
			calibration_handle?
		End 'CALIBRATION_METHOD'
	;

characteristic
	:	Begin 'CHARACTERISTIC' Name=Ident
			LongIdentifier=String
			Type=CHARACTERISTIC_TYPE
			Address=ULong
			Deposit=Ident
			MaxDiff=Float
			Conversion=Ident
			LowerLimit=Float
			UpperLimit=Float
			characteristic_optional*
			
		End 'CHARACTERISTIC'
	;

characteristic_optional
	:	annotation
	|	axis_descr
	|	bit_mask
	|	byte_order
	|	calibration_access
	|	comparison_quantity
	|	dependent_characteristic
	|	discrete
	|	display_identifier
	|	ecu_address_extension
	|	extended_limits
	|	phormat
	|	function_list
	|	guard_rails
	|	if_data
	|	map_list
	|	matrix_dim
	|	max_refresh
	|	number
	|	phys_unit
	|	read_only
	|	ref_memory_segment
	|	step_size
	|	symbol_link
	|	virtual_characteristic
	;

CHARACTERISTIC_TYPE
	:	'ASCII'
	|	'CURVE'
	|	'MAP'
	|	'CUBOID'
	|	'CUBE_4'
	|	'CUBE_5'
	|	'VAL_BLK'
	|	'VALUE'
	;

coeffs	// f(x) = (axx + bx + c) / (dxx + ex + f)
	:	'COEFFS'	a=Float b=Float c=Float d=Float e=Float f=Float
	;

coeffs_linear // 
	:	'COEFFS'	a=Float b=Float
	;

comparison_quantity
	:	'COMPARISON_QUANTITY'	Name=Ident
	;

compu_method
	:	Begin 'COMPU_METHOD'
			Name = Ident
			LongIdentifier=String
			ConversionType=COMPU_METHOD_CONVERSION_TYPE
			Format=FormatString
			Unit=String
			compu_method_optional*
		End 'COMPU_METHOD'
	;

compu_method_optional
	:	coeffs
	|	coeffs_linear
	|	compu_tab_ref
	|	formula
	|	ref_unit
	|	status_string_ref
	;

COMPU_METHOD_CONVERSION_TYPE
	:	'IDENTICAL'
	|	'FORM'
	|	'LINEAR'
	|	'RAT_FUNC'
	|	'TAB_INTP'
	|	'TAB_NOINTP'
	|	'TAB_VERB'
	;

compu_tab
	:	Begin 'COMPU_TAB'	Name=Ident
			LongIdentifier=String
			ConversionType=('TAB_INTP'|'TAB_NOINTP')
			NumberValuePairs=UInt
			(Float Float)*
			compu_tab_optional*
		End 'COMPU_TAB'
	;


compu_tab_optional
	:	default_value
	|	default_value_numeric
	;

compu_tab_ref
	:	'COMPU_TAB_REF'	ConversionTable=Ident
	;

compu_vtab
	:	Begin 'COMPU_VTAB' Name=Ident
			LongIdentifier=String
			ConversionType='TAB_VERB'
			NumberValuePairs=UInt
			(Float String)*
			default_value?
		End 'COMPU_VTAB'
	;


compu_vtab_range
	:	Begin 'COMPU_VTAB_RANGE' Name=Ident
			LongIdentifier=String
			NumberValueTriples=UInt
			(Float Float String)*
			default_value?
		End 'COMPU_VTAB_RANGE'
	;

cpu_type
	:	'CPU_TYPE'	CPU=String
	;

curve_axis_ref
	:	'CURVE_AXIS_REF'	CurveAxis=Ident
	;

customer
	:	'CUSTOMER'	Customer=String
	;

customer_no
	:	'CUSTOMER_NO'	CustomerNumber=String
	;

data_size
	:	'DATA_SIZE'	Size=UInt
	;

def_characteristic
	:	Begin 'DEF_CHARACTERISTIC'
			Ident*
		End 'DEF_CHARACTERISTIC'
	;

default_value
	:	'DEFAULT_VALUE'	String
	;

default_value_numeric
	:	'DEFAULT_VALUE_NUMERIC'	Float
	;

dependent_characteristic
	:	Begin 'DEPENDENT_CHARACTERISTIC' Formula=String
			Characteristics=Ident*
		End 'DEPENDENT_CHARACTERISTIC'
	;

deposit
	:	'DEPOSIT'	('ABSOLUTE'|'DIFFERENCE')
	;

discrete
	:	'DISCRETE'
	;

display_identifier
	:	'DISPLAY_IDENTIFIER'	DisplayName=Ident
	;

dist_op_x
	:	'DIST_OP_X'	Position=UInt
					DataType=DATATYPE
	;

dist_op_y
	:	'DIST_OP_Y'	Position=UInt
					DataType=DATATYPE
	;

dist_op_z
	:	'DIST_OP_Z'	Position=UInt
					DataType=DATATYPE
	;

dist_op_4
	:	'DIST_OP_4'	Position=UInt
					DataType=DATATYPE
	;

dist_op_5
	:	'DIST_OP_5'	Position=UInt
					DataType=DATATYPE
	;

ecu
	:	'ECU'	ControlUnit=String
	;

ecu_address
	:	'ECU_ADDRESS'	Address=ULong
	;

ecu_address_extension
	:	'ECU_ADDRESS_EXTENSION'	Extension=Int
	;

ecu_calibration_offset
	:	'ECU_CALIBRATION_OFFSET'	Offset=Long
	;

epk
	:	'EPK'	Identifier=String
	;

error_mask
	:	'ERROR_MASK'	Mask=UInt64
	;

extended_limits
	:	'EXTENDED_LIMITS'	LowerLimit=Float
							UpperLimit=Float
	;

fix_axis_par
	:	'FIX_AXIS_PAR'	Offset=Float
						Shift=Float
						Numberapo=UInt
	;

fix_axis_par_dist
	:	'FIX_AXIS_PAR_DIST'	Offset=Float
							Distance=Float
							Numberapo=UInt
	;

fix_axis_par_list
	:	Begin 'FIX_AXIS_PAR_LIST'
			AxisPts_Values=Float*
		End 'FIX_AXIS_PAR_LIST'
	;

fix_no_axis_pts_x
	:	'FIX_NO_AXIS_PTS_X'	NumberOfAxisPoints=UInt
	;

fix_no_axis_pts_y
	:	'FIX_NO_AXIS_PTS_Y'	NumberOfAxisPoints=UInt
	;

fix_no_axis_pts_z
	:	'FIX_NO_AXIS_PTS_Z'	NumberOfAxisPoints=UInt
	;

fix_no_axis_pts_4
	:	'FIX_NO_AXIS_PTS_4'	NumberOfAxisPoints=UInt
	;

fix_no_axis_pts_5
	:	'FIX_NO_AXIS_PTS_5'	NumberOfAxisPoints=UInt
	;

fnc_values
	:	'FNC_VALUES'	Position=UInt
						DataType=DATATYPE
						IndexMode=('ALTERNATE_CURVES'
						|'ALTERNATE_WITH_X'
						|'ALTERNATE_WITH_Y'
						|'COLUMN_DIR'
						|'ROW_DIR')
						AddressType=ADDRTYPE
	;

phormat
	:	'FORMAT'	FormatString
	;

formula
	:	Begin 'FORMULA'	Fx=String
			formula_inv?
		End 'FORMULA'
	;

formula_inv
	: 'FORMULA_INV'	Gx=String
	;

frame
	:	Begin 'FRAME' Name=Ident
			LongIdentifier=String
			ScalingUnit=UInt
			Rate=ULong
			frame_measurement?
			if_data*
		End 'FRAME'
	;

frame_measurement
	:	'FRAME_MEASUREMENT' Ident*
	;

function
	:	Begin 'FUNCTION' Name=Ident
			LongIdentifier=Ident
			function_optional*
		End 'FUNCTION'
	;

function_optional
	:	annotation
	|	def_characteristic
	|	function_version
	|	if_data
	|	in_measurement
	|	loc_measurement
	|	out_measurement
	|	ref_characteristic
	|	sub_function
	;

function_list
	:	Begin 'FUNCTION_LIST'	Name=Ident
		End 'FUNCTION_LIST'
	;

function_version
	:	'FUNCTION_VERSION'	VersionIdentifier=String
	;

group
	:	Begin 'GROUP'	GroupName=Ident
			GroupLongIdentifier=String
			group_optional*
		End 'GROUP'
	;

group_optional
	:	annotation
	|	function_list
	|	if_data
	|	ref_characteristic
	|	ref_measurement
	|	root
	|	sub_group
	;

guard_rails
	:	'GUARD_RAILS'
	;

header
	:	Begin 'HEADER' Comment=String 
			('VERSION' String)?
			('PROJECT_NO' Ident)?
		End 'HEADER'
	;

identification
	:	'IDENTIFICATION'	Position=UInt
							DataType=DATATYPE
	;

if_data
	:	Begin 'IF_DATA'	Name=Ident
			.*?
		End 'IF_DATA'
	;

include
	:	'/include' Ident
	;

in_measurement
	:	Begin 'IN_MEASUREMENT'
			Ident*
		End 'IN_MEASUREMENT'
	;

layout
	:	'LAYOUT'	IndexMode=('ROW_DIR'|'COLUMN_DIR')
	;

left_shift
	:	'LEFT_SHIFT' Bitcount=ULong 
	;

loc_measurement
	:	Begin 'LOC_MEASUREMENT'
			Ident*
		End 'LOC_MEASUREMENT'
	;

map_list
	:	Begin 'MAP_LIST'
			Ident*
		End 'MAP_LIST'
	;

matrix_dim
	:	'MATRIX_DIM'	xDim=UInt
						yDim=UInt
						zDim=UInt
	;

max_grad
	:	'MAX_GRAD' MaxGradient=Float
	;

max_refresh
	:	'MAX_REFRESH' ScalingUnit=UInt
						Rate=ULong
	;

measurement
	:	Begin 'MEASUREMENT' Name=Ident
			LongIdentifier=String
			Datatype=DATATYPE
			Conversion=Ident
			Resolution=UInt
			Accuracy=Float
			LowerLimit=Float
			UpperLimit=Float
			measurement_optional*
			
		End 'MEASUREMENT'
	;
	
measurement_optional
	:	annotation
	|	array_size
	|	bit_mask
	|	bit_operation
	|	byte_order
	|	discrete
	|	display_identifier
	|	ecu_address
	|	ecu_address_extension
	|	error_mask
	|	phormat
	|	function_list
	|	if_data
	|	layout
	|	matrix_dim
	|	max_refresh
	|	phys_unit
	|	read_write
	|	ref_memory_segment
	|	symbol_link
	|	virtual
	;

memory_layout
	:	Begin 'MEMORY_LAYOUT'
			PrgType=('PRG_CODE'
			|'PRG_DATA'
			|'PRG_RESERVED')
			Address=ULong
			Size=ULong
			Offset=Long+
			if_data*
		End 'MEMORY_LAYOUT'
	;

memory_segment
	:	Begin 'MEMORY_SEGMENT'	Name=Ident
			LongIdentifier=String
			PrgType=('CALIBRATION_VARIABLES'
			|'CODE'
			|'DATA'
			|'EXCLUDE_FROM_FLASH'
			|'OFFLINE_DATA'
			|'RESERVED'
			|'SERAM'
			|'VARIABLES')
			MemoryType=('EEPROM'
			|'EPROM'
			|'FLASH'
			|'RAM'
			|'ROM'
			|'REGISTER')
			Attribute=('INTERN'
			|'EXTERN')
			Address=ULong
			Size=ULong
			Long Long Long Long Long
			if_data*
		End 'MEMORY_SEGMENT'
	;

mod_common
	:	Begin 'MOD_COMMON'	Comment=String
			mod_common_optional*
		End 'MOD_COMMON'
	;

mod_common_optional
	:	alignment_byte
	|	alignment_float32_ieee
	|	alignment_float64_ieee
	|	alignment_int64
	|	alignment_long
	|	alignment_word
	|	byte_order
	|	data_size
	|	deposit
	;

mod_par
	:	Begin 'MOD_PAR'	Comment=String
			mod_par_optional*
		End 'MOD_PAR'
	;

mod_par_optional
	:	addr_epk
	|	calibration_method
	|	cpu_type
	|	customer
	|	customer_no
	|	ecu
	|	ecu_calibration_offset
	|	epk
	|	memory_layout
	|	memory_segment
	|	no_of_interfaces
	|	phone_no
	|	supplier
	|	system_constant
	|	user
	|	version
	;

module
	:	Begin 'MODULE'	Name=Ident
			LongIdentifier = String
			a2ml?
			(axis_pts|characteristic|compu_method
				|compu_tab|compu_vtab|compu_vtab_range
				|frame|function|group|if_data|measurement
				|record_layout|unit|user_rights
				|mod_common|mod_par|variant_coding)*
			
		End 'MODULE'
	;

monotony
	:	'MONOTONY'	Monotony=('MON_DECREASE'|'MON_INCREASE'|'STRICT_DECREASE'|'STRICT_INCREASE'|'MONOTONOUS'|'STRICT_MON'|'NOT_MON')
	;

no_axis_pts_x
	:	'NO_AXIS_PTS_X'	Position=UInt
						DataType=DATATYPE
	;

no_axis_pts_y
	:	'NO_AXIS_PTS_Y'	Position=UInt
						DataType=DATATYPE
	;

no_axis_pts_z
	:	'NO_AXIS_PTS_Z'	Position=UInt
						DataType=DATATYPE
	;

no_axis_pts_4
	:	'NO_AXIS_PTS_4'	Position=UInt
						DataType=DATATYPE
	;

no_axis_pts_5
	:	'NO_AXIS_PTS_5'	Position=UInt
						DataType=DATATYPE
	;

no_of_interfaces
	:	'NO_OF_INTERFACES'	Num=UInt
	;

no_rescale_x
	:	'NO_RESCALE_X'	Position=UInt
						DataType=DATATYPE
	;

number
	:	'NUMBER'	Number=UInt
	;

offset_x
	:	'OFFSET_X'	Position=UInt
						DataType=DATATYPE
	;

offset_y
	:	'OFFSET_Y'	Position=UInt
						DataType=DATATYPE
	;

offset_z
	:	'OFFSET_Z'	Position=UInt
						DataType=DATATYPE
	;

offset_4
	:	'OFFSET_4'	Position=UInt
						DataType=DATATYPE
	;

offset_5
	:	'OFFSET_5'	Position=UInt
						DataType=DATATYPE
	;

out_measurement
	:	Begin 'OUT_MEASUREMENT'
			Ident*
		End 'OUT_MEASUREMENT'
	;

phone_no
	: 'PHONE_NO'	Telnum=String
	;

phys_unit
	:	'PHYS_UNIT'	Unit=String
	;

project
	:	Begin 'PROJECT' Name=Ident
			LongIdentifier=String 
			header?
			include* 
			module*
		End 'PROJECT'
	;

project_no
	:	'PROJECT_NO' ProjectNumber=Ident
	;

read_only
	:	'READ_ONLY'
	;

read_write
	:	'READ_WRITE'
	;

record_layout
	:	Begin 'RECORD_LAYOUT' Name=Ident
			record_layout_optional*
		End 'RECORD_LAYOUT'
	;

record_layout_optional
	:	alignment_byte
	|	alignment_float32_ieee
	|	alignment_float64_ieee
	|	alignment_int64
	|	alignment_long
	|	alignment_word
	|	axis_pts_x
	|	axis_pts_y
	|	axis_pts_z
	|	axis_pts_4
	|	axis_pts_5
	|	axis_rescale_x
	|	dist_op_x
	|	dist_op_y
	|	dist_op_z
	|	dist_op_4
	|	dist_op_5
	|	fix_no_axis_pts_x
	|	fix_no_axis_pts_y
	|	fix_no_axis_pts_z
	|	fix_no_axis_pts_4
	|	fix_no_axis_pts_5
	|	fnc_values
	|	identification
	|	no_axis_pts_x
	|	no_axis_pts_y
	|	no_axis_pts_z
	|	no_axis_pts_4
	|	no_axis_pts_5
	|	no_rescale_x
	|	offset_x
	|	offset_y
	|	offset_z
	|	offset_4
	|	offset_5
	|	reserved
	|	rip_addr_w
	|	rip_addr_x
	|	rip_addr_y
	|	rip_addr_z
	|	rip_addr_4
	|	rip_addr_5
	|	src_addr_x
	|	src_addr_y
	|	src_addr_z
	|	src_addr_4
	|	src_addr_5
	|	shift_op_x
	|	shift_op_y
	|	shift_op_z
	|	shift_op_4
	|	shift_op_5
	|	static_record_layout
	;

ref_characteristic
	:	Begin 'REF_CHARACTERISTIC'	Ident*
		End 'REF_CHARACTERISTIC'
	;

ref_group
	:	Begin 'REF_GROUP'	Ident*
		End 'REF_GROUP'
	;

ref_measurement
	:	Begin 'REF_MEASUREMENT'	Ident*
	;

ref_memory_segment
	:	'REF_MEMORY_SEGMENT'	Name=Ident
	;

ref_unit
	:	'REF_UNIT'	Unit=Ident
	;

reserved
	:	'RESERVED'	Position=UInt
					DataSize=DATASIZE
	;

right_shift
	:	'RIGHT_SHIFT'	Bitcount=ULong
	;

rip_addr_w
	:	'RIP_ADDR_W'	Position=UInt
						DataType=DATATYPE
	;

rip_addr_x
	:	'RIP_ADDR_X'	Position=UInt
						DataType=DATATYPE
	;

rip_addr_y
	:	'RIP_ADDR_Y'	Position=UInt
						DataType=DATATYPE
	;

rip_addr_z
	:	'RIP_ADDR_Z'	Position=UInt
						DataType=DATATYPE
	;

rip_addr_4
	:	'RIP_ADDR_4'	Position=UInt
						DataType=DATATYPE
	;

rip_addr_5
	:	'RIP_ADDR_5'	Position=UInt
						DataType=DATATYPE
	;

root
	:	'ROOT'
	;

shift_op_x
	:	'SHIFT_OP_X'	Position=UInt
						DataType=DATATYPE
	;

shift_op_y
	:	'SHIFT_OP_Y'	Position=UInt
						DataType=DATATYPE
	;

shift_op_z
	:	'SHIFT_OP_Z'	Position=UInt
						DataType=DATATYPE
	;

shift_op_4
	:	'SHIFT_OP_4'	Position=UInt
						DataType=DATATYPE
	;

shift_op_5
	:	'SHIFT_OP_5'	Position=UInt
						DataType=DATATYPE
	;

sign_extend
	:	'SIGN_EXTEND'
	;

si_exponents
	:	Length=Int Mass=Int Time=Int ElectricCurrent=Int
		Temperature=Int AmountOfSubstance=Int LuminousIntensity=Int
	;

src_addr_x
	:	'SRC_ADDR_X'	Position=UInt
					DataType=DATATYPE
	;

src_addr_y
	:	'SRC_ADDR_Y'	Position=UInt
					DataType=DATATYPE
	;

src_addr_z
	:	'SRC_ADDR_Z'	Position=UInt
					DataType=DATATYPE
	;

src_addr_4
	:	'SRC_ADDR_4'	Position=UInt
					DataType=DATATYPE
	;

src_addr_5
	:	'SRC_ADDR_5'	Position=UInt
					DataType=DATATYPE
	;

static_record_layout
	:	'STATIC_RECORD_LAYOUT'
	;

status_string_ref
	:	'STATUS_STRING_REF'	ConversionTable=Ident
	;

step_size
	:	'STEP_SIZE'	StepSize=Float
	;

sub_function
	:	Begin 'SUB_FUNCTION'	Ident*
		End 'SUB_FUNCTION'
	;

sub_group
	:	Begin 'SUB_GROUP'	Ident*
		End 'SUB_GROUP'
	;

supplier
	:	'SUPPLIER'	Manufacturer=String
	;

symbol_link
	:	'SYMBOL_LINK'	SymbolName=String
						Offset=Long
	;

system_constant
	:	'SYSTEM_CONSTANT'	Name=String Value=String
	;

unit
	:	Begin 'UNIT'	Name=Ident
			LongIdentifier=String
			Display=String
			Type=('DERIVED'|'EXTENDED_SI')
			unit_optional*
		End 'UNIT'
	;

unit_optional
	:	ref_unit
	|	si_exponents
	|	unit_conversion
	;

unit_conversion
	:	'UNIT_CONVERSION'	Gradient=Float Offset=Float
	;

user
	:	'USER'	UserName=String
	;

user_rights
	:	Begin 'USER_RIGHTS'	UserLevelId=Ident
			read_only?
			ref_group*
		End 'USER_RIGHTS'
	;

var_address
	:	Begin 'VAR_ADDRESS'	ULong*
		End 'VAR_ADDRESS'
	;

var_characteristic
	:	Begin 'VAR_CHARACTERISTIC'	Name=Ident
			CriterionNames=Ident*
			var_address?
		End	'VAR_CHARACTERISTIC'
	;

var_criterion
	:	Begin 'VAR_CRITERION'	Name=Ident
			LongIdentifier=String
			Values=Ident*
			var_measurement?
			var_selection_characteristic?
		End 'VAR_CRITERION'
	;

var_forbidden_comb
	:	Begin 'VAR_FORBIDDEN_COMB'
			(CriterionName=Ident CriterionValue=Ident)*
		End 'VAR_FORBIDDEN_COMB'
	;

var_measurement
	:	'VAR_MEASUREMENT'	Name=Ident
	;

var_naming
	:	'VAR_NAMING'	Tag=('NUMERIC'|'ALPHA')
	;

var_selection_characteristic
	:	'VAR_SELECTION_CHARACTERISTIC'	Name=Ident
	;

var_separator
	:	'VAR_SEPARATOR'	Name=Ident
	;

variant_coding
	:	Begin 'VARIANT_CODING'
			variant_coding_optional*
		End 'VARIANT_CODING'
	;

variant_coding_optional
	:	var_characteristic
	|	var_criterion
	|	var_forbidden_comb
	|	var_naming
	|	var_separator
	;

version
	:	'VERSION'	VersionIdentifier=String
	;

virtual
	:	Begin 'VIRTUAL'	MeasuringChannels=Ident*
		End 'VIRTUAL'
	;

virtual_characteristic
	:	Begin 'VIRTUAL_CHARACTERISTIC'	Formula=String
			Characteristics=Ident*
		End 'VIRTUAL_CHARACTERISTIC'
	;


 
UInt	// 2-byte unsigned integer
	:	HexNum
	|	DigitNum
	;

Int		// 2-byte signed integer
    :	HexNum
	|	'-'?DigitNum
   ;

UInt64	// 8-byte unsigned integer
	:	HexNum
	|	DigitNum	
	;

Long	// 4-byte signed integer
	:	HexNum
	|	'-'?DigitNum
	;

ULong	// 4-byte unsigned integer
	:	HexNum
	|	DigitNum
	;

Float
	:	DigitSequence?'.'DigitSequence?(('e'|'E')('+'|'-')?DigitSequence)?
	;

HexNum
	:	HexadecimalPrefix(HexadecimalDigit)+
	;

DigitNum
	:	'0'
	|	(NonzeroDigit(Digit)*)
	;

fragment
Nondigit
    :   [a-zA-Z_]
    ;

fragment
Digit
    :   [0-9]
    ;

DigitSequence
    :   Digit+
    ;

fragment
HexadecimalPrefix
    :   '0'[xX]
    ;

fragment
NonzeroDigit
    :   [1-9]
    ;

fragment
OctalDigit
    :   [0-7]
    ;

fragment
HexadecimalDigit
    :   [0-9a-fA-F]
    ;

fragment
Letter
	:	[a-zA-Z]
	;

DATATYPE
	:	'UBYTE'
	|	'SBYTE'
	|	'UWORD'
	|	'SWORD'
	|	'ULONG'
	|	'SLONG'
	|	'A_UINT64'
	|	'A_INT64'
	|	'FLOAT32_IEEE'
	|	'FLOAT64_IEEE'
	;

DATASIZE
	:	'BYTE'
	|	'WORD'
	|	'LONG'
	;

ADDRTYPE
	:	'PBYTE'
	|	'PWORD'
	|	'PLONG'
	|	'DIRECT'
	;

BYTEORDER
	:	'LITTLE_ENDIAN'
	|	'BIG_ENDIAN'
	|	'MSB_LAST'
	|	'MSB_FIRST'
	;

INDEXORDER
	:	'INDEX_INCR'
	|	'INDEX_DECR'
	;

FormatString
	:	'"%'UInt?'.'UInt'"'
	;

Ident
	:	PartIdent('.'PartIdent)*
	;

PartIdent
	:	CIdent('['(ENUM|Index)']')?
	;

Index
	:	Digit+
	;

ENUM
	:	CIdent
	;

CIdent
	:	[a-zA-Z_][a-zA-Z0-9_]*
	;

String
	:	'"'(ESC|.)*?'"'
	;

fragment
SChar
    :   ~["\\\r\n]
    |   '\\\n'   // Added line
    |   '\\\r\n' // Added line
    ;

WS
    :   [ \t\r\n]+
        -> skip
    ;

Newline
    :   (   '\r' '\n'?
        |   '\n'
        )
        -> skip
    ;

BlockComment
    :   '/*' .*? '*/'
        -> skip
    ;

LineComment
    :   '//' .*? '\n'
        -> skip
    ;

fragment
ESC
	:	'\\' [btnr"\\]
	;

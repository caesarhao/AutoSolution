grammar A2L;

/* A2ML grammar begin */
/* The A2ML block only describes the syntax of communication parameters. */
/* The actual parameter values are given in the IF_DATA blocks. 
The values in the IF_DATA blocks must match the syntax description of the A2ML block. */
a2ml
	:	Begin 'A2ML'
			declaration_list
		End 'A2ML'
	;

declaration_list
	: 	declaration
	|	declaration declaration_list
	;

declaration
	:	type_definition  ';'
	|	block_definition ';'
	;

type_definition
	:	type_name
	;

type_name
	:	predefined_type_name
	|	struct_type_name
	|	taggedstruct_type_name
	|	taggedunion_type_name
	|	enum_type_name
	;

predefined_type_name
	:	PREDEFINED_TYPE_NAME;

block_definition
	:	'block' tag member
	|	'block' tag '(' member ')*'
	;

enum_type_name
	:	'enum' identifier? '{' enumerator_list '}'
	|	'enum' identifier
	;

enumerator_list
	:	enumerator (',' enumerator_list)?
	;

enumerator
	:	keyword ('=' constant)?
	;

struct_type_name
	:	'struct' identifier? '{' struct_member_list? '}'
	|	'struct' identifier
	;

struct_member_list
	:	struct_member struct_member_list?
	;

struct_member
	:	member ';'
	;
 
member
	:	type_name array_specifier?
	;

array_specifier
	:	'[' constant ']' array_specifier?
	;

taggedstruct_type_name
	:	'taggedstruct' identifier? '{' taggedstruct_member_list? '}'
	|	'taggedstruct' identifier
	;

taggedstruct_member_list
	:	taggedstruct_member taggedstruct_member_list?
	;

taggedstruct_member
	:	taggedstruct_definition ';'
	|	'(' taggedstruct_definition ')*;'
	|	block_definition ';' 
	|	'(' block_definition ')*;'
	;

taggedstruct_definition
	:	tag member?
	|	tag '(' member ')*;'
	;

taggedunion_type_name
	:	'taggedunion' identifier? '{' taggedunion_member_list? '}'
	|	'taggedunion' identifier
	;

taggedunion_member_list
	:	tagged_union_member taggedunion_member_list?
	;

tagged_union_member
	:	tag member? ';'
	|	block_definition ';'
	;

identifier
	: Ident
	;

tag
	:	STRING
	;

keyword
	:	STRING
	;

/* constant is really uint32 */
constant
	:	A2LNUM
	;

/* A2ML grammar end */

/* A2L grammar begin */

a2l 
	:	(asap2_ver|a2ml_ver)*? 
		project
	;

a2ml_ver
	:	'A2ML_VERSION' VersionNo=A2LNUM UpgradeNo=A2LNUM
	;

addr_epk
	:	'ADDR_EPK'	Address=A2LNUM
	;

address_type
	:	ADDRTYPE
	;

alignment_byte
	:	'ALIGNMENT_BYTE'	AlignmentBorder=A2LNUM
	;

alignment_float16_ieee
	:	'ALIGNMENT_FLOAT16_IEEE'	AlignmentBorder=A2LNUM
	;

alignment_float32_ieee
	:	'ALIGNMENT_FLOAT32_IEEE'	AlignmentBorder=A2LNUM
	;

alignment_float64_ieee
	:	'ALIGNMENT_FLOAT64_IEEE'	AlignmentBorder=A2LNUM
	;

alignment_int64
	:	'ALIGNMENT_INT64'	AlignmentBorder=A2LNUM
	;

alignment_long
	:	'ALIGNMENT_LONG'	AlignmentBorder=A2LNUM
	;

alignment_word
	:	'ALIGNMENT_WORD'	AlignmentBorder=A2LNUM
	;

annotation
	:	Begin 'ANNOTATION'
			annotation_label?
			annotation_origin?
			annotation_text?
		End 'ANNOTATION'
	;

annotation_label
	:	'ANNOTATION_LABEL'	Title=STRING
	;

annotation_origin
	:	'ANNOTATION_ORIGIN'	Creator=STRING
	;

annotation_text
	:	Begin 'ANNOTATION_TEXT'
			STRING*
		End	'ANNOTATION_TEXT'
	;

array_size
	:	'ARRAY_SIZE'	A2LNUM
	;

asap2_ver
	:	'ASAP2_VERSION' VersionNo=A2LNUM UpgradeNo=A2LNUM
	;
	
axis_descr
	:	Begin 'AXIS_DESCR'
			Attribute=AXIS_DESCR_ATTRIBUTE
			InputQuantity=Ident
			Conversion=Ident
			MaxAxisPoA2LNUMs=A2LNUM
			LowerLimit=A2LNUM
			UpperLimit=A2LNUM
				(annotation
			|	axis_pts_ref
			|	byte_order
			|	curve_axis_ref
			|	deposit
			|	extended_limits
			|	fix_axis_par
			|	fix_axis_par_dist
			|	fix_axis_par_list
			|	formate
			|	max_grad
			|	monotony
			|	phys_unit
			|	read_only
			|	step_size)*
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
			LongIdentifier=STRING
			Address=A2LNUM
			InputQuantity=Ident
			Deposit=Ident
			MaxDiff=A2LNUM
			Conversion=Ident
			MaxAxisPoA2LNUMs=A2LNUM
			LowerLimit=A2LNUM
			UpperLimit=A2LNUM
			(	annotation
			|	byte_order
			|	calibration_access
			|	deposit
			|	display_identifier
			|	ecu_address_extension
			|	extended_limits
			|	formate
			|	function_list
			|	guard_rails
			|	if_data
			|	monotony
			|	phys_unit
			|	read_only
			|	ref_memory_segment
			|	step_size
			|	symbol_link)*
		End 'AXIS_PTS'
	;

axis_pts_ref
	:	'AXIS_PTS_REF'	AxisPoA2LNUMs=Ident
	;

axis_pts_x
	:	'AXIS_PTS_X'	Position=A2LNUM
					DataType=DATATYPE
					IndexOrder=INDEXORDER
					AddrType=ADDRTYPE

	;

axis_pts_y
	:	'AXIS_PTS_Y'	Position=A2LNUM
					DataType=DATATYPE
					IndexOrder=INDEXORDER
					AddrType=ADDRTYPE
	;

axis_pts_z
	:	'AXIS_PTS_Z'	Position=A2LNUM
					DataType=DATATYPE
					IndexOrder=INDEXORDER
					AddrType=ADDRTYPE
	;

axis_pts_4
	:	'AXIS_PTS_4'	Position=A2LNUM
					DataType=DATATYPE
					IndexOrder=INDEXORDER
					AddrType=ADDRTYPE
	;

axis_pts_5
	:	'AXIS_PTS_5'	Position=A2LNUM
					DataType=DATATYPE
					IndexOrder=INDEXORDER
					AddrType=ADDRTYPE
	;

axis_rescale_x
	:	'AXIS_RESCALE_X'	Position=A2LNUM
					DataType=DATATYPE
					MaxNumberOfRescalePairs=A2LNUM
					IndexIncr=INDEXORDER
					Addressing=ADDRTYPE
	;

bit_mask
	:	'BIT_MASK'	Mask=A2LNUM
	;

bit_operation
	:	Begin 'BIT_OPERATION'
			left_shift?
			right_shift?
			sign_extend?
		End 'BIT_OPERATION'
	;

blob
	:	Begin 'BLOB' Name=Ident
			LongIdentifier=STRING
			Address=A2LNUM
			Size=A2LNUM
			(	address_type
			|	annotation
			|	calibration_access
			|	display_identifier
			|	ecu_address_extension
			|	if_data
			|	max_refresh
			|	model_link
			|	symbol_link)*
		End 'BLOB'
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
	:	Begin 'CALIBRATION_HANDLE'	A2LNUM*?
			calibration_handle_text?
		End 'CALIBRATION_HANDLE'
	;

calibration_handle_text
	:	'CALIBRATION_HANDLE_TEXT'	Text=STRING
	;

calibration_method
	:	Begin 'CALIBRATION_METHOD'
			Method=STRING
			Version=A2LNUM
			calibration_handle?
		End 'CALIBRATION_METHOD'
	;

characteristic
	:	Begin 'CHARACTERISTIC' Name=Ident
			LongIdentifier=STRING
			Type=CHARACTERISTIC_TYPE
			Address=A2LNUM
			Deposit=Ident
			MaxDiff=A2LNUM
			Conversion=Ident
			LowerLimit=A2LNUM
			UpperLimit=A2LNUM
			(	annotation
			|	axis_descr
			|	bit_mask
			|	byte_order
			|	calibration_access
			|	comparison_quantity
			|	dependent_characteristic
			|	discrete
			|	display_identifier
			|	ecu_address_extension
			|	encoding
			|	extended_limits
			|	formate
			|	function_list
			|	guard_rails
			|	if_data
			|	map_list
			|	matrix_dim
			|	max_refresh
			|	model_link
			|	number
			|	phys_unit
			|	read_only
			|	ref_memory_segment
			|	step_size
			|	symbol_link
			|	virtual_characteristic)*
			
		End 'CHARACTERISTIC'
	;

CHARACTERISTIC_TYPE
	:	'ASCII'		/* string */
	|	'CURVE' 	/* 1D-table */
	|	'MAP'		/* 2D-table */
	|	'CUBOID'	/* 3D-table */
	|	'CUBE_4'	/* 4D-table */
	|	'CUBE_5'	/* 5D-table */
	|	'VAL_BLK'	/* array (no axes) */
	|	'VALUE' 	/* scalar */
	;

coeffs	// f(x) = (axx + bx + c) / (dxx + ex + f)
	:	'COEFFS'	a=A2LNUM b=A2LNUM c=A2LNUM d=A2LNUM e=A2LNUM f=A2LNUM
	;

coeffs_linear // 
	:	'COEFFS_LINEAR'	a=A2LNUM b=A2LNUM
	;

comparison_quantity
	:	'COMPARISON_QUANTITY'	Name=Ident
	;
/* COMPU_METHODs convert this data from their fixed-point representation into a floating-point representation for display in an MC-system. */
compu_method
	:	Begin 'COMPU_METHOD'
			Name = Ident
			LongIdentifier=STRING
			ConversionType=COMPU_METHOD_CONVERSION_TYPE
			Format=Formatstring
			Unit=STRING
			(	coeffs
			|	coeffs_linear
			|	compu_tab_ref
			|	formula
			|	ref_unit
			|	status_string_ref)*
		End 'COMPU_METHOD'
	;

/* The conversion direction is from the internal format to the physical format, except for RAT_FUNC, which describes the conversion from the physical format to the internal format. */
COMPU_METHOD_CONVERSION_TYPE
	:	'IDENTICAL'		/* no conversion */
	|	'FORM'			/* formula which consists of a specific set of operators and functions */
	|	'LINEAR'		/* linear, 2-coefficient function with slope and offset */
	|	'RAT_FUNC'		/* 6-coefficient rational function with 2nd-degree numerator and denominator polynomials */
	|	'TAB_INTP'		/* table with interpolation */
	|	'TAB_NOINTP'	/* table without interpolation */
	|	'TAB_VERB'		/* verbal table (i.e. enumeration) */
	;

/* compu_tab, like enum in C */
compu_tab
	:	Begin 'COMPU_TAB'	Name=Ident
			LongIdentifier=STRING
			ConversionType=COMPU_METHOD_CONVERSION_TYPE
			NumberValuePairs=A2LNUM
			(A2LNUM A2LNUM)*?
			(	default_value
			|	default_value_numeric)*
		End 'COMPU_TAB'
	;

compu_tab_ref
	:	'COMPU_TAB_REF'	ConversionTable=Ident
	;

compu_vtab
	:	Begin 'COMPU_VTAB' Name=Ident
			LongIdentifier=STRING
			ConversionType=COMPU_METHOD_CONVERSION_TYPE
			NumberValuePairs=A2LNUM
			(A2LNUM STRING)*?
			default_value?
		End 'COMPU_VTAB'
	;


compu_vtab_range
	:	Begin 'COMPU_VTAB_RANGE' Name=Ident
			LongIdentifier=STRING
			NumberValueTriples=A2LNUM
			(A2LNUM A2LNUM STRING)*?
			default_value?
		End 'COMPU_VTAB_RANGE'
	;

consistent_exchange
	:	'TODOTODOTODOTODOTODO CONSISTENT_EXCHANGE'
	;

cpu_type
	:	'CPU_TYPE'	CPU=STRING
	;

curve_axis_ref
	:	'CURVE_AXIS_REF'	CurveAxis=Ident
	;

customer
	:	'CUSTOMER'	Customer=STRING
	;

customer_no
	:	'CUSTOMER_NO'	CustomerNumber=STRING
	;

data_size
	:	'DATA_SIZE'	Size=A2LNUM
	;

def_characteristic
	:	Begin 'DEF_CHARACTERISTIC'
			Ident*?
		End 'DEF_CHARACTERISTIC'
	;

default_value
	:	'DEFAULT_VALUE'	STRING
	;

default_value_numeric
	:	'DEFAULT_VALUE_NUMERIC'	A2LNUM
	;

dependent_characteristic
	:	Begin 'DEPENDENT_CHARACTERISTIC' Formula=STRING
			Characteristics=Ident*?
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
	:	'DIST_OP_X'	Position=A2LNUM
					DataType=DATATYPE
	;

dist_op_y
	:	'DIST_OP_Y'	Position=A2LNUM
					DataType=DATATYPE
	;

dist_op_z
	:	'DIST_OP_Z'	Position=A2LNUM
					DataType=DATATYPE
	;

dist_op_4
	:	'DIST_OP_4'	Position=A2LNUM
					DataType=DATATYPE
	;

dist_op_5
	:	'DIST_OP_5'	Position=A2LNUM
					DataType=DATATYPE
	;

ecu
	:	'ECU'	ControlUnit=STRING
	;

ecu_address
	:	'ECU_ADDRESS'	Address=A2LNUM
	;

ecu_address_extension
	:	'ECU_ADDRESS_EXTENSION'	Extension=A2LNUM
	;

ecu_calibration_offset
	:	'ECU_CALIBRATION_OFFSET'	Offset=A2LNUM
	;

encoding
	:	'ENCODING'	Encod=('UTF8'|'UTF16'|'UTF32')
	;

epk
	:	'EPK'	Identifier=STRING
	;

error_mask
	:	'ERROR_MASK'	Mask=A2LNUM
	;

extended_limits
	:	'EXTENDED_LIMITS'	LowerLimit=A2LNUM
							UpperLimit=A2LNUM
	;

fix_axis_par
	:	'FIX_AXIS_PAR'	Offset=A2LNUM
						Shift=A2LNUM
						Numberapo=A2LNUM
	;

fix_axis_par_dist
	:	'FIX_AXIS_PAR_DIST'	Offset=A2LNUM
							Distance=A2LNUM
							Numberapo=A2LNUM
	;

fix_axis_par_list
	:	Begin 'FIX_AXIS_PAR_LIST'
			AxisPts_Values=A2LNUM*
		End 'FIX_AXIS_PAR_LIST'
	;

fix_no_axis_pts_x
	:	'FIX_NO_AXIS_PTS_X'	NumberOfAxisPoA2LNUMs=A2LNUM
	;

fix_no_axis_pts_y
	:	'FIX_NO_AXIS_PTS_Y'	NumberOfAxisPoA2LNUMs=A2LNUM
	;

fix_no_axis_pts_z
	:	'FIX_NO_AXIS_PTS_Z'	NumberOfAxisPoA2LNUMs=A2LNUM
	;

fix_no_axis_pts_4
	:	'FIX_NO_AXIS_PTS_4'	NumberOfAxisPoA2LNUMs=A2LNUM
	;

fix_no_axis_pts_5
	:	'FIX_NO_AXIS_PTS_5'	NumberOfAxisPoA2LNUMs=A2LNUM
	;

fnc_values
	:	'FNC_VALUES'	Position=A2LNUM
						DataType=DATATYPE
						IndexMode=('ALTERNATE_CURVES'
						|'ALTERNATE_WITH_X'
						|'ALTERNATE_WITH_Y'
						|'COLUMN_DIR'
						|'ROW_DIR')
						AddressType=ADDRTYPE
	;

formate
	:	'FORMAT'	Formatstring
	;

formula
	:	Begin 'FORMULA'	Fx=STRING
			formula_inv?
		End 'FORMULA'
	;

formula_inv
	: 'FORMULA_INV'	Gx=STRING
	;

frame
	:	Begin 'FRAME' Name=Ident
			LongIdentifier=STRING
			ScalingUnit=A2LNUM
			Rate=A2LNUM
			frame_measurement?
			if_data*
		End 'FRAME'
	;

frame_measurement
	:	'FRAME_MEASUREMENT' Ident*?
	;

function
	:	Begin 'FUNCTION' Name=Ident
			LongIdentifier=STRING
			(	annotation
			|	def_characteristic
			|	function_version
			|	if_data
			|	in_measurement
			|	loc_measurement
			|	out_measurement
			|	ref_characteristic
			|	sub_function)*
		End 'FUNCTION'
	;


function_list
	:	Begin 'FUNCTION_LIST'	Name=Ident
		End 'FUNCTION_LIST'
	;

function_version
	:	'FUNCTION_VERSION'	VersionIdentifier=STRING
	;

group
	:	Begin 'GROUP'	GroupName=Ident
			GroupLongIdentifier=STRING
			(	annotation
			|	function_list
			|	if_data
			|	ref_characteristic
			|	ref_measurement
			|	root
			|	sub_group)*
		End 'GROUP'
	;

guard_rails
	:	'GUARD_RAILS'
	;

header
	:	Begin 'HEADER' Comment=STRING 
			('VERSION' STRING)?
			('PROJECT_NO' Ident)?
		End 'HEADER'
	;

identification
	:	'IDENTIFICATION'	Position=A2LNUM
							DataType=DATATYPE
	;
/* As a primary keyword on MODULE level, the IF_DATA section contains the parametric values for the configuration of the protocol stack.  */
/* 
if_data
	:	Begin 'IF_DATA'	Name=Ident
			.*?
		End 'IF_DATA'
	;
*/
// if_data is skipped now
if_data
	:	'qnqmofnqmehqmbgq bgmusodgqhgoqnglmqsugqb:sguq'
	;

include
	:	'/include' Ident
	;

in_measurement
	:	Begin 'IN_MEASUREMENT'
			Ident*?
		End 'IN_MEASUREMENT'
	;

instance
	:	Begin 'INSTANCE' Name=Ident
			LongIdentifier=STRING
			TypedefName=Ident
			Address=A2LNUM
			(	address_type
			|	annotation
			|	calibration_access
			|	display_identifier
			|	ecu_address_extension
			|	if_data
			|	layout
			|	matrix_dim
			|	max_refresh
			|	model_link
			|	overwrite
			|	read_write
			|	symbol_link)*
		End 'INSTANCE'
	;

layout
	:	'LAYOUT'	IndexMode=('ROW_DIR'|'COLUMN_DIR')
	;

left_shift
	:	'LEFT_SHIFT' Bitcount=A2LNUM 
	;

loc_measurement
	:	Begin 'LOC_MEASUREMENT'
			Ident*?
		End 'LOC_MEASUREMENT'
	;

map_list
	:	Begin 'MAP_LIST'
			Ident*?
		End 'MAP_LIST'
	;

matrix_dim
	:	'MATRIX_DIM'	xDim=A2LNUM
						(yDim=A2LNUM)?
						(zDim=A2LNUM)?
	;

max_grad
	:	'MAX_GRAD' MaxGradient=A2LNUM
	;

max_refresh
	:	'MAX_REFRESH' ScalingUnit=A2LNUM
						Rate=A2LNUM
	;

measurement
	:	Begin 'MEASUREMENT' Name=Ident
			LongIdentifier=STRING
			Datatype=DATATYPE
			Conversion=Ident
			Resolution=A2LNUM
			Accuracy=A2LNUM
			LowerLimit=A2LNUM
			UpperLimit=A2LNUM
			(	annotation
			|	array_size
			|	bit_mask
			|	bit_operation
			|	byte_order
			|	discrete
			|	display_identifier
			|	ecu_address
			|	ecu_address_extension
			|	error_mask
			|	formate
			|	function_list
			|	if_data
			|	layout
			|	matrix_dim
			|	max_refresh
			|	phys_unit
			|	read_write
			|	ref_memory_segment
			|	symbol_link
			|	virtual)*
			
		End 'MEASUREMENT'
	;
	
memory_layout
	:	Begin 'MEMORY_LAYOUT'
			PrgType=('PRG_CODE'
			|'PRG_DATA'
			|'PRG_RESERVED')
			Address=A2LNUM
			Size=A2LNUM
			Offset=A2LNUM+
			if_data*
		End 'MEMORY_LAYOUT'
	;

memory_segment
	:	Begin 'MEMORY_SEGMENT'	Name=Ident
			LongIdentifier=STRING
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
			|'REGISTER'
			|'NOT_IN_ECU')
			Attribute=('INTERN'
			|'EXTERN')
			Address=A2LNUM
			Size=A2LNUM
			A2LNUM A2LNUM A2LNUM A2LNUM A2LNUM
			if_data*
		End 'MEMORY_SEGMENT'
	;

/* Defines default parameters that are common for other keywords of the module, 
so they do not have to be repeated for each of them. 
They include the definition of byte alignment, byte order, size and storage of data in the ECU memory. 
The parameters of MOD_COMMON are optional parameters of other keywords. 
If they are not defined in a keyword, then the corresponding parameter value of MOD_COMMON is used. 
Otherwise, when a parameter is defined in a keyword, then it overrules the parameter value defined in MOD_COMMON. */
mod_common
	:	Begin 'MOD_COMMON'	Comment=STRING
			(	alignment_byte
			|	alignment_float16_ieee
			|	alignment_float32_ieee
			|	alignment_float64_ieee
			|	alignment_int64
			|	alignment_long
			|	alignment_word
			|	byte_order
			|	data_size
			|	deposit)*
		End 'MOD_COMMON'
	;

/* Specifies general parameters of a module (i.e. ECU). 
This includes data such as the name of the CPU, customer, version and other ECU-specific data. 
Furthermore, this keyword contains the description of the organization of the ECU's memory via the keyword MEMORY_SEGMENT 
as well as a list of system constants which can be used in conversion methods. */
mod_par
	:	Begin 'MOD_PAR'	Comment=STRING
			(	addr_epk
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
			|	version)*
		End 'MOD_PAR'
	;

model_link
	:	'MODEL_LINK'	Model=STRING
	;

module
	:	Begin 'MODULE'	Name=Ident
			LongIdentifier = STRING
			a2ml?	
			(	axis_pts
			|	blob
			|	characteristic
			|	compu_method
			|	compu_tab
			|	compu_vtab
			|	compu_vtab_range
			|	frame
			|	function
			|	group
			|	if_data
			|	instance
			|	measurement
			|	mod_common
			|	mod_par
			|	record_layout
			|	transformer
			|	typedef_axis
			|	typedef_blob
			|	typedef_characteristic
			|	typedef_measurement
			|	typedef_structure
			|	unit
			|	user_rights
			|	variant_coding)*
		End 'MODULE'
	;

monotony
	:	'MONOTONY'	Monotony=('MON_DECREASE'|'MON_INCREASE'|'STRICT_DECREASE'|'STRICT_INCREASE'|'MONOTONOUS'|'STRICT_MON'|'NOT_MON')
	;

no_axis_pts_x
	:	'NO_AXIS_PTS_X'	Position=A2LNUM
						DataType=DATATYPE
	;

no_axis_pts_y
	:	'NO_AXIS_PTS_Y'	Position=A2LNUM
						DataType=DATATYPE
	;

no_axis_pts_z
	:	'NO_AXIS_PTS_Z'	Position=A2LNUM
						DataType=DATATYPE
	;

no_axis_pts_4
	:	'NO_AXIS_PTS_4'	Position=A2LNUM
						DataType=DATATYPE
	;

no_axis_pts_5
	:	'NO_AXIS_PTS_5'	Position=A2LNUM
						DataType=DATATYPE
	;

no_of_interfaces
	:	'NO_OF_INTERFACES'	Num=A2LNUM
	;

no_rescale_x
	:	'NO_RESCALE_X'	Position=A2LNUM
						DataType=DATATYPE
	;

number
	:	'NUMBER'	Number=A2LNUM
	;

offset_x
	:	'OFFSET_X'	Position=A2LNUM
						DataType=DATATYPE
	;

offset_y
	:	'OFFSET_Y'	Position=A2LNUM
						DataType=DATATYPE
	;

offset_z
	:	'OFFSET_Z'	Position=A2LNUM
						DataType=DATATYPE
	;

offset_4
	:	'OFFSET_4'	Position=A2LNUM
						DataType=DATATYPE
	;

offset_5
	:	'OFFSET_5'	Position=A2LNUM
						DataType=DATATYPE
	;

out_measurement
	:	Begin 'OUT_MEASUREMENT'
			Ident*
		End 'OUT_MEASUREMENT'
	;

overwrite
	:	'TODOTODO overwrite'
	;

phone_no
	: 'PHONE_NO'	Telnum=STRING
	;

phys_unit
	:	'PHYS_UNIT'	Unit=STRING
	;

project
	:	Begin 'PROJECT' Name=Ident
			LongIdentifier=STRING 
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
			(	alignment_byte
			|	alignment_float16_ieee
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
			|	static_record_layout)*
		End 'RECORD_LAYOUT'
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
		End	'REF_MEASUREMENT'
	;

ref_memory_segment
	:	'REF_MEMORY_SEGMENT'	Name=Ident
	;

ref_unit
	:	'REF_UNIT'	Unit=Ident
	;

reserved
	:	'RESERVED'	Position=A2LNUM
					DataSize=DATASIZE
	;

right_shift
	:	'RIGHT_SHIFT'	Bitcount=A2LNUM
	;

rip_addr_w
	:	'RIP_ADDR_W'	Position=A2LNUM
						DataType=DATATYPE
	;

rip_addr_x
	:	'RIP_ADDR_X'	Position=A2LNUM
						DataType=DATATYPE
	;

rip_addr_y
	:	'RIP_ADDR_Y'	Position=A2LNUM
						DataType=DATATYPE
	;

rip_addr_z
	:	'RIP_ADDR_Z'	Position=A2LNUM
						DataType=DATATYPE
	;

rip_addr_4
	:	'RIP_ADDR_4'	Position=A2LNUM
						DataType=DATATYPE
	;

rip_addr_5
	:	'RIP_ADDR_5'	Position=A2LNUM
						DataType=DATATYPE
	;

root
	:	'ROOT'
	;

shift_op_x
	:	'SHIFT_OP_X'	Position=A2LNUM
						DataType=DATATYPE
	;

shift_op_y
	:	'SHIFT_OP_Y'	Position=A2LNUM
						DataType=DATATYPE
	;

shift_op_z
	:	'SHIFT_OP_Z'	Position=A2LNUM
						DataType=DATATYPE
	;

shift_op_4
	:	'SHIFT_OP_4'	Position=A2LNUM
						DataType=DATATYPE
	;

shift_op_5
	:	'SHIFT_OP_5'	Position=A2LNUM
						DataType=DATATYPE
	;

sign_extend
	:	'SIGN_EXTEND'
	;

si_exponents
	:	Length=A2LNUM Mass=A2LNUM Time=A2LNUM ElectricCurrent=A2LNUM
		Temperature=A2LNUM AmountOfSubstance=A2LNUM LuminousA2LNUMensity=A2LNUM
	;

src_addr_x
	:	'SRC_ADDR_X'	Position=A2LNUM
					DataType=DATATYPE
	;

src_addr_y
	:	'SRC_ADDR_Y'	Position=A2LNUM
					DataType=DATATYPE
	;

src_addr_z
	:	'SRC_ADDR_Z'	Position=A2LNUM
					DataType=DATATYPE
	;

src_addr_4
	:	'SRC_ADDR_4'	Position=A2LNUM
					DataType=DATATYPE
	;

src_addr_5
	:	'SRC_ADDR_5'	Position=A2LNUM
					DataType=DATATYPE
	;

static_record_layout
	:	'STATIC_RECORD_LAYOUT'
	;

status_string_ref
	:	'STATUS_STRING_REF'	ConversionTable=Ident
	;

step_size
	:	'STEP_SIZE'	StepSize=A2LNUM
	;

structure_component
	:	Begin 'STRUCTURE_COMPONENT' Name=Ident
			TypedefName=Ident
			AddressOffset=A2LNUM
			(
				address_type
			|	layout
			|	matrix_dim
			|	symbol_type_link
			)*
		End 'STRUCTURE_COMPONENT'
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
	:	'SUPPLIER'	Manufacturer=STRING
	;

symbol_link
	:	'SYMBOL_LINK'	SymbolName=STRING
						Offset=A2LNUM
	;

symbol_type_link
	:	'SYMBOL_TYPE_LINK' SymbolName=STRING
	;

system_constant
	:	'SYSTEM_CONSTANT'	Name=STRING Value=STRING
	;

transformer
	:	Begin 'TRANSFORMER' Name=Ident
			Version=STRING
			Executable32=STRING
			Executable64=STRING
			Timeout=A2LNUM
			Trigger=('ON_CHANGE'|'ON_USER_REQUEST')
			InverseTransformer=Ident
			(	transformer_in_objects
			|	transformer_out_objects)*
		End 'TRANSFORMER'
	;

transformer_in_objects
	:	Begin 'TRANSFORMER_IN_OBJECTS'
			Ident*
		End 'TRANSFORMER_IN_OBJECTS'
	;

transformer_out_objects
	:	Begin 'TRANSFORMER_OUT_OBJECTS'
			Ident*
		End 'TRANSFORMER_OUT_OBJECTS'
	;

typedef_axis
	:	Begin 'TYPEDEF_AXIS' Name=Ident
			LongIdentifier=STRING
			InputQuantity=Ident
			RecordLayout=Ident
			MaxDiff=A2LNUM
			Conversion=Ident
			MaxAxisPoints=A2LNUM
			LowerLimit=A2LNUM
			UpperLimit=A2LNUM
			(	byte_order
			|	deposit
			|	extended_limits
			|	formate
			|	monotony
			|	phys_unit
			|	step_size)*
		End 'TYPEDEF_AXIS'
	;

typedef_blob
	:	Begin 'TYPEDEF_BLOB' Name=Ident
			LongIdentifier=STRING
			Size=A2LNUM
			address_type?
		End 'TYPEDEF_BLOB'
	;

typedef_characteristic
	:	Begin 'TYPEDEF_CHARACTERISTIC'	Name=Ident
			LongIdentifier=STRING
			Type=CHARACTERISTIC_TYPE
			RecordLayout=Ident
			MaxDiff=A2LNUM
			Conversion=Ident
			LowerLimit=A2LNUM
			UpperLimit=A2LNUM
			(
				axis_descr
			|	bit_mask
			|	byte_order
			|	discrete
			|	encoding
			|	extended_limits
			|	formate
			|	matrix_dim
			|	number
			|	phys_unit
			|	step_size
			)*
		End 'TYPEDEF_CHARACTERISTIC'
	;

typedef_measurement
	:	Begin 'TYPEDEF_MEASUREMENT' Name=Ident
			LongIdentifier=STRING
			DataType=DATATYPE
			Conversion=Ident
			Resolution=A2LNUM
			Accuracy=A2LNUM
			LowerLimit=A2LNUM
			UpperLimit=A2LNUM
			(
				address_type
			|	bit_mask
			|	bit_operation
			|	byte_order
			|	discrete
			|	error_mask
			|	formate
			|	layout
			|	matrix_dim
			|	phys_unit
			)*
		End 'TYPEDEF_MEASUREMENT'
	;

typedef_structure
	:	Begin 'TYPEDEF_STRUCTURE' Name=Ident
			LongIdentifier=STRING
			Size=A2LNUM
			(
				address_type
			|	consistent_exchange
			|	structure_component
			|	symbol_type_link
			)*
		End 'TYPEDEF_STRUCTURE'
	;

unit
	:	Begin 'UNIT'	Name=Ident
			LongIdentifier=STRING
			Display=STRING
			Type=('DERIVED'|'EXTENDED_SI')
			(	ref_unit
			|	si_exponents
			|	unit_conversion)*
		End 'UNIT'
	;

unit_conversion
	:	'UNIT_CONVERSION'	Gradient=A2LNUM Offset=A2LNUM
	;

user
	:	'USER'	UserName=STRING
	;

user_rights
	:	Begin 'USER_RIGHTS'	UserLevelId=Ident
			read_only?
			ref_group*
		End 'USER_RIGHTS'
	;

var_address
	:	Begin 'VAR_ADDRESS'	A2LNUM*
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
			LongIdentifier=STRING
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
			(	var_characteristic
			|	var_criterion
			|	var_forbidden_comb
			|	var_naming
			|	var_separator)*
		End 'VARIANT_CODING'
	;

version
	:	'VERSION'	VersionIdentifier=STRING
	;

virtual
	:	Begin 'VIRTUAL'	MeasuringChannels=Ident*
		End 'VIRTUAL'
	;

virtual_characteristic
	:	Begin 'VIRTUAL_CHARACTERISTIC'	Formula=STRING
			Characteristics=Ident*
		End 'VIRTUAL_CHARACTERISTIC'
	;

/* A2L grammar end */

/* Lexer grammar begin */

IF_DATA_BLOCK
	:	'/begin' WS+ 'IF_DATA'
			.*?
		'/end' WS+ 'IF_DATA'
		-> skip
	;

Begin	:	'/begin'	;
End		:	'/end'		;


PREDEFINED_TYPE_NAME
	:	'char'
	|	'int'
	|	'long'
	|	'int64'
	|	'uchar'
	|	'uint'
	|	'ulong'
	|	'uint64'
	|	'double'
	|	'float'
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
	|	'FLOAT16_IEEE'
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
	|	'PLONGLONG'
	|	'DIRECT'
	;

BYTEORDER
	:	'LITTLE_ENDIAN'
	|	'BIG_ENDIAN'
	|	'MSB_LAST'
	|	'MSB_FIRST'
	|	'MSB_FIRST_MSW_LAST'
	|	'MSB_LAST_MSW_FIRST'
	;

INDEXORDER
	:	'INDEX_INCR'
	|	'INDEX_DECR'
	;

A2LNUM
	: HEX_VALUE
	| DECIMAL
	;

fragment	
HEX_VALUE : '0' [xX] [a-fA-F0-9]+;

fragment
DECIMAL : INTEGER
	|	FLOAT
	;

fragment
INTEGER
	:	'0'
	|	[\-+]? [1-9] [0-9]*
	;

fragment
FLOAT
	:	[\-+]? '.' [0-9]+ ([eE][\-+]?[0-9]+)?
	|	[\-+]? [0-9]+ ('.' [0-9]*)? ([eE][\-+]?[0-9]+)? 
	;

Ident : IDENTIFIER;

fragment
IDENTIFIER : PartIDENTIFIER ('.' IDENTIFIER)?
;

fragment 
PartIDENTIFIER	:	[a-zA-Z_] [a-zA-Z0-9_]* //('[' [a-zA-Z0-9_]+ ']')? 
;


Formatstring
	:	'"%' [0-9]* '.' [0-9]+ '"'
	;

STRING
	:	'"' (ESC|.)*? '"'
	;


WS
    :   [ \t\n\r]+
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

/* Lexer grammar end */


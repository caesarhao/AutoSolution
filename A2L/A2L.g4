grammar A2L;
import AML;
a2l 
	:	(asap2_ver|a2ml_ver)* 
		project
	;

asap2_ver
	:	'ASAP2_VERSION' VersionNo=UInt UpgradeNo=UInt
	;
	
a2ml_ver
	:	'A2ML_VERSION' VersionNo=UInt UpgradeNo=UInt
	;

project
	:	Begin 'PROJECT' Name=Ident
			LongIdentifier=String 
			header?
			include* 
			module*
		End 'PROJECT'
	;

header
	:	Begin 'HEADER' Comment=String 
			('VERSION' String)?
			('PROJECT_NO' Ident)?
		End 'HEADER'
	;

include
	:	'/include' Ident
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
			format?
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
	|	format
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
	|	format
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

customer
	:	'CUSTOMER'	Customer=String
	;

customer_no
	:	'CUSTOMER_NO'	CustomerNumber=String
	;

data_size
	:	'DATA_SIZE'	Size=UInt
	;

default_value
	:	'DEFAULT_VALUE'	String
	;

default_value_numeric
	:	'DEFAULT_VALUE_NUMERIC'	Float
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

ecu
	:	'ECU'	ControlUnit=String
	;

ecu_address
	:	'ECU_ADDRESS'	Address=ULong
	;

ecu_address_extension
	:	'ECU_ADDRESS_EXTENSION'	Extension=Int
	;

epk
	:	'EPK'	Identifier=String
	;

format
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

identification
	:	'IDENTIFICATION'	Position=UInt
							DataType=DATATYPE
	;

if_data
	:	Begin 'IF_DATA'	Name=Ident
			.*
		End 'IF_DATA'
	;

in_measurement
	:	Begin 'IN_MEASUREMENT'
			Ident*
		End 'IN_MEASUREMENT'
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
	|	format
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

phys_unit
	:	'PHYS_UNIT'	Unit=String
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

Int		// 2-byte signed integer
    :	HexNum
	|	'-'?DigitNum
   ;
 
UInt	// 2-byte unsigned integer
	:	HexNum
	|	DigitNum
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
	|	NonzeroDigit(Digit)*
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

grammar A2L;

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

a2ml
	:	Begin 'A2ML'
		.*
		End 'A2ML'
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

fragment
axis_pts_optional
	:
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

fragment	
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

fragment
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
	
Begin :	'/begin';
End : '/end';





Int
    :	'-'? UInt
    ;

UInt
	:	'0'
	|	NonzeroDigit Digit*
	;

Float
	:	DigitSequence? '.' DigitSequence? ((e|E)(+-)?DigitSequence)?
	;

HexNum
	:	HexadecimalPrefix HexadecimalDigit+
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
    :   '0' [xX]
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

Ident
	:	PartIdent?(\.PartIdent)*
	;

PartIdent
	:	CIdent(\[(ENUM|Index)\])?
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
	:	'"' SChar* '"'
	;

fragment
SChar
    :   ~["\\\r\n]
    |   '\\\n'   // Added line
    |   '\\\r\n' // Added line
    ;

Whitespace
    :   [ \t]+
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
    :   '//' ~[\r\n]*
        -> skip
    ;


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
		End 'A2ML'
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
	
measurement_optional
	:
	;

characteristic
	:	Begin 'CHARACTERISTIC' Name=Ident
			LongIdentifier=String
			Type=ENUM
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
	:
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


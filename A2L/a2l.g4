grammar A2L;

a2l 
	:	(a2ml_ver | asap2_ver)* project
	;

a2ml_ver
	:	'A2ML_VERSION' Whitespace+ VersionNo Whitespace+ UpgradeNo
	;

asap2_ver
	:	'ASAP2_VERSION' Whitespace+ VersionNo Whitespace+ UpgradeNo
	;

project
	:	Begin Whitespace+ 'PROJECT' Whitespace+ Identifier
	;

VersionNo
	:	UInt
	;

UpgradeNo
	:	UInt
	;



Begin :	'/begin';
End : '/end';



fragment
Nondigit
    :   [a-zA-Z_]
    ;

fragment
Digit
    :   [0-9]
    ;

fragment
Int
    :	'-'? UInt
    ;

fragment
UInt
	:	'0'
	|	NonzeroDigit Digit*
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

fragment
Word
	:	[_a-zA-Z0-9]
	;

fragment
Identifier
	:	[_a-zA-Z] Word*
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


grammar AML;

a2ml
	:	Begin 'A2ML'
			declaration*?
		End 'A2ML'
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
	:	'char'
	|	'int'
	|	'long'
	|	'uchar'
	|	'uint'
	|	'ulong'
	|	'double'
	|	'float'
	;

block_definition
	:	'block' tag type_name
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

Begin :	'/begin';
End : '/end';

identifier
	: CIdent
	;

tag
	:	STRING
	;

keyword
	:	STRING
	;

constant
	:	NUMBER
	;

CIdent
	:	[a-zA-Z_][a-zA-Z0-9_]*
	;

WS
    :   [ \t\r\n]+
        -> skip
    ;

STRING
	: '"' .*? '"'
	;

SIGN
	: ('+'|'-')
	;

NUMBER
	: SIGN? ([0-9]* '.' )? [0-9]+
	;

BlockComment
    :   '/*' .*? '*/'
        -> skip
    ;

LineComment
    :   '//' .*? '\n'
        -> skip
    ;


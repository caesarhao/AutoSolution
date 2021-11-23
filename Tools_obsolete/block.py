import textparser
from textparser import Sequence
from textparser import choice
from textparser import ZeroOrMore
from textparser import OneOrMore
from textparser import OneOrMoreDict
from textparser import DelimitedList
from textparser import Any
from textparser import AnyUntil
from textparser import tokenize_init
from textparser import Token
from textparser import TokenizeError
from textparser import Optional

class Block(textparser.Parser):
	def token_specs(self):
		return [
			# (kind,		(name),	re)
			('SKIP',          		r'[ \r\n\t]+'),
			('HEX',					r'0[xX]\d+'),
			('NUMBER', 		  		r'[-+]?\d+\.?\d*([eE][-+]?\d+)?'),
			('WORD',          		r'\w+'),
			('STRING',		  		r'"(\\"|[^"])*?"'),
			('COMMENT',				r'\/\*(\*(?!\/)|[^*])*\*\/'),
			('LPARENTHESE',	'(',	r'\('),
            ('RPARENTHESE',	')',	r'\)'),
            ('LBRACKET',	'[',	r'\['),
            ('RBRACKET',	']',	r'\]'),
            ('LBRACE',		'{',	r'\{'),
            ('RBRACE',		'}',	r'\}'),
			('EMARK',    	'!',	r'!'),
			('COMMA',    	',',	r','),
			('COLON',    	':',	r':'),
			('SEMICOLON'	';',	r';'),
			
			('MISMATCH',      		r'.')
			]
	predefined_types = ['char', 'int', 'long', 'uchar', 'uint', 'ulong', 'double', 'float']
	def	keywords(self):
		return set([
			'/begin', '/end', '/include',
			'A2ML', 'A2ML_VERSION', 'ADDR_EPK',	'ALIGNMENT_BYTE', 'ALIGNMENT_FLOAT32_IEEE',	'ALIGNMENT_FLOAT64_IEEE',
			'ALIGNMENT_INT64', 'ALIGNMENT_LONG', 'ALIGNMENT_WORD', 'ANNOTATION', 'ANNOTATION_LABEL', 'ANNOTATION_ORIGIN',
			'ANNOTATION_TEXT', 'ARRAY_SIZE', 'ASAP2_VERSION', 'AXIS_DESCR', 'AXIS_PTS', 'AXIS_PTS_REF',
			'AXIS_PTS_X', 'AXIS_PTS_Y', 'AXIS_PTS_Z', 'AXIS_PTS_4', 'AXIS_PTS_5',
			'AXIS_RESCALE_X','BIT_MASK','BIT_OPERATION','BYTE_ORDER','CALIBRATION_ACCESS','CALIBRATION_HANDLE',
			'CALIBRATION_HANDLE_TEXT','CALIBRATION_METHOD','CHARACTERISTIC','COEFFS','COEFFS_LINEAR','COMPARISON_QUANTITY',
			'COMPU_METHOD','COMPU_TAB','COMPU_TAB_REF','COMPU_VTAB','COMPU_VTAB_RANGE','CPU_TYPE','CURVE_AXIS_REF',
			'CUSTOMER','CUSTOMER_NO','DATA_SIZE','DEF_CHARACTERISTIC','DEFAULT_VALUE','DEFAULT_VALUE_NUMERIC',
			'DEPENDENT_CHARACTERISTIC','DEPOSIT','DISCRETE','DISPLAY_IDENTIFIER','DIST_OP_X','DIST_OP_Z','DIST_OP_4',
			'DIST_OP_5','ECU','ECU_ADDRESS','ECU_ADDRESS_EXTENSION','ECU_CALIBRATION_OFFSET','EPK','ERROR_MASK',
			'EXTENDED_LIMITS','FIX_AXIS_PAR','FIX_AXIS_PAR_DIST','FIX_AXIS_PAR_LIST','FIX_NO_AXIS_PTS_X',
			'FIX_NO_AXIS_PTS_Y','FIX_NO_AXIS_PTS_Z','FIX_NO_AXIS_PTS_4','FIX_NO_AXIS_PTS_5','FNC_VALUES','FORMAT',
			'FORMULA','FORMULA_INV','FRAME','FRAME_MEASUREMENT','FUNCTION','FUNCTION_LIST','FUNCTION_VERSION',
			'GROUP','GUARD_RAILS','HEADER','IDENTIFICATION','IF_DATA','IN_MEASUREMENT','LAYOUT','LEFT_SHIFT',
			'LOC_MEASUREMENT','MAP_LIST','MATRIX_DIM','MAX_GRAD','MAX_REFRESH','MEASUREMENT','MEMORY_LAYOUT',
			'MEMORY_SEGMENT','MOD_COMMON','MOD_PAR','MODEL_LINK','MODULE','MONOTONY','NO_AXIS_PTS_X','NO_AXIS_PTS_Y','NO_AXIS_PTS_Z',
			'NO_AXIS_PTS_4','NO_AXIS_PTS_5','NO_OF_INTERFACES','NO_RESCALE_X','NUMBER','OFFSET_X','OFFSET_Y','OFFSET_Z',
			'OFFSET_4','OFFSET_5', 'OPTIONAL_CMD', 'OUT_MEASUREMENT','PHONE_NO','PHYS_UNIT','PROJECT','PROJECT_NO','READ_ONLY','READ_WRITE',
			'RECORD_LAYOUT','REF_CHARACTERISTIC','REF_GROUP','REF_MEASUREMENT','REF_MEMORY_SEGMENT','REF_UNIT','RESERVED',
			'RIGHT_SHIFT','RIP_ADDR_W','RIP_ADDR_X','RIP_ADDR_Y','RIP_ADDR_Z','RIP_ADDR_4','RIP_ADDR_5','ROOT','SHIFT_OP_X',
			'SHIFT_OP_Y','SHIFT_OP_Z','SHIFT_OP_4','SHIFT_OP_5','SIGN_EXTEND','SI_EXPONENTS','SRC_ADDR_X','SRC_ADDR_Y',
			'SRC_ADDR_Z','SRC_ADDR_4','SRC_ADDR_5','STATIC_RECORD_LAYOUT','STATUS_STRING_REF','STEP_SIZE','SUB_FUNCTION',
			'SUB_GROUP','SUPPLIER','SYMBOL_LINK','SYSTEM_CONSTANT','UNIT','UNIT_CONVERSION','USER','USER_RIGHTS',
			'VAR_ADDRESS','VAR_CHARACTERISTIC','VAR_CRITERION','VAR_FORBIDDEN_COMB','VAR_MEASUREMENT','VAR_NAMING',
			'VAR_SELECTION_CHARACTERISTIC','VAR_SEPARATOR','VARIANT_CODING','VERSION','VIRTUAL','VIRTUAL_CHARACTERISTIC'
			])
	def grammar(self):
		

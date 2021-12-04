// Generated from /home/caesarhao/sandboxes/AutoSolution/A2L/AML.g4 by ANTLR 4.8
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class AMLParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.8", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		CIdent=25, Begin=26, End=27, DigitNum=28, WS=29, Newline=30, BlockComment=31, 
		LineComment=32;
	public static final int
		RULE_a2ml = 0, RULE_declaration = 1, RULE_type_definition = 2, RULE_type_name = 3, 
		RULE_predefined_type_name = 4, RULE_block_definition = 5, RULE_enum_type_name = 6, 
		RULE_enumerator_list = 7, RULE_enumerator = 8, RULE_struct_type_name = 9, 
		RULE_struct_member_list = 10, RULE_struct_member = 11, RULE_member = 12, 
		RULE_array_specifier = 13, RULE_taggedstruct_type_name = 14, RULE_taggedstruct_member_list = 15, 
		RULE_taggedstruct_member = 16, RULE_taggedstruct_definition = 17, RULE_taggedunion_type_name = 18, 
		RULE_taggedunion_member_list = 19, RULE_tagged_union_member = 20, RULE_tag = 21, 
		RULE_keyword = 22, RULE_identifier = 23, RULE_constant = 24;
	private static String[] makeRuleNames() {
		return new String[] {
			"a2ml", "declaration", "type_definition", "type_name", "predefined_type_name", 
			"block_definition", "enum_type_name", "enumerator_list", "enumerator", 
			"struct_type_name", "struct_member_list", "struct_member", "member", 
			"array_specifier", "taggedstruct_type_name", "taggedstruct_member_list", 
			"taggedstruct_member", "taggedstruct_definition", "taggedunion_type_name", 
			"taggedunion_member_list", "tagged_union_member", "tag", "keyword", "identifier", 
			"constant"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'A2ML'", "';'", "'char'", "'int'", "'long'", "'uchar'", "'uint'", 
			"'ulong'", "'double'", "'float'", "'block'", "'enum'", "'{'", "'}'", 
			"','", "'='", "'struct'", "'['", "']'", "'taggedstruct'", "'('", "')*;'", 
			"'taggedunion'", "'\"'", null, "'/begin'", "'/end'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, "CIdent", "Begin", "End", "DigitNum", "WS", "Newline", "BlockComment", 
			"LineComment"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "AML.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public AMLParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	public static class A2mlContext extends ParserRuleContext {
		public TerminalNode Begin() { return getToken(AMLParser.Begin, 0); }
		public TerminalNode End() { return getToken(AMLParser.End, 0); }
		public A2mlContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_a2ml; }
	}

	public final A2mlContext a2ml() throws RecognitionException {
		A2mlContext _localctx = new A2mlContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_a2ml);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(50);
			match(Begin);
			setState(51);
			match(T__0);
			setState(55);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,0,_ctx);
			while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					setState(52);
					matchWildcard();
					}
					} 
				}
				setState(57);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,0,_ctx);
			}
			setState(58);
			match(End);
			setState(59);
			match(T__0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class DeclarationContext extends ParserRuleContext {
		public Type_definitionContext type_definition() {
			return getRuleContext(Type_definitionContext.class,0);
		}
		public Block_definitionContext block_definition() {
			return getRuleContext(Block_definitionContext.class,0);
		}
		public DeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_declaration; }
	}

	public final DeclarationContext declaration() throws RecognitionException {
		DeclarationContext _localctx = new DeclarationContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_declaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(63);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__2:
			case T__3:
			case T__4:
			case T__5:
			case T__6:
			case T__7:
			case T__8:
			case T__9:
			case T__11:
			case T__16:
			case T__19:
			case T__22:
				{
				setState(61);
				type_definition();
				}
				break;
			case T__10:
				{
				setState(62);
				block_definition();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			setState(65);
			match(T__1);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Type_definitionContext extends ParserRuleContext {
		public Type_nameContext type_name() {
			return getRuleContext(Type_nameContext.class,0);
		}
		public Type_definitionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_type_definition; }
	}

	public final Type_definitionContext type_definition() throws RecognitionException {
		Type_definitionContext _localctx = new Type_definitionContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_type_definition);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(67);
			type_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Type_nameContext extends ParserRuleContext {
		public Predefined_type_nameContext predefined_type_name() {
			return getRuleContext(Predefined_type_nameContext.class,0);
		}
		public Struct_type_nameContext struct_type_name() {
			return getRuleContext(Struct_type_nameContext.class,0);
		}
		public Taggedstruct_type_nameContext taggedstruct_type_name() {
			return getRuleContext(Taggedstruct_type_nameContext.class,0);
		}
		public Taggedunion_type_nameContext taggedunion_type_name() {
			return getRuleContext(Taggedunion_type_nameContext.class,0);
		}
		public Enum_type_nameContext enum_type_name() {
			return getRuleContext(Enum_type_nameContext.class,0);
		}
		public Type_nameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_type_name; }
	}

	public final Type_nameContext type_name() throws RecognitionException {
		Type_nameContext _localctx = new Type_nameContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_type_name);
		try {
			setState(74);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__2:
			case T__3:
			case T__4:
			case T__5:
			case T__6:
			case T__7:
			case T__8:
			case T__9:
				enterOuterAlt(_localctx, 1);
				{
				setState(69);
				predefined_type_name();
				}
				break;
			case T__16:
				enterOuterAlt(_localctx, 2);
				{
				setState(70);
				struct_type_name();
				}
				break;
			case T__19:
				enterOuterAlt(_localctx, 3);
				{
				setState(71);
				taggedstruct_type_name();
				}
				break;
			case T__22:
				enterOuterAlt(_localctx, 4);
				{
				setState(72);
				taggedunion_type_name();
				}
				break;
			case T__11:
				enterOuterAlt(_localctx, 5);
				{
				setState(73);
				enum_type_name();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Predefined_type_nameContext extends ParserRuleContext {
		public Predefined_type_nameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_predefined_type_name; }
	}

	public final Predefined_type_nameContext predefined_type_name() throws RecognitionException {
		Predefined_type_nameContext _localctx = new Predefined_type_nameContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_predefined_type_name);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(76);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9))) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Block_definitionContext extends ParserRuleContext {
		public TagContext tag() {
			return getRuleContext(TagContext.class,0);
		}
		public Type_nameContext type_name() {
			return getRuleContext(Type_nameContext.class,0);
		}
		public Block_definitionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_block_definition; }
	}

	public final Block_definitionContext block_definition() throws RecognitionException {
		Block_definitionContext _localctx = new Block_definitionContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_block_definition);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(78);
			match(T__10);
			setState(79);
			tag();
			setState(80);
			type_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Enum_type_nameContext extends ParserRuleContext {
		public Enumerator_listContext enumerator_list() {
			return getRuleContext(Enumerator_listContext.class,0);
		}
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public Enum_type_nameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_enum_type_name; }
	}

	public final Enum_type_nameContext enum_type_name() throws RecognitionException {
		Enum_type_nameContext _localctx = new Enum_type_nameContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_enum_type_name);
		int _la;
		try {
			setState(92);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,4,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				{
				setState(82);
				match(T__11);
				setState(84);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==CIdent) {
					{
					setState(83);
					identifier();
					}
				}

				setState(86);
				match(T__12);
				setState(87);
				enumerator_list();
				setState(88);
				match(T__13);
				}
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				{
				setState(90);
				match(T__11);
				setState(91);
				identifier();
				}
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Enumerator_listContext extends ParserRuleContext {
		public EnumeratorContext enumerator() {
			return getRuleContext(EnumeratorContext.class,0);
		}
		public Enumerator_listContext enumerator_list() {
			return getRuleContext(Enumerator_listContext.class,0);
		}
		public Enumerator_listContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_enumerator_list; }
	}

	public final Enumerator_listContext enumerator_list() throws RecognitionException {
		Enumerator_listContext _localctx = new Enumerator_listContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_enumerator_list);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(94);
			enumerator();
			setState(97);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__14) {
				{
				setState(95);
				match(T__14);
				setState(96);
				enumerator_list();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class EnumeratorContext extends ParserRuleContext {
		public KeywordContext keyword() {
			return getRuleContext(KeywordContext.class,0);
		}
		public ConstantContext constant() {
			return getRuleContext(ConstantContext.class,0);
		}
		public EnumeratorContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_enumerator; }
	}

	public final EnumeratorContext enumerator() throws RecognitionException {
		EnumeratorContext _localctx = new EnumeratorContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_enumerator);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(99);
			keyword();
			setState(102);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__15) {
				{
				setState(100);
				match(T__15);
				setState(101);
				constant();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Struct_type_nameContext extends ParserRuleContext {
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public Struct_member_listContext struct_member_list() {
			return getRuleContext(Struct_member_listContext.class,0);
		}
		public Struct_type_nameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_struct_type_name; }
	}

	public final Struct_type_nameContext struct_type_name() throws RecognitionException {
		Struct_type_nameContext _localctx = new Struct_type_nameContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_struct_type_name);
		int _la;
		try {
			setState(115);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,9,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				{
				setState(104);
				match(T__16);
				setState(106);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==CIdent) {
					{
					setState(105);
					identifier();
					}
				}

				setState(108);
				match(T__12);
				setState(110);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__11) | (1L << T__16) | (1L << T__19) | (1L << T__22))) != 0)) {
					{
					setState(109);
					struct_member_list();
					}
				}

				setState(112);
				match(T__13);
				}
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				{
				setState(113);
				match(T__16);
				setState(114);
				identifier();
				}
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Struct_member_listContext extends ParserRuleContext {
		public Struct_memberContext struct_member() {
			return getRuleContext(Struct_memberContext.class,0);
		}
		public Struct_member_listContext struct_member_list() {
			return getRuleContext(Struct_member_listContext.class,0);
		}
		public Struct_member_listContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_struct_member_list; }
	}

	public final Struct_member_listContext struct_member_list() throws RecognitionException {
		Struct_member_listContext _localctx = new Struct_member_listContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_struct_member_list);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(117);
			struct_member();
			setState(119);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__11) | (1L << T__16) | (1L << T__19) | (1L << T__22))) != 0)) {
				{
				setState(118);
				struct_member_list();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Struct_memberContext extends ParserRuleContext {
		public MemberContext member() {
			return getRuleContext(MemberContext.class,0);
		}
		public Struct_memberContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_struct_member; }
	}

	public final Struct_memberContext struct_member() throws RecognitionException {
		Struct_memberContext _localctx = new Struct_memberContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_struct_member);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(121);
			member();
			setState(122);
			match(T__1);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MemberContext extends ParserRuleContext {
		public Type_nameContext type_name() {
			return getRuleContext(Type_nameContext.class,0);
		}
		public Array_specifierContext array_specifier() {
			return getRuleContext(Array_specifierContext.class,0);
		}
		public MemberContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_member; }
	}

	public final MemberContext member() throws RecognitionException {
		MemberContext _localctx = new MemberContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_member);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(124);
			type_name();
			setState(126);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__17) {
				{
				setState(125);
				array_specifier();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Array_specifierContext extends ParserRuleContext {
		public ConstantContext constant() {
			return getRuleContext(ConstantContext.class,0);
		}
		public Array_specifierContext array_specifier() {
			return getRuleContext(Array_specifierContext.class,0);
		}
		public Array_specifierContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_array_specifier; }
	}

	public final Array_specifierContext array_specifier() throws RecognitionException {
		Array_specifierContext _localctx = new Array_specifierContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_array_specifier);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(128);
			match(T__17);
			setState(129);
			constant();
			setState(130);
			match(T__18);
			setState(132);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__17) {
				{
				setState(131);
				array_specifier();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Taggedstruct_type_nameContext extends ParserRuleContext {
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public Taggedstruct_member_listContext taggedstruct_member_list() {
			return getRuleContext(Taggedstruct_member_listContext.class,0);
		}
		public Taggedstruct_type_nameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_taggedstruct_type_name; }
	}

	public final Taggedstruct_type_nameContext taggedstruct_type_name() throws RecognitionException {
		Taggedstruct_type_nameContext _localctx = new Taggedstruct_type_nameContext(_ctx, getState());
		enterRule(_localctx, 28, RULE_taggedstruct_type_name);
		int _la;
		try {
			setState(145);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,15,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				{
				setState(134);
				match(T__19);
				setState(136);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==CIdent) {
					{
					setState(135);
					identifier();
					}
				}

				setState(138);
				match(T__12);
				setState(140);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__10) | (1L << T__20) | (1L << T__23))) != 0)) {
					{
					setState(139);
					taggedstruct_member_list();
					}
				}

				setState(142);
				match(T__13);
				}
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				{
				setState(143);
				match(T__19);
				setState(144);
				identifier();
				}
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Taggedstruct_member_listContext extends ParserRuleContext {
		public Taggedstruct_memberContext taggedstruct_member() {
			return getRuleContext(Taggedstruct_memberContext.class,0);
		}
		public Taggedstruct_member_listContext taggedstruct_member_list() {
			return getRuleContext(Taggedstruct_member_listContext.class,0);
		}
		public Taggedstruct_member_listContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_taggedstruct_member_list; }
	}

	public final Taggedstruct_member_listContext taggedstruct_member_list() throws RecognitionException {
		Taggedstruct_member_listContext _localctx = new Taggedstruct_member_listContext(_ctx, getState());
		enterRule(_localctx, 30, RULE_taggedstruct_member_list);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(147);
			taggedstruct_member();
			setState(149);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__10) | (1L << T__20) | (1L << T__23))) != 0)) {
				{
				setState(148);
				taggedstruct_member_list();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Taggedstruct_memberContext extends ParserRuleContext {
		public Taggedstruct_definitionContext taggedstruct_definition() {
			return getRuleContext(Taggedstruct_definitionContext.class,0);
		}
		public List<Block_definitionContext> block_definition() {
			return getRuleContexts(Block_definitionContext.class);
		}
		public Block_definitionContext block_definition(int i) {
			return getRuleContext(Block_definitionContext.class,i);
		}
		public Taggedstruct_memberContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_taggedstruct_member; }
	}

	public final Taggedstruct_memberContext taggedstruct_member() throws RecognitionException {
		Taggedstruct_memberContext _localctx = new Taggedstruct_memberContext(_ctx, getState());
		enterRule(_localctx, 32, RULE_taggedstruct_member);
		try {
			setState(164);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__23:
				enterOuterAlt(_localctx, 1);
				{
				{
				setState(151);
				taggedstruct_definition();
				setState(152);
				match(T__1);
				}
				}
				break;
			case T__20:
				enterOuterAlt(_localctx, 2);
				{
				{
				setState(154);
				match(T__20);
				setState(155);
				taggedstruct_definition();
				setState(156);
				match(T__21);
				}
				}
				break;
			case T__10:
				enterOuterAlt(_localctx, 3);
				{
				{
				setState(158);
				block_definition();
				setState(159);
				match(T__1);
				setState(160);
				match(T__20);
				setState(161);
				block_definition();
				setState(162);
				match(T__21);
				}
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Taggedstruct_definitionContext extends ParserRuleContext {
		public TagContext tag() {
			return getRuleContext(TagContext.class,0);
		}
		public MemberContext member() {
			return getRuleContext(MemberContext.class,0);
		}
		public Taggedstruct_definitionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_taggedstruct_definition; }
	}

	public final Taggedstruct_definitionContext taggedstruct_definition() throws RecognitionException {
		Taggedstruct_definitionContext _localctx = new Taggedstruct_definitionContext(_ctx, getState());
		enterRule(_localctx, 34, RULE_taggedstruct_definition);
		int _la;
		try {
			setState(175);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,19,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				{
				setState(166);
				tag();
				setState(168);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__11) | (1L << T__16) | (1L << T__19) | (1L << T__22))) != 0)) {
					{
					setState(167);
					member();
					}
				}

				}
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				{
				setState(170);
				tag();
				setState(171);
				match(T__20);
				setState(172);
				member();
				setState(173);
				match(T__21);
				}
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Taggedunion_type_nameContext extends ParserRuleContext {
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public Taggedunion_member_listContext taggedunion_member_list() {
			return getRuleContext(Taggedunion_member_listContext.class,0);
		}
		public Taggedunion_type_nameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_taggedunion_type_name; }
	}

	public final Taggedunion_type_nameContext taggedunion_type_name() throws RecognitionException {
		Taggedunion_type_nameContext _localctx = new Taggedunion_type_nameContext(_ctx, getState());
		enterRule(_localctx, 36, RULE_taggedunion_type_name);
		int _la;
		try {
			setState(188);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,22,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				{
				setState(177);
				match(T__22);
				setState(179);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==CIdent) {
					{
					setState(178);
					identifier();
					}
				}

				setState(181);
				match(T__12);
				setState(183);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==T__10 || _la==T__23) {
					{
					setState(182);
					taggedunion_member_list();
					}
				}

				setState(185);
				match(T__13);
				}
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				{
				setState(186);
				match(T__22);
				setState(187);
				identifier();
				}
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Taggedunion_member_listContext extends ParserRuleContext {
		public Tagged_union_memberContext tagged_union_member() {
			return getRuleContext(Tagged_union_memberContext.class,0);
		}
		public Taggedunion_member_listContext taggedunion_member_list() {
			return getRuleContext(Taggedunion_member_listContext.class,0);
		}
		public Taggedunion_member_listContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_taggedunion_member_list; }
	}

	public final Taggedunion_member_listContext taggedunion_member_list() throws RecognitionException {
		Taggedunion_member_listContext _localctx = new Taggedunion_member_listContext(_ctx, getState());
		enterRule(_localctx, 38, RULE_taggedunion_member_list);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(190);
			tagged_union_member();
			setState(192);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__10 || _la==T__23) {
				{
				setState(191);
				taggedunion_member_list();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Tagged_union_memberContext extends ParserRuleContext {
		public TagContext tag() {
			return getRuleContext(TagContext.class,0);
		}
		public MemberContext member() {
			return getRuleContext(MemberContext.class,0);
		}
		public Block_definitionContext block_definition() {
			return getRuleContext(Block_definitionContext.class,0);
		}
		public Tagged_union_memberContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_tagged_union_member; }
	}

	public final Tagged_union_memberContext tagged_union_member() throws RecognitionException {
		Tagged_union_memberContext _localctx = new Tagged_union_memberContext(_ctx, getState());
		enterRule(_localctx, 40, RULE_tagged_union_member);
		int _la;
		try {
			setState(203);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__23:
				enterOuterAlt(_localctx, 1);
				{
				{
				setState(194);
				tag();
				setState(196);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__11) | (1L << T__16) | (1L << T__19) | (1L << T__22))) != 0)) {
					{
					setState(195);
					member();
					}
				}

				setState(198);
				match(T__1);
				}
				}
				break;
			case T__10:
				enterOuterAlt(_localctx, 2);
				{
				{
				setState(200);
				block_definition();
				setState(201);
				match(T__1);
				}
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class TagContext extends ParserRuleContext {
		public TerminalNode CIdent() { return getToken(AMLParser.CIdent, 0); }
		public TagContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_tag; }
	}

	public final TagContext tag() throws RecognitionException {
		TagContext _localctx = new TagContext(_ctx, getState());
		enterRule(_localctx, 42, RULE_tag);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(205);
			match(T__23);
			setState(206);
			match(CIdent);
			setState(207);
			match(T__23);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class KeywordContext extends ParserRuleContext {
		public TerminalNode CIdent() { return getToken(AMLParser.CIdent, 0); }
		public KeywordContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_keyword; }
	}

	public final KeywordContext keyword() throws RecognitionException {
		KeywordContext _localctx = new KeywordContext(_ctx, getState());
		enterRule(_localctx, 44, RULE_keyword);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(209);
			match(T__23);
			setState(210);
			match(CIdent);
			setState(211);
			match(T__23);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IdentifierContext extends ParserRuleContext {
		public TerminalNode CIdent() { return getToken(AMLParser.CIdent, 0); }
		public IdentifierContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_identifier; }
	}

	public final IdentifierContext identifier() throws RecognitionException {
		IdentifierContext _localctx = new IdentifierContext(_ctx, getState());
		enterRule(_localctx, 46, RULE_identifier);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(213);
			match(CIdent);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ConstantContext extends ParserRuleContext {
		public TerminalNode DigitNum() { return getToken(AMLParser.DigitNum, 0); }
		public ConstantContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_constant; }
	}

	public final ConstantContext constant() throws RecognitionException {
		ConstantContext _localctx = new ConstantContext(_ctx, getState());
		enterRule(_localctx, 48, RULE_constant);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(215);
			match(DigitNum);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\"\u00dc\4\2\t\2\4"+
		"\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t"+
		"\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31\t\31"+
		"\4\32\t\32\3\2\3\2\3\2\7\28\n\2\f\2\16\2;\13\2\3\2\3\2\3\2\3\3\3\3\5\3"+
		"B\n\3\3\3\3\3\3\4\3\4\3\5\3\5\3\5\3\5\3\5\5\5M\n\5\3\6\3\6\3\7\3\7\3\7"+
		"\3\7\3\b\3\b\5\bW\n\b\3\b\3\b\3\b\3\b\3\b\3\b\5\b_\n\b\3\t\3\t\3\t\5\t"+
		"d\n\t\3\n\3\n\3\n\5\ni\n\n\3\13\3\13\5\13m\n\13\3\13\3\13\5\13q\n\13\3"+
		"\13\3\13\3\13\5\13v\n\13\3\f\3\f\5\fz\n\f\3\r\3\r\3\r\3\16\3\16\5\16\u0081"+
		"\n\16\3\17\3\17\3\17\3\17\5\17\u0087\n\17\3\20\3\20\5\20\u008b\n\20\3"+
		"\20\3\20\5\20\u008f\n\20\3\20\3\20\3\20\5\20\u0094\n\20\3\21\3\21\5\21"+
		"\u0098\n\21\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22"+
		"\3\22\5\22\u00a7\n\22\3\23\3\23\5\23\u00ab\n\23\3\23\3\23\3\23\3\23\3"+
		"\23\5\23\u00b2\n\23\3\24\3\24\5\24\u00b6\n\24\3\24\3\24\5\24\u00ba\n\24"+
		"\3\24\3\24\3\24\5\24\u00bf\n\24\3\25\3\25\5\25\u00c3\n\25\3\26\3\26\5"+
		"\26\u00c7\n\26\3\26\3\26\3\26\3\26\3\26\5\26\u00ce\n\26\3\27\3\27\3\27"+
		"\3\27\3\30\3\30\3\30\3\30\3\31\3\31\3\32\3\32\3\32\39\2\33\2\4\6\b\n\f"+
		"\16\20\22\24\26\30\32\34\36 \"$&(*,.\60\62\2\3\3\2\5\f\2\u00e0\2\64\3"+
		"\2\2\2\4A\3\2\2\2\6E\3\2\2\2\bL\3\2\2\2\nN\3\2\2\2\fP\3\2\2\2\16^\3\2"+
		"\2\2\20`\3\2\2\2\22e\3\2\2\2\24u\3\2\2\2\26w\3\2\2\2\30{\3\2\2\2\32~\3"+
		"\2\2\2\34\u0082\3\2\2\2\36\u0093\3\2\2\2 \u0095\3\2\2\2\"\u00a6\3\2\2"+
		"\2$\u00b1\3\2\2\2&\u00be\3\2\2\2(\u00c0\3\2\2\2*\u00cd\3\2\2\2,\u00cf"+
		"\3\2\2\2.\u00d3\3\2\2\2\60\u00d7\3\2\2\2\62\u00d9\3\2\2\2\64\65\7\34\2"+
		"\2\659\7\3\2\2\668\13\2\2\2\67\66\3\2\2\28;\3\2\2\29:\3\2\2\29\67\3\2"+
		"\2\2:<\3\2\2\2;9\3\2\2\2<=\7\35\2\2=>\7\3\2\2>\3\3\2\2\2?B\5\6\4\2@B\5"+
		"\f\7\2A?\3\2\2\2A@\3\2\2\2BC\3\2\2\2CD\7\4\2\2D\5\3\2\2\2EF\5\b\5\2F\7"+
		"\3\2\2\2GM\5\n\6\2HM\5\24\13\2IM\5\36\20\2JM\5&\24\2KM\5\16\b\2LG\3\2"+
		"\2\2LH\3\2\2\2LI\3\2\2\2LJ\3\2\2\2LK\3\2\2\2M\t\3\2\2\2NO\t\2\2\2O\13"+
		"\3\2\2\2PQ\7\r\2\2QR\5,\27\2RS\5\b\5\2S\r\3\2\2\2TV\7\16\2\2UW\5\60\31"+
		"\2VU\3\2\2\2VW\3\2\2\2WX\3\2\2\2XY\7\17\2\2YZ\5\20\t\2Z[\7\20\2\2[_\3"+
		"\2\2\2\\]\7\16\2\2]_\5\60\31\2^T\3\2\2\2^\\\3\2\2\2_\17\3\2\2\2`c\5\22"+
		"\n\2ab\7\21\2\2bd\5\20\t\2ca\3\2\2\2cd\3\2\2\2d\21\3\2\2\2eh\5.\30\2f"+
		"g\7\22\2\2gi\5\62\32\2hf\3\2\2\2hi\3\2\2\2i\23\3\2\2\2jl\7\23\2\2km\5"+
		"\60\31\2lk\3\2\2\2lm\3\2\2\2mn\3\2\2\2np\7\17\2\2oq\5\26\f\2po\3\2\2\2"+
		"pq\3\2\2\2qr\3\2\2\2rv\7\20\2\2st\7\23\2\2tv\5\60\31\2uj\3\2\2\2us\3\2"+
		"\2\2v\25\3\2\2\2wy\5\30\r\2xz\5\26\f\2yx\3\2\2\2yz\3\2\2\2z\27\3\2\2\2"+
		"{|\5\32\16\2|}\7\4\2\2}\31\3\2\2\2~\u0080\5\b\5\2\177\u0081\5\34\17\2"+
		"\u0080\177\3\2\2\2\u0080\u0081\3\2\2\2\u0081\33\3\2\2\2\u0082\u0083\7"+
		"\24\2\2\u0083\u0084\5\62\32\2\u0084\u0086\7\25\2\2\u0085\u0087\5\34\17"+
		"\2\u0086\u0085\3\2\2\2\u0086\u0087\3\2\2\2\u0087\35\3\2\2\2\u0088\u008a"+
		"\7\26\2\2\u0089\u008b\5\60\31\2\u008a\u0089\3\2\2\2\u008a\u008b\3\2\2"+
		"\2\u008b\u008c\3\2\2\2\u008c\u008e\7\17\2\2\u008d\u008f\5 \21\2\u008e"+
		"\u008d\3\2\2\2\u008e\u008f\3\2\2\2\u008f\u0090\3\2\2\2\u0090\u0094\7\20"+
		"\2\2\u0091\u0092\7\26\2\2\u0092\u0094\5\60\31\2\u0093\u0088\3\2\2\2\u0093"+
		"\u0091\3\2\2\2\u0094\37\3\2\2\2\u0095\u0097\5\"\22\2\u0096\u0098\5 \21"+
		"\2\u0097\u0096\3\2\2\2\u0097\u0098\3\2\2\2\u0098!\3\2\2\2\u0099\u009a"+
		"\5$\23\2\u009a\u009b\7\4\2\2\u009b\u00a7\3\2\2\2\u009c\u009d\7\27\2\2"+
		"\u009d\u009e\5$\23\2\u009e\u009f\7\30\2\2\u009f\u00a7\3\2\2\2\u00a0\u00a1"+
		"\5\f\7\2\u00a1\u00a2\7\4\2\2\u00a2\u00a3\7\27\2\2\u00a3\u00a4\5\f\7\2"+
		"\u00a4\u00a5\7\30\2\2\u00a5\u00a7\3\2\2\2\u00a6\u0099\3\2\2\2\u00a6\u009c"+
		"\3\2\2\2\u00a6\u00a0\3\2\2\2\u00a7#\3\2\2\2\u00a8\u00aa\5,\27\2\u00a9"+
		"\u00ab\5\32\16\2\u00aa\u00a9\3\2\2\2\u00aa\u00ab\3\2\2\2\u00ab\u00b2\3"+
		"\2\2\2\u00ac\u00ad\5,\27\2\u00ad\u00ae\7\27\2\2\u00ae\u00af\5\32\16\2"+
		"\u00af\u00b0\7\30\2\2\u00b0\u00b2\3\2\2\2\u00b1\u00a8\3\2\2\2\u00b1\u00ac"+
		"\3\2\2\2\u00b2%\3\2\2\2\u00b3\u00b5\7\31\2\2\u00b4\u00b6\5\60\31\2\u00b5"+
		"\u00b4\3\2\2\2\u00b5\u00b6\3\2\2\2\u00b6\u00b7\3\2\2\2\u00b7\u00b9\7\17"+
		"\2\2\u00b8\u00ba\5(\25\2\u00b9\u00b8\3\2\2\2\u00b9\u00ba\3\2\2\2\u00ba"+
		"\u00bb\3\2\2\2\u00bb\u00bf\7\20\2\2\u00bc\u00bd\7\31\2\2\u00bd\u00bf\5"+
		"\60\31\2\u00be\u00b3\3\2\2\2\u00be\u00bc\3\2\2\2\u00bf\'\3\2\2\2\u00c0"+
		"\u00c2\5*\26\2\u00c1\u00c3\5(\25\2\u00c2\u00c1\3\2\2\2\u00c2\u00c3\3\2"+
		"\2\2\u00c3)\3\2\2\2\u00c4\u00c6\5,\27\2\u00c5\u00c7\5\32\16\2\u00c6\u00c5"+
		"\3\2\2\2\u00c6\u00c7\3\2\2\2\u00c7\u00c8\3\2\2\2\u00c8\u00c9\7\4\2\2\u00c9"+
		"\u00ce\3\2\2\2\u00ca\u00cb\5\f\7\2\u00cb\u00cc\7\4\2\2\u00cc\u00ce\3\2"+
		"\2\2\u00cd\u00c4\3\2\2\2\u00cd\u00ca\3\2\2\2\u00ce+\3\2\2\2\u00cf\u00d0"+
		"\7\32\2\2\u00d0\u00d1\7\33\2\2\u00d1\u00d2\7\32\2\2\u00d2-\3\2\2\2\u00d3"+
		"\u00d4\7\32\2\2\u00d4\u00d5\7\33\2\2\u00d5\u00d6\7\32\2\2\u00d6/\3\2\2"+
		"\2\u00d7\u00d8\7\33\2\2\u00d8\61\3\2\2\2\u00d9\u00da\7\36\2\2\u00da\63"+
		"\3\2\2\2\349ALV^chlpuy\u0080\u0086\u008a\u008e\u0093\u0097\u00a6\u00aa"+
		"\u00b1\u00b5\u00b9\u00be\u00c2\u00c6\u00cd";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}
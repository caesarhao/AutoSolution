// Generated from AML.g4 by ANTLR 4.9.3
package a2mljava;
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
	static { RuntimeMetaData.checkVersion("4.9.3", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, Begin=24, 
		End=25, CIdent=26, WS=27, STRING=28, SIGN=29, NUMBER=30, BlockComment=31, 
		LineComment=32;
	public static final int
		RULE_a2ml = 0, RULE_declaration = 1, RULE_type_definition = 2, RULE_type_name = 3, 
		RULE_predefined_type_name = 4, RULE_block_definition = 5, RULE_enum_type_name = 6, 
		RULE_enumerator_list = 7, RULE_enumerator = 8, RULE_struct_type_name = 9, 
		RULE_struct_member_list = 10, RULE_struct_member = 11, RULE_member = 12, 
		RULE_array_specifier = 13, RULE_taggedstruct_type_name = 14, RULE_taggedstruct_member_list = 15, 
		RULE_taggedstruct_member = 16, RULE_taggedstruct_definition = 17, RULE_taggedunion_type_name = 18, 
		RULE_taggedunion_member_list = 19, RULE_tagged_union_member = 20, RULE_identifier = 21, 
		RULE_tag = 22, RULE_keyword = 23, RULE_constant = 24;
	private static String[] makeRuleNames() {
		return new String[] {
			"a2ml", "declaration", "type_definition", "type_name", "predefined_type_name", 
			"block_definition", "enum_type_name", "enumerator_list", "enumerator", 
			"struct_type_name", "struct_member_list", "struct_member", "member", 
			"array_specifier", "taggedstruct_type_name", "taggedstruct_member_list", 
			"taggedstruct_member", "taggedstruct_definition", "taggedunion_type_name", 
			"taggedunion_member_list", "tagged_union_member", "identifier", "tag", 
			"keyword", "constant"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'A2ML'", "';'", "'char'", "'int'", "'long'", "'uchar'", "'uint'", 
			"'ulong'", "'double'", "'float'", "'block'", "'enum'", "'{'", "'}'", 
			"','", "'='", "'struct'", "'['", "']'", "'taggedstruct'", "'('", "')*;'", 
			"'taggedunion'", "'/begin'", "'/end'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, null, null, null, null, null, null, null, 
			"Begin", "End", "CIdent", "WS", "STRING", "SIGN", "NUMBER", "BlockComment", 
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
		public List<DeclarationContext> declaration() {
			return getRuleContexts(DeclarationContext.class);
		}
		public DeclarationContext declaration(int i) {
			return getRuleContext(DeclarationContext.class,i);
		}
		public A2mlContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_a2ml; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterA2ml(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitA2ml(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitA2ml(this);
			else return visitor.visitChildren(this);
		}
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
					declaration();
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterDeclaration(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitDeclaration(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitDeclaration(this);
			else return visitor.visitChildren(this);
		}
	}

	public final DeclarationContext declaration() throws RecognitionException {
		DeclarationContext _localctx = new DeclarationContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_declaration);
		try {
			setState(67);
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
				enterOuterAlt(_localctx, 1);
				{
				setState(61);
				type_definition();
				setState(62);
				match(T__1);
				}
				break;
			case T__10:
				enterOuterAlt(_localctx, 2);
				{
				setState(64);
				block_definition();
				setState(65);
				match(T__1);
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

	public static class Type_definitionContext extends ParserRuleContext {
		public Type_nameContext type_name() {
			return getRuleContext(Type_nameContext.class,0);
		}
		public Type_definitionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_type_definition; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterType_definition(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitType_definition(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitType_definition(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Type_definitionContext type_definition() throws RecognitionException {
		Type_definitionContext _localctx = new Type_definitionContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_type_definition);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(69);
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterType_name(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitType_name(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitType_name(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Type_nameContext type_name() throws RecognitionException {
		Type_nameContext _localctx = new Type_nameContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_type_name);
		try {
			setState(76);
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
				setState(71);
				predefined_type_name();
				}
				break;
			case T__16:
				enterOuterAlt(_localctx, 2);
				{
				setState(72);
				struct_type_name();
				}
				break;
			case T__19:
				enterOuterAlt(_localctx, 3);
				{
				setState(73);
				taggedstruct_type_name();
				}
				break;
			case T__22:
				enterOuterAlt(_localctx, 4);
				{
				setState(74);
				taggedunion_type_name();
				}
				break;
			case T__11:
				enterOuterAlt(_localctx, 5);
				{
				setState(75);
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterPredefined_type_name(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitPredefined_type_name(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitPredefined_type_name(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Predefined_type_nameContext predefined_type_name() throws RecognitionException {
		Predefined_type_nameContext _localctx = new Predefined_type_nameContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_predefined_type_name);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(78);
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterBlock_definition(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitBlock_definition(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitBlock_definition(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Block_definitionContext block_definition() throws RecognitionException {
		Block_definitionContext _localctx = new Block_definitionContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_block_definition);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(80);
			match(T__10);
			setState(81);
			tag();
			setState(82);
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterEnum_type_name(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitEnum_type_name(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitEnum_type_name(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Enum_type_nameContext enum_type_name() throws RecognitionException {
		Enum_type_nameContext _localctx = new Enum_type_nameContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_enum_type_name);
		int _la;
		try {
			setState(94);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,4,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(84);
				match(T__11);
				setState(86);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==CIdent) {
					{
					setState(85);
					identifier();
					}
				}

				setState(88);
				match(T__12);
				setState(89);
				enumerator_list();
				setState(90);
				match(T__13);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(92);
				match(T__11);
				setState(93);
				identifier();
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterEnumerator_list(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitEnumerator_list(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitEnumerator_list(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Enumerator_listContext enumerator_list() throws RecognitionException {
		Enumerator_listContext _localctx = new Enumerator_listContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_enumerator_list);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(96);
			enumerator();
			setState(99);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__14) {
				{
				setState(97);
				match(T__14);
				setState(98);
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterEnumerator(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitEnumerator(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitEnumerator(this);
			else return visitor.visitChildren(this);
		}
	}

	public final EnumeratorContext enumerator() throws RecognitionException {
		EnumeratorContext _localctx = new EnumeratorContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_enumerator);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(101);
			keyword();
			setState(104);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__15) {
				{
				setState(102);
				match(T__15);
				setState(103);
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterStruct_type_name(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitStruct_type_name(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitStruct_type_name(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Struct_type_nameContext struct_type_name() throws RecognitionException {
		Struct_type_nameContext _localctx = new Struct_type_nameContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_struct_type_name);
		int _la;
		try {
			setState(117);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,9,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(106);
				match(T__16);
				setState(108);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==CIdent) {
					{
					setState(107);
					identifier();
					}
				}

				setState(110);
				match(T__12);
				setState(112);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__11) | (1L << T__16) | (1L << T__19) | (1L << T__22))) != 0)) {
					{
					setState(111);
					struct_member_list();
					}
				}

				setState(114);
				match(T__13);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(115);
				match(T__16);
				setState(116);
				identifier();
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterStruct_member_list(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitStruct_member_list(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitStruct_member_list(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Struct_member_listContext struct_member_list() throws RecognitionException {
		Struct_member_listContext _localctx = new Struct_member_listContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_struct_member_list);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(119);
			struct_member();
			setState(121);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__11) | (1L << T__16) | (1L << T__19) | (1L << T__22))) != 0)) {
				{
				setState(120);
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterStruct_member(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitStruct_member(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitStruct_member(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Struct_memberContext struct_member() throws RecognitionException {
		Struct_memberContext _localctx = new Struct_memberContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_struct_member);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(123);
			member();
			setState(124);
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterMember(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitMember(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitMember(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MemberContext member() throws RecognitionException {
		MemberContext _localctx = new MemberContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_member);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(126);
			type_name();
			setState(128);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__17) {
				{
				setState(127);
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterArray_specifier(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitArray_specifier(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitArray_specifier(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Array_specifierContext array_specifier() throws RecognitionException {
		Array_specifierContext _localctx = new Array_specifierContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_array_specifier);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(130);
			match(T__17);
			setState(131);
			constant();
			setState(132);
			match(T__18);
			setState(134);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__17) {
				{
				setState(133);
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterTaggedstruct_type_name(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitTaggedstruct_type_name(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitTaggedstruct_type_name(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Taggedstruct_type_nameContext taggedstruct_type_name() throws RecognitionException {
		Taggedstruct_type_nameContext _localctx = new Taggedstruct_type_nameContext(_ctx, getState());
		enterRule(_localctx, 28, RULE_taggedstruct_type_name);
		int _la;
		try {
			setState(147);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,15,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(136);
				match(T__19);
				setState(138);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==CIdent) {
					{
					setState(137);
					identifier();
					}
				}

				setState(140);
				match(T__12);
				setState(142);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__10) | (1L << T__20) | (1L << STRING))) != 0)) {
					{
					setState(141);
					taggedstruct_member_list();
					}
				}

				setState(144);
				match(T__13);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(145);
				match(T__19);
				setState(146);
				identifier();
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterTaggedstruct_member_list(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitTaggedstruct_member_list(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitTaggedstruct_member_list(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Taggedstruct_member_listContext taggedstruct_member_list() throws RecognitionException {
		Taggedstruct_member_listContext _localctx = new Taggedstruct_member_listContext(_ctx, getState());
		enterRule(_localctx, 30, RULE_taggedstruct_member_list);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(149);
			taggedstruct_member();
			setState(151);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__10) | (1L << T__20) | (1L << STRING))) != 0)) {
				{
				setState(150);
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
		public Block_definitionContext block_definition() {
			return getRuleContext(Block_definitionContext.class,0);
		}
		public Taggedstruct_memberContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_taggedstruct_member; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterTaggedstruct_member(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitTaggedstruct_member(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitTaggedstruct_member(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Taggedstruct_memberContext taggedstruct_member() throws RecognitionException {
		Taggedstruct_memberContext _localctx = new Taggedstruct_memberContext(_ctx, getState());
		enterRule(_localctx, 32, RULE_taggedstruct_member);
		try {
			setState(167);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,17,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(153);
				taggedstruct_definition();
				setState(154);
				match(T__1);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(156);
				match(T__20);
				setState(157);
				taggedstruct_definition();
				setState(158);
				match(T__21);
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(160);
				block_definition();
				setState(161);
				match(T__1);
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(163);
				match(T__20);
				setState(164);
				block_definition();
				setState(165);
				match(T__21);
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterTaggedstruct_definition(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitTaggedstruct_definition(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitTaggedstruct_definition(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Taggedstruct_definitionContext taggedstruct_definition() throws RecognitionException {
		Taggedstruct_definitionContext _localctx = new Taggedstruct_definitionContext(_ctx, getState());
		enterRule(_localctx, 34, RULE_taggedstruct_definition);
		int _la;
		try {
			setState(178);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,19,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(169);
				tag();
				setState(171);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__11) | (1L << T__16) | (1L << T__19) | (1L << T__22))) != 0)) {
					{
					setState(170);
					member();
					}
				}

				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(173);
				tag();
				setState(174);
				match(T__20);
				setState(175);
				member();
				setState(176);
				match(T__21);
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterTaggedunion_type_name(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitTaggedunion_type_name(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitTaggedunion_type_name(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Taggedunion_type_nameContext taggedunion_type_name() throws RecognitionException {
		Taggedunion_type_nameContext _localctx = new Taggedunion_type_nameContext(_ctx, getState());
		enterRule(_localctx, 36, RULE_taggedunion_type_name);
		int _la;
		try {
			setState(191);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,22,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(180);
				match(T__22);
				setState(182);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==CIdent) {
					{
					setState(181);
					identifier();
					}
				}

				setState(184);
				match(T__12);
				setState(186);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==T__10 || _la==STRING) {
					{
					setState(185);
					taggedunion_member_list();
					}
				}

				setState(188);
				match(T__13);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(189);
				match(T__22);
				setState(190);
				identifier();
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterTaggedunion_member_list(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitTaggedunion_member_list(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitTaggedunion_member_list(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Taggedunion_member_listContext taggedunion_member_list() throws RecognitionException {
		Taggedunion_member_listContext _localctx = new Taggedunion_member_listContext(_ctx, getState());
		enterRule(_localctx, 38, RULE_taggedunion_member_list);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(193);
			tagged_union_member();
			setState(195);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__10 || _la==STRING) {
				{
				setState(194);
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterTagged_union_member(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitTagged_union_member(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitTagged_union_member(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Tagged_union_memberContext tagged_union_member() throws RecognitionException {
		Tagged_union_memberContext _localctx = new Tagged_union_memberContext(_ctx, getState());
		enterRule(_localctx, 40, RULE_tagged_union_member);
		int _la;
		try {
			setState(206);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case STRING:
				enterOuterAlt(_localctx, 1);
				{
				setState(197);
				tag();
				setState(199);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__11) | (1L << T__16) | (1L << T__19) | (1L << T__22))) != 0)) {
					{
					setState(198);
					member();
					}
				}

				setState(201);
				match(T__1);
				}
				break;
			case T__10:
				enterOuterAlt(_localctx, 2);
				{
				setState(203);
				block_definition();
				setState(204);
				match(T__1);
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

	public static class IdentifierContext extends ParserRuleContext {
		public TerminalNode CIdent() { return getToken(AMLParser.CIdent, 0); }
		public IdentifierContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_identifier; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterIdentifier(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitIdentifier(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitIdentifier(this);
			else return visitor.visitChildren(this);
		}
	}

	public final IdentifierContext identifier() throws RecognitionException {
		IdentifierContext _localctx = new IdentifierContext(_ctx, getState());
		enterRule(_localctx, 42, RULE_identifier);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(208);
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

	public static class TagContext extends ParserRuleContext {
		public TerminalNode STRING() { return getToken(AMLParser.STRING, 0); }
		public TagContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_tag; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterTag(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitTag(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitTag(this);
			else return visitor.visitChildren(this);
		}
	}

	public final TagContext tag() throws RecognitionException {
		TagContext _localctx = new TagContext(_ctx, getState());
		enterRule(_localctx, 44, RULE_tag);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(210);
			match(STRING);
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
		public TerminalNode STRING() { return getToken(AMLParser.STRING, 0); }
		public KeywordContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_keyword; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterKeyword(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitKeyword(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitKeyword(this);
			else return visitor.visitChildren(this);
		}
	}

	public final KeywordContext keyword() throws RecognitionException {
		KeywordContext _localctx = new KeywordContext(_ctx, getState());
		enterRule(_localctx, 46, RULE_keyword);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(212);
			match(STRING);
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
		public TerminalNode NUMBER() { return getToken(AMLParser.NUMBER, 0); }
		public ConstantContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_constant; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).enterConstant(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AMLListener ) ((AMLListener)listener).exitConstant(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof AMLVisitor ) return ((AMLVisitor<? extends T>)visitor).visitConstant(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ConstantContext constant() throws RecognitionException {
		ConstantContext _localctx = new ConstantContext(_ctx, getState());
		enterRule(_localctx, 48, RULE_constant);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(214);
			match(NUMBER);
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
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\"\u00db\4\2\t\2\4"+
		"\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t"+
		"\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31\t\31"+
		"\4\32\t\32\3\2\3\2\3\2\7\28\n\2\f\2\16\2;\13\2\3\2\3\2\3\2\3\3\3\3\3\3"+
		"\3\3\3\3\3\3\5\3F\n\3\3\4\3\4\3\5\3\5\3\5\3\5\3\5\5\5O\n\5\3\6\3\6\3\7"+
		"\3\7\3\7\3\7\3\b\3\b\5\bY\n\b\3\b\3\b\3\b\3\b\3\b\3\b\5\ba\n\b\3\t\3\t"+
		"\3\t\5\tf\n\t\3\n\3\n\3\n\5\nk\n\n\3\13\3\13\5\13o\n\13\3\13\3\13\5\13"+
		"s\n\13\3\13\3\13\3\13\5\13x\n\13\3\f\3\f\5\f|\n\f\3\r\3\r\3\r\3\16\3\16"+
		"\5\16\u0083\n\16\3\17\3\17\3\17\3\17\5\17\u0089\n\17\3\20\3\20\5\20\u008d"+
		"\n\20\3\20\3\20\5\20\u0091\n\20\3\20\3\20\3\20\5\20\u0096\n\20\3\21\3"+
		"\21\5\21\u009a\n\21\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22"+
		"\3\22\3\22\3\22\3\22\5\22\u00aa\n\22\3\23\3\23\5\23\u00ae\n\23\3\23\3"+
		"\23\3\23\3\23\3\23\5\23\u00b5\n\23\3\24\3\24\5\24\u00b9\n\24\3\24\3\24"+
		"\5\24\u00bd\n\24\3\24\3\24\3\24\5\24\u00c2\n\24\3\25\3\25\5\25\u00c6\n"+
		"\25\3\26\3\26\5\26\u00ca\n\26\3\26\3\26\3\26\3\26\3\26\5\26\u00d1\n\26"+
		"\3\27\3\27\3\30\3\30\3\31\3\31\3\32\3\32\3\32\39\2\33\2\4\6\b\n\f\16\20"+
		"\22\24\26\30\32\34\36 \"$&(*,.\60\62\2\3\3\2\5\f\2\u00e0\2\64\3\2\2\2"+
		"\4E\3\2\2\2\6G\3\2\2\2\bN\3\2\2\2\nP\3\2\2\2\fR\3\2\2\2\16`\3\2\2\2\20"+
		"b\3\2\2\2\22g\3\2\2\2\24w\3\2\2\2\26y\3\2\2\2\30}\3\2\2\2\32\u0080\3\2"+
		"\2\2\34\u0084\3\2\2\2\36\u0095\3\2\2\2 \u0097\3\2\2\2\"\u00a9\3\2\2\2"+
		"$\u00b4\3\2\2\2&\u00c1\3\2\2\2(\u00c3\3\2\2\2*\u00d0\3\2\2\2,\u00d2\3"+
		"\2\2\2.\u00d4\3\2\2\2\60\u00d6\3\2\2\2\62\u00d8\3\2\2\2\64\65\7\32\2\2"+
		"\659\7\3\2\2\668\5\4\3\2\67\66\3\2\2\28;\3\2\2\29:\3\2\2\29\67\3\2\2\2"+
		":<\3\2\2\2;9\3\2\2\2<=\7\33\2\2=>\7\3\2\2>\3\3\2\2\2?@\5\6\4\2@A\7\4\2"+
		"\2AF\3\2\2\2BC\5\f\7\2CD\7\4\2\2DF\3\2\2\2E?\3\2\2\2EB\3\2\2\2F\5\3\2"+
		"\2\2GH\5\b\5\2H\7\3\2\2\2IO\5\n\6\2JO\5\24\13\2KO\5\36\20\2LO\5&\24\2"+
		"MO\5\16\b\2NI\3\2\2\2NJ\3\2\2\2NK\3\2\2\2NL\3\2\2\2NM\3\2\2\2O\t\3\2\2"+
		"\2PQ\t\2\2\2Q\13\3\2\2\2RS\7\r\2\2ST\5.\30\2TU\5\b\5\2U\r\3\2\2\2VX\7"+
		"\16\2\2WY\5,\27\2XW\3\2\2\2XY\3\2\2\2YZ\3\2\2\2Z[\7\17\2\2[\\\5\20\t\2"+
		"\\]\7\20\2\2]a\3\2\2\2^_\7\16\2\2_a\5,\27\2`V\3\2\2\2`^\3\2\2\2a\17\3"+
		"\2\2\2be\5\22\n\2cd\7\21\2\2df\5\20\t\2ec\3\2\2\2ef\3\2\2\2f\21\3\2\2"+
		"\2gj\5\60\31\2hi\7\22\2\2ik\5\62\32\2jh\3\2\2\2jk\3\2\2\2k\23\3\2\2\2"+
		"ln\7\23\2\2mo\5,\27\2nm\3\2\2\2no\3\2\2\2op\3\2\2\2pr\7\17\2\2qs\5\26"+
		"\f\2rq\3\2\2\2rs\3\2\2\2st\3\2\2\2tx\7\20\2\2uv\7\23\2\2vx\5,\27\2wl\3"+
		"\2\2\2wu\3\2\2\2x\25\3\2\2\2y{\5\30\r\2z|\5\26\f\2{z\3\2\2\2{|\3\2\2\2"+
		"|\27\3\2\2\2}~\5\32\16\2~\177\7\4\2\2\177\31\3\2\2\2\u0080\u0082\5\b\5"+
		"\2\u0081\u0083\5\34\17\2\u0082\u0081\3\2\2\2\u0082\u0083\3\2\2\2\u0083"+
		"\33\3\2\2\2\u0084\u0085\7\24\2\2\u0085\u0086\5\62\32\2\u0086\u0088\7\25"+
		"\2\2\u0087\u0089\5\34\17\2\u0088\u0087\3\2\2\2\u0088\u0089\3\2\2\2\u0089"+
		"\35\3\2\2\2\u008a\u008c\7\26\2\2\u008b\u008d\5,\27\2\u008c\u008b\3\2\2"+
		"\2\u008c\u008d\3\2\2\2\u008d\u008e\3\2\2\2\u008e\u0090\7\17\2\2\u008f"+
		"\u0091\5 \21\2\u0090\u008f\3\2\2\2\u0090\u0091\3\2\2\2\u0091\u0092\3\2"+
		"\2\2\u0092\u0096\7\20\2\2\u0093\u0094\7\26\2\2\u0094\u0096\5,\27\2\u0095"+
		"\u008a\3\2\2\2\u0095\u0093\3\2\2\2\u0096\37\3\2\2\2\u0097\u0099\5\"\22"+
		"\2\u0098\u009a\5 \21\2\u0099\u0098\3\2\2\2\u0099\u009a\3\2\2\2\u009a!"+
		"\3\2\2\2\u009b\u009c\5$\23\2\u009c\u009d\7\4\2\2\u009d\u00aa\3\2\2\2\u009e"+
		"\u009f\7\27\2\2\u009f\u00a0\5$\23\2\u00a0\u00a1\7\30\2\2\u00a1\u00aa\3"+
		"\2\2\2\u00a2\u00a3\5\f\7\2\u00a3\u00a4\7\4\2\2\u00a4\u00aa\3\2\2\2\u00a5"+
		"\u00a6\7\27\2\2\u00a6\u00a7\5\f\7\2\u00a7\u00a8\7\30\2\2\u00a8\u00aa\3"+
		"\2\2\2\u00a9\u009b\3\2\2\2\u00a9\u009e\3\2\2\2\u00a9\u00a2\3\2\2\2\u00a9"+
		"\u00a5\3\2\2\2\u00aa#\3\2\2\2\u00ab\u00ad\5.\30\2\u00ac\u00ae\5\32\16"+
		"\2\u00ad\u00ac\3\2\2\2\u00ad\u00ae\3\2\2\2\u00ae\u00b5\3\2\2\2\u00af\u00b0"+
		"\5.\30\2\u00b0\u00b1\7\27\2\2\u00b1\u00b2\5\32\16\2\u00b2\u00b3\7\30\2"+
		"\2\u00b3\u00b5\3\2\2\2\u00b4\u00ab\3\2\2\2\u00b4\u00af\3\2\2\2\u00b5%"+
		"\3\2\2\2\u00b6\u00b8\7\31\2\2\u00b7\u00b9\5,\27\2\u00b8\u00b7\3\2\2\2"+
		"\u00b8\u00b9\3\2\2\2\u00b9\u00ba\3\2\2\2\u00ba\u00bc\7\17\2\2\u00bb\u00bd"+
		"\5(\25\2\u00bc\u00bb\3\2\2\2\u00bc\u00bd\3\2\2\2\u00bd\u00be\3\2\2\2\u00be"+
		"\u00c2\7\20\2\2\u00bf\u00c0\7\31\2\2\u00c0\u00c2\5,\27\2\u00c1\u00b6\3"+
		"\2\2\2\u00c1\u00bf\3\2\2\2\u00c2\'\3\2\2\2\u00c3\u00c5\5*\26\2\u00c4\u00c6"+
		"\5(\25\2\u00c5\u00c4\3\2\2\2\u00c5\u00c6\3\2\2\2\u00c6)\3\2\2\2\u00c7"+
		"\u00c9\5.\30\2\u00c8\u00ca\5\32\16\2\u00c9\u00c8\3\2\2\2\u00c9\u00ca\3"+
		"\2\2\2\u00ca\u00cb\3\2\2\2\u00cb\u00cc\7\4\2\2\u00cc\u00d1\3\2\2\2\u00cd"+
		"\u00ce\5\f\7\2\u00ce\u00cf\7\4\2\2\u00cf\u00d1\3\2\2\2\u00d0\u00c7\3\2"+
		"\2\2\u00d0\u00cd\3\2\2\2\u00d1+\3\2\2\2\u00d2\u00d3\7\34\2\2\u00d3-\3"+
		"\2\2\2\u00d4\u00d5\7\36\2\2\u00d5/\3\2\2\2\u00d6\u00d7\7\36\2\2\u00d7"+
		"\61\3\2\2\2\u00d8\u00d9\7 \2\2\u00d9\63\3\2\2\2\349ENX`ejnrw{\u0082\u0088"+
		"\u008c\u0090\u0095\u0099\u00a9\u00ad\u00b4\u00b8\u00bc\u00c1\u00c5\u00c9"+
		"\u00d0";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}
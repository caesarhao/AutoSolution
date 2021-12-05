// Generated from AML.g4 by ANTLR 4.9.3
package a2mljava;
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class AMLLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.9.3", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		Begin=25, End=26, CIdent=27, DigitNum=28, WS=29, Newline=30, BlockComment=31, 
		LineComment=32;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
			"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
			"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "Begin", 
			"End", "CIdent", "DigitNum", "Digit", "NonzeroDigit", "WS", "Newline", 
			"BlockComment", "LineComment"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'A2ML'", "';'", "'char'", "'int'", "'long'", "'uchar'", "'uint'", 
			"'ulong'", "'double'", "'float'", "'block'", "'enum'", "'{'", "'}'", 
			"','", "'='", "'struct'", "'['", "']'", "'taggedstruct'", "'('", "')*;'", 
			"'taggedunion'", "'\"'", "'/begin'", "'/end'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, "Begin", "End", "CIdent", "DigitNum", "WS", "Newline", "BlockComment", 
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


	public AMLLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "AML.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\"\u0105\b\1\4\2\t"+
		"\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31\t\31"+
		"\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t \4!"+
		"\t!\4\"\t\"\4#\t#\3\2\3\2\3\2\3\2\3\2\3\3\3\3\3\4\3\4\3\4\3\4\3\4\3\5"+
		"\3\5\3\5\3\5\3\6\3\6\3\6\3\6\3\6\3\7\3\7\3\7\3\7\3\7\3\7\3\b\3\b\3\b\3"+
		"\b\3\b\3\t\3\t\3\t\3\t\3\t\3\t\3\n\3\n\3\n\3\n\3\n\3\n\3\n\3\13\3\13\3"+
		"\13\3\13\3\13\3\13\3\f\3\f\3\f\3\f\3\f\3\f\3\r\3\r\3\r\3\r\3\r\3\16\3"+
		"\16\3\17\3\17\3\20\3\20\3\21\3\21\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3"+
		"\23\3\23\3\24\3\24\3\25\3\25\3\25\3\25\3\25\3\25\3\25\3\25\3\25\3\25\3"+
		"\25\3\25\3\25\3\26\3\26\3\27\3\27\3\27\3\27\3\30\3\30\3\30\3\30\3\30\3"+
		"\30\3\30\3\30\3\30\3\30\3\30\3\30\3\31\3\31\3\32\3\32\3\32\3\32\3\32\3"+
		"\32\3\32\3\33\3\33\3\33\3\33\3\33\3\34\3\34\7\34\u00c8\n\34\f\34\16\34"+
		"\u00cb\13\34\3\35\3\35\3\35\7\35\u00d0\n\35\f\35\16\35\u00d3\13\35\5\35"+
		"\u00d5\n\35\3\36\3\36\3\37\3\37\3 \6 \u00dc\n \r \16 \u00dd\3 \3 \3!\3"+
		"!\5!\u00e4\n!\3!\5!\u00e7\n!\3!\3!\3\"\3\"\3\"\3\"\7\"\u00ef\n\"\f\"\16"+
		"\"\u00f2\13\"\3\"\3\"\3\"\3\"\3\"\3#\3#\3#\3#\7#\u00fd\n#\f#\16#\u0100"+
		"\13#\3#\3#\3#\3#\4\u00f0\u00fe\2$\3\3\5\4\7\5\t\6\13\7\r\b\17\t\21\n\23"+
		"\13\25\f\27\r\31\16\33\17\35\20\37\21!\22#\23%\24\'\25)\26+\27-\30/\31"+
		"\61\32\63\33\65\34\67\359\36;\2=\2?\37A C!E\"\3\2\7\5\2C\\aac|\6\2\62"+
		";C\\aac|\3\2\62;\3\2\63;\5\2\13\f\17\17\"\"\2\u010a\2\3\3\2\2\2\2\5\3"+
		"\2\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2\2\2\17\3\2\2\2\2"+
		"\21\3\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31\3\2\2\2\2\33\3"+
		"\2\2\2\2\35\3\2\2\2\2\37\3\2\2\2\2!\3\2\2\2\2#\3\2\2\2\2%\3\2\2\2\2\'"+
		"\3\2\2\2\2)\3\2\2\2\2+\3\2\2\2\2-\3\2\2\2\2/\3\2\2\2\2\61\3\2\2\2\2\63"+
		"\3\2\2\2\2\65\3\2\2\2\2\67\3\2\2\2\29\3\2\2\2\2?\3\2\2\2\2A\3\2\2\2\2"+
		"C\3\2\2\2\2E\3\2\2\2\3G\3\2\2\2\5L\3\2\2\2\7N\3\2\2\2\tS\3\2\2\2\13W\3"+
		"\2\2\2\r\\\3\2\2\2\17b\3\2\2\2\21g\3\2\2\2\23m\3\2\2\2\25t\3\2\2\2\27"+
		"z\3\2\2\2\31\u0080\3\2\2\2\33\u0085\3\2\2\2\35\u0087\3\2\2\2\37\u0089"+
		"\3\2\2\2!\u008b\3\2\2\2#\u008d\3\2\2\2%\u0094\3\2\2\2\'\u0096\3\2\2\2"+
		")\u0098\3\2\2\2+\u00a5\3\2\2\2-\u00a7\3\2\2\2/\u00ab\3\2\2\2\61\u00b7"+
		"\3\2\2\2\63\u00b9\3\2\2\2\65\u00c0\3\2\2\2\67\u00c5\3\2\2\29\u00d4\3\2"+
		"\2\2;\u00d6\3\2\2\2=\u00d8\3\2\2\2?\u00db\3\2\2\2A\u00e6\3\2\2\2C\u00ea"+
		"\3\2\2\2E\u00f8\3\2\2\2GH\7C\2\2HI\7\64\2\2IJ\7O\2\2JK\7N\2\2K\4\3\2\2"+
		"\2LM\7=\2\2M\6\3\2\2\2NO\7e\2\2OP\7j\2\2PQ\7c\2\2QR\7t\2\2R\b\3\2\2\2"+
		"ST\7k\2\2TU\7p\2\2UV\7v\2\2V\n\3\2\2\2WX\7n\2\2XY\7q\2\2YZ\7p\2\2Z[\7"+
		"i\2\2[\f\3\2\2\2\\]\7w\2\2]^\7e\2\2^_\7j\2\2_`\7c\2\2`a\7t\2\2a\16\3\2"+
		"\2\2bc\7w\2\2cd\7k\2\2de\7p\2\2ef\7v\2\2f\20\3\2\2\2gh\7w\2\2hi\7n\2\2"+
		"ij\7q\2\2jk\7p\2\2kl\7i\2\2l\22\3\2\2\2mn\7f\2\2no\7q\2\2op\7w\2\2pq\7"+
		"d\2\2qr\7n\2\2rs\7g\2\2s\24\3\2\2\2tu\7h\2\2uv\7n\2\2vw\7q\2\2wx\7c\2"+
		"\2xy\7v\2\2y\26\3\2\2\2z{\7d\2\2{|\7n\2\2|}\7q\2\2}~\7e\2\2~\177\7m\2"+
		"\2\177\30\3\2\2\2\u0080\u0081\7g\2\2\u0081\u0082\7p\2\2\u0082\u0083\7"+
		"w\2\2\u0083\u0084\7o\2\2\u0084\32\3\2\2\2\u0085\u0086\7}\2\2\u0086\34"+
		"\3\2\2\2\u0087\u0088\7\177\2\2\u0088\36\3\2\2\2\u0089\u008a\7.\2\2\u008a"+
		" \3\2\2\2\u008b\u008c\7?\2\2\u008c\"\3\2\2\2\u008d\u008e\7u\2\2\u008e"+
		"\u008f\7v\2\2\u008f\u0090\7t\2\2\u0090\u0091\7w\2\2\u0091\u0092\7e\2\2"+
		"\u0092\u0093\7v\2\2\u0093$\3\2\2\2\u0094\u0095\7]\2\2\u0095&\3\2\2\2\u0096"+
		"\u0097\7_\2\2\u0097(\3\2\2\2\u0098\u0099\7v\2\2\u0099\u009a\7c\2\2\u009a"+
		"\u009b\7i\2\2\u009b\u009c\7i\2\2\u009c\u009d\7g\2\2\u009d\u009e\7f\2\2"+
		"\u009e\u009f\7u\2\2\u009f\u00a0\7v\2\2\u00a0\u00a1\7t\2\2\u00a1\u00a2"+
		"\7w\2\2\u00a2\u00a3\7e\2\2\u00a3\u00a4\7v\2\2\u00a4*\3\2\2\2\u00a5\u00a6"+
		"\7*\2\2\u00a6,\3\2\2\2\u00a7\u00a8\7+\2\2\u00a8\u00a9\7,\2\2\u00a9\u00aa"+
		"\7=\2\2\u00aa.\3\2\2\2\u00ab\u00ac\7v\2\2\u00ac\u00ad\7c\2\2\u00ad\u00ae"+
		"\7i\2\2\u00ae\u00af\7i\2\2\u00af\u00b0\7g\2\2\u00b0\u00b1\7f\2\2\u00b1"+
		"\u00b2\7w\2\2\u00b2\u00b3\7p\2\2\u00b3\u00b4\7k\2\2\u00b4\u00b5\7q\2\2"+
		"\u00b5\u00b6\7p\2\2\u00b6\60\3\2\2\2\u00b7\u00b8\7$\2\2\u00b8\62\3\2\2"+
		"\2\u00b9\u00ba\7\61\2\2\u00ba\u00bb\7d\2\2\u00bb\u00bc\7g\2\2\u00bc\u00bd"+
		"\7i\2\2\u00bd\u00be\7k\2\2\u00be\u00bf\7p\2\2\u00bf\64\3\2\2\2\u00c0\u00c1"+
		"\7\61\2\2\u00c1\u00c2\7g\2\2\u00c2\u00c3\7p\2\2\u00c3\u00c4\7f\2\2\u00c4"+
		"\66\3\2\2\2\u00c5\u00c9\t\2\2\2\u00c6\u00c8\t\3\2\2\u00c7\u00c6\3\2\2"+
		"\2\u00c8\u00cb\3\2\2\2\u00c9\u00c7\3\2\2\2\u00c9\u00ca\3\2\2\2\u00ca8"+
		"\3\2\2\2\u00cb\u00c9\3\2\2\2\u00cc\u00d5\7\62\2\2\u00cd\u00d1\5=\37\2"+
		"\u00ce\u00d0\5;\36\2\u00cf\u00ce\3\2\2\2\u00d0\u00d3\3\2\2\2\u00d1\u00cf"+
		"\3\2\2\2\u00d1\u00d2\3\2\2\2\u00d2\u00d5\3\2\2\2\u00d3\u00d1\3\2\2\2\u00d4"+
		"\u00cc\3\2\2\2\u00d4\u00cd\3\2\2\2\u00d5:\3\2\2\2\u00d6\u00d7\t\4\2\2"+
		"\u00d7<\3\2\2\2\u00d8\u00d9\t\5\2\2\u00d9>\3\2\2\2\u00da\u00dc\t\6\2\2"+
		"\u00db\u00da\3\2\2\2\u00dc\u00dd\3\2\2\2\u00dd\u00db\3\2\2\2\u00dd\u00de"+
		"\3\2\2\2\u00de\u00df\3\2\2\2\u00df\u00e0\b \2\2\u00e0@\3\2\2\2\u00e1\u00e3"+
		"\7\17\2\2\u00e2\u00e4\7\f\2\2\u00e3\u00e2\3\2\2\2\u00e3\u00e4\3\2\2\2"+
		"\u00e4\u00e7\3\2\2\2\u00e5\u00e7\7\f\2\2\u00e6\u00e1\3\2\2\2\u00e6\u00e5"+
		"\3\2\2\2\u00e7\u00e8\3\2\2\2\u00e8\u00e9\b!\2\2\u00e9B\3\2\2\2\u00ea\u00eb"+
		"\7\61\2\2\u00eb\u00ec\7,\2\2\u00ec\u00f0\3\2\2\2\u00ed\u00ef\13\2\2\2"+
		"\u00ee\u00ed\3\2\2\2\u00ef\u00f2\3\2\2\2\u00f0\u00f1\3\2\2\2\u00f0\u00ee"+
		"\3\2\2\2\u00f1\u00f3\3\2\2\2\u00f2\u00f0\3\2\2\2\u00f3\u00f4\7,\2\2\u00f4"+
		"\u00f5\7\61\2\2\u00f5\u00f6\3\2\2\2\u00f6\u00f7\b\"\2\2\u00f7D\3\2\2\2"+
		"\u00f8\u00f9\7\61\2\2\u00f9\u00fa\7\61\2\2\u00fa\u00fe\3\2\2\2\u00fb\u00fd"+
		"\13\2\2\2\u00fc\u00fb\3\2\2\2\u00fd\u0100\3\2\2\2\u00fe\u00ff\3\2\2\2"+
		"\u00fe\u00fc\3\2\2\2\u00ff\u0101\3\2\2\2\u0100\u00fe\3\2\2\2\u0101\u0102"+
		"\7\f\2\2\u0102\u0103\3\2\2\2\u0103\u0104\b#\2\2\u0104F\3\2\2\2\13\2\u00c9"+
		"\u00d1\u00d4\u00dd\u00e3\u00e6\u00f0\u00fe\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}
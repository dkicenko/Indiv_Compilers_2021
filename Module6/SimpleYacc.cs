// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2010
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.3.6
// Machine:  DESKTOP-MQGTEI6
// DateTime: 21.09.2021 3:20:24
// UserName: Jingle
// Input file <SimpleYacc.y>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using QUT.Gppg;
using ProgramTree;

namespace SimpleParser
{
public enum Tokens {
    error=1,EOF=2,BEGIN=3,END=4,CYCLE=5,ASSIGN=6,
    SEMICOLON=7,DO=8,UNTIL=9,TO=10,LBRACKET=11,RBRACKET=12,
    COMMA=13,PLUS=14,MINUS=15,MULT=16,DIVISION=17,THEN=18,
    INUM=19,RNUM=20,ID=21,WHILE=22,REPEAT=23,FOR=24,
    WRITE=25,VAR=26,IF=27,ELSE=28};

public struct ValueType
{ 
			public double dVal; 
			public int iVal; 
			public string sVal; 
			public Node nVal;
			public ExprNode eVal;
			public StatementNode stVal;
			public BlockNode blVal;
			public WhileNode whVal;
			public RepeatNode rVal;
			public ForNode fVal;
			public WriteNode wrVal;
			public VarDefNode vrVal;
			public IfNode ifelVal;
       }
// Abstract base class for GPLEX scanners
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

public class Parser: ShiftReduceParser<ValueType, LexLocation>
{
  // Verbatim content from SimpleYacc.y
// Ёти объ¤влени¤ добавл¤ютс¤ в класс GPPGParser, представл¤ющий собой парсер, генерируемый системой gppg
    public BlockNode root; //  орневой узел синтаксического дерева 
    public Parser(AbstractScanner<ValueType, LexLocation> scanner) : base(scanner) { }
  // End verbatim content from SimpleYacc.y

#pragma warning disable 649
  private static Dictionary<int, string> aliasses;
#pragma warning restore 649
  private static Rule[] rules = new Rule[31];
  private static State[] states = new State[65];
  private static string[] nonTerms = new string[] {
      "expr", "ident", "assign", "statement", "cycle", "stlist", "block", "var", 
      "t", "f", "if", "progr", "$accept", };

  static Parser() {
    states[0] = new State(new int[]{3,4},new int[]{-12,1,-7,3});
    states[1] = new State(new int[]{2,2});
    states[2] = new State(-1);
    states[3] = new State(-2);
    states[4] = new State(new int[]{21,18,3,4,5,31,22,34,23,38,24,43,25,49,27,54,26,60},new int[]{-6,5,-4,42,-3,9,-2,10,-7,29,-5,30,-11,53});
    states[5] = new State(new int[]{4,6,7,7});
    states[6] = new State(-29);
    states[7] = new State(new int[]{21,18,3,4,5,31,22,34,23,38,24,43,25,49,27,54,26,60},new int[]{-4,8,-3,9,-2,10,-7,29,-5,30,-11,53});
    states[8] = new State(-4);
    states[9] = new State(-5);
    states[10] = new State(new int[]{6,11});
    states[11] = new State(new int[]{21,18,19,19,11,20},new int[]{-1,12,-9,28,-10,27,-2,17});
    states[12] = new State(new int[]{14,13,15,23,4,-19,7,-19,9,-19,28,-19,10,-19});
    states[13] = new State(new int[]{21,18,19,19,11,20},new int[]{-9,14,-10,27,-2,17});
    states[14] = new State(new int[]{16,15,17,25,14,-21,15,-21,4,-21,7,-21,9,-21,28,-21,10,-21,12,-21,21,-21,3,-21,5,-21,22,-21,23,-21,24,-21,25,-21,27,-21,26,-21,8,-21,18,-21});
    states[15] = new State(new int[]{21,18,19,19,11,20},new int[]{-10,16,-2,17});
    states[16] = new State(-24);
    states[17] = new State(-26);
    states[18] = new State(-18);
    states[19] = new State(-27);
    states[20] = new State(new int[]{21,18,19,19,11,20},new int[]{-1,21,-9,28,-10,27,-2,17});
    states[21] = new State(new int[]{12,22,14,13,15,23});
    states[22] = new State(-28);
    states[23] = new State(new int[]{21,18,19,19,11,20},new int[]{-9,24,-10,27,-2,17});
    states[24] = new State(new int[]{16,15,17,25,14,-22,15,-22,4,-22,7,-22,9,-22,28,-22,10,-22,12,-22,21,-22,3,-22,5,-22,22,-22,23,-22,24,-22,25,-22,27,-22,26,-22,8,-22,18,-22});
    states[25] = new State(new int[]{21,18,19,19,11,20},new int[]{-10,26,-2,17});
    states[26] = new State(-25);
    states[27] = new State(-23);
    states[28] = new State(new int[]{16,15,17,25,14,-20,15,-20,4,-20,7,-20,9,-20,28,-20,10,-20,12,-20,21,-20,3,-20,5,-20,22,-20,23,-20,24,-20,25,-20,27,-20,26,-20,8,-20,18,-20});
    states[29] = new State(-6);
    states[30] = new State(-7);
    states[31] = new State(new int[]{21,18,19,19,11,20},new int[]{-1,32,-9,28,-10,27,-2,17});
    states[32] = new State(new int[]{14,13,15,23,21,18,3,4,5,31,22,34,23,38,24,43,25,49,27,54,26,60},new int[]{-4,33,-3,9,-2,10,-7,29,-5,30,-11,53});
    states[33] = new State(-30);
    states[34] = new State(new int[]{21,18,19,19,11,20},new int[]{-1,35,-9,28,-10,27,-2,17});
    states[35] = new State(new int[]{8,36,14,13,15,23});
    states[36] = new State(new int[]{21,18,3,4,5,31,22,34,23,38,24,43,25,49,27,54,26,60},new int[]{-4,37,-3,9,-2,10,-7,29,-5,30,-11,53});
    states[37] = new State(-8);
    states[38] = new State(new int[]{21,18,3,4,5,31,22,34,23,38,24,43,25,49,27,54,26,60},new int[]{-6,39,-4,42,-3,9,-2,10,-7,29,-5,30,-11,53});
    states[39] = new State(new int[]{9,40,7,7});
    states[40] = new State(new int[]{21,18,19,19,11,20},new int[]{-1,41,-9,28,-10,27,-2,17});
    states[41] = new State(new int[]{14,13,15,23,4,-9,7,-9,9,-9,28,-9});
    states[42] = new State(-3);
    states[43] = new State(new int[]{21,18},new int[]{-3,44,-2,10});
    states[44] = new State(new int[]{10,45});
    states[45] = new State(new int[]{21,18,19,19,11,20},new int[]{-1,46,-9,28,-10,27,-2,17});
    states[46] = new State(new int[]{8,47,14,13,15,23});
    states[47] = new State(new int[]{21,18,3,4,5,31,22,34,23,38,24,43,25,49,27,54,26,60},new int[]{-4,48,-3,9,-2,10,-7,29,-5,30,-11,53});
    states[48] = new State(-10);
    states[49] = new State(new int[]{11,50});
    states[50] = new State(new int[]{21,18,19,19,11,20},new int[]{-1,51,-9,28,-10,27,-2,17});
    states[51] = new State(new int[]{12,52,14,13,15,23});
    states[52] = new State(-11);
    states[53] = new State(-12);
    states[54] = new State(new int[]{21,18,19,19,11,20},new int[]{-1,55,-9,28,-10,27,-2,17});
    states[55] = new State(new int[]{18,56,14,13,15,23});
    states[56] = new State(new int[]{21,18,3,4,5,31,22,34,23,38,24,43,25,49,27,54,26,60},new int[]{-4,57,-3,9,-2,10,-7,29,-5,30,-11,53});
    states[57] = new State(new int[]{28,58,4,-15,7,-15,9,-15});
    states[58] = new State(new int[]{21,18,3,4,5,31,22,34,23,38,24,43,25,49,27,54,26,60},new int[]{-4,59,-3,9,-2,10,-7,29,-5,30,-11,53});
    states[59] = new State(-14);
    states[60] = new State(new int[]{21,62},new int[]{-8,61});
    states[61] = new State(-13);
    states[62] = new State(new int[]{13,63,4,-16,7,-16,9,-16,28,-16});
    states[63] = new State(new int[]{21,62},new int[]{-8,64});
    states[64] = new State(-17);

    rules[1] = new Rule(-13, new int[]{-12,2});
    rules[2] = new Rule(-12, new int[]{-7});
    rules[3] = new Rule(-6, new int[]{-4});
    rules[4] = new Rule(-6, new int[]{-6,7,-4});
    rules[5] = new Rule(-4, new int[]{-3});
    rules[6] = new Rule(-4, new int[]{-7});
    rules[7] = new Rule(-4, new int[]{-5});
    rules[8] = new Rule(-4, new int[]{22,-1,8,-4});
    rules[9] = new Rule(-4, new int[]{23,-6,9,-1});
    rules[10] = new Rule(-4, new int[]{24,-3,10,-1,8,-4});
    rules[11] = new Rule(-4, new int[]{25,11,-1,12});
    rules[12] = new Rule(-4, new int[]{-11});
    rules[13] = new Rule(-4, new int[]{26,-8});
    rules[14] = new Rule(-11, new int[]{27,-1,18,-4,28,-4});
    rules[15] = new Rule(-11, new int[]{27,-1,18,-4});
    rules[16] = new Rule(-8, new int[]{21});
    rules[17] = new Rule(-8, new int[]{21,13,-8});
    rules[18] = new Rule(-2, new int[]{21});
    rules[19] = new Rule(-3, new int[]{-2,6,-1});
    rules[20] = new Rule(-1, new int[]{-9});
    rules[21] = new Rule(-1, new int[]{-1,14,-9});
    rules[22] = new Rule(-1, new int[]{-1,15,-9});
    rules[23] = new Rule(-9, new int[]{-10});
    rules[24] = new Rule(-9, new int[]{-9,16,-10});
    rules[25] = new Rule(-9, new int[]{-9,17,-10});
    rules[26] = new Rule(-10, new int[]{-2});
    rules[27] = new Rule(-10, new int[]{19});
    rules[28] = new Rule(-10, new int[]{11,-1,12});
    rules[29] = new Rule(-7, new int[]{3,-6,4});
    rules[30] = new Rule(-5, new int[]{5,-1,-4});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
    switch (action)
    {
      case 2: // progr -> block
{ root = ValueStack[ValueStack.Depth-1].blVal; }
        break;
      case 3: // stlist -> statement
{ 
				CurrentSemanticValue.blVal = new BlockNode(ValueStack[ValueStack.Depth-1].stVal); 
			}
        break;
      case 4: // stlist -> stlist, SEMICOLON, statement
{ 
				ValueStack[ValueStack.Depth-3].blVal.Add(ValueStack[ValueStack.Depth-1].stVal); 
				CurrentSemanticValue.blVal = ValueStack[ValueStack.Depth-3].blVal; 
			}
        break;
      case 5: // statement -> assign
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 6: // statement -> block
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].blVal; }
        break;
      case 7: // statement -> cycle
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 8: // statement -> WHILE, expr, DO, statement
{
				CurrentSemanticValue.stVal = new WhileNode(ValueStack[ValueStack.Depth-3].eVal,ValueStack[ValueStack.Depth-1].stVal);
			}
        break;
      case 9: // statement -> REPEAT, stlist, UNTIL, expr
{
				CurrentSemanticValue.stVal = new RepeatNode(ValueStack[ValueStack.Depth-1].eVal,ValueStack[ValueStack.Depth-3].blVal);
			}
        break;
      case 10: // statement -> FOR, assign, TO, expr, DO, statement
{
				CurrentSemanticValue.stVal = new ForNode(ValueStack[ValueStack.Depth-5].stVal,ValueStack[ValueStack.Depth-3].eVal,ValueStack[ValueStack.Depth-1].stVal);
			}
        break;
      case 11: // statement -> WRITE, LBRACKET, expr, RBRACKET
{
			CurrentSemanticValue.stVal = new WriteNode(ValueStack[ValueStack.Depth-2].eVal);
		}
        break;
      case 12: // statement -> if
{
			CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].ifelVal;
		}
        break;
      case 13: // statement -> VAR, var
{
			CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].vrVal;
		}
        break;
      case 14: // if -> IF, expr, THEN, statement, ELSE, statement
{
		CurrentSemanticValue.ifelVal = new IfNode(ValueStack[ValueStack.Depth-5].eVal,ValueStack[ValueStack.Depth-3].stVal,ValueStack[ValueStack.Depth-1].stVal);
	}
        break;
      case 15: // if -> IF, expr, THEN, statement
{
		CurrentSemanticValue.ifelVal = new IfNode(ValueStack[ValueStack.Depth-3].eVal,ValueStack[ValueStack.Depth-1].stVal,null);
	}
        break;
      case 16: // var -> ID
{
			CurrentSemanticValue.vrVal = new VarDefNode(ValueStack[ValueStack.Depth-1].sVal);
		}
        break;
      case 17: // var -> ID, COMMA, var
{
			CurrentSemanticValue.vrVal.Add(ValueStack[ValueStack.Depth-3].sVal);
		}
        break;
      case 18: // ident -> ID
{ CurrentSemanticValue.eVal = new IdNode(ValueStack[ValueStack.Depth-1].sVal); }
        break;
      case 19: // assign -> ident, ASSIGN, expr
{ CurrentSemanticValue.stVal = new AssignNode(ValueStack[ValueStack.Depth-3].eVal as IdNode, ValueStack[ValueStack.Depth-1].eVal); }
        break;
      case 20: // expr -> t
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 21: // expr -> expr, PLUS, t
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal,ValueStack[ValueStack.Depth-1].eVal,'+'); }
        break;
      case 22: // expr -> expr, MINUS, t
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal,ValueStack[ValueStack.Depth-1].eVal,'-'); }
        break;
      case 23: // t -> f
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 24: // t -> t, MULT, f
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal,ValueStack[ValueStack.Depth-1].eVal,'*'); }
        break;
      case 25: // t -> t, DIVISION, f
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal,ValueStack[ValueStack.Depth-1].eVal,'/'); }
        break;
      case 26: // f -> ident
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal as IdNode; }
        break;
      case 27: // f -> INUM
{ CurrentSemanticValue.eVal = new IntNumNode(ValueStack[ValueStack.Depth-1].iVal); }
        break;
      case 28: // f -> LBRACKET, expr, RBRACKET
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-2].eVal; }
        break;
      case 29: // block -> BEGIN, stlist, END
{ CurrentSemanticValue.blVal = ValueStack[ValueStack.Depth-2].blVal; }
        break;
      case 30: // cycle -> CYCLE, expr, statement
{ CurrentSemanticValue.stVal = new CycleNode(ValueStack[ValueStack.Depth-2].eVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
    }
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliasses != null && aliasses.ContainsKey(terminal))
        return aliasses[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}

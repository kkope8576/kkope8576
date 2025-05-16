using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Algorithm.E01.Practice.Classes.Runtime.Practice_04
{
	internal class CP01Practice_04
	{
		public static void Start(string[] args)
		{
			Console.Write("수식 입력 : ");
			string oExpression = Console.ReadLine();

			string oPostfix = InfixToPostfix(oExpression);
			List<string> oTokens = oGet_ExpressToken(oPostfix);
			CNode oRoot = oExpressionTree(oTokens);

			Console.WriteLine("결과 : {0}", GetResult(oRoot));
		}

		private static string oGetToken (string oExpression , int oStrat) 
		{
			var oSb = new StringBuilder();
			string oDigits = "0123456789.";

			for (int i = oStrat; i < oExpression.Length; i++ )
			{
				oSb.Append(oExpression[i]);

				bool blsNum = i + 1 < oExpression.Length;
				blsNum = blsNum && oDigits.Contains(oExpression[i]);
				blsNum = blsNum && oDigits.Contains(oExpression[i+1]);

				if (!blsNum)
				{
					break;
				}

			}
			return oSb.ToString();
		}

		private static int oGetPriority (string oOperator , bool blsPush)
		{
			switch (oOperator[0])
			{
				case '+':
				case '-':
					return 2;

				case '*':
				case '/':
					return 1;
			}

			return (blsPush && oOperator[0] == '(') ? 0 : 3;
		}

		private static string InfixToPostfix(string oExpression)
		{
			int nIdx = 0;
			string nOperators = "+-*/()";

			var oSb = new StringBuilder();
			var oStackOperator = new Stack<string>();

			while ( nIdx < oExpression.Length )
			{ 
				string oToken = oGetToken(oExpression, nIdx);
				nIdx += oToken.Length;

				if (char.IsWhiteSpace(oToken[0]))
				{
					continue;
				}

				if (!nOperators.Contains(oToken[0]))
				{
					oSb.Append($"{oToken} ");
					continue;
				}

				if(oToken[0] == ')')
				{
					while (oStackOperator.Count > 0)
					{
						string nOperator = oStackOperator.Pop();

						if(nOperator[0] == '(')
						{
							break;
						}
						oSb.Append(nOperator);
					}

					continue;
				}

				int nPriority_Token = oGetPriority(oToken, true);

				while (oStackOperator.Count > 0)
				{
					string nOperator = oStackOperator.Pop();
					int nPriority_Operator = oGetPriority(nOperator, false);

					if(nPriority_Token < nPriority_Operator)
					{
						oStackOperator.Push(nOperator);
						break;
					}
					oSb.Append(nOperator);
				}

				oStackOperator.Push(oToken);
			}

			while(oStackOperator.Count > 0)
			{
				oSb.Append(oStackOperator.Pop());
			}

			return oSb.ToString();
		}

		private static List<string> oGet_ExpressToken(string oPostfix)
		{
			var oExToken = new List<string>();
			var oSb = new StringBuilder();

			for (int i = 0;  i < oPostfix.Length; i++)
			{
				char ch = oPostfix[i];

				if ( char.IsWhiteSpace(ch))
				{
					if ( oSb.Length > 0 )
					{
						oExToken.Add(oSb.ToString());
						oSb.Clear();
					}
				}
				else
				{
					oSb.Append(ch);
				}
			}
			if (oSb.Length > 0 )
			{
				oExToken.Add(oSb.ToString());
			}
			return oExToken;
		}

		public class CNode
		{
			public string Value;
			public CNode Node_LChild = null;
			public CNode Node_RChild = null;

			public bool blsOperator()
			{
				return "+-*/".Contains(Value);
			}
		}

		private static CNode oExpressionTree(List<string> oExToken)
		{
			var oStack = new Stack<CNode>();

			for (int i = 0; i < oExToken.Count; i++)
			{
				string token = oExToken[i];
				var oNode = new CNode { Value = token };

				if (oNode.blsOperator())
				{
					oNode.Node_RChild = oStack.Pop();
					oNode.Node_LChild = oStack.Pop();
				}

				oStack.Push(oNode);
			}

			return oStack.Pop();
		}

		private static double GetResult(CNode oNode)
		{
			if (!oNode.blsOperator())
			{
				return double.Parse(oNode.Value);
			}

			double nLeft = GetResult(oNode.Node_LChild);
			double nRight = GetResult(oNode.Node_RChild);

			return oNode.Value switch
			{
				"+" => nLeft + nRight,
				"-" => nLeft - nRight,
				"*" => nLeft * nRight,
				"/" => nLeft / nRight
			};
		}
	}
}

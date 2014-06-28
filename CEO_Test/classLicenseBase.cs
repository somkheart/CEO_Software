using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Runtime.CompilerServices;
namespace PG.SerialKeyMaker.Utility.API
{
	public abstract class classLicenseBase
	{
		private string A;
		private string a;
		private int A;
		private string B;
		private int a;
		private classLogging A;
		private string b;
		private string[,,] A;
		private int B;
		private const string C = "4.0.0.2";
		internal classLicenseBase()
		{
			this.A = PP.A();
			this.a = PP.B();
			this.A = 2;
			this.B = PP.a();
			this.a = 128;
			this.b = string.Empty;
			this.A = new string[11, 4, 5];
		}
		internal classLicenseBase(classLogging p_objLogObject)
		{
			this.A = PP.A();
			this.a = PP.B();
			this.A = 2;
			this.B = PP.a();
			this.a = 128;
			this.b = string.Empty;
			this.A = new string[11, 4, 5];
			this.A = p_objLogObject;
		}
		internal classLicenseBase(string p_strPrivateKey, classLogging p_objLogObject)
		{
			this.A = PP.A();
			this.a = PP.B();
			this.A = 2;
			this.B = PP.a();
			this.a = 128;
			this.b = string.Empty;
			this.A = new string[11, 4, 5];
			this.A = p_objLogObject;
			if (string.IsNullOrEmpty(p_strPrivateKey))
			{
				throw new Exception("Invalid Private Key.");
			}
			this.b = Strings.Left(p_strPrivateKey, 25);
		}
		internal string[,,] A()
		{
			if (this.A(this.A))
			{
				this.A = this.C();
			}
			return this.A;
		}
		protected internal int a()
		{
			return 999;
		}
		protected internal string B()
		{
			return this.b;
		}
		protected internal void A(string value)
		{
			this.b = value;
		}
		internal classLogging b()
		{
			return this.A;
		}
		internal void A(classLogging value)
		{
			this.A = value;
		}
		private string[,,] C()
		{
			string[,,] array = new string[11, 3, 5];
			array[0, 0, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aA();
			array[0, 1, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aa();
			array[0, 2, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aB();
			array[1, 0, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ab();
			array[1, 1, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aC();
			array[1, 2, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ac();
			array[2, 0, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aD();
			array[2, 1, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ad();
			array[2, 2, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aE();
			array[3, 0, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ae();
			array[3, 1, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aF();
			array[3, 2, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.af();
			array[4, 0, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aG();
			array[4, 1, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ag();
			array[4, 2, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aH();
			array[5, 0, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ah();
			array[5, 1, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aI();
			array[5, 2, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ai();
			array[6, 0, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aJ();
			array[6, 1, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aj();
			array[6, 2, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aj();
			array[7, 0, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aK();
			array[7, 1, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ak();
			array[7, 2, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aK();
			array[8, 0, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aL();
			array[8, 1, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.al();
			array[8, 2, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.al();
			array[9, 0, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aM();
			array[9, 1, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.am();
			array[9, 2, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aM();
			array[10, 0, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aH();
			array[10, 1, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ai();
			array[10, 2, 0] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ai();
			array[0, 0, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aB();
			array[0, 1, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aD();
			array[0, 2, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ab();
			array[1, 0, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ai();
			array[1, 1, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aj();
			array[1, 2, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aa();
			array[2, 0, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aL();
			array[2, 1, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ac();
			array[2, 2, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aE();
			array[3, 0, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aH();
			array[3, 1, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.af();
			array[3, 2, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aG();
			array[4, 0, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ah();
			array[4, 1, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ad();
			array[4, 2, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aF();
			array[5, 0, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ak();
			array[5, 1, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.am();
			array[5, 2, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aC();
			array[6, 0, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ae();
			array[6, 1, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.al();
			array[6, 2, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.al();
			array[7, 0, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aJ();
			array[7, 1, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aA();
			array[7, 2, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aJ();
			array[8, 0, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ag();
			array[8, 1, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aI();
			array[8, 2, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aI();
			array[9, 0, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aM();
			array[9, 1, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aK();
			array[9, 2, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aM();
			array[10, 0, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aF();
			array[10, 1, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aC();
			array[10, 2, 1] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aF();
			array[0, 0, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aI();
			array[0, 1, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aC();
			array[0, 2, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ad();
			array[1, 0, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aE();
			array[1, 1, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.al();
			array[1, 2, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aM();
			array[2, 0, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aL();
			array[2, 1, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ac();
			array[2, 2, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aa();
			array[3, 0, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ak();
			array[3, 1, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aF();
			array[3, 2, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aG();
			array[4, 0, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ae();
			array[4, 1, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aH();
			array[4, 2, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ab();
			array[5, 0, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ah();
			array[5, 1, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ag();
			array[5, 2, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aB();
			array[6, 0, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aD();
			array[6, 1, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aA();
			array[6, 2, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aD();
			array[7, 0, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aK();
			array[7, 1, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aj();
			array[7, 2, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aj();
			array[8, 0, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aJ();
			array[8, 1, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ai();
			array[8, 2, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ai();
			array[9, 0, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.af();
			array[9, 1, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.am();
			array[9, 2, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.af();
			array[10, 0, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ab();
			array[10, 1, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aB();
			array[10, 2, 2] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ab();
			array[0, 0, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ad();
			array[0, 1, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aB();
			array[0, 2, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aF();
			array[1, 0, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aJ();
			array[1, 1, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aL();
			array[1, 2, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aA();
			array[2, 0, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aD();
			array[2, 1, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ab();
			array[2, 2, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ag();
			array[3, 0, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.af();
			array[3, 1, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ak();
			array[3, 2, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aa();
			array[4, 0, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aK();
			array[4, 1, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ae();
			array[4, 2, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aE();
			array[5, 0, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ai();
			array[5, 1, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aM();
			array[5, 2, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ac();
			array[6, 0, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aH();
			array[6, 1, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aG();
			array[6, 2, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aH();
			array[7, 0, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aC();
			array[7, 1, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.am();
			array[7, 2, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aC();
			array[8, 0, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aj();
			array[8, 1, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.al();
			array[8, 2, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.al();
			array[9, 0, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ah();
			array[9, 1, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aI();
			array[9, 2, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ah();
			array[10, 0, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aE();
			array[10, 1, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ac();
			array[10, 2, 3] = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ac();
			return array;
		}
		private string A(string p_strLetter, int p_intSeries)
		{
			string result = string.Empty;
			if (p_intSeries == 0)
			{
				if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aA(), false) != 0)
				{
					if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aa(), false) != 0)
					{
						if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aB(), false) != 0)
						{
							if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ab(), false) != 0)
							{
								if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aC(), false) != 0)
								{
									if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ac(), false) != 0)
									{
										if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aD(), false) != 0)
										{
											if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ad(), false) != 0)
											{
												if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aE(), false) != 0)
												{
													if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ae(), false) != 0)
													{
														if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aF(), false) != 0)
														{
															if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.af(), false) != 0)
															{
																if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aG(), false) != 0)
																{
																	if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ag(), false) != 0)
																	{
																		if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aH(), false) != 0)
																		{
																			if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ah(), false) != 0)
																			{
																				if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aI(), false) != 0)
																				{
																					if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ai(), false) != 0)
																					{
																						if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aJ(), false) != 0)
																						{
																							if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aj(), false) != 0)
																							{
																								if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aj(), false) != 0)
																								{
																									if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aK(), false) != 0)
																									{
																										if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ak(), false) != 0)
																										{
																											if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aK(), false) != 0)
																											{
																												if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aL(), false) != 0)
																												{
																													if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.al(), false) != 0)
																													{
																														if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.al(), false) != 0)
																														{
																															if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aM(), false) != 0)
																															{
																																if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.am(), false) != 0)
																																{
																																	if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aM(), false) != 0)
																																	{
																																		goto IL_248;
																																	}
																																}
																															}
																															result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ar();
																															goto IL_248;
																														}
																													}
																												}
																												result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aR();
																												goto IL_248;
																											}
																										}
																									}
																									result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aq();
																									goto IL_248;
																								}
																							}
																						}
																						result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aQ();
																						goto IL_248;
																					}
																				}
																			}
																			result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ap();
																			goto IL_248;
																		}
																	}
																}
																result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aP();
																goto IL_248;
															}
														}
													}
													result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ao();
													goto IL_248;
												}
											}
										}
										result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aO();
										goto IL_248;
									}
								}
							}
							result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.an();
							goto IL_248;
						}
					}
				}
				result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aN();
			}
			IL_248:
			if (p_intSeries == 1)
			{
				if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aB(), false) != 0)
				{
					if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aD(), false) != 0)
					{
						if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ab(), false) != 0)
						{
							if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ai(), false) != 0)
							{
								if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aj(), false) != 0)
								{
									if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aa(), false) != 0)
									{
										if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aL(), false) != 0)
										{
											if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ac(), false) != 0)
											{
												if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aE(), false) != 0)
												{
													if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aH(), false) != 0)
													{
														if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.af(), false) != 0)
														{
															if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aG(), false) != 0)
															{
																if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ah(), false) != 0)
																{
																	if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ad(), false) != 0)
																	{
																		if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aF(), false) != 0)
																		{
																			if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ak(), false) != 0)
																			{
																				if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.am(), false) != 0)
																				{
																					if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aC(), false) != 0)
																					{
																						if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ae(), false) != 0)
																						{
																							if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.al(), false) != 0)
																							{
																								if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.al(), false) != 0)
																								{
																									if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aJ(), false) != 0)
																									{
																										if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aA(), false) != 0)
																										{
																											if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aJ(), false) != 0)
																											{
																												if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ag(), false) != 0)
																												{
																													if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aI(), false) != 0)
																													{
																														if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aI(), false) != 0)
																														{
																															if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aM(), false) != 0)
																															{
																																if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aK(), false) != 0)
																																{
																																	if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aM(), false) != 0)
																																	{
																																		goto IL_48A;
																																	}
																																}
																															}
																															result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ar();
																															goto IL_48A;
																														}
																													}
																												}
																												result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aR();
																												goto IL_48A;
																											}
																										}
																									}
																									result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aq();
																									goto IL_48A;
																								}
																							}
																						}
																						result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aQ();
																						goto IL_48A;
																					}
																				}
																			}
																			result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ap();
																			goto IL_48A;
																		}
																	}
																}
																result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aP();
																goto IL_48A;
															}
														}
													}
													result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ao();
													goto IL_48A;
												}
											}
										}
										result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aO();
										goto IL_48A;
									}
								}
							}
							result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.an();
							goto IL_48A;
						}
					}
				}
				result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aN();
			}
			IL_48A:
			if (p_intSeries == 2)
			{
				if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aI(), false) != 0)
				{
					if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aC(), false) != 0)
					{
						if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ad(), false) != 0)
						{
							if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aE(), false) != 0)
							{
								if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.al(), false) != 0)
								{
									if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aM(), false) != 0)
									{
										if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aL(), false) != 0)
										{
											if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ac(), false) != 0)
											{
												if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aa(), false) != 0)
												{
													if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ak(), false) != 0)
													{
														if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aF(), false) != 0)
														{
															if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aG(), false) != 0)
															{
																if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ae(), false) != 0)
																{
																	if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aH(), false) != 0)
																	{
																		if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ab(), false) != 0)
																		{
																			if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ah(), false) != 0)
																			{
																				if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ag(), false) != 0)
																				{
																					if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aB(), false) != 0)
																					{
																						if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aD(), false) != 0)
																						{
																							if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aA(), false) != 0)
																							{
																								if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aD(), false) != 0)
																								{
																									if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aK(), false) != 0)
																									{
																										if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aj(), false) != 0)
																										{
																											if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aj(), false) != 0)
																											{
																												if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aJ(), false) != 0)
																												{
																													if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ai(), false) != 0)
																													{
																														if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ai(), false) != 0)
																														{
																															if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.af(), false) != 0)
																															{
																																if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.am(), false) != 0)
																																{
																																	if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.af(), false) != 0)
																																	{
																																		goto IL_6EB;
																																	}
																																}
																															}
																															result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ar();
																															goto IL_6EB;
																														}
																													}
																												}
																												result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aR();
																												goto IL_6EB;
																											}
																										}
																									}
																									result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aq();
																									goto IL_6EB;
																								}
																							}
																						}
																						result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aQ();
																						goto IL_6EB;
																					}
																				}
																			}
																			result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ap();
																			goto IL_6EB;
																		}
																	}
																}
																result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aP();
																goto IL_6EB;
															}
														}
													}
													result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ao();
													goto IL_6EB;
												}
											}
										}
										result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aO();
										goto IL_6EB;
									}
								}
							}
							result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.an();
							goto IL_6EB;
						}
					}
				}
				result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aN();
			}
			IL_6EB:
			if (p_intSeries == 3)
			{
				if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ad(), false) != 0)
				{
					if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aB(), false) != 0)
					{
						if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aF(), false) != 0)
						{
							if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aJ(), false) != 0)
							{
								if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aL(), false) != 0)
								{
									if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aA(), false) != 0)
									{
										if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aD(), false) != 0)
										{
											if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ab(), false) != 0)
											{
												if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ag(), false) != 0)
												{
													if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.af(), false) != 0)
													{
														if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ak(), false) != 0)
														{
															if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aa(), false) != 0)
															{
																if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aK(), false) != 0)
																{
																	if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ae(), false) != 0)
																	{
																		if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aE(), false) != 0)
																		{
																			if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ai(), false) != 0)
																			{
																				if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aM(), false) != 0)
																				{
																					if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ac(), false) != 0)
																					{
																						if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aH(), false) != 0)
																						{
																							if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aG(), false) != 0)
																							{
																								if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aH(), false) != 0)
																								{
																									if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aC(), false) != 0)
																									{
																										if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.am(), false) != 0)
																										{
																											if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aC(), false) != 0)
																											{
																												if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aj(), false) != 0)
																												{
																													if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.al(), false) != 0)
																													{
																														if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.al(), false) != 0)
																														{
																															if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ah(), false) != 0)
																															{
																																if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aI(), false) != 0)
																																{
																																	if (Operators.CompareString(p_strLetter, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ah(), false) != 0)
																																	{
																																		return result;
																																	}
																																}
																															}
																															result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ar();
																															return result;
																														}
																													}
																												}
																												result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aR();
																												return result;
																											}
																										}
																									}
																									result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aq();
																									return result;
																								}
																							}
																						}
																						result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aQ();
																						return result;
																					}
																				}
																			}
																			result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ap();
																			return result;
																		}
																	}
																}
																result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aP();
																return result;
															}
														}
													}
													result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ao();
													return result;
												}
											}
										}
										result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aO();
										return result;
									}
								}
							}
							result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.an();
							return result;
						}
					}
				}
				result = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aN();
			}
			return result;
		}
		private bool A(int p_intFeatureCode, int p_intCurrentLevel)
		{
			bool result = false;
			if (p_intFeatureCode == 2)
			{
				result = (p_intCurrentLevel == 1);
			}
			else
			{
				if (p_intFeatureCode == 4)
				{
					result = (p_intCurrentLevel == 1 || p_intCurrentLevel == 2);
				}
				else
				{
					if (p_intFeatureCode == 8)
					{
						result = (p_intCurrentLevel == 1 || p_intCurrentLevel == 2 || p_intCurrentLevel == 3);
					}
					else
					{
						if (p_intFeatureCode == 16)
						{
							result = (p_intCurrentLevel == 1 || p_intCurrentLevel == 2 || p_intCurrentLevel == 3 || p_intCurrentLevel == 4);
						}
						else
						{
							if (p_intFeatureCode == 32)
							{
								result = true;
							}
						}
					}
				}
			}
			return result;
		}
		private bool A(string[,,] p_arIN)
		{
			bool result;
			try
			{
				if (p_arIN == null)
				{
					result = true;
				}
				else
				{
					if (p_arIN[0, 0, 0] == null)
					{
						result = true;
					}
				}
			}
			catch (Exception expr_16)
			{
				ProjectData.SetProjectError(expr_16);
				result = true;
				ProjectData.ClearProjectError();
			}
			return result;
		}
		private string a(string Version)
		{
			int num = Strings.InStr(Version, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aS(), CompareMethod.Binary);
			checked
			{
				string result;
				if (num > 0)
				{
					string str = Strings.Left(Version, num - 1);
					short num2 = (short)Strings.InStr(num + 1, Version, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aS(), CompareMethod.Binary);
					string str2;
					if (num2 > 0)
					{
						str2 = Strings.Mid(Version, num + 1, (int)num2 - (num + 1));
					}
					else
					{
						str2 = Strings.Mid(Version, num + 1);
					}
					result = str + <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aS() + str2;
				}
				else
				{
					result = Version;
				}
				return result;
			}
		}
		private string B(string p_strIN)
		{
			string text = string.Empty;
			ArrayList arrayList = new ArrayList();
			char[] array = p_strIN.ToCharArray();
			arrayList.Add(modMain.SafeString(array[11]));
			arrayList.Add(modMain.SafeString(array[4]));
			arrayList.Add(modMain.SafeString(array[0]));
			arrayList.Add(modMain.SafeString(array[18]));
			arrayList.Add(modMain.SafeString(array[14]));
			arrayList.Add(modMain.SafeString(array[5]));
			arrayList.Add(modMain.SafeString(array[8]));
			arrayList.Add(modMain.SafeString(array[13]));
			arrayList.Add(modMain.SafeString(array[15]));
			arrayList.Add(modMain.SafeString(array[9]));
			arrayList.Add(modMain.SafeString(array[2]));
			arrayList.Add(modMain.SafeString(array[12]));
			arrayList.Add(modMain.SafeString(array[17]));
			arrayList.Add(modMain.SafeString(array[16]));
			arrayList.Add(modMain.SafeString(array[6]));
			try
			{
				IEnumerator enumerator = arrayList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string str = Conversions.ToString(enumerator.Current);
					text += str;
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return text;
		}
		private string a(string p_strIN, int p_intUnlockCode)
		{
			string text = string.Empty;
			ArrayList arrayList = new ArrayList();
			string text2 = this.D();
			string p_objIn = this.d(text2);
			string text3 = this.D();
			string p_objIn2 = this.d(text3);
			char[] array = p_strIN.ToCharArray();
			string text4 = this.a(p_intUnlockCode);
			string p_objIn3 = this.d(text4);
			arrayList.Add(modMain.SafeString(array[2]));
			arrayList.Add(modMain.SafeString(text2));
			arrayList.Add(modMain.SafeString(array[10]));
			arrayList.Add(modMain.SafeString(text4));
			arrayList.Add(modMain.SafeString(array[1]));
			arrayList.Add(modMain.SafeString(array[5]));
			arrayList.Add(modMain.SafeString(text3));
			arrayList.Add(modMain.SafeString(p_objIn2));
			arrayList.Add(modMain.SafeString(array[6]));
			arrayList.Add(modMain.SafeString(array[9]));
			arrayList.Add(modMain.SafeString(p_objIn3));
			arrayList.Add(modMain.SafeString(array[0]));
			arrayList.Add(modMain.SafeString(array[11]));
			arrayList.Add(modMain.SafeString(array[7]));
			arrayList.Add(modMain.SafeString(array[4]));
			arrayList.Add(modMain.SafeString(array[8]));
			arrayList.Add(modMain.SafeString(array[13]));
			arrayList.Add(modMain.SafeString(array[12]));
			arrayList.Add(modMain.SafeString(array[3]));
			arrayList.Add(modMain.SafeString(p_objIn));
			try
			{
				IEnumerator enumerator = arrayList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string str = Conversions.ToString(enumerator.Current);
					text += str;
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return text;
		}
		private int c()
		{
			int num;
			try
			{
				VBMath.Randomize(300215.0);
				num = checked((int)Math.Round((double)unchecked(6000f * VBMath.Rnd() + 1f)));
				if (num > 4000)
				{
					num = 2;
				}
				else
				{
					if (num > 2000)
					{
						num = 1;
					}
					else
					{
						num = 0;
					}
				}
			}
			catch (Exception expr_44)
			{
				ProjectData.SetProjectError(expr_44);
				Exception ex = expr_44;
				this.b().LogRuntimeError(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.@as(), ex.ToString(), ex.StackTrace);
				ProjectData.ClearProjectError();
			}
			return num;
		}
		private int A(int p_intNumber)
		{
			int result = 0;
			int num = this.c();
			if (p_intNumber == 2)
			{
				if (num == 0)
				{
					result = 2;
				}
				if (num == 1)
				{
					result = 21;
				}
				if (num == 2)
				{
					result = 16;
				}
			}
			else
			{
				if (p_intNumber == 4)
				{
					if (num == 0)
					{
						result = 18;
					}
					if (num == 1)
					{
						result = 17;
					}
					if (num == 2)
					{
						result = 4;
					}
				}
				else
				{
					if (p_intNumber == 8)
					{
						if (num == 0)
						{
							result = 13;
						}
						if (num == 1)
						{
							result = 20;
						}
						if (num == 2)
						{
							result = 3;
						}
					}
					else
					{
						if (p_intNumber == 16)
						{
							if (num == 0)
							{
								result = 15;
							}
							if (num == 1)
							{
								result = 5;
							}
							if (num == 2)
							{
								result = 7;
							}
						}
						else
						{
							if (p_intNumber == 32)
							{
								if (num == 0)
								{
									result = 8;
								}
								if (num == 1)
								{
									result = 10;
								}
								if (num == 2)
								{
									result = 12;
								}
							}
							else
							{
								if (num == 0)
								{
									result = 1;
								}
								if (num == 1)
								{
									result = 24;
								}
								if (num == 2)
								{
									result = 19;
								}
							}
						}
					}
				}
			}
			return result;
		}
		private string a(int p_intNumber)
		{
			string result = string.Empty;
			try
			{
				if (p_intNumber == 0 || p_intNumber < 0)
				{
					p_intNumber = 0;
				}
				int charCode = checked(65 + this.A(p_intNumber));
				result = modMain.SafeString(Strings.Chr(charCode));
			}
			catch (Exception expr_31)
			{
				ProjectData.SetProjectError(expr_31);
				ProjectData.ClearProjectError();
			}
			return result;
		}
		private byte[] A(byte[] p_bteArray)
		{
			checked
			{
				byte[] array;
				try
				{
					int num = p_bteArray.Length;
					array = new byte[num - 1 + 1];
					p_bteArray.CopyTo(array, 0);
					int num2 = p_bteArray.Length;
					while (num2 >= 0 && p_bteArray[num2 - 1] == 0)
					{
						num--;
						array = (byte[])Utils.CopyArray((Array)array, new byte[num - 1 + 1]);
						num2 += -1;
					}
				}
				catch (Exception expr_50)
				{
					ProjectData.SetProjectError(expr_50);
					array = p_bteArray;
					ProjectData.ClearProjectError();
				}
				return array;
			}
		}
		internal ValidatedKey B(string EncryptedString, int p_intMachineKey)
		{
			return this.c(EncryptedString, p_intMachineKey);
		}
		internal ValidatedKey b(string p_strEncryptedKey, int p_intMachineKey)
		{
			return this.D(p_strEncryptedKey, p_intMachineKey);
		}
		internal bool b(string p_strIN)
		{
			return this.e(p_strIN);
		}
		internal int C(string p_strIN)
		{
			return this.F(p_strIN);
		}
		internal int c(string p_strLetter)
		{
			return this.f(p_strLetter);
		}
		internal bool A(string p_strA, string p_strB)
		{
			return this.b(p_strA, p_strB);
		}
		internal string D(string EncryptedText)
		{
			return this.G(EncryptedText);
		}
		internal string C(string plainText, int p_intUnlockCode)
		{
			return this.d(plainText, p_intUnlockCode);
		}
		internal string d(string p_UnLetter)
		{
			return this.g(p_UnLetter);
		}
		internal string a(int p_intNumber, int p_intSeries)
		{
			return this.B(p_intNumber, p_intSeries);
		}
		internal string D()
		{
			return this.d();
		}
		internal static string E(string p_strPublicKey)
		{
			return classLicenseBase.H(p_strPublicKey);
		}
		internal string a(string plainText, string p_strSaltValue)
		{
			return this.C(plainText, p_strSaltValue);
		}
		internal byte[] A(byte[] p_bteData, string p_strSaltValue)
		{
			return this.a(p_bteData, p_strSaltValue);
		}
		internal byte[] A(byte[] p_bteData, string p_strSaltValue, int p_intFileBufferLength)
		{
			return this.a(p_bteData, p_strSaltValue, p_intFileBufferLength);
		}
		internal string B(string cipherText, string p_strSaltValue)
		{
			return this.c(cipherText, p_strSaltValue);
		}
		internal string A(string p_strPrivateKey, int p_intNumberOfDays, classLicense.FeaturesUnlocked p_intUnlockCode)
		{
			return this.a(p_strPrivateKey, p_intNumberOfDays, p_intUnlockCode);
		}
		private ValidatedKey c(string EncryptedString, int p_intMachineKey)
		{
			return this.b(EncryptedString, p_intMachineKey);
		}
		private ValidatedKey D(string p_strEncryptedKey, int p_intMachineKey)
		{
			ValidatedKey validatedKey = new ValidatedKey();
			string str = string.Empty;
			string text = string.Empty;
			DateTime dateTime = DateAndTime.Now;
			DateTime dateTime2 = DateAndTime.DateAdd(DateInterval.Day, -1.0, DateAndTime.Now);
			string value = string.Empty;
			string value2 = string.Empty;
			string value3 = string.Empty;
			bool flag = false;
			string value4 = string.Empty;
			int num = -1;
			string text2 = string.Empty;
			string text3 = string.Empty;
			string freeformText = string.Empty;
			try
			{
				validatedKey.ValidVersion = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aT();
				if (p_strEncryptedKey.Length > 23)
				{
					text2 = this.B(p_strEncryptedKey, this.b);
					if (string.IsNullOrEmpty(text2))
					{
						throw new Exception(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.at());
					}
					text3 = text2.Substring(0, 23);
					freeformText = text2.Substring(23);
				}
				else
				{
					text3 = p_strEncryptedKey;
				}
				validatedKey.FreeformText = freeformText;
				validatedKey.Key = text3;
				str = this.D(text3);
				text = Strings.Left(str, 6);
				int num2 = Conversions.ToInteger(Strings.Mid(str, 7, 3));
				value4 = Strings.Mid(str, 10, 5);
				value = text.Substring(0, 2);
				value2 = text.Substring(2, 2);
				value3 = text.Substring(4, 2);
				dateTime = DateAndTime.DateSerial(Conversions.ToInteger(value3), Conversions.ToInteger(value), Conversions.ToInteger(value2));
				dateTime2 = DateAndTime.DateAdd(DateInterval.Day, (double)num2, dateTime);
				validatedKey.DateCreated = dateTime;
				validatedKey.DateValidThrough = dateTime2;
				flag = this.b(text3);
				if (flag)
				{
					int p_intFeatureCode = this.C(text3);
					validatedKey.Feature1 = this.A(p_intFeatureCode, 1);
					validatedKey.Feature2 = this.A(p_intFeatureCode, 2);
					validatedKey.Feature3 = this.A(p_intFeatureCode, 3);
					validatedKey.Feature4 = this.A(p_intFeatureCode, 4);
					validatedKey.Feature5 = this.A(p_intFeatureCode, 5);
				}
				try
				{
					num = Conversions.ToInteger(classLicenseBase.E(this.b));
				}
				catch (Exception expr_1D8)
				{
					ProjectData.SetProjectError(expr_1D8);
					ProjectData.ClearProjectError();
				}
				int num3 = p_intMachineKey;
				if (num3 <= 0)
				{
					num3 = 0;
				}
				try
				{
					int num4 = Conversions.ToInteger(value4);
					validatedKey.PublicKeyValidates = (num4 == num | num4 == checked(num + num3));
				}
				catch (Exception expr_215)
				{
					ProjectData.SetProjectError(expr_215);
					validatedKey.PublicKeyValidates = false;
					ProjectData.ClearProjectError();
				}
				validatedKey.MachineCodeValidates = validatedKey.PublicKeyValidates;
				if (DateAndTime.DateDiff(DateInterval.Day, dateTime, dateTime2, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) == (long)this.a())
				{
					validatedKey.IsCurrentlyValid = (true & flag & validatedKey.PublicKeyValidates);
					if (validatedKey.IsCurrentlyValid)
					{
						validatedKey.Expires = false;
					}
					else
					{
						validatedKey.Expires = true;
					}
				}
				else
				{
					validatedKey.IsCurrentlyValid = (DateTime.Compare(DateAndTime.Now, dateTime) > 0 & DateTime.Compare(DateAndTime.Now, dateTime2) < 0 & flag & validatedKey.PublicKeyValidates);
					validatedKey.Expires = true;
				}
				if (!validatedKey.IsCurrentlyValid)
				{
					validatedKey.DateCreated = DateAndTime.Now;
					validatedKey.DateValidThrough = DateAndTime.Now.AddDays(-1.0);
					validatedKey.IsCurrentlyValid = false;
					validatedKey.Expires = true;
					validatedKey.PublicKeyValidates = false;
					validatedKey.Feature1 = false;
					validatedKey.Feature2 = false;
					validatedKey.Feature3 = false;
					validatedKey.Feature4 = false;
					validatedKey.Feature5 = false;
				}
			}
			catch (Exception expr_32A)
			{
				ProjectData.SetProjectError(expr_32A);
				validatedKey.DateCreated = DateAndTime.Now;
				validatedKey.DateValidThrough = DateAndTime.Now.AddDays(-1.0);
				validatedKey.IsCurrentlyValid = false;
				validatedKey.Expires = true;
				validatedKey.PublicKeyValidates = false;
				validatedKey.Key = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aU();
				validatedKey.Feature1 = false;
				validatedKey.Feature2 = false;
				validatedKey.Feature3 = false;
				validatedKey.Feature4 = false;
				validatedKey.Feature5 = false;
				ProjectData.ClearProjectError();
			}
			return validatedKey;
		}
		private bool e(string p_strIN)
		{
			bool flag = false;
			ArrayList arrayList = new ArrayList();
			try
			{
				p_strIN = modMain.RemoveReadability(p_strIN);
				char[] array = p_strIN.ToCharArray();
				if (array != null && Information.UBound(array, 1) > 0)
				{
					flag = this.A(modMain.SafeString(array[1]), modMain.SafeString(array[19]));
					flag &= this.A(modMain.SafeString(array[3]), modMain.SafeString(array[10]));
					flag &= this.A(modMain.SafeString(array[6]), modMain.SafeString(array[7]));
				}
				else
				{
					flag = false;
				}
			}
			catch (Exception expr_93)
			{
				ProjectData.SetProjectError(expr_93);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}
		private int F(string p_strIN)
		{
			int result = 0;
			ArrayList arrayList = new ArrayList();
			try
			{
				p_strIN = modMain.RemoveReadability(p_strIN);
				char[] array = p_strIN.ToCharArray();
				if (array != null && Information.UBound(array, 1) > 0)
				{
					if (this.A(modMain.SafeString(array[3]), modMain.SafeString(array[10])))
					{
						result = this.c(modMain.SafeString(array[3]));
					}
				}
				else
				{
					result = 0;
				}
			}
			catch (Exception expr_61)
			{
				ProjectData.SetProjectError(expr_61);
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}
		private int f(string p_strLetter)
		{
			int result = 0;
			try
			{
				switch (checked(Strings.Asc(p_strLetter) - 65))
				{
				case 2:
				case 16:
				case 21:
					result = 2;
					return result;
				case 3:
				case 13:
				case 20:
					result = 8;
					return result;
				case 4:
				case 17:
				case 18:
					result = 4;
					return result;
				case 5:
				case 7:
				case 15:
					result = 16;
					return result;
				case 8:
				case 10:
				case 12:
					result = 32;
					return result;
				}
				result = 0;
			}
			catch (Exception expr_82)
			{
				ProjectData.SetProjectError(expr_82);
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}
		private bool b(string p_strA, string p_strB)
		{
			bool result = false;
			try
			{
				int num = Strings.Asc(p_strA);
				int num2 = Strings.Asc(p_strB);
				result = (checked(num + num2) == 155);
			}
			catch (Exception expr_21)
			{
				ProjectData.SetProjectError(expr_21);
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}
		private string G(string EncryptedText)
		{
			string str = string.Empty;
			EncryptedText = modMain.RemoveReadability(EncryptedText);
			EncryptedText = this.B(EncryptedText);
			char[] array = EncryptedText.ToCharArray();
			str += this.A(modMain.SafeString(array[0]), 2).ToString();
			str += this.A(modMain.SafeString(array[1]), 0).ToString();
			str += this.A(modMain.SafeString(array[2]), 0).ToString();
			str += this.A(modMain.SafeString(array[3]), 3).ToString();
			str += this.A(modMain.SafeString(array[4]), 2).ToString();
			str += this.A(modMain.SafeString(array[5]), 1).ToString();
			str += this.A(modMain.SafeString(array[6]), 1).ToString();
			str += this.A(modMain.SafeString(array[7]), 3).ToString();
			str += this.A(modMain.SafeString(array[8]), 3).ToString();
			str += this.A(modMain.SafeString(array[9]), 1).ToString();
			str += this.A(modMain.SafeString(array[10]), 0).ToString();
			str += this.A(modMain.SafeString(array[11]), 2).ToString();
			str += this.A(modMain.SafeString(array[12]), 3).ToString();
			return str + this.A(modMain.SafeString(array[13]), 3).ToString();
		}
		private string d(string plainText, int p_intUnlockCode)
		{
			string text = string.Empty;
			try
			{
				if (p_intUnlockCode == 0 || p_intUnlockCode < 0)
				{
					p_intUnlockCode = 0;
				}
				char[] array = plainText.ToCharArray();
				text = this.a(Conversions.ToInteger(modMain.SafeString(array[0])), 2);
				text += this.a(Conversions.ToInteger(modMain.SafeString(array[1])), 0);
				text += this.a(Conversions.ToInteger(modMain.SafeString(array[2])), 0);
				text += this.a(Conversions.ToInteger(modMain.SafeString(array[3])), 3);
				text += this.a(Conversions.ToInteger(modMain.SafeString(array[4])), 2);
				text += this.a(Conversions.ToInteger(modMain.SafeString(array[5])), 1);
				text += this.a(Conversions.ToInteger(modMain.SafeString(array[6])), 1);
				text += this.a(Conversions.ToInteger(modMain.SafeString(array[7])), 3);
				text += this.a(Conversions.ToInteger(modMain.SafeString(array[8])), 3);
				text += this.a(Conversions.ToInteger(modMain.SafeStringVersion(array[9])), 1);
				text += this.a(Conversions.ToInteger(modMain.SafeStringVersion(array[10])), 0);
				text += this.a(Conversions.ToInteger(modMain.SafeStringVersion(array[11])), 2);
				text += this.a(Conversions.ToInteger(modMain.SafeStringVersion(array[12])), 3);
				text += this.a(Conversions.ToInteger(modMain.SafeString(array[13])), 3);
			}
			catch (Exception expr_1D9)
			{
				ProjectData.SetProjectError(expr_1D9);
				throw new Exception(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.au());
			}
			try
			{
				text = this.a(text, p_intUnlockCode);
			}
			catch (Exception expr_1F6)
			{
				ProjectData.SetProjectError(expr_1F6);
				throw new Exception(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aV());
			}
			try
			{
				text = modMain.MakeReadable(text);
			}
			catch (Exception expr_212)
			{
				ProjectData.SetProjectError(expr_212);
				throw new Exception(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.av());
			}
			return text;
		}
		private string g(string p_UnLetter)
		{
			string empty = string.Empty;
			int num = Strings.Asc(p_UnLetter);
			return Conversions.ToString(Strings.Chr(checked(90 - num + 65)));
		}
		private string B(int p_intNumber, int p_intSeries)
		{
			string result = string.Empty;
			int num = this.c();
			if (p_intNumber >= 0 && p_intNumber <= 10 && num >= 0 && num <= 2 && p_intSeries >= 0 && p_intSeries <= 3)
			{
				result = this.A()[p_intNumber, num, p_intSeries];
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}
		private string d()
		{
			string empty = string.Empty;
			VBMath.Randomize();
			double num = Math.Round((double)(25f * VBMath.Rnd())) + 65.0;
			int charCode = checked((int)Math.Round(num));
			return modMain.SafeString(Strings.Chr(charCode));
		}
		internal static string H(string p_strPublicKey)
		{
			string str = string.Empty;
			ArrayList arrayList = new ArrayList();
			int num = 0;
			int num2 = 0;
			bool flag = false;
			bool flag2 = true;
			p_strPublicKey = Strings.Left(p_strPublicKey, 25);
			char[] array = p_strPublicKey.ToCharArray();
			char[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					char @string = array2[i];
					arrayList.Add(Strings.Asc(@string));
				}
				int num4;
				try
				{
					IEnumerator enumerator = arrayList.GetEnumerator();
					while (enumerator.MoveNext())
					{
						int num3 = Conversions.ToInteger(enumerator.Current);
						if (flag2)
						{
							num4 = num3;
							flag2 = false;
						}
						if (flag)
						{
							flag = false;
							num += num3;
						}
						else
						{
							flag = true;
							num2 += num3;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				str = ((2 * num + (num2 + num4 * 3) + 64) * 11).ToString();
				return Strings.Right(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aW() + str, 5);
			}
		}
		private string C(string plainText, string p_strSaltValue)
		{
			string result = string.Empty;
			try
			{
				byte[] bytes = Encoding.ASCII.GetBytes(this.B);
				byte[] bytes2 = Encoding.ASCII.GetBytes(p_strSaltValue);
				byte[] bytes3 = Encoding.UTF8.GetBytes(plainText);
				PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(this.A, bytes2, this.a, this.A);
				int cb = checked((int)Math.Round((double)this.a / 8.0));
				byte[] bytes4 = passwordDeriveBytes.GetBytes(cb);
				ICryptoTransform transform = new RijndaelManaged
				{
					Mode = CipherMode.CBC
				}.CreateEncryptor(bytes4, bytes);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(bytes3, 0, bytes3.Length);
				cryptoStream.FlushFinalBlock();
				byte[] inArray = memoryStream.ToArray();
				memoryStream.Close();
				cryptoStream.Close();
				string text = Convert.ToBase64String(inArray);
				result = text;
			}
			catch (Exception expr_D9)
			{
				ProjectData.SetProjectError(expr_D9);
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}
		private byte[] a(byte[] p_bteData, string p_strSaltValue)
		{
			byte[] result;
			try
			{
				byte[] bytes = Encoding.ASCII.GetBytes(this.B);
				byte[] bytes2 = Encoding.ASCII.GetBytes(p_strSaltValue);
				PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(this.A, bytes2, this.a, this.A);
				int cb = checked((int)Math.Round((double)this.a / 8.0));
				byte[] bytes3 = passwordDeriveBytes.GetBytes(cb);
				ICryptoTransform transform = new RijndaelManaged
				{
					Mode = CipherMode.CBC
				}.CreateEncryptor(bytes3, bytes);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(p_bteData, 0, p_bteData.Length);
				cryptoStream.FlushFinalBlock();
				result = memoryStream.ToArray();
				memoryStream.Close();
				cryptoStream.Close();
			}
			catch (Exception expr_BA)
			{
				ProjectData.SetProjectError(expr_BA);
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}
		private byte[] a(byte[] p_bteData, string p_strSaltValue, int p_intFileBufferLength)
		{
			checked
			{
				MemoryStream memoryStream;
				CryptoStream cryptoStream;
				byte[] array;
				try
				{
					byte[] bytes = Encoding.ASCII.GetBytes(this.B);
					byte[] bytes2 = Encoding.ASCII.GetBytes(p_strSaltValue);
					PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(this.A, bytes2, this.a, this.A);
					int cb = (int)Math.Round((double)this.a / 8.0);
					byte[] bytes3 = passwordDeriveBytes.GetBytes(cb);
					ICryptoTransform transform = new RijndaelManaged
					{
						Mode = CipherMode.CBC
					}.CreateDecryptor(bytes3, bytes);
					memoryStream = new MemoryStream(p_bteData);
					cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
				}
				catch (Exception expr_8F)
				{
					ProjectData.SetProjectError(expr_8F);
					array = null;
					ProjectData.ClearProjectError();
				}
				array = new byte[p_intFileBufferLength - 1 + 1];
				try
				{
					if (cryptoStream != null)
					{
						int num = cryptoStream.Read(array, 0, p_intFileBufferLength);
					}
				}
				catch (Exception expr_BE)
				{
					ProjectData.SetProjectError(expr_BE);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (memoryStream != null)
					{
						memoryStream.Close();
					}
				}
				catch (Exception expr_D8)
				{
					ProjectData.SetProjectError(expr_D8);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (cryptoStream != null)
					{
						cryptoStream.Close();
					}
				}
				catch (Exception expr_F2)
				{
					ProjectData.SetProjectError(expr_F2);
					ProjectData.ClearProjectError();
				}
				return array;
			}
		}
		private string c(string cipherText, string p_strSaltValue)
		{
			string result = string.Empty;
			checked
			{
				try
				{
					byte[] bytes = Encoding.ASCII.GetBytes(this.B);
					byte[] bytes2 = Encoding.ASCII.GetBytes(p_strSaltValue);
					byte[] array = Convert.FromBase64String(cipherText);
					PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(this.A, bytes2, this.a, this.A);
					int cb = (int)Math.Round((double)this.a / 8.0);
					byte[] bytes3 = passwordDeriveBytes.GetBytes(cb);
					ICryptoTransform transform = new RijndaelManaged
					{
						Mode = CipherMode.CBC
					}.CreateDecryptor(bytes3, bytes);
					MemoryStream memoryStream = new MemoryStream(array);
					CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
					byte[] array2 = new byte[array.Length + 1];
					int count = cryptoStream.Read(array2, 0, array2.Length);
					memoryStream.Close();
					cryptoStream.Close();
					string @string = Encoding.UTF8.GetString(array2, 0, count);
					result = @string;
				}
				catch (Exception expr_D8)
				{
					ProjectData.SetProjectError(expr_D8);
					result = null;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}
		private string a(string p_strPrivateKey, int p_intNumberOfDays, classLicense.FeaturesUnlocked p_intUnlockCode)
		{
			if (p_intNumberOfDays > 60)
			{
				p_intNumberOfDays = 60;
			}
			if (p_intNumberOfDays < 1)
			{
				p_intNumberOfDays = 1;
			}
			int p_intCompositeKey = modMain.SafeInteger(classLicenseBase.E(p_strPrivateKey));
			string plainText = modMain.FixDate(DateAndTime.Now) + modMain.FixString(p_intNumberOfDays.ToString(), 3) + modMain.FixCompositeKey(p_intCompositeKey);
			return this.C(plainText, (int)p_intUnlockCode);
		}
	}
}

using System.Runtime.InteropServices;using System;using System.Text;using System.Runtime;
namespace QuineHearth {class quine{[DllImport("kernel32.dll", SetLastError = true)]
static extern IntPtr GetStdHandle(int nStdHandle);[DllImport("kernel32.dll", SetLastError = true)]
static extern bool ReadConsoleOutputCharacter(IntPtr hConsoleOutput,[Out] StringBuilder lpCharacter,
uint length,COORD bufferCoord,out uint lpNumberOfCharactersRead);
[StructLayout(LayoutKind.Sequential)]struct COORD{ public short X;  public short Y;}
static char ReadCharacterAt(int x, int y){  IntPtr consoleHandle = GetStdHandle(-11);
if (consoleHandle == IntPtr.Zero){ return '\0';}COORD position = new COORD {X = (short)x, Y = (short)y};
StringBuilder result = new StringBuilder(1);uint read = 0;
if (ReadConsoleOutputCharacter(consoleHandle, result, 1, position, out read))
{return result[0];} else {return '\0';}} static void Main(string[] args)
{var l = System.Console.CursorLeft;var t = System.Console.CursorTop;string s = """
using System.Runtime.InteropServices;using System;using System.Text;using System.Runtime;
namespace QuineHearth {{class quine{{[DllImport("kernel32.dll", SetLastError = true)]
static extern IntPtr GetStdHandle(int nStdHandle);[DllImport("kernel32.dll", SetLastError = true)]
static extern bool ReadConsoleOutputCharacter(IntPtr hConsoleOutput,[Out] StringBuilder lpCharacter,
uint length,COORD bufferCoord,out uint lpNumberOfCharactersRead);
[StructLayout(LayoutKind.Sequential)]struct COORD{{ public short X;  public short Y;}}
static char ReadCharacterAt(int x, int y){{  IntPtr consoleHandle = GetStdHandle(-11);
if (consoleHandle == IntPtr.Zero){{ return '\0';}}COORD position = new COORD {{X = (short)x, Y = (short)y}};
StringBuilder result = new StringBuilder(1);uint read = 0;
if (ReadConsoleOutputCharacter(consoleHandle, result, 1, position, out read))
{{return result[0];}} else {{return '\0';}}}} static void Main(string[] args)
{{var l = System.Console.CursorLeft;var t = System.Console.CursorTop;string s = {0}{0}{0}
{1}
{0}{0}{0};System.Console.Write(s,(char)34, s);while(true){{System.Console.SetCursorPosition(l,t);
for(double y = 1.3; y > -1.3; y-=0.1){{for(double x = -1.3; x < 1.3; x+=0.05){{System.Threading.Thread.Sleep(1);
double a = x * x + y * y - 1;var l1 = System.Console.CursorLeft;var t1 = System.Console.CursorTop;char character = ReadCharacterAt(l1, t1);
ConsoleColor recentForegroundColor = Console.ForegroundColor;if(a * a * a - x * x * y * y * y <= 0)
{{Console.ForegroundColor = ConsoleColor.Red;System.Console.Write(character);Console.ForegroundColor = recentForegroundColor;
}}else {{System.Console.Write(character);}}}}System.Console.Write('\n');}}}}}}}}}}
""";System.Console.Write(s,(char)34, s);while(true){System.Console.SetCursorPosition(l,t);
for(double y = 1.3; y > -1.3; y-=0.1){for(double x = -1.3; x < 1.3; x+=0.05){System.Threading.Thread.Sleep(1);
double a = x * x + y * y - 1;var l1 = System.Console.CursorLeft;var t1 = System.Console.CursorTop;char character = ReadCharacterAt(l1, t1);
ConsoleColor recentForegroundColor = Console.ForegroundColor;if(a * a * a - x * x * y * y * y <= 0)
{Console.ForegroundColor = ConsoleColor.Red;System.Console.Write(character);Console.ForegroundColor = recentForegroundColor;
}else {System.Console.Write(character);}}System.Console.Write('\n');}}}}}
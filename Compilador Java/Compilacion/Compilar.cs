using Compilador_Java.Depuracion;
using Compilador_Java.Lexico.Simbolos;
using Compilador_Java.Lexico.Tokens;
using Compilador_Java.Errores;
using Compilador_Java.Sintactico;
namespace Compilador_Java.Compilacion;
public class Compilar
{
    public static (bool, List<Symbol>?) CompilarCodigo(string source)
    {
        Depurar.Limpiar(ref source);
        Console.WriteLine(source);
        if (!Depurar.ValidarEsCodigoJava(source))
        {
            CompilerException.AddException("BAD SOURCE");
            return (false, null);
        }
        var tokens = Tokenizer.TokenTable(source);
        if(tokens == null) return (false, null);
        var symbols = Symbolize.SymbolTable(tokens);
        SyntaxAnalyzer.Analizar(symbols);
        if (CompilerException.HasExceptions()) return (false, symbols);
        return (true, symbols);
    }
    public static List<(string, string)> MostrarErrores() => 
        CompilerException.GetExceptions();
}
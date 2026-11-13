using Compilador_Java.Depuracion;
using Compilador_Java.Lexico.Simbolos;
using Compilador_Java.Lexico.Tokens;
using Compilador_Java.Errores;
using Compilador_Java.Sintactico;
using DI = Compilador_Java.Recopilar_Instrucciones.DetectorInstrucciones;
namespace Compilador_Java.Compilacion;
public class Compilar
{
    public static (bool, List<Symbol>?) CompilarCodigo(string source)
    {
        new DI();
        Depurar.Limpiar(ref source);
        if (!Depurar.ValidarEsCodigoJava(source))
        {
            CompilerException.AddException("BAD SOURCE");
            return (false, null);
        }
        var tokens = Tokenizer.TokenTable(source);
        if(tokens == null) return (false, null);
        var symbols = Symbolize.SymbolTable(tokens);
        Console.WriteLine(string.Join('\n', symbols));
        SyntaxAnalyzer.Analizar(symbols);
        if (CompilerException.HasExceptions()) return (false, symbols);
        Console.WriteLine(DI.Instance!.Instrucciones.Count);
        Console.WriteLine(string.Join("\n",DI.Instance!.Instrucciones));
        return (true, symbols);
    }
}
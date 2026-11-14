using Compilador_Java.Info_Lenguaje;
using Compilador_Java.Recopilar_Instrucciones;
using DI = Compilador_Java.Recopilar_Instrucciones.DetectorInstrucciones;

namespace Compilador_Java.Semantico;
public class Analyzer
{
    public static void Start()
    {
        var instrucciones = DI.Instance!.Instrucciones;
        foreach (var instruccion in instrucciones)
        {
            if (instruccion.Message.Contains("Clase"))
                Clase();
            else if (instruccion.Message.Contains("Metodo"))
                Metodo(instruccion);
        }
    }
    public static void Clase()
    {

    }
    public static void Metodo(Instruccion instruction)
    {
        bool procParams = false;
        string idMethod = "";
        List<string> @params = new();
        string valType = "";

        foreach (var token in instruction.Tokens)
        {
            if (token.Tipo == TokensJava.PA.Name())
                procParams = true;
            else if (token.Tipo == TokensJava.ID.Name() &&
                     idMethod == "")
                idMethod = token.Lexema;
            else if (valType == "" && token.IsTY())
                valType = token.TD2VAL()?.Name() ?? token.Lexema;
            if (procParams && TokenHelper.IsVAL(token.Lexema))
                @params.Add(token.Tipo);

        }
        SystemMethods.JavaMethods.Add(idMethod, new Method(valType, new(), @params));
    }
}
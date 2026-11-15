using Compilador_Java.Info_Lenguaje;
using Compilador_Java.Lexico.Tokens.Table;

namespace Compilador_Java.Semantico;
public class LinkVTSMethods
{
    public static void Link(string td, string name)
    {
        if (td != TokensJava.VTS.Name()) return;
        SystemMethods.JavaMethods["substring"]
            .Relaciones.Add(name);
        SystemMethods.JavaMethods["charAt"]
            .Relaciones.Add(name);
    }
}
using Compilador_Java.Lexico.Tokens.Table;

namespace Compilador_Java.Info_Lenguaje;

public static class TokenHelper
{
    public static readonly Dictionary<char, string> Posfix = new() {
        {'f', TokensJava.VTF.Name()},
        { 'd', TokensJava.VTD.Name() }
    };

    public static bool HasPosfix(char curr) => Posfix.ContainsKey(curr);

    public static bool IsTY(this TokenRow t) =>
    t.Tipo == TokensJava.ID.Name() ||
    t.Tipo == TokensJava.TD.Name() ||
    t.Tipo == TokensJava.STR.Name();

    public static string Name(this TokensJava token)
    { 
        return token.ToString();
    }

    public static bool EmpiezaInst(this TokenRow t)
    {
        string c = t.Tipo;
        return c == TokensJava.TD.Name() ||
               c == TokensJava.STR.Name() ||
               c == TokensJava.ID.Name() ||
               c == TokensJava.VTS.Name() ||
               c == TokensJava.PRW.Name() ||
               c == TokensJava.PRIF.Name() ||
               c == TokensJava.PRDO.Name() ||
               c == TokensJava.PRSW.Name() ||
               c == TokensJava.PRF.Name();
    }
}
using Compilador_Java.Info_Lenguaje;
using System.Runtime.CompilerServices;

namespace Compilador_Java.Sintactico.GCL.Rules;
public class Val : RuleBase<Val>
{
    public override void Ejec()
    {
        string c = Ctx.CurrentToken().Tipo;
        if (IsVAL(c)) {
            Avanzar();
            return; 
        }
        throw Error("un valor (VTE, VTD, VTS, VTB, ID, VTF o VTC)");
    }
    public bool IsVAL(string c) =>
            c == TokensJava.VTE.Name() ||
            c == TokensJava.VTD.Name() ||
            c == TokensJava.VTS.Name() ||
            c == TokensJava.VTB.Name() ||
            c == TokensJava.ID.Name() ||
            c == TokensJava.VTF.Name() ||
            c == TokensJava.VTC.Name();
}
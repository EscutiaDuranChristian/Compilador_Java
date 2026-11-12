using Compilador_Java.Info_Lenguaje;

namespace Compilador_Java.Sintactico.GCL.Rules;
public class Val : RuleBase<Val>
{
    public override void Ejec()
    {
        string c = Ctx.CurrentToken().Tipo;
        if (c == TokensJava.VTE.Name() || 
            c == TokensJava.VTD.Name() ||
            c == TokensJava.VTS.Name() || 
            c == TokensJava.VTB.Name() ||
            c == TokensJava.ID.Name()  ||
            c == TokensJava.VTF.Name() || 
            c == TokensJava.VTC.Name()) {
            Avanzar();
            return; 
        }
        throw Error("un valor (VTE, VTD, VTS, VTB, ID, VTF o VTC)");
    }
}
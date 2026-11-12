using Compilador_Java.Info_Lenguaje;

namespace Compilador_Java.Sintactico.GCL.Rules;

public class  Clase : RuleBase<Clase>
{
    public override void Ejec()
    {
        Expect(TokensJava.MA.Name()); 
        Expect(TokensJava.CL.Name()); 
        Expect(TokensJava.ID.Name()); 
        RaiseDetectValidInst();
        Expect(TokensJava.LLA.Name());
        RaiseDetectValidInst("CONTENT BEGIN");
        while (!Ctx.Eof && Ctx.CurrentToken().Tipo != TokensJava.LLC.Name())
            Varios.Instance!.Ejec();
        Expect(TokensJava.LLC.Name());
        RaiseDetectValidInst("CONTENT END");
    }
}
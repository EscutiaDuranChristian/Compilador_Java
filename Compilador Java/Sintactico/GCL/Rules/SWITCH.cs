using Compilador_Java.Info_Lenguaje;

namespace Compilador_Java.Sintactico.GCL.Rules;
public class Switch : RuleBase<Switch>
{
    public override void Ejec()
    {
        Expect(TokensJava.PRSW.Name());
        Expect(TokensJava.PA.Name());
        Val.Instance!.Ejec();
        Expect(TokensJava.PC.Name());
        RaiseDetectValidInst();
        Expect(TokensJava.LLA.Name());
        RaiseDetectValidInst("CASES BEGIN");
        CASE();
        C_DEF();
        Expect(TokensJava.LLC.Name());
        RaiseDetectValidInst("CASES END");
    }
    public void CASE()
    {
        while (Ctx.CurrentToken().Tipo == TokensJava.CS.Name())                             
        {
            Avanzar();
            Val.Instance!.Ejec();
            Expect(TokensJava.DOP.Name());
            RaiseDetectValidInst("CASE");
            Cuerpo.Instance!.Ejec();
            Break.Instance!.Ejec();
        }
    }
    public void C_DEF()
    {
        if (Accept(TokensJava.DF.Name()))                               
        {
            Expect(TokensJava.DOP.Name());
            RaiseDetectValidInst("CASE_DEFAULT");
            Cuerpo.Instance!.Ejec(); 
            Break.Instance!.Ejec();
        }
    }
}
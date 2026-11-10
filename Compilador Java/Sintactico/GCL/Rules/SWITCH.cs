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
        Expect(TokensJava.LLA.Name());
        CASE();
        C_DEF();
        Expect(TokensJava.LLC.Name());
    }
    public void CASE()
    {
        while (Ctx.CurrentToken().Tipo == TokensJava.CS.Name())                             
        {
            Ctx.Advance();
            Val.Instance!.Ejec();
            Expect(TokensJava.DOP.Name());
            Cuerpo.Instance!.Ejec();
            Break.Instance!.Ejec();
        }
    }
    public void C_DEF()
    {
        if (Accept(TokensJava.DF.Name()))                               
        {
            Expect(TokensJava.DOP.Name());
            Cuerpo.Instance!.Ejec(); 
            Break.Instance!.Ejec();
        }
    }
}
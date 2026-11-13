using Compilador_Java.Info_Lenguaje;
namespace Compilador_Java.Sintactico.GCL.Rules;

public class Metodo : RuleBase<Metodo>
{
    public override void Ejec()
    {
        Expect(TokensJava.MA.Name());
        Type.Instance!.Ejec();
        Expect(TokensJava.ID.Name()); 
        Expect(TokensJava.PA.Name());
        if (Ctx.CurrentToken().Tipo != TokensJava.PC.Name())                                // PARAMS
        {
            Param.Instance!.Ejec();
            while (Accept(TokensJava.CO.Name())) 
                Param.Instance!.Ejec();
        }
        Expect(TokensJava.PC.Name());
        RaiseDetectValidInst();
        Expect(TokensJava.LLA.Name());
        Cuerpo.Instance!.Ejec();
        if (Accept(TokensJava.RTN.Name()))                            
        {
            if (Ctx.CurrentToken().Tipo != TokensJava.FI.Name()) 
                Exp.Instance!.Ejec();
            Expect(TokensJava.FI.Name());
        }
        Expect(TokensJava.LLC.Name());
    }
}
using Compilador_Java.Info_Lenguaje;
namespace Compilador_Java.Sintactico.GCL.Rules;

public class IfEl : RuleBase<IfEl>
{
    // IFEL::=PRIF PA EXPBOO PC LLA INST LLC CLOS ;  CLOS::=PRE LLA INST LLC|
    public override void Ejec()
    {
        Expect(TokensJava.PRIF.Name());
        Expect(TokensJava.PA.Name());
        Exp.Instance!.Ejec(); 
        Expect(TokensJava.PC.Name());
        Bloque.Instance!.Ejec();
        if (Accept(TokensJava.PRE.Name()))
        Bloque.Instance!.Ejec();
    }
}
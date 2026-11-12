using Compilador_Java.Info_Lenguaje;
namespace Compilador_Java.Sintactico.GCL.Rules;
public class Do : RuleBase<Do>
{
    public override void Ejec()
    {
        Expect(TokensJava.PRDO.Name());
        RaiseDetectValidInst();
        Bloque.Instance!.Ejec();
        Expect(TokensJava.PRW.Name()); 
        Expect(TokensJava.PA.Name()); 
        RaiseDetectValidInst("DO WHILE");
        Exp.Instance!.Ejec(); 
        Expect(TokensJava.PC.Name());
        Expect(TokensJava.FI.Name());
    }
}
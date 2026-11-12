using Compilador_Java.Info_Lenguaje;
namespace Compilador_Java.Sintactico.GCL.Rules;
public class Bloque : RuleBase<Bloque>
{
    public override void Ejec()
    {
        Expect(TokensJava.LLA.Name());
        RaiseDetectValidInst("BLOQUE BEGIN");
        Cuerpo.Instance!.Ejec();
        Expect(TokensJava.LLC.Name());
        RaiseDetectValidInst("BLOQUE END");
    }
}
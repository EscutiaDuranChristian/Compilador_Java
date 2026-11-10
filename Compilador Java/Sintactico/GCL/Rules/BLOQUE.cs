using Compilador_Java.Info_Lenguaje;
namespace Compilador_Java.Sintactico.GCL.Rules;
public class Bloque : RuleBase<Bloque>
{
    public override void Ejec()
    {
        Expect(TokensJava.LLA.Name());
        Cuerpo.Instance!.Ejec();
        Expect(TokensJava.LLC.Name());
    }
}
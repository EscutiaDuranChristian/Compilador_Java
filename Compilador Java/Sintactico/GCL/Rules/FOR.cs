using Compilador_Java.Info_Lenguaje;
namespace Compilador_Java.Sintactico.GCL.Rules;
public class  For : RuleBase<For>
{
    public override void Ejec()
    {
        Expect(TokensJava.PRF.Name()); 
        Expect(TokensJava.PA.Name());
        PrimerBloque();
        Condicion();
        Actualizacion();
        Expect(TokensJava.PC.Name());
        Bloque.Instance!.Ejec();
    }
    public void PrimerBloque()
    {
        if (Ctx.CurrentToken().Tipo == TokensJava.TD.Name() ||
            Ctx.CurrentToken().Tipo == TokensJava.STR.Name() ||
            (Ctx.CurrentToken().Tipo == TokensJava.ID.Name() &&
            Ctx.At(1).Tipo == TokensJava.ID.Name()))
            DecOrObj.Instance!.Ejec();
        else if (Ctx.CurrentToken().Tipo == TokensJava.ID.Name() &&
            Ctx.At(1).Tipo == TokensJava.ODA.Name())
            Asig.Instance!.Ejec();
        else if (Ctx.CurrentToken().Tipo == TokensJava.FI.Name())
            Ctx.Advance();
        else
        {
            Exp.Instance!.Ejec();
            Expect(TokensJava.FI.Name());
        }
    }
    public void Condicion()
    {
        if (Ctx.CurrentToken().Tipo != TokensJava.FI.Name()) 
            Exp.Instance!.Ejec();
        Expect(TokensJava.FI.Name());
    }
    public void Actualizacion()
    {
        if (Ctx.CurrentToken().Tipo != TokensJava.PC.Name())
        {
            if (Ctx.CurrentToken().Tipo == TokensJava.ID.Name() &&
                Ctx.At(1).Tipo == TokensJava.ODA.Name()) { 
                Ctx.Advance(2); 
                Exp.Instance!.Ejec(); 
            }
            else Exp.Instance!.Ejec();
        }
    }
}
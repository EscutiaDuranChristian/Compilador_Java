using Compilador_Java.Sintactico.GCL.Context;
using Compilador_Java.Sintactico.Result;

namespace Compilador_Java.Sintactico.GCL;
public abstract class RuleBase
{
    public static GramarContext Ctx { get; private set; } = new(new());
    public static void SetContext(GramarContext ctx) => Ctx = ctx;
}

public abstract class RuleBase<T> : RuleBase where T : RuleBase<T>
{
    public static T? Instance;

    public RuleBase()
    {
        if (Instance == null) Instance = (T)this;
    }

    protected static SyntaxException Error(string esperado)
    {
        int i_token = Ctx.CurrentTokenIndex;

        string encontrado = Ctx.Eof
            ? "fin de la tabla"
            : $"'{Ctx.CurrentToken().Lexema}' ({Ctx.CurrentToken().Tipo})";

        return new SyntaxException(
            $"Error sintáctico en el token #{i_token}: " +
            $"se esperaba {esperado} pero se encontró {encontrado}.", i_token);
    }

    protected void Expect(string tipo)
    {
        if (Ctx.CurrentToken().Tipo != tipo) 
            throw Error(tipo);
        Ctx.Advance();
    }

    protected bool Accept(string tipo)
    {
        if (Ctx.CurrentToken().Tipo != tipo) 
            return false;
        Ctx.Advance();
        return true;
    }

    public abstract void Ejec();
}
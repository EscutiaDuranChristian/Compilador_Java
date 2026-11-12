using Compilador_Java.Info_Lenguaje;
using Compilador_Java.Lexico.Tokens.Table;
using Compilador_Java.Sintactico.GCL;

namespace Compilador_Java.Recopilar_Instrucciones;

public class DetectorInstrucciones
{
    public event Action<Instruccion>? OnAddInstruction;
    public static DetectorInstrucciones? Instance
    { get; private set; }
    public List<Instruccion> Instrucciones
    { get; private set; } = new();
    public Instruccion CurrInst = new("");

    public DetectorInstrucciones()
    {
        RuleBase.OnAcceptToken += AddToken;
        RuleBase.OnDetectValidInst += AddInst;
        Instance = this;
    }

    private void AddInst(string message)
    {
        if (CurrInst == null) return;
        CurrInst.Message = message;
        Instrucciones.Add(CurrInst);
        OnAddInstruction?.Invoke(CurrInst);
        CurrInst = new("");
    }
    private void AddToken(TokenRow tk)
    {
        if (tk.Tipo == TokensJava.FI.Name()
            // || tk.Tipo == TokensJava.LLA.Name() ||
            //tk.Tipo == TokensJava.LLC.Name()
            ) return;
        CurrInst.Tokens.Add(tk);
    }
}
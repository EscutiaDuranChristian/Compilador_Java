namespace Compilador_Java.Lexico.Tokens.Table;
public class TokenRow
{
    public string Lexema { get; set; }
    public string Tipo { get; private set; }
    public TokenRow(string lexema, string tipo)
    {
        Lexema = lexema;
        Tipo = tipo;
    }
    public override string ToString() => $"{Lexema}";
}
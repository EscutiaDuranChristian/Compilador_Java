namespace Compilador_Java.Lexico.Tokens.Table;
public class TokenRow
{
    public string Lexema;
    public string Tipo;
    public TokenRow(string lexema, string tipo)
    {
        Lexema = lexema;
        Tipo = tipo;
    }
    public override string ToString() => $"{Lexema}\t\t\t{Tipo}";
}
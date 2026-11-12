using Compilador_Java.Lexico.Tokens.Table;
using System.Text;

namespace Compilador_Java.Recopilar_Instrucciones;
public class Instruccion
{
    public string Message { get;  set; }
    public List<TokenRow> Tokens { get; set; }

    public Instruccion(string message)
    {
        Message = message;
        Tokens = new();
    }

    public override string ToString()
    {
        StringBuilder st = new();
        st.Append(Message).Append(':');
        foreach (var token in Tokens)
            st.Append(token).Append(" ");
        return st.ToString();
    }
}
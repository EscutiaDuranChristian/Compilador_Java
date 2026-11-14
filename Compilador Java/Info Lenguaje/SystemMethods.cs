using Compilador_Java.Sintactico.GCL.Rules;

namespace Compilador_Java.Info_Lenguaje;
public class SystemMethods
{
    public static readonly Dictionary<string, Container> JavaMethods = new()
        {
            { "System", new(TokensJava.TM.Name(), new(){ "java" }) },
             { "java", new(TokensJava.TM.Name(), new(){ "out" }) }, 
             { "out", new(TokensJava.TM.Name(), new(){ "print", "println" }) }, 
             { "println", new("ANY", new()) }, 
             { "print", new("ANY", new()) },
             {"in", new(TokensJava.TM.Name(), new())},
             {"Scanner", new("Scanner", new(){ "nextInt", "nextDouble", "nextLine" })},
             {"nextInt", new(TokensJava.VTE.Name(), new())},
             {"nextDouble",new(TokensJava.VTD.Name(), new())},
             {"nextLine",new(TokensJava.VTS.Name(), new())},
             {"Math", new(TokensJava.TM.Name(), new(){ "random" })},
             { "random" , new(TokensJava.VTD.Name(), new()) },
        };
}
public class Container
{
    //VTE VTF VTS TM
    protected string ValType = TokensJava.VTE.Name();
    protected HashSet<string> Relaciones = new();
    public bool Validar(string val) => val == ValType || ValType == "ANY";
    public bool CA(string rel) => Relaciones.Contains(rel);
    public Container(string valType,List<string> relaciones)
    {
        foreach (var relacion in relaciones)
            Relaciones.Add(relacion);
        ValType = valType;
    }
}

public class Method : Container
{
    public Method(string v, List<string> r, List<string> @params): base(v, r) {
        Params = @params;
    }
    protected List<string> Params = new();
    public bool Validar(List<string> @params)
    {
        if (@params.Count == 0 || Params.Count == 0) 
            return @params.Count == Params.Count;
        foreach (var param in Params)
        {
            if (param != @params[0]) return false;
            @params.RemoveAt(0);
        }
        return true;
    }
}
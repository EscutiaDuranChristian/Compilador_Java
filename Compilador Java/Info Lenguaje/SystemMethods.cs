namespace Compilador_Java.Info_Lenguaje;
public class SystemMethods
{
    public static readonly Dictionary<string,
        JAVA_ID> Methods = new()
        {
            { "System", new(MethodType.CL)},
            { "java", new(MethodType.CL)},
            { "out", new(MethodType.CL) },
            { "println", new(MethodType.Print)},
            { "print", new(MethodType.Print)},
            { "read", new(MethodType.Read) },
            { "in", new(MethodType.CL) } 
        };
    //Posible solucion
    public void Out(object o) => Console.WriteLine();
}
public class JAVA_ID
{
    public MethodType MethodType { get; private set; }
    public JAVA_ID(MethodType methodType) =>
        MethodType = methodType;
}
public enum MethodType
{
    Print,
    Read,
    CL
}
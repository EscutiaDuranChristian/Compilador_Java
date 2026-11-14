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
            { "in", new(MethodType.CL) },
            { "Scanner", new(MethodType.CL) },
            { "nextInt", new(MethodType.Read) },
            { "nextDouble", new(MethodType.Read) },
            { "Math", new(MethodType.CL) },
            { "random", new(MethodType.Method) }
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
    CL,
    Method
}
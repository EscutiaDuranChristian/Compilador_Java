using Compilador_Java.Compilacion;
string codigoJava = """
package facil;
public class Mierco
{
    //Comentario corto: Ignorar
    /*
        Comentario largo:
        -----------------
        Ignorar
        uwu
        @@@@@@@@@@@@@@@@@
    */
    public int valor = 2;
    public static void main(String args[]){
        int x = 2; 
        double z = .0+2f+1.+15.0;
        float y = x+++2.0f+2f;
        System.out.println("El resultado es:" + (x+y)*2);
    }
}
""";

Console.WriteLine(string.Join("\n", Compilar.CompilarCodigo(codigoJava).Item1));
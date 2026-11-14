using Compilador_Java.Compilacion;
using Compilador_Java.Errores;
string codigoJava1 = """
package facil;
public class Mierco
{
    //Comentario corto: Ignorar
    public int hola;
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
        System.out.println();
        System.out.println("El resultado es:" + (x+y)*2);
        switch(x){
            case 0: 
                if(z > 10){
                System.out.println("Hola mundo"); }
                break;
            default:
                System.out.println("Mayor que 0");
                break;
        }
        do{
            System.out.println("Infinito");
        }while(true);
        while(true){
            System.out.println("No infinito");
        }
        for(int i = 0; i < 5; i++){
            System.out.println("Hello neighbor"+i);
        }
    }
}
""";
string codigoJava2 = """
    package automatas;
    import java.util.Scanner;
    public class Uno{
        public double dos(int t, float c){
            return t/3+11*2-c;
        }
        public static void main(String[] args){
            Uno obj = new Uno();
            char siete = (char)(obj.dos('2',0.5f));
            String cad = "SISTEMAS";
            System.out.println(siete + "BARCO".substring(3,4) + (char)81+cad.charAt(5));
            Random random = new Random();
            Scanner sc = new Scanner();
            int numero2 = numero1 * sc.nextInt() * Math.random();
        }
    }
    """;

Compilar.CompilarCodigo(codigoJava1);
Console.WriteLine(string.Join("\n", CompilerException.GetExceptions()));
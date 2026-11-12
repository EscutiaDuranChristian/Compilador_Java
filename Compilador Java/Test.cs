using Compilador_Java.Compilacion;
string codigoJava = """
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
    }
}
""";

Console.WriteLine(string.Join("\n", Compilar.CompilarCodigo(codigoJava).Item1));
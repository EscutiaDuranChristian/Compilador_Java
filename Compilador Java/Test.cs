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
    public class Uno{
        public double dos(int t, float c){
            return t/3+11*2-c;
        }
        public static void main(String[] args){
            Uno obj = new Uno();
            char siete = (char)(obj.dos('2',0.5f));
            String cad = "SISTEMAS";
            System.out.println(siete + "BARCO".substring(3,4) + (char)81+cad.charAt(5));
            Scanner sc = new Scanner();
        }
    }
    """;
string codigo3 = """
    package automatas;
    public class Uno{
        public double dos(int t, float c){
            return t/3+11*2-c;
        }
        public static void main(String[] args){
            double d = dos();
        }
    }
    """;
Compilar.CompilarCodigo(codigoJava2);
Console.WriteLine(string.Join("\n", CompilerException.GetExceptions()));
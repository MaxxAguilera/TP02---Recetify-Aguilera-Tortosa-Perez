namespace Tp02.Models;

public class SugeridorReceta
{
    private const int COMENSALES_MAXIMOS = 20;
    private const int COMENSALES_MINIMOS = 1;

    public string nombreCocinero {get; set;}
    public DateTime fechaNacimiento {get; set;}
    public string tipoDeComida {get; set;}
    public double presupuesto {get; set;}
    public int cantidadComensales {get; set;}

    public int CalcularEdad(){
        return DateTime.Today.Year - fechaNacimiento.Year;
    }

    public string DeterminarPlato(){

        if (tipoDeComida == "Fría")
        {
            if(presupuesto < 3000) return "Ensalada simple";
            else if (presupuesto <= 7000) return "Ensalada completa con proteína";
            else return "Tabla de fiambres y quesos";  
        }
        else
        {
            if(presupuesto < 3000) return "Fideos con manteca";
            else if (presupuesto <= 7000) return "Arroz con verduras salteadas";
            else return "Pollo al horno con guarnición";            
        }

    }

    public int CalcularTiempo(){

        if (tipoDeComida == "Fría")
        {
            if (cantidadComensales <= 3) return 10;
            else if (cantidadComensales <= 7) return 20;
            else return 40;       
        }
        else
        {
            if(cantidadComensales == 1) return 20;
            else if (cantidadComensales <= 3) return 20;
            else if (cantidadComensales <= 7) return 40;
            else return 80;            
        }
    }

    public string DeterminarDificultad(){
        if (presupuesto < 3000){
            if(cantidadComensales <= 3) return "Principiante";
            else return "Intermedio";
        }
        else if (presupuesto <= 7000) return "Intermedio";
        else{
            if(cantidadComensales <= 7) return "Intermedio";
            else return "Avanzado";
        }
    }
}

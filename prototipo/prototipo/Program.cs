using System;

abstract class Examen
{
    // Atributos protegidos
    protected string materia;
    protected string docente;
    protected string salon;
    protected string clave;

    public Examen(string materia, string docente, string salon, string clave)
    {
        this.materia = materia;
        this.docente = docente;
        this.salon = salon;
        this.clave = clave;
    }

    // Método prototipo
    public abstract Examen Clonar();

    public void Mostrar()
    {
        Console.WriteLine("Materia: " + materia);
        Console.WriteLine("Docente: " + docente);
        Console.WriteLine("Salon: " + salon);
        Console.WriteLine("Clave: " + clave);
        Console.WriteLine("--------------------");
    }
}

class ExamenPatrones : Examen
{
    public ExamenPatrones(string docente)
        : base("Patrones de Diseño", docente, "A1", "PD101") { }

    public override Examen Clonar()
    {
        return (Examen)this.MemberwiseClone();
    }
}
class ExamenTemasAvanzados : Examen
{
    public ExamenTemasAvanzados(string docente)
        : base("Temas Avanzados de Desarrollo de Software", docente, "B2", "TA102") { }

    public override Examen Clonar()
    {
        return (Examen)this.MemberwiseClone();
    }
}
class ExamenGestionProyectos : Examen
{
    public ExamenGestionProyectos(string docente)
        : base("Gestion de Proyectos", docente, "C3", "GP103") { }

    public override Examen Clonar()
    {
        return (Examen)this.MemberwiseClone();
    }
}

class ExamenAnalisisAvanzado : Examen
{
    public ExamenAnalisisAvanzado(string docente)
        : base("Analisis Avanzado de Desarrollo de Software", docente, "D4", "AA104") { }

    public override Examen Clonar()
    {
        return (Examen)this.MemberwiseClone();
    }
}

class Program
{
    static void Main()
    {
        Examen examen1 = new ExamenPatrones("Maribel Guerrero");
        Examen examen2 = examen1.Clonar(); // mismo examen para otro grupo

        Examen examen3 = new ExamenTemasAvanzados("Juan Perez");
        Examen examen4 = examen3.Clonar();

        Examen examen5 = new ExamenGestionProyectos("Maria Lopez");
        Examen examen6 = examen5.Clonar();

        Examen examen7 = new ExamenAnalisisAvanzado("Carlos Ramirez");
        Examen examen8 = examen7.Clonar();

        examen1.Mostrar();
        examen2.Mostrar();
        examen3.Mostrar();
        examen4.Mostrar();
        examen5.Mostrar();
        examen6.Mostrar();
        examen7.Mostrar();
        examen8.Mostrar();
    }
}
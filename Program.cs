using System;

class Pupil//creating a class
{
    public virtual void Study()//creating methods
    {
        Console.WriteLine("...");
    }

    public virtual void Read(){
        Console.WriteLine("...");
    }

    public virtual void Write(){ 
        Console.WriteLine("...");
    }

    public virtual void Relax(){ 
        Console.WriteLine("...");
    }
}
class ExcellentPupil : Pupil//child class
{
    public override void Study()//redefined methods
    {
        Console.WriteLine("Прекрасно учится");
    }
    public override void Read()
    {
        Console.WriteLine("Прекрасно читает");
    }
    public override void Write()
    {
        Console.WriteLine("Прекрасно пишет");
    }
    public override void Relax()
    {
        Console.WriteLine("Прекрасно отдыхает");
    }
}
class GoodPupil : Pupil//child class
{
    public override void Study()//redefined methods
    {
        Console.WriteLine("Хорошо учится");
    }
    public override void Read()
    {
        Console.WriteLine("Хорошо читает");
    }
    public override void Relax()
    {
        Console.WriteLine("Хорошо отдыхает");
    }
    public override void Write()
    {
        Console.WriteLine("Хорошо пишет");
    }

}
class BadPupil : Pupil//child class
{
    public override void Read()//redefined methods
    {
        Console.WriteLine("Плохо читает");
    }
    public override void Write()
    {
        Console.WriteLine("Плохо пишет");
    }
    public override void Relax()
    {
        Console.WriteLine("Плохо отдыхает");
    }
    public override void Study()
    {
        Console.WriteLine("Плохо учится");
    }
}
class ClassRoom//creating a class
{
    
    private Pupil[] pupils;//class field    

    public ClassRoom(params Pupil[] pupils)//constructor
    {
        if (pupils.Length < 2 || pupils.Length > 4)//checking the condition
        {
            throw new ArgumentException("Класс должен содержать от 2 до 4 учеников");//creating an exception
        }
        this.pupils = new Pupil[4];
        for (int i = 0; i < pupils.Length; i++)//filling the array
        {
            this.pupils[i]=pupils[i];
        }
        for (int i = pupils.Length; i < 4; i++)
        {
            this.pupils[i] = new ExcellentPupil();
        }
    }
    public void ShowClassInfo()//class method
    {
        Console.WriteLine("=== ИНФОРМАЦИЯ О КЛАССЕ ===");
        Console.WriteLine();

        for (int i = 0; i < pupils.Length; i++)
        {
            Console.WriteLine($"Ученик {i + 1}:");
            Console.WriteLine("Учеба: "); pupils[i].Study();
            Console.WriteLine("Чтение: "); pupils[i].Read();
            Console.WriteLine("Письмо: "); pupils[i].Write();
            Console.WriteLine("Отдых: "); pupils[i].Relax();
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        ExcellentPupil excellent=new ExcellentPupil();//creating elemenths of the class
        GoodPupil good=new GoodPupil();
        BadPupil bad=new BadPupil();
        ClassRoom class2 = new ClassRoom(excellent, good,bad);
        class2.ShowClassInfo();//calling the class method
        ClassRoom class1 = new ClassRoom(excellent);


    }

}

using System;

class Pupil
{
    public virtual void Study()
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
class ExcellentPupil : Pupil
{
    public override void Study()
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
class GoodPupil : Pupil
{
    public override void Study()
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
class BadPupil : Pupil
{
    public override void Read()
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
class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils)
    {
        if (pupils.Length < 2 || pupils.Length > 4)
        {
            throw new ArgumentException("Класс должен содержать от 2 до 4 учеников");
        }
        this.pupils = new Pupil[4];
        for (int i = 0; i < pupils.Length; i++)
        {
            this.pupils[i]=pupils[i];
        }
        for (int i = pupils.Length; i < 4; i++)
        {
            this.pupils[i] = new ExcellentPupil();
        }
    }
    public void ShowClassInfo()
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
        ExcellentPupil excellent=new ExcellentPupil();
        GoodPupil good=new GoodPupil();
        BadPupil bad=new BadPupil();
        ClassRoom class2 = new ClassRoom(excellent, good,bad);
        class2.ShowClassInfo();
        ClassRoom class1 = new ClassRoom(excellent);


    }
}
using System;
class DocumentWorker//base class
{
    //creating methods
    public virtual void EditDocument() {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }

    public virtual void SaveDocument() {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
    }

    public virtual void OpenDocument() {
        Console.WriteLine("Документ открыт");
    }

}

class ProDocumentWorker():DocumentWorker //child class
{
    //redefining the methods
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредакирован");
    }
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
    public override void OpenDocument()
    {
        base.OpenDocument();
    }
}

class ExpertDocumentWorker() : ProDocumentWorker//child class
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите ключ продукта: ");//display the message
        string key;
        key = Console.ReadLine();//reading the message
        DocumentWorker programm;//creating element of a class
        if (key == "pro")
        {
            programm = new ProDocumentWorker();
        }
        else if (key == "expert")
        {
            programm = new ExpertDocumentWorker();
        }
        else
        {
            programm = new DocumentWorker();
        }
        //display the features of the mode on the screen
        programm.SaveDocument();
        programm.OpenDocument();
        programm.EditDocument();
    }
}


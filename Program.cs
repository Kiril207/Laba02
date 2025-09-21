using System;
class DocumentWorker
{
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

class ProDocumentWorker():DocumentWorker 
{
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

class ExpertDocumentWorker() : ProDocumentWorker
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
        Console.Write("Введите ключ продукта: ");
        string key;
        key = Console.ReadLine();
        DocumentWorker programm;
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
        programm.SaveDocument();
        programm.OpenDocument();
        programm.EditDocument();
    }
}

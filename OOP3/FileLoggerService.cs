namespace OOP3
{
    //FileLogger ve DatabeseLogger scriptleri sadece bir şablondur.
    //Bu şablonda istediğimiz kod işlemlerini sorunsuz gerçekleştirebiliriz.

    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya log işlemi başarılı oldu");
        }
    }
}


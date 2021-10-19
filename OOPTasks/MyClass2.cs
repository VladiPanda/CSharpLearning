namespace OOPTasks
{
    /*  Используя Visual Studio, создайте проект по шаблону Console Application. 
        В коллекцию ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа, 
        переберите данную коллекцию с помощью, цикла for – С какой проблемой вы столкнулись? */
    public class MyClass2
    {
     public int MyIntProperty { get; set; }
     public string MyStringProperty { get; set; }
    }
    
    
    // Все объекты которые мы будем передавать в ArrayList будут upcast к object включая свойства myClass2 и чтобы
    // получить к ним доступ нужно будет их даункастить обратно
}
using System;

namespace OOPTasks
{
    /*  Используя Visual Studio, создайте проект по шаблону Console Application. 
        Создайте класс CarCollection<T>. Реализуйте в простейшем приближении возможность
        использования его экземпляра для создания парка машин. Минимально требуемый интерфейс 
        взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и 
        года ее выпуска, индексатор для получения значения элемента по указанному индексу и свойство 
        только для чтения для получения общего количества элементов. 
        Создайте метод удаления всех машин автопарка. */
    public class CarCollection<T> : MyList<T>
    {
        // два поля "только для чтения" коллекций с названием машин и годом
        private readonly MyList<string> carName;
        private readonly MyList<DateTime> carYear;
        
        // конструктор инициализирует поля новыми экземплярами 
        public CarCollection()
        {
            carName = new MyList<string>();
            carYear = new MyList<DateTime>();
        }
        
        // метод принимающий название машины и год, и добавляющий их в коллекцию
        public void AddCar(string name, DateTime year)
        {
            carName.Add(name);
            carYear.Add(year);
        }
        // индексатор с проверкой выхода за пределы коллекции
        public new string this[int index]
        {
            get
            {
                if (index < carName.Count)
                {
                    return carName[index] + " " + carYear[index].Year + " year";
                }

                return "There is no car with this number";
            }
        }
        // свойство выводит размер коллекции
        public int Lenght
        {
            get { return carName.Count; }
        }
        // метод очищающий коллекции
        public void Remove()
        {
            carName.Clear();
            carYear.Clear();
        }
        
        // переопределенный метод ToString который будет выводить информацию о машинах
        public override string ToString()
        {
            string text = null;
            for (int i = 0; i < carName.Count; i++)
            {
                text += "№ " + (i + 1) + " " + carName[i] + " " + carYear[i].Year + " ";
            }

            if (text != null) return text;
            return "The is no any car in the park";
        }
    }
}
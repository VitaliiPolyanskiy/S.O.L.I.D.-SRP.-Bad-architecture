using System.Xml.Serialization;

namespace Single_responsibility_principle
{
    class Сontainer
    {
        List<Human> list = new List<Human>();

        #region Операции над данными в коллекции - первая ответственность
        public void Add(Human human)
        {
            list.Add(human);
            Console.WriteLine("Данные добавлены!");
        }
        public List<Human> Get() 
        { 
            return list; 
        }
        public void Remove(int index)
        {
            if (index < 0 || index >= list.Count)
                return;
            list.RemoveAt(index);
            Console.WriteLine("Удаление выполнено!");
        }
        public void RemoveAll()
        {
            list.RemoveRange(0, list.Count);
            Console.WriteLine("Все данные удалены!");
        }
        #endregion

        #region Печать данных - вторая ответственность
        public void Print()
        {
            if(list.Count == 0) 
            {
                Console.WriteLine("Список пуст!");
                return;
            }
            foreach (Human j in list)
            {
                Console.WriteLine(j.Name + "\t" + j.Age);
            }
        }
        #endregion

        #region Загрузка и сохранение данных  - третья ответственность
        public void SaveXmlSerializer()
        {
            FileStream stream = new FileStream("../../human.xml", FileMode.OpenOrCreate);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Human>));
            serializer.Serialize(stream, list);
            stream.Close();
            Console.WriteLine("Сериализация успешно выполнена!");
        }
        public void LoadXmlSerializer()
        {
            FileStream stream = new FileStream("../../human.xml", FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Human>));
            list = serializer.Deserialize(stream) as List<Human> ?? new List<Human>();
            stream.Close();
            Console.WriteLine("Десериализация успешно выполнена!");
        }
        #endregion

    }
}

using Newtonsoft.Json;

namespace Task1
{
    public class Database <T> where T : Dog
    {
        private string _folderPath;
        private string _filePath;

        public Database()
        {
            _folderPath = @"..\..\..\Dogs";
            _filePath = _folderPath + $@"\{typeof(T).Name}s.json";

            if(!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }
            if(!File.Exists(_filePath)) 
            { 
                File.Create(_filePath).Close();
            }
        }
        public void WriteToFile(List<T> data)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(data);
                using(StreamWriter sw = new StreamWriter(_filePath))
                {
                    sw.WriteLine(jsonData);
                }
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e.Message);
            }
        }

        public List<T> ReadFromFile ()
        {
            try
            {
                using(StreamReader streamReader = new StreamReader(_filePath))
                {
                    string data = streamReader.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<T>>(data);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        
        public List<T> GetAll()
        {
            List<T> data = ReadFromFile();
            return data;
        }

        public void Insert(T item)
        {
            List<T> data = ReadFromFile();
            data.Add(item);
            WriteToFile(data);
            
        }
    }
}

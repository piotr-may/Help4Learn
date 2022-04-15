using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace Help4Learn.Model
{
    public static class DatabaseEngine
    {
        public static void WriteTasks(List<Task> tasks,string fileName)
        {
            JsonSerialization.WriteToJsonFile<List<Task>>(tasks, fileName);
        }
    }

    public static class JsonSerialization
    {
        public static async void WriteToJsonFile<T>(T objectToWrite, string fileName,bool append = false) where T : new()
        {
            var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), fileName);
           
            var contentsToWriteToFile = Newtonsoft.Json.JsonConvert.SerializeObject(objectToWrite);
            using (var writer = File.CreateText(backingFile))//new System.IO.StreamWriter(stream
            {
                await writer.WriteAsync(contentsToWriteToFile);

            }

        }

        public static T ReadFromJsonFile<T>(string fileName) where T : new()
        {
            var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), fileName);
            if (backingFile == null || !File.Exists(backingFile))
            {
                return new T();
            }
            string FileData = string.Empty;
            using (var reader = new StreamReader(backingFile, true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    FileData = line;
                }
            }
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(FileData);
            
        }
    }
}

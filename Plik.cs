using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Projekt
{
    static class Plik
    {
        public static void Zapisz<T>(string sciezka, T obiektZapis) //Binarna serializacja obiektu
        {
            FileStream stream = null;
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                stream = File.Create(sciezka);
                formatter.Serialize(stream, obiektZapis);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
        public static T Wczytaj<T>(string sciezka)//Binarna deserializacja obiektu
        {
            FileStream stream = null;
            BinaryFormatter formatter = new BinaryFormatter();
            T obj;
            try
            {
                stream = new FileStream(sciezka, FileMode.Open);
                obj = (T)formatter.Deserialize(stream);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return obj;
        }
    }
}

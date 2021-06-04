using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Projekt
{
    static class Plik
    {
        public static void Zapisz<T>(string sciezka, T obiektZapis) //Binarna serializacja obiektu
        {
            FileStream stream = null;
            try
            {
                stream = File.Create(sciezka);
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, obiektZapis);
            }catch(Exception e)
            {
                //wypisanie wyjatku czy cos
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
        public static T Wczytaj<T>(string sciezka)//Binarna deserializacja obiektu
        {
            var stream = File.OpenRead(sciezka);
            var formatter = new BinaryFormatter();
            var obj = (T)formatter.Deserialize(stream);//deserializacja pliku i rzutowanie na obiekt klasy T
            stream.Close();
            return obj;
        }
    }
}

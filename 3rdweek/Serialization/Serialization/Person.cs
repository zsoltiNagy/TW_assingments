using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    class Person: IDeserializationCallback
    {
        string name;
        string address;
        string phone;
        DateTime dateOfRecording;
        [NonSerialized]
        int serialNumber;
        public static Random generator = new Random();
        public Person(string name, string address, string phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            dateOfRecording = DateTime.Now;
            SetSerialNumber();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public void SetSerialNumber()
        {
            this.serialNumber = generator.Next(10, 99);
        }

        public void SetSerialNumberFromSource(int n)
        {
            this.serialNumber = n;
        }

        public int GetSerialNumber()
        {
            return serialNumber;
        }

        public string SetFileName()
        {
            return "person" + serialNumber + ".dat";
        }

        public void Serialize()
        {
            IFormatter formatter = new BinaryFormatter();

            using (Stream stream = new FileStream(SetFileName(),
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, this);
            }
        }

        public static Person Deserialize(string fileName)
        {
            Person person;
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(fileName,
                FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                person = (Person)formatter.Deserialize(stream);
            }
            int serNum = Convert.ToInt32(fileName.Substring(fileName.Length - 6, 2));
            person.SetSerialNumberFromSource(serNum);
            return person;
        }

        public void OnDeserialization(object sender)
        {
            Console.WriteLine("Deserialization succesfully finished.");
        }

    }
}

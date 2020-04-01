using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;



namespace AttributesLiberary
{
    public class Attribute : IEquatable<Attribute>
    {   //Field and properties
        public string AttributeName { get; set; }
        public int AttributeID { get; set; }
        public int AttributeValue { get; set; }
        public override string ToString()
        {
            return "AttID: " + AttributeID + "   Attribute: " + AttributeName + " " + "Attribute Value: " + AttributeValue;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Attribute objAsAttribute = obj as Attribute;
            if (objAsAttribute == null) return false;
            else return Equals(objAsAttribute);
        }
        public override int GetHashCode()
        {
            return AttributeID;
        }
        public bool Equals(Attribute other)
        {
            if (other == null) return false;
            return (this.AttributeID.Equals(other.AttributeID));
        }
        public void AddAttributes()
        {
            string AttributeName = "";
            string Value = "";
            int ID = 0;
            List<Attribute> Attributes = new List<Attribute>();
            for(int i = 0; i < 6; i++)
            {
                ID++;
                Console.WriteLine("Type in the specific Attribute Name: ");
                AttributeName = Console.ReadLine();
                Console.WriteLine("Type in the amount for the Attribute:");
                Value = Console.ReadLine();
                Attributes.Add(new Attribute() { AttributeName = AttributeName, AttributeID = ID , AttributeValue = Convert.ToInt32(Value) });
                File.WriteAllText(@"C:\Users\rallo\source\repos\Dnddata\movie.json", JsonConvert.SerializeObject(Attributes));
                using (StreamWriter file = File.CreateText(@"C:\Users\rallo\source\repos\Dnddata\movie.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, Attributes);
                }
            }
            
            foreach (Attribute aAttribue in Attributes)
            {
                Console.WriteLine(aAttribue);
                
                
                
            }
            
        }
        
    }
        
        
    }

    //Movies movie = new Movies
    //{

    //    Name = "Bad Boys",

    //    Year = 199

    //};

//    File.WriteAllText(@"C:\Users\rallo\source\repos\Dnddata\movie.json", JsonConvert.SerializeObject(movie));

//    // serialize JSON directly to a file
//    using (StreamWriter file = File.CreateText(@"C:\Users\rallo\source\repos\Dnddata\movie.json"))
//    {
//        JsonSerializer serializer = new JsonSerializer();
//    serializer.Serialize(file, movie);
//    }
//// read file into a string and deserialize JSON to a type
//Movies movie1 = JsonConvert.DeserializeObject<Movies>(File.ReadAllText(@"C:\Users\rallo\source\repos\Dnddata\movie.json"));

//    // deserialize JSON directly from a file
//    using (StreamReader file = File.OpenText(@"C:\Users\rallo\source\repos\Dnddata\movie.json"))
//    {
//        JsonSerializer serializer = new JsonSerializer();
//Movies movie2 = (Movies)serializer.Deserialize(file, typeof(Movies));
//    }

//    string json = Json
//    dynamic stuff = JObject.Parse("{ 'Name': 'Jon Smith', 'Address': { 'City': 'New York', 'State': 'NY' }, 'Age': 42 }");

//string name = stuff.Name;
//string address = stuff.Address.State;
//Console.WriteLine(name);
//    Console.WriteLine(address);

    //    List<Attribute> Attributes = new List<Attribute>();
    //    Attributes.Add(new Attribute() { AttributeName = "Strenght ", AttributeID = 1, AttributeValue = 0 });
    //            Attributes.Add(new Attribute() { AttributeName = "Intelligence ", AttributeID = 2, AttributeValue = 0 });
    //            Attributes.Add(new Attribute() { AttributeName = "Wisdom ", AttributeID = 3, AttributeValue = 0 });
    //            Attributes.Add(new Attribute() { AttributeName = "Dexterity ", AttributeID = 4, AttributeValue = 0 });
    //            Attributes.Add(new Attribute() { AttributeName = "Constitution ", AttributeID = 5, AttributeValue = 0 });
    //            Attributes.Add(new Attribute() { AttributeName = "Constitution ", AttributeID = 6, AttributeValue = 0 });
    //            string AttributeValue = "";
    //    string Value = "";
    //    Console.WriteLine("Type in the specific Attribute Name: ");
    //            AttributeValue = Console.ReadLine();
    //            Console.WriteLine("Type in the amount for the Attribute:")
    //            Value = Console.ReadLine(); 
    //            Attributes.Add(new Attribute() { AttributeName = AttributeValue, AttributeID = 1, AttributeValue = Convert.ToInt32(StenghtValue)});
    //            foreach(Attribute aAttribue in Attributes)
    //            {
    //                Console.WriteLine(aAttribue);
    //            }
    //Console.ReadKey();

    //public class Movies
    //{
    //    public string Name { get; set; }
    //    public int Year { get; set; }

    //}





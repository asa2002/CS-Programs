using System;
namespace project
{
    public class Teacher
    {
        private string id;
        private string name;
        private string lastname;
        private int hours;
        private int payperonehour;
        public string Id
        {
            get {return id;}
            set {id=value;}
        }
        public string Name
        {
            get {return name;}
            set {name=value;}
        }
        public string Lastname
        {
            get {return lastname;}
            set {lastname=value;}
        }
        public int Hours
        {
            get {return hours;}
            set {hours=value;}
        }
        public int Payperonehour
        {
            get {return payperonehour;}
            set {if (value > 0){payperonehour=value;}}
        }
        public Teacher(){} //تابع مخرب
        public Teacher(string Id , string Name , string Lastname , int Hours , int Payperonehour)
        {
            id = Id;
            name = Name;
            lastname = Lastname;
            hours = Hours;
            payperonehour = Payperonehour;
        } //تابع سازنده
        private long Payment()
        {
            return hours*payperonehour;
        }
    }//end class
    class project2
    {
        public static void Main()
        {
            Teacher th = new Teacher("123" , "Ali" , "Shojaee" , 16 , 40000);
            long Pay = th.Payment();
            Console.WriteLine(Pay);
        }//end main
    }//end class Project2 
}//end namespace
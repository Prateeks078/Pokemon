// See https://aka.ms/new-console-template for more information
using Pokemon.Basics;

//Console.WriteLine("Hello, World!");

// Because member is static, So no object is required !!
//InputOutput.Run();

//Arrays.Run();

//ExceptionHandling.Run1();
//ExceptionHandling.Run2();



//----- Starting the Classes & Objects (ClassesObjects.cs)-----
//Book book1 = new Book();

//book1.title = "Romeo & Juliet";
//book1.pages = 230;
//book1.author = "Prateek Sharma";

//Console.WriteLine(book1.title);



//----- Starting with the Constructors (Constructor Class) -----
Car car1 = new Car("Mustang", 340000, "Elon Musk");
//Console.WriteLine(car1.brand);



// ----- Starting with the ObjectMethods Concepts (ObjectMethods.cs Class) ----
Student s1 = new Student("Anish", "Mathematics", 3.4);
Student s2 = new Student("Alex", "Mathematics", 9.5);

//Console.WriteLine(s1.hasMerit());
//Console.WriteLine(s2.hasMerit());


// ---- Working with the Getters & Setters(Putting a Double Wrapper Security Guard Encapsulation) -------
Movie m1 = new Movie("Harry-Potter", 9, "Mark James");
m1.Rating = -1; // This Line will never execute in this case 

Movie m2 = new Movie("Harry", -9999, "Mark J");
Console.WriteLine(m2.Rating); // In this case -999 will never be going to set coz if(value>=0) will give us false, hence default value 0 will come to o/p



// ---- Working with Static Methods ------
Song song1 = new Song("Waka-waka", 120, "Shakira");
Console.WriteLine("The current Count of Song is: " + Song.songCount);

Song song2 = new Song("Respect", 110, "Bohemiyan");
Console.WriteLine("The current Count of Song is: " + song2.GetsongCount());


// ---- Working with the inheritance Concepts -----
IndianChef c1 = new IndianChef();
c1.MakeChapatti();
c1.MakeRice();
c1.MakeSpecialDish();

Console.WriteLine("------------------");

RajasthaniChef r1 = new RajasthaniChef();
r1.MakeChapatti();
r1.MakeRice();
r1.MakeSpecialDish();

// Now, I want my RajasthaniChef to make his own specialDish, and for that i will be using
// Virtual keyword in the superclass and override in the subclass. Hence, any child class can override that particular method.



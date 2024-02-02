// // # parameter and argument by MyMethod

// // class MyMethod{
// //     static void MyMthod(string name, int age)
// //     {
// //         Console.WriteLine("My name is "+name+" and My age is "+age);
// //     }
// // static void Main(String[] args)
// // {
// //     MyMthod("Dharmesh",20);
// //     MyMthod("Bhargav",19);
// //     MyMthod("Kishan",19);
// // }
// // }
// //OutPut: -
// //My name is Dharmesh and My age is 20
// //My name is Bhargav and My age is 19
// //My name is Kishan and My age is 19
// //In the above program we have created a method named "MyMethod" which takes two parameters
// //"Name" of type string and "Age" of type integer. This method simply prints out
// //the name and age passed to it as arguments. In the main function we are calling this method
// //by passing different names and ages each time.






// //default parameter
// class program
// {
//     static void MyMethod(string country = "India")
//     {
//         Console.WriteLine(country);
//     }
//     public static void Main(String[] args)
//     {
//         MyMethod("Sweden");
//         MyMethod("Norway");
//         MyMethod();
//         MyMethod("Japan");
//     }
// }
// //Output :
// //Sweden
// //Norway
// //India
// //Japan







// # Return Values
// class return_values{
//     static int MyMethod(int x)
//     {
//         return 5 + x;
//     }
//     static void Main(String[] args)
//     {
//         Console.WriteLine(MyMethod(3));
//     }
// }
// // Output:
// //8


// class return_values{
//     static int MyMethod(int x,int y)
//     {
//         return x+y;
//     }
//     static void Main(String[] args)
//     {
//         int z= MyMethod(5,3);
//         Console.WriteLine(z);
//     }
// }
// // Output:
// // 8



// # named argument
// class named_argument
// {
//     static void MyMethod(string c1,string c2,string c3)
//     {
//         Console.WriteLine("The Youngest Child is: "+ c3);
//     }
//     public static void Main(String[] args)
//     {
//         MyMethod(c3:"John",c1:"Liam",c2:"zoro");
//     }
// }
// // Output:
// // The Youngest Child is: John






// # Method Overloading

// class method_overloading
// {
//     static int PlusMethodInt(int x,int y)
//     {
//         return x+y;   
//     }
//     static double PlusMethodDouble(double x,double y)
//     {
//         return x+y;
//     }
//     public static void Main(String[] args){
//         int num1=PlusMethodInt(8,4);
//     double num2=PlusMethodDouble(48.33,33.21);
//     Console.WriteLine("Int: "+num1);
//     Console.WriteLine("Double: "+num2);
//     }

// }
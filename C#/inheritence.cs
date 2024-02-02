// // class A{
// //     protected   int a=10,b=20,c;
// //     public void add()
// //     {
// //         c=a+b;
// //         Console.WriteLine("Addition "+c);
// //     }
// //     public void sub()
// //     {
// //         c=a-b;
// //         Console.WriteLine("Substraction "+c);
// //     }
// // }
// // class B:A{
// //     public void multi()
// //     {
// //         c=a*b;
// //         Console.WriteLine("Multiplication "+c);
// //     }
// //     public void div()
// //     {
// //         c=a/b;
// //         Console.WriteLine("Division "+c);
// //     }
// //     public static void Main(String[] args)
// //     {
// //         B b1=new B();
// //         b1.add(); b1.sub(); b1.multi(); b1.div();
// //     }
// // }





// interface A{
//     void add(); //public
// }
// interface B{
//     void sub(); //public
// }
// class C:A,B{
//     public void add(){
//         int a=10,b=20;
//         Console.WriteLine(a+b);
//     }
//     public void sub(){
//         int a=10,b=20;
//         Console.WriteLine(a-b);
//     }
//     static void Main(){
//         C c1=new C();
//         c1.add(); c1.sub();
//     }
// }
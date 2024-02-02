// // table using c#
// // https://stackoverflow.com/questions/167304/create-a-
// //-html-table-in-c-sharp
// using System;
// public class Program 
// {
//     public static void Main(String[] args)
//     {
//         Console.WriteLine("<HTML><BODY>");
//         PrintHtmlTable(5, 5);
//         Console.Write("</BODY></HTML>");
//     }
//     private static void PrintHtmlTable(int rows, int cols)
//     {
//         string row = "tr>";
//         string col = "td>";
//         for (int i=0; i<rows; i++)
//         {
//             Console.Write(row + Environment.NewLine);
//             for (int j=0; j<cols; j++)
//             {
//                 Console.Write(col+"Row "+i+", Col "+j+"<br>"+
//                 col.ToLower()+"This is Row "+i+", Col "+j+Environment
//                 .NewLine);
//             }
//         }
//     }

// }
// /* Output:
// <HTML><BODY>
// <tr>
// <td>Row 0, Col 0<br>this is row 0, col
// 0<td>Row 0, Col 1<br>this is row 0,
// col 1<td>Row 0, Col 2<br>this is row
// 0, col 2<td>Row 0, Col 3<br>this is
// row 0, col 3<td>Row 0, Col 4<br>
// this is row 0, col 4<tr>
// .
// .
// .
// */
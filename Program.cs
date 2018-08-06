using System;

class Program
{
    static void Main(string[] args)
    {
        Bird c;
        Console.WriteLine("c = new Bird ( 60 );");
        Console.WriteLine("????????????????????????????????");
        // fix 練習二 #2 觀察下一行
        //    ,  此範例 new Bird ( 60 )
        //    為用 Bird 類別的某建構子 
        //    來產生 Bird 物件的語法
        c = new Bird(60);
        Console.WriteLine("################################");
        // fix #6 印出Bird物件的"移動速度"物件資料 
        Console.WriteLine("c.移動速度 : "
          + c.移動速度);
        Console.WriteLine(" Bird d = new Bird( );");
        Console.WriteLine("################################");
        // fix #10 觀察下一行
        Bird d = new Bird();
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("d.移動速度 : " + d.移動速度);
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine("結束");
        Console.WriteLine();
        Console.WriteLine();
    }
}

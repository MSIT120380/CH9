using System;

class Animal
{
    public double 移動速度 = 2; // 2 km/hour
// fix #9 觀察下一行,  此範例
//       為 Animal類別的其他建構子
//       , 此建構子沒有 引數
    public Animal()
    {
        Console.WriteLine(
          "Animal的沒有參數建構子"
          );
    }
    // fix #5 練習四 所用的建構子
    public Animal(double m)
    {
        移動速度 = m;
        Console.WriteLine(
          "Animal的double參數建構子,m為"
          + m);
    }
}



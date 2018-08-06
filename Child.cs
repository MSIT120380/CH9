using System;

class Bird
    // fix #1 觀察下一行
    //,  此範例為 Bird 繼承自 Animal 的語法
    //  , 意味 Bird 是衍生自 Animal
    : Animal
// fix #11 將下一行註解取消, 看會如何?
// 觀察下一行
//, 此範例為 Bird繼承自 Object類別的語法
//  , 意味 Bird 是 Object的基底類別
//  , 觀察完後恢復成註解
//, Object
{
    // fix #3 練習二 所用的建構子 
    public Bird(double m)
      // fix 練習四 #4  
      // 下面語法來挑選使用 Animal 類別的某建構子
      : base(m)
    {
        Console.WriteLine(
          "Bird的double參數建構子");
    }
    // fix  #7 觀察下一行,  此範例
    // 為用 Bird 類別的其他建構子
    //, 此建構子沒有參數
    public Bird()
    // fix  #8 觀察下一行
    // 會自動挑選使用 Animal 類別沒有參數的建構子
    {
        Console.WriteLine(
          "Bird的沒有參數建構子");
    }
}


using System;

class Day2_1_1
{
    static void Main()
    {
        Console.WriteLine("{0} {1} {2}", "Hello", "World", "!"); // Hello World !
        Console.WriteLine("{2} {1} {0}", "Hello", "World", "!"); // ! World Hello

        Console.WriteLine("{0} + {1} = {2}", 1, 2, 1 + 2); // 1 + 2 = 3
        Console.WriteLine("{0} + {1} = {2}", 10, 20, 10 * 20); // 10 + 20 = 200

        
        int calc1 = 1 + 2; // 3
        Console.WriteLine(calc1);
        Console.WriteLine(calc1 + 10); //13

        int a; //宣言
        a = 1; //代入
        Console.WriteLine(a); // 変数aを出力

        int b = 2; //宣言と代入を同時に行う
        Console.WriteLine(b); // 変数bを出力

        int a = -10; // 整数型(int型)の変数aを宣言
        a = "Hello"; // 整数型(int型)の変数に文字列型(string型)を代入してるのでエラー：型の不一致

        string b = "Hello"; // 文字列型(string型)の変数bを宣言
        b = 10; // 文字列型(string型)の変数に整数型(int型)を代入してるのでエラー

        string d = "10";
        d + 10; // 文字列型(string型)の変数に整数型(int型)を足してるのでエラー


        int a, b, c; // 3つの整数型の変数を同時に宣言
        a = 1;
        b = 2;
        c = 3;

        int a = 1, b = 2, c = 3; // 3つの整数型の変数を同時に宣言と代入

        int 1num = 1; // 変数名の先頭に数字は使えない(エラー)

        //予約語は変数名に使えない
        int int = 1; // intは予約語
        var string = "Hello"; // stringは予約語

        var i = 0;
        var str = "Hello";
        var b = true;

        //以下と同義
        int i = 0;
        string str = "Hello";
        bool b = true;

        // 右の型がわかりにくいので明示的な変数とする
        int var3 = Convert.ToInt32(Console.ReadLine()); 
        int var4 = ExampleClass.ResultSoFar();

        // 次の文ではループ変数を明示的に宣言している
        foreach (char ch in laugh)
        {
            if (ch == 'h')
                Console.Write("H");
            else
                Console.Write(ch);
        }
        Console.WriteLine();
                

        //代入演算子
        int a;
        a = 1; // 1を変数aに代入.
        a += 2; // a = a + 2 と同じ. a=1+2=3. 

        int b = 1;
        int c = -10;
        b += c; // b = b + c と同じ. b=1+(-10)=-9.

        //cast
        int a = 10;
        double b = 3.14;
        /*intとdoubleは型が違うのでそのままでは演算できない*/
        int c = a + (int)b; // キャストを使ってdouble型のbをint型に変換している, c=10+3=13.

        //ただし、「整数型(int) → 実数型(double)」へのキャストは不要。
        int a = 10;
        double b = 3.14;
        double c = a + b; // int型のaがdouble型に自動的にキャストされる
        
        //double → int はキャストが必要
        double a = 3.14;
        int b = (int)a; // double型のaをint型に明示的にキャスト

        //const
        const int a = 10; // 定数aを宣言
        const string str = "Hello"; // 定数strを宣言


        //if文

        Console.WriteLine("process 1");
        Console.WriteLine("process 2");
        Console.WriteLine("process 3");
        
        Console.WriteLine("process A");
        var term = false;
        if(term) {
            Console.WriteLine("process B");Natural number
        }
        Console.WriteLine("process C");

        var a = 0;
        if(a > 0) {
            Console.WriteLine("変数aは a > 0");
        }

        if(<条件式A>) {
            if(<条件式B>) {
                <処理> // 条件式Aと条件式Bが両方trueの場合の処理
            }
        }

        var termA = true;
        var termB = true;
        var termC = true;

        if(termA && termB && termC) {
            Console.WriteLine("termA, termB, termC が全てtrue");
        }
        if((termA && termB) || termC)  {
            Console.WriteLine("termA, termB がともにtrue ,または termC がtrue");
        }
        if(!termA || (termB && termC)) {
            Console.WriteLine("termAがfalse, または termB, termC がともにtrue");
        }

        //A. if文で式を評価した後に、別の<条件式>を評価する方法
        if(termA) {
            if(termB) {
                if(termC) {
                    Console.WriteLine("termA, termB, termC がtrue");
                }
            }
        }

        //B. <条件式>に複数の式を持たせる方法
        if(termA && termB && termC) {
            Console.WriteLine("termA, termB, termC がtrue");
        }

        

        var num  = 1;
        if(num == 1) {
            Console.WriteLine("one");
        } else if(num == 2) {
            Console.WriteLine("two");
        } else if(num == 3) {
            Console.WriteLine("three");
        } else {
            Console.WriteLine("不適切な値です.");
        }

        var num = 1;
        switch(num) { //条件判定したい変数や式を指定
            case 1: //その変数,式の値が1の場合
                Console.WriteLine("one");
                break;
            case 2: //その変数,式の値が2の場合
                Console.WriteLine("two");
                break;
            case 3: //その変数,式の値が3の場合
                Console.WriteLine("three");
                break;
            default: //どのcaseにも当てはまらない場合
                Console.WriteLine("不適切な値です.");
                break;
        }

        //break文
        


}

class ExampleClass
{
    public static int ResultSoFar()
    {
        return 0;
    }
}
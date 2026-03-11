using System;
using System.Collections.Generic;

// 1. Equals 메서드
{
    var tp1 = (1, 2, 3);
    var tp2 = (1, 2, 4);
    var tp3 = (1, 2, 3);

    Console.WriteLine(tp1.Equals(tp3));
    Console.WriteLine(tp1.Equals(tp2));
    Console.WriteLine();
    Console.WriteLine();
}

// 2. == 및 != 연산자
{
    var tp1 = (1, 2, 3);
    var tp3 = (1, 2, 3);

    Console.WriteLine(tp1 == tp3);
    Console.WriteLine(tp1 != tp3);
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 타입 호환성 - 기본
{
    (string, int) tp = ("Alice", 25);
    (string, int) tp2 = tp;
    Console.WriteLine($"{tp2.Item1}, {tp2.Item2}");
    Console.WriteLine();
    Console.WriteLine();
}

// 4. 타입 호환성 - 주의사항
{
    (string name, int age, char gender) tp = ("Bob", 23, 'M');
    (string name2, int age2, char gender2) tp2 = tp;

    Console.WriteLine(tp.name);
    Console.WriteLine(tp.age);
    Console.WriteLine(tp.gender);
    Console.WriteLine();
    Console.WriteLine();
}

// 5. 제네릭과 튜플 - 리스트
{
    List<(string name, int age)> list = new List<(string name, int age)>();

    list.Add(("Alice", 25));
    list.Add(("Bob", 30));
    list.Add(("Charlie", 35));

    foreach (var item in list) {
        Console.WriteLine($"{item.name} : {item.age}세");
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 6. 딕셔너리의 키로 튜플 사용
{
    Dictionary<(int x, int y), string> dict = new Dictionary<(int x, int y), string>();

    dict.Add((0, 0), "원점");
    dict.Add((1, 0), "오른쪽");

    Console.WriteLine($"{dict[(0, 0)]}");
    Console.WriteLine($"{dict[(1, 0)]}");
    Console.WriteLine();
    Console.WriteLine();
}

// 7. System.Tuple 클래스
{
    var tp = new Tuple<string, int>("Bob", 23);
    Console.WriteLine($"{tp.Item1}, {tp.Item2}");

    var t2p = Tuple.Create("Alice", 25);
    Console.WriteLine($"{t2p.Item1}, {t2p.Item2}");

    Console.WriteLine();
    Console.WriteLine();
}
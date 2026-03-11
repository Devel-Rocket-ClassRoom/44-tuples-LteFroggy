using System;
using System.Collections.Generic;

List<(string name, int quantity, int price)> itemList = new List<(string name, int quantity, int price)>();
AddItem(itemList, "체력 포션", 3, 500);
AddItem(itemList, "마나 포션", 5, 800);
AddItem(itemList, "해독제", 2, 300);
AddItem(itemList, "엘릭서", 1, 5000);

Console.WriteLine($"=== 아이템 인벤토리 ===");
foreach (var item in itemList) {
    Console.WriteLine($"{item.name} - 수량 : {item.quantity}, 단가 : {item.price:N0}원");
}
Console.WriteLine();

Console.WriteLine($"=== 가장 비싼 아이템 ===");
var (name, price) = FindMostExpensive(itemList);
Console.WriteLine($"이름 : {name}, 단가 : {price:N0}원");
Console.WriteLine();

Console.WriteLine($"=== 인벤토리 합산 ===");
var (totalPrice, totalCount) = CalculateTotal(itemList);
Console.WriteLine($"총 가치 : {totalPrice:N0}원");
Console.WriteLine($"총 아이템 수 : {totalCount}개");
Console.WriteLine();
Console.WriteLine();


void AddItem(List<(string name, int quantity, int price)> inventory, string name, int quantity, int price) {
    inventory.Add((name, quantity, price));
}

(string name, int price) FindMostExpensive(List<(string name, int quantity, int price)> itemList) {
    string highestPriceName = "";
    int highestPrice = Int32.MinValue;

    foreach (var item in itemList) {
        if (highestPrice < item.price) {
            highestPrice = item.price;
            highestPriceName = item.name;
        }
    }

    return (highestPriceName, highestPrice);
}

(int totalValue, int totalCount) CalculateTotal(List<(string name, int quantity, int price)> itemList) {
    int totalCount = 0;
    int totalValue = 0;

    foreach (var item in itemList) {
        totalCount += item.quantity;
        totalValue += item.quantity * item.price;
    }

    return (totalValue, totalCount);
}
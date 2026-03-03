using System;

var bibimbap = new Recipe("비빔밥", 2, 5);
bibimbap.AddIngredient("밥");
bibimbap.AddIngredient("고추장");
bibimbap.AddIngredient("계란");
bibimbap.AddIngredient("시금치");
bibimbap.AddIngredient("당근");

bibimbap.PrintRecipe();
Console.WriteLine($"계란 포함: {bibimbap.HasIngredient("계란")}");
Console.WriteLine($"소고기 포함: {bibimbap.HasIngredient("소고기")}");
Console.WriteLine();

var sandwich = new Recipe("샌드위치", 1, 3);
sandwich.AddIngredient("빵");
sandwich.AddIngredient("햄");
sandwich.AddIngredient("치즈");

sandwich.PrintRecipe();

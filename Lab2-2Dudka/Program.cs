Console.WriteLine("Введите двухзначное число");
int number = Convert.ToInt32 (Console.ReadLine());
int tensDigit = number / 10;
int onesDigit = number % 10; 
bool containsThreeAndSeven = (tensDigit == 3 || onesDigit == 3) && (tensDigit == 7 || onesDigit == 7);
Console.WriteLine("Входят ли в число 3 и 7: " + containsThreeAndSeven);
bool containsFourAndEightOrNine = (tensDigit == 4 || onesDigit == 4) && (tensDigit == 8 || onesDigit == 8) || (tensDigit == 9 || onesDigit == 9);
Console.WriteLine("Входят ли в число 4 и 8, или 9: " + containsFourAndEightOrNine);
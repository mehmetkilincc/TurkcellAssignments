// See https://aka.ms/new-console-template for more information

int[] numbers = { 1, 5, 90, 13, 63, 78, 4, 9, 16 };

int total = 0;
int max = numbers[0];
int min = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    //En büyük sayı
    if (numbers[i] > max)
        max = numbers[i];
}

for (int i = 1; i < numbers.Length; i++)
{
    //En küçük sayı 
    if (numbers[i] < min)
        min = numbers[i];
}

for (int i = 0; i < numbers.Length; i++)
{
    //Dizi elemanları toplamı
    total += numbers[i];
}

float average = (float)total / numbers.Length;

Console.WriteLine($"Dizinin en büyük elemanı : {max} \nDizinin en küçük elemanı : {min}\n" +
                  $"Dizi elemanlarının toplamı : {total}\nDizi elemanlarının ortalaması : {average}");

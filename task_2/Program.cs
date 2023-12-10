using System;

Random rand = new Random();
int N = 10;
char [] mas = new char [N];
for (int i=0;i<N;i++){
    mas[i] = (char)rand.Next(0x0410, 0x44F);
    Console.Write($"{mas[i]}\t");
}
string str = Convert.ToString(mas[0]);
for(int i=1;i<N;i++){
    str += Convert.ToString(mas[i]);
}
Console.WriteLine($"\n{str.ToLower()}");
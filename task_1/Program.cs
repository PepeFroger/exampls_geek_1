using System;

Random rand = new Random();
int N = 5, M = 5;
char [,] mas = new char [N,M];
for (int i=0;i<N;i++){
    for (int j=0;j<M;j++){
        mas[i, j] = (char)rand.Next(0x0410, 0x44F);
        Console.Write($"{mas[i,j]}\t");
    }
    Console.WriteLine();
}
string str = Convert.ToString(mas[0,0]);
for (int i=0;i<N;i++){
    for (int j=0;j<M;j++){
        if(i==0 & j==0){
            j++;
        }
        str += Convert.ToString(mas[i,j]);
    }
}

Console.WriteLine(str);
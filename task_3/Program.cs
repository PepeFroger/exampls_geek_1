using System;

string? str = "qwrwqq";
int count = 0;
for(int i=0;i<str.Length/2;i++){
    if (str[i]==str[str.Length-i-1]){
        count++;
    }
}
if (str.Length/2%2==0){
    if(count==str.Length/2){
        Console.WriteLine($"Строка {str} является полиндромом");
    }
    else{
        Console.WriteLine($"Строка {str} не является полиндромом");
    }
}else{
        if(count==(str.Length/2)+1){
        Console.WriteLine($"Строка {str} является полиндромом");
    }
    else{
        Console.WriteLine($"Строка {str} не является полиндромом");
    }
}

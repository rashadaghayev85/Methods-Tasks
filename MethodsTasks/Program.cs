﻿//////////////////////////////////////////////////////////HOME TASKS

//1. Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
string IsDivide(int n)
{
    if (n % 3 == 0 && n % 7 == 0)
    {
        return "bolunur";
    }
    return"bolunmur";
}

//Console.WriteLine(IsDivide(21));

//2. n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

int SumOfNumbers(int n,int m)
{
    
    if (n % 2 == 0 && m % 2 == 0)
    {
        int sum = 0;
        sum = n + m;
        return sum;
    }
    return 0;
}
//Console.WriteLine(SumOfNumbers(2,3));

//3. Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

// n<m ve "n,m araliga daxildir" oldugunu qebul ediirik
int OddOfNumbers(int n,int m)
{
    int count = 0;
        for (int i = n; i <= m; i++)
    {
        if (i%2!=0)
        {
            count++;
        }
    }
    return count;   
}
//Console.WriteLine(OddOfNumbers(2,9));

//4. Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.
// n<m oldugunu ve n,m araliga daxildir qebul edirik
int SumOddOfNumbers(int n, int m)
{
    int sum = 0;
    for (int i = n; i <= m; i++)
    {
        if (i % 2 != 0)
        {
            sum+=i;
        }
    }
    return sum;
}
//Console.WriteLine(SumOddOfNumbers(1,5));

//5.Verilmish arrayin icindeki tek ededlerin cemini tapin.

int SumOfNumbersArray(int[] elems)
{
    int sum = 0;
    for (int i = 0; i <elems.Length; i++)
    {
        if (elems[i]%2!=0)
        {
            sum += elems[i];
        }
    }
    return sum;
}
//int[] elems = { 1, 2, 3, 4, 5, 6 };
//Console.WriteLine(SumOfNumbersArray(elems));

//6.Verilmish arrayin icindeki cut ededlerin sayini tapin.

int CountOfNumbersArray(params int[] elems )
{
    int count = 0;
    for (int i = 0; i < elems.Length; i++)
    {
        if (elems[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
//Console.WriteLine(CountOfNumbersArray(1,2,3,4,5,6));

//7.Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

 string NumbersMethods(int n)
{
    int count = 0;
   if (n == 0 || n==1)
    {
        return "ne sade ne murekkeb";
    }
   else 
    {
    for (int i = 1;i <= n;i++) 
    {
        if (n%i==0)
        {
            count++;
        }
    }
    if (count >2) 
    {
        return "murekkeb";
    }
    else 
    {
        return "sade";
            
    }
    }
}
//Console.WriteLine(NumbersMethods(6));

//8.n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.Meselen: Cavablar ola biler:2,4,8,16,32 ve s. Yeni n bele ededler olmalidir.



string PowerMethod(int n)
{
    int number = 1;
    
    if (n == 1)
    {
        return "quvvetidir";
    }
    else
    {
        for(int i = 2; i <= n; i*=2)
        {
            if (n%i==0)
            {
                number *= 2;
                
                if (n==number)
                {
                    return "quvvetidir";
                    
                }
            }
            else
            {
                return "quvveti deyil";
                
            }

        }
        return "quvveti deyil";
        
    }
}
//Console.WriteLine(PowerMethod(64));

//9.Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.Mes ([1,3,55,6,33], cavab: 18).


int ResultOfNumbersArray(params int[] elems)//params yazamasaq 180ci setri aktiv edib consolun icine elems yazmaliyiq
{
    int result = 1;
    for (int i = 0; i < elems.Length; i++)
    {
        if (elems[i] >= 1 && elems[i]<20)
        {
            result *= elems[i];
            
        }
    }
    return result;
}
//int[] elems = { 1, 55, 3, 6, 33 };
//Console.WriteLine(ResultOfNumbersArray(1,55,3,6,33));

//10.Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.

int SquareOfNumbersArray( int[] elems)
{
    int sum = 0;
    int result;
    for (int i = 0; i < elems.Length; i++)
    {
        if (elems[i]%2==0)
        {
            sum += elems[i];

        }
    }
    result = sum*sum;
    return result;
}
//int[] elems = { 1, 2, 3, 45,4,2,11 };
//Console.WriteLine(SquareOfNumbersArray(elems));

////////////////////////////////////////////////////////////CLASS TASKS
///
//11.temp qebul eden method yazirsiz. Return type olan method olmalidir. Method temp 20den boyukdurse isti, kicikdirse soyuq, beraberdirse mulayim mesajlarini qaytarsin.
string TempMethod(int n)
{
    if (n == 20)
    {
        return "mulayim";
    }
    else if (n > 20)
    {
        return "isti";
    }
    else
    {
        return "soyuq";
    }
}
//Console.WriteLine(TempMethod(20));

//12.methoda a ve b ededleri gelecek, method a ve b arasindaki ededlerin sayini qaytarsin.
int CountMethod(int a,int b)// a ve b daxil deyil
{
    int count = 0;
    if (a > b)
    {
        count = a - b;
        count--;
        return count;
    }
    else if (a < b)
        {
        count=b-a;
        count--;    
        return count;
        }
    else
    {
       
        return count;
    }
}
//Console.WriteLine(CountMethod(7,4));

//13.method reqemlerden ibaret 2 array qebul edecek, her iki arrayin elementlerinin cemini geri qaytarsin.
int SumOfArray(int[] arr1, int[] arr2)
{
    int sum1 = 0;   
    int sum2 = 0;
    int result = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        sum1+= arr1[i]; 
    }
    for (int i = 0; i < arr2.Length; i++)
    {
        sum2+= arr2[i]; 
    }
    result=sum1+sum2;   
    return result;  
}
//int[] arr1 = { 1, 2, 3, 4, 5 };
//int [] arr2 ={ 1,2,3,4,5};
//Console.WriteLine(SumOfArray(arr1,arr2));

//14.methoda eded gelir, hemin method ededin kvadratini geriye qaytarsin.
int SquareOneNumber(int n)
{
    int result = 0;
    if (n == 0)
    {
        return 0;
    }
    else
    {
        result = n*n;
        return result;
    }
}
//Console.WriteLine(SquareOneNumber(4));

//15.methoda eded gelir, hemin method 1-den gelen edede qeder olan cut ededlerin cemini geri qaytarsin.
int SumNumbers(int n)
{
    int sum = 0;
    for (int i = 1;i <=n; i++)
    {
        if (i%2== 0)
        {
            sum += i;
        }
    }
    return sum;
}
//Console.WriteLine(SumNumbers(6));


















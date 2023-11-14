int[] x = new int[10];


//int[] aval = new int[9];
//aval[0] = 2;
//aval[1] = 3;
//aval[2] = 5;
//aval[3] = 7;
//aval[4] = 11;
//aval[5] = 13;
//aval[6] = 17;
//aval[7] = 19;
string[] name = new string[100];



name[0] = "hossein"; name[1] = "ali";
name[2] = "mohsen"; name[3] = "bahram";
name[4] = "kazem"; name[5] = "behrooz";
name[6] = "amir"; name[7] = "sina";
name[10] = " eskandar"; name[11] = " reza";
name[12] = "mahram"; name[13] = "bahram";
name[14] = " shahram"; name[15] = "shadmehr";
name[16] = " ebi"; name[17] = "korosh";
name[18] = "ehsan"; name[19] = "ahmad";
name[20] = " salar"; name[21] = "sorena";
name[22] = "avesta"; name[23] = "ramin";
name[24] = "alireza"; name[25] = "mobin";
name[26] = "saeid"; name[27] = "moein";
name[28] = "mehdi"; name[29] = "sadegh";
name[30] = "jalal"; name[31] = "bohlol";
name[32] = "masood"; name[33] = "erfan";
name[34] = "majid"; name[35] = "omid";
name[36] = "mehrdad"; name[37] = "hesam";
name[38] = "iliya"; name[39] = "ashkan";
name[40] = "bardiya"; name[41] = "benjamin";
name[42] = "babak"; name[43] = "behnam";
name[44] = "pooya"; name[45] = "khosro";
name[46] = "daryoosh"; name[47] = "sirvan";
name[48] = "sadra"; name[49] = "sobhan";
name[50] = "shahab"; name[51] = "zahra";
name[52] = "fatemeh"; name[53] = "reyhaneh";
name[54] = "homa"; name[55] = "sara";
name[56] = "mona"; name[57] = "azita";
name[58] = "nazanin"; name[59] = "niloofar";
name[60] = "nastaran"; name[61] = "helen";
name[62] = "asal"; name[63] = "ava";
name[64] = "ghazal"; name[65] = "hana";
name[66] = "mersana"; name[67] = "aseman";
name[68] = "darya"; name[69] = "donya";
name[70] = "baran"; name[71] = "ayda";
name[72] = "maedeh"; name[73] = "negar";
name[74] = "negin"; name[75] = "samira";
name[76] = "elnaz"; name[77] = "elham";
name[78] = "narges"; name[79] = "ameneh";
name[80] = "zeynab"; name[81] = "nasrin";
name[82] = "mahnaz"; name[83] = "bahar";
name[84] = "niki"; name[85] = "sadaf";
name[86] = "nahid"; name[87] = "akram";
name[88] = "james"; name[89] = "ben";
name[90] = "kevin"; name[91] = "marco";
name[92] = "selena"; name[93] = "antony";
name[94] = "taylor"; name[95] = "alan";
name[96] = "maria"; name[97] = "roze";
name[98] = "harry"; name[99] = "nicolas";

Console.WriteLine("esm daneshjo ro vared namaid :");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Pishrafte1**" + System.Environment.NewLine +
    "Tafsir" + System.Environment.NewLine +
    "Riazi" + System.Environment.NewLine +
    "Kargah" + System.Environment.NewLine +
    "Zaban Khareji" + System.Environment.NewLine +
    "Pishrafte2**" + System.Environment.NewLine +
    "Sheygaraei**" + System.Environment.NewLine +
    "SystemAmel*" + System.Environment.NewLine +
    "Algoritm*" + System.Environment.NewLine
    );
Console.ForegroundColor = ConsoleColor.White;

string nam = Console.ReadLine();

for (int i = 0; i < x.Length; i++)
{
    x[i] = Random.Shared.Next(0, 21);
    if (x[i] > 16)
    {
        Console.WriteLine("{0},{1},{2}", nam, x[i], "A");
    }
    else if (x[i] <= 17 && x[i] >= 15)
    {
        Console.WriteLine("{0},{1},{2}", nam, x[i], "B");
    }
    else if (x[i] < 15 && x[i] >= 13)
    {
        Console.WriteLine("{0},{1},{2}", nam, x[i], "C");
    }
    else if (x[i] < 13 && x[i] >= 10)
    {
        Console.WriteLine("{0},{1},{2}", nam, x[i], "D");
    }
    else if (x[i] < 10 && x[i] >= 7)
    {
        Console.WriteLine("{0},{1},{2}", nam, x[i], "E");
    }
    else if (x[i] < 7 && x[i] >= 3)
    {
        Console.WriteLine("{0},{1},{2}", nam, x[i], "F");
    }
    else if (x[i] < 3)
    {
        Console.WriteLine("{0},{1},{2}", nam, x[i], "G");
    }


}
int x1 = x[0] * 3;
int x2 = x[1] * 1;
int x3 = x[2] * 2;
int x4 = x[3] * 1;
int x5 = x[4] * 2;
int x6 = x[5] * 3;
int x7 = x[6] * 3;
int x8 = x[7] * 1;
int x9 = x[8] * 3;
int x10 = x[9] * 3;

double sum = x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10;
double moadelkol = sum / 22;
Console.WriteLine("moadel kole doros : " + moadelkol);

double sum1 = x1 + x6 + x7;
double moadel1 = sum1 / 9;
Console.WriteLine("moadel** : " + moadel1);

double sum2 = x9 + x10;
double moadel2 = sum2 / 6;
Console.WriteLine("moadel* : " + moadel2);
Console.ReadLine(); 
//surena karimi tamrine 7
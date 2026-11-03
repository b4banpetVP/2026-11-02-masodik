double jelszo_erosseg(string jelszo)
{
    int erosseg = 1;
    if (jelszo.Length >=5 )
    {
        erosseg += 1;
    };
    if (jelszo.Length >= 8)
    {
        erosseg += 2;
    };
    foreach (char i in jelszo)
    {
        if (i == '-')
        {
            erosseg += 2;
        };

        if (i == '_')
        {
            erosseg += 2;
        };
        
        if (i == '.')
        {
            erosseg += 2;
        };
    }
    if (jelszo.Contains("jelszo")) {
        erosseg = 0;
    };
    if (jelszo.Contains("123"))
    {
        erosseg = 0;
    };
    if (jelszo.Length == 0)
    {
        erosseg = 0;
    }
    ;
return(erosseg);
}
Console.WriteLine(jelszo_erosseg("ez1feltorhetetlenjelszo"));

//7. feladat: Magánhangzó eltávolítás
List<char> maganhangzok = new() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
string maganhangzot_torol(string szoveg)
{
    string szovegketto = "";
    foreach (char i in szoveg)
    {
        if (maganhangzok.Contains(i) == false)
        {
            szovegketto += i;
        }
    }
    return(szovegketto);
}
Console.WriteLine(maganhangzot_torol("Iden Java szigeten voltunk nyaralni. Nem is tudtam, hogy elneveztek egy helyet egy programozasi nyelvrol"));

//8.feladat: Szöveg titkosítása

string kodol(string uzenet,int szam,char karakter)
{ string kodolt_uzenet = "";
    foreach (char i in uzenet) 
    { 
        kodolt_uzenet += i;
            for (int j = 1; j<=szam;j++)
            {
            kodolt_uzenet+=karakter;
            }
    }
    return (kodolt_uzenet);
}

Console.WriteLine(kodol("Pizza delben?", 3, 'x'));
using klasaPersonklasaChild;

Test1();
Console.WriteLine();
Test2();
Console.WriteLine();
Test34();
Console.WriteLine();
Test5();
Console.WriteLine();
Test6();
Console.WriteLine();
Test7();
Console.WriteLine();
Test8();
Console.WriteLine();
Test9();
Console.WriteLine();
Test10();
Console.WriteLine();
Test11();
Console.WriteLine();
Test12();
Console.WriteLine();
Test13();









void Test1()
{
    /* Test: poprawne tworzenie obiektu Person, dane poprawne */
    try
    {
        Person p = new Person(familyName: "Storozhuk", firstName: "Yuliana", age: 18);
        Console.WriteLine(p);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Test2()
{
    /* Test: poprawne tworzenie obiektu Person,
   błędne imię lub nazwisko, spacje przed i po */
    try
    {
        Person p = new Person(familyName: "  Storozhuk    ", firstName: " Yuliana ", age: 18);
        Console.WriteLine(p);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Test34()
{
    /* Test: poprawne tworzenie obiektu Person,
   błędne imię lub nazwisko, spacje w środku */
    try
    {
        Person p = new Person(familyName: "Storoz  huk", firstName: "Yuliana.", age: 18);
        Console.WriteLine(p);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Test5()
{
    /* Test: poprawne tworzenie obiektu Person,
   błędne imię lub nazwisko, pierwsza duża pozostałe małe */
    try
    {
        Person p = new Person(familyName: "STorozhuk", firstName: "yuliana", age: 18);
        Console.WriteLine(p);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Test6()
{
    /* Test: poprawne tworzenie obiektu Person,
   błędne imię lub nazwisko, niewłaściwy wiek */
    try
    {
        Person p = new Person(familyName: "STorozhuk", firstName: "yuliana", age: -18);
        Console.WriteLine(p);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Test7()
{
    /* Test: modyfikacja obiektu */
    try
    {
        Person p = new Person(familyName: "Storozhuk", firstName: "Yuliana", age: 18);
        p.modifyFirstName(" Ew a");
        p.modifyFamilyName("storozuk ");
        p.modifyAge(35);
        Console.WriteLine(p);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Test8()
{
    /* Test: tworzenie obiektu Child */
    try
    {
        Person o = new Person(familyName: "Storozhuk", firstName: "Vadim", age: 30);
        Person m = new Person(familyName: "Storozhuk", firstName: "Yuliana", age: 29);
        Child d = new Child(familyName: "Storozhuk", firstName: "Anna", age: 10,
                            mother: m, father: o);
        Console.WriteLine(d);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Test9()
{
    /* Test: tworzenie obiektu Child
   zły wiek */
    try
    {
        Person o = new Person(familyName: "Storozhuk", firstName: "Vadim", age: 30);
        Person m = new Person(familyName: "Storozhuk", firstName: "Yuliana", age: 29);
        Child d = new Child(familyName: "Storozhuk", firstName: "Anna", age: 18,
                            mother: m, father: o);
        Console.WriteLine(d);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Test10()
{
    /* Test: tworzenie obiektu Child
   brak rodziców */
    try
    {
        Child d = new Child(familyName: "Storozhuk", firstName: "Anna", age: 14);

        Console.WriteLine(d);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Test11()
{
    /* Test: tworzenie obiektu Child
   modyfikacja danych */
    try
    {
        Person o = new Person(familyName: "Storozhuk", firstName: "Vadim", age: 30);
        Person m = new Person(familyName: "Storozhuk", firstName: "Yuliana", age: 29);
        Child d = new Child(familyName: "Storozhuk", firstName: "Anna", age: 14,
                            mother: m, father: o);
        d.modifyFirstName("Aneta");
        Console.WriteLine(d);
        d.modifyFamilyName("Storozuk");
        Console.WriteLine(d);
        d.modifyAge(18);
        Console.WriteLine(d);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Test12()
{
    /* Test: tworzenie obiektu Child 
   brak jednego z rodziców */
    try
    {
        Person o = new Person(familyName: "Storozhuk", firstName: "Vadim", age: 30);
        Person m = new Person(familyName: "Storozhuk", firstName: "Yuliana", age: 29);
        Child d = new Child(familyName: "Storozhuk", firstName: "Anna", age: 14, father: o);
        Console.WriteLine(d);
        d = new Child(familyName: "Storozhuk", firstName: "Anna", age: 14, mother: m);
        Console.WriteLine(d);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Test13()
{
    /* Test: poprawne tworzenie obiektu Person,
   błędne imię lub nazwisko, spacje w środku*/
    try
    {
        Person p = new Person(familyName: "Storoz  huk", firstName: "Yuliana", age: 18);
        Console.WriteLine(p);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
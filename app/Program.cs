using app.obj;

Console.WriteLine("Caooss");

Primer_ValueType();
Primer_ReferenceType();
Primer_Passing_Obj_to_Method();

Console.WriteLine(Person.Velika_Slova("aj cao")); //primer pozivanja staticke metode klase


static void Primer_ValueType()
{
    var number = 1; // Alocirana je memorija na steku i upisana vrednost
    var number2 = number; // Alocirana je druga memorija za number2 i kopirana vrednost
    number2++;
    Console.WriteLine("number - {0}, number2 - {1}", number, number2); 
}

static void Primer_ReferenceType()
{
    Person person1 = new Person { Name = "Ivana" }; // Na steku je upisana referenca - adresa vrednosti upisane u heap-u
    Person person2 = new Person { Name = "Ana" }; 

    person2 = person1; // Kopirana je referenca sa person1 na person2 stek, i sada obe pokazuju na istu lokaciju

    person2.Name = "Višnja";
    person1.Ispiši_Ime();  // Višnja logicno; Primer za non-static clana klase
}

static void Primer_Passing_Obj_to_Method()
{
    Person person1 = new Person { Name = "Mihajlo" };
    ChangeName(person1);
    person1.Ispiši_Ime();
}

static void ChangeName(Person p)
{
    p.Name = "Ime je promenjeno";
}


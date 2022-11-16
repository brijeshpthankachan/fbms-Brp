


class A
{
    public void Fa() => Console.WriteLine("From A");
}
class B:A
{
    public void Fb() => Console.WriteLine("From A");
}

class C:A
{
    public void Fc() => Console.WriteLine("From A");
}



interface Istudent
{
    int Total();
}

class SchoolStudent : Istudent
{
    public int M1, M2;
    public int Total() => M1 + M2;
}


class CollegeStudent : Istudent
{
    public int M1, M2;
    public int Total() => M1 + M2+5;
}


interface IEmailSender
{
    void SendEmail(string x);
}

class GmailSender : IEmailSender
{
    public void SendEmail(string x)=> Console.WriteLine("Gmail "+x);

}

class OutLookSender : IEmailSender
{
    public void SendEmail(string x) => Console.WriteLine("OutLook " + x);

}
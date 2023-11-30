public class Program{
    
}

public class CpfNotFoundException : Exception
{
    public CpfNotFoundException() : base("CPF não encontrado."){}
}

public class CnaNotFoundException : Exception
{
    public CnaNotFoundException() : base("CNA não encontrado."){}
}

public class RepeatedRegisterAttorneyException : Exception
{
    public RepeatedRegisterAttorneyException() : base("CPF ou CNA já cadastrado."){}
}

public class RepeatedRegisterClientException : Exception
{
    public RepeatedRegisterClientException() : base("CPF já cadastrado."){}
}

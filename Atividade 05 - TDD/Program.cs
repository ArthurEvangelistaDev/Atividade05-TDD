internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite a senha:");
        String senha = Console.ReadLine();


        Console.WriteLine(validaSenha(senha).ToString());


    }

    public static String validaSenha(String senha)
    {
        String retorno = "";
        if (senha.Length < 8)
        {
            retorno += "A senha deve ter pelo menos 8 caracteres.";
        }
        if (senha.Count(char.IsDigit) < 2)
        {
            retorno += "A senha deve conter pelo menos 2 dígitos.";
        }
        if (!senha.Any(char.IsUpper))
        {
            retorno += "A senha deve conter pelo menos uma letra maiuscula.";
        }
        if (!senha.Any(c => !char.IsLetterOrDigit(c)))
        {
            retorno += "A senha deve conter pelo menos um caractere especial.";
        }

        return retorno;
    }

}
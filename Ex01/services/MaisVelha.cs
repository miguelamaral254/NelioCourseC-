namespace Ex01.services;

public class MaisVelha
{
    public static void EncontrarMaisVelha(Pessoa[] pessoas)
        {
            if (pessoas == null || pessoas.Length == 0)
    {
        Console.WriteLine("Não há pessoas para avaliar.");
        return;
    }
            int idadeMaisVelha = int.MinValue;
            List<string> pessoasMaisVelhas = new List<string>();

            foreach (var pessoa in pessoas)
            {
                if (pessoa.Idade > idadeMaisVelha)
                {
                    idadeMaisVelha = pessoa.Idade;
                    pessoasMaisVelhas.Clear();
                    pessoasMaisVelhas.Add(pessoa.Nome);
                }
                else if (pessoa.Idade == idadeMaisVelha)
                {
                    pessoasMaisVelhas.Add(pessoa.Nome);
                }
            }
            if (pessoasMaisVelhas.Count > 1)
            {
                Console.WriteLine($"{string.Join(", ", pessoasMaisVelhas)} têm a mesma idade e são os mais velhos.");
            }
            else
            {
                Console.WriteLine($"{pessoasMaisVelhas[0]} é o mais velho.");
            }
        }
}

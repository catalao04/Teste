class Program
{
    static void Main(string[] args)
    {
        MiniZoo miniZoo = new MiniZoo();
        miniZoo.AdicionarAnimal(new Leao("Leao", 0, 0));
        miniZoo.AdicionarAnimal(new Cobra("Cobra", 0, 0));

        miniZoo.EmitirSomDeTodosOsAnimais();
        miniZoo.ImprimirSomDeTodosOsAnimais();

    }
}

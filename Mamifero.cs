public class Mamifero : Animal
{
    public Mamifero(string nome, int idade) : base(nome, idade) { 

        
        
    }

    override public string EmitirSom(){
        return "Au Au";
    }

}

public class Leao : Mamifero{

    public int TamanhoGrupo { get; set; }

    override public string EmitirSom(){
        return "Au Au";
    }

    public Leao(string nome, int idade, int TamanhoGrupo) : base(nome, idade) {

        this.TamanhoGrupo = TamanhoGrupo;

    }

}

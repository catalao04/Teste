public class Reptil : Animal
{
    public Reptil(string nome, int idade) : base(nome, idade) {

        

    }

    public override string EmitirSom(){
            return "SSSSSSSSSSS";
    }

    
}

public class Cobra : Reptil{

    public double Comprimento { get; set; }

    public override string EmitirSom(){
        return "SSSSSSSSSSS";
    }

    public Cobra(string nome, int idade, int Comprimento) : base(nome, idade) {

        this.Comprimento = Comprimento;

    }

}



// Desafio Fixação POO - Implementação completa em C#
// Autor: (preencha seu nome)
// Data de geração: 2025-09-04
// Observação: Este arquivo compila como um app de console (.NET 6+).
// Para executar: dotnet new console -n DesafioPOO && substitua Program.cs por este arquivo, ou
// compile com: csc DesafioFixacaoPOO.cs && ./DesafioFixacaoPOO.exe

using System;
using System.Collections.Generic;
using System.Globalization;

namespace DesafioFixacaoPOO
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Desafio de Fixação POO (C#) ===");
            Section1.Run();
            Section2.Run();
            Section3.Run();
            Section4.Run();
            Section5.Run();
            Section6.Run();

            Console.WriteLine("\n--- Fim da execução. ---");
            Console.WriteLine("Dica: faça uma captura de tela desta saída para anexar ao seu repositório.");
        }
    }

    // -------------------- SEÇÃO 1 --------------------
    public static class Section1
    {
        // Q1
        class Pessoa { }

        // Q2
        class Carro { public string Cor { get; set; } = "Vermelho"; }

        // Q3
        class Animal { public string Nome { get; set; } public int Idade { get; set; }
            public Animal(string nome, int idade){ Nome = nome; Idade = idade; } }

        // Q4
        class Livro {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public void ExibirInfo() => Console.WriteLine($"Livro: \"{Titulo}\", Autor: {Autor}");
        }

        // Q5
        class Quadrado { public double Lado { get; set; } public double Area() => Lado * Lado; }

        // Q6
        class Aluno { public string Nome { get; set; } public double Nota { get; set; } }

        // Q7
        class Circulo {
            public double Raio { get; set; }
            public double Area() => Math.PI * Raio * Raio;
            public double Perimetro() => 2 * Math.PI * Raio;
        }

        // Q8
        class ContaBancaria {
            public decimal Saldo { get; private set; } = 0m;
            public void Depositar(decimal valor){ Saldo += valor; }
        }

        // Q9
        class Produto {
            public string Nome { get; set; }
            public decimal Preco { get; set; }
            public void AplicarDesconto() { Preco *= 0.9m; }
        }

        // Q10
        class Ponto {
            public double X { get; set; }
            public double Y { get; set; }
            public double DistanciaOrigem() => Math.Sqrt(X * X + Y * Y);
        }

        public static void Run()
        {
            Console.WriteLine("\n--- Seção 1: Introdução a Classes e Objetos (Q1-Q10) ---");

            // Q1
            var p = new Pessoa();
            Console.WriteLine("Q1: Pessoa instanciada.");

            // Q2
            var c = new Carro();
            Console.WriteLine($"Q2: Carro.Cor = {c.Cor}");

            // Q3
            var a = new Animal("Rex", 3);
            Console.WriteLine($"Q3: Animal Nome={a.Nome}, Idade={a.Idade}");

            // Q4
            var l = new Livro { Titulo = "POO na Prática", Autor = "Ana Dev" };
            Console.Write("Q4: "); l.ExibirInfo();

            // Q5
            var q = new Quadrado { Lado = 4 };
            Console.WriteLine($"Q5: Área do quadrado (lado 4) = {q.Area()}");

            // Q6
            var al1 = new Aluno { Nome = "João", Nota = 8.5 };
            var al2 = new Aluno { Nome = "Maria", Nota = 9.0 };
            var melhor = al1.Nota > al2.Nota ? al1.Nome : al2.Nome;
            Console.WriteLine($"Q6: Maior nota: {melhor}");

            // Q7
            var circ = new Circulo { Raio = 3 };
            Console.WriteLine($"Q7: Área={circ.Area():F2}, Perímetro={circ.Perimetro():F2}");

            // Q8
            var cb = new ContaBancaria();
            cb.Depositar(250m);
            Console.WriteLine($"Q8: Saldo após depósito = {cb.Saldo:C}");

            // Q9
            var prod = new Produto { Nome = "Mouse", Preco = 100m };
            prod.AplicarDesconto();
            Console.WriteLine($"Q9: {prod.Nome} com desconto = {prod.Preco:C}");

            // Q10
            var pto = new Ponto { X = 3, Y = 4 };
            Console.WriteLine($"Q10: Distância até origem = {pto.DistanciaOrigem():F2}");
        }
    }

    // -------------------- SEÇÃO 2 --------------------
    public static class Section2
    {
        // Q11
        class Retangulo { public double Largura { get; } public double Altura { get; }
            public Retangulo(double w, double h){ Largura = w; Altura = h; }
            public double Area() => Largura * Altura; }

        // Q12
        class Funcionario {
            public string Nome { get; } public decimal Salario { get; private set; }
            public Funcionario(string nome, decimal salario){ Nome = nome; Salario = salario; }
            public void AumentarSalario(double percentual){ Salario += (decimal)percentual/100m * Salario; }
        }

        // Q13
        class Data {
            public int Dia { get; } public int Mes { get; } public int Ano { get; }
            public Data(int d,int m,int a){ Dia=d;Mes=m;Ano=a; }
            public string Formatar() => $"{Dia:00}/{Mes:00}/{Ano:0000}";
        }

        // Q14
        class Veiculo { public string Marca { get; } public string Modelo { get; }
            public Veiculo(string marca, string modelo){ Marca=marca;Modelo=modelo; }
            public void Acelerar(){ Console.WriteLine("Acelerando!"); } }

        // Q15
        class Triangulo {
            public double L1,L2,L3;
            public Triangulo(double l1,double l2,double l3){L1=l1;L2=l2;L3=l3;}
            public double Perimetro()=>L1+L2+L3;
        }

        // Q16
        class Usuario {
            public string Nome { get; } public string Email { get; private set; }
            public Usuario(string nome, string email){ Nome=nome; Email=email; }
            public void AlterarEmail(string novo)=> Email=novo;
        }

        // Q17
        class Biblioteca {
            private List<string> titulos = new();
            public void AdicionarLivro(string titulo)=> titulos.Add(titulo);
            public IEnumerable<string> Listar()=> titulos;
        }

        // Q18
        class Calculadora {
            public double Somar(double a,double b)=>a+b;
            public double Subtrair(double a,double b)=>a-b;
            public double Multiplicar(double a,double b)=>a*b;
            public double Dividir(double a,double b)=> b==0? double.NaN : a/b;
        }

        // Q19
        class Agenda {
            private List<string> contatos;
            public Agenda(List<string> contatos){ this.contatos = contatos; }
            public string? BuscarContato(string nome)=> contatos.Find(c=> c.Contains(nome,StringComparison.OrdinalIgnoreCase));
        }

        // Q20
        class Jogo {
            public string Nome { get; } public string Plataforma { get; }
            public Jogo(string nome,string plataforma){ Nome=nome;Plataforma=plataforma; }
            public void Jogar()=> Console.WriteLine($"Jogando {Nome} no {Plataforma}!");
        }

        public static void Run()
        {
            Console.WriteLine("\n--- Seção 2: Métodos e Construtores (Q11-Q20) ---");
            var r = new Retangulo(5,4);
            Console.WriteLine($"Q11: Área retângulo = {r.Area()}");

            var f = new Funcionario("Carla", 3000m);
            f.AumentarSalario(10);
            Console.WriteLine($"Q12: {f.Nome} novo salário = {f.Salario:C}");

            var d = new Data(1,9,2025);
            Console.WriteLine($"Q13: Data formatada = {d.Formatar()}");

            var v = new Veiculo("VW","Gol");
            Console.Write("Q14: "); v.Acelerar();

            var t = new Triangulo(3,4,5);
            Console.WriteLine($"Q15: Perímetro triângulo = {t.Perimetro()}");

            var u = new Usuario("Alex","alex@ex.com");
            u.AlterarEmail("alex.novo@ex.com");
            Console.WriteLine($"Q16: Email alterado para {u.Email}");

            var bib = new Biblioteca();
            bib.AdicionarLivro("Clean Code");
            bib.AdicionarLivro("Refactoring");
            Console.WriteLine("Q17: Livros => " + string.Join(", ", bib.Listar()));

            var calc = new Calculadora();
            Console.WriteLine($"Q18: 12/3 = {calc.Dividir(12,3)}");

            var ag = new Agenda(new List<string>{"João - 999","Maria - 888"});
            Console.WriteLine($"Q19: Buscar 'ma' => {ag.BuscarContato("ma") ?? "não encontrado"}");

            var j = new Jogo("Hollow Knight","PC");
            Console.Write("Q20: "); j.Jogar();
        }
    }

    // -------------------- SEÇÃO 3 --------------------
    public static class Section3
    {
        // Q21
        class Pessoa { private int _idade; public int Idade { get=>_idade; set=>_idade=value; } }

        // Q22
        class Conta {
            private decimal saldo;
            public void Depositar(decimal v)=> saldo+=v;
            public bool Sacar(decimal v){ if(v<=saldo){ saldo-=v; return true; } return false; }
            public decimal Saldo()=> saldo;
        }

        // Q23
        class Aluno {
            private double nota;
            public double Nota { get=>nota; set{ if(value>=0 && value<=10) nota=value; } }
        }

        // Q24
        class Produto {
            private decimal preco;
            public Produto(decimal precoInicial){ preco = Math.Max(0m, precoInicial); }
            public void AplicarDesconto(decimal valor){
                preco -= valor;
                if (preco < 0) preco = 0;
            }
            public decimal Preco => preco;
        }

        // Q25
        class Carro {
            private int velocidade;
            private const int Max = 200;
            public void Acelerar(int delta){ velocidade = Math.Min(Max, velocidade+delta); }
            public int Velocidade => velocidade;
        }

        // Q26
        class Usuario {
            private string senha;
            public Usuario(string senha){ this.senha = senha; }
            public bool Autenticar(string tentativa)=> senha == tentativa;
        }

        // Q27
        class Banco {
            private List<int> contas = new();
            public void Adicionar(int id){ if(!contas.Contains(id)) contas.Add(id); }
            public bool Remover(int id)=> contas.Remove(id);
            public IEnumerable<int> Listar()=> contas;
        }

        // Q28
        class Forma {
            private double area;
            public Forma(double areaCalculada){ area = areaCalculada; }
            public double Area => area;
        }

        // Q29
        class Empregado {
            private decimal salario;
            public Empregado(decimal salario){ this.salario=salario; }
            public decimal CalcularBonus()=> salario * 0.10m;
        }

        // Q30
        class Configuracao {
            private Dictionary<string,string> dict = new();
            public void Set(string chave,string valor)=> dict[chave]=valor;
            public string? Get(string chave)=> dict.TryGetValue(chave,out var v)? v : null;
        }

        public static void Run()
        {
            Console.WriteLine("\n--- Seção 3: Encapsulamento (Q21-Q30) ---");

            var p = new Pessoa { Idade = 25 };
            Console.WriteLine($"Q21: Idade = {p.Idade}");

            var c = new Conta(); c.Depositar(100m);
            Console.WriteLine($"Q22: Saque 30 => {c.Sacar(30m)}, Saldo={c.Saldo():C}");

            var a = new Aluno(); a.Nota = 9.5; a.Nota = 11; // ignorado
            Console.WriteLine($"Q23: Nota válida = {a.Nota}");

            var prod = new Produto(50m); prod.AplicarDesconto(60m);
            Console.WriteLine($"Q24: Preço após desconto = {prod.Preco:C}");

            var car = new Carro(); car.Acelerar(250);
            Console.WriteLine($"Q25: Velocidade = {car.Velocidade} (máx 200)");

            var usr = new Usuario("1234");
            Console.WriteLine($"Q26: Autenticar '1234' => {usr.Autenticar(\"1234\")}");

            var b = new Banco(); b.Adicionar(1); b.Adicionar(2); b.Remover(1);
            Console.WriteLine($"Q27: Contas => {string.Join(\", \", b.Listar())}");

            var f = new Forma(12.5);
            Console.WriteLine($"Q28: Área (somente get) = {f.Area}");

            var emp = new Empregado(2000m);
            Console.WriteLine($"Q29: Bônus = {emp.CalcularBonus():C}");

            var cfg = new Configuracao(); cfg.Set("tema","escuro");
            Console.WriteLine($"Q30: Config 'tema' = {cfg.Get(\"tema\")}");
        }
    }

    // -------------------- SEÇÃO 4 --------------------
    public static class Section4
    {
        // Q31
        class Animal { public virtual string FazerSom()=> "Som"; }
        class Cachorro : Animal { public override string FazerSom()=> "Latir"; }

        // Q32
        class Veiculo { public int Velocidade { get; set; } }
        class Carro : Veiculo { public void Buzinar()=> Console.WriteLine("Biiip!"); }

        // Q33
        abstract class Forma { public abstract double Area(); }
        class Quadrado : Forma {
            public double Lado { get; }
            public Quadrado(double lado){ Lado=lado; }
            public override double Area()=> Lado*Lado;
        }

        // Q34
        class Pessoa { public string Nome{get;set;} public int Idade{get;set;} }
        class Aluno : Pessoa { public double Nota{get;set;} public void Estudar()=> Console.WriteLine($"{Nome} estudando..."); }

        // Q35
        class Conta { protected decimal saldo; public decimal Saldo => saldo; }
        class ContaPoupanca : Conta { public void RenderJuros(){ saldo += saldo * 0.01m; } public void Depositar(decimal v){ saldo+=v; } }

        // Q36
        class Funcionario { public decimal SalarioBase {get;set;} }
        class Gerente : Funcionario {
            public decimal Bonus {get;set;}
            public decimal SalarioTotal()=> SalarioBase + Bonus;
        }

        // Q37
        class Produto { public decimal Preco {get;set;} }
        class ProdutoDigital : Produto { public long TamanhoArquivoBytes {get;set;}
            public void Baixar()=> Console.WriteLine($"Baixando {TamanhoArquivoBytes} bytes..."); }

        // Q38
        class Transporte { public virtual string Mover()=> "Mover"; }
        class Aviao : Transporte { public int Altitude {get;set;} public override string Mover()=> "Voar"; }

        // Q39
        class Jogo { public string Nome {get;set;} }
        class JogoOnline : Jogo { public string Servidor {get;set;} public void Conectar()=> Console.WriteLine($"Conectando ao {Servidor}..."); }

        // Q40
        class BibliotecaItem { public string Titulo {get;set;} }
        class Livro : BibliotecaItem { public string Autor {get;set;} }
        class Revista : BibliotecaItem { public int Edicao {get;set;} }

        public static void Run()
        {
            Console.WriteLine("\n--- Seção 4: Herança Básica (Q31-Q40) ---");
            var dog = new Cachorro();
            Console.WriteLine($"Q31: Som do cachorro = {dog.FazerSom()}");

            var carro = new Carro{Velocidade=60};
            Console.Write("Q32: "); carro.Buzinar();

            var q = new Quadrado(6);
            Console.WriteLine($"Q33: Área quadrado = {q.Area()}");

            var al = new Aluno{Nome="Nina", Idade=20, Nota=9.8};
            Console.Write("Q34: "); al.Estudar();

            var cp = new ContaPoupanca(); cp.Depositar(1000m); cp.RenderJuros();
            Console.WriteLine($"Q35: Saldo com juros = {cp.Saldo:C}");

            var g = new Gerente{SalarioBase=4000m, Bonus=800m};
            Console.WriteLine($"Q36: Salário total gerente = {g.SalarioTotal():C}");

            var pd = new ProdutoDigital{Preco=59.90m, TamanhoArquivoBytes=1024*1024};
            Console.Write("Q37: "); pd.Baixar();

            var av = new Aviao{Altitude=10000};
            Console.WriteLine($"Q38: Transporte: {av.Mover()}, Altitude = {av.Altitude}");

            var jo = new JogoOnline{Nome="RPG-Z", Servidor="BR-1"};
            Console.Write("Q39: "); jo.Conectar();

            var li = new Livro{Titulo="POO Essencial", Autor="Dev X"};
            var re = new Revista{Titulo="Tech Monthly", Edicao=42};
            Console.WriteLine($"Q40: Livro='{li.Titulo}' de {li.Autor}; Revista='{re.Titulo}' edição {re.Edicao}");
        }
    }

    // -------------------- SEÇÃO 5 --------------------
    public static class Section5
    {
        // Q41
        class Animal { public virtual string Comer()=> "Comer"; }
        class Mamifero : Animal { public override string Comer()=> "Mamífero comendo"; }
        class Ave : Animal { public override string Comer()=> "Ave bicando"; }

        // Q42
        abstract class Empregado { public abstract decimal CalcularSalario(); }
        class Horista : Empregado {
            public decimal Horas {get;} public decimal Taxa {get;}
            public Horista(decimal horas, decimal taxa){ Horas=horas; Taxa=taxa; }
            public override decimal CalcularSalario()=> Horas * Taxa;
        }
        class Assalariado : Empregado {
            public decimal Fixo {get;}
            public Assalariado(decimal fixo){ Fixo=fixo; }
            public override decimal CalcularSalario()=> Fixo;
        }

        // Q43
        abstract class FormaGeometrica { public abstract double Perimetro(); }
        class Retangulo : FormaGeometrica {
            public double L, A; public Retangulo(double l,double a){L=l;A=a;}
            public override double Perimetro()=> 2*(L+A);
        }
        class Circulo : FormaGeometrica {
            public double R; public Circulo(double r){R=r;}
            public override double Perimetro()=> 2*Math.PI*R;
        }
        static double CalcularPerimetro(FormaGeometrica f)=> f.Perimetro();

        // Q44
        class Veiculo { public virtual string Acelerar()=> "Acelerar genérico"; }
        class Bicicleta : Veiculo { public override string Acelerar()=> "Pedalando mais rápido"; }
        class Moto : Veiculo { public override string Acelerar()=> "Acelerando motor"; }

        // Q45
        interface INadador { void Nadar(); }
        interface ICorredor { void Correr(); }
        class Triatleta : INadador, ICorredor {
            public void Nadar()=> Console.WriteLine("Triatleta nadando");
            public void Correr()=> Console.WriteLine("Triatleta correndo");
            public void Competir()=> Console.WriteLine("Triatleta competindo!");
        }

        // Q46
        abstract class Produto { public abstract decimal CalcularPreco(); }
        class ProdutoFisico : Produto {
            public decimal Base {get;} public decimal Frete {get;}
            public ProdutoFisico(decimal bas, decimal frete){ Base=bas; Frete=frete; }
            public override decimal CalcularPreco()=> Base + Frete;
        }
        class ProdutoServico : Produto {
            public decimal Base {get;} public decimal Taxa {get;}
            public ProdutoServico(decimal bas, decimal taxa){ Base=bas; Taxa=taxa; }
            public override decimal CalcularPreco()=> Base + Taxa;
        }

        // Q47
        class Pessoa { public string Nome{get;set;} }
        class Cliente : Pessoa { public void Comprar()=> Console.WriteLine($"{Nome} comprando..."); }
        class Fornecedor : Pessoa { public void Fornecer()=> Console.WriteLine($"{Nome} fornecendo..."); }

        // Q48
        abstract class Arquivo { public string Nome{get;set;} public long Tamanho{get;set;} public abstract void Abrir(); }
        class ArquivoTexto : Arquivo {
            public override void Abrir(){ if(Tamanho>0) Console.WriteLine($"Abrindo texto {Nome}"); else Console.WriteLine("Arquivo vazio"); }
        }
        class ArquivoBinario : Arquivo {
            public override void Abrir(){ if(Tamanho>0) Console.WriteLine($"Abrindo binário {Nome}"); else Console.WriteLine("Arquivo vazio"); }
        }

        // Q49
        abstract class ContaBancaria { public decimal Saldo {get; protected set;}
            public virtual bool Sacar(decimal v){ if(v<=Saldo){ Saldo-=v; return true; } return false; } }
        class ContaCorrente : ContaBancaria {
            public decimal Limite {get; set;}
            public override bool Sacar(decimal v){ if(v<=Saldo+Limite){ Saldo-=v; return true; } return false; }
        }
        class ContaInvestimento : ContaBancaria {
            public void Render(decimal taxa){ Saldo += Saldo * taxa; }
        }

        // Q50
        interface ITelaTouch { void Tocar(int x,int y); }
        abstract class Dispositivo { public abstract void Ligar(); }
        class Smartphone : Dispositivo, ITelaTouch {
            public override void Ligar()=> Console.WriteLine("Smartphone ligado");
            public void Tocar(int x,int y)=> Console.WriteLine($"Smartphone toque em ({x},{y})");
        }
        class Tablet : Dispositivo, ITelaTouch {
            public override void Ligar()=> Console.WriteLine("Tablet ligado");
            public void Tocar(int x,int y)=> Console.WriteLine($"Tablet toque em ({x},{y})");
        }

        public static void Run()
        {
            Console.WriteLine("\n--- Seção 5: Herança Avançada e Polimorfismo (Q41-Q50) ---");

            // Q41
            var animais = new List<Animal>{ new Mamifero(), new Ave() };
            Console.WriteLine("Q41: " + string.Join(" | ", animais.ConvertAll(a => a.Comer())));

            // Q42
            Empregado e1 = new Horista(160, 25m);
            Empregado e2 = new Assalariado(3000m);
            Console.WriteLine($"Q42: Horista={e1.CalcularSalario():C}, Assalariado={e2.CalcularSalario():C}");

            // Q43
            Console.WriteLine($"Q43: Perímetro Retângulo(5,3)={CalcularPerimetro(new Retangulo(5,3))}, Círculo(r=2)={CalcularPerimetro(new Circulo(2)):F2}");

            // Q44
            Veiculo v1 = new Bicicleta(); Veiculo v2 = new Moto();
            Console.WriteLine($"Q44: {v1.Acelerar()} | {v2.Acelerar()}");

            // Q45
            var tri = new Triatleta(); tri.Nadar(); tri.Correr(); tri.Competir();

            // Q46
            Produto pf = new ProdutoFisico(100m, 20m);
            Produto ps = new ProdutoServico(150m, 30m);
            Console.WriteLine($"Q46: Físico={pf.CalcularPreco():C}, Serviço={ps.CalcularPreco():C}");

            // Q47
            var listaPessoas = new List<Pessoa>{ new Cliente{Nome="Lia"}, new Fornecedor{Nome="Zé"} };
            Console.Write("Q47: ");
            foreach(var p in listaPessoas){
                if(p is Cliente cli) cli.Comprar();
                if(p is Fornecedor forn) forn.Fornecer();
            }

            // Q48
            Arquivo at = new ArquivoTexto{Nome="leia.txt", Tamanho=10};
            Arquivo ab = new ArquivoBinario{Nome="img.bin", Tamanho=0};
            Console.Write("Q48: "); at.Abrir(); ab.Abrir();

            // Q49
            var cc = new ContaCorrente{Saldo=100m, Limite=50m};
            var ci = new ContaInvestimento{Saldo=1000m}; ci.Render(0.05m);
            Console.WriteLine($"Q49: CC saque 120 => {cc.Sacar(120m)} (saldo={cc.Saldo}), Invest rendimento => {ci.Saldo:C}");

            // Q50
            Dispositivo s = new Smartphone(); s.Ligar(); ((ITelaTouch)s).Tocar(10,20);
            Dispositivo t = new Tablet(); t.Ligar(); ((ITelaTouch)t).Tocar(5,7);
        }
    }

    // -------------------- SEÇÃO 6 --------------------
    public static class Section6
    {
        // Q51
        abstract class Forma { public abstract double Area(); }
        class Triangulo : Forma { public double B,H; public Triangulo(double b,double h){B=b;H=h;} public override double Area()=> (B*H)/2; }
        class Retangulo : Forma { public double L,A; public Retangulo(double l,double a){L=l;A=a;} public override double Area()=> L*A; }

        // Q52
        abstract class Animal { public abstract string Mover(); }
        class Peixe : Animal { public override string Mover()=> "Nadar"; }
        class Passaro : Animal { public override string Mover()=> "Voar"; }

        // Q53
        abstract class Pagamento { public abstract string Processar(decimal valor); }
        class CartaoCredito : Pagamento { public override string Processar(decimal valor)=> $"Cartão aprovado: {valor:C}"; }
        class Boleto : Pagamento { public override string Processar(decimal valor)=> $"Boleto gerado: {valor:C}"; }

        // Q54
        abstract class Funcionario { public abstract decimal CalcularBonus(); }
        class Vendedor : Funcionario { public decimal Vendas {get;} public Vendedor(decimal vendas){Vendas=vendas;} public override decimal CalcularBonus()=> Vendas * 0.05m; }
        class Engenheiro : Funcionario { public override decimal CalcularBonus()=> 1000m; }

        // Q55
        abstract class Veiculo {
            public abstract double CalcularCombustivel(double distancia);
            public abstract void Viajar(double distancia);
        }
        class CarroEletrico : Veiculo {
            public override double CalcularCombustivel(double distancia)=> distancia * 0.15; // kWh fictício
            public override void Viajar(double distancia)=> Console.WriteLine($"Viajando {distancia} km de carro elétrico");
        }
        class CarroGasolina : Veiculo {
            public override double CalcularCombustivel(double distancia)=> distancia / 12.0; // litros fictício
            public override void Viajar(double distancia)=> Console.WriteLine($"Viajando {distancia} km de carro a gasolina");
        }

        // Q56
        abstract class Estrategia { public abstract void Executar(); }
        class Ataque : Estrategia { public override void Executar()=> Console.WriteLine("Estrategia de ATAQUE!"); }
        class Defesa : Estrategia { public override void Executar()=> Console.WriteLine("Estrategia de DEFESA!"); }

        // Q57
        abstract class Relatorio { public abstract string Gerar(); }
        class RelatorioPDF : Relatorio { public override string Gerar()=> "Relatório PDF: [conteúdo simulado]"; }
        class RelatorioExcel : Relatorio { public override string Gerar()=> "Relatório Excel: [conteúdo simulado]"; }

        // Q58
        abstract class ItemMenu { public abstract string Preparar(); }
        class PratoPrincipal : ItemMenu { public override string Preparar()=> "Preparando prato principal..."; }
        class Sobremesa : ItemMenu { public override string Preparar()=> "Preparando sobremesa..."; }

        // Q59
        abstract class Notificador { public abstract void Enviar(string msg); }
        class EmailNotificador : Notificador { public override void Enviar(string msg)=> Console.WriteLine($"Email: {msg}"); }
        class SMSNotificador : Notificador { public override void Enviar(string msg)=> Console.WriteLine($"SMS: {msg}"); }

        // Q60
        abstract class Simulador {
            public abstract void Iniciar();
            public abstract void Executar();
            public abstract void Finalizar();
        }
        class SimuladorJogo : Simulador {
            private int estado = 0;
            public override void Iniciar(){ estado = 1; Console.WriteLine("Jogo iniciado"); }
            public override void Executar(){ if(estado==1){ Console.WriteLine("Jogando..."); estado=2; } }
            public override void Finalizar(){ Console.WriteLine("Jogo finalizado"); }
        }
        class SimuladorTreinamento : Simulador {
            private string status = "novo";
            public override void Iniciar(){ status="iniciado"; Console.WriteLine("Treinamento iniciado"); }
            public override void Executar(){ if(status=="iniciado"){ Console.WriteLine("Treinando..."); status="concluindo"; } }
            public override void Finalizar(){ Console.WriteLine("Treinamento finalizado"); }
        }

        public static void Run()
        {
            Console.WriteLine("\n--- Seção 6: Classes Abstratas (Q51-Q60) ---");

            // Q51
            Forma f1 = new Triangulo(5,4);
            Forma f2 = new Retangulo(3,7);
            Console.WriteLine($"Q51: Triângulo área={f1.Area()}, Retângulo área={f2.Area()}");

            // Q52
            Animal an1 = new Peixe(); Animal an2 = new Passaro();
            Console.WriteLine($"Q52: Peixe={an1.Mover()}, Pássaro={an2.Mover()}");

            // Q53
            Pagamento p1 = new CartaoCredito(); Pagamento p2 = new Boleto();
            Console.WriteLine($"Q53: {p1.Processar(200m)} | {p2.Processar(150m)}");

            // Q54
            Funcionario fv = new Vendedor(50000m); Funcionario fe = new Engenheiro();
            Console.WriteLine($"Q54: Bônus Vendedor={fv.CalcularBonus():C}, Engenheiro={fe.CalcularBonus():C}");

            // Q55
            Veiculo ve = new CarroEletrico(); Veiculo vg = new CarroGasolina();
            Console.WriteLine($"Q55: Eletrico consumo(100km)={ve.CalcularCombustivel(100):F2}, Gasolina={vg.CalcularCombustivel(100):F2}");
            ve.Viajar(50); vg.Viajar(50);

            // Q56
            Estrategia ea = new Ataque(); Estrategia ed = new Defesa();
            Console.Write("Q56: "); ea.Executar(); ed.Executar();

            // Q57
            Relatorio rp = new RelatorioPDF(); Relatorio rx = new RelatorioExcel();
            Console.WriteLine($"Q57: {rp.Gerar()} | {rx.Gerar()}");

            // Q58
            ItemMenu im1 = new PratoPrincipal(); ItemMenu im2 = new Sobremesa();
            Console.WriteLine($"Q58: {im1.Preparar()} | {im2.Preparar()}");

            // Q59
            Notificador n1 = new EmailNotificador(); Notificador n2 = new SMSNotificador();
            Console.Write("Q59: "); n1.Enviar("Olá por Email"); n2.Enviar("Olá por SMS");

            // Q60
            Simulador sj = new SimuladorJogo();
            sj.Iniciar(); sj.Executar(); sj.Finalizar();
            Simulador st = new SimuladorTreinamento();
            st.Iniciar(); st.Executar(); st.Finalizar();
        }
    }
}

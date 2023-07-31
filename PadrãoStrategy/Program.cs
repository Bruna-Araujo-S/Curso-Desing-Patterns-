using CursoDesingPatterns;

namespace CursoDesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            NotaFiscalBuilder builder = new NotaFiscalBuilder();
            builder.AdicionaAcao(new Multiplicador(2));
            builder.AdicionaAcao(new Multiplicador(3));
            builder.AdicionaAcao(new Multiplicador(5.5));

            NotaFiscal notaFiscal = builder.ParaEmpresa("Caelum")
                .ComCnpj("123.456.789/0001-10")
                .ComItem(new ItemDaNota("Item 1", 100.0))
                .ComItem(new ItemDaNota("Item 1", 200.0))
                .ComItem(new ItemDaNota("Item 1", 300.0))
                .ComObservacoes("entregar notaFiscal pessoalmente")
                .NaDataAtual()
                .Constroi();



            //NotaFiscalBuilder criador = new NotaFiscalBuilder();
            //criador
            //.ParaEmpresa("Caelum Ensino")
            //.ComCnpj("12.123.123/0001-01")
            //.ComItem(new ItemDaNota("Item 1", 100.0))
            //.ComItem(new ItemDaNota("Item 2", 200.0))
            //.NaDataAtual()
            //.ComObservacoes("qualquer");


            //criador.AdicionaAcao(new EnviadorDeEmail());
            //criador.AdicionaAcao(new EnviadorDeSMS());
            //criador.AdicionaAcao(new NotaFiscalDAO());

            //NotaFiscalBuilder builder = new NotaFiscalBuilder();
            //builder.AdicionaAcao(new Multiplicador(2));
            //builder.AdicionaAcao(new Multiplicador(3));
            //builder.AdicionaAcao(new Multiplicador(5.5));

            //NotaFiscal nf = criador.Constroi();

            //Console.WriteLine(nf.ValorBruto);
            //Console.WriteLine(nf.Impostos);
            //Console.ReadKey();




            //Orcamento reforma = new Orcamento(500);

            //Console.WriteLine(reforma.Valor);

            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor);

            //reforma.Aprova();

            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor);

            //reforma.Finaliza();

            //Console.ReadKey();





            //Imposto iss = new ISS(new ICMS());

            //Orcamento orcamento = new Orcamento(500);

            //double valor = iss.Calcula(orcamento);

            //Console.WriteLine(valor);

            //Console.ReadKey();
        }
    }

}









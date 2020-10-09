namespace pacientesPessoas.Models
{
    public class Pacientes
    {
        public long id {get; set;}
        public int idPessoa {get; set;}
        public string data_entrada { get; set; }
        public string comorbidade {get; set;}
        public int grau{get;set;}

        //construtor
        public Pacientes(long id, int idPessoa, string data_entrada,
                          string comorbidade, int grau){
            this.id = id;
            this.idPessoa = idPessoa;
            this.data_entrada = data_entrada;
            this.comorbidade = comorbidade;
            this.grau = grau;
        }
    }
}
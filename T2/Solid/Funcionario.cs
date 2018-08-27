namespace Solid
{
    public class Funcionario
    {
        public Cargo Cargo;
        public double SalarioBase { get; set; }
        public Funcionario(Cargo cargo, double salarioBase)
        {
            Cargo = cargo;
            SalarioBase = salarioBase;
        }
        public double CalculaSalario()
        {
            return Cargo.Regra.Calcula(this);
        }
    }
}
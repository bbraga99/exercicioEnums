using System;


namespace exercicioEnum.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }// construtor padrao

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }// construtor recebendo parametros  
        
        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}

using System;

namespace Calculator.API // Убедитесь, что это имя совпадает с именем вашего проекта
{
    public class Calculation
    {
        public int Id { get; set; }
        public double NumberA { get; set; }
        public double NumberB { get; set; }
        public double Result { get; set; }

        // Добавим = DateTime.Now, чтобы время ставилось само
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

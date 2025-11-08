namespace DesignPatterns.Builder.House
{
    public class House
    {
        public int Floors { get; set; } = 1;
        public string RoofType { get; set; } = string.Empty;
        public int Rooms { get; set; } = 1;
        public bool HasGarage { get; set; } = false;
        public bool HasGarden { get; set; } = false;
        public bool HasSwimmingPool { get; set; } = false;
        public string DisplayInfo()
        {
            return $"Дом: {Floors} этаж(а/ей), {Rooms} комнат(а/ы), крыша: {RoofType}\n" +
            $"Гараж: {(HasGarage ? "есть" : "нет")}, " +
            $"Сад: {(HasGarden ? "есть" : "нет")}, " +
            $"Бассейн: {(HasSwimmingPool ? "есть" : "нет")}";
        }
    }
}

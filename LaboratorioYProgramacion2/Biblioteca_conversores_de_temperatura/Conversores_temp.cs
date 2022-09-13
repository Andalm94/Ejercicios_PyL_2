namespace Biblioteca_conversores_de_temperatura
{
    public class Conversor
    {
        public static float ConvertirAFarenheitACelsius(float temperaturaFarenheit)
        {
            return (temperaturaFarenheit - 32) * 5 / 9;
        }

        public static float ConvertirACelsiusAFarenheit(float temperaturaCelsius)
        {
            return (temperaturaCelsius * 9 / 5) + 32;
        }

        public static float ConvertirKelvinAFarenheit(float temperaturaKelvin)
        {
            return (temperaturaKelvin * 9 / 5) - 459.67F;
        }

        public static float ConvertirFarenheitAKelvin(float temperaturaFarenheit)
        {
            return (temperaturaFarenheit + 459.67F) * 5 / 9;
        }
    }
}
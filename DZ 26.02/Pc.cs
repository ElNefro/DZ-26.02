namespace DZ_26._02
{
    internal class Pc
    {
        private string model;
        private double cpu_ClockSpeed;
        private int ram;
        private int hdd;

        public Pc(string model, double cpu_ClockSpeed, int ram, int hdd)
        {
            this.model = model;
            this.cpu_ClockSpeed = cpu_ClockSpeed;
            this.ram = ram;
            this.hdd = hdd;
        }


        public void Info()
        {
            Console.WriteLine($"Model: {model}, CPU clock speed: {cpu_ClockSpeed}, RAM: {ram}, HDD: {hdd}\n");
        }
    }
}
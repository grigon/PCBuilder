using System;

namespace PCBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            RAM ram = new RAM("GoodRAM", -50, -10);
            CPU cpu = new CPU("Intel Core i3", -20, -30);
            PowerSupply power = new PowerSupply("Silentium PC", 100, -20);
            Fan fan = new Fan("Corsair", -10, 100);
            Fan fan2 = new Fan("Corsair", -10, 100);

            Computer comp = new Computer(4);

            comp.MountComponent(ram);
            comp.MountComponent(cpu);
            comp.MountComponent(power);
            comp.CheckIfWorks();
            comp.MountComponent(fan);
            comp.CheckIfWorks();
            comp.MountComponent(fan2);
        }
    }
}
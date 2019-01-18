using System;
using XProtocol;
using XProtocol.Serializator;

namespace Test
{
    internal class TestPacket
    {
        [XField(0)]
        public int TestNumber;

        [XField(1)]
        public double TestDouble;

        [XField(2)]
        public bool TestBoolean;
    }

    internal class Program
    {
        private static void Main()
        {
            Console.Title = "";
            Console.ForegroundColor = ConsoleColor.White;

            var packet = XPacket.Create(0, 0);
            packet.SetValue(0, 12345);

            var encr = packet.Encrypt().ToPacket();
            var decr = XPacket.Parse(encr);

            Console.WriteLine(decr.GetValue<int>(0));

            Console.ReadLine();
        }
    }
}

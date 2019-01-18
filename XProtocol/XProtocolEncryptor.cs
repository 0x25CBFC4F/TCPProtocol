namespace XProtocol
{
    public class XProtocolEncryptor
    {
        private static string Key { get; } = "2e985f930";

        public static byte[] Encrypt(byte[] data)
        {
            return RijndaelHandler.Encrypt(data, Key);
        }

        public static byte[] Decrypt(byte[] data)
        {
            return RijndaelHandler.Decrypt(data, Key);
        }
    }
}

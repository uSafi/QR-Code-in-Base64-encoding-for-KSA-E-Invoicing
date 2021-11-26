using System.Text;

namespace QR_Code_in_Base64_encoding_for_KSA_E_Invoicing
{
    public class TLV
    {
        public byte Tag { get; private set; }
        public string Value { get; private set; }
        public byte[] TLVbytes { get; private set; }
        public TLV(byte tag, string value)
        {
            this.Tag = tag;
            this.Value = value;

            var byteValue = Encoding.UTF8.GetBytes(value);
            TLVbytes = new byte[2 + byteValue.Length];
            TLVbytes[0] = tag;
            TLVbytes[1] = (byte)byteValue.Length;
            byteValue.CopyTo(TLVbytes, 2);
        }
    }
}

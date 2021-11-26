using QRCoder;

namespace QR_Code_in_Base64_encoding_for_KSA_E_Invoicing
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {            
            TLV sellerTlv = new(1, txtSellerName.Text);
            TLV vATnumber = new(2, txtVATNumber.Text);
            TLV timeStamp = new(3, txtTimeStamp.Text);
            TLV invoiceTotal = new(4, txtInvoiceTotal.Text);
            TLV VATTotal = new(5, txtVATTotal.Text);


            var result = ToBase64(new TLV[] { sellerTlv, vATnumber, timeStamp, invoiceTotal,VATTotal });
            txtBase64.Text = result;
            pboxQrImage.Image = GetQrImage(result);
        }

        public string ToBase64(TLV[] tlvList)
        {
            List<byte> TLV_Bytes = new List<byte>();
            foreach (var tlv in tlvList)
            {
                TLV_Bytes.AddRange(tlv.TLVbytes);
            }
            return Convert.ToBase64String(TLV_Bytes.ToArray());
        }
        private Bitmap GetQrImage(string value)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("The payload aka the text which should be encoded.", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }
    }
}
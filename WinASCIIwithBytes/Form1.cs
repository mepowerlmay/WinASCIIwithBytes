using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace WinASCIIwithBytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbASCII.Checked = true;
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            if (rbASCII.Checked == false
                && rb2.Checked == false
                && rb10.Checked == false
                && rb16.Checked == false)
            {
                MessageBox.Show("請選擇轉換來源 項目 ");
                return;
            }

            if (string.IsNullOrEmpty(txtFromValue.Text) || string.IsNullOrWhiteSpace(txtFromValue.Text))
            {
                MessageBox.Show("轉換 來源 資料不可為空 或 空白");
                return;
            }

            txtResultASCII.Text = "";
            txtResult2.Text = "";
            txtResult10.Text = "";
            txtResult16.Text = "";

            if (rbASCII.Checked)
            {
                TranFromASCII();
            }

            if (rb2.Checked)
            {
                TranFrom2bit();
            }
            if (rb10.Checked)
            {
                TranFrom10bit();
            }
            if (rb16.Checked)
            {
                TranFrom16bit();
            }
        }


        /// <summary>
        /// 10進位轉....
        /// </summary>
        private void TranFrom10bit()
        {
            txtResult16.Text = DecStringToHexString(txtFromValue.Text);
            txtResult10.Text = txtFromValue.Text;
            txtResultASCII.Text = DecStringToASCII(txtFromValue.Text);
            txtResult2.Text = DecStringToBinaryString(txtFromValue.Text);
        }

        /// <summary>
        /// 2進位轉.....
        /// </summary>
        private void TranFrom2bit()
        {
            txtResult16.Text = BinaryStringToHexString(txtFromValue.Text);
            txtResult10.Text = BinaryStringToDecString(txtFromValue.Text);
            txtResultASCII.Text = BinaryStringToASCII(txtFromValue.Text);
            txtResult2.Text = txtFromValue.Text;
        }

        /// <summary>
        /// 16進位轉....
        /// </summary>
        private void TranFrom16bit()
        {
            txtResult16.Text = txtFromValue.Text;
            txtResult10.Text = HexstringToDecString(txtFromValue.Text);
            txtResultASCII.Text = HexstringToASCII(txtFromValue.Text);
            txtResult2.Text = HexstringToBinaryString(txtFromValue.Text);
        }


        /// <summary>
        /// ASCII 轉.......
        /// </summary>
        private void TranFromASCII()
        {
            txtResultASCII.Text = txtFromValue.Text;
            txtResult10.Text =  ASCIIToDecstring(txtFromValue.Text);
            txtResult2.Text = ASCIIToBinaryString(txtFromValue.Text);
            txtResult16.Text = ASCIIToHexString(txtFromValue.Text);


        }

    

      

        #region BinaryStringTo

        public string BinaryStringToHexString(string binary)
        {
            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

            // TODO: check all 1's or 0's... Will throw otherwise

            int mod4Len = binary.Length % 8;
            if (mod4Len != 0)
            {
                // pad to length multiple of 8
                binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < binary.Length; i += 8)
            {
                string eightBits = binary.Substring(i, 8);

                try
                {
                    byte tempbyte = Convert.ToByte(eightBits, 2);
                }
                catch (FormatException)
                {
                    Console.WriteLine("   '{0}' is not in the correct format for a base {1} byte value.",
                                      eightBits, 2);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("   '{0}' is outside the range of the Byte type.", eightBits);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("   '{0}' is invalid in base {1}.", eightBits, 2);
                }

                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }

            return result.ToString();
        }

        public string BinaryStringToDecString(string binary)
        {
            string tmepHex = BinaryStringToHexString(binary);

            //16 轉 10的轉法
            long n = Int64.Parse(tmepHex, System.Globalization.NumberStyles.HexNumber);
            string result = n.ToString();

            return result;
        }

        public string BinaryStringToASCII(string binary)
        {
            Byte[] arryByte = GetBytesFromBinaryString(binary);

            string result = Encoding.ASCII.GetString(arryByte);

            return result;
        }

        public Byte[] GetBytesFromBinaryString(String binary)
        {
            var list = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                String t = binary.Substring(i, 8);

                list.Add(Convert.ToByte(t, 2));
            }

            return list.ToArray();
        }



        #endregion BinaryStringTo

        #region DecStringTo

        public string DecStringToHexString(string Dec)
        {
            int d = Convert.ToInt32(Dec);
            string result = String.Format("{0:X2}", d);

            //Convert.ToString(d, 16);

            return result;
        }

        public string DecStringToBinaryString(string Dec)
        {
            int d = Convert.ToInt32(Dec);
            string Hexstring = String.Format("{0:X2}", d);    //X2的2代表若缺0會自動補0，所以沒有2也沒關係

            string result = String.Join(String.Empty,
  Hexstring.Select(
    c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
  )
);
            return result;
        }

        public string DecStringToASCII(string Dec)
        {
            Decimal d = Convert.ToDecimal(Dec);
            string result = Convert.ToString((char)d);
            return result;
        }

        #endregion 


        #region HexStringTo

        /// <summary>
        /// 16 TO 2
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        public string HexstringToBinaryString(string Hex) {       

            string result = String.Join(String.Empty,
  Hex.Select(
    c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
  )
);
            return result;

        }
        /// <summary>
        /// 16 TO 10
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        public string HexstringToDecString(string Hex)
        {
            //16 轉 10的轉法
            long n = Int64.Parse(Hex, System.Globalization.NumberStyles.HexNumber);
            string result = n.ToString();

            return result;

        }
        
        /// <summary>
        /// 16 TO ASCII
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        public string HexstringToASCII(string Hex)
        {
            string binary = String.Join(String.Empty,
Hex.Select(
  c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
)
);


            Byte[] arryByte = GetBytesFromBinaryString(binary);

            string result = Encoding.ASCII.GetString(arryByte);
            return result;
        }

        #endregion

        #region ASCIITo

        public string ASCIIToDecstring(string ASCII) {
            byte[] byteArray = System.Text.Encoding.ASCII.GetBytes(ASCII);

            string binary = string.Join("",
    byteArray.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));

            string tmepHex = BinaryStringToHexString(binary);

            ////16 轉 10的轉法
            long n = Int64.Parse(tmepHex, System.Globalization.NumberStyles.HexNumber);
            string result = n.ToString();

            return result;
        }


        private string ASCIIToBinaryString(string ASCII)
        {
            byte[] byteArray = System.Text.Encoding.ASCII.GetBytes(ASCII);

            string binary = string.Join("",
    byteArray.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));

            return binary;

        }

        private string ASCIIToHexString(string ASCII)
        {
            byte[] byteArray = System.Text.Encoding.ASCII.GetBytes(ASCII);

            string binary = string.Join("",
    byteArray.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));

            string tmepHex = BinaryStringToHexString(binary);



            return tmepHex;


        }

        #endregion
    }
}
namespace Roblox_Cookie_Generator
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cookieTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(10000000, 99999999);
            string cookie = "_|WARNING:-DO-NOT-SHARE-THIS.--Sharing-this-will-allow-someone-to-log-in-as-you-and-to-steal-your-ROBUX-and-items.|_" + randomNum.ToString() + "ABCDEFGHIJKLMNOPQRSTUVWXYZ0FE12C5E040D5B0C9D4C52758D170B431170ECAEED57E785274C52F0B42AABBC4B3C6DC96BF0B03AC8BBF54D6045BB0B65E9423701C666C89E2DC6078889CE5AC003253E2B3F5C3A2C7ABA3074185A475B56AF52CB355557D2817AF9C9D8FCD8C85EF1FD147C3A917D0A270BE77E923802E2DD24E32AD808AFB1EB8FB28136E191F3B91AE2D7B8C0772B7CB5BCBCF6F12D85C809DC91CC42FBE1D5C732477B37398A48182BB910592F4822501D7BACA0C989E3DD09EC0BB221C4783F035C9C42917DAE2B66C84C9A947B066C48D4BF45BE656BDB5446FDA0C6FF4FDF1DB3EB588E4E7B23C29F13A4FC8655934C893CA63E6F851F10FBB0CBE03EB15EE4429D8598FE51F129AFEC4DBEA5528CEC3E76B2F79F1FBE97FDFE57CAB073CFC44204F14C87C58600653B6EBFD04CA84EF94F5AE12B01972D195679BC18F1174766A623CB6C69A4A13627ACB4E6638FC5ABA8CC77417B19FF75C37AE9FD2986E2EF78C0F062DAD71D581ED4925E175996F76D74EB968F2B277E1FB0162678B10831AB7F9774B4D1";
            cookieTextBox.Text = cookie;

           
            File.WriteAllText("cookie.txt", cookie);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
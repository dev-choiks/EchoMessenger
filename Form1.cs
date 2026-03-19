namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //TextBox에 입력된 텍스트를 변수에 저장
            string typed_msg = txtInput.Text;

            //입력받은 문자열을 ListBox의 Items에 추가
            lstChat.Items.Add(typed_msg);

            //추가 직후 다음 입력을 준비하기 위해 TextBox의 내용을 비움
            txtInput.Clear();
        }

       
    }
}
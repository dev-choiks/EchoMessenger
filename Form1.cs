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
            // 공백만 있다면 더 이상 코드를 실행하지 않고 빠져나감
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                return;
            }

            //TextBox에 입력된 텍스트를 변수에 저장
            string typed_msg = txtInput.Text;

            //입력받은 문자열을 ListBox의 Items에 추가
            lstChat.Items.Add(typed_msg);

            //추가 직후 다음 입력을 준비하기 위해 TextBox의 내용을 비움
            txtInput.Clear();

            //텍스트 박스에 바로 입력할 수 있도록 포커스 설정
            txtInput.Focus();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
                e.Handled = true; // Enter 키 이벤트가 다른 곳으로 전달되지 않도록 처리
            }
        }

       
    }
}

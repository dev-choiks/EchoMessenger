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

            // 공백만 있다면 더 이상 코드를 실행하지 않고 빠져나감
            if (string.IsNullOrWhiteSpace(typed_msg))
            {
                return;
            }

            //앞뒤 불필요한 공백 제거
            typed_msg = typed_msg.Trim();

            //타임스탬프 문자열 결합 (현재 시간 추가)
            string timeStamp = DateTime.Now.ToString("HH:mm:ss");
            string final_msg = $"[{timeStamp}] {typed_msg}";

            //입력받은 문자열을 ListBox의 Items에 추가
            lstChat.Items.Add(final_msg);

            //실시간 메시지 카운팅하여 Label에 표시
            lblCount.Text = $"현재 대화: {lstChat.Items.Count}개";

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

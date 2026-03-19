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

            // 마지막 항목을 선택 상태로 만들어 자동으로 스크롤을 맨 밑으로 내림
            lstChat.SelectedIndex = lstChat.Items.Count - 1;
            lstChat.SelectedIndex = -1;

            //글자 수 50자 제한 검사 및 예외 처리
            if (typed_msg.Length > 50)
            {
                //더 이상 코드를 실행하지 않고 전송 차단
                MessageBox.Show("메시지는 50자를 초과할 수 없습니다.");
                return;
            }

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //예외 처리: ListBox에서 항목이 선택되어 있는지 확인
            if (lstChat.SelectedIndex != -1)
            {
                //선택된 위치의 인덱스 항목을 제거
                lstChat.Items.RemoveAt(lstChat.SelectedIndex);

                //삭제 후 줄어든 개수 업데이트
                lblCount.Text = $"현재 대화: {lstChat.Items.Count}개";
            }
            else
            {
                MessageBox.Show("삭제할 메시지를 먼저 선택해주세요.");
            }
        }

        private void btnAllDelete_Click(object sender, EventArgs e)
        {
            // ListBox의 모든 항목을 한 번에 비움
            lstChat.Items.Clear();

            //모두 삭제되었으므로 개수를 업데이트
            lblCount.Text = $"현재 대화: {lstChat.Items.Count}개";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = $"EchoMessenger";
        }

    
    }
}

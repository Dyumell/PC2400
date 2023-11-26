using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        StreamReader streamReader1;  // 데이타 읽기 위한 스트림리더
        StreamWriter streamWriter1;  // 데이타 쓰기 위한 스트림라이터    

        private void button1_Click(object sender, EventArgs e)  // '연결하기' 버튼이 클릭되면
        {
            Thread thread1 = new Thread(connect); // Thread 객채 생성, Form과는 별도 쓰레드에서 connect 함수가 실행됨.
            thread1.IsBackground = true; // Form이 종료되면 thread1도 종료.
            thread1.Start(); // thread1 시작.
        }

        private void connect()  // thread1에 연결된 함수. 메인폼과는 별도로 동작한다.
        {
            TcpListener tcpListener1 = new TcpListener(IPAddress.Parse(textBox1.Text), int.Parse(textBox2.Text)); // 서버 객체 생성 및 IP주소와 Port번호를 할당
            tcpListener1.Start();  // 서버 시작
            writeRichTextbox("서버 준비...클라이언트 기다리는 중...");

            TcpClient tcpClient1 = tcpListener1.AcceptTcpClient(); // 클라이언트 접속 확인
            writeRichTextbox("클라이언트 연결됨...");

            streamReader1 = new StreamReader(tcpClient1.GetStream());  // 읽기 스트림 연결
            streamWriter1 = new StreamWriter(tcpClient1.GetStream());  // 쓰기 스트림 연결
            streamWriter1.AutoFlush = true;  // 쓰기 버퍼 자동으로 뭔가 처리..

            while (tcpClient1.Connected)  // 클라이언트가 연결되어 있는 동안
            {
                string receiveData1 = streamReader1.ReadLine();  // 수신 데이타를 읽어서 receiveData1 변수에 저장
                writeRichTextbox(receiveData1); // 데이타를 수신창에 쓰기                  
            }
        }

        private void writeRichTextbox(string str)  // richTextbox1 에 쓰기 함수
        {
            richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.AppendText(str + "\r\n"); }); // 데이타를 수신창에 표시, 반드시 invoke 사용. 충돌피함.
            richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.ScrollToCaret(); });  // 스크롤을 젤 밑으로.
        }

        private void button2_Click(object sender, EventArgs e)  // '보내기' 버튼이 클릭되면
        {
            string sendData1 = textBox3.Text;  // testBox3 의 내용을 sendData1 변수에 저장
            streamWriter1.WriteLine(sendData1);  // 스트림라이터를 통해 데이타를 전송
        }
    }
}

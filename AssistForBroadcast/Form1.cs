using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistForBroadcast {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region Group 1

        // 測定の開始および終了
        private void button1_Click(object sender, EventArgs e) {

        }

        // 通知時間の編集および適用
        private void button2_Click(object sender, EventArgs e) {

        }

        // テキストファイルへの出力
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {

        }

        // Twitter への通知
        private void checkBox2_CheckedChanged(object sender, EventArgs e) {

        }

        // Twitch への通知
        private void checkBox3_CheckedChanged(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {

        }

        #endregion

        #region Group 2

        string Group2 = "現在時間";

        // 表示の開始および終了
        private void button4_Click(object sender, EventArgs e) {
            var start = "現在時間の表示を開始";
            var stop = "現在時間の表示を終了";
            if (button4.Text == start) {
                button4.Text = stop;
                timer2.Start();
            } else {
                button4.Text = start;
                timer2.Stop();
            }
        }

        // 通知時間の編集および適用
        private void button3_Click(object sender, EventArgs e) {

        }

        // テキストファイルへの出力
        private void checkBox6_CheckedChanged(object sender, EventArgs e) {

        }

        // Twitter への通知
        private void checkBox5_CheckedChanged(object sender, EventArgs e) {

        }

        // Twitch への通知
        private void checkBox4_CheckedChanged(object sender, EventArgs e) {

        }
        
        // 現在時間の表示
        private void timer2_Tick(object sender, EventArgs e) {
            var time = DateTime.Now.ToString("hh:mm:ss");
            textBox4.Text = time;
            if (checkBox6.Checked) {
                WriteInFile(time, Group2 + ".txt");
            }
        }

        #endregion

        #region Method

        // テキストファイルへの出力
        private void WriteInFile(string text, string file) {
            using (StreamWriter writer = new StreamWriter(file, false, Encoding.UTF8)) {
                writer.WriteLine(text);
            }
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using DFAParser.ParserModel;

namespace CipherCompilerLexicalAnalyzer
{
    public partial class MainForm : Form
    {
        List<string> lstNumTokens = new List<string>();
        List<string> lstIdTokens = new List<string>();
        List<string> lstBinOpTokens = new List<string>();
        List<string> lstUniOpTokens = new List<string>();
        List<string> lstResTokens = new List<string>();
        List<string> lstTerminatorTokens = new List<string>();
        List<string> lstPuncTokens = new List<string>();
        List<string> lstConsoleOpTokens = new List<string>();
        List<string> lsterrorText = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            progressBar.Hide();
            codeTxtBox.Hide();
        }
        void GetLines()
        {

            string path = @"D:\New folder\Tokens\input.txt";
            FileStream fStream = File.OpenRead(path);
            StreamReader reader = new StreamReader(fStream);
            string temp = reader.ReadToEnd();
            codeTxtBox.Lines = new string[] { temp };
            fStream.Close();
            reader.Close();

        }
        bool GenerateTokensToFile()
        {
            bool flag = false;
            //SaveFileDialog fileDialog = new SaveFileDialog();
            //fileDialog.Filter = "Text files (*.txt) | *.txt";
            string path = @"D:\New folder\Tokens\output.txt";
            //if (fileDialog.ShowDialog() == DialogResult.OK)
            //{

            FileStream fStream = File.OpenWrite(path);
            StreamWriter writer = new StreamWriter(fStream);
            foreach (var item in lstIdTokens)
            {
                writer.WriteLine("<id," + item + ">");
            }
            foreach (var item in lstNumTokens)
            {
                writer.WriteLine("<num," + item + ">");
            }
            foreach (var item in lstBinOpTokens)
            {
                writer.WriteLine("<op," + item + ">");
            }
            foreach (var item in lstUniOpTokens)
            {
                writer.WriteLine("<op," + item + ">");
            }
            foreach (var item in lstTerminatorTokens)
            {
                writer.WriteLine("<op," + item + ">");
            }
            foreach (var item in lstPuncTokens)
            {
                writer.WriteLine("<op," + item + ">");
            }
            foreach (var item in lstResTokens)
            {
                writer.WriteLine("<key," + item + ">");
            }
            foreach (var item in lstConsoleOpTokens)
            {
                writer.WriteLine("<key," + item + ">");
            }
            writer.Close();
            fStream.Close();
            flag = true;
            //}
            return flag;
        }
        void AddIdentifierTokens()
        {
            IdentifierParser ip = new IdentifierParser();
            foreach (var item in codeTxtBox.Lines)
            {
                lstIdTokens = ip.GenerateTokens(item);
            }
        }
        void AddNumericTokens()
        {
            NumericParser np = new NumericParser();
            foreach (var item in codeTxtBox.Lines)
            {
                lstIdTokens = np.GenerateTokens(item);
            }
        }
        void AddStringTokens()
        {
            StringParser sp = new StringParser();
            foreach (var item in codeTxtBox.Lines)
            {
                lstIdTokens = sp.GenerateTokens(item);
            }
        }
        void AddTerminatorTokens()
        {
            TerminatorOpParser tp = new TerminatorOpParser();
            foreach (var item in codeTxtBox.Lines)
            {
                lstIdTokens = tp.GenerateTokens(item);
            }
        }
        void AddPunctuationTokens()
        {
            PunctuationOpParser pp = new PunctuationOpParser();
            foreach (var item in codeTxtBox.Lines)
            {
                lstIdTokens = pp.GenerateTokens(item);
            }
        }
        void AddConsoleOpTokens()
        {
            ConsoleOpParser cp = new ConsoleOpParser();
            foreach (var item in codeTxtBox.Lines)
            {
                lstIdTokens = cp.GenerateTokens(item);
            }
        }
        void AddBinaryOpTokens()
        {
            BinaryOpParser bp = new BinaryOpParser();
            foreach (var item in codeTxtBox.Lines)
            {
                lstIdTokens = bp.GenerateTokens(item);
            }
        }
        void AddUninaryOpTokens()
        {
            UninaryOpParser up = new UninaryOpParser();
            foreach (var item in codeTxtBox.Lines)
            {
                lstIdTokens = up.GenerateTokens(item);
            }
        }
        void AddReserveWordTokens()
        {
            ReserveWordParser rp = new ReserveWordParser();
            foreach (var item in codeTxtBox.Lines)
            {
                lstIdTokens = rp.GenerateTokens(item);
            }
        }

        private void btnGenerateTokens_Click(object sender, EventArgs e)
        {
            try
            {
                GetLines();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            if (codeTxtBox.Lines.Length != 0)
            {
                btnClear_Click(sender, e);
                progressBar.Show();
                try
                {
                    CodeTokenizer(codeTxtBox.Lines);
                    if (GenerateTokensToFile())
                        MessageBox.Show("Tokens Added to the file successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                progressBar.Hide();
            }
            else
            {
                MessageBox.Show("Nothing is written in the input code file.", "Proccess Terminated", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        void CodeTokenizer(string[] codeLines)
        {
            try
            {
                NumericParser np = new NumericParser();
                IdentifierParser ip = new IdentifierParser();
                BinaryOpParser bp = new BinaryOpParser();
                UninaryOpParser up = new UninaryOpParser();
                ReserveWordParser rp = new ReserveWordParser();
                TerminatorOpParser tp = new TerminatorOpParser();
                PunctuationOpParser pp = new PunctuationOpParser();
                ConsoleOpParser cp = new ConsoleOpParser();
                foreach (var item in codeLines)
                {
                    lstBinOpTokens = bp.GenerateTokens(item);
                    lstConsoleOpTokens = cp.GenerateTokens(item);
                    lstIdTokens = ip.GenerateTokens(item);
                    lstNumTokens = np.GenerateTokens(item);
                    lstPuncTokens = pp.GenerateTokens(item);
                    lstResTokens = rp.GenerateTokens(item);
                    lstTerminatorTokens = tp.GenerateTokens(item);
                    lstUniOpTokens = up.GenerateTokens(item);
                }
            }
            catch (Exception ex)
            {
                lsterrorText.Add(">" + ex.Message);
            }
            try
            {
                foreach (var item in lstUniOpTokens)
                {
                    unLstView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                lsterrorText.Add(">" + ex.Message);
            }
            try
            {
                foreach (var item in lstTerminatorTokens)
                {
                    TerminatorLstView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                lsterrorText.Add(">" + ex.Message);
            }
            try
            {
                foreach (var item in lstResTokens)
                {
                    resLstView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                lsterrorText.Add(">" + ex.Message);
            }
            try
            {
                foreach (var item in lstPuncTokens)
                {
                    PuncLstView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                lsterrorText.Add(">" + ex.Message);
            }
            try
            {
                foreach (var item in lstNumTokens)
                {
                    numLstView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                lsterrorText.Add(">" + ex.Message);
            }
            try
            {
                foreach (var item in lstIdTokens)
                {
                    idLstView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                lsterrorText.Add(">" + ex.Message);
            }
            try
            {
                foreach (var item in lstConsoleOpTokens)
                {
                    conLstView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                lsterrorText.Add(">" + ex.Message);
            }
            try
            {
                foreach (var item in lstBinOpTokens)
                {
                    binlstView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                lsterrorText.Add(">" + ex.Message);
            }
            richTextBox1.Lines = lsterrorText.ToArray();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstNumTokens = new List<string>();
            lstIdTokens = new List<string>();
            lstBinOpTokens = new List<string>();
            lstUniOpTokens = new List<string>();
            lstResTokens = new List<string>();
            lstTerminatorTokens = new List<string>();
            lstPuncTokens = new List<string>();
            lstConsoleOpTokens = new List<string>();
            lsterrorText = new List<string>();
            numLstView.Clear();
            idLstView.Clear();
            binlstView.Clear();
            unLstView.Clear();
            resLstView.Clear();
            TerminatorLstView.Clear();
            PuncLstView.Clear();
            conLstView.Clear();
        }
    }
}

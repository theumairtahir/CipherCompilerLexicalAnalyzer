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
        List<string> lstStringTokens = new List<string>();
        List<string> lstTerminatorTokens = new List<string>();
        List<string> lstPuncTokens = new List<string>();
        List<string> lstConsoleOpTokens = new List<string>();
        List<string> lsterrorText = new List<string>();
        public MainForm()
        {
            InitializeComponent();
        }
        void GenerateTokensToFile()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Tokens\";
            Directory.CreateDirectory(path);
            path += DateTime.Now.ToString("dd_MMMM_yy hhmmss") + ".txt";
            FileStream fStream = File.OpenWrite(path);
            StreamWriter writer = new StreamWriter(fStream);
            writer.WriteLine("Identifiers: ");
            foreach (var item in lstIdTokens)
            {
                writer.WriteLine(item);
            }
            writer.WriteLine("Numerics: ");
            foreach (var item in lstNumTokens)
            {
                writer.WriteLine(item);
            }
            writer.WriteLine("Strings: ");
            foreach (var item in lstStringTokens)
            {
                writer.WriteLine(item);
            }
            writer.WriteLine("Binary Operators: ");
            foreach (var item in lstBinOpTokens)
            {
                writer.WriteLine(item);
            }
            writer.WriteLine("Uninary Operators: ");
            foreach (var item in lstUniOpTokens)
            {
                writer.WriteLine(item);
            }
            writer.WriteLine("Terminators: ");
            foreach (var item in lstTerminatorTokens)
            {
                writer.WriteLine(item);
            }
            writer.WriteLine("Punctuations: ");
            foreach (var item in lstPuncTokens)
            {
                writer.WriteLine(item);
            }
            writer.WriteLine("Reserve Words: ");
            foreach (var item in lstResTokens)
            {
                writer.WriteLine(item);
            }
            writer.WriteLine("Console Operators: ");
            foreach (var item in lstConsoleOpTokens)
            {
                writer.WriteLine(item);
            }
            writer.Close();
            fStream.Close();
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
                CodeTokenizer(codeTxtBox.Lines);
                GenerateTokensToFile();
                MessageBox.Show("Tokens Added to the file successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            lstNumTokens = new List<string>();
            lstIdTokens = new List<string>();
            lstBinOpTokens = new List<string>();
            lstUniOpTokens = new List<string>();
            lstResTokens = new List<string>();
            lstStringTokens = new List<string>();
            lstTerminatorTokens = new List<string>();
            lstPuncTokens = new List<string>();
            lstConsoleOpTokens = new List<string>();
            lsterrorText = new List<string>();
        }
        void CodeTokenizer(string[] codeLines)
        {
            try
            {
                NumericParser np = new NumericParser();
                StringParser sp = new StringParser();
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
                    lstStringTokens = sp.GenerateTokens(item);
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
                foreach (var item in lstStringTokens)
                {
                    stringLstView.Items.Add(item);
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

    }
}

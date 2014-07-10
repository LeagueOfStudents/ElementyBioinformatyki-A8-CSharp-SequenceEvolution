using SequenceEvolution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    /*
     * 
            int mode = 2;
            try
            {
                float transitionRate = 0.3f;
                float transversionRate = 0.2f;
                //Sequence human = new Sequence("TGGTCCTGCTGTCCTCTCCTGGCGCCCTGGGCGCGAGCGGATGT");
                //Sequence chimpansee = new Sequence("TGATCCTGCAGTCCTTGGGCGCGACTGGGCGCGTGCGGTTGTCC");
                Sequence human =        new Sequence("TGGTCCTGCTGTCCTCTCCTGGCGCCCTGGGCGCGAGCGGATGT");
                Sequence chimpansee =   new Sequence("TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT");
            Console.WriteLine("PART 1");
                double time = DnaEvolution.ComputeMostPropTime(aSeq: human, bSeq: chimpansee, alpha: transitionRate, beta: transversionRate);
                Console.WriteLine(time);
            Console.WriteLine("PART 2");
                double inputTime = time;
                Sequence inputSequence = human;
                Console.WriteLine(inputSequence);
                for (int i = 0; i < 10; i++)
                {
                    Sequence outputSequence = DnaEvolution.ComputeMostPropabSequenceAfterTime(inputSequence, inputTime, transitionRate, transversionRate, null);
                    Console.WriteLine(outputSequence);
                }
                Console.WriteLine("- should: - be licke -");
                Console.WriteLine(chimpansee);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.ReadKey();
            }
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_computeTime_Click(object sender, EventArgs e)
        {
            tbx_output.Clear();
            try
            {
                Sequence seqA = new Sequence(tbx_A.Text.ToLower());
                Sequence seqB = new Sequence(tbx_B.Text.ToLower());
                double transitionRate = (double)numeric_alpha.Value;
                double transversionRate = (double)numeric_beta.Value;
                double time = DnaEvolution.ComputeMostPropTime(aSeq: seqA, bSeq: seqB, alpha: transitionRate, beta: transversionRate);
                tbx_output.Text = "most probable time: = " + time.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btn_ProbableSequence_Click(object sender, EventArgs e)
        {
            tbx_output.Clear();
            try
            {
                double inputTime = (double)numericUpDown1.Value;
                Sequence inputSequence = new Sequence(tbx_A.Text);
                double transitionRate = (double)numeric_alpha.Value;
                double transversionRate = (double)numeric_beta.Value;
                Sequence outputSequence = DnaEvolution.ComputeMostPropabSequenceAfterTime(inputSequence, inputTime, transitionRate, transversionRate, null);
                tbx_output.Text = " = " + outputSequence.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbx_A.Text = "TGGTCCTGCTGTCCTCTCCTGGCGCCCTGGGCGCGAGCGGATGT";
            tbx_B.Text = "TGATCCTGCAGTCCTTGGGCGCGACTGGGCGCGTGCGGTTGTCC";
            numeric_alpha.Value = 0.3M;
            numeric_beta.Value = 0.2M;
        }
    }
}

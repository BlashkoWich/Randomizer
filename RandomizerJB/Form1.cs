using System;
using System.Windows.Forms;
using RandomizerJB.Randoms;

namespace RandomizerJB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SwitchGeneratorType(GeneratorType.Fibonacci);
        }

        private void FibonacciCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SwitchGeneratorType(GeneratorType.Fibonacci);
        }

        private void MiddleSquareCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SwitchGeneratorType(GeneratorType.MiddleSquare);
        }

        private void LinearCongruentialCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SwitchGeneratorType(GeneratorType.LinearCongruent);
        }

        private void SwitchGeneratorType(GeneratorType generatorType)
        {
            var isFibo = generatorType == GeneratorType.Fibonacci;
            FibonacciCheckBox.Checked = isFibo;

            var isMiddle = generatorType == GeneratorType.MiddleSquare;
            MiddleSquareCheckBox.Checked = isMiddle;

            var isLinear = generatorType == GeneratorType.LinearCongruent;
            LinearCongruentialCheckBox.Checked = isLinear;

            Config.GeneratorType = generatorType;
        }

        private string previousEndNumber = string.Empty;
        private void EndNumber_TextChanged(object sender, EventArgs e)
        {
            var tryParse = int.TryParse(EndNumber.Text, out var value);
            if (tryParse)
            {
                Config.MaxNumber = value;
                previousEndNumber = EndNumber.Text;
            }
            else
            {
                EndNumber.Text = previousEndNumber;
            }
        }

        private string previousStartNumber = string.Empty;
        private void StartNumber_TextChanged(object sender, EventArgs e)
        {
            var tryParse = int.TryParse(StartNumber.Text, out var value);
            if (tryParse)
            {
                Config.StartNumber = value;
                previousStartNumber = StartNumber.Text;
            }
            else
            {
                StartNumber.Text = previousStartNumber;
            }
        }

        private string previousResultCountNumber = string.Empty;
        private void ResultCountInput_TextChanged(object sender, EventArgs e)
        {
            var tryParse = int.TryParse(ResultCountInput.Text, out var value);
            if (tryParse)
            {
                Config.ResultCount = value;
                previousResultCountNumber = ResultCountInput.Text;
            }
            else
            {
                ResultCountInput.Text = previousResultCountNumber;
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            var generate = GeneratorStore.Generate(
                Config.GeneratorType,
                Config.StartNumber,
                Config.MaxNumber,
                Config.ResultCount);

            var result = string.Empty;
            foreach (var res in generate)
            {
                result += res + Environment.NewLine;
            }

            ResultText.Text = result;
        }
    }
}
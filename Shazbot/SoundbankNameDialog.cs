using System.Windows.Forms;

namespace Shazbot
{
    public partial class SoundbankNameDialog : Form
    {
        public string SoundbankName => textBoxName.Text;

        private bool _accepted;

        public SoundbankNameDialog(string initialName = "")
        {
            InitializeComponent();
            textBoxName.Text = initialName;
            textBoxName.SelectAll();
            _accepted = false;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            _accepted = true;
            Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void SoundbankNameDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = _accepted ? DialogResult.OK : DialogResult.Cancel;
        }
    }
}

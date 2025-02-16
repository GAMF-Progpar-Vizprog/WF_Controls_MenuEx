namespace Menu
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
		{
			MessageBox.Show("Dropdown menu being opened");
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Meni item New selected");
		}
	}
}
using System.Windows.Forms;

namespace tasker
{
    public class FormBase : Form
    {
        protected DataBase dataBase = new DataBase();

        public FormBase()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormBase
            // 
            this.ClientSize = new System.Drawing.Size(282, 256);
            this.Name = "FormBase";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.ResumeLayout(false);

        }

        private void FormBase_Load(object sender, System.EventArgs e)
        {

        }
    }
}

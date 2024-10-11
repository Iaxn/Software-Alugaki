namespace PrimeiroApp
{
    partial class PaginaRemover
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbAlugueis = new ComboBox();
            btexcluircad = new Button();
            SuspendLayout();
            // 
            // cbAlugueis
            // 
            cbAlugueis.FormattingEnabled = true;
            cbAlugueis.Location = new Point(359, 155);
            cbAlugueis.Name = "cbAlugueis";
            cbAlugueis.Size = new Size(267, 23);
            cbAlugueis.TabIndex = 0;
            // 
            // btexcluircad
            // 
            btexcluircad.Location = new Point(452, 193);
            btexcluircad.Name = "btexcluircad";
            btexcluircad.Size = new Size(75, 23);
            btexcluircad.TabIndex = 1;
            btexcluircad.Text = "button1";
            btexcluircad.UseVisualStyleBackColor = true;
            btexcluircad.Click += btexcluircad_Click_1;
            // 
            // PaginaRemover
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 549);
            Controls.Add(btexcluircad);
            Controls.Add(cbAlugueis);
            Name = "PaginaRemover";
            Text = "PaginaRemover";
            Load += PaginaRemover_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbAlugueis;
        private Button btexcluircad;
    }
}
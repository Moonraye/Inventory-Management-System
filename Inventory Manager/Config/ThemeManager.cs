using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public static class ThemeManager
    {
        // Палітра "Dark Old Money"
        public static readonly Color BgMain = Color.FromArgb(22, 22, 22);      // Глибокий чорний
        public static readonly Color BgSidebar = Color.FromArgb(30, 30, 30);   // Графітовий для панелей
        public static readonly Color AccentGold = Color.FromArgb(174, 153, 117); // Бронза/Золото для акцентів
        public static readonly Color TextPrimary = Color.FromArgb(230, 230, 230); // М'який білий
        public static readonly Color TextSecondary = Color.FromArgb(150, 150, 150); // Сірий для описів

        public static void ApplyTheme(Form form)
        {
            form.BackColor = BgMain;
            form.ForeColor = TextPrimary;
            form.Font = new Font("Segoe UI", 10);

            ApplyToControls(form.Controls);
        }

        private static void ApplyToControls(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is Button btn) StyleButton(btn);
                else if (c is TextBox txt) StyleTextBox(txt);
                else if (c is DataGridView grid) StyleGrid(grid);
                else if (c is Label lbl) StyleLabel(lbl);
                else if (c is Panel p) p.BackColor = Color.Transparent;

                if (c.HasChildren) ApplyToControls(c.Controls);
            }
        }

        private static void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = AccentGold;
            btn.BackColor = BgSidebar;
            btn.ForeColor = AccentGold;
            btn.Cursor = Cursors.Hand;
            btn.Padding = new Padding(10, 5, 10, 5);
            btn.Font = new Font("Segoe UI Semibold", 9F);
        }

        private static void StyleTextBox(TextBox txt)
        {
            txt.BackColor = BgSidebar;
            txt.ForeColor = TextPrimary;
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Padding = new Padding(5);
        }

        private static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = BgMain;
            grid.BorderStyle = BorderStyle.None;
            grid.EnableHeadersVisualStyles = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.RowHeadersVisible = false;
            grid.GridColor = Color.FromArgb(40, 40, 40);

            grid.ColumnHeadersDefaultCellStyle.BackColor = BgSidebar;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = AccentGold;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = BgSidebar;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            grid.DefaultCellStyle.BackColor = BgMain;
            grid.DefaultCellStyle.ForeColor = TextPrimary;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 50, 50);
            grid.DefaultCellStyle.SelectionForeColor = AccentGold;
        }

        private static void StyleLabel(Label lbl)
        {
            if (lbl.Tag?.ToString() == "Header")
            {
                lbl.Font = new Font("Georgia", 18, FontStyle.Italic);
                lbl.ForeColor = AccentGold;
            }
            else
            {
                lbl.ForeColor = TextSecondary;
            }
        }
    }
}
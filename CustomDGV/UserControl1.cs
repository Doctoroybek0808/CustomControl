using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDGV
{
    [ToolboxItem(false)]
    public class PopupEditor : ToolStripDropDown
    {
        #region Declaration(s)
        private ToolStripControlHost _host;
        #endregion

        #region Constructor
        public PopupEditor(Control content)
        {
            if (content == null)
            {
                throw new ArgumentNullException("content");
            }
            Content = content;
            AutoSize = false;
            DoubleBuffered = true;
            ResizeRedraw = true;
            _host = new ToolStripControlHost(content);
            Padding = Margin = _host.Padding = _host.Margin = Padding.Empty;
            content.Margin = Padding.Empty;
            MinimumSize = content.MinimumSize;
            content.MinimumSize = content.Size;
            MaximumSize = content.MaximumSize;
            Size = content.Size;
            _host.Size = content.Size;
            TabStop = content.TabStop = true;
            content.Location = Point.Empty;
            Items.Add(_host);
            content.Disposed += (sender, e) =>
            {
                content = null;
                Dispose(true);
            };
            content.RegionChanged += (sender, e) => UpdateRegion();
            UpdateRegion();
        }
        #endregion

        #region Properties
        public Control Content { get; private set; }
        #endregion

        #region Private Methods
        /// <summary>
        /// Updates the pop-up region.
        /// </summary>
        private void UpdateRegion()
        {
            if (Region != null)
            {
                Region.Dispose();
                Region = null;
            }
            if (Content.Region != null)
            {
                Region = Content.Region.Clone();
            }
        }

        private void Show(Control control, Rectangle area)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }

            Point location = control.PointToScreen(new Point(area.Left, area.Top + area.Height));
            Rectangle screen = Screen.FromControl(control).WorkingArea;
            if (location.X + Size.Width > (screen.Left + screen.Width))
            {
                location.X = (screen.Left + screen.Width) - Size.Width;
            }
            if (location.Y + Size.Height > (screen.Top + screen.Height))
            {
                location.Y -= Size.Height + area.Height;
            }
            location = new Point(location.X, location.Y - 5);
            location = control.PointToClient(location);
            Show(control, location, ToolStripDropDownDirection.BelowRight);
        }

        private void Show(Rectangle area)
        {
            Point location = new Point(area.Left, area.Top + area.Height);
            Rectangle screen = Screen.FromControl(this).WorkingArea;
            if (location.X + Size.Width > (screen.Left + screen.Width))
            {
                location.X = (screen.Left + screen.Width) - Size.Width;
            }
            if (location.Y + Size.Height > (screen.Top + screen.Height))
            {
                location.Y -= Size.Height + area.Height;
            }
            Show(location, ToolStripDropDownDirection.BelowRight);
        }
        #endregion

        #region Public Methods
        public void Show(Control control)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }
            Show(control, control.ClientRectangle);
        }
        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
    public partial class UserControl1 : UserControl
    {
        private Frm1 frm;
        private MyCalendar cal;
        public PopupEditor popup;
        public UserControl1()
        {
            InitializeComponent();
            frm = new Frm1();
            cal = new MyCalendar();
            cal.Location = new Point(textBox1.Location.X, textBox1.Location.Y + textBox1.Height + 10);
            
            popup = new PopupEditor(cal);
            
            popup.AutoClose = false;
        }
        #region Properties
        [Description("Test text displayed in the textbox"), Category("Data")]
        public DataTable dataSource { get => (DataTable)this.frm.dataGridView1.DataSource; set => this.frm.dataGridView1.DataSource = value; }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            if (popup.Visible)
            {
                popup.Close();
            }
            else
            {
                popup.Location = new Point(textBox1.Location.X, textBox1.Location.Y);
                popup.Show(this);
            }
            
        }
    }
}